using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']"
	[global::Android.Runtime.Register ("org/opencv/ml/SVM", DoNotGenerateAcw=true)]
	public partial class SVM : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='C']"
		[Register ("C")]
		public const int C = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='CHI2']"
		[Register ("CHI2")]
		public const int Chi2 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='COEF']"
		[Register ("COEF")]
		public const int Coef = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public const int Custom = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='C_SVC']"
		[Register ("C_SVC")]
		public const int CSvc = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='EPS_SVR']"
		[Register ("EPS_SVR")]
		public const int EpsSvr = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='INTER']"
		[Register ("INTER")]
		public const int Inter = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='LINEAR']"
		[Register ("LINEAR")]
		public const int Linear = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='NU_SVC']"
		[Register ("NU_SVC")]
		public const int NuSvc = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='NU_SVR']"
		[Register ("NU_SVR")]
		public const int NuSvr = (int) 104;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='ONE_CLASS']"
		[Register ("ONE_CLASS")]
		public const int OneClass = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='P']"
		[Register ("P")]
		public const int P = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='POLY']"
		[Register ("POLY")]
		public const int Poly = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='RBF']"
		[Register ("RBF")]
		public const int Rbf = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/field[@name='SIGMOID']"
		[Register ("SIGMOID")]
		public const int Sigmoid = (int) 3;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/SVM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SVM); }
		}

		protected SVM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/constructor[@name='SVM' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe SVM (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SVM)) {
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

		static Delegate cb_getClassWeights;
#pragma warning disable 0169
		static Delegate GetGetClassWeightsHandler ()
		{
			if (cb_getClassWeights == null)
				cb_getClassWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassWeights);
			return cb_getClassWeights;
		}

		static IntPtr n_GetClassWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassWeights);
		}
