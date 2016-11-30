using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Features2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']"
	[global::Android.Runtime.Register ("org/opencv/features2d/FeatureDetector", DoNotGenerateAcw=true)]
	public partial class FeatureDetector : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='AKAZE']"
		[Register ("AKAZE")]
		public const int Akaze = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='BRISK']"
		[Register ("BRISK")]
		public const int Brisk = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DENSE']"
		[Register ("DENSE")]
		public const int Dense = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_AKAZE']"
		[Register ("DYNAMIC_AKAZE")]
		public const int DynamicAkaze = (int) 3012;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_BRISK']"
		[Register ("DYNAMIC_BRISK")]
		public const int DynamicBrisk = (int) 3011;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_DENSE']"
		[Register ("DYNAMIC_DENSE")]
		public const int DynamicDense = (int) 3010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_FAST']"
		[Register ("DYNAMIC_FAST")]
		public const int DynamicFast = (int) 3001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_GFTT']"
		[Register ("DYNAMIC_GFTT")]
		public const int DynamicGftt = (int) 3007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_HARRIS']"
		[Register ("DYNAMIC_HARRIS")]
		public const int DynamicHarris = (int) 3008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_MSER']"
		[Register ("DYNAMIC_MSER")]
		public const int DynamicMser = (int) 3006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_ORB']"
		[Register ("DYNAMIC_ORB")]
		public const int DynamicOrb = (int) 3005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_SIFT']"
		[Register ("DYNAMIC_SIFT")]
		public const int DynamicSift = (int) 3003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_SIMPLEBLOB']"
		[Register ("DYNAMIC_SIMPLEBLOB")]
		public const int DynamicSimpleblob = (int) 3009;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_STAR']"
		[Register ("DYNAMIC_STAR")]
		public const int DynamicStar = (int) 3002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='DYNAMIC_SURF']"
		[Register ("DYNAMIC_SURF")]
		public const int DynamicSurf = (int) 3004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='FAST']"
		[Register ("FAST")]
		public const int Fast = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GFTT']"
		[Register ("GFTT")]
		public const int Gftt = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_AKAZE']"
		[Register ("GRID_AKAZE")]
		public const int GridAkaze = (int) 1012;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_BRISK']"
		[Register ("GRID_BRISK")]
		public const int GridBrisk = (int) 1011;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_DENSE']"
		[Register ("GRID_DENSE")]
		public const int GridDense = (int) 1010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_FAST']"
		[Register ("GRID_FAST")]
		public const int GridFast = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_GFTT']"
		[Register ("GRID_GFTT")]
		public const int GridGftt = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_HARRIS']"
		[Register ("GRID_HARRIS")]
		public const int GridHarris = (int) 1008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_MSER']"
		[Register ("GRID_MSER")]
		public const int GridMser = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_ORB']"
		[Register ("GRID_ORB")]
		public const int GridOrb = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_SIFT']"
		[Register ("GRID_SIFT")]
		public const int GridSift = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_SIMPLEBLOB']"
		[Register ("GRID_SIMPLEBLOB")]
		public const int GridSimpleblob = (int) 1009;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_STAR']"
		[Register ("GRID_STAR")]
		public const int GridStar = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='GRID_SURF']"
		[Register ("GRID_SURF")]
		public const int GridSurf = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='HARRIS']"
		[Register ("HARRIS")]
		public const int Harris = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='MSER']"
		[Register ("MSER")]
		public const int Mser = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='ORB']"
		[Register ("ORB")]
		public const int Orb = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_AKAZE']"
		[Register ("PYRAMID_AKAZE")]
		public const int PyramidAkaze = (int) 2012;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_BRISK']"
		[Register ("PYRAMID_BRISK")]
		public const int PyramidBrisk = (int) 2011;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_DENSE']"
		[Register ("PYRAMID_DENSE")]
		public const int PyramidDense = (int) 2010;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_FAST']"
		[Register ("PYRAMID_FAST")]
		public const int PyramidFast = (int) 2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_GFTT']"
		[Register ("PYRAMID_GFTT")]
		public const int PyramidGftt = (int) 2007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_HARRIS']"
		[Register ("PYRAMID_HARRIS")]
		public const int PyramidHarris = (int) 2008;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_MSER']"
		[Register ("PYRAMID_MSER")]
		public const int PyramidMser = (int) 2006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_ORB']"
		[Register ("PYRAMID_ORB")]
		public const int PyramidOrb = (int) 2005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_SIFT']"
		[Register ("PYRAMID_SIFT")]
		public const int PyramidSift = (int) 2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_SIMPLEBLOB']"
		[Register ("PYRAMID_SIMPLEBLOB")]
		public const int PyramidSimpleblob = (int) 2009;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_STAR']"
		[Register ("PYRAMID_STAR")]
		public const int PyramidStar = (int) 2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='PYRAMID_SURF']"
		[Register ("PYRAMID_SURF")]
		public const int PyramidSurf = (int) 2004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='SIFT']"
		[Register ("SIFT")]
		public const int Sift = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='SIMPLEBLOB']"
		[Register ("SIMPLEBLOB")]
		public const int Simpleblob = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='STAR']"
		[Register ("STAR")]
		public const int Star = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='SURF']"
		[Register ("SURF")]
		public const int Surf = (int) 4;

		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		protected long NativeObj {
			get {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId);
			}
			set {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/features2d/FeatureDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeatureDetector); }
		}

		protected FeatureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/constructor[@name='FeatureDetector' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe FeatureDetector (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FeatureDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/opencv/features2d/FeatureDetector;", "")]
		public static unsafe global::OpenCV.Features2d.FeatureDetector Create (int p0)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lorg/opencv/features2d/FeatureDetector;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_detect_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDetect_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_detect_Ljava_util_List_Ljava_util_List_ == null)
				cb_detect_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Ljava_util_List_Ljava_util_List_);
			return cb_detect_Ljava_util_List_Ljava_util_List_;
		}

		static void n_Detect_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='detect' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfKeyPoint&gt;']]"
		[Register ("detect", "(Ljava/util/List;Ljava/util/List;)V", "GetDetect_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void Detect (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfKeyPoint> p1)
		{
			if (id_detect_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_detect_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "detect", "(Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDetect_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
				cb_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_);
			return cb_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		static void n_Detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='detect' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfKeyPoint&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("detect", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetDetect_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void Detect (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfKeyPoint> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2)
		{
			if (id_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "detect", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Ljava_util_List_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfKeyPoint p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfKeyPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='detect' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfKeyPoint p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfKeyPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='detect' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetMethodID (class_ref, "empty", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_empty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "empty", "()Z"));
			} finally {
			}
		}

		static Delegate cb_read_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_lang_String_Handler ()
		{
			if (cb_read_Ljava_lang_String_ == null)
				cb_read_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_lang_String_);
			return cb_read_Ljava_lang_String_;
		}

		static void n_Read_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)V", "GetRead_Ljava_lang_String_Handler")]
		public virtual unsafe void Read (string p0)
		{
			if (id_read_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_String_Handler ()
		{
			if (cb_write_Ljava_lang_String_ == null)
				cb_write_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_String_);
			return cb_write_Ljava_lang_String_;
		}

		static void n_Write_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.FeatureDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.FeatureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='FeatureDetector']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("write", "(Ljava/lang/String;)V", "GetWrite_Ljava_lang_String_Handler")]
		public virtual unsafe void Write (string p0)
		{
			if (id_write_Ljava_lang_String_ == IntPtr.Zero)
				id_write_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
