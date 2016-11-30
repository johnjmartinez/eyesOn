using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Hardware.Camera2;
using Android.Graphics;
using Android.Hardware.Camera2.Params;
using Android.Media;
using Android.Runtime;
using Android.Preferences;
//using Android.Support.V13.App;
//using Android.Support.V4.Content;

using Java.IO;
using Java.Lang;
using Java.Util;
using Java.Util.Concurrent;

using Boolean = Java.Lang.Boolean;
using Math = Java.Lang.Math;
using Orientation = Android.Content.Res.Orientation;

using Emgu.CV;
//using Emgu.CV.Structure;
using Emgu.Util;

//using OpenCV.Core;
//using OpenCV.ObjDetect;
//using OpenCV.Android;
//using OpenCV.ImgProc;
//using Size = OpenCV.Core.Size;

using EyesOn.UI.Droid.Utilities;
using EyesOn.UI.Droid.ColorBlobDetection;
using EyesOn.UI.Droid.TakePhoto.Listeners;

namespace EyesOn.UI.Droid.TakePhoto
{
    [Activity(Label = "Take Photo 4", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class TakePhotoActivity4 : Activity, ISurfaceHolderCallback
    {
        float L, T, R, B;
        float screenX;
        float screenY;
        string eyeXml;
        string faceXml;
        private static readonly string TAG = "\t\tTakePhotoActivity4";

        public TakePhotoActivity4()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //opencv preferences
            AppPreference appPreference = new AppPreference();
            CvInvoke.UseOpenCL = false; // appPreference.UseOpenCL;
            System.String oclDeviceName = appPreference.OpenClDeviceName;
            if (!System.String.IsNullOrEmpty(oclDeviceName))
            {
                Log.Error(TAG, "\t\t --OclSetDefaultDevice: " + oclDeviceName);
                CvInvoke.OclSetDefaultDevice(oclDeviceName);
            }

            ISharedPreferences preference = PreferenceManager.GetDefaultSharedPreferences(ApplicationContext);
            System.String appVersion = PackageManager.GetPackageInfo(PackageName, Android.Content.PM.PackageInfoFlags.Activities).VersionName;
            if (!preference.Contains("cascade-data-version") || !preference.GetString("cascade-data-version", null).Equals(appVersion)
               || !(preference.Contains("cascade-eye-data-path") || preference.Contains("cascade-face-data-path")))
            {
                AndroidFileAsset.OverwriteMethod overwriteMethod = AndroidFileAsset.OverwriteMethod.AlwaysOverwrite;

                FileInfo eyeFile = AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_eye.xml", "cascade", overwriteMethod);
                FileInfo faceFile = AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_frontalface_default.xml", "cascade", overwriteMethod);

                Log.Error(TAG, "\t\t --eyeFile.FullName: " + eyeFile.FullName);
                Log.Error(TAG, "\t\t --faceFile.FullName: " + faceFile.FullName);

                //save tesseract data path
                ISharedPreferencesEditor editor = preference.Edit();
                editor.PutString("cascade-data-version", appVersion);
                editor.PutString("cascade-eye-data-path", eyeFile.FullName);
                editor.PutString("cascade-face-data-path", faceFile.FullName);
                editor.Commit();
            }

            eyeXml = preference.GetString("cascade-eye-data-path", null);
            faceXml = preference.GetString("cascade-face-data-path", null);

            Log.Error(TAG, "\t\t --eyeXml: " + eyeXml);
            Log.Error(TAG, "\t\t --faceXml: " + faceXml);

            // Hide the window title and go fullscreen.
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen);

            SetContentView(Resource.Layout.take_photo_surface_view);
            //SurfaceView mSV = (SurfaceView)FindViewById(Resource.Id.CameraView);
            //mTextureView = (AutoFitTextureView)FindViewById(Resource.Id.CameraView);
            mTransparentView = (SurfaceView)FindViewById(Resource.Id.TransparentView);

            mTransparentView.SetZOrderOnTop(true);
            mTransparentView.BringToFront();

            mTransparentView.Holder.SetFormat(Android.Graphics.Format.Transparent);
            mTransparentView.Holder.AddCallback(this);

            var manager = GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            var size = new Android.Graphics.Point();
            manager.DefaultDisplay.GetSize(size);

            screenX = size.X / 2;
            screenY = size.Y / 2;

            L = screenX - 100;
            T = screenY - 100;
            R = screenX + 100;
            B = screenY + 100;           
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        //for drawing
        private SurfaceView mTransparentView;

        private void DrawFocusRect(ISurfaceHolder holder, float RectLeft, float RectTop, float RectRight, float RectBottom, Android.Graphics.Color color)
        {

            //lock
            var canvas = holder.LockCanvas();

            //no pointer to canvas?
            if (canvas == null) return;

            //detect face
            FaceEyes FE = Detect();

            //clear out
            canvas.DrawColor(Android.Graphics.Color.Transparent, Android.Graphics.PorterDuff.Mode.Clear);

            //border's properties
            var paint = new Android.Graphics.Paint();
            paint.SetStyle(Android.Graphics.Paint.Style.Stroke);
            paint.Color = color;
            paint.StrokeWidth = 3;

            Rectangle e0 = FE.Eyes[0];
            Rectangle e1 = FE.Eyes[1];
            Rectangle f0 = FE.Faces[0];

            canvas.DrawRect( new Rect(e0.Left, e0.Top, e0.Right, e0.Bottom), paint);
            canvas.DrawRect( new Rect(e1.Left, e1.Top, e1.Right, e1.Bottom), paint);
            paint.Color = Android.Graphics.Color.White;
            canvas.DrawRect(new Rect(f0.Left, f0.Top, f0.Right, f0.Bottom), paint);

            //unlock
            holder.UnlockCanvasAndPost(canvas);
        }

        private class FaceEyes
        {
            public List<Rectangle> Faces { get; set; } = new List<Rectangle>();
            public List<Rectangle> Eyes  { get; set; } = new List<Rectangle>();

            public int Count
            {
                get
                {
                    return Faces.Count + Eyes.Count;
                }
            }
        }

        //private FaceEyes Detect(byte [] imageBytes)
        private FaceEyes Detect()
        {
            FaceEyes FE = new FaceEyes();

            Mat image = new Mat(Assets, "lena.jpg");

            using (CascadeClassifier face = new CascadeClassifier(faceXml))
            using (CascadeClassifier eye = new CascadeClassifier(eyeXml))
            {
                //watch = Stopwatch.StartNew();

                using (UMat ugray = new UMat())
                {
                    CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                    //normalizes brightness and increases contrast of the image
                    CvInvoke.EqualizeHist(ugray, ugray);

                    //Detect the faces  from the gray scale image and store the locations as rectangle
                    //The first dimensional is the channel
                    //The second dimension is the index of the rectangle in the specific channel
                    Rectangle[] facesDetected = face.DetectMultiScale(
                       ugray,
                       1.1,
                       10,
                       new System.Drawing.Size(20, 20));

                    FE.Faces.AddRange(facesDetected);

                    foreach (Rectangle f in facesDetected)
                    {
                        //Get the region of interest on the faces
                        using (UMat faceRegion = new UMat(ugray, f))
                        {
                            Rectangle[] eyesDetected = eye.DetectMultiScale(
                               faceRegion,
                               1.1,
                               10,
                               new System.Drawing.Size(20, 20));

                            foreach (Rectangle e in eyesDetected)
                            {
                                Rectangle eyeRect = e;
                                eyeRect.Offset(f.X, f.Y);
                                FE.Eyes.Add(eyeRect);
                            }
                        }
                    }
                }

                //watch.Stop();
            }

            return FE;
        }

        #region ISurfaceHolderCallback

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            // The Surface has been created, acquire the camera and tell it where
            // to draw.
            try
            {
                if (mTransparentView.Holder == holder)
                {
                    DrawFocusRect(holder, L, T, R, B, Android.Graphics.Color.Yellow);
                }                
            }
            catch (Java.IO.IOException exception)
            {
                Log.Error("TAG", "IOException caused by setPreviewDisplay()", exception);
            }
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            // Surface will be destroyed when we return, so stop the preview.
            //if (PreviewCamera != null)
            //{
            //    PreviewCamera.StopPreview();
            //}
        }

        public void SurfaceChanged(ISurfaceHolder holder, Android.Graphics.Format format, int w, int h)
        {
            // Now that the size is known, set up the camera parameters and begin
            // the preview.
            if (mTransparentView.Holder == holder)
            {
                DrawFocusRect(holder, L, T, R, B, Android.Graphics.Color.Yellow);
            }           
        }

        #endregion        
    }
}