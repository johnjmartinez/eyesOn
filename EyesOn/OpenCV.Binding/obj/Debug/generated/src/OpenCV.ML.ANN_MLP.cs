using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']"
	[global::Android.Runtime.Register ("org/opencv/ml/ANN_MLP", DoNotGenerateAcw=true)]
	public partial class ANN_MLP : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='BACKPROP']"
		[Register ("BACKPROP")]
		public const int Backprop = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='GAUSSIAN']"
		[Register ("GAUSSIAN")]
		public const int Gaussian = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='IDENTITY']"
		[Register ("IDENTITY")]
		public const int Identity = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='NO_INPUT_SCALE']"
		[Register ("NO_INPUT_SCALE")]
		public const int NoInputScale = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='NO_OUTPUT_SCALE']"
		[Register ("NO_OUTPUT_SCALE")]
		public const int NoOutputScale = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='RPROP']"
		[Register ("RPROP")]
		public const int Rprop = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='SIGMOID_SYM']"
		[Register ("SIGMOID_SYM")]
		public const int SigmoidSym = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/field[@name='UPDATE_WEIGHTS']"
		[Register ("UPDATE_WEIGHTS")]
		public const int UpdateWeights = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/ANN_MLP", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ANN_MLP); }
		}

		protected ANN_MLP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/constructor[@name='ANN_MLP' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe ANN_MLP (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ANN_MLP)) {
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

		static Delegate cb_getBackpropMomentumScale;
#pragma warning disable 0169
		static Delegate GetGetBackpropMomentumScaleHandler ()
		{
			if (cb_getBackpropMomentumScale == null)
				cb_getBackpropMomentumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBackpropMomentumScale);
			return cb_getBackpropMomentumScale;
		}

		static double n_GetBackpropMomentumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackpropMomentumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setBackpropMomentumScale_D;
#pragma warning disable 0169
		static Delegate GetSetBackpropMomentumScale_DHandler ()
		{
			if (cb_setBackpropMomentumScale_D == null)
				cb_setBackpropMomentumScale_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBackpropMomentumScale_D);
			return cb_setBackpropMomentumScale_D;
		}

		static void n_SetBackpropMomentumScale_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackpropMomentumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackpropMomentumScale;
		static IntPtr id_setBackpropMomentumScale_D;
		public virtual unsafe double BackpropMomentumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getBackpropMomentumScale' and count(parameter)=0]"
			[Register ("getBackpropMomentumScale", "()D", "GetGetBackpropMomentumScaleHandler")]
			get {
				if (id_getBackpropMomentumScale == IntPtr.Zero)
					id_getBackpropMomentumScale = JNIEnv.GetMethodID (class_ref, "getBackpropMomentumScale", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBackpropMomentumScale);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackpropMomentumScale", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setBackpropMomentumScale' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBackpropMomentumScale", "(D)V", "GetSetBackpropMomentumScale_DHandler")]
			set {
				if (id_setBackpropMomentumScale_D == IntPtr.Zero)
					id_setBackpropMomentumScale_D = JNIEnv.GetMethodID (class_ref, "setBackpropMomentumScale", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackpropMomentumScale_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackpropMomentumScale", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBackpropWeightScale;
#pragma warning disable 0169
		static Delegate GetGetBackpropWeightScaleHandler ()
		{
			if (cb_getBackpropWeightScale == null)
				cb_getBackpropWeightScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBackpropWeightScale);
			return cb_getBackpropWeightScale;
		}

		static double n_GetBackpropWeightScale (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackpropWeightScale;
		}
#pragma warning restore 0169

		static Delegate cb_setBackpropWeightScale_D;
#pragma warning disable 0169
		static Delegate GetSetBackpropWeightScale_DHandler ()
		{
			if (cb_setBackpropWeightScale_D == null)
				cb_setBackpropWeightScale_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBackpropWeightScale_D);
			return cb_setBackpropWeightScale_D;
		}

		static void n_SetBackpropWeightScale_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackpropWeightScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackpropWeightScale;
		static IntPtr id_setBackpropWeightScale_D;
		public virtual unsafe double BackpropWeightScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getBackpropWeightScale' and count(parameter)=0]"
			[Register ("getBackpropWeightScale", "()D", "GetGetBackpropWeightScaleHandler")]
			get {
				if (id_getBackpropWeightScale == IntPtr.Zero)
					id_getBackpropWeightScale = JNIEnv.GetMethodID (class_ref, "getBackpropWeightScale", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBackpropWeightScale);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackpropWeightScale", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setBackpropWeightScale' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBackpropWeightScale", "(D)V", "GetSetBackpropWeightScale_DHandler")]
			set {
				if (id_setBackpropWeightScale_D == IntPtr.Zero)
					id_setBackpropWeightScale_D = JNIEnv.GetMethodID (class_ref, "setBackpropWeightScale", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackpropWeightScale_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackpropWeightScale", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLayerSizes;
#pragma warning disable 0169
		static Delegate GetGetLayerSizesHandler ()
		{
			if (cb_getLayerSizes == null)
				cb_getLayerSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayerSizes);
			return cb_getLayerSizes;
		}

		static IntPtr n_GetLayerSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LayerSizes);
		}