#pragma warning restore 0169

		static Delegate cb_setClassWeights_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetClassWeights_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setClassWeights_Lorg_opencv_core_Mat_ == null)
				cb_setClassWeights_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClassWeights_Lorg_opencv_core_Mat_);
			return cb_setClassWeights_Lorg_opencv_core_Mat_;
		}

		static void n_SetClassWeights_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClassWeights = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClassWeights;
		static IntPtr id_setClassWeights_Lorg_opencv_core_Mat_;
		public virtual unsafe global::OpenCV.Core.Mat ClassWeights {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getClassWeights' and count(parameter)=0]"
			[Register ("getClassWeights", "()Lorg/opencv/core/Mat;", "GetGetClassWeightsHandler")]
			get {
				if (id_getClassWeights == IntPtr.Zero)
					id_getClassWeights = JNIEnv.GetMethodID (class_ref, "getClassWeights", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClassWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassWeights", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setClassWeights' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
			[Register ("setClassWeights", "(Lorg/opencv/core/Mat;)V", "GetSetClassWeights_Lorg_opencv_core_Mat_Handler")]
			set {
				if (id_setClassWeights_Lorg_opencv_core_Mat_ == IntPtr.Zero)
					id_setClassWeights_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setClassWeights", "(Lorg/opencv/core/Mat;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClassWeights_Lorg_opencv_core_Mat_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClassWeights", "(Lorg/opencv/core/Mat;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCoef0;
#pragma warning disable 0169
		static Delegate GetGetCoef0Handler ()
		{
			if (cb_getCoef0 == null)
				cb_getCoef0 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetCoef0);
			return cb_getCoef0;
		}

		static double n_GetCoef0 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Coef0;
		}
#pragma warning restore 0169

		static Delegate cb_setCoef0_D;
#pragma warning disable 0169
		static Delegate GetSetCoef0_DHandler ()
		{
			if (cb_setCoef0_D == null)
				cb_setCoef0_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetCoef0_D);
			return cb_setCoef0_D;
		}

		static void n_SetCoef0_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Coef0 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCoef0;
		static IntPtr id_setCoef0_D;
		public virtual unsafe double Coef0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getCoef0' and count(parameter)=0]"
			[Register ("getCoef0", "()D", "GetGetCoef0Handler")]
			get {
				if (id_getCoef0 == IntPtr.Zero)
					id_getCoef0 = JNIEnv.GetMethodID (class_ref, "getCoef0", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getCoef0);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCoef0", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setCoef0' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setCoef0", "(D)V", "GetSetCoef0_DHandler")]
			set {
				if (id_setCoef0_D == IntPtr.Zero)
					id_setCoef0_D = JNIEnv.GetMethodID (class_ref, "setCoef0", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCoef0_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCoef0", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDegree;
#pragma warning disable 0169
		static Delegate GetGetDegreeHandler ()
		{
			if (cb_getDegree == null)
				cb_getDegree = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDegree);
			return cb_getDegree;
		}

		static double n_GetDegree (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Degree;
		}
#pragma warning restore 0169

		static Delegate cb_setDegree_D;
#pragma warning disable 0169
		static Delegate GetSetDegree_DHandler ()
		{
			if (cb_setDegree_D == null)
				cb_setDegree_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDegree_D);
			return cb_setDegree_D;
		}

		static void n_SetDegree_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Degree = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDegree;
		static IntPtr id_setDegree_D;
		public virtual unsafe double Degree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getDegree' and count(parameter)=0]"
			[Register ("getDegree", "()D", "GetGetDegreeHandler")]
			get {
				if (id_getDegree == IntPtr.Zero)
					id_getDegree = JNIEnv.GetMethodID (class_ref, "getDegree", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDegree);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDegree", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setDegree' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDegree", "(D)V", "GetSetDegree_DHandler")]
			set {
				if (id_setDegree_D == IntPtr.Zero)
					id_setDegree_D = JNIEnv.GetMethodID (class_ref, "setDegree", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDegree_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDegree", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGamma;
#pragma warning disable 0169
		static Delegate GetGetGammaHandler ()
		{
			if (cb_getGamma == null)
				cb_getGamma = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetGamma);
			return cb_getGamma;
		}

		static double n_GetGamma (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gamma;
		}
#pragma warning restore 0169

		static Delegate cb_setGamma_D;
#pragma warning disable 0169
		static Delegate GetSetGamma_DHandler ()
		{
			if (cb_setGamma_D == null)
				cb_setGamma_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetGamma_D);
			return cb_setGamma_D;
		}

		static void n_SetGamma_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gamma = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGamma;
		static IntPtr id_setGamma_D;
		public virtual unsafe double Gamma {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getGamma' and count(parameter)=0]"
			[Register ("getGamma", "()D", "GetGetGammaHandler")]
			get {
				if (id_getGamma == IntPtr.Zero)
					id_getGamma = JNIEnv.GetMethodID (class_ref, "getGamma", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getGamma);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGamma", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setGamma' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setGamma", "(D)V", "GetSetGamma_DHandler")]
			set {
				if (id_setGamma_D == IntPtr.Zero)
					id_setGamma_D = JNIEnv.GetMethodID (class_ref, "setGamma", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGamma_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGamma", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKernelType;
#pragma warning disable 0169
		static Delegate GetGetKernelTypeHandler ()
		{
			if (cb_getKernelType == null)
				cb_getKernelType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKernelType);
			return cb_getKernelType;
		}

		static int n_GetKernelType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KernelType;
		}
#pragma warning restore 0169

		static IntPtr id_getKernelType;
		public virtual unsafe int KernelType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getKernelType' and count(parameter)=0]"
			[Register ("getKernelType", "()I", "GetGetKernelTypeHandler")]
			get {
				if (id_getKernelType == IntPtr.Zero)
					id_getKernelType = JNIEnv.GetMethodID (class_ref, "getKernelType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKernelType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKernelType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNu;
#pragma warning disable 0169
		static Delegate GetGetNuHandler ()
		{
			if (cb_getNu == null)
				cb_getNu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetNu);
			return cb_getNu;
		}

		static double n_GetNu (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Nu;
		}
#pragma warning restore 0169

		static Delegate cb_setNu_D;
#pragma warning disable 0169
		static Delegate GetSetNu_DHandler ()
		{
			if (cb_setNu_D == null)
				cb_setNu_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetNu_D);
			return cb_setNu_D;
		}

		static void n_SetNu_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Nu = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNu;
		static IntPtr id_setNu_D;
		public virtual unsafe double Nu {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getNu' and count(parameter)=0]"
			[Register ("getNu", "()D", "GetGetNuHandler")]
			get {
				if (id_getNu == IntPtr.Zero)
					id_getNu = JNIEnv.GetMethodID (class_ref, "getNu", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getNu);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNu", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setNu' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setNu", "(D)V", "GetSetNu_DHandler")]
			set {
				if (id_setNu_D == IntPtr.Zero)
					id_setNu_D = JNIEnv.GetMethodID (class_ref, "setNu", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNu_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNu", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportVectors;
#pragma warning disable 0169
		static Delegate GetGetSupportVectorsHandler ()
		{
			if (cb_getSupportVectors == null)
				cb_getSupportVectors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportVectors);
			return cb_getSupportVectors;
		}

		static IntPtr n_GetSupportVectors (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportVectors);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportVectors;
		public virtual unsafe global::OpenCV.Core.Mat SupportVectors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getSupportVectors' and count(parameter)=0]"
			[Register ("getSupportVectors", "()Lorg/opencv/core/Mat;", "GetGetSupportVectorsHandler")]
			get {
				if (id_getSupportVectors == IntPtr.Zero)
					id_getSupportVectors = JNIEnv.GetMethodID (class_ref, "getSupportVectors", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportVectors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportVectors", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.TermCriteria p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TermCriteria = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTermCriteria;
		static IntPtr id_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		public virtual unsafe global::OpenCV.Core.TermCriteria TermCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getTermCriteria' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setTermCriteria' and count(parameter)=1 and parameter[1][@type='org.opencv.core.TermCriteria']]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_I;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			set {
				if (id_setType_I == IntPtr.Zero)
					id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUncompressedSupportVectors;
#pragma warning disable 0169
		static Delegate GetGetUncompressedSupportVectorsHandler ()
		{
			if (cb_getUncompressedSupportVectors == null)
				cb_getUncompressedSupportVectors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUncompressedSupportVectors);
			return cb_getUncompressedSupportVectors;
		}

		static IntPtr n_GetUncompressedSupportVectors (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UncompressedSupportVectors);
		}
#pragma warning restore 0169

		static IntPtr id_getUncompressedSupportVectors;
		public virtual unsafe global::OpenCV.Core.Mat UncompressedSupportVectors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getUncompressedSupportVectors' and count(parameter)=0]"
			[Register ("getUncompressedSupportVectors", "()Lorg/opencv/core/Mat;", "GetGetUncompressedSupportVectorsHandler")]
			get {
				if (id_getUncompressedSupportVectors == IntPtr.Zero)
					id_getUncompressedSupportVectors = JNIEnv.GetMethodID (class_ref, "getUncompressedSupportVectors", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUncompressedSupportVectors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUncompressedSupportVectors", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/SVM;", "")]
		public static unsafe global::OpenCV.ML.SVM Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/SVM;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getC;
#pragma warning disable 0169
		static Delegate GetGetCHandler ()
		{
			if (cb_getC == null)
				cb_getC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetC);
			return cb_getC;
		}

		static double n_GetC (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetC ();
		}
#pragma warning restore 0169

		static IntPtr id_getC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getC' and count(parameter)=0]"
		[Register ("getC", "()D", "GetGetCHandler")]
		public virtual unsafe double GetC ()
		{
			if (id_getC == IntPtr.Zero)
				id_getC = JNIEnv.GetMethodID (class_ref, "getC", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getC);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getC", "()D"));
			} finally {
			}
		}

		static Delegate cb_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetGetDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, double>) n_GetDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static double n_GetDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDecisionFunction (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getDecisionFunction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("getDecisionFunction", "(ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "GetGetDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe double GetDecisionFunction (int p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "getDecisionFunction", "(ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDecisionFunction_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecisionFunction", "(ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getP;
#pragma warning disable 0169
		static Delegate GetGetPHandler ()
		{
			if (cb_getP == null)
				cb_getP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetP);
			return cb_getP;
		}

		static double n_GetP (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetP ();
		}
#pragma warning restore 0169

		static IntPtr id_getP;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='getP' and count(parameter)=0]"
		[Register ("getP", "()D", "GetGetPHandler")]
		public virtual unsafe double GetP ()
		{
			if (id_getP == IntPtr.Zero)
				id_getP = JNIEnv.GetMethodID (class_ref, "getP", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getP);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getP", "()D"));
			} finally {
			}
		}

		static Delegate cb_setC_D;
