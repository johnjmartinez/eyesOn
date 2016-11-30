using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/opencv/android",
						"org/opencv/calib3d",
						"org/opencv/core",
						"org/opencv/engine",
						"org/opencv/features2d",
						"org/opencv/imgcodecs",
						"org/opencv/imgproc",
						"org/opencv/ml",
						"org/opencv/objdetect",
						"org/opencv/photo",
						"org/opencv/utils",
						"org/opencv/video",
						"org/opencv/videoio",
					},
					new Converter<string, Type>[]{
						lookup_org_opencv_android_package,
						lookup_org_opencv_calib3d_package,
						lookup_org_opencv_core_package,
						lookup_org_opencv_engine_package,
						lookup_org_opencv_features2d_package,
						lookup_org_opencv_imgcodecs_package,
						lookup_org_opencv_imgproc_package,
						lookup_org_opencv_ml_package,
						lookup_org_opencv_objdetect_package,
						lookup_org_opencv_photo_package,
						lookup_org_opencv_utils_package,
						lookup_org_opencv_video_package,
						lookup_org_opencv_videoio_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_opencv_android_mappings;
		static Type lookup_org_opencv_android_package (string klass)
		{
			if (package_org_opencv_android_mappings == null) {
				package_org_opencv_android_mappings = new string[]{
					"org/opencv/android/BaseLoaderCallback:OpenCV.Android.BaseLoaderCallback",
					"org/opencv/android/Camera2Renderer:OpenCV.Android.Camera2Renderer",
					"org/opencv/android/CameraBridgeViewBase:OpenCV.Android.CameraBridgeViewBase",
					"org/opencv/android/CameraBridgeViewBase$CvCameraViewListenerAdapter:OpenCV.Android.CameraBridgeViewBase/CvCameraViewListenerAdapter",
					"org/opencv/android/CameraGLRendererBase:OpenCV.Android.CameraGLRendererBase",
					"org/opencv/android/CameraGLSurfaceView:OpenCV.Android.CameraGLSurfaceView",
					"org/opencv/android/CameraRenderer:OpenCV.Android.CameraRenderer",
					"org/opencv/android/FpsMeter:OpenCV.Android.FpsMeter",
					"org/opencv/android/JavaCameraView:OpenCV.Android.JavaCameraView",
					"org/opencv/android/JavaCameraView$CameraWorker:OpenCV.Android.JavaCameraView/CameraWorker",
					"org/opencv/android/JavaCameraView$JavaCameraFrame:OpenCV.Android.JavaCameraView/JavaCameraFrame",
					"org/opencv/android/JavaCameraView$JavaCameraSizeAccessor:OpenCV.Android.JavaCameraView/JavaCameraSizeAccessor",
					"org/opencv/android/OpenCVLoader:OpenCV.Android.OpenCVLoader",
					"org/opencv/android/Utils:OpenCV.Android.Utils",
				};
			}

			return Lookup (package_org_opencv_android_mappings, klass);
		}

		static string[] package_org_opencv_calib3d_mappings;
		static Type lookup_org_opencv_calib3d_package (string klass)
		{
			if (package_org_opencv_calib3d_mappings == null) {
				package_org_opencv_calib3d_mappings = new string[]{
					"org/opencv/calib3d/Calib3d:OpenCV.Calib3d.Calib3d",
					"org/opencv/calib3d/StereoBM:OpenCV.Calib3d.StereoBM",
					"org/opencv/calib3d/StereoMatcher:OpenCV.Calib3d.StereoMatcher",
					"org/opencv/calib3d/StereoSGBM:OpenCV.Calib3d.StereoSGBM",
				};
			}

			return Lookup (package_org_opencv_calib3d_mappings, klass);
		}

		static string[] package_org_opencv_core_mappings;
		static Type lookup_org_opencv_core_package (string klass)
		{
			if (package_org_opencv_core_mappings == null) {
				package_org_opencv_core_mappings = new string[]{
					"org/opencv/core/Algorithm:OpenCV.Core.Algorithm",
					"org/opencv/core/Core:OpenCV.Core.Core",
					"org/opencv/core/Core$MinMaxLocResult:OpenCV.Core.Core/MinMaxLocResult",
					"org/opencv/core/CvException:OpenCV.Core.CvException",
					"org/opencv/core/CvType:OpenCV.Core.CvType",
					"org/opencv/core/DMatch:OpenCV.Core.DMatch",
					"org/opencv/core/KeyPoint:OpenCV.Core.KeyPoint",
					"org/opencv/core/Mat:OpenCV.Core.Mat",
					"org/opencv/core/MatOfByte:OpenCV.Core.MatOfByte",
					"org/opencv/core/MatOfDMatch:OpenCV.Core.MatOfDMatch",
					"org/opencv/core/MatOfDouble:OpenCV.Core.MatOfDouble",
					"org/opencv/core/MatOfFloat:OpenCV.Core.MatOfFloat",
					"org/opencv/core/MatOfFloat4:OpenCV.Core.MatOfFloat4",
					"org/opencv/core/MatOfFloat6:OpenCV.Core.MatOfFloat6",
					"org/opencv/core/MatOfInt:OpenCV.Core.MatOfInt",
					"org/opencv/core/MatOfInt4:OpenCV.Core.MatOfInt4",
					"org/opencv/core/MatOfKeyPoint:OpenCV.Core.MatOfKeyPoint",
					"org/opencv/core/MatOfPoint:OpenCV.Core.MatOfPoint",
					"org/opencv/core/MatOfPoint2f:OpenCV.Core.MatOfPoint2f",
					"org/opencv/core/MatOfPoint3:OpenCV.Core.MatOfPoint3",
					"org/opencv/core/MatOfPoint3f:OpenCV.Core.MatOfPoint3f",
					"org/opencv/core/MatOfRect:OpenCV.Core.MatOfRect",
					"org/opencv/core/Point:OpenCV.Core.Point",
					"org/opencv/core/Point3:OpenCV.Core.Point3",
					"org/opencv/core/Range:OpenCV.Core.Range",
					"org/opencv/core/Rect:OpenCV.Core.Rect",
					"org/opencv/core/RotatedRect:OpenCV.Core.RotatedRect",
					"org/opencv/core/Scalar:OpenCV.Core.Scalar",
					"org/opencv/core/Size:OpenCV.Core.Size",
					"org/opencv/core/TermCriteria:OpenCV.Core.TermCriteria",
				};
			}

			return Lookup (package_org_opencv_core_mappings, klass);
		}

		static string[] package_org_opencv_engine_mappings;
		static Type lookup_org_opencv_engine_package (string klass)
		{
			if (package_org_opencv_engine_mappings == null) {
				package_org_opencv_engine_mappings = new string[]{
					"org/opencv/engine/OpenCVEngineInterface$Stub:OpenCV.Engine.OpenCVEngineInterfaceStub",
					"org/opencv/engine/OpenCVEngineInterface$Stub$Proxy:OpenCV.Engine.OpenCVEngineInterfaceStub/Proxy",
				};
			}

			return Lookup (package_org_opencv_engine_mappings, klass);
		}

		static string[] package_org_opencv_features2d_mappings;
		static Type lookup_org_opencv_features2d_package (string klass)
		{
			if (package_org_opencv_features2d_mappings == null) {
				package_org_opencv_features2d_mappings = new string[]{
					"org/opencv/features2d/DescriptorExtractor:OpenCV.Features2d.DescriptorExtractor",
					"org/opencv/features2d/DescriptorMatcher:OpenCV.Features2d.DescriptorMatcher",
					"org/opencv/features2d/FeatureDetector:OpenCV.Features2d.FeatureDetector",
					"org/opencv/features2d/Features2d:OpenCV.Features2d.Features2d",
				};
			}

			return Lookup (package_org_opencv_features2d_mappings, klass);
		}

		static string[] package_org_opencv_imgcodecs_mappings;
		static Type lookup_org_opencv_imgcodecs_package (string klass)
		{
			if (package_org_opencv_imgcodecs_mappings == null) {
				package_org_opencv_imgcodecs_mappings = new string[]{
					"org/opencv/imgcodecs/Imgcodecs:OpenCV.ImgCodecs.Imgcodecs",
				};
			}

			return Lookup (package_org_opencv_imgcodecs_mappings, klass);
		}

		static string[] package_org_opencv_imgproc_mappings;
		static Type lookup_org_opencv_imgproc_package (string klass)
		{
			if (package_org_opencv_imgproc_mappings == null) {
				package_org_opencv_imgproc_mappings = new string[]{
					"org/opencv/imgproc/CLAHE:OpenCV.ImgProc.CLAHE",
					"org/opencv/imgproc/Imgproc:OpenCV.ImgProc.Imgproc",
					"org/opencv/imgproc/LineSegmentDetector:OpenCV.ImgProc.LineSegmentDetector",
					"org/opencv/imgproc/Moments:OpenCV.ImgProc.Moments",
					"org/opencv/imgproc/Subdiv2D:OpenCV.ImgProc.Subdiv2D",
				};
			}

			return Lookup (package_org_opencv_imgproc_mappings, klass);
		}

		static string[] package_org_opencv_ml_mappings;
		static Type lookup_org_opencv_ml_package (string klass)
		{
			if (package_org_opencv_ml_mappings == null) {
				package_org_opencv_ml_mappings = new string[]{
					"org/opencv/ml/ANN_MLP:OpenCV.ML.ANN_MLP",
					"org/opencv/ml/Boost:OpenCV.ML.Boost",
					"org/opencv/ml/DTrees:OpenCV.ML.DTrees",
					"org/opencv/ml/EM:OpenCV.ML.EM",
					"org/opencv/ml/KNearest:OpenCV.ML.KNearest",
					"org/opencv/ml/LogisticRegression:OpenCV.ML.LogisticRegression",
					"org/opencv/ml/Ml:OpenCV.ML.Ml",
					"org/opencv/ml/NormalBayesClassifier:OpenCV.ML.NormalBayesClassifier",
					"org/opencv/ml/RTrees:OpenCV.ML.RTrees",
					"org/opencv/ml/StatModel:OpenCV.ML.StatModel",
					"org/opencv/ml/SVM:OpenCV.ML.SVM",
					"org/opencv/ml/TrainData:OpenCV.ML.TrainData",
				};
			}

			return Lookup (package_org_opencv_ml_mappings, klass);
		}

		static string[] package_org_opencv_objdetect_mappings;
		static Type lookup_org_opencv_objdetect_package (string klass)
		{
			if (package_org_opencv_objdetect_mappings == null) {
				package_org_opencv_objdetect_mappings = new string[]{
					"org/opencv/objdetect/BaseCascadeClassifier:OpenCV.ObjDetect.BaseCascadeClassifier",
					"org/opencv/objdetect/CascadeClassifier:OpenCV.ObjDetect.CascadeClassifier",
					"org/opencv/objdetect/HOGDescriptor:OpenCV.ObjDetect.HOGDescriptor",
					"org/opencv/objdetect/Objdetect:OpenCV.ObjDetect.Objdetect",
				};
			}

			return Lookup (package_org_opencv_objdetect_mappings, klass);
		}

		static string[] package_org_opencv_photo_mappings;
		static Type lookup_org_opencv_photo_package (string klass)
		{
			if (package_org_opencv_photo_mappings == null) {
				package_org_opencv_photo_mappings = new string[]{
					"org/opencv/photo/AlignExposures:OpenCV.Photo.AlignExposures",
					"org/opencv/photo/AlignMTB:OpenCV.Photo.AlignMTB",
					"org/opencv/photo/CalibrateCRF:OpenCV.Photo.CalibrateCRF",
					"org/opencv/photo/CalibrateDebevec:OpenCV.Photo.CalibrateDebevec",
					"org/opencv/photo/CalibrateRobertson:OpenCV.Photo.CalibrateRobertson",
					"org/opencv/photo/MergeDebevec:OpenCV.Photo.MergeDebevec",
					"org/opencv/photo/MergeExposures:OpenCV.Photo.MergeExposures",
					"org/opencv/photo/MergeMertens:OpenCV.Photo.MergeMertens",
					"org/opencv/photo/MergeRobertson:OpenCV.Photo.MergeRobertson",
					"org/opencv/photo/Photo:OpenCV.Photo.Photo",
					"org/opencv/photo/Tonemap:OpenCV.Photo.Tonemap",
					"org/opencv/photo/TonemapDrago:OpenCV.Photo.TonemapDrago",
					"org/opencv/photo/TonemapDurand:OpenCV.Photo.TonemapDurand",
					"org/opencv/photo/TonemapMantiuk:OpenCV.Photo.TonemapMantiuk",
					"org/opencv/photo/TonemapReinhard:OpenCV.Photo.TonemapReinhard",
				};
			}

			return Lookup (package_org_opencv_photo_mappings, klass);
		}

		static string[] package_org_opencv_utils_mappings;
		static Type lookup_org_opencv_utils_package (string klass)
		{
			if (package_org_opencv_utils_mappings == null) {
				package_org_opencv_utils_mappings = new string[]{
					"org/opencv/utils/Converters:OpenCV.Utils.Converters",
				};
			}

			return Lookup (package_org_opencv_utils_mappings, klass);
		}

		static string[] package_org_opencv_video_mappings;
		static Type lookup_org_opencv_video_package (string klass)
		{
			if (package_org_opencv_video_mappings == null) {
				package_org_opencv_video_mappings = new string[]{
					"org/opencv/video/BackgroundSubtractor:OpenCV.Video.BackgroundSubtractor",
					"org/opencv/video/BackgroundSubtractorKNN:OpenCV.Video.BackgroundSubtractorKNN",
					"org/opencv/video/BackgroundSubtractorMOG2:OpenCV.Video.BackgroundSubtractorMOG2",
					"org/opencv/video/DenseOpticalFlow:OpenCV.Video.DenseOpticalFlow",
					"org/opencv/video/DualTVL1OpticalFlow:OpenCV.Video.DualTVL1OpticalFlow",
					"org/opencv/video/KalmanFilter:OpenCV.Video.KalmanFilter",
					"org/opencv/video/Video:OpenCV.Video.Video",
				};
			}

			return Lookup (package_org_opencv_video_mappings, klass);
		}

		static string[] package_org_opencv_videoio_mappings;
		static Type lookup_org_opencv_videoio_package (string klass)
		{
			if (package_org_opencv_videoio_mappings == null) {
				package_org_opencv_videoio_mappings = new string[]{
					"org/opencv/videoio/VideoCapture:OpenCV.VideoIO.VideoCapture",
					"org/opencv/videoio/Videoio:OpenCV.VideoIO.Videoio",
					"org/opencv/videoio/VideoWriter:OpenCV.VideoIO.VideoWriter",
				};
			}

			return Lookup (package_org_opencv_videoio_mappings, klass);
		}
	}
}
