using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']"
	[global::Android.Runtime.Register ("org/opencv/utils/Converters", DoNotGenerateAcw=true)]
	public partial class Converters : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/utils/Converters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Converters); }
		}

		protected Converters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/constructor[@name='Converters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Converters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Converters)) {
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

		static IntPtr id_Mat_to_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_DMatch' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.DMatch&gt;']]"
		[Register ("Mat_to_vector_DMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_DMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.DMatch> p1)
		{
			if (id_Mat_to_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_DMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.DMatch>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_KeyPoint' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.KeyPoint&gt;']]"
		[Register ("Mat_to_vector_KeyPoint", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_KeyPoint (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.KeyPoint> p1)
		{
			if (id_Mat_to_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_KeyPoint", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.KeyPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Mat_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Mat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("Mat_to_vector_Mat", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Mat (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_Mat_to_vector_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Mat", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Mat_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point2d_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point2d' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("Mat_to_vector_Point2d", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point2d (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p1)
		{
			if (id_Mat_to_vector_Point2d_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point2d_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point2d", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point2d_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point2f' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("Mat_to_vector_Point2f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point2f (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p1)
		{
			if (id_Mat_to_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point2f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point3_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point3' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("Mat_to_vector_Point3", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point3 (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p1)
		{
			if (id_Mat_to_vector_Point3_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point3_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point3", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point3_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point3d_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point3d' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("Mat_to_vector_Point3d", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point3d (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p1)
		{
			if (id_Mat_to_vector_Point3d_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point3d_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point3d", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point3d_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point3f' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("Mat_to_vector_Point3f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point3f (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p1)
		{
			if (id_Mat_to_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point3f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point3i_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point3i' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("Mat_to_vector_Point3i", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point3i (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p1)
		{
			if (id_Mat_to_vector_Point3i_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point3i_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point3i", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point3i_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Point' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("Mat_to_vector_Point", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Point (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p1)
		{
			if (id_Mat_to_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Point", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_Rect_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_Rect' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Rect&gt;']]"
		[Register ("Mat_to_vector_Rect", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_Rect (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Rect> p1)
		{
			if (id_Mat_to_vector_Rect_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_Rect_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_Rect", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Rect>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_Rect_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_char' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.lang.Byte&gt;']]"
		[Register ("Mat_to_vector_char", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_char (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_Mat_to_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_char", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_double_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_double' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("Mat_to_vector_double", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_double (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::Java.Lang.Double> p1)
		{
			if (id_Mat_to_vector_double_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_double_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_double", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_double_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_float_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_float' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.lang.Float&gt;']]"
		[Register ("Mat_to_vector_float", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_float (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::Java.Lang.Float> p1)
		{
			if (id_Mat_to_vector_float_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_float_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_float", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_float_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_int_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_int' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("Mat_to_vector_int", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_int (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::Java.Lang.Integer> p1)
		{
			if (id_Mat_to_vector_int_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_int_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_int", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_int_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_uchar_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_uchar' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.lang.Byte&gt;']]"
		[Register ("Mat_to_vector_uchar", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_uchar (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_Mat_to_vector_uchar_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_uchar_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_uchar", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_uchar_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_DMatch' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;']]"
		[Register ("Mat_to_vector_vector_DMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_DMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p1)
		{
			if (id_Mat_to_vector_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_DMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_DMatch_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_KeyPoint' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfKeyPoint&gt;']]"
		[Register ("Mat_to_vector_vector_KeyPoint", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_KeyPoint (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfKeyPoint> p1)
		{
			if (id_Mat_to_vector_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_KeyPoint", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_KeyPoint_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_Point2f' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint2f&gt;']]"
		[Register ("Mat_to_vector_vector_Point2f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_Point2f (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint2f> p1)
		{
			if (id_Mat_to_vector_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_Point2f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_Point2f_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_Point3f' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint3f&gt;']]"
		[Register ("Mat_to_vector_vector_Point3f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_Point3f (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint3f> p1)
		{
			if (id_Mat_to_vector_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_Point3f", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint3f>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_Point3f_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_Point' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;']]"
		[Register ("Mat_to_vector_vector_Point", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_Point (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p1)
		{
			if (id_Mat_to_vector_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_Point", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_Point_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Mat_to_vector_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='Mat_to_vector_vector_char' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;java.lang.Byte&gt;&gt;']]"
		[Register ("Mat_to_vector_vector_char", "(Lorg/opencv/core/Mat;Ljava/util/List;)V", "")]
		public static unsafe void Mat_to_vector_vector_char (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Java.Lang.Byte>> p1)
		{
			if (id_Mat_to_vector_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_Mat_to_vector_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "Mat_to_vector_vector_char", "(Lorg/opencv/core/Mat;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Java.Lang.Byte>>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Mat_to_vector_vector_char_Lorg_opencv_core_Mat_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_DMatch_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_DMatch_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.DMatch&gt;']]"
		[Register ("vector_DMatch_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_DMatch_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.DMatch> p0)
		{
			if (id_vector_DMatch_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_DMatch_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_DMatch_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.DMatch>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_DMatch_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_KeyPoint_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_KeyPoint_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.KeyPoint&gt;']]"
		[Register ("vector_KeyPoint_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_KeyPoint_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.KeyPoint> p0)
		{
			if (id_vector_KeyPoint_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_KeyPoint_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_KeyPoint_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.KeyPoint>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_KeyPoint_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Mat_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Mat_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_Mat_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Mat_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0)
		{
			if (id_vector_Mat_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Mat_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Mat_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Mat_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point2d_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point2d_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("vector_Point2d_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point2d_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p0)
		{
			if (id_vector_Point2d_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point2d_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point2d_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point2d_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point2f_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point2f_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("vector_Point2f_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point2f_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p0)
		{
			if (id_vector_Point2f_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point2f_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point2f_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point2f_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point3_to_Mat_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point3_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point3&gt;'] and parameter[2][@type='int']]"
		[Register ("vector_Point3_to_Mat", "(Ljava/util/List;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point3_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p0, int p1)
		{
			if (id_vector_Point3_to_Mat_Ljava_util_List_I == IntPtr.Zero)
				id_vector_Point3_to_Mat_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "vector_Point3_to_Mat", "(Ljava/util/List;I)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point3_to_Mat_Ljava_util_List_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point3d_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point3d_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("vector_Point3d_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point3d_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p0)
		{
			if (id_vector_Point3d_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point3d_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point3d_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point3d_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point3f_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point3f_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("vector_Point3f_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point3f_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p0)
		{
			if (id_vector_Point3f_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point3f_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point3f_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point3f_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point3i_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point3i_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point3&gt;']]"
		[Register ("vector_Point3i_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point3i_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point3> p0)
		{
			if (id_vector_Point3i_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point3i_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point3i_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point3>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point3i_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point&gt;']]"
		[Register ("vector_Point_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p0)
		{
			if (id_vector_Point_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Point_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Point_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Point_to_Mat_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Point_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Point&gt;'] and parameter[2][@type='int']]"
		[Register ("vector_Point_to_Mat", "(Ljava/util/List;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Point_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Point> p0, int p1)
		{
			if (id_vector_Point_to_Mat_Ljava_util_List_I == IntPtr.Zero)
				id_vector_Point_to_Mat_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "vector_Point_to_Mat", "(Ljava/util/List;I)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Point>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Point_to_Mat_Ljava_util_List_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_Rect_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_Rect_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Rect&gt;']]"
		[Register ("vector_Rect_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_Rect_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.Rect> p0)
		{
			if (id_vector_Rect_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_Rect_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_Rect_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Rect>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_Rect_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_char_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_char_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Byte&gt;']]"
		[Register ("vector_char_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_char_to_Mat (global::System.Collections.Generic.IList<global::Java.Lang.Byte> p0)
		{
			if (id_vector_char_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_char_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_char_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_char_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_double_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_double_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("vector_double_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_double_to_Mat (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_vector_double_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_double_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_double_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_double_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_float_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_float_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Float&gt;']]"
		[Register ("vector_float_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_float_to_Mat (global::System.Collections.Generic.IList<global::Java.Lang.Float> p0)
		{
			if (id_vector_float_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_float_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_float_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_float_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_int_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_int_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("vector_int_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_int_to_Mat (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_vector_int_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_int_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_int_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_int_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_uchar_to_Mat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_uchar_to_Mat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Byte&gt;']]"
		[Register ("vector_uchar_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_uchar_to_Mat (global::System.Collections.Generic.IList<global::Java.Lang.Byte> p0)
		{
			if (id_vector_uchar_to_Mat_Ljava_util_List_ == IntPtr.Zero)
				id_vector_uchar_to_Mat_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_uchar_to_Mat", "(Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_uchar_to_Mat_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_vector_vector_DMatch_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_DMatch_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_DMatch_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_DMatch_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_DMatch_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_DMatch_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_DMatch_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_DMatch_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_vector_KeyPoint_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_KeyPoint_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfKeyPoint&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_KeyPoint_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_KeyPoint_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfKeyPoint> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_KeyPoint_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_KeyPoint_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_KeyPoint_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_KeyPoint_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_vector_Point2f_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_Point2f_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfPoint2f&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_Point2f_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_Point2f_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint2f> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_Point2f_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_Point2f_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_Point2f_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_Point2f_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_vector_Point3f_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_Point3f_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfPoint3f&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_Point3f_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_Point3f_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint3f> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_Point3f_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_Point3f_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_Point3f_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint3f>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_Point3f_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_vector_Point_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_Point_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfPoint&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_Point_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_Point_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_Point_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_Point_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_Point_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_Point_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_vector_vector_char_to_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.utils']/class[@name='Converters']/method[@name='vector_vector_char_to_Mat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfByte&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("vector_vector_char_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Vector_vector_char_to_Mat (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfByte> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_vector_vector_char_to_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_vector_vector_char_to_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "vector_vector_char_to_Mat", "(Ljava/util/List;Ljava/util/List;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfByte>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vector_vector_char_to_Mat_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
