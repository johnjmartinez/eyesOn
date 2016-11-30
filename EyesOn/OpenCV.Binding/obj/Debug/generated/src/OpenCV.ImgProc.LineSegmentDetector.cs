using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ImgProc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']"
	[global::Android.Runtime.Register ("org/opencv/imgproc/LineSegmentDetector", DoNotGenerateAcw=true)]
	public partial class LineSegmentDetector : global::OpenCV.Core.Algorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/imgproc/LineSegmentDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LineSegmentDetector); }
		}

		protected LineSegmentDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/constructor[@name='LineSegmentDetector' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe LineSegmentDetector (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LineSegmentDetector)) {
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

		static Delegate cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_CompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static int n_CompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ImgProc.LineSegmentDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareSegments (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/method[@name='compareSegments' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "GetCompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe int CompareSegments (global::OpenCV.Core.Size p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_CompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static int n_CompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::OpenCV.ImgProc.LineSegmentDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareSegments (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/method[@name='compareSegments' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "GetCompareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe int CompareSegments (global::OpenCV.Core.Size p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareSegments_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareSegments", "(Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.LineSegmentDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/method[@name='detect' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::OpenCV.ImgProc.LineSegmentDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/method[@name='detect' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetDrawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_DrawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.LineSegmentDetector __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.LineSegmentDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DrawSegments (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='LineSegmentDetector']/method[@name='drawSegments' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("drawSegments", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetDrawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void DrawSegments (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "drawSegments", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawSegments_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawSegments", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
