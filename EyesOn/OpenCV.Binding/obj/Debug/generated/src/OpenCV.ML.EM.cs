using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']"
	[global::Android.Runtime.Register ("org/opencv/ml/EM", DoNotGenerateAcw=true)]
	public partial class EM : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='COV_MAT_DEFAULT']"
		[Register ("COV_MAT_DEFAULT")]
		public const int CovMatDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='COV_MAT_DIAGONAL']"
		[Register ("COV_MAT_DIAGONAL")]
		public const int CovMatDiagonal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='COV_MAT_GENERIC']"
		[Register ("COV_MAT_GENERIC")]
		public const int CovMatGeneric = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='COV_MAT_SPHERICAL']"
		[Register ("COV_MAT_SPHERICAL")]
		public const int CovMatSpherical = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='DEFAULT_MAX_ITERS']"
		[Register ("DEFAULT_MAX_ITERS")]
		public const int DefaultMaxIters = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='DEFAULT_NCLUSTERS']"
		[Register ("DEFAULT_NCLUSTERS")]
		public const int DefaultNclusters = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='START_AUTO_STEP']"
		[Register ("START_AUTO_STEP")]
		public const int StartAutoStep = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='START_E_STEP']"
		[Register ("START_E_STEP")]
		public const int StartEStep = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/field[@name='START_M_STEP']"
		[Register ("START_M_STEP")]
		public const int StartMStep = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/EM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EM); }
		}

		protected EM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/constructor[@name='EM' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe EM (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (EM)) {
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

		static Delegate cb_getClustersNumber;
#pragma warning disable 0169
		static Delegate GetGetClustersNumberHandler ()
		{
			if (cb_getClustersNumber == null)
				cb_getClustersNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetClustersNumber);
			return cb_getClustersNumber;
		}

		static int n_GetClustersNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClustersNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setClustersNumber_I;
#pragma warning disable 0169
		static Delegate GetSetClustersNumber_IHandler ()
		{
			if (cb_setClustersNumber_I == null)
				cb_setClustersNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetClustersNumber_I);
			return cb_setClustersNumber_I;
		}

		static void n_SetClustersNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClustersNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClustersNumber;
		static IntPtr id_setClustersNumber_I;
		public virtual unsafe int ClustersNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getClustersNumber' and count(parameter)=0]"
			[Register ("getClustersNumber", "()I", "GetGetClustersNumberHandler")]
			get {
				if (id_getClustersNumber == IntPtr.Zero)
					id_getClustersNumber = JNIEnv.GetMethodID (class_ref, "getClustersNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getClustersNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClustersNumber", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='setClustersNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setClustersNumber", "(I)V", "GetSetClustersNumber_IHandler")]
			set {
				if (id_setClustersNumber_I == IntPtr.Zero)
					id_setClustersNumber_I = JNIEnv.GetMethodID (class_ref, "setClustersNumber", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClustersNumber_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClustersNumber", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCovarianceMatrixType;
#pragma warning disable 0169
		static Delegate GetGetCovarianceMatrixTypeHandler ()
		{
			if (cb_getCovarianceMatrixType == null)
				cb_getCovarianceMatrixType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCovarianceMatrixType);
			return cb_getCovarianceMatrixType;
		}

		static int n_GetCovarianceMatrixType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CovarianceMatrixType;
		}
#pragma warning restore 0169

		static Delegate cb_setCovarianceMatrixType_I;
#pragma warning disable 0169
		static Delegate GetSetCovarianceMatrixType_IHandler ()
		{
			if (cb_setCovarianceMatrixType_I == null)
				cb_setCovarianceMatrixType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCovarianceMatrixType_I);
			return cb_setCovarianceMatrixType_I;
		}

		static void n_SetCovarianceMatrixType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CovarianceMatrixType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCovarianceMatrixType;
		static IntPtr id_setCovarianceMatrixType_I;
		public virtual unsafe int CovarianceMatrixType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getCovarianceMatrixType' and count(parameter)=0]"
			[Register ("getCovarianceMatrixType", "()I", "GetGetCovarianceMatrixTypeHandler")]
			get {
				if (id_getCovarianceMatrixType == IntPtr.Zero)
					id_getCovarianceMatrixType = JNIEnv.GetMethodID (class_ref, "getCovarianceMatrixType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCovarianceMatrixType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCovarianceMatrixType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='setCovarianceMatrixType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCovarianceMatrixType", "(I)V", "GetSetCovarianceMatrixType_IHandler")]
			set {
				if (id_setCovarianceMatrixType_I == IntPtr.Zero)
					id_setCovarianceMatrixType_I = JNIEnv.GetMethodID (class_ref, "setCovarianceMatrixType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCovarianceMatrixType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCovarianceMatrixType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMeans;
#pragma warning disable 0169
		static Delegate GetGetMeansHandler ()
		{
			if (cb_getMeans == null)
				cb_getMeans = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeans);
			return cb_getMeans;
		}

		static IntPtr n_GetMeans (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Means);
		}
#pragma warning restore 0169

		static IntPtr id_getMeans;
		public virtual unsafe global::OpenCV.Core.Mat Means {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getMeans' and count(parameter)=0]"
			[Register ("getMeans", "()Lorg/opencv/core/Mat;", "GetGetMeansHandler")]
			get {
				if (id_getMeans == IntPtr.Zero)
					id_getMeans = JNIEnv.GetMethodID (class_ref, "getMeans", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeans), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeans", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.TermCriteria p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TermCriteria = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTermCriteria;
		static IntPtr id_setTermCriteria_Lorg_opencv_core_TermCriteria_;
		public virtual unsafe global::OpenCV.Core.TermCriteria TermCriteria {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getTermCriteria' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='setTermCriteria' and count(parameter)=1 and parameter[1][@type='org.opencv.core.TermCriteria']]"
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

		static Delegate cb_getWeights;
#pragma warning disable 0169
		static Delegate GetGetWeightsHandler ()
		{
			if (cb_getWeights == null)
				cb_getWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeights);
			return cb_getWeights;
		}

		static IntPtr n_GetWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Weights);
		}
#pragma warning restore 0169

		static IntPtr id_getWeights;
		public virtual unsafe global::OpenCV.Core.Mat Weights {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getWeights' and count(parameter)=0]"
			[Register ("getWeights", "()Lorg/opencv/core/Mat;", "GetGetWeightsHandler")]
			get {
				if (id_getWeights == IntPtr.Zero)
					id_getWeights = JNIEnv.GetMethodID (class_ref, "getWeights", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeights", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/EM;", "")]
		public static unsafe global::OpenCV.ML.EM Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/EM;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCovs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetCovs_Ljava_util_List_Handler ()
		{
			if (cb_getCovs_Ljava_util_List_ == null)
				cb_getCovs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetCovs_Ljava_util_List_);
			return cb_getCovs_Ljava_util_List_;
		}

		static void n_GetCovs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCovs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getCovs_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='getCovs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("getCovs", "(Ljava/util/List;)V", "GetGetCovs_Ljava_util_List_Handler")]
		public virtual unsafe void GetCovs (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0)
		{
			if (id_getCovs_Ljava_util_List_ == IntPtr.Zero)
				id_getCovs_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getCovs", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCovs_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCovs", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetPredict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_Predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Predict2 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='predict2' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("predict2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D", "GetPredict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe double[] Predict2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "predict2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_predict2_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainE (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainE' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "GetTrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainE (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p5 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p6 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p6, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainE (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainE' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "GetTrainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainE (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6)
		{
			if (id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainE_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainE", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainEM_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainEM_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainEM_Lorg_opencv_core_Mat_ == null)
				cb_trainEM_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_TrainEM_Lorg_opencv_core_Mat_);
			return cb_trainEM_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainEM_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainEM (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainEM_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainEM' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("trainEM", "(Lorg/opencv/core/Mat;)Z", "GetTrainEM_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainEM (global::OpenCV.Core.Mat p0)
		{
			if (id_trainEM_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainEM_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainEM", "(Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainEM_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainEM", "(Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainEM (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainEM' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("trainEM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "GetTrainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainEM (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainEM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainEM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainEM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainM (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainM' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "GetTrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainM (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static bool n_TrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::OpenCV.ML.EM __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.EM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrainM (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='EM']/method[@name='trainM' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "GetTrainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool TrainM (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trainM_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trainM", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
