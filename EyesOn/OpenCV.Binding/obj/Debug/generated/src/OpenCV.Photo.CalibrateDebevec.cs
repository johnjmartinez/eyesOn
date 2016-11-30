using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']"
	[global::Android.Runtime.Register ("org/opencv/photo/CalibrateDebevec", DoNotGenerateAcw=true)]
	public partial class CalibrateDebevec : global::OpenCV.Photo.CalibrateCRF {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/CalibrateDebevec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalibrateDebevec); }
		}

		protected CalibrateDebevec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/constructor[@name='CalibrateDebevec' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe CalibrateDebevec (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CalibrateDebevec)) {
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

		static Delegate cb_getLambda;
#pragma warning disable 0169
		static Delegate GetGetLambdaHandler ()
		{
			if (cb_getLambda == null)
				cb_getLambda = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLambda);
			return cb_getLambda;
		}

		static float n_GetLambda (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lambda;
		}
#pragma warning restore 0169

		static Delegate cb_setLambda_F;
#pragma warning disable 0169
		static Delegate GetSetLambda_FHandler ()
		{
			if (cb_setLambda_F == null)
				cb_setLambda_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLambda_F);
			return cb_setLambda_F;
		}

		static void n_SetLambda_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Lambda = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLambda;
		static IntPtr id_setLambda_F;
		public virtual unsafe float Lambda {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='getLambda' and count(parameter)=0]"
			[Register ("getLambda", "()F", "GetGetLambdaHandler")]
			get {
				if (id_getLambda == IntPtr.Zero)
					id_getLambda = JNIEnv.GetMethodID (class_ref, "getLambda", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLambda);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLambda", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='setLambda' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLambda", "(F)V", "GetSetLambda_FHandler")]
			set {
				if (id_setLambda_F == IntPtr.Zero)
					id_setLambda_F = JNIEnv.GetMethodID (class_ref, "setLambda", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLambda_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLambda", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRandom;
#pragma warning disable 0169
		static Delegate GetGetRandomHandler ()
		{
			if (cb_getRandom == null)
				cb_getRandom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRandom);
			return cb_getRandom;
		}

		static bool n_GetRandom (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Random;
		}
#pragma warning restore 0169

		static Delegate cb_setRandom_Z;
#pragma warning disable 0169
		static Delegate GetSetRandom_ZHandler ()
		{
			if (cb_setRandom_Z == null)
				cb_setRandom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRandom_Z);
			return cb_setRandom_Z;
		}

		static void n_SetRandom_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Random = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRandom;
		static IntPtr id_setRandom_Z;
		public virtual unsafe bool Random {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='getRandom' and count(parameter)=0]"
			[Register ("getRandom", "()Z", "GetGetRandomHandler")]
			get {
				if (id_getRandom == IntPtr.Zero)
					id_getRandom = JNIEnv.GetMethodID (class_ref, "getRandom", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getRandom);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRandom", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='setRandom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRandom", "(Z)V", "GetSetRandom_ZHandler")]
			set {
				if (id_setRandom_Z == IntPtr.Zero)
					id_setRandom_Z = JNIEnv.GetMethodID (class_ref, "setRandom", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRandom_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRandom", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSamples;
#pragma warning disable 0169
		static Delegate GetGetSamplesHandler ()
		{
			if (cb_getSamples == null)
				cb_getSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSamples);
			return cb_getSamples;
		}

		static int n_GetSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Samples;
		}
#pragma warning restore 0169

		static Delegate cb_setSamples_I;
#pragma warning disable 0169
		static Delegate GetSetSamples_IHandler ()
		{
			if (cb_setSamples_I == null)
				cb_setSamples_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSamples_I);
			return cb_setSamples_I;
		}

		static void n_SetSamples_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Photo.CalibrateDebevec __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Samples = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSamples;
		static IntPtr id_setSamples_I;
		public virtual unsafe int Samples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='getSamples' and count(parameter)=0]"
			[Register ("getSamples", "()I", "GetGetSamplesHandler")]
			get {
				if (id_getSamples == IntPtr.Zero)
					id_getSamples = JNIEnv.GetMethodID (class_ref, "getSamples", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSamples);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamples", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateDebevec']/method[@name='setSamples' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSamples", "(I)V", "GetSetSamples_IHandler")]
			set {
				if (id_setSamples_I == IntPtr.Zero)
					id_setSamples_I = JNIEnv.GetMethodID (class_ref, "setSamples", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSamples_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSamples", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
