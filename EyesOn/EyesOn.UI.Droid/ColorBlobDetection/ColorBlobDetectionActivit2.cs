using System;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Content.PM;
using Android.Util;

using OpenCV.Core;
using OpenCV.Android;
using Size = OpenCV.Core.Size;
using Mat = OpenCV.Core.Mat;
using OpenCV.ImgProc;
using OpenCV.ObjDetect;

namespace EyesOn.UI.Droid.ColorBlobDetection
{
    [Activity(Label = "ColorBlobDetectionActivity2",
        ScreenOrientation = ScreenOrientation.Landscape,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden)]
    public class ColorBlobDetectionActivity2 : Activity, /*View.IOnTouchListener,*/ CameraBridgeViewBase.ICvCameraViewListener2
    {
        string TAG = "\t\t-- jBlobDetect2 --\t\t";

        private static OpenCV.Core.Scalar FACE_RECT_COLOR = new OpenCV.Core.Scalar(0, 255, 0, 255);

        public  const int JAVA_DETECTOR = 0;
        private const int TM_SQDIFF = 0;
        private const int TM_SQDIFF_NORMED = 1;
        private const int TM_CCOEFF = 2;
        private const int TM_CCOEFF_NORMED = 3;
        private const int TM_CCORR = 4;
        private const int TM_CCORR_NORMED = 5;

        private int learn_frames = 0;
        private Mat teplateR;
        private Mat teplateL;
        int method = 0;

        private Mat mRgba;
        private Mat mGray;

        // matrix for zooming
        private Mat mZoomWindow;
        private Mat mZoomWindow2;

        /*
        private bool mIsColorSelected = false;
        private Scalar mBlobColorRgba;
        private Scalar mBlobColorHsv;
        private ColorBlobDetector mDetector;
        private Mat mSpectrum;
        private Size SPECTRUM_SIZE;
        private Scalar CONTOUR_COLOR;
        */

        public CameraBridgeViewBase mOpenCvCameraView { get; private set; }
        BaseLoaderCallback mLoaderCallback;

        CascadeClassifier FACE = null;
        CascadeClassifier EYE = null;

        private int mDetectorType = JAVA_DETECTOR;
        private String[] mDetectorName;

        private double mRelativeFaceSize = 0.2;
        private int mAbsoluteFaceSize = 0;

        double xCenter = -1;
        double yCenter = -1;


        public ColorBlobDetectionActivity2()
        {
            Log.Info(TAG, "Instantiated new " + GetType().ToString());
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Log.Info(TAG, "called onCreate");
            base.OnCreate(savedInstanceState);

            //string APPLICATION_RAW_PATH = "android.resource://" + PackageName + "/";
            ISharedPreferences preference = Android.Preferences.PreferenceManager.GetDefaultSharedPreferences(ApplicationContext);
            FileInfo eyeFile = Emgu.Util.AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_eye.xml", "cascade", 0);
            FileInfo faceFile = Emgu.Util.AndroidFileAsset.WritePermanantFileAsset(this, "haarcascade_frontalface_alt_tree.xml", "cascade", 0);

            //string[] items = System.IO.Directory.GetFiles("../../Resources/raw"); //BREAKS SHITE

            try
            {
                //using (var istr = Resources.OpenRawResource(Resource.Raw.haarcascade_frontalface_alt_tree))
                //{
                /*
                Java.IO.File cascadeDir = GetDir("raw", FileCreationMode.Private);
                Java.IO.File mCascadeFile = new Java.IO.File(cascadeDir, "haarcascade_frontalface_alt_tree.xml");
                using (Java.IO.FileOutputStream os = new Java.IO.FileOutputStream(mCascadeFile))
                {
                    int byteRead;
                    while ((byteRead = istr.ReadByte()) != -1)
                        os.Write(byteRead);
                }*/
                //var tmp = Resource.Raw.haarcascade_frontalface_alt_tree;
                FACE = new CascadeClassifier(faceFile.FullName); // preference.GetString("cascade-face-data-path", null));  //(APPLICATION_RAW_PATH + tmp);

                /*
                mCascadeFile = new Java.IO.File(cascadeDir, "haarcascade_eye.xml");
                using (Java.IO.FileOutputStream os = new Java.IO.FileOutputStream(mCascadeFile))
                {
                    int byteRead;
                    while ((byteRead = istr.ReadByte()) != -1)
                        os.Write(byteRead);
                }*/
                //tmp = Resource.Raw.haarcascade_eye;
                EYE = new CascadeClassifier(eyeFile.FullName);  
                //}

                //if (FACE.isEmpty| EYE.isEmpty)
                //   Log.Error(TAG, "Empty cascade");

            }
            catch (IOException e)
            {
                Log.Error(TAG, "Failed to load cascade. Exception thrown: " + e.StackTrace);
            
            }

            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            SetContentView(Resource.Layout.color_blob_detection_surface_view);

            mOpenCvCameraView = FindViewById<CameraBridgeViewBase>(Resource.Id.color_blob_detection_activity_surface_view);
            mOpenCvCameraView.Visibility = ViewStates.Visible;
            mOpenCvCameraView.SetCvCameraViewListener2(this);
            mLoaderCallback = new Callback(this, this);
        }

