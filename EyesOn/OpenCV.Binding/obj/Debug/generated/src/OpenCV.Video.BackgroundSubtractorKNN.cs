using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']"
	[global::Android.Runtime.Register ("org/opencv/video/BackgroundSubtractorKNN", DoNotGenerateAcw=true)]
	public partial class BackgroundSubtractorKNN : global::OpenCV.Video.BackgroundSubtractor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/BackgroundSubtractorKNN", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundSubtractorKNN); }
		}

		protected BackgroundSubtractorKNN (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/constructor[@name='BackgroundSubtractorKNN' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe BackgroundSubtractorKNN (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BackgroundSubtractorKNN)) {
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetectShadows = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDetectShadows;
		static IntPtr id_setDetectShadows_Z;
		public virtual unsafe bool DetectShadows {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getDetectShadows' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setDetectShadows' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getDist2Threshold;
#pragma warning disable 0169
		static Delegate GetGetDist2ThresholdHandler ()
		{
			if (cb_getDist2Threshold == null)
				cb_getDist2Threshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDist2Threshold);
			return cb_getDist2Threshold;
		}

		static double n_GetDist2Threshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dist2Threshold;
		}
#pragma warning restore 0169

		static Delegate cb_setDist2Threshold_D;
#pragma warning disable 0169
		static Delegate GetSetDist2Threshold_DHandler ()
		{
			if (cb_setDist2Threshold_D == null)
				cb_setDist2Threshold_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDist2Threshold_D);
			return cb_setDist2Threshold_D;
		}

		static void n_SetDist2Threshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dist2Threshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDist2Threshold;
		static IntPtr id_setDist2Threshold_D;
		public virtual unsafe double Dist2Threshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getDist2Threshold' and count(parameter)=0]"
			[Register ("getDist2Threshold", "()D", "GetGetDist2ThresholdHandler")]
			get {
				if (id_getDist2Threshold == IntPtr.Zero)
					id_getDist2Threshold = JNIEnv.GetMethodID (class_ref, "getDist2Threshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDist2Threshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDist2Threshold", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setDist2Threshold' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDist2Threshold", "(D)V", "GetSetDist2Threshold_DHandler")]
			set {
				if (id_setDist2Threshold_D == IntPtr.Zero)
					id_setDist2Threshold_D = JNIEnv.GetMethodID (class_ref, "setDist2Threshold", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDist2Threshold_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDist2Threshold", "(D)V"), __args);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.History = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHistory;
		static IntPtr id_setHistory_I;
		public virtual unsafe int History {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getHistory' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setHistory' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getNSamples;
#pragma warning disable 0169
		static Delegate GetGetNSamplesHandler ()
		{
			if (cb_getNSamples == null)
				cb_getNSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNSamples);
			return cb_getNSamples;
		}

		static int n_GetNSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NSamples;
		}
#pragma warning restore 0169

		static Delegate cb_setNSamples_I;
#pragma warning disable 0169
		static Delegate GetSetNSamples_IHandler ()
		{
			if (cb_setNSamples_I == null)
				cb_setNSamples_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNSamples_I);
			return cb_setNSamples_I;
		}

		static void n_SetNSamples_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NSamples = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNSamples;
		static IntPtr id_setNSamples_I;
		public virtual unsafe int NSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getNSamples' and count(parameter)=0]"
			[Register ("getNSamples", "()I", "GetGetNSamplesHandler")]
			get {
				if (id_getNSamples == IntPtr.Zero)
					id_getNSamples = JNIEnv.GetMethodID (class_ref, "getNSamples", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNSamples);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNSamples", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setNSamples' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNSamples", "(I)V", "GetSetNSamples_IHandler")]
			set {
				if (id_setNSamples_I == IntPtr.Zero)
					id_setNSamples_I = JNIEnv.GetMethodID (class_ref, "setNSamples", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNSamples_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNSamples", "(I)V"), __args);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShadowThreshold;
		static IntPtr id_setShadowThreshold_D;
		public virtual unsafe double ShadowThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getShadowThreshold' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setShadowThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShadowValue;
		static IntPtr id_setShadowValue_I;
		public virtual unsafe int ShadowValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getShadowValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setShadowValue' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getkNNSamples;
#pragma warning disable 0169
		static Delegate GetGetkNNSamplesHandler ()
		{
			if (cb_getkNNSamples == null)
				cb_getkNNSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetkNNSamples);
			return cb_getkNNSamples;
		}

		static int n_GetkNNSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetkNNSamples ();
		}
#pragma warning restore 0169

		static IntPtr id_getkNNSamples;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='getkNNSamples' and count(parameter)=0]"
		[Register ("getkNNSamples", "()I", "GetGetkNNSamplesHandler")]
		public virtual unsafe int GetkNNSamples ()
		{
			if (id_getkNNSamples == IntPtr.Zero)
				id_getkNNSamples = JNIEnv.GetMethodID (class_ref, "getkNNSamples", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getkNNSamples);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getkNNSamples", "()I"));
			} finally {
			}
		}

		static Delegate cb_setkNNSamples_I;
#pragma warning disable 0169
		static Delegate GetSetkNNSamples_IHandler ()
		{
			if (cb_setkNNSamples_I == null)
				cb_setkNNSamples_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetkNNSamples_I);
			return cb_setkNNSamples_I;
		}

		static void n_SetkNNSamples_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Video.BackgroundSubtractorKNN __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.BackgroundSubtractorKNN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetkNNSamples (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setkNNSamples_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='BackgroundSubtractorKNN']/method[@name='setkNNSamples' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setkNNSamples", "(I)V", "GetSetkNNSamples_IHandler")]
		public virtual unsafe void SetkNNSamples (int p0)
		{
			if (id_setkNNSamples_I == IntPtr.Zero)
				id_setkNNSamples_I = JNIEnv.GetMethodID (class_ref, "setkNNSamples", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setkNNSamples_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setkNNSamples", "(I)V"), __args);
			} finally {
			}
		}

	}
}
