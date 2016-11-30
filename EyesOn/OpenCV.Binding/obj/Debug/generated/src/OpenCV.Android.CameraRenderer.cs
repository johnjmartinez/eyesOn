using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraRenderer']"
	[global::Android.Runtime.Register ("org/opencv/android/CameraRenderer", DoNotGenerateAcw=true)]
	public partial class CameraRenderer : global::OpenCV.Android.CameraGLRendererBase {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraRenderer']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		public const string Logtag = (string) "CameraRenderer";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/CameraRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraRenderer); }
		}

		protected CameraRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_closeCamera;
#pragma warning disable 0169
		static Delegate GetCloseCameraHandler ()
		{
			if (cb_closeCamera == null)
				cb_closeCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseCamera);
			return cb_closeCamera;
		}

		static void n_CloseCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraRenderer __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_closeCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraRenderer']/method[@name='closeCamera' and count(parameter)=0]"
		[Register ("closeCamera", "()V", "GetCloseCameraHandler")]
		protected override unsafe void CloseCamera ()
		{
			if (id_closeCamera == IntPtr.Zero)
				id_closeCamera = JNIEnv.GetMethodID (class_ref, "closeCamera", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeCamera);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeCamera", "()V"));
			} finally {
			}
		}

		static Delegate cb_openCamera_I;
#pragma warning disable 0169
		static Delegate GetOpenCamera_IHandler ()
		{
			if (cb_openCamera_I == null)
				cb_openCamera_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OpenCamera_I);
			return cb_openCamera_I;
		}

		static void n_OpenCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Android.CameraRenderer __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraRenderer']/method[@name='openCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openCamera", "(I)V", "GetOpenCamera_IHandler")]
		protected override unsafe void OpenCamera (int p0)
		{
			if (id_openCamera_I == IntPtr.Zero)
				id_openCamera_I = JNIEnv.GetMethodID (class_ref, "openCamera", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openCamera_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openCamera", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCameraPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewSize_IIHandler ()
		{
			if (cb_setCameraPreviewSize_II == null)
				cb_setCameraPreviewSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetCameraPreviewSize_II);
			return cb_setCameraPreviewSize_II;
		}

		static void n_SetCameraPreviewSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraRenderer __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraPreviewSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraRenderer']/method[@name='setCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCameraPreviewSize", "(II)V", "GetSetCameraPreviewSize_IIHandler")]
		protected override unsafe void SetCameraPreviewSize (int p0, int p1)
		{
			if (id_setCameraPreviewSize_II == IntPtr.Zero)
				id_setCameraPreviewSize_II = JNIEnv.GetMethodID (class_ref, "setCameraPreviewSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraPreviewSize_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCameraPreviewSize", "(II)V"), __args);
			} finally {
			}
		}

	}
}