        protected override void OnPause()
        {
            Log.Info(TAG, "called OnPause");

            base.OnPause();
            if (mOpenCvCameraView != null)
                mOpenCvCameraView.DisableView();
        }

        protected override void OnResume()
        {
            Log.Info(TAG, "called OnResume");

            base.OnResume();
            if (!OpenCVLoader.InitDebug())
            {
                Log.Debug(TAG, "Internal OpenCV library not found. Using OpenCV Manager for initialization");
                OpenCVLoader.InitAsync(OpenCVLoader.OpencvVersion300, this, mLoaderCallback);
            }
            else
            {
                Log.Debug(TAG, "OpenCV library found inside package. Using it!");
                mLoaderCallback.OnManagerConnected(LoaderCallbackInterface.Success);
            }
        }

        protected override void OnDestroy()
        {
            Log.Info(TAG, "called OnDestroy");

            base.OnDestroy();
            if (mOpenCvCameraView != null)
                mOpenCvCameraView.DisableView();
        }

        public void OnCameraViewStarted(int width, int height)
        {
            Log.Info(TAG, "called OnCameraViewStarted " + width + "," + height);

            mGray = new Mat();
            mRgba = new Mat();

            /*
            mRgba = new Mat(height, width, CvType.Cv8uc4);
            mDetector = new ColorBlobDetector();
            mSpectrum = new Mat();
            mBlobColorRgba = new Scalar(255); 
            mBlobColorHsv = new Scalar(255);
            SPECTRUM_SIZE = new Size(200, 64);
            CONTOUR_COLOR = new Scalar(255, 0, 0, 255);
            */
        }

        public void OnCameraViewStopped()
        {
            Log.Info(TAG, "called OnCameraViewStopped");
            mGray.Dispose();
            mRgba.Dispose();
            mZoomWindow.Dispose();
            mZoomWindow2.Dispose();
        }

