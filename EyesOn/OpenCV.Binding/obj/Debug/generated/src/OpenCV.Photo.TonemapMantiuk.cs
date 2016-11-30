using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']"
	[global::Android.Runtime.Register ("org/opencv/photo/TonemapMantiuk", DoNotGenerateAcw=true)]
	public partial class TonemapMantiuk : global::OpenCV.Photo.Tonemap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/TonemapMantiuk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TonemapMantiuk); }
		}

		protected TonemapMantiuk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']/constructor[@name='TonemapMantiuk' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe TonemapMantiuk (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TonemapMantiuk)) {
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

		static Delegate cb_getSaturation;
#pragma warning disable 0169
		static Delegate GetGetSaturationHandler ()
		{
			if (cb_getSaturation == null)
				cb_getSaturation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSaturation);
			return cb_getSaturation;
		}

		static float n_GetSaturation (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapMantiuk __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Saturation;
		}
#pragma warning restore 0169

		static Delegate cb_setSaturation_F;
#pragma warning disable 0169
		static Delegate GetSetSaturation_FHandler ()
		{
			if (cb_setSaturation_F == null)
				cb_setSaturation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSaturation_F);
			return cb_setSaturation_F;
		}

		static void n_SetSaturation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapMantiuk __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Saturation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSaturation;
		static IntPtr id_setSaturation_F;
		public virtual unsafe float Saturation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']/method[@name='getSaturation' and count(parameter)=0]"
			[Register ("getSaturation", "()F", "GetGetSaturationHandler")]
			get {
				if (id_getSaturation == IntPtr.Zero)
					id_getSaturation = JNIEnv.GetMethodID (class_ref, "getSaturation", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSaturation);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSaturation", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']/method[@name='setSaturation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSaturation", "(F)V", "GetSetSaturation_FHandler")]
			set {
				if (id_setSaturation_F == IntPtr.Zero)
					id_setSaturation_F = JNIEnv.GetMethodID (class_ref, "setSaturation", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSaturation_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSaturation", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapMantiuk __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapMantiuk __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		static IntPtr id_setScale_F;
		public virtual unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapMantiuk']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
			set {
				if (id_setScale_F == IntPtr.Zero)
					id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
