using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']"
	[global::Android.Runtime.Register ("org/opencv/ml/RTrees", DoNotGenerateAcw=true)]
	public partial class RTrees : global::OpenCV.ML.DTrees {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/RTrees", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RTrees); }
		}

		protected RTrees (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/constructor[@name='RTrees' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe RTrees (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RTrees)) {
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

		static Delegate cb_getActiveVarCount;
#pragma warning disable 0169
		static Delegate GetGetActiveVarCountHandler ()
		{
			if (cb_getActiveVarCount == null)
				cb_getActiveVarCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActiveVarCount);
			return cb_getActiveVarCount;
		}

		static int n_GetActiveVarCount (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveVarCount;
		}
#pragma warning restore 0169

		static Delegate cb_setActiveVarCount_I;
#pragma warning disable 0169
		static Delegate GetSetActiveVarCount_IHandler ()
		{
			if (cb_setActiveVarCount_I == null)
				cb_setActiveVarCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActiveVarCount_I);
			return cb_setActiveVarCount_I;
		}

		static void n_SetActiveVarCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActiveVarCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveVarCount;
		static IntPtr id_setActiveVarCount_I;
		public virtual unsafe int ActiveVarCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='getActiveVarCount' and count(parameter)=0]"
			[Register ("getActiveVarCount", "()I", "GetGetActiveVarCountHandler")]
			get {
				if (id_getActiveVarCount == IntPtr.Zero)
					id_getActiveVarCount = JNIEnv.GetMethodID (class_ref, "getActiveVarCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getActiveVarCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveVarCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='setActiveVarCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActiveVarCount", "(I)V", "GetSetActiveVarCount_IHandler")]
			set {
				if (id_setActiveVarCount_I == IntPtr.Zero)
					id_setActiveVarCount_I = JNIEnv.GetMethodID (class_ref, "setActiveVarCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveVarCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveVarCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCalculateVarImportance;
#pragma warning disable 0169
		static Delegate GetGetCalculateVarImportanceHandler ()
		{
			if (cb_getCalculateVarImportance == null)
				cb_getCalculateVarImportance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCalculateVarImportance);
			return cb_getCalculateVarImportance;
		}

		static bool n_GetCalculateVarImportance (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculateVarImportance;
		}
#pragma warning restore 0169

		static Delegate cb_setCalculateVarImportance_Z;
#pragma warning disable 0169
		static Delegate GetSetCalculateVarImportance_ZHandler ()
		{
			if (cb_setCalculateVarImportance_Z == null)
				cb_setCalculateVarImportance_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCalculateVarImportance_Z);
			return cb_setCalculateVarImportance_Z;
		}

		static void n_SetCalculateVarImportance_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateVarImportance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCalculateVarImportance;
		static IntPtr id_setCalculateVarImportance_Z;
		public virtual unsafe bool CalculateVarImportance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='getCalculateVarImportance' and count(parameter)=0]"
			[Register ("getCalculateVarImportance", "()Z", "GetGetCalculateVarImportanceHandler")]
			get {
				if (id_getCalculateVarImportance == IntPtr.Zero)
					id_getCalculateVarImportance = JNIEnv.GetMethodID (class_ref, "getCalculateVarImportance", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getCalculateVarImportance);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalculateVarImportance", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='setCalculateVarImportance' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCalculateVarImportance", "(Z)V", "GetSetCalculateVarImportance_ZHandler")]
			set {
				if (id_setCalculateVarImportance_Z == IntPtr.Zero)
					id_setCalculateVarImportance_Z = JNIEnv.GetMethodID (class_ref, "setCalculateVarImportance", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCalculateVarImportance_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalculateVarImportance", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTermCriteria;
#pragma warning disable 0169
		static Delegate GetGetTermCriteriaHandler ()
		{
			if (cb_getTermCriteria == null)
				cb_getTermCriteria = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTermCriteria);
			return cb_getTermCriteria;
		}

		static IntPtr n_GetTermCriteria (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TermCriteria);
		}
#pragma warning restore 0169

		static Delegate cb_setTermCriteria_Lorg_opencv_core_TermCriteria_;
#pragma warning disable 0169
		static Delegate GetSetTermCriteria_Lorg_opencv_core_TermCriteria_Handler ()
		{
			if (cb_setTermCriteria_Lorg_opencv_core_TermCriteria_ == null)
				cb_setTermCriteria_Lorg_opencv_core_TermCriteria_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTermCriteria_Lorg_opencv_core_TermCriteria_);
			return cb_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		}

		static void n_SetTermCriteria_Lorg_opencv_core_TermCriteria_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.TermCriteria p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TermCriteria = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTermCriteria;
		static IntPtr id_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		public virtual unsafe global::OpenCV.Core.TermCriteria TermCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='getTermCriteria' and count(parameter)=0]"
			[Register ("getTermCriteria", "()Lorg/opencv/core/TermCriteria;", "GetGetTermCriteriaHandler")]
			get {
				if (id_getTermCriteria == IntPtr.Zero)
					id_getTermCriteria = JNIEnv.GetMethodID (class_ref, "getTermCriteria", "()Lorg/opencv/core/TermCriteria;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTermCriteria), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTermCriteria", "()Lorg/opencv/core/TermCriteria;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='setTermCriteria' and count(parameter)=1 and parameter[1][@type='org.opencv.core.TermCriteria']]"
			[Register ("setTermCriteria", "(Lorg/opencv/core/TermCriteria;)V", "GetSetTermCriteria_Lorg_opencv_core_TermCriteria_Handler")]
			set {
				if (id_setTermCriteria_Lorg_opencv_core_TermCriteria_ == IntPtr.Zero)
					id_setTermCriteria_Lorg_opencv_core_TermCriteria_ = JNIEnv.GetMethodID (class_ref, "setTermCriteria", "(Lorg/opencv/core/TermCriteria;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTermCriteria_Lorg_opencv_core_TermCriteria_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTermCriteria", "(Lorg/opencv/core/TermCriteria;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVarImportance;
#pragma warning disable 0169
		static Delegate GetGetVarImportanceHandler ()
		{
			if (cb_getVarImportance == null)
				cb_getVarImportance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVarImportance);
			return cb_getVarImportance;
		}

		static IntPtr n_GetVarImportance (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.RTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VarImportance);
		}
#pragma warning restore 0169

		static IntPtr id_getVarImportance;
		public virtual unsafe global::OpenCV.Core.Mat VarImportance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='getVarImportance' and count(parameter)=0]"
			[Register ("getVarImportance", "()Lorg/opencv/core/Mat;", "GetGetVarImportanceHandler")]
			get {
				if (id_getVarImportance == IntPtr.Zero)
					id_getVarImportance = JNIEnv.GetMethodID (class_ref, "getVarImportance", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVarImportance), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarImportance", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='RTrees']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/RTrees;", "")]
		public static unsafe global::OpenCV.ML.RTrees Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/RTrees;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.RTrees> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
