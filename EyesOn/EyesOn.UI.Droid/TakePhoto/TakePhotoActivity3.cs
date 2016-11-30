//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.IO;
//using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

//using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Views;
//using Android.Widget;
using Android.Hardware.Camera2;
using Android.Graphics;
using Android.Hardware.Camera2.Params;
using Android.Media;
using Android.Runtime;
using Android.Preferences;
//using Android.Provider;
//using Android.Support.V13.App;
//using Android.Support.V4.Content;


//using Java.IO;
using Java.Lang;
using Java.Util;
//using Java.Util.Concurrent;

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

//using Java.IO;
//using Java.Lang;

//using EyesOn.UI.Droid.Utilities;
//using EyesOn.UI.Droid.ColorBlobDetection;
using EyesOn.UI.Droid.TakePhoto.Listeners;

//using OpenCV.Core;
//using OpenCV.ImgProc;
using Mat = Emgu.CV.Mat;
//using Point = OpenCV.Core.Point;

namespace EyesOn.UI.Droid.TakePhoto
{
    [Activity(Label = "Take Photo 3", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class TakePhotoActivity3 : Activity, ISurfaceHolderCallback
    {

        float L, T, R, B;
        float screenX;
        float screenY;
        string eyeXml;
        string faceXml;
        Android.Graphics.Color COLOR = Android.Graphics.Color.Green;
        FaceEyes RESULTS = null;
        public bool CLEAR_CANVAS = true;
        public Java.IO.File mFile;

        CascadeClassifier face = null;
        CascadeClassifier eye = null;

        public TakePhotoActivity3()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AppPreference appPreference = new AppPreference();
            CvInvoke.UseOpenCL = false;  //appPreference.UseOpenCL;
            string oclDeviceName = appPreference.OpenClDeviceName;
            if (!string.IsNullOrEmpty(oclDeviceName))
            {
                CvInvoke.OclSetDefaultDevice(oclDeviceName);
                Log.Error(TAG, "\t\t --OclSetDefaultDevice: " + oclDeviceName);
            }

            mFile = new Java.IO.File(GetExternalFilesDir(null), "derp.jpg");

            ISharedPreferences preference = PreferenceManager.GetDefaultSharedPreferences(ApplicationContext);
            string appVersion = PackageManager.GetPackageInfo(PackageName, Android.Content.PM.PackageInfoFlags.Activities).VersionName;
            if (!preference.Contains("cascade-data-version") || !preference.GetString("cascade-data-version", null).Equals(appVersion)
               || !(preference.Contains("cascade-eye-data-path") || preference.Contains("cascade-face-data-path")))
            {
                AndroidFileAsset.OverwriteMethod overwriteMethod = AndroidFileAsset.OverwriteMethod.AlwaysOverwrite;

                FileInfo eyeFile = AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_eye.xml", "cascade", overwriteMethod);
                FileInfo faceFile = AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_frontalface_alt_tree.xml", "cascade", overwriteMethod);

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

            //face = new CascadeClassifier(faceXml);
            //eye = new CascadeClassifier(eyeXml);

            // Hide the window title and go fullscreen.
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen);

            SetContentView(Resource.Layout.take_photo_surface_view);
            mTextureView = (AutoFitTextureView)FindViewById(Resource.Id.CameraView);
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

            L = screenX - 200;
            T = screenY - 200;
            R = screenX + 200;
            B = screenY + 200;

            mStateCallback = new CameraStateListener() { owner = this };
            mSurfaceTextureListener = new Camera2BasicSurfaceTextureListener(this);
            mOnImageAvailableListener = new ImageAvailableListener() { Owner = this };

            // fill ORIENTATIONS list
            ORIENTATIONS.Append((int)SurfaceOrientation.Rotation0, 90);
            ORIENTATIONS.Append((int)SurfaceOrientation.Rotation90, 0);
            ORIENTATIONS.Append((int)SurfaceOrientation.Rotation180, 270);
            ORIENTATIONS.Append((int)SurfaceOrientation.Rotation270, 180);
        }

        protected override void OnResume()
        {
            base.OnResume();
            StartBackgroundThread();

            // When the screen is turned off and turned back on, the SurfaceTexture is already
            // available, and "onSurfaceTextureAvailable" will not be called. In that case, we can open
            // a camera and start preview from here (otherwise, we wait until the surface is ready in
            // the SurfaceTextureListener).
            if (mTextureView.IsAvailable)
                OpenCamera(mTextureView.Width, mTextureView.Height);
            else
                mTextureView.SurfaceTextureListener = mSurfaceTextureListener;
        }

        protected override void OnPause()
        {
            CloseCamera();
            StopBackgroundThread();
            base.OnPause();
        }

        /************************ NEW ***************************/

        private static readonly SparseIntArray ORIENTATIONS = new SparseIntArray();
        public static readonly int REQUEST_CAMERA_PERMISSION = 1;
        private static readonly string FRAGMENT_DIALOG = "dialog";

        // Tag for the {@link Log}.
        private static readonly string TAG = "\t\tTakePhotoActivity3";

        // Camera state: Showing camera preview.
        public const int STATE_PREVIEW = 0;

        // Camera state: Waiting for the focus to be locked.
        public const int STATE_WAITING_LOCK = 1;

        // Camera state: Waiting for the exposure to be precapture state.
        public const int STATE_WAITING_PRECAPTURE = 2;

        //Camera state: Waiting for the exposure state to be something other than precapture.
        public const int STATE_WAITING_NON_PRECAPTURE = 3;

        // Camera state: Picture was taken.
        public const int STATE_PICTURE_TAKEN = 4;

        // Max preview width that is guaranteed by Camera2 API
        private static readonly int MAX_PREVIEW_WIDTH = 2560;

        // Max preview height that is guaranteed by Camera2 API
        private static readonly int MAX_PREVIEW_HEIGHT = 1440;

        // TextureView.ISurfaceTextureListener handles several lifecycle events on a TextureView
        private Camera2BasicSurfaceTextureListener mSurfaceTextureListener;

        // ID of the current {@link CameraDevice}.
        private string mCameraId;

        // An AutoFitTextureView for camera preview
        private AutoFitTextureView mTextureView;

        //for drawing
        private SurfaceView mTransparentView;

        // A {@link CameraCaptureSession } for camera preview.
        public CameraCaptureSession mCaptureSession;

        // A reference to the opened CameraDevice
        public CameraDevice mCameraDevice;

        // The size of the camera preview
        private Android.Util.Size mPreviewSize;

        // CameraDevice.StateListener is called when a CameraDevice changes its state
        private CameraStateListener mStateCallback;

        // An additional thread for running tasks that shouldn't block the UI.
        private HandlerThread mBackgroundThread;

        // A {@link Handler} for running tasks in the background.
        public Handler mBackgroundHandler;

        // An {@link ImageReader} that handles still image capture.
        private ImageReader mImageReader;

        // This a callback object for the {@link ImageReader}. "onImageAvailable" will be called when a
        // still image is ready to be saved.
        private ImageAvailableListener mOnImageAvailableListener;

        //{@link CaptureRequest.Builder} for the camera preview
        public CaptureRequest.Builder mPreviewRequestBuilder;

        // {@link CaptureRequest} generated by {@link #mPreviewRequestBuilder}
        public CaptureRequest mPreviewRequest;

        // The current state of camera state for taking pictures.
        public int mState = STATE_PREVIEW;

        // A {@link Semaphore} to prevent the app from exiting before closing the camera.
        public Java.Util.Concurrent.Semaphore mCameraOpenCloseLock = new Java.Util.Concurrent.Semaphore(1);

        // Whether the current camera device supports Flash or not.
        private bool mFlashSupported;

        // Orientation of the camera sensor
        private int mSensorOrientation;

        // A {@link CameraCaptureSession.CaptureCallback} that handles events related to JPEG capture.
        public CameraCaptureListener mCaptureCallback;

        private void DrawFocusRect(ISurfaceHolder holder, float RectLeft, float RectTop, float RectRight, float RectBottom, Android.Graphics.Color color)
        {
            //lock
            var canvas = holder.LockCanvas();

            //no pointer to canvas?
            if (canvas == null) return;
            Log.Error(TAG, "\t\t --Drawing in canvas--");

            Rectangle rect = new Rectangle((int)RectLeft, (int)RectTop, (int)RectRight, (int)RectBottom);
            var xCenter = (rect.X + rect.Width) / 2;
            var yCenter = (rect.Y + rect.Height) / 2;

            //clear out
            if (CLEAR_CANVAS)
                canvas.DrawColor(Android.Graphics.Color.Transparent, Android.Graphics.PorterDuff.Mode.Clear);

            //border's properties
            var paint = new Android.Graphics.Paint();
            paint.SetStyle(Android.Graphics.Paint.Style.Stroke);

            var text = new Paint();
            text.TextSize = 20;
            paint.TextSize = 30;

            //paint.SetTextSize(20);
            paint.Color = color;
            paint.StrokeWidth = 3;
            canvas.DrawRect(RectLeft, RectTop, RectRight, RectBottom, paint);
            canvas.DrawText("RectLeft:" + RectLeft, 0, 30, paint);
            canvas.DrawText("RectTop:" + RectTop, 0, 60, paint);
            canvas.DrawText("RectRight:" + RectRight, 0, 90, paint);
            canvas.DrawText("RectBottom:" + RectBottom, 0, 120, paint);

            CLEAR_CANVAS = false;

            //unlock
            holder.UnlockCanvasAndPost(canvas);
        }

        private readonly object _lock = new object();
        private volatile bool isBusy = false;
        private Task PreviewThread;

        public void PreviewFrame(Mat yuvMat)
        //public void PreviewFrame(Image yuvImg)
        {
            /* EMIL EXAMPLE 
            //just move the box around to see something happen
            lock (_lock)
            {
                if (!isBusy)
                {
                    isBusy = true;
                    var results = Detect(image);


                    var PreviewThread = Task.Factory.StartNew(() =>
                    {
                        screenX -= 5;
                        screenY -= 5;

                        if (screenX < 150 || screenY < 150)
                        {
                            var manager = GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
                            var size = new Android.Graphics.Point();
                            manager.DefaultDisplay.GetSize(size);

                            screenX = size.X - 150;
                            screenY = size.Y - 150;
                        }

                        L = screenX - 100;
                        T = screenY - 100;
                        R = screenX + 100;
                        B = screenY + 100;

                        RunOnUiThread(() =>
                        {
                            //code to update UI
                            DrawFocusRect(mTransparentView.Holder, L, T, R, B, Android.Graphics.Color.Yellow);
                        });
                    });

                    //free lock
                    lock (_lock)
                    {
                        isBusy = false;
                    }
                }
            }*/

            Log.Error(TAG, "\t\t--in PreviewFrame--");
            CLEAR_CANVAS = false;
            lock (_lock)
            {
                if (!isBusy)
                {
                    isBusy = true;
                    PreviewThread = Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            face = new CascadeClassifier(faceXml);
                            eye = new CascadeClassifier(eyeXml);

                            Log.Error(TAG, "\t\t--PreviewThread: " + this);

                            //Mat image = Yuv2Rgb(yuvImg);
                            //Mat rgbMat = new Mat();
                            //CvInvoke.CvtColor(yuvMat, rgbMat, Emgu.CV.CvEnum.ColorConversion.Yuv420P2Rgb);
                            RESULTS = Detect(yuvMat);
                            
                            RunOnUiThread(() =>
                            {
                                if (RESULTS != null && RESULTS.Count > 0)
                                {
                                    CLEAR_CANVAS = true;
                                    COLOR = Android.Graphics.Color.White;
                                    foreach (var face in RESULTS.Faces)
                                    {
                                        L = face.Left; T = face.Top;
                                        R = face.Right; B = face.Bottom;

                                        DrawFocusRect(mTransparentView.Holder, L, T, R, B, COLOR);
                                    }
                                    foreach (var eye in RESULTS.Eyes)
                                    {
                                        COLOR = Android.Graphics.Color.Blue;
                                        DrawFocusRect(mTransparentView.Holder, eye.Left, eye.Top, eye.Right, eye.Bottom, COLOR);
                                    }
                                }
                                else
                                {
                                    COLOR = Android.Graphics.Color.Red;
                                    DrawFocusRect(mTransparentView.Holder, L, T, R, B, COLOR);
                                }
                            });
                        }
                        catch (System.Exception ex) { }

                        //free lock
                        lock (_lock)
                        {
                            isBusy = false;
                        }
                    });
                }
            }
            //*/
        }

        private Mat Yuv2Rgb (Image yuvImg) 
        {

            Log.Error(TAG, "\t\t--Yuv2Rgb, Thread:" + this);

            Java.Nio.ByteBuffer buffer = yuvImg.GetPlanes()[0].Buffer;
            byte[] bytes = new byte[buffer.Remaining()];
            buffer.Get(bytes);

            Mat yuvMat = new Mat(yuvImg.Height, yuvImg.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 3);
            Mat rgbMat = new Mat();

            CvInvoke.Imdecode(bytes, Emgu.CV.CvEnum.ImreadModes.Unchanged, yuvMat);
            CvInvoke.CvtColor(yuvMat, rgbMat, Emgu.CV.CvEnum.ColorConversion.Yuv420P2Rgb);

            return rgbMat;
        }

        private class FaceEyes
        {
            public List<Rectangle> Faces { get; set; } = new List<Rectangle>();
            public List<Rectangle> Eyes { get; set; } = new List<Rectangle>();

            public int Count
            {
                get
                {
                    return Faces.Count + Eyes.Count;
                }
            }
        }

        //private FaceEyes Detect(byte [] imageBytes)
        private FaceEyes Detect(Mat image2)
        {
            FaceEyes FE = new FaceEyes();

            //Mat image = new Mat(Assets, "lena.jpg");
            //BitmapRgb565Image image = new BitmapRgb565Image(bmp);
            //var test = new Mat()
            //var image = new Image<Bgr565, byte>(MAX_PREVIEW_WIDTH, MAX_PREVIEW_HEIGHT, );
            //image.map
            //image.Bytes = imageBytes;
            //var image = new Image<Bgr565, byte>(100, 100, new Emgu.CV.Structure.Bgr565());

            if (face != null && eye != null)
            {
                //watch = Stopwatch.StartNew();
                Log.Error(TAG, "\t\t -- FaceEyes Detect()");

                using (UMat ugray = new UMat())
                {
                    CvInvoke.CvtColor(image2, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                    //normalizes brightness and increases contrast of the image
                    CvInvoke.EqualizeHist(ugray, ugray);

                    //Detect the faces  from the gray scale image and store the locations as rectangle
                    //The first dimensional is the channel
                    //The second dimension is the index of the rectangle in the specific channel
                    Rectangle[] facesDetected = face.DetectMultiScale(
                       ugray, 1.1, 10, new System.Drawing.Size(20, 20));

                    FE.Faces.AddRange(facesDetected);

                    foreach (Rectangle f in facesDetected)
                    {
                        Log.Error(TAG, "\t\t -- FaceEyes Detect()\t FACE DETECTED");

                        //Get the region of interest on the faces
                        using (UMat faceRegion = new UMat(ugray, f))
                        {
                            Rectangle[] eyesDetected = eye.DetectMultiScale(
                               faceRegion, 1.1, 10, new System.Drawing.Size(20, 20));

                            foreach (Rectangle e in eyesDetected)
                            {

                                Log.Error(TAG, "\t\t -- FaceEyes Detect()\t EYE DETECTED");

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
            /*
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
                Log.Error(TAG, "IOException caused by setPreviewDisplay()", exception);
            }
            */
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
            /*
            // Now that the size is known, set up the camera parameters and begin
            // the preview.
            if (mTransparentView.Holder == holder)
            {
                lock (_lock)
                {
                    if (!isBusy)
                    {
                        Log.Error(TAG, "\t\t--in SurfaceChanged--");
                        isBusy = true;
                        CLEAR_CANVAS = true;

                        if (RESULTS != null && RESULTS.Count > 0)
                        {
                            foreach (var face in RESULTS.Faces)
                                DrawFocusRect(holder, face.Left, face.Top, face.Right, face.Bottom, Android.Graphics.Color.Red);

                            foreach (var eye in RESULTS.Eyes)
                                DrawFocusRect(holder, eye.Left, eye.Top, eye.Right, eye.Bottom, Android.Graphics.Color.Red);
                        }
                        else
                            DrawFocusRect(holder, L, T, R, B, COLOR);

                        //free lock
                        lock (_lock)
                        {
                            isBusy = false;
                        }
                    }
                }
            }
            */
        }
        #endregion

        private static Android.Util.Size ChooseOptimalSize(Android.Util.Size[] choices, int textureViewWidth, int textureViewHeight, int maxWidth, 
            int maxHeight, Android.Util.Size aspectRatio)
        {
            // Collect the supported resolutions that are at least as big as the preview Surface
            var bigEnough = new List<Android.Util.Size>();
            // Collect the supported resolutions that are smaller than the preview Surface
            var notBigEnough = new List<Android.Util.Size>();
            int w = aspectRatio.Width;
            int h = aspectRatio.Height;

            for (var i = 0; i < choices.Length; i++)
            {
                Android.Util.Size option = choices[i];
                //if ((option.Width <= maxWidth) && (option.Height <= maxHeight) && option.Height == option.Width * h / w)
                if ((option.Width <= maxWidth) && (option.Height <= maxHeight))
                {
                    if (option.Width >= textureViewWidth && option.Height >= textureViewHeight)
                    {
                        bigEnough.Add(option);
                    }
                    else
                    {
                        notBigEnough.Add(option);
                    }
                }
            }

            // Pick the smallest of those big enough. If there is no one big enough, pick the
            // largest of those not big enough.
            if (bigEnough.Count > 0)
            {
                return (Android.Util.Size)Collections.Min(bigEnough, new CompareSizesByArea());
            }
            else if (notBigEnough.Count > 0)
            {
                return (Android.Util.Size)Collections.Max(notBigEnough, new CompareSizesByArea());
            }
            else
            {
                Log.Error(TAG, "Couldn't find any suitable preview size");
                return choices[0];
            }
        }

        /************ STUFF THAT WAS PART OF FRAGMENT **************/
        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    return inflater.Inflate(Resource.Layout.fragment_camera2_basic, container, false);
        //}

        //public override void OnViewCreated(View view, Bundle savedInstanceState)
        //{
        //    mTextureView = (AutoFitTextureView)view.FindViewById(Resource.Id.texture);
        //    view.FindViewById(Resource.Id.picture).SetOnClickListener(this);
        //    view.FindViewById(Resource.Id.info).SetOnClickListener(this);
        //}

        //public override void OnActivityCreated(Bundle savedInstanceState)
        //{
        //    base.OnActivityCreated(savedInstanceState);
        //    mFile = new File(Activity.GetExternalFilesDir(null), "pic.jpg");
        //}


        //this was used in fragment, requires Android.Support.V13
        //private void RequestCameraPermission()
        //{
        //    if (FragmentCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.Camera))
        //    {
        //        new ConfirmationDialog().Show(ChildFragmentManager, FRAGMENT_DIALOG);
        //    }
        //    else
        //    {
        //        FragmentCompat.RequestPermissions(this, new string[] { Manifest.Permission.Camera }, REQUEST_CAMERA_PERMISSION);
        //    }
        //}

        //public void OnRequestPermissionsResult(int requestCode, string[] permissions, int[] grantResults)
        //{
        //    if (requestCode != REQUEST_CAMERA_PERMISSION)
        //    {
        //        return;
        //    }

        //    if (grantResults.Length != 1 || grantResults[0] != (int)Permission.Granted)
        //    {
        //        ErrorDialog.NewInstance(GetString(Resource.String.request_permission)).Show(ChildFragmentManager, FRAGMENT_DIALOG);
        //    }
        //}


        // Sets up member variables related to camera.

        private void SetUpCameraOutputs(int width, int height)
        {
            //this line was with Fragment.Activity
            //var activity = Activity;

            var manager = (CameraManager)GetSystemService(Context.CameraService);
            try
            {
                for (var i = 0; i < manager.GetCameraIdList().Length; i++)
                {
                    var cameraId = manager.GetCameraIdList()[i];
                    CameraCharacteristics characteristics = manager.GetCameraCharacteristics(cameraId);

                    // We don't use a front facing camera in this sample.
                    var facing = (Integer)characteristics.Get(CameraCharacteristics.LensFacing);
                    if (facing != null && facing == (Integer.ValueOf((int)LensFacing.Front)))
                    {
                        continue;
                    }

                    var map = (StreamConfigurationMap)characteristics.Get(CameraCharacteristics.ScalerStreamConfigurationMap);
                    if (map == null)
                    {
                        continue;
                    }

                    // For still image captures, we use the largest available size.
                    //Android.Util.Size largest = (Android.Util.Size)Collections.Max(Arrays.AsList(map.GetOutputSizes((int)ImageFormatType.Jpeg)), 
                    //    new CompareSizesByArea());
                    //mImageReader = ImageReader.NewInstance(largest.Width, largest.Height, ImageFormatType.Jpeg, /*maxImages*/16);
                    mImageReader = ImageReader.NewInstance(1280, 720, ImageFormatType.Yuv420888, 2);
                    mImageReader.SetOnImageAvailableListener(mOnImageAvailableListener, mBackgroundHandler);

                    // Find out if we need to swap dimension to get the preview size relative to sensor
                    // coordinate.
                    var displayRotation = WindowManager.DefaultDisplay.Rotation;
                    //noinspection ConstantConditions
                    mSensorOrientation = (int)characteristics.Get(CameraCharacteristics.SensorOrientation);
                    bool swappedDimensions = false;
                    switch (displayRotation)
                    {
                        case SurfaceOrientation.Rotation0:
                        case SurfaceOrientation.Rotation180:
                            if (mSensorOrientation == 90 || mSensorOrientation == 270)
                            {
                                swappedDimensions = true;
                            }
                            break;
                        case SurfaceOrientation.Rotation90:
                        case SurfaceOrientation.Rotation270:
                            if (mSensorOrientation == 0 || mSensorOrientation == 180)
                            {
                                swappedDimensions = true;
                            }
                            break;
                        default:
                            Log.Error(TAG, "Display rotation is invalid: " + displayRotation);
                            break;
                    }

                    var displaySize = new Android.Graphics.Point();
                    WindowManager.DefaultDisplay.GetSize(displaySize);
                    var rotatedPreviewWidth = width;
                    var rotatedPreviewHeight = height;
                    var maxPreviewWidth = displaySize.X;
                    var maxPreviewHeight = displaySize.Y;

                    if (swappedDimensions)
                    {
                        rotatedPreviewWidth = height;
                        rotatedPreviewHeight = width;
                        maxPreviewWidth = displaySize.Y;
                        maxPreviewHeight = displaySize.X;
                    }

                    if (maxPreviewWidth > MAX_PREVIEW_WIDTH)
                    {
                        maxPreviewWidth = MAX_PREVIEW_WIDTH;
                    }

                    if (maxPreviewHeight > MAX_PREVIEW_HEIGHT)
                    {
                        maxPreviewHeight = MAX_PREVIEW_HEIGHT;
                    }

                    // Danger, W.R.! Attempting to use too large a preview size could  exceed the camera
                    // bus' bandwidth limitation, resulting in gorgeous previews but the storage of
                    // garbage capture data.
                    /*mPreviewSize = ChooseOptimalSize(map.GetOutputSizes(Class.FromType(typeof(SurfaceTexture))),
                        rotatedPreviewWidth, rotatedPreviewHeight, maxPreviewWidth,
                        maxPreviewHeight, largest);*/
                    mPreviewSize = new Android.Util.Size(1280, 720);

                    // We fit the aspect ratio of TextureView to the size of preview we picked.
                    var orientation = Resources.Configuration.Orientation;
                    if (orientation == Orientation.Landscape)
                    {
                        mTextureView.SetAspectRatio(mPreviewSize.Width, mPreviewSize.Height);
                    }
                    else
                    {
                        mTextureView.SetAspectRatio(mPreviewSize.Height, mPreviewSize.Width);
                    }

                    // Check if the flash is supported.
                    var available = (Boolean)characteristics.Get(CameraCharacteristics.FlashInfoAvailable);
                    if (available == null)
                    {
                        mFlashSupported = false;
                    }
                    else
                    {
                        mFlashSupported = (bool)available;
                    }

                    mCameraId = cameraId;
                    return;
                }
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
            catch (NullPointerException e)
            {
                // Currently an NPE is thrown when the Camera2API is used but not supported on the
                // device this code runs.
                //ErrorDialog.NewInstance(GetString(Resource.String.camera_error)).Show(ChildFragmentManager, FRAGMENT_DIALOG);
            }
        }

        // Opens the camera specified by {@link Camera2BasicFragment#mCameraId}.
        public void OpenCamera(int width, int height)
        {
            //check if camera permissions exist, if not, request them
            //this requries Android.Support.V4
            //if (ContextCompat.CheckSelfPermission(Activity, Manifest.Permission.Camera) != Permission.Granted)
            //{
            //    RequestCameraPermission();
            //    return;
            //}

            SetUpCameraOutputs(width, height);
            ConfigureTransform(width, height);
            var manager = (CameraManager)GetSystemService(Context.CameraService);
            try
            {
                if (!mCameraOpenCloseLock.TryAcquire(2500, Java.Util.Concurrent.TimeUnit.Microseconds))
                {
                    throw new RuntimeException("Time out waiting to lock camera opening.");
                }
                manager.OpenCamera(mCameraId, mStateCallback, mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
            catch (InterruptedException e)
            {
                throw new RuntimeException("Interrupted while trying to lock camera opening.", e);
            }
        }

        // Closes the current {@link CameraDevice}.
        private void CloseCamera()
        {
            try
            {
                mCameraOpenCloseLock.Acquire();
                if (null != mCaptureSession)
                {
                    mCaptureSession.Close();
                    mCaptureSession = null;
                }
                if (null != mCameraDevice)
                {
                    mCameraDevice.Close();
                    mCameraDevice = null;
                }
                if (null != mImageReader)
                {
                    mImageReader.Close();
                    mImageReader = null;
                }
            }
            catch (InterruptedException e)
            {
                throw new RuntimeException("Interrupted while trying to lock camera closing.", e);
            }
            finally
            {
                mCameraOpenCloseLock.Release();
            }
        }

        // Starts a background thread and its {@link Handler}.
        private void StartBackgroundThread()
        {
            mBackgroundThread = new HandlerThread("CameraBackground");
            mBackgroundThread.Start();
            mBackgroundHandler = new Handler(mBackgroundThread.Looper);
        }

        // Stops the background thread and its {@link Handler}.
        private void StopBackgroundThread()
        {
            mBackgroundThread.QuitSafely();
            try
            {
                mBackgroundThread.Join();
                mBackgroundThread = null;
                mBackgroundHandler = null;
            }
            catch (InterruptedException e)
            {
                e.PrintStackTrace();
            }
        }

        // Creates a new {@link CameraCaptureSession} for camera preview.
        public void CreateCameraPreviewSession()
        {
            try
            {
                SurfaceTexture texture = mTextureView.SurfaceTexture;
                if (texture == null)
                {
                    throw new IllegalStateException("texture is null");
                }

                // We configure the size of default buffer to be the size of camera preview we want.
                texture.SetDefaultBufferSize(mPreviewSize.Width, mPreviewSize.Height);

                // This is the output Surface we need to start preview.
                Surface surface = new Surface(texture);

                // We set up a CaptureRequest.Builder with the output Surface.
                mPreviewRequestBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.Preview);
                mPreviewRequestBuilder.AddTarget(surface);
                mPreviewRequestBuilder.AddTarget(mImageReader.Surface);

                // Here, we create a CameraCaptureSession for camera preview.
                List<Surface> surfaces = new List<Surface>();
                surfaces.Add(surface);
                surfaces.Add(mImageReader.Surface);
                mCameraDevice.CreateCaptureSession(surfaces, new CameraCaptureSessionCallback(this), null);

            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        public static T Cast<T>(Java.Lang.Object obj) where T : class
        {
            var propertyInfo = obj.GetType().GetProperty("Instance");
            return propertyInfo == null ? null : propertyInfo.GetValue(obj, null) as T;
        }

        // Configures the necessary {@link android.graphics.Matrix}
        // transformation to `mTextureView`.
        // This method should be called after the camera preview size is determined in
        // setUpCameraOutputs and also the size of `mTextureView` is fixed.
        public void ConfigureTransform(int viewWidth, int viewHeight)
        {
            if (null == mTextureView || null == mPreviewSize)
            {
                return;
            }

            var rotation = (int)WindowManager.DefaultDisplay.Rotation;
            Matrix matrix = new Matrix();
            RectF viewRect = new RectF(0, 0, viewWidth, viewHeight);
            RectF bufferRect = new RectF(0, 0, mPreviewSize.Height, mPreviewSize.Width);
            float centerX = viewRect.CenterX();
            float centerY = viewRect.CenterY();
            if ((int)SurfaceOrientation.Rotation90 == rotation || (int)SurfaceOrientation.Rotation270 == rotation)
            {
                bufferRect.Offset(centerX - bufferRect.CenterX(), centerY - bufferRect.CenterY());
                matrix.SetRectToRect(viewRect, bufferRect, Matrix.ScaleToFit.Fill);
                float scale = Math.Max((float)viewHeight / mPreviewSize.Height, (float)viewWidth / mPreviewSize.Width);
                matrix.PostScale(scale, scale, centerX, centerY);
                matrix.PostRotate(90 * (rotation - 2), centerX, centerY);
            }
            else if ((int)SurfaceOrientation.Rotation180 == rotation)
            {
                matrix.PostRotate(180, centerX, centerY);
            }
            mTextureView.SetTransform(matrix);
        }

        // Initiate a still image capture.
        private void TakePicture()
        {
            LockFocus();
        }

        // Lock the focus as the first step for a still image capture.
        private void LockFocus()
        {
            try
            {
                // This is how to tell the camera to lock focus.

                mPreviewRequestBuilder.Set(CaptureRequest.ControlAfTrigger, (int)ControlAFTrigger.Start);
                // Tell #mCaptureCallback to wait for the lock.
                mState = STATE_WAITING_LOCK;
                mCaptureSession.Capture(mPreviewRequestBuilder.Build(), mCaptureCallback, mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        // Run the precapture sequence for capturing a still image. This method should be called when
        // we get a response in {@link #mCaptureCallback} from {@link #lockFocus()}.
        public void RunPrecaptureSequence()
        {
            try
            {
                // This is how to tell the camera to trigger.
                mPreviewRequestBuilder.Set(CaptureRequest.ControlAePrecaptureTrigger, (int)ControlAEPrecaptureTrigger.Start);
                // Tell #mCaptureCallback to wait for the precapture sequence to be set.
                mState = STATE_WAITING_PRECAPTURE;
                mCaptureSession.Capture(mPreviewRequestBuilder.Build(), mCaptureCallback, mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        public void CapturePreviewShot()
        {
            try
            {
                //final Activity activity = getActivity();
                if (null == mCameraDevice)
                {
                    return;
                }

                // This is the CaptureRequest.Builder that we use to take a picture.
                //final CaptureRequest.Builder captureBuilder = mCameraDevice.createCaptureRequest(CameraDevice.TEMPLATE_PREVIEW);
                CaptureRequest.Builder captureBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.Preview);
                captureBuilder.AddTarget(mImageReader.Surface);

                // Use the same AE and AF modes as the preview.
                captureBuilder.Set(CaptureRequest.ControlAfMode, (int)ControlAFMode.ContinuousPicture);
                //SetAutoFlash(captureBuilder);

                // Orientation
                int rotation = (int)WindowManager.DefaultDisplay.Rotation;
                captureBuilder.Set(CaptureRequest.JpegOrientation, GetOrientation(rotation));

                mCaptureSession.StopRepeating();
                //mCaptureSession.Capture(captureBuilder.Build(), new CameraCapturePreviewSessionCallback(this), null);
                mCaptureSession.Capture(captureBuilder.Build(), new CameraCapturePreviewSessionCallback(this), mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        // Capture a still picture. This method should be called when we get a response in
        // {@link #mCaptureCallback} from both {@link #lockFocus()}.
        public void CaptureStillPicture()
        {
            try
            {
                if (null == mCameraDevice)
                {
                    return;
                }

                // This is the CaptureRequest.Builder that we use to take a picture.
                CaptureRequest.Builder captureBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.StillCapture);
                captureBuilder.AddTarget(mImageReader.Surface);

                // Use the same AE and AF modes as the preview.
                captureBuilder.Set(CaptureRequest.ControlAfMode, (int)ControlAFMode.ContinuousPicture);
                SetAutoFlash(captureBuilder);

                // Orientation
                int rotation = (int)WindowManager.DefaultDisplay.Rotation;
                captureBuilder.Set(CaptureRequest.JpegOrientation, GetOrientation(rotation));

                mCaptureSession.StopRepeating();
                mCaptureSession.Capture(captureBuilder.Build(), new CameraCaptureStillPictureSessionCallback(this), null);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        // Retrieves the JPEG orientation from the specified screen rotation.
        private int GetOrientation(int rotation)
        {
            // Sensor orientation is 90 for most devices, or 270 for some devices (eg. Nexus 5X)
            // We have to take that into account and rotate JPEG properly.
            // For devices with orientation of 90, we simply return our mapping from ORIENTATIONS.
            // For devices with orientation of 270, we need to rotate the JPEG 180 degrees.
            return (ORIENTATIONS.Get(rotation) + mSensorOrientation + 270) % 360;
        }

        // Unlock the focus. This method should be called when still image capture sequence is
        // finished.
        public void UnlockFocus()
        {
            try
            {
                // Reset the auto-focus trigger
                mPreviewRequestBuilder.Set(CaptureRequest.ControlAfTrigger, (int)ControlAFTrigger.Cancel);
                SetAutoFlash(mPreviewRequestBuilder);
                mCaptureSession.Capture(mPreviewRequestBuilder.Build(), mCaptureCallback, mBackgroundHandler);
                // After this, the camera will go back to the normal state of preview.
                mState = STATE_PREVIEW;
                mCaptureSession.SetRepeatingRequest(mPreviewRequest, mCaptureCallback, mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        //this is only if View.IOnClickListener is implemented
        //public void OnClick(View v)
        //{
        //    switch (v.Id)
        //    {
        //        case Resource.Id.picture:
        //            TakePicture();
        //            break;
        //        case Resource.Id.info:
        //            EventHandler<DialogClickEventArgs> nullHandler = null;
        //            Activity activity = Activity;
        //            if (activity != null)
        //            {
        //                new AlertDialog.Builder(activity)
        //                    .SetMessage("This sample demonstrates the basic use of the Camera2 API. ...")
        //                    .SetPositiveButton(Android.Resource.String.Ok, nullHandler)
        //                    .Show();
        //            }
        //            break;
        //    }
        //}
        public void SetAutoFlash(CaptureRequest.Builder requestBuilder)
        {
            if (mFlashSupported)
            {
                requestBuilder.Set(CaptureRequest.ControlAeMode, (int)ControlAEMode.OnAutoFlash);
            }
        }

    }
}