#pragma warning restore 0169

		static Delegate cb_setLayerSizes_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetLayerSizes_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setLayerSizes_Lorg_opencv_core_Mat_ == null)
				cb_setLayerSizes_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLayerSizes_Lorg_opencv_core_Mat_);
			return cb_setLayerSizes_Lorg_opencv_core_Mat_;
		}

		static void n_SetLayerSizes_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LayerSizes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLayerSizes;
		static IntPtr id_setLayerSizes_Lorg_opencv_core_Mat_;
		public virtual unsafe global::OpenCV.Core.Mat LayerSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getLayerSizes' and count(parameter)=0]"
			[Register ("getLayerSizes", "()Lorg/opencv/core/Mat;", "GetGetLayerSizesHandler")]
			get {
				if (id_getLayerSizes == IntPtr.Zero)
					id_getLayerSizes = JNIEnv.GetMethodID (class_ref, "getLayerSizes", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayerSizes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayerSizes", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setLayerSizes' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
			[Register ("setLayerSizes", "(Lorg/opencv/core/Mat;)V", "GetSetLayerSizes_Lorg_opencv_core_Mat_Handler")]
			set {
				if (id_setLayerSizes_Lorg_opencv_core_Mat_ == IntPtr.Zero)
					id_setLayerSizes_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setLayerSizes", "(Lorg/opencv/core/Mat;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLayerSizes_Lorg_opencv_core_Mat_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLayerSizes", "(Lorg/opencv/core/Mat;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRpropDW0;
#pragma warning disable 0169
		static Delegate GetGetRpropDW0Handler ()
		{
			if (cb_getRpropDW0 == null)
				cb_getRpropDW0 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRpropDW0);
			return cb_getRpropDW0;
		}

		static double n_GetRpropDW0 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RpropDW0;
		}
#pragma warning restore 0169

		static Delegate cb_setRpropDW0_D;
#pragma warning disable 0169
		static Delegate GetSetRpropDW0_DHandler ()
		{
			if (cb_setRpropDW0_D == null)
				cb_setRpropDW0_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRpropDW0_D);
			return cb_setRpropDW0_D;
		}

		static void n_SetRpropDW0_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RpropDW0 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRpropDW0;
		static IntPtr id_setRpropDW0_D;
		public virtual unsafe double RpropDW0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getRpropDW0' and count(parameter)=0]"
			[Register ("getRpropDW0", "()D", "GetGetRpropDW0Handler")]
			get {
				if (id_getRpropDW0 == IntPtr.Zero)
					id_getRpropDW0 = JNIEnv.GetMethodID (class_ref, "getRpropDW0", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRpropDW0);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpropDW0", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setRpropDW0' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRpropDW0", "(D)V", "GetSetRpropDW0_DHandler")]
			set {
				if (id_setRpropDW0_D == IntPtr.Zero)
					id_setRpropDW0_D = JNIEnv.GetMethodID (class_ref, "setRpropDW0", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRpropDW0_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRpropDW0", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRpropDWMax;
#pragma warning disable 0169
		static Delegate GetGetRpropDWMaxHandler ()
		{
			if (cb_getRpropDWMax == null)
				cb_getRpropDWMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRpropDWMax);
			return cb_getRpropDWMax;
		}

		static double n_GetRpropDWMax (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RpropDWMax;
		}
#pragma warning restore 0169

		static Delegate cb_setRpropDWMax_D;
#pragma warning disable 0169
		static Delegate GetSetRpropDWMax_DHandler ()
		{
			if (cb_setRpropDWMax_D == null)
				cb_setRpropDWMax_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRpropDWMax_D);
			return cb_setRpropDWMax_D;
		}

		static void n_SetRpropDWMax_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RpropDWMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRpropDWMax;
		static IntPtr id_setRpropDWMax_D;
		public virtual unsafe double RpropDWMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getRpropDWMax' and count(parameter)=0]"
			[Register ("getRpropDWMax", "()D", "GetGetRpropDWMaxHandler")]
			get {
				if (id_getRpropDWMax == IntPtr.Zero)
					id_getRpropDWMax = JNIEnv.GetMethodID (class_ref, "getRpropDWMax", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRpropDWMax);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpropDWMax", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setRpropDWMax' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRpropDWMax", "(D)V", "GetSetRpropDWMax_DHandler")]
			set {
				if (id_setRpropDWMax_D == IntPtr.Zero)
					id_setRpropDWMax_D = JNIEnv.GetMethodID (class_ref, "setRpropDWMax", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRpropDWMax_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRpropDWMax", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRpropDWMin;
#pragma warning disable 0169
		static Delegate GetGetRpropDWMinHandler ()
		{
			if (cb_getRpropDWMin == null)
				cb_getRpropDWMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRpropDWMin);
			return cb_getRpropDWMin;
		}

		static double n_GetRpropDWMin (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RpropDWMin;
		}
#pragma warning restore 0169

		static Delegate cb_setRpropDWMin_D;
#pragma warning disable 0169
		static Delegate GetSetRpropDWMin_DHandler ()
		{
			if (cb_setRpropDWMin_D == null)
				cb_setRpropDWMin_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRpropDWMin_D);
			return cb_setRpropDWMin_D;
		}

		static void n_SetRpropDWMin_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RpropDWMin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRpropDWMin;
		static IntPtr id_setRpropDWMin_D;
		public virtual unsafe double RpropDWMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getRpropDWMin' and count(parameter)=0]"
			[Register ("getRpropDWMin", "()D", "GetGetRpropDWMinHandler")]
			get {
				if (id_getRpropDWMin == IntPtr.Zero)
					id_getRpropDWMin = JNIEnv.GetMethodID (class_ref, "getRpropDWMin", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRpropDWMin);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpropDWMin", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setRpropDWMin' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRpropDWMin", "(D)V", "GetSetRpropDWMin_DHandler")]
			set {
				if (id_setRpropDWMin_D == IntPtr.Zero)
					id_setRpropDWMin_D = JNIEnv.GetMethodID (class_ref, "setRpropDWMin", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRpropDWMin_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRpropDWMin", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRpropDWMinus;
#pragma warning disable 0169
		static Delegate GetGetRpropDWMinusHandler ()
		{
			if (cb_getRpropDWMinus == null)
				cb_getRpropDWMinus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRpropDWMinus);
			return cb_getRpropDWMinus;
		}

		static double n_GetRpropDWMinus (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RpropDWMinus;
		}
#pragma warning restore 0169

		static Delegate cb_setRpropDWMinus_D;
#pragma warning disable 0169
		static Delegate GetSetRpropDWMinus_DHandler ()
		{
			if (cb_setRpropDWMinus_D == null)
				cb_setRpropDWMinus_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRpropDWMinus_D);
			return cb_setRpropDWMinus_D;
		}

		static void n_SetRpropDWMinus_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RpropDWMinus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRpropDWMinus;
		static IntPtr id_setRpropDWMinus_D;
		public virtual unsafe double RpropDWMinus {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getRpropDWMinus' and count(parameter)=0]"
			[Register ("getRpropDWMinus", "()D", "GetGetRpropDWMinusHandler")]
			get {
				if (id_getRpropDWMinus == IntPtr.Zero)
					id_getRpropDWMinus = JNIEnv.GetMethodID (class_ref, "getRpropDWMinus", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRpropDWMinus);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpropDWMinus", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setRpropDWMinus' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRpropDWMinus", "(D)V", "GetSetRpropDWMinus_DHandler")]
			set {
				if (id_setRpropDWMinus_D == IntPtr.Zero)
					id_setRpropDWMinus_D = JNIEnv.GetMethodID (class_ref, "setRpropDWMinus", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRpropDWMinus_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRpropDWMinus", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRpropDWPlus;
#pragma warning disable 0169
		static Delegate GetGetRpropDWPlusHandler ()
		{
			if (cb_getRpropDWPlus == null)
				cb_getRpropDWPlus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRpropDWPlus);
			return cb_getRpropDWPlus;
		}

		static double n_GetRpropDWPlus (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RpropDWPlus;
		}
#pragma warning restore 0169

		static Delegate cb_setRpropDWPlus_D;
#pragma warning disable 0169
		static Delegate GetSetRpropDWPlus_DHandler ()
		{
			if (cb_setRpropDWPlus_D == null)
				cb_setRpropDWPlus_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRpropDWPlus_D);
			return cb_setRpropDWPlus_D;
		}

		static void n_SetRpropDWPlus_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RpropDWPlus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRpropDWPlus;
		static IntPtr id_setRpropDWPlus_D;
		public virtual unsafe double RpropDWPlus {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getRpropDWPlus' and count(parameter)=0]"
			[Register ("getRpropDWPlus", "()D", "GetGetRpropDWPlusHandler")]
			get {
				if (id_getRpropDWPlus == IntPtr.Zero)
					id_getRpropDWPlus = JNIEnv.GetMethodID (class_ref, "getRpropDWPlus", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRpropDWPlus);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpropDWPlus", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setRpropDWPlus' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRpropDWPlus", "(D)V", "GetSetRpropDWPlus_DHandler")]
			set {
				if (id_setRpropDWPlus_D == IntPtr.Zero)
					id_setRpropDWPlus_D = JNIEnv.GetMethodID (class_ref, "setRpropDWPlus", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRpropDWPlus_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRpropDWPlus", "(D)V"), __args);
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
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.TermCriteria p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TermCriteria = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTermCriteria;
		static IntPtr id_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		public virtual unsafe global::OpenCV.Core.TermCriteria TermCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getTermCriteria' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setTermCriteria' and count(parameter)=1 and parameter[1][@type='org.opencv.core.TermCriteria']]"
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

		static Delegate cb_getTrainMethod;
#pragma warning disable 0169
		static Delegate GetGetTrainMethodHandler ()
		{
			if (cb_getTrainMethod == null)
				cb_getTrainMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrainMethod);
			return cb_getTrainMethod;
		}

		static int n_GetTrainMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrainMethod;
		}
