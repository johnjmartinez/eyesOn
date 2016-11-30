
using System.Collections.Generic;

using Android.Runtime;

using OpenCV.Core;
using OpenCV.ImgProc;
using Android.Util;

namespace EyesOn.UI.Droid.ColorBlobDetection
{
    class ColorBlobDetector
    {
        string TAG = "\t\t --detector-- \t\t";

        // Lower and Upper bounds for range checking in HSV color space
        private Scalar mLowerBound = new Scalar(0);
        private Scalar mUpperBound = new Scalar(0);
        // Minimum contour area in percent for contours filtering
        private static double mMinContourArea = 0.1;
        // Color radius for range checking in HSV color space
        private Scalar mColorRadius = new Scalar(25, 50, 50, 0);
        private Mat mSpectrum = new Mat();
        private List<MatOfPoint> mContours = new List<MatOfPoint>();

        // Cache
        Mat mPyrDownMat = new Mat();
        Mat mHsvMat = new Mat();
        Mat mMask = new Mat();
        Mat mDilatedMask = new Mat();
        Mat mHierarchy = new Mat();

        public void setColorRadius(Scalar radius)
        {
            Log.Info(TAG, "setColorRadius: " + radius.ToString());
            mColorRadius = radius;
        }

        public void SetHsvColor(Scalar hsvColor)
        {
            Log.Info(TAG, "SetHsvColor: " + hsvColor.ToString());

            double minH = (hsvColor.Val[0] >= mColorRadius.Val[0]) ? hsvColor.Val[0] - mColorRadius.Val[0] : 0;
            double maxH = (hsvColor.Val[0] + mColorRadius.Val[0] <= 255) ? hsvColor.Val[0] + mColorRadius.Val[0] : 255;

            mLowerBound.Val[0] = minH;
            mUpperBound.Val[0] = maxH;

            mLowerBound.Val[1] = hsvColor.Val[1] - mColorRadius.Val[1];
            mUpperBound.Val[1] = hsvColor.Val[1] + mColorRadius.Val[1];

            mLowerBound.Val[2] = hsvColor.Val[2] - mColorRadius.Val[2];
            mUpperBound.Val[2] = hsvColor.Val[2] + mColorRadius.Val[2];

            mLowerBound.Val[3] = 0;
            mUpperBound.Val[3] = 255;

            Mat spectrumHsv = new Mat(1, (int)(maxH - minH), CvType.Cv8uc3);

            for (int j = 0; j < maxH - minH; j++)
            {
                byte[] tmp = { (byte)(minH + j), (byte)255, (byte)255 };
                spectrumHsv.Put(0, j, tmp);
            }

            Imgproc.CvtColor(spectrumHsv, mSpectrum, Imgproc.ColorHsv2rgbFull, 4);
        }

        public Mat Spectrum
        {
            get { return mSpectrum; }
        }

        public void SetMinContourArea(double area)
        {
            Log.Info(TAG, "SetMinContourArea: " + area);
            mMinContourArea = area;
        }

        public void Process(Mat rgbaImage)
        {

            Log.Info(TAG, "Process rgbaImages");

            Imgproc.PyrDown(rgbaImage, mPyrDownMat);
            Imgproc.PyrDown(mPyrDownMat, mPyrDownMat);

            Imgproc.CvtColor(mPyrDownMat, mHsvMat, Imgproc.ColorRgb2hsvFull);

            Core.InRange(mHsvMat, mLowerBound, mUpperBound, mMask);
            Imgproc.Dilate(mMask, mDilatedMask, new Mat());

            IList<MatOfPoint> contours = new JavaList<MatOfPoint>();

            Imgproc.FindContours(mDilatedMask, contours, mHierarchy, Imgproc.RetrExternal, Imgproc.ChainApproxSimple);

            // Find max contour area
            double maxArea = 0;

            foreach (var each in contours)
            {
                MatOfPoint wrapper = each;
                double area = Imgproc.ContourArea(wrapper);
                if (area > maxArea)
                    maxArea = area;
                Log.Info(TAG, "Process rgbaImages\t-- Imgproc.ContourArea(wrapper)");
            }

            // Filter contours by area and resize to fit the original image size
            mContours.Clear();
            foreach (var each in contours)
            {
                MatOfPoint contour = each;
                if (Imgproc.ContourArea(contour) > mMinContourArea * maxArea)
                {
                    Core.Multiply(contour, new Scalar(4, 4), contour);
                    mContours.Add(contour);
                    Log.Info(TAG, "Process rgbaImages\t-- mContours.Add(contour)");
                }
            }
        }

        public List<MatOfPoint> Contours { get { return mContours; } }
    }
}