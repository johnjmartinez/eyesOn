using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']"
	[global::Android.Runtime.Register ("org/opencv/ml/LogisticRegression", DoNotGenerateAcw=true)]
	public partial class LogisticRegression : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/field[@name='BATCH']"
		[Register ("BATCH")]
		public const int Batch = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/field[@name='MINI_BATCH']"
		[Register ("MINI_BATCH")]
		public const int MiniBatch = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/field[@name='REG_DISABLE']"
		[Register ("REG_DISABLE")]
		public const int RegDisable = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/field[@name='REG_L1']"
		[Register ("REG_L1")]
		public const int RegL1 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/field[@name='REG_L2']"
		[Register ("REG_L2")]
		public const int RegL2 = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/LogisticRegression", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogisticRegression); }
		}

		protected LogisticRegression (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/constructor[@name='LogisticRegression' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe LogisticRegression (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LogisticRegression)) {
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

		static Delegate cb_getIterations;
#pragma warning disable 0169
		static Delegate GetGetIterationsHandler ()
		{
			if (cb_getIterations == null)
				cb_getIterations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIterations);
			return cb_getIterations;
		}

		static int n_GetIterations (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Iterations;
		}
#pragma warning restore 0169

		static Delegate cb_setIterations_I;
#pragma warning disable 0169
		static Delegate GetSetIterations_IHandler ()
		{
			if (cb_setIterations_I == null)
				cb_setIterations_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIterations_I);
			return cb_setIterations_I;
		}

		static void n_SetIterations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Iterations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIterations;
		static IntPtr id_setIterations_I;
		public virtual unsafe int Iterations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getIterations' and count(parameter)=0]"
			[Register ("getIterations", "()I", "GetGetIterationsHandler")]
			get {
				if (id_getIterations == IntPtr.Zero)
					id_getIterations = JNIEnv.GetMethodID (class_ref, "getIterations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIterations);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIterations", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setIterations' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIterations", "(I)V", "GetSetIterations_IHandler")]
			set {
				if (id_setIterations_I == IntPtr.Zero)
					id_setIterations_I = JNIEnv.GetMethodID (class_ref, "setIterations", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIterations_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIterations", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLearningRate;
#pragma warning disable 0169
		static Delegate GetGetLearningRateHandler ()
		{
			if (cb_getLearningRate == null)
				cb_getLearningRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLearningRate);
			return cb_getLearningRate;
		}

		static double n_GetLearningRate (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LearningRate;
		}
#pragma warning restore 0169

		static Delegate cb_setLearningRate_D;
#pragma warning disable 0169
		static Delegate GetSetLearningRate_DHandler ()
		{
			if (cb_setLearningRate_D == null)
				cb_setLearningRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLearningRate_D);
			return cb_setLearningRate_D;
		}

		static void n_SetLearningRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LearningRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLearningRate;
		static IntPtr id_setLearningRate_D;
		public virtual unsafe double LearningRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getLearningRate' and count(parameter)=0]"
			[Register ("getLearningRate", "()D", "GetGetLearningRateHandler")]
			get {
				if (id_getLearningRate == IntPtr.Zero)
					id_getLearningRate = JNIEnv.GetMethodID (class_ref, "getLearningRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLearningRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLearningRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setLearningRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLearningRate", "(D)V", "GetSetLearningRate_DHandler")]
			set {
				if (id_setLearningRate_D == IntPtr.Zero)
					id_setLearningRate_D = JNIEnv.GetMethodID (class_ref, "setLearningRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLearningRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLearningRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMiniBatchSize;
#pragma warning disable 0169
		static Delegate GetGetMiniBatchSizeHandler ()
		{
			if (cb_getMiniBatchSize == null)
				cb_getMiniBatchSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMiniBatchSize);
			return cb_getMiniBatchSize;
		}

		static int n_GetMiniBatchSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MiniBatchSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMiniBatchSize_I;
#pragma warning disable 0169
		static Delegate GetSetMiniBatchSize_IHandler ()
		{
			if (cb_setMiniBatchSize_I == null)
				cb_setMiniBatchSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMiniBatchSize_I);
			return cb_setMiniBatchSize_I;
		}

		static void n_SetMiniBatchSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MiniBatchSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMiniBatchSize;
		static IntPtr id_setMiniBatchSize_I;
		public virtual unsafe int MiniBatchSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getMiniBatchSize' and count(parameter)=0]"
			[Register ("getMiniBatchSize", "()I", "GetGetMiniBatchSizeHandler")]
			get {
				if (id_getMiniBatchSize == IntPtr.Zero)
					id_getMiniBatchSize = JNIEnv.GetMethodID (class_ref, "getMiniBatchSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMiniBatchSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiniBatchSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setMiniBatchSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMiniBatchSize", "(I)V", "GetSetMiniBatchSize_IHandler")]
			set {
				if (id_setMiniBatchSize_I == IntPtr.Zero)
					id_setMiniBatchSize_I = JNIEnv.GetMethodID (class_ref, "setMiniBatchSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMiniBatchSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMiniBatchSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRegularization;
#pragma warning disable 0169
		static Delegate GetGetRegularizationHandler ()
		{
			if (cb_getRegularization == null)
				cb_getRegularization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRegularization);
			return cb_getRegularization;
		}

		static int n_GetRegularization (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Regularization;
		}
#pragma warning restore 0169

		static Delegate cb_setRegularization_I;
#pragma warning disable 0169
		static Delegate GetSetRegularization_IHandler ()
		{
			if (cb_setRegularization_I == null)
				cb_setRegularization_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRegularization_I);
			return cb_setRegularization_I;
		}

		static void n_SetRegularization_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Regularization = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegularization;
		static IntPtr id_setRegularization_I;
		public virtual unsafe int Regularization {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getRegularization' and count(parameter)=0]"
			[Register ("getRegularization", "()I", "GetGetRegularizationHandler")]
			get {
				if (id_getRegularization == IntPtr.Zero)
					id_getRegularization = JNIEnv.GetMethodID (class_ref, "getRegularization", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRegularization);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegularization", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setRegularization' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRegularization", "(I)V", "GetSetRegularization_IHandler")]
			set {
				if (id_setRegularization_I == IntPtr.Zero)
					id_setRegularization_I = JNIEnv.GetMethodID (class_ref, "setRegularization", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegularization_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegularization", "(I)V"), __args);
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
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.TermCriteria p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TermCriteria = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTermCriteria;
		static IntPtr id_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		public virtual unsafe global::OpenCV.Core.TermCriteria TermCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getTermCriteria' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setTermCriteria' and count(parameter)=1 and parameter[1][@type='org.opencv.core.TermCriteria']]"
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
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrainMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrainMethod;
		static IntPtr id_setTrainMethod_I;
		public virtual unsafe int TrainMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='getTrainMethod' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='setTrainMethod' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/LogisticRegression;", "")]
		public static unsafe global::OpenCV.ML.LogisticRegression Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/LogisticRegression;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_learnt_thetas;
#pragma warning disable 0169
		static Delegate GetGet_learnt_thetasHandler ()
		{
			if (cb_get_learnt_thetas == null)
				cb_get_learnt_thetas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_learnt_thetas);
			return cb_get_learnt_thetas;
		}

		static IntPtr n_Get_learnt_thetas (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.LogisticRegression __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.LogisticRegression> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_learnt_thetas ());
		}
#pragma warning restore 0169

		static IntPtr id_get_learnt_thetas;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='LogisticRegression']/method[@name='get_learnt_thetas' and count(parameter)=0]"
		[Register ("get_learnt_thetas", "()Lorg/opencv/core/Mat;", "GetGet_learnt_thetasHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_learnt_thetas ()
		{
			if (id_get_learnt_thetas == IntPtr.Zero)
				id_get_learnt_thetas = JNIEnv.GetMethodID (class_ref, "get_learnt_thetas", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_learnt_thetas), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_learnt_thetas", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
