using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractor']"
	[global::Android.Runtime.Register ("org/opencv/video/BackgroundSubtractor", DoNotGenerateAcw=true)]
	public partial class BackgroundSubtractor : global::OpenCV.Core.Algorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/BackgroundSubtractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundSubtractor); }
		}

		protected BackgroundSubtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractor']/constructor[@name='BackgroundSubtractor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe BackgroundSubtractor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BackgroundSubtractor)) {
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

		static Delegate cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Video.BackgroundSubtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractor']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Apply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
#pragma warning disable 0169
		static Delegate GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DHandler ()
		{
			if (cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == null)
				cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D);
			return cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		}

		static void n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::OpenCV.Video.BackgroundSubtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractor']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double']]"
		[Register ("apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DHandler")]
		public virtual unsafe void Apply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2)
		{
			if (id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetMethodID (class_ref, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBackgroundImage_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetGetBackgroundImage_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_getBackgroundImage_Lorg_opencv_core_Mat_ == null)
				cb_getBackgroundImage_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBackgroundImage_Lorg_opencv_core_Mat_);
			return cb_getBackgroundImage_Lorg_opencv_core_Mat_;
		}

		static void n_GetBackgroundImage_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.BackgroundSubtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetBackgroundImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundImage_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractor']/method[@name='getBackgroundImage' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("getBackgroundImage", "(Lorg/opencv/core/Mat;)V", "GetGetBackgroundImage_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void GetBackgroundImage (global::OpenCV.Core.Mat p0)
		{
			if (id_getBackgroundImage_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getBackgroundImage_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "getBackgroundImage", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundImage_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundImage", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
