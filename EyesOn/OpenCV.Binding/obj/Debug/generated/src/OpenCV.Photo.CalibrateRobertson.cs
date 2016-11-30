using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']"
	[global::Android.Runtime.Register ("org/opencv/photo/CalibrateRobertson", DoNotGenerateAcw=true)]
	public partial class CalibrateRobertson : global::OpenCV.Photo.CalibrateCRF {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/CalibrateRobertson", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalibrateRobertson); }
		}

		protected CalibrateRobertson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/constructor[@name='CalibrateRobertson' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe CalibrateRobertson (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CalibrateRobertson)) {
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

		static Delegate cb_getMaxIter;
#pragma warning disable 0169
		static Delegate GetGetMaxIterHandler ()
		{
			if (cb_getMaxIter == null)
				cb_getMaxIter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxIter);
			return cb_getMaxIter;
		}

		static int n_GetMaxIter (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxIter;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxIter_I;
#pragma warning disable 0169
		static Delegate GetSetMaxIter_IHandler ()
		{
			if (cb_setMaxIter_I == null)
				cb_setMaxIter_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxIter_I);
			return cb_setMaxIter_I;
		}

		static void n_SetMaxIter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Photo.CalibrateRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxIter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxIter;
		static IntPtr id_setMaxIter_I;
		public virtual unsafe int MaxIter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/method[@name='getMaxIter' and count(parameter)=0]"
			[Register ("getMaxIter", "()I", "GetGetMaxIterHandler")]
			get {
				if (id_getMaxIter == IntPtr.Zero)
					id_getMaxIter = JNIEnv.GetMethodID (class_ref, "getMaxIter", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxIter);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxIter", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/method[@name='setMaxIter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxIter", "(I)V", "GetSetMaxIter_IHandler")]
			set {
				if (id_setMaxIter_I == IntPtr.Zero)
					id_setMaxIter_I = JNIEnv.GetMethodID (class_ref, "setMaxIter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxIter_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxIter", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadiance;
#pragma warning disable 0169
		static Delegate GetGetRadianceHandler ()
		{
			if (cb_getRadiance == null)
				cb_getRadiance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRadiance);
			return cb_getRadiance;
		}

		static IntPtr n_GetRadiance (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Radiance);
		}
#pragma warning restore 0169

		static IntPtr id_getRadiance;
		public virtual unsafe global::OpenCV.Core.Mat Radiance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/method[@name='getRadiance' and count(parameter)=0]"
			[Register ("getRadiance", "()Lorg/opencv/core/Mat;", "GetGetRadianceHandler")]
			get {
				if (id_getRadiance == IntPtr.Zero)
					id_getRadiance = JNIEnv.GetMethodID (class_ref, "getRadiance", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRadiance), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRadiance", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreshold;
#pragma warning disable 0169
		static Delegate GetGetThresholdHandler ()
		{
			if (cb_getThreshold == null)
				cb_getThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetThreshold);
			return cb_getThreshold;
		}

		static float n_GetThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.CalibrateRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Threshold;
		}
#pragma warning restore 0169

		static Delegate cb_setThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetThreshold_FHandler ()
		{
			if (cb_setThreshold_F == null)
				cb_setThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetThreshold_F);
			return cb_setThreshold_F;
		}

		static void n_SetThreshold_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.CalibrateRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Threshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getThreshold;
		static IntPtr id_setThreshold_F;
		public virtual unsafe float Threshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/method[@name='getThreshold' and count(parameter)=0]"
			[Register ("getThreshold", "()F", "GetGetThresholdHandler")]
			get {
				if (id_getThreshold == IntPtr.Zero)
					id_getThreshold = JNIEnv.GetMethodID (class_ref, "getThreshold", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getThreshold);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreshold", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='CalibrateRobertson']/method[@name='setThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setThreshold", "(F)V", "GetSetThreshold_FHandler")]
			set {
				if (id_setThreshold_F == IntPtr.Zero)
					id_setThreshold_F = JNIEnv.GetMethodID (class_ref, "setThreshold", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThreshold_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThreshold", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
