using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']"
	[global::Android.Runtime.Register ("org/opencv/photo/TonemapReinhard", DoNotGenerateAcw=true)]
	public partial class TonemapReinhard : global::OpenCV.Photo.Tonemap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/TonemapReinhard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TonemapReinhard); }
		}

		protected TonemapReinhard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/constructor[@name='TonemapReinhard' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe TonemapReinhard (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TonemapReinhard)) {
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

		static Delegate cb_getColorAdaptation;
#pragma warning disable 0169
		static Delegate GetGetColorAdaptationHandler ()
		{
			if (cb_getColorAdaptation == null)
				cb_getColorAdaptation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetColorAdaptation);
			return cb_getColorAdaptation;
		}

		static float n_GetColorAdaptation (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorAdaptation;
		}
#pragma warning restore 0169

		static Delegate cb_setColorAdaptation_F;
#pragma warning disable 0169
		static Delegate GetSetColorAdaptation_FHandler ()
		{
			if (cb_setColorAdaptation_F == null)
				cb_setColorAdaptation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetColorAdaptation_F);
			return cb_setColorAdaptation_F;
		}

		static void n_SetColorAdaptation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorAdaptation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColorAdaptation;
		static IntPtr id_setColorAdaptation_F;
		public virtual unsafe float ColorAdaptation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='getColorAdaptation' and count(parameter)=0]"
			[Register ("getColorAdaptation", "()F", "GetGetColorAdaptationHandler")]
			get {
				if (id_getColorAdaptation == IntPtr.Zero)
					id_getColorAdaptation = JNIEnv.GetMethodID (class_ref, "getColorAdaptation", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getColorAdaptation);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorAdaptation", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='setColorAdaptation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setColorAdaptation", "(F)V", "GetSetColorAdaptation_FHandler")]
			set {
				if (id_setColorAdaptation_F == IntPtr.Zero)
					id_setColorAdaptation_F = JNIEnv.GetMethodID (class_ref, "setColorAdaptation", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorAdaptation_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorAdaptation", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIntensity;
#pragma warning disable 0169
		static Delegate GetGetIntensityHandler ()
		{
			if (cb_getIntensity == null)
				cb_getIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIntensity);
			return cb_getIntensity;
		}

		static float n_GetIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Intensity;
		}
#pragma warning restore 0169

		static Delegate cb_setIntensity_F;
#pragma warning disable 0169
		static Delegate GetSetIntensity_FHandler ()
		{
			if (cb_setIntensity_F == null)
				cb_setIntensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIntensity_F);
			return cb_setIntensity_F;
		}

		static void n_SetIntensity_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Intensity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntensity;
		static IntPtr id_setIntensity_F;
		public virtual unsafe float Intensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='getIntensity' and count(parameter)=0]"
			[Register ("getIntensity", "()F", "GetGetIntensityHandler")]
			get {
				if (id_getIntensity == IntPtr.Zero)
					id_getIntensity = JNIEnv.GetMethodID (class_ref, "getIntensity", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getIntensity);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntensity", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIntensity", "(F)V", "GetSetIntensity_FHandler")]
			set {
				if (id_setIntensity_F == IntPtr.Zero)
					id_setIntensity_F = JNIEnv.GetMethodID (class_ref, "setIntensity", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntensity_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntensity", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLightAdaptation;
#pragma warning disable 0169
		static Delegate GetGetLightAdaptationHandler ()
		{
			if (cb_getLightAdaptation == null)
				cb_getLightAdaptation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLightAdaptation);
			return cb_getLightAdaptation;
		}

		static float n_GetLightAdaptation (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LightAdaptation;
		}
#pragma warning restore 0169

		static Delegate cb_setLightAdaptation_F;
#pragma warning disable 0169
		static Delegate GetSetLightAdaptation_FHandler ()
		{
			if (cb_setLightAdaptation_F == null)
				cb_setLightAdaptation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLightAdaptation_F);
			return cb_setLightAdaptation_F;
		}

		static void n_SetLightAdaptation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapReinhard __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LightAdaptation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLightAdaptation;
		static IntPtr id_setLightAdaptation_F;
		public virtual unsafe float LightAdaptation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='getLightAdaptation' and count(parameter)=0]"
			[Register ("getLightAdaptation", "()F", "GetGetLightAdaptationHandler")]
			get {
				if (id_getLightAdaptation == IntPtr.Zero)
					id_getLightAdaptation = JNIEnv.GetMethodID (class_ref, "getLightAdaptation", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLightAdaptation);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLightAdaptation", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapReinhard']/method[@name='setLightAdaptation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLightAdaptation", "(F)V", "GetSetLightAdaptation_FHandler")]
			set {
				if (id_setLightAdaptation_F == IntPtr.Zero)
					id_setLightAdaptation_F = JNIEnv.GetMethodID (class_ref, "setLightAdaptation", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLightAdaptation_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLightAdaptation", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