#pragma warning disable 0169
		static Delegate GetSetC_DHandler ()
		{
			if (cb_setC_D == null)
				cb_setC_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetC_D);
			return cb_setC_D;
		}

		static void n_SetC_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetC (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setC_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setC' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setC", "(D)V", "GetSetC_DHandler")]
		public virtual unsafe void SetC (double p0)
		{
			if (id_setC_D == IntPtr.Zero)
				id_setC_D = JNIEnv.GetMethodID (class_ref, "setC", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setC_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setC", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setKernel_I;
#pragma warning disable 0169
		static Delegate GetSetKernel_IHandler ()
		{
			if (cb_setKernel_I == null)
				cb_setKernel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetKernel_I);
			return cb_setKernel_I;
		}

		static void n_SetKernel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKernel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKernel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setKernel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKernel", "(I)V", "GetSetKernel_IHandler")]
		public virtual unsafe void SetKernel (int p0)
		{
			if (id_setKernel_I == IntPtr.Zero)
				id_setKernel_I = JNIEnv.GetMethodID (class_ref, "setKernel", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKernel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKernel", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setP_D;
#pragma warning disable 0169
		static Delegate GetSetP_DHandler ()
		{
			if (cb_setP_D == null)
				cb_setP_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetP_D);
			return cb_setP_D;
		}

		static void n_SetP_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.SVM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.SVM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetP (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setP_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='SVM']/method[@name='setP' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setP", "(D)V", "GetSetP_DHandler")]
		public virtual unsafe void SetP (double p0)
		{
			if (id_setP_D == IntPtr.Zero)
				id_setP_D = JNIEnv.GetMethodID (class_ref, "setP", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setP_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setP", "(D)V"), __args);
			} finally {
			}
		}

	}
}
