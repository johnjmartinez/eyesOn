using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']"
	[global::Android.Runtime.Register ("org/opencv/video/Video", DoNotGenerateAcw=true)]
	public partial class Video : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='MOTION_AFFINE']"
		[Register ("MOTION_AFFINE")]
		public const int MotionAffine = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='MOTION_EUCLIDEAN']"
		[Register ("MOTION_EUCLIDEAN")]
		public const int MotionEuclidean = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='MOTION_HOMOGRAPHY']"
		[Register ("MOTION_HOMOGRAPHY")]
		public const int MotionHomography = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='MOTION_TRANSLATION']"
		[Register ("MOTION_TRANSLATION")]
		public const int MotionTranslation = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='OPTFLOW_FARNEBACK_GAUSSIAN']"
		[Register ("OPTFLOW_FARNEBACK_GAUSSIAN")]
		public const int OptflowFarnebackGaussian = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='OPTFLOW_LK_GET_MIN_EIGENVALS']"
		[Register ("OPTFLOW_LK_GET_MIN_EIGENVALS")]
		public const int OptflowLkGetMinEigenvals = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/field[@name='OPTFLOW_USE_INITIAL_FLOW']"
		[Register ("OPTFLOW_USE_INITIAL_FLOW")]
		public const int OptflowUseInitialFlow = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/Video", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Video); }
		}

		protected Video (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/constructor[@name='Video' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Video ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Video)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_CamShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='CamShift' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Rect'] and parameter[3][@type='org.opencv.core.TermCriteria']]"
		[Register ("CamShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/TermCriteria;)Lorg/opencv/core/RotatedRect;", "")]
		public static unsafe global::OpenCV.Core.RotatedRect CamShift (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Rect p1, global::OpenCV.Core.TermCriteria p2)
		{
			if (id_CamShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_CamShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "CamShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/TermCriteria;)Lorg/opencv/core/RotatedRect;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.RotatedRect __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_CamShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='buildOpticalFlowPyramid' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int']]"
		[Register ("buildOpticalFlowPyramid", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Size;I)I", "")]
		public static unsafe int BuildOpticalFlowPyramid (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, int p3)
		{
			if (id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "buildOpticalFlowPyramid", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Size;I)I");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_IZIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='buildOpticalFlowPyramid' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register ("buildOpticalFlowPyramid", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Size;IZIIZ)I", "")]
		public static unsafe int BuildOpticalFlowPyramid (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, int p3, bool p4, int p5, int p6, bool p7)
		{
			if (id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_IZIIZ == IntPtr.Zero)
				id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_IZIIZ = JNIEnv.GetStaticMethodID (class_ref, "buildOpticalFlowPyramid", "(Lorg/opencv/core/Mat;Ljava/util/List;Lorg/opencv/core/Size;IZIIZ)I");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_buildOpticalFlowPyramid_Lorg_opencv_core_Mat_Ljava_util_List_Lorg_opencv_core_Size_IZIIZ, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_calcOpticalFlowFarneback_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIIIDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='calcOpticalFlowFarneback' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='double'] and parameter[10][@type='int']]"
		[Register ("calcOpticalFlowFarneback", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DIIIIDI)V", "")]
		public static unsafe void CalcOpticalFlowFarneback (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3, int p4, int p5, int p6, int p7, double p8, int p9)
		{
			if (id_calcOpticalFlowFarneback_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIIIDI == IntPtr.Zero)
				id_calcOpticalFlowFarneback_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIIIDI = JNIEnv.GetStaticMethodID (class_ref, "calcOpticalFlowFarneback", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DIIIIDI)V");
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcOpticalFlowFarneback_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DIIIIDI, __args);
			} finally {
			}
		}

		static IntPtr id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='calcOpticalFlowPyrLK' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfPoint2f'] and parameter[4][@type='org.opencv.core.MatOfPoint2f'] and parameter[5][@type='org.opencv.core.MatOfByte'] and parameter[6][@type='org.opencv.core.MatOfFloat']]"
		[Register ("calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;)V", "")]
		public static unsafe void CalcOpticalFlowPyrLK (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfPoint2f p2, global::OpenCV.Core.MatOfPoint2f p3, global::OpenCV.Core.MatOfByte p4, global::OpenCV.Core.MatOfFloat p5)
		{
			if (id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_ == IntPtr.Zero)
				id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_ = JNIEnv.GetStaticMethodID (class_ref, "calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_, __args);
			} finally {
			}
		}

		static IntPtr id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='calcOpticalFlowPyrLK' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfPoint2f'] and parameter[4][@type='org.opencv.core.MatOfPoint2f'] and parameter[5][@type='org.opencv.core.MatOfByte'] and parameter[6][@type='org.opencv.core.MatOfFloat'] and parameter[7][@type='org.opencv.core.Size'] and parameter[8][@type='int']]"
		[Register ("calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;I)V", "")]
		public static unsafe void CalcOpticalFlowPyrLK (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfPoint2f p2, global::OpenCV.Core.MatOfPoint2f p3, global::OpenCV.Core.MatOfByte p4, global::OpenCV.Core.MatOfFloat p5, global::OpenCV.Core.Size p6, int p7)
		{
			if (id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_ILorg_opencv_core_TermCriteria_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='calcOpticalFlowPyrLK' and count(parameter)=11 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfPoint2f'] and parameter[4][@type='org.opencv.core.MatOfPoint2f'] and parameter[5][@type='org.opencv.core.MatOfByte'] and parameter[6][@type='org.opencv.core.MatOfFloat'] and parameter[7][@type='org.opencv.core.Size'] and parameter[8][@type='int'] and parameter[9][@type='org.opencv.core.TermCriteria'] and parameter[10][@type='int'] and parameter[11][@type='double']]"
		[Register ("calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;ILorg/opencv/core/TermCriteria;ID)V", "")]
		public static unsafe void CalcOpticalFlowPyrLK (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfPoint2f p2, global::OpenCV.Core.MatOfPoint2f p3, global::OpenCV.Core.MatOfByte p4, global::OpenCV.Core.MatOfFloat p5, global::OpenCV.Core.Size p6, int p7, global::OpenCV.Core.TermCriteria p8, int p9, double p10)
		{
			if (id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_ILorg_opencv_core_TermCriteria_ID == IntPtr.Zero)
				id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_ILorg_opencv_core_TermCriteria_ID = JNIEnv.GetStaticMethodID (class_ref, "calcOpticalFlowPyrLK", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfByte;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;ILorg/opencv/core/TermCriteria;ID)V");
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calcOpticalFlowPyrLK_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfByte_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_ILorg_opencv_core_TermCriteria_ID, __args);
			} finally {
			}
		}

		static IntPtr id_createBackgroundSubtractorKNN;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='createBackgroundSubtractorKNN' and count(parameter)=0]"
		[Register ("createBackgroundSubtractorKNN", "()Lorg/opencv/video/BackgroundSubtractorKNN;", "")]
		public static unsafe global::OpenCV.Video.BackgroundSubtractorKNN CreateBackgroundSubtractorKNN ()
		{
			if (id_createBackgroundSubtractorKNN == IntPtr.Zero)
				id_createBackgroundSubtractorKNN = JNIEnv.GetStaticMethodID (class_ref, "createBackgroundSubtractorKNN", "()Lorg/opencv/video/BackgroundSubtractorKNN;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBackgroundSubtractorKNN), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createBackgroundSubtractorKNN_IDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='createBackgroundSubtractorKNN' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='boolean']]"
		[Register ("createBackgroundSubtractorKNN", "(IDZ)Lorg/opencv/video/BackgroundSubtractorKNN;", "")]
		public static unsafe global::OpenCV.Video.BackgroundSubtractorKNN CreateBackgroundSubtractorKNN (int p0, double p1, bool p2)
		{
			if (id_createBackgroundSubtractorKNN_IDZ == IntPtr.Zero)
				id_createBackgroundSubtractorKNN_IDZ = JNIEnv.GetStaticMethodID (class_ref, "createBackgroundSubtractorKNN", "(IDZ)Lorg/opencv/video/BackgroundSubtractorKNN;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBackgroundSubtractorKNN_IDZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createBackgroundSubtractorMOG2;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='createBackgroundSubtractorMOG2' and count(parameter)=0]"
		[Register ("createBackgroundSubtractorMOG2", "()Lorg/opencv/video/BackgroundSubtractorMOG2;", "")]
		public static unsafe global::OpenCV.Video.BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 ()
		{
			if (id_createBackgroundSubtractorMOG2 == IntPtr.Zero)
				id_createBackgroundSubtractorMOG2 = JNIEnv.GetStaticMethodID (class_ref, "createBackgroundSubtractorMOG2", "()Lorg/opencv/video/BackgroundSubtractorMOG2;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBackgroundSubtractorMOG2), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createBackgroundSubtractorMOG2_IDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='createBackgroundSubtractorMOG2' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='boolean']]"
		[Register ("createBackgroundSubtractorMOG2", "(IDZ)Lorg/opencv/video/BackgroundSubtractorMOG2;", "")]
		public static unsafe global::OpenCV.Video.BackgroundSubtractorMOG2 CreateBackgroundSubtractorMOG2 (int p0, double p1, bool p2)
		{
			if (id_createBackgroundSubtractorMOG2_IDZ == IntPtr.Zero)
				id_createBackgroundSubtractorMOG2_IDZ = JNIEnv.GetStaticMethodID (class_ref, "createBackgroundSubtractorMOG2", "(IDZ)Lorg/opencv/video/BackgroundSubtractorMOG2;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBackgroundSubtractorMOG2_IDZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createOptFlow_DualTVL1;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='createOptFlow_DualTVL1' and count(parameter)=0]"
		[Register ("createOptFlow_DualTVL1", "()Lorg/opencv/video/DualTVL1OpticalFlow;", "")]
		public static unsafe global::OpenCV.Video.DualTVL1OpticalFlow CreateOptFlow_DualTVL1 ()
		{
			if (id_createOptFlow_DualTVL1 == IntPtr.Zero)
				id_createOptFlow_DualTVL1 = JNIEnv.GetStaticMethodID (class_ref, "createOptFlow_DualTVL1", "()Lorg/opencv/video/DualTVL1OpticalFlow;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Video.DualTVL1OpticalFlow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOptFlow_DualTVL1), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_estimateRigidTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='estimateRigidTransform' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='boolean']]"
		[Register ("estimateRigidTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat EstimateRigidTransform (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, bool p2)
		{
			if (id_estimateRigidTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_estimateRigidTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "estimateRigidTransform", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_estimateRigidTransform_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='findTransformECC' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double FindTransformECC (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='findTransformECC' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double FindTransformECC (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='findTransformECC' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.TermCriteria'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double FindTransformECC (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, global::OpenCV.Core.TermCriteria p4, global::OpenCV.Core.Mat p5)
		{
			if (id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findTransformECC", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_findTransformECC_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_meanShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='Video']/method[@name='meanShift' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Rect'] and parameter[3][@type='org.opencv.core.TermCriteria']]"
		[Register ("meanShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/TermCriteria;)I", "")]
		public static unsafe int MeanShift (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Rect p1, global::OpenCV.Core.TermCriteria p2)
		{
			if (id_meanShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_meanShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "meanShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;Lorg/opencv/core/TermCriteria;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_meanShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_Lorg_opencv_core_TermCriteria_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