#pragma warning restore 0169

		static Delegate cb_setTrainMethod_I;
#pragma warning disable 0169
		static Delegate GetSetTrainMethod_IHandler ()
		{
			if (cb_setTrainMethod_I == null)
				cb_setTrainMethod_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrainMethod_I);
			return cb_setTrainMethod_I;
		}

		static void n_SetTrainMethod_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrainMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrainMethod;
		static IntPtr id_setTrainMethod_I;
		public virtual unsafe int TrainMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getTrainMethod' and count(parameter)=0]"
			[Register ("getTrainMethod", "()I", "GetGetTrainMethodHandler")]
			get {
				if (id_getTrainMethod == IntPtr.Zero)
					id_getTrainMethod = JNIEnv.GetMethodID (class_ref, "getTrainMethod", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrainMethod);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainMethod", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setTrainMethod' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrainMethod", "(I)V", "GetSetTrainMethod_IHandler")]
			set {
				if (id_setTrainMethod_I == IntPtr.Zero)
					id_setTrainMethod_I = JNIEnv.GetMethodID (class_ref, "setTrainMethod", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainMethod_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainMethod", "(I)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/ANN_MLP;", "")]
		public static unsafe global::OpenCV.ML.ANN_MLP Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/ANN_MLP;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getWeights_I;
#pragma warning disable 0169
		static Delegate GetGetWeights_IHandler ()
		{
			if (cb_getWeights_I == null)
				cb_getWeights_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetWeights_I);
			return cb_getWeights_I;
		}

		static IntPtr n_GetWeights_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetWeights (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getWeights_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='getWeights' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWeights", "(I)Lorg/opencv/core/Mat;", "GetGetWeights_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat GetWeights (int p0)
		{
			if (id_getWeights_I == IntPtr.Zero)
				id_getWeights_I = JNIEnv.GetMethodID (class_ref, "getWeights", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeights_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActivationFunction_I;
#pragma warning disable 0169
		static Delegate GetSetActivationFunction_IHandler ()
		{
			if (cb_setActivationFunction_I == null)
				cb_setActivationFunction_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActivationFunction_I);
			return cb_setActivationFunction_I;
		}

		static void n_SetActivationFunction_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActivationFunction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivationFunction_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setActivationFunction' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActivationFunction", "(I)V", "GetSetActivationFunction_IHandler")]
		public virtual unsafe void SetActivationFunction (int p0)
		{
			if (id_setActivationFunction_I == IntPtr.Zero)
				id_setActivationFunction_I = JNIEnv.GetMethodID (class_ref, "setActivationFunction", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivationFunction_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivationFunction", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setActivationFunction_IDD;
#pragma warning disable 0169
		static Delegate GetSetActivationFunction_IDDHandler ()
		{
			if (cb_setActivationFunction_IDD == null)
				cb_setActivationFunction_IDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double, double>) n_SetActivationFunction_IDD);
			return cb_setActivationFunction_IDD;
		}

		static void n_SetActivationFunction_IDD (IntPtr jnienv, IntPtr native__this, int p0, double p1, double p2)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActivationFunction (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setActivationFunction_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setActivationFunction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("setActivationFunction", "(IDD)V", "GetSetActivationFunction_IDDHandler")]
		public virtual unsafe void SetActivationFunction (int p0, double p1, double p2)
		{
			if (id_setActivationFunction_IDD == IntPtr.Zero)
				id_setActivationFunction_IDD = JNIEnv.GetMethodID (class_ref, "setActivationFunction", "(IDD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivationFunction_IDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivationFunction", "(IDD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrainMethod_IDD;
#pragma warning disable 0169
		static Delegate GetSetTrainMethod_IDDHandler ()
		{
			if (cb_setTrainMethod_IDD == null)
				cb_setTrainMethod_IDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double, double>) n_SetTrainMethod_IDD);
			return cb_setTrainMethod_IDD;
		}

		static void n_SetTrainMethod_IDD (IntPtr jnienv, IntPtr native__this, int p0, double p1, double p2)
		{
			global::OpenCV.ML.ANN_MLP __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.ANN_MLP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrainMethod (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setTrainMethod_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='ANN_MLP']/method[@name='setTrainMethod' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("setTrainMethod", "(IDD)V", "GetSetTrainMethod_IDDHandler")]
		public virtual unsafe void SetTrainMethod (int p0, double p1, double p2)
		{
			if (id_setTrainMethod_IDD == IntPtr.Zero)
				id_setTrainMethod_IDD = JNIEnv.GetMethodID (class_ref, "setTrainMethod", "(IDD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainMethod_IDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainMethod", "(IDD)V"), __args);
			} finally {
			}
		}

	}
}