        /*public bool OnTouch(View v, MotionEvent e)
        {
            int cols = mRgba.Cols();
            int rows = mRgba.Rows();

            int xOffset = (mOpenCvCameraView.Width - cols) / 2;
            int yOffset = (mOpenCvCameraView.Height - rows) / 2;

            int x = (int)e.GetX() - xOffset;
            int y = (int)e.GetY() - yOffset;

            Log.Info(TAG, "Touch image coordinates: (" + x + ", " + y + ")");

            if ((x < 0) || (y < 0) || (x > cols) || (y > rows)) return false;

            Rect touchedRect = new Rect();

            touchedRect.X = (x > 4) ? x - 4 : 0;
            touchedRect.Y = (y > 4) ? y - 4 : 0;

            touchedRect.Width = (x + 4 < cols) ? x + 4 - touchedRect.X : cols - touchedRect.X;
            touchedRect.Height = (y + 4 < rows) ? y + 4 - touchedRect.Y : rows - touchedRect.Y;

            Mat touchedRegionRgba = mRgba.Submat(touchedRect);

            Mat touchedRegionHsv = new Mat();
            Imgproc.CvtColor(touchedRegionRgba, touchedRegionHsv, Imgproc.ColorRgb2hsvFull);

            // Calculate average color of touched region
            mBlobColorHsv = Core.SumElems(touchedRegionHsv);
            int pointCount = touchedRect.Width * touchedRect.Height;
            for (int i = 0; i < mBlobColorHsv.Val.Count; i++)
                mBlobColorHsv.Val[i] /= pointCount;

            mBlobColorRgba = ConvertScalarHsv2Rgba(mBlobColorHsv);

            Log.Info(TAG, "Touched rgba color: (" + mBlobColorRgba.Val[0] + ", " + mBlobColorRgba.Val[1] +
                    ", " + mBlobColorRgba.Val[2] + ", " + mBlobColorRgba.Val[3] + ")");

            mDetector.SetHsvColor(mBlobColorHsv);
            Imgproc.Resize(mDetector.Spectrum, mSpectrum, SPECTRUM_SIZE);

            mIsColorSelected = true;

            touchedRegionRgba.Release();
            touchedRegionHsv.Release();

            return false; // don't need subsequent touch events
        }*/

        private void CreateAuxiliaryMats()
        {
            if (mGray.Empty())  return;

            int rows = mGray.Rows();
            int cols = mGray.Cols();

            if (mZoomWindow == null)
            {
                mZoomWindow  = mRgba.Submat(rows / 2 + rows / 10, rows, cols / 2 + cols / 10, cols);
                mZoomWindow2 = mRgba.Submat(0, rows / 2 - rows / 10, cols / 2 + cols / 10, cols);
            }

        }

        private Mat get_template(CascadeClassifier clssfr, Rect area, int size)
        {
            Mat template = new Mat();
            Mat mROI = mGray.Submat(area);
            MatOfRect eyes = new MatOfRect();
            Point iris = new Point();
            Rect eye_template = new Rect(); 
            clssfr.DetectMultiScale(mROI, eyes, 1.15, 2, Objdetect.CascadeFindBiggestObject | Objdetect.CascadeScaleImage, 
                new Size(30, 30), new Size());

            Rect[] eyesArray = eyes.ToArray();
            for (int i = 0; i < eyesArray.Length;)
            {
                Rect e = eyesArray[i];
                e.X = area.X + e.X;
                e.Y = area.Y + e.Y;
                Rect eye_only_rectangle = new Rect((int)e.Tl().X,
                        (int)(e.Tl().Y + e.Height * 0.4), (int)e.Width,
                        (int)(e.Height * 0.6));
                mROI = mGray.Submat(eye_only_rectangle);
                Mat vyrez = mRgba.Submat(eye_only_rectangle);

                Core.MinMaxLocResult mmG = Core.MinMaxLoc(mROI);

                Imgproc.Circle(vyrez, mmG.MinLoc, 2, new Scalar(255, 255, 255, 255), 2);
                iris.X = mmG.MinLoc.X + eye_only_rectangle.X;
                iris.Y = mmG.MinLoc.Y + eye_only_rectangle.Y;

                eye_template = new Rect((int)iris.X - size / 2, (int)iris.Y - size / 2, size, size);

                Imgproc.Rectangle(mRgba, eye_template.Tl(), eye_template.Br(), new Scalar(255, 0, 0, 255), 2);
                template = (mGray.Submat(eye_template)).Clone();
                return template;
            }
            return template;
        }

