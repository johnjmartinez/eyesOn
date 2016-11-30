using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']"
	[global::Android.Runtime.Register ("org/opencv/photo/TonemapDrago", DoNotGenerateAcw=true)]
	public partial class TonemapDrago : global::OpenCV.Photo.Tonemap {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/TonemapDrago", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TonemapDrago); }
		}

		protected TonemapDrago (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']/constructor[@name='TonemapDrago' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe TonemapDrago (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TonemapDrago)) {
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

		static Delegate cb_getBias;
#pragma warning disable 0169
		static Delegate GetGetBiasHandler ()
		{
			if (cb_getBias == null)
				cb_getBias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBias);
			return cb_getBias;
		}

		static float n_GetBias (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.TonemapDrago __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bias;
		}
#pragma warning restore 0169

		static Delegate cb_setBias_F;
#pragma warning disable 0169
		static Delegate GetSetBias_FHandler ()
		{
			if (cb_setBias_F == null)
				cb_setBias_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBias_F);
			return cb_setBias_F;
		}

		static void n_SetBias_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.TonemapDrago __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bias = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBias;
		static IntPtr id_setBias_F;
		public virtual unsafe float Bias {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']/method[@name='getBias' and count(parameter)=0]"
			[Register ("getBias", "()F", "GetGetBiasHandler")]
			get {
				if (id_getBias == IntPtr.Zero)
					id_getBias = JNIEnv.GetMethodID (class_ref, "getBias", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getBias);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBias", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']/method[@name='setBias' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBias", "(F)V", "GetSetBias_FHandler")]
			set {
				if (id_setBias_F == IntPtr.Zero)
					id_setBias_F = JNIEnv.GetMethodID (class_ref, "setBias", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBias_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBias", "(F)V"), __args);
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
			global::OpenCV.Photo.TonemapDrago __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Photo.TonemapDrago __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Saturation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSaturation;
		static IntPtr id_setSaturation_F;
		public virtual unsafe float Saturation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']/method[@name='getSaturation' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='TonemapDrago']/method[@name='setSaturation' and count(parameter)=1 and parameter[1][@type='float']]"
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

	}
}
