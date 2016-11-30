using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Features2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']"
	[global::Android.Runtime.Register ("org/opencv/features2d/Features2d", DoNotGenerateAcw=true)]
	public partial class Features2d : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/field[@name='DRAW_OVER_OUTIMG']"
		[Register ("DRAW_OVER_OUTIMG")]
		public const int DrawOverOutimg = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/field[@name='DRAW_RICH_KEYPOINTS']"
		[Register ("DRAW_RICH_KEYPOINTS")]
		public const int DrawRichKeypoints = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/field[@name='NOT_DRAW_SINGLE_POINTS']"
		[Register ("NOT_DRAW_SINGLE_POINTS")]
		public const int NotDrawSinglePoints = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/features2d/Features2d", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Features2d); }
		}

		protected Features2d (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/constructor[@name='Features2d' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Features2d ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Features2d)) {
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

		static IntPtr id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawKeypoints' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("drawKeypoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DrawKeypoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2)
		{
			if (id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "drawKeypoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawKeypoints' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Scalar'] and parameter[5][@type='int']]"
		[Register ("drawKeypoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;I)V", "")]
		public static unsafe void DrawKeypoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Scalar p3, int p4)
		{
			if (id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_I == IntPtr.Zero)
				id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_I = JNIEnv.GetStaticMethodID (class_ref, "drawKeypoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawKeypoints_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_I, __args);
			} finally {
			}
		}

		static IntPtr id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawMatches2' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfKeyPoint'] and parameter[5][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("drawMatches2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Ljava/util/List;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DrawMatches2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfKeyPoint p3, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p4, global::OpenCV.Core.Mat p5)
		{
			if (id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "drawMatches2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawMatches2' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfKeyPoint'] and parameter[5][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Scalar'] and parameter[8][@type='org.opencv.core.Scalar'] and parameter[9][@type='java.util.List&lt;org.opencv.core.MatOfByte&gt;'] and parameter[10][@type='int']]"
		[Register ("drawMatches2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Ljava/util/List;I)V", "")]
		public static unsafe void DrawMatches2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfKeyPoint p3, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Scalar p6, global::OpenCV.Core.Scalar p7, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfByte> p8, int p9)
		{
			if (id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Ljava_util_List_I == IntPtr.Zero)
				id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "drawMatches2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Ljava/util/List;I)V");
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p4);
			IntPtr native_p8 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfByte>.ToLocalJniHandle (p8);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMatches2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Ljava_util_List_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static IntPtr id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawMatches' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfKeyPoint'] and parameter[5][@type='org.opencv.core.MatOfDMatch'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("drawMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DrawMatches (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfKeyPoint p3, global::OpenCV.Core.MatOfDMatch p4, global::OpenCV.Core.Mat p5)
		{
			if (id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "drawMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_MatOfByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='Features2d']/method[@name='drawMatches' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfKeyPoint'] and parameter[5][@type='org.opencv.core.MatOfDMatch'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Scalar'] and parameter[8][@type='org.opencv.core.Scalar'] and parameter[9][@type='org.opencv.core.MatOfByte'] and parameter[10][@type='int']]"
		[Register ("drawMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Lorg/opencv/core/MatOfByte;I)V", "")]
		public static unsafe void DrawMatches (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfKeyPoint p3, global::OpenCV.Core.MatOfDMatch p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Scalar p6, global::OpenCV.Core.Scalar p7, global::OpenCV.Core.MatOfByte p8, int p9)
		{
			if (id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_MatOfByte_I == IntPtr.Zero)
				id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_MatOfByte_I = JNIEnv.GetStaticMethodID (class_ref, "drawMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;Lorg/opencv/core/Scalar;Lorg/opencv/core/Scalar;Lorg/opencv/core/MatOfByte;I)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Scalar_Lorg_opencv_core_Scalar_Lorg_opencv_core_MatOfByte_I, __args);
			} finally {
			}
		}

	}
}
