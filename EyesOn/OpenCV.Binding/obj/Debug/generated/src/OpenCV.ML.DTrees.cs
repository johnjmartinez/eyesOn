using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']"
	[global::Android.Runtime.Register ("org/opencv/ml/DTrees", DoNotGenerateAcw=true)]
	public partial class DTrees : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/field[@name='PREDICT_AUTO']"
		[Register ("PREDICT_AUTO")]
		public const int PredictAuto = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/field[@name='PREDICT_MASK']"
		[Register ("PREDICT_MASK")]
		public const int PredictMask = (int) 768;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/field[@name='PREDICT_MAX_VOTE']"
		[Register ("PREDICT_MAX_VOTE")]
		public const int PredictMaxVote = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/field[@name='PREDICT_SUM']"
		[Register ("PREDICT_SUM")]
		public const int PredictSum = (int) 256;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/DTrees", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DTrees); }
		}

		protected DTrees (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/constructor[@name='DTrees' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe DTrees (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DTrees)) {
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

		static Delegate cb_getCVFolds;
#pragma warning disable 0169
		static Delegate GetGetCVFoldsHandler ()
		{
			if (cb_getCVFolds == null)
				cb_getCVFolds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCVFolds);
			return cb_getCVFolds;
		}

		static int n_GetCVFolds (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CVFolds;
		}
#pragma warning restore 0169

		static Delegate cb_setCVFolds_I;
#pragma warning disable 0169
		static Delegate GetSetCVFolds_IHandler ()
		{
			if (cb_setCVFolds_I == null)
				cb_setCVFolds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCVFolds_I);
			return cb_setCVFolds_I;
		}

		static void n_SetCVFolds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CVFolds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCVFolds;
		static IntPtr id_setCVFolds_I;
		public virtual unsafe int CVFolds {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getCVFolds' and count(parameter)=0]"
			[Register ("getCVFolds", "()I", "GetGetCVFoldsHandler")]
			get {
				if (id_getCVFolds == IntPtr.Zero)
					id_getCVFolds = JNIEnv.GetMethodID (class_ref, "getCVFolds", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCVFolds);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCVFolds", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setCVFolds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCVFolds", "(I)V", "GetSetCVFolds_IHandler")]
			set {
				if (id_setCVFolds_I == IntPtr.Zero)
					id_setCVFolds_I = JNIEnv.GetMethodID (class_ref, "setCVFolds", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCVFolds_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCVFolds", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxCategories;
#pragma warning disable 0169
		static Delegate GetGetMaxCategoriesHandler ()
		{
			if (cb_getMaxCategories == null)
				cb_getMaxCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxCategories);
			return cb_getMaxCategories;
		}

		static int n_GetMaxCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCategories;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxCategories_I;
#pragma warning disable 0169
		static Delegate GetSetMaxCategories_IHandler ()
		{
			if (cb_setMaxCategories_I == null)
				cb_setMaxCategories_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxCategories_I);
			return cb_setMaxCategories_I;
		}

		static void n_SetMaxCategories_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCategories = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCategories;
		static IntPtr id_setMaxCategories_I;
		public virtual unsafe int MaxCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getMaxCategories' and count(parameter)=0]"
			[Register ("getMaxCategories", "()I", "GetGetMaxCategoriesHandler")]
			get {
				if (id_getMaxCategories == IntPtr.Zero)
					id_getMaxCategories = JNIEnv.GetMethodID (class_ref, "getMaxCategories", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxCategories);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCategories", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setMaxCategories' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxCategories", "(I)V", "GetSetMaxCategories_IHandler")]
			set {
				if (id_setMaxCategories_I == IntPtr.Zero)
					id_setMaxCategories_I = JNIEnv.GetMethodID (class_ref, "setMaxCategories", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxCategories_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCategories", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxDepth;
#pragma warning disable 0169
		static Delegate GetGetMaxDepthHandler ()
		{
			if (cb_getMaxDepth == null)
				cb_getMaxDepth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxDepth);
			return cb_getMaxDepth;
		}

		static int n_GetMaxDepth (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDepth;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxDepth_I;
#pragma warning disable 0169
		static Delegate GetSetMaxDepth_IHandler ()
		{
			if (cb_setMaxDepth_I == null)
				cb_setMaxDepth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxDepth_I);
			return cb_setMaxDepth_I;
		}

		static void n_SetMaxDepth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxDepth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxDepth;
		static IntPtr id_setMaxDepth_I;
		public virtual unsafe int MaxDepth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getMaxDepth' and count(parameter)=0]"
			[Register ("getMaxDepth", "()I", "GetGetMaxDepthHandler")]
			get {
				if (id_getMaxDepth == IntPtr.Zero)
					id_getMaxDepth = JNIEnv.GetMethodID (class_ref, "getMaxDepth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDepth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxDepth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setMaxDepth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxDepth", "(I)V", "GetSetMaxDepth_IHandler")]
			set {
				if (id_setMaxDepth_I == IntPtr.Zero)
					id_setMaxDepth_I = JNIEnv.GetMethodID (class_ref, "setMaxDepth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxDepth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxDepth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinSampleCount;
#pragma warning disable 0169
		static Delegate GetGetMinSampleCountHandler ()
		{
			if (cb_getMinSampleCount == null)
				cb_getMinSampleCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinSampleCount);
			return cb_getMinSampleCount;
		}

		static int n_GetMinSampleCount (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinSampleCount;
		}
#pragma warning restore 0169

		static Delegate cb_setMinSampleCount_I;
#pragma warning disable 0169
		static Delegate GetSetMinSampleCount_IHandler ()
		{
			if (cb_setMinSampleCount_I == null)
				cb_setMinSampleCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinSampleCount_I);
			return cb_setMinSampleCount_I;
		}

		static void n_SetMinSampleCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinSampleCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinSampleCount;
		static IntPtr id_setMinSampleCount_I;
		public virtual unsafe int MinSampleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getMinSampleCount' and count(parameter)=0]"
			[Register ("getMinSampleCount", "()I", "GetGetMinSampleCountHandler")]
			get {
				if (id_getMinSampleCount == IntPtr.Zero)
					id_getMinSampleCount = JNIEnv.GetMethodID (class_ref, "getMinSampleCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinSampleCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinSampleCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setMinSampleCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinSampleCount", "(I)V", "GetSetMinSampleCount_IHandler")]
			set {
				if (id_setMinSampleCount_I == IntPtr.Zero)
					id_setMinSampleCount_I = JNIEnv.GetMethodID (class_ref, "setMinSampleCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinSampleCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinSampleCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPriors;
#pragma warning disable 0169
		static Delegate GetGetPriorsHandler ()
		{
			if (cb_getPriors == null)
				cb_getPriors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriors);
			return cb_getPriors;
		}

		static IntPtr n_GetPriors (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Priors);
		}
#pragma warning restore 0169

		static Delegate cb_setPriors_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetPriors_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setPriors_Lorg_opencv_core_Mat_ == null)
				cb_setPriors_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPriors_Lorg_opencv_core_Mat_);
			return cb_setPriors_Lorg_opencv_core_Mat_;
		}

		static void n_SetPriors_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Priors = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPriors;
		static IntPtr id_setPriors_Lorg_opencv_core_Mat_;
		public virtual unsafe global::OpenCV.Core.Mat Priors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getPriors' and count(parameter)=0]"
			[Register ("getPriors", "()Lorg/opencv/core/Mat;", "GetGetPriorsHandler")]
			get {
				if (id_getPriors == IntPtr.Zero)
					id_getPriors = JNIEnv.GetMethodID (class_ref, "getPriors", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPriors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPriors", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setPriors' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
			[Register ("setPriors", "(Lorg/opencv/core/Mat;)V", "GetSetPriors_Lorg_opencv_core_Mat_Handler")]
			set {
				if (id_setPriors_Lorg_opencv_core_Mat_ == IntPtr.Zero)
					id_setPriors_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setPriors", "(Lorg/opencv/core/Mat;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPriors_Lorg_opencv_core_Mat_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPriors", "(Lorg/opencv/core/Mat;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRegressionAccuracy;
#pragma warning disable 0169
		static Delegate GetGetRegressionAccuracyHandler ()
		{
			if (cb_getRegressionAccuracy == null)
				cb_getRegressionAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRegressionAccuracy);
			return cb_getRegressionAccuracy;
		}

		static float n_GetRegressionAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegressionAccuracy;
		}
#pragma warning restore 0169

		static Delegate cb_setRegressionAccuracy_F;
#pragma warning disable 0169
		static Delegate GetSetRegressionAccuracy_FHandler ()
		{
			if (cb_setRegressionAccuracy_F == null)
				cb_setRegressionAccuracy_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRegressionAccuracy_F);
			return cb_setRegressionAccuracy_F;
		}

		static void n_SetRegressionAccuracy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegressionAccuracy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegressionAccuracy;
		static IntPtr id_setRegressionAccuracy_F;
		public virtual unsafe float RegressionAccuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getRegressionAccuracy' and count(parameter)=0]"
			[Register ("getRegressionAccuracy", "()F", "GetGetRegressionAccuracyHandler")]
			get {
				if (id_getRegressionAccuracy == IntPtr.Zero)
					id_getRegressionAccuracy = JNIEnv.GetMethodID (class_ref, "getRegressionAccuracy", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRegressionAccuracy);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegressionAccuracy", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setRegressionAccuracy' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRegressionAccuracy", "(F)V", "GetSetRegressionAccuracy_FHandler")]
			set {
				if (id_setRegressionAccuracy_F == IntPtr.Zero)
					id_setRegressionAccuracy_F = JNIEnv.GetMethodID (class_ref, "setRegressionAccuracy", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegressionAccuracy_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegressionAccuracy", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTruncatePrunedTree;
#pragma warning disable 0169
		static Delegate GetGetTruncatePrunedTreeHandler ()
		{
			if (cb_getTruncatePrunedTree == null)
				cb_getTruncatePrunedTree = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTruncatePrunedTree);
			return cb_getTruncatePrunedTree;
		}

		static bool n_GetTruncatePrunedTree (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TruncatePrunedTree;
		}
#pragma warning restore 0169

		static Delegate cb_setTruncatePrunedTree_Z;
#pragma warning disable 0169
		static Delegate GetSetTruncatePrunedTree_ZHandler ()
		{
			if (cb_setTruncatePrunedTree_Z == null)
				cb_setTruncatePrunedTree_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTruncatePrunedTree_Z);
			return cb_setTruncatePrunedTree_Z;
		}

		static void n_SetTruncatePrunedTree_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TruncatePrunedTree = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTruncatePrunedTree;
		static IntPtr id_setTruncatePrunedTree_Z;
		public virtual unsafe bool TruncatePrunedTree {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getTruncatePrunedTree' and count(parameter)=0]"
			[Register ("getTruncatePrunedTree", "()Z", "GetGetTruncatePrunedTreeHandler")]
			get {
				if (id_getTruncatePrunedTree == IntPtr.Zero)
					id_getTruncatePrunedTree = JNIEnv.GetMethodID (class_ref, "getTruncatePrunedTree", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getTruncatePrunedTree);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTruncatePrunedTree", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setTruncatePrunedTree' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTruncatePrunedTree", "(Z)V", "GetSetTruncatePrunedTree_ZHandler")]
			set {
				if (id_setTruncatePrunedTree_Z == IntPtr.Zero)
					id_setTruncatePrunedTree_Z = JNIEnv.GetMethodID (class_ref, "setTruncatePrunedTree", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTruncatePrunedTree_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTruncatePrunedTree", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUse1SERule;
#pragma warning disable 0169
		static Delegate GetGetUse1SERuleHandler ()
		{
			if (cb_getUse1SERule == null)
				cb_getUse1SERule = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUse1SERule);
			return cb_getUse1SERule;
		}

		static bool n_GetUse1SERule (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Use1SERule;
		}
#pragma warning restore 0169

		static Delegate cb_setUse1SERule_Z;
#pragma warning disable 0169
		static Delegate GetSetUse1SERule_ZHandler ()
		{
			if (cb_setUse1SERule_Z == null)
				cb_setUse1SERule_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUse1SERule_Z);
			return cb_setUse1SERule_Z;
		}

		static void n_SetUse1SERule_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Use1SERule = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUse1SERule;
		static IntPtr id_setUse1SERule_Z;
		public virtual unsafe bool Use1SERule {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getUse1SERule' and count(parameter)=0]"
			[Register ("getUse1SERule", "()Z", "GetGetUse1SERuleHandler")]
			get {
				if (id_getUse1SERule == IntPtr.Zero)
					id_getUse1SERule = JNIEnv.GetMethodID (class_ref, "getUse1SERule", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUse1SERule);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUse1SERule", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setUse1SERule' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUse1SERule", "(Z)V", "GetSetUse1SERule_ZHandler")]
			set {
				if (id_setUse1SERule_Z == IntPtr.Zero)
					id_setUse1SERule_Z = JNIEnv.GetMethodID (class_ref, "setUse1SERule", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUse1SERule_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUse1SERule", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUseSurrogates;
#pragma warning disable 0169
		static Delegate GetGetUseSurrogatesHandler ()
		{
			if (cb_getUseSurrogates == null)
				cb_getUseSurrogates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUseSurrogates);
			return cb_getUseSurrogates;
		}

		static bool n_GetUseSurrogates (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSurrogates;
		}
#pragma warning restore 0169

		static Delegate cb_setUseSurrogates_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSurrogates_ZHandler ()
		{
			if (cb_setUseSurrogates_Z == null)
				cb_setUseSurrogates_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseSurrogates_Z);
			return cb_setUseSurrogates_Z;
		}

		static void n_SetUseSurrogates_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.ML.DTrees __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseSurrogates = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUseSurrogates;
		static IntPtr id_setUseSurrogates_Z;
		public virtual unsafe bool UseSurrogates {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='getUseSurrogates' and count(parameter)=0]"
			[Register ("getUseSurrogates", "()Z", "GetGetUseSurrogatesHandler")]
			get {
				if (id_getUseSurrogates == IntPtr.Zero)
					id_getUseSurrogates = JNIEnv.GetMethodID (class_ref, "getUseSurrogates", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUseSurrogates);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUseSurrogates", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='setUseSurrogates' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseSurrogates", "(Z)V", "GetSetUseSurrogates_ZHandler")]
			set {
				if (id_setUseSurrogates_Z == IntPtr.Zero)
					id_setUseSurrogates_Z = JNIEnv.GetMethodID (class_ref, "setUseSurrogates", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseSurrogates_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseSurrogates", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='DTrees']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/DTrees;", "")]
		public static unsafe global::OpenCV.ML.DTrees Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/DTrees;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.DTrees> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