        private void match_eye(Rect area, Mat mTemplate, int type)
        {
            Point matchLoc;
            Mat mROI = mGray.Submat(area);
            int result_cols = mROI.Cols() - mTemplate.Cols() + 1;
            int result_rows = mROI.Rows() - mTemplate.Rows() + 1;
            
            // Check for bad template size
            if (mTemplate.Cols() == 0 || mTemplate.Rows() == 0)
                return;

            Mat mResult = new Mat(result_cols, result_rows, CvType.Cv8u);

            switch (type)
            {
                case TM_SQDIFF:                  
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmSqdiff);
                    break;
                case TM_SQDIFF_NORMED:
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmSqdiffNormed);
                    break;
                case TM_CCOEFF:
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmCcoeff);
                    break;
                case TM_CCOEFF_NORMED:
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmCcoeffNormed);
                    break;
                case TM_CCORR:
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmCcorr);
                    break;
                case TM_CCORR_NORMED:
                    Imgproc.MatchTemplate(mROI, mTemplate, mResult, Imgproc.TmCcorrNormed);
                    break;
            }

            Core.MinMaxLocResult mmres = Core.MinMaxLoc(mResult);

            // there is difference in matching methods - best match is max/min value
            if (type == TM_SQDIFF || type == TM_SQDIFF_NORMED)
                matchLoc = mmres.MinLoc;
            else
                matchLoc = mmres.MaxLoc;

            Point matchLoc_tx = new Point(matchLoc.X + area.X, matchLoc.Y + area.Y);
            Point matchLoc_ty = new Point(matchLoc.X + mTemplate.Cols() + area.X,
                    matchLoc.Y + mTemplate.Rows() + area.Y);

            Imgproc.Rectangle(mRgba, matchLoc_tx, matchLoc_ty, new Scalar(255, 255, 0, 255));
            Rect rec = new Rect(matchLoc_tx, matchLoc_ty); 
        }

        public Mat OnCameraFrame(CameraBridgeViewBase.ICvCameraViewFrame inputFrame)
        {

            mRgba = inputFrame.Rgba();
            mGray = inputFrame.Gray();

            if (mAbsoluteFaceSize == 0)
            {
                int height = mGray.Rows();
                if (Math.Round(height * mRelativeFaceSize) > 0)
                    mAbsoluteFaceSize = (int) Math.Round(height * mRelativeFaceSize);
            }

            if (mZoomWindow == null || mZoomWindow2 == null)
                CreateAuxiliaryMats();

            MatOfRect faces = new MatOfRect();

            if (FACE != null)
                FACE.DetectMultiScale(mGray, faces, 1.1, 2, 2, // TODO: objdetect.CV_HAAR_SCALE_IMAGE
                        new Size(mAbsoluteFaceSize, mAbsoluteFaceSize), new Size());

            Rect[] facesArray = faces.ToArray();
            for (int i = 0; i < facesArray.Length; i++)
            {
                Imgproc.Rectangle(mRgba, facesArray[i].Tl(), facesArray[i].Br(), FACE_RECT_COLOR, 3);
                xCenter = (facesArray[i].X + facesArray[i].Width + facesArray[i].X) / 2;
                yCenter = (facesArray[i].Y + facesArray[i].Y + facesArray[i].Height) / 2;
                Point center = new Point(xCenter, yCenter);

                Imgproc.Circle(mRgba, center, 10, new Scalar(255, 0, 0, 255), 3);

                /* --- NOT NEEDED
                Imgproc.putText(mRgba, "[" + center.X + "," + center.Y + "]",
                        new Point(center.X + 20, center.Y + 20),
                        Core.FONT_HERSHEY_SIMPLEX, 0.7, new Scalar(255, 255, 255, 255));
                */

                Rect r = facesArray[i];

                // compute the eye area
                Rect eyearea = new Rect(r.X + r.Width / 8,
                        (int)(r.Y + (r.Height / 4.5)), r.Width - 2 * r.Width / 8, (int)(r.Height / 3.0));

                // split it
                Rect eyearea_right = new Rect(r.X + r.Width / 16, (int)(r.Y + (r.Height / 4.5)),
                        (r.Width - 2 * r.Width / 16) / 2, (int)(r.Height / 3.0));

                Rect eyearea_left = new Rect(r.X + r.Width / 16 + (r.Width - 2 * r.Width / 16) / 2,
                        (int)(r.Y + (r.Height / 4.5)), (r.Width - 2 * r.Width / 16) / 2, (int)(r.Height / 3.0));

                // draw the area - mGray is working grayscale mat, if you want to see area in rgb preview, 
                // change mGray to mRgba
                Imgproc.Rectangle(mRgba, eyearea_left.Tl(), eyearea_left.Br(), new Scalar(255, 0, 0, 255), 2);
                Imgproc.Rectangle(mRgba, eyearea_right.Tl(), eyearea_right.Br(), new Scalar(255, 0, 0, 255), 2);

                if (learn_frames < 5)
                {
                    teplateR = get_template(EYE, eyearea_right, 24);
                    teplateL = get_template(EYE, eyearea_left, 24);
                    learn_frames++;
                }
                else
                {
                    // Learning finished, use the new templates for template matching
                    match_eye(eyearea_right, teplateR, method);
                    match_eye(eyearea_left, teplateL, method);
                }

                // cut eye areas and put them to zoom windows
                Imgproc.Resize(mRgba.Submat(eyearea_left), mZoomWindow2, mZoomWindow2.Size());
                Imgproc.Resize(mRgba.Submat(eyearea_right), mZoomWindow, mZoomWindow.Size());
            }

            /*
            mRgba = inputFrame.Rgba();
            Log.Info(TAG, "called OnCameraFrame");

            if (mIsColorSelected)
            {
                mDetector.Process(mRgba);
                List<MatOfPoint> contours = mDetector.Contours;
                Log.Error(TAG, "Contours count: " + contours.Count);
                Imgproc.DrawContours(mRgba, contours, -1, CONTOUR_COLOR);

                Mat colorLabel = mRgba.Submat(4, 68, 4, 68);
                colorLabel.SetTo(mBlobColorRgba);

                Mat spectrumLabel = mRgba.Submat(4, 4 + mSpectrum.Rows(), 70, 70 + mSpectrum.Cols());
                mSpectrum.CopyTo(spectrumLabel);
            }
            */

            return mRgba;
        }

        /*
        private Scalar ConvertScalarHsv2Rgba(Scalar hsvColor)
        {
            Log.Info(TAG, "called ConvertScalarHsv2Rgba");

            Mat pointMatRgba = new Mat();
            Mat pointMatHsv = new Mat(1, 1, CvType.Cv8uc3, hsvColor);
            Imgproc.CvtColor(pointMatHsv, pointMatRgba, Imgproc.ColorHsv2rgbFull, 4);

            return new Scalar(pointMatRgba.Get(0, 0));
        }   
        */
    }

    class Callback : BaseLoaderCallback
    {
        string TAG = "\t\t-- jBlobCallback --\t\t";

        private readonly ColorBlobDetectionActivity2 _activity;
        public Callback(ColorBlobDetectionActivity2 activity, Context context)
            : base(context)
        {
            Log.Info(TAG, "BaseLoaderCallback created");
            _activity = activity;
        }

        public override void OnManagerConnected(int status)
        {
            switch (status)
            {
                case LoaderCallbackInterface.Success:
                    {
                        Log.Info(TAG, "OpenCV loaded successfully");

                        //_activity.mOpenCvCameraView.setCameraIndex(1);
                        _activity.mOpenCvCameraView.EnableView();
                        //_activity.mOpenCvCameraView.SetOnTouchListener(_activity);
                    }
                    break;
                default:
                    {
                        base.OnManagerConnected(status);
                    }
                    break;
            }
        }
    }

}