using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']"
	[global::Android.Runtime.Register ("org/opencv/photo/TonemapDurand", DoNotGenerateAcw=true)]
	public partial class TonemapDurand : global::OpenCV.Photo.Tonemap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/TonemapDurand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TonemapDurand); }
		}

		protected TonemapDurand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/constructor[@name='TonemapDurand' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe TonemapDurand (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TonemapDurand)) {
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

		static Delegate cb_getContrast;
#pragma warning disable 0169
		static Delegate GetGetContrastHandler ()
		{
			if (cb_getContrast == null)
				cb_getContrast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetContrast);
			return cb_getContrast;
		}

		static float n_GetContrast (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Contrast;
		}
#pragma warning restore 0169

		static Delegate cb_setContrast_F;
#pragma warning disable 0169
		static Delegate GetSetContrast_FHandler ()
		{
			if (cb_setContrast_F == null)
				cb_setContrast_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetContrast_F);
			return cb_setContrast_F;
		}

		static void n_SetContrast_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Contrast = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContrast;
		static IntPtr id_setContrast_F;
		public virtual unsafe float Contrast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='getContrast' and count(parameter)=0]"
			[Register ("getContrast", "()F", "GetGetContrastHandler")]
			get {
				if (id_getContrast == IntPtr.Zero)
					id_getContrast = JNIEnv.GetMethodID (class_ref, "getContrast", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getContrast);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContrast", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='setContrast' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setContrast", "(F)V", "GetSetContrast_FHandler")]
			set {
				if (id_setContrast_F == IntPtr.Zero)
					id_setContrast_F = JNIEnv.GetMethodID (class_ref, "setContrast", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContrast_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContrast", "(F)V"), __args);
				} finally {
				}
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
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Saturation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSaturation;
		static IntPtr id_setSaturation_F;
		public virtual unsafe float Saturation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='getSaturation' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='setSaturation' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_getSigmaColor;
#pragma warning disable 0169
		static Delegate GetGetSigmaColorHandler ()
		{
			if (cb_getSigmaColor == null)
				cb_getSigmaColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSigmaColor);
			return cb_getSigmaColor;
		}

		static float n_GetSigmaColor (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SigmaColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSigmaColor_F;
#pragma warning disable 0169
		static Delegate GetSetSigmaColor_FHandler ()
		{
			if (cb_setSigmaColor_F == null)
				cb_setSigmaColor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSigmaColor_F);
			return cb_setSigmaColor_F;
		}

		static void n_SetSigmaColor_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SigmaColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSigmaColor;
		static IntPtr id_setSigmaColor_F;
		public virtual unsafe float SigmaColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='getSigmaColor' and count(parameter)=0]"
			[Register ("getSigmaColor", "()F", "GetGetSigmaColorHandler")]
			get {
				if (id_getSigmaColor == IntPtr.Zero)
					id_getSigmaColor = JNIEnv.GetMethodID (class_ref, "getSigmaColor", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSigmaColor);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigmaColor", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='setSigmaColor' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSigmaColor", "(F)V", "GetSetSigmaColor_FHandler")]
			set {
				if (id_setSigmaColor_F == IntPtr.Zero)
					id_setSigmaColor_F = JNIEnv.GetMethodID (class_ref, "setSigmaColor", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSigmaColor_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSigmaColor", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSigmaSpace;
#pragma warning disable 0169
		static Delegate GetGetSigmaSpaceHandler ()
		{
			if (cb_getSigmaSpace == null)
				cb_getSigmaSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSigmaSpace);
			return cb_getSigmaSpace;
		}

		static float n_GetSigmaSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SigmaSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setSigmaSpace_F;
#pragma warning disable 0169
		static Delegate GetSetSigmaSpace_FHandler ()
		{
			if (cb_setSigmaSpace_F == null)
				cb_setSigmaSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSigmaSpace_F);
			return cb_setSigmaSpace_F;
		}

		static void n_SetSigmaSpace_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapDurand __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SigmaSpace = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSigmaSpace;
		static IntPtr id_setSigmaSpace_F;
		public virtual unsafe float SigmaSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='getSigmaSpace' and count(parameter)=0]"
			[Register ("getSigmaSpace", "()F", "GetGetSigmaSpaceHandler")]
			get {
				if (id_getSigmaSpace == IntPtr.Zero)
					id_getSigmaSpace = JNIEnv.GetMethodID (class_ref, "getSigmaSpace", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSigmaSpace);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigmaSpace", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDurand']/method[@name='setSigmaSpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSigmaSpace", "(F)V", "GetSetSigmaSpace_FHandler")]
			set {
				if (id_setSigmaSpace_F == IntPtr.Zero)
					id_setSigmaSpace_F = JNIEnv.GetMethodID (class_ref, "setSigmaSpace", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSigmaSpace_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSigmaSpace", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
