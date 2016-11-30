using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='Tonemap']"
	[global::Android.Runtime.Register ("org/opencv/photo/Tonemap", DoNotGenerateAcw=true)]
	public partial class Tonemap : global::OpenCV.Core.Algorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/Tonemap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tonemap); }
		}

		protected Tonemap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='Tonemap']/constructor[@name='Tonemap' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Tonemap (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tonemap)) {
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

		static Delegate cb_getGamma;
#pragma warning disable 0169
		static Delegate GetGetGammaHandler ()
		{
			if (cb_getGamma == null)
				cb_getGamma = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGamma);
			return cb_getGamma;
		}

		static float n_GetGamma (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.Tonemap __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.Tonemap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gamma;
		}
#pragma warning restore 0169

		static Delegate cb_setGamma_F;
#pragma warning disable 0169
		static Delegate GetSetGamma_FHandler ()
		{
			if (cb_setGamma_F == null)
				cb_setGamma_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGamma_F);
			return cb_setGamma_F;
		}

		static void n_SetGamma_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.Tonemap __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.Tonemap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gamma = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGamma;
		static IntPtr id_setGamma_F;
		public virtual unsafe float Gamma {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Tonemap']/method[@name='getGamma' and count(parameter)=0]"
			[Register ("getGamma", "()F", "GetGetGammaHandler")]
			get {
				if (id_getGamma == IntPtr.Zero)
					id_getGamma = JNIEnv.GetMethodID (class_ref, "getGamma", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getGamma);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGamma", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Tonemap']/method[@name='setGamma' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGamma", "(F)V", "GetSetGamma_FHandler")]
			set {
				if (id_setGamma_F == IntPtr.Zero)
					id_setGamma_F = JNIEnv.GetMethodID (class_ref, "setGamma", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGamma_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGamma", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetProcess_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Photo.Tonemap __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.Tonemap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Tonemap']/method[@name='process' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("process", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetProcess_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Process (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "process", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
