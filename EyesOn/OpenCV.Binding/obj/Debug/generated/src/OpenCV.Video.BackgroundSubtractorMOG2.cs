using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']"
	[global::Android.Runtime.Register ("org/opencv/video/BackgroundSubtractorMOG2", DoNotGenerateAcw=true)]
	public partial class BackgroundSubtractorMOG2 : global::OpenCV.Video.BackgroundSubtractor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/BackgroundSubtractorMOG2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundSubtractorMOG2); }
		}

		protected BackgroundSubtractorMOG2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/constructor[@name='BackgroundSubtractorMOG2' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe BackgroundSubtractorMOG2 (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BackgroundSubtractorMOG2)) {
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

		static Delegate cb_getBackgroundRatio;
#pragma warning disable 0169
		static Delegate GetGetBackgroundRatioHandler ()
		{
			if (cb_getBackgroundRatio == null)
				cb_getBackgroundRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBackgroundRatio);
			return cb_getBackgroundRatio;
		}

		static double n_GetBackgroundRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundRatio_D;
#pragma warning disable 0169
		static Delegate GetSetBackgroundRatio_DHandler ()
		{
			if (cb_setBackgroundRatio_D == null)
				cb_setBackgroundRatio_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBackgroundRatio_D);
			return cb_setBackgroundRatio_D;
		}

		static void n_SetBackgroundRatio_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundRatio;
		static IntPtr id_setBackgroundRatio_D;
		public virtual unsafe double BackgroundRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getBackgroundRatio' and count(parameter)=0]"
			[Register ("getBackgroundRatio", "()D", "GetGetBackgroundRatioHandler")]
			get {
				if (id_getBackgroundRatio == IntPtr.Zero)
					id_getBackgroundRatio = JNIEnv.GetMethodID (class_ref, "getBackgroundRatio", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundRatio);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundRatio", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setBackgroundRatio' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBackgroundRatio", "(D)V", "GetSetBackgroundRatio_DHandler")]
			set {
				if (id_setBackgroundRatio_D == IntPtr.Zero)
					id_setBackgroundRatio_D = JNIEnv.GetMethodID (class_ref, "setBackgroundRatio", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundRatio_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundRatio", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getComplexityReductionThreshold;
#pragma warning disable 0169
		static Delegate GetGetComplexityReductionThresholdHandler ()
		{
			if (cb_getComplexityReductionThreshold == null)
				cb_getComplexityReductionThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetComplexityReductionThreshold);
			return cb_getComplexityReductionThreshold;
		}

		static double n_GetComplexityReductionThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComplexityReductionThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setComplexityReductionThreshold_D;
#pragma warning disable 0169
		static Delegate GetSetComplexityReductionThreshold_DHandler ()
		{
			if (cb_setComplexityReductionThreshold_D == null)
				cb_setComplexityReductionThreshold_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetComplexityReductionThreshold_D);
			return cb_setComplexityReductionThreshold_D;
		}

		static void n_SetComplexityReductionThreshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComplexityReductionThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getComplexityReductionThreshold;
		static IntPtr id_setComplexityReductionThreshold_D;
		public virtual unsafe double ComplexityReductionThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getComplexityReductionThreshold' and count(parameter)=0]"
			[Register ("getComplexityReductionThreshold", "()D", "GetGetComplexityReductionThresholdHandler")]
			get {
				if (id_getComplexityReductionThreshold == IntPtr.Zero)
					id_getComplexityReductionThreshold = JNIEnv.GetMethodID (class_ref, "getComplexityReductionThreshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getComplexityReductionThreshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComplexityReductionThreshold", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setComplexityReductionThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setComplexityReductionThreshold", "(D)V", "GetSetComplexityReductionThreshold_DHandler")]
			set {
				if (id_setComplexityReductionThreshold_D == IntPtr.Zero)
					id_setComplexityReductionThreshold_D = JNIEnv.GetMethodID (class_ref, "setComplexityReductionThreshold", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setComplexityReductionThreshold_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setComplexityReductionThreshold", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDetectShadows;
#pragma warning disable 0169
		static Delegate GetGetDetectShadowsHandler ()
		{
			if (cb_getDetectShadows == null)
				cb_getDetectShadows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetDetectShadows);
			return cb_getDetectShadows;
		}

		static bool n_GetDetectShadows (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DetectShadows;
		}
#pragma warning restore 0169

		static Delegate cb_setDetectShadows_Z;
#pragma warning disable 0169
		static Delegate GetSetDetectShadows_ZHandler ()
		{
			if (cb_setDetectShadows_Z == null)
				cb_setDetectShadows_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDetectShadows_Z);
			return cb_setDetectShadows_Z;
		}

		static void n_SetDetectShadows_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetectShadows = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDetectShadows;
		static IntPtr id_setDetectShadows_Z;
		public virtual unsafe bool DetectShadows {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getDetectShadows' and count(parameter)=0]"
			[Register ("getDetectShadows", "()Z", "GetGetDetectShadowsHandler")]
			get {
				if (id_getDetectShadows == IntPtr.Zero)
					id_getDetectShadows = JNIEnv.GetMethodID (class_ref, "getDetectShadows", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getDetectShadows);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetectShadows", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setDetectShadows' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDetectShadows", "(Z)V", "GetSetDetectShadows_ZHandler")]
			set {
				if (id_setDetectShadows_Z == IntPtr.Zero)
					id_setDetectShadows_Z = JNIEnv.GetMethodID (class_ref, "setDetectShadows", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDetectShadows_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDetectShadows", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHistory;
#pragma warning disable 0169
		static Delegate GetGetHistoryHandler ()
		{
			if (cb_getHistory == null)
				cb_getHistory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHistory);
			return cb_getHistory;
		}

		static int n_GetHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.History;
		}
#pragma warning restore 0169

		static Delegate cb_setHistory_I;
#pragma warning disable 0169
		static Delegate GetSetHistory_IHandler ()
		{
			if (cb_setHistory_I == null)
				cb_setHistory_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHistory_I);
			return cb_setHistory_I;
		}

		static void n_SetHistory_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.History = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHistory;
		static IntPtr id_setHistory_I;
		public virtual unsafe int History {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getHistory' and count(parameter)=0]"
			[Register ("getHistory", "()I", "GetGetHistoryHandler")]
			get {
				if (id_getHistory == IntPtr.Zero)
					id_getHistory = JNIEnv.GetMethodID (class_ref, "getHistory", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHistory);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistory", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setHistory' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHistory", "(I)V", "GetSetHistory_IHandler")]
			set {
				if (id_setHistory_I == IntPtr.Zero)
					id_setHistory_I = JNIEnv.GetMethodID (class_ref, "setHistory", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHistory_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHistory", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNMixtures;
#pragma warning disable 0169
		static Delegate GetGetNMixturesHandler ()
		{
			if (cb_getNMixtures == null)
				cb_getNMixtures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNMixtures);
			return cb_getNMixtures;
		}

		static int n_GetNMixtures (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NMixtures;
		}
#pragma warning restore 0169

		static Delegate cb_setNMixtures_I;
#pragma warning disable 0169
		static Delegate GetSetNMixtures_IHandler ()
		{
			if (cb_setNMixtures_I == null)
				cb_setNMixtures_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNMixtures_I);
			return cb_setNMixtures_I;
		}

		static void n_SetNMixtures_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NMixtures = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNMixtures;
		static IntPtr id_setNMixtures_I;
		public virtual unsafe int NMixtures {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getNMixtures' and count(parameter)=0]"
			[Register ("getNMixtures", "()I", "GetGetNMixturesHandler")]
			get {
				if (id_getNMixtures == IntPtr.Zero)
					id_getNMixtures = JNIEnv.GetMethodID (class_ref, "getNMixtures", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNMixtures);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNMixtures", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setNMixtures' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNMixtures", "(I)V", "GetSetNMixtures_IHandler")]
			set {
				if (id_setNMixtures_I == IntPtr.Zero)
					id_setNMixtures_I = JNIEnv.GetMethodID (class_ref, "setNMixtures", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNMixtures_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNMixtures", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowThreshold;
#pragma warning disable 0169
		static Delegate GetGetShadowThresholdHandler ()
		{
			if (cb_getShadowThreshold == null)
				cb_getShadowThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetShadowThreshold);
			return cb_getShadowThreshold;
		}

		static double n_GetShadowThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowThreshold_D;
#pragma warning disable 0169
		static Delegate GetSetShadowThreshold_DHandler ()
		{
			if (cb_setShadowThreshold_D == null)
				cb_setShadowThreshold_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetShadowThreshold_D);
			return cb_setShadowThreshold_D;
		}

		static void n_SetShadowThreshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShadowThreshold;
		static IntPtr id_setShadowThreshold_D;
		public virtual unsafe double ShadowThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getShadowThreshold' and count(parameter)=0]"
			[Register ("getShadowThreshold", "()D", "GetGetShadowThresholdHandler")]
			get {
				if (id_getShadowThreshold == IntPtr.Zero)
					id_getShadowThreshold = JNIEnv.GetMethodID (class_ref, "getShadowThreshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getShadowThreshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShadowThreshold", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setShadowThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setShadowThreshold", "(D)V", "GetSetShadowThreshold_DHandler")]
			set {
				if (id_setShadowThreshold_D == IntPtr.Zero)
					id_setShadowThreshold_D = JNIEnv.GetMethodID (class_ref, "setShadowThreshold", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadowThreshold_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShadowThreshold", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowValue;
#pragma warning disable 0169
		static Delegate GetGetShadowValueHandler ()
		{
			if (cb_getShadowValue == null)
				cb_getShadowValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowValue);
			return cb_getShadowValue;
		}

		static int n_GetShadowValue (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowValue;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowValue_I;
#pragma warning disable 0169
		static Delegate GetSetShadowValue_IHandler ()
		{
			if (cb_setShadowValue_I == null)
				cb_setShadowValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowValue_I);
			return cb_setShadowValue_I;
		}

		static void n_SetShadowValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShadowValue;
		static IntPtr id_setShadowValue_I;
		public virtual unsafe int ShadowValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getShadowValue' and count(parameter)=0]"
			[Register ("getShadowValue", "()I", "GetGetShadowValueHandler")]
			get {
				if (id_getShadowValue == IntPtr.Zero)
					id_getShadowValue = JNIEnv.GetMethodID (class_ref, "getShadowValue", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShadowValue);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShadowValue", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setShadowValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowValue", "(I)V", "GetSetShadowValue_IHandler")]
			set {
				if (id_setShadowValue_I == IntPtr.Zero)
					id_setShadowValue_I = JNIEnv.GetMethodID (class_ref, "setShadowValue", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadowValue_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShadowValue", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarInit;
#pragma warning disable 0169
		static Delegate GetGetVarInitHandler ()
		{
			if (cb_getVarInit == null)
				cb_getVarInit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVarInit);
			return cb_getVarInit;
		}

		static double n_GetVarInit (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarInit;
		}
#pragma warning restore 0169

		static Delegate cb_setVarInit_D;
#pragma warning disable 0169
		static Delegate GetSetVarInit_DHandler ()
		{
			if (cb_setVarInit_D == null)
				cb_setVarInit_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVarInit_D);
			return cb_setVarInit_D;
		}

		static void n_SetVarInit_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VarInit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVarInit;
		static IntPtr id_setVarInit_D;
		public virtual unsafe double VarInit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getVarInit' and count(parameter)=0]"
			[Register ("getVarInit", "()D", "GetGetVarInitHandler")]
			get {
				if (id_getVarInit == IntPtr.Zero)
					id_getVarInit = JNIEnv.GetMethodID (class_ref, "getVarInit", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVarInit);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarInit", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setVarInit' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVarInit", "(D)V", "GetSetVarInit_DHandler")]
			set {
				if (id_setVarInit_D == IntPtr.Zero)
					id_setVarInit_D = JNIEnv.GetMethodID (class_ref, "setVarInit", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVarInit_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVarInit", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarMax;
#pragma warning disable 0169
		static Delegate GetGetVarMaxHandler ()
		{
			if (cb_getVarMax == null)
				cb_getVarMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVarMax);
			return cb_getVarMax;
		}

		static double n_GetVarMax (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarMax;
		}
#pragma warning restore 0169

		static Delegate cb_setVarMax_D;
#pragma warning disable 0169
		static Delegate GetSetVarMax_DHandler ()
		{
			if (cb_setVarMax_D == null)
				cb_setVarMax_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVarMax_D);
			return cb_setVarMax_D;
		}

		static void n_SetVarMax_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VarMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVarMax;
		static IntPtr id_setVarMax_D;
		public virtual unsafe double VarMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getVarMax' and count(parameter)=0]"
			[Register ("getVarMax", "()D", "GetGetVarMaxHandler")]
			get {
				if (id_getVarMax == IntPtr.Zero)
					id_getVarMax = JNIEnv.GetMethodID (class_ref, "getVarMax", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVarMax);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarMax", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setVarMax' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVarMax", "(D)V", "GetSetVarMax_DHandler")]
			set {
				if (id_setVarMax_D == IntPtr.Zero)
					id_setVarMax_D = JNIEnv.GetMethodID (class_ref, "setVarMax", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVarMax_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVarMax", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarMin;
#pragma warning disable 0169
		static Delegate GetGetVarMinHandler ()
		{
			if (cb_getVarMin == null)
				cb_getVarMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVarMin);
			return cb_getVarMin;
		}

		static double n_GetVarMin (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarMin;
		}
#pragma warning restore 0169

		static Delegate cb_setVarMin_D;
#pragma warning disable 0169
		static Delegate GetSetVarMin_DHandler ()
		{
			if (cb_setVarMin_D == null)
				cb_setVarMin_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVarMin_D);
			return cb_setVarMin_D;
		}

		static void n_SetVarMin_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VarMin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVarMin;
		static IntPtr id_setVarMin_D;
		public virtual unsafe double VarMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getVarMin' and count(parameter)=0]"
			[Register ("getVarMin", "()D", "GetGetVarMinHandler")]
			get {
				if (id_getVarMin == IntPtr.Zero)
					id_getVarMin = JNIEnv.GetMethodID (class_ref, "getVarMin", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVarMin);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarMin", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setVarMin' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVarMin", "(D)V", "GetSetVarMin_DHandler")]
			set {
				if (id_setVarMin_D == IntPtr.Zero)
					id_setVarMin_D = JNIEnv.GetMethodID (class_ref, "setVarMin", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVarMin_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVarMin", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarThreshold;
#pragma warning disable 0169
		static Delegate GetGetVarThresholdHandler ()
		{
			if (cb_getVarThreshold == null)
				cb_getVarThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVarThreshold);
			return cb_getVarThreshold;
		}

		static double n_GetVarThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setVarThreshold_D;
#pragma warning disable 0169
		static Delegate GetSetVarThreshold_DHandler ()
		{
			if (cb_setVarThreshold_D == null)
				cb_setVarThreshold_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVarThreshold_D);
			return cb_setVarThreshold_D;
		}

		static void n_SetVarThreshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VarThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVarThreshold;
		static IntPtr id_setVarThreshold_D;
		public virtual unsafe double VarThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getVarThreshold' and count(parameter)=0]"
			[Register ("getVarThreshold", "()D", "GetGetVarThresholdHandler")]
			get {
				if (id_getVarThreshold == IntPtr.Zero)
					id_getVarThreshold = JNIEnv.GetMethodID (class_ref, "getVarThreshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVarThreshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarThreshold", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setVarThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVarThreshold", "(D)V", "GetSetVarThreshold_DHandler")]
			set {
				if (id_setVarThreshold_D == IntPtr.Zero)
					id_setVarThreshold_D = JNIEnv.GetMethodID (class_ref, "setVarThreshold", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVarThreshold_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVarThreshold", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarThresholdGen;
#pragma warning disable 0169
		static Delegate GetGetVarThresholdGenHandler ()
		{
			if (cb_getVarThresholdGen == null)
				cb_getVarThresholdGen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVarThresholdGen);
			return cb_getVarThresholdGen;
		}

		static double n_GetVarThresholdGen (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarThresholdGen;
		}
#pragma warning restore 0169

		static Delegate cb_setVarThresholdGen_D;
#pragma warning disable 0169
		static Delegate GetSetVarThresholdGen_DHandler ()
		{
			if (cb_setVarThresholdGen_D == null)
				cb_setVarThresholdGen_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetVarThresholdGen_D);
			return cb_setVarThresholdGen_D;
		}

		static void n_SetVarThresholdGen_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorMOG2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorMOG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VarThresholdGen = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVarThresholdGen;
		static IntPtr id_setVarThresholdGen_D;
		public virtual unsafe double VarThresholdGen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='getVarThresholdGen' and count(parameter)=0]"
			[Register ("getVarThresholdGen", "()D", "GetGetVarThresholdGenHandler")]
			get {
				if (id_getVarThresholdGen == IntPtr.Zero)
					id_getVarThresholdGen = JNIEnv.GetMethodID (class_ref, "getVarThresholdGen", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVarThresholdGen);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarThresholdGen", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorMOG2']/method[@name='setVarThresholdGen' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setVarThresholdGen", "(D)V", "GetSetVarThresholdGen_DHandler")]
			set {
				if (id_setVarThresholdGen_D == IntPtr.Zero)
					id_setVarThresholdGen_D = JNIEnv.GetMethodID (class_ref, "setVarThresholdGen", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVarThresholdGen_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVarThresholdGen", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
