using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']"
	[global::Android.Runtime.Register ("org/opencv/ml/TrainData", DoNotGenerateAcw=true)]
	public partial class TrainData : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		protected long NativeObj {
			get {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId);
			}
			set {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/TrainData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrainData); }
		}

		protected TrainData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/constructor[@name='TrainData' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe TrainData (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TrainData)) {
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

		static Delegate cb_getCatMap;
#pragma warning disable 0169
		static Delegate GetGetCatMapHandler ()
		{
			if (cb_getCatMap == null)
				cb_getCatMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCatMap);
			return cb_getCatMap;
		}

		static IntPtr n_GetCatMap (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CatMap);
		}
#pragma warning restore 0169

		static IntPtr id_getCatMap;
		public virtual unsafe global::OpenCV.Core.Mat CatMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getCatMap' and count(parameter)=0]"
			[Register ("getCatMap", "()Lorg/opencv/core/Mat;", "GetGetCatMapHandler")]
			get {
				if (id_getCatMap == IntPtr.Zero)
					id_getCatMap = JNIEnv.GetMethodID (class_ref, "getCatMap", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCatMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCatMap", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCatOfs;
#pragma warning disable 0169
		static Delegate GetGetCatOfsHandler ()
		{
			if (cb_getCatOfs == null)
				cb_getCatOfs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCatOfs);
			return cb_getCatOfs;
		}

		static IntPtr n_GetCatOfs (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CatOfs);
		}
#pragma warning restore 0169

		static IntPtr id_getCatOfs;
		public virtual unsafe global::OpenCV.Core.Mat CatOfs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getCatOfs' and count(parameter)=0]"
			[Register ("getCatOfs", "()Lorg/opencv/core/Mat;", "GetGetCatOfsHandler")]
			get {
				if (id_getCatOfs == IntPtr.Zero)
					id_getCatOfs = JNIEnv.GetMethodID (class_ref, "getCatOfs", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCatOfs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCatOfs", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClassLabels;
#pragma warning disable 0169
		static Delegate GetGetClassLabelsHandler ()
		{
			if (cb_getClassLabels == null)
				cb_getClassLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassLabels);
			return cb_getClassLabels;
		}

		static IntPtr n_GetClassLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassLabels);
		}
#pragma warning restore 0169

		static IntPtr id_getClassLabels;
		public virtual unsafe global::OpenCV.Core.Mat ClassLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getClassLabels' and count(parameter)=0]"
			[Register ("getClassLabels", "()Lorg/opencv/core/Mat;", "GetGetClassLabelsHandler")]
			get {
				if (id_getClassLabels == IntPtr.Zero)
					id_getClassLabels = JNIEnv.GetMethodID (class_ref, "getClassLabels", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClassLabels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassLabels", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultSubstValues;
#pragma warning disable 0169
		static Delegate GetGetDefaultSubstValuesHandler ()
		{
			if (cb_getDefaultSubstValues == null)
				cb_getDefaultSubstValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultSubstValues);
			return cb_getDefaultSubstValues;
		}

		static IntPtr n_GetDefaultSubstValues (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSubstValues);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultSubstValues;
		public virtual unsafe global::OpenCV.Core.Mat DefaultSubstValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getDefaultSubstValues' and count(parameter)=0]"
			[Register ("getDefaultSubstValues", "()Lorg/opencv/core/Mat;", "GetGetDefaultSubstValuesHandler")]
			get {
				if (id_getDefaultSubstValues == IntPtr.Zero)
					id_getDefaultSubstValues = JNIEnv.GetMethodID (class_ref, "getDefaultSubstValues", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultSubstValues), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultSubstValues", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayout);
			return cb_getLayout;
		}

		static int n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		public virtual unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()I", "GetGetLayoutHandler")]
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayout", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMissing;
#pragma warning disable 0169
		static Delegate GetGetMissingHandler ()
		{
			if (cb_getMissing == null)
				cb_getMissing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMissing);
			return cb_getMissing;
		}

		static IntPtr n_GetMissing (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Missing);
		}
#pragma warning restore 0169

		static IntPtr id_getMissing;
		public virtual unsafe global::OpenCV.Core.Mat Missing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getMissing' and count(parameter)=0]"
			[Register ("getMissing", "()Lorg/opencv/core/Mat;", "GetGetMissingHandler")]
			get {
				if (id_getMissing == IntPtr.Zero)
					id_getMissing = JNIEnv.GetMethodID (class_ref, "getMissing", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMissing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMissing", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNAllVars;
#pragma warning disable 0169
		static Delegate GetGetNAllVarsHandler ()
		{
			if (cb_getNAllVars == null)
				cb_getNAllVars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNAllVars);
			return cb_getNAllVars;
		}

		static int n_GetNAllVars (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NAllVars;
		}
#pragma warning restore 0169

		static IntPtr id_getNAllVars;
		public virtual unsafe int NAllVars {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNAllVars' and count(parameter)=0]"
			[Register ("getNAllVars", "()I", "GetGetNAllVarsHandler")]
			get {
				if (id_getNAllVars == IntPtr.Zero)
					id_getNAllVars = JNIEnv.GetMethodID (class_ref, "getNAllVars", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNAllVars);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNAllVars", "()I"));
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
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NSamples;
		}
#pragma warning restore 0169

		static IntPtr id_getNSamples;
		public virtual unsafe int NSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNSamples' and count(parameter)=0]"
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
		}

		static Delegate cb_getNTestSamples;
#pragma warning disable 0169
		static Delegate GetGetNTestSamplesHandler ()
		{
			if (cb_getNTestSamples == null)
				cb_getNTestSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNTestSamples);
			return cb_getNTestSamples;
		}

		static int n_GetNTestSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NTestSamples;
		}
#pragma warning restore 0169

		static IntPtr id_getNTestSamples;
		public virtual unsafe int NTestSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNTestSamples' and count(parameter)=0]"
			[Register ("getNTestSamples", "()I", "GetGetNTestSamplesHandler")]
			get {
				if (id_getNTestSamples == IntPtr.Zero)
					id_getNTestSamples = JNIEnv.GetMethodID (class_ref, "getNTestSamples", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNTestSamples);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNTestSamples", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNTrainSamples;
#pragma warning disable 0169
		static Delegate GetGetNTrainSamplesHandler ()
		{
			if (cb_getNTrainSamples == null)
				cb_getNTrainSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNTrainSamples);
			return cb_getNTrainSamples;
		}

		static int n_GetNTrainSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NTrainSamples;
		}
#pragma warning restore 0169

		static IntPtr id_getNTrainSamples;
		public virtual unsafe int NTrainSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNTrainSamples' and count(parameter)=0]"
			[Register ("getNTrainSamples", "()I", "GetGetNTrainSamplesHandler")]
			get {
				if (id_getNTrainSamples == IntPtr.Zero)
					id_getNTrainSamples = JNIEnv.GetMethodID (class_ref, "getNTrainSamples", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNTrainSamples);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNTrainSamples", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNVars;
#pragma warning disable 0169
		static Delegate GetGetNVarsHandler ()
		{
			if (cb_getNVars == null)
				cb_getNVars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNVars);
			return cb_getNVars;
		}

		static int n_GetNVars (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NVars;
		}
#pragma warning restore 0169

		static IntPtr id_getNVars;
		public virtual unsafe int NVars {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNVars' and count(parameter)=0]"
			[Register ("getNVars", "()I", "GetGetNVarsHandler")]
			get {
				if (id_getNVars == IntPtr.Zero)
					id_getNVars = JNIEnv.GetMethodID (class_ref, "getNVars", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNVars);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNVars", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNormCatResponses;
#pragma warning disable 0169
		static Delegate GetGetNormCatResponsesHandler ()
		{
			if (cb_getNormCatResponses == null)
				cb_getNormCatResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNormCatResponses);
			return cb_getNormCatResponses;
		}

		static IntPtr n_GetNormCatResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormCatResponses);
		}
#pragma warning restore 0169

		static IntPtr id_getNormCatResponses;
		public virtual unsafe global::OpenCV.Core.Mat NormCatResponses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getNormCatResponses' and count(parameter)=0]"
			[Register ("getNormCatResponses", "()Lorg/opencv/core/Mat;", "GetGetNormCatResponsesHandler")]
			get {
				if (id_getNormCatResponses == IntPtr.Zero)
					id_getNormCatResponses = JNIEnv.GetMethodID (class_ref, "getNormCatResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNormCatResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNormCatResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponseType);
			return cb_getResponseType;
		}

		static int n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseType;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseType;
		public virtual unsafe int ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getResponseType' and count(parameter)=0]"
			[Register ("getResponseType", "()I", "GetGetResponseTypeHandler")]
			get {
				if (id_getResponseType == IntPtr.Zero)
					id_getResponseType = JNIEnv.GetMethodID (class_ref, "getResponseType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResponseType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getResponses;
#pragma warning disable 0169
		static Delegate GetGetResponsesHandler ()
		{
			if (cb_getResponses == null)
				cb_getResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponses);
			return cb_getResponses;
		}

		static IntPtr n_GetResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Responses);
		}
#pragma warning restore 0169

		static IntPtr id_getResponses;
		public virtual unsafe global::OpenCV.Core.Mat Responses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getResponses' and count(parameter)=0]"
			[Register ("getResponses", "()Lorg/opencv/core/Mat;", "GetGetResponsesHandler")]
			get {
				if (id_getResponses == IntPtr.Zero)
					id_getResponses = JNIEnv.GetMethodID (class_ref, "getResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSampleWeights;
#pragma warning disable 0169
		static Delegate GetGetSampleWeightsHandler ()
		{
			if (cb_getSampleWeights == null)
				cb_getSampleWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSampleWeights);
			return cb_getSampleWeights;
		}

		static IntPtr n_GetSampleWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SampleWeights);
		}
#pragma warning restore 0169

		static IntPtr id_getSampleWeights;
		public virtual unsafe global::OpenCV.Core.Mat SampleWeights {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getSampleWeights' and count(parameter)=0]"
			[Register ("getSampleWeights", "()Lorg/opencv/core/Mat;", "GetGetSampleWeightsHandler")]
			get {
				if (id_getSampleWeights == IntPtr.Zero)
					id_getSampleWeights = JNIEnv.GetMethodID (class_ref, "getSampleWeights", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSampleWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleWeights", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSamples;
#pragma warning disable 0169
		static Delegate GetGetSamplesHandler ()
		{
			if (cb_getSamples == null)
				cb_getSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSamples);
			return cb_getSamples;
		}

		static IntPtr n_GetSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Samples);
		}
#pragma warning restore 0169

		static IntPtr id_getSamples;
		public virtual unsafe global::OpenCV.Core.Mat Samples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getSamples' and count(parameter)=0]"
			[Register ("getSamples", "()Lorg/opencv/core/Mat;", "GetGetSamplesHandler")]
			get {
				if (id_getSamples == IntPtr.Zero)
					id_getSamples = JNIEnv.GetMethodID (class_ref, "getSamples", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSamples), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamples", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTestNormCatResponses;
#pragma warning disable 0169
		static Delegate GetGetTestNormCatResponsesHandler ()
		{
			if (cb_getTestNormCatResponses == null)
				cb_getTestNormCatResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestNormCatResponses);
			return cb_getTestNormCatResponses;
		}

		static IntPtr n_GetTestNormCatResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestNormCatResponses);
		}
#pragma warning restore 0169

		static IntPtr id_getTestNormCatResponses;
		public virtual unsafe global::OpenCV.Core.Mat TestNormCatResponses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTestNormCatResponses' and count(parameter)=0]"
			[Register ("getTestNormCatResponses", "()Lorg/opencv/core/Mat;", "GetGetTestNormCatResponsesHandler")]
			get {
				if (id_getTestNormCatResponses == IntPtr.Zero)
					id_getTestNormCatResponses = JNIEnv.GetMethodID (class_ref, "getTestNormCatResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTestNormCatResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestNormCatResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTestResponses;
#pragma warning disable 0169
		static Delegate GetGetTestResponsesHandler ()
		{
			if (cb_getTestResponses == null)
				cb_getTestResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestResponses);
			return cb_getTestResponses;
		}

		static IntPtr n_GetTestResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestResponses);
		}
#pragma warning restore 0169

		static IntPtr id_getTestResponses;
		public virtual unsafe global::OpenCV.Core.Mat TestResponses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTestResponses' and count(parameter)=0]"
			[Register ("getTestResponses", "()Lorg/opencv/core/Mat;", "GetGetTestResponsesHandler")]
			get {
				if (id_getTestResponses == IntPtr.Zero)
					id_getTestResponses = JNIEnv.GetMethodID (class_ref, "getTestResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTestResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTestSampleIdx;
#pragma warning disable 0169
		static Delegate GetGetTestSampleIdxHandler ()
		{
			if (cb_getTestSampleIdx == null)
				cb_getTestSampleIdx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestSampleIdx);
			return cb_getTestSampleIdx;
		}

		static IntPtr n_GetTestSampleIdx (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestSampleIdx);
		}
#pragma warning restore 0169

		static IntPtr id_getTestSampleIdx;
		public virtual unsafe global::OpenCV.Core.Mat TestSampleIdx {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTestSampleIdx' and count(parameter)=0]"
			[Register ("getTestSampleIdx", "()Lorg/opencv/core/Mat;", "GetGetTestSampleIdxHandler")]
			get {
				if (id_getTestSampleIdx == IntPtr.Zero)
					id_getTestSampleIdx = JNIEnv.GetMethodID (class_ref, "getTestSampleIdx", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTestSampleIdx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestSampleIdx", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTestSampleWeights;
#pragma warning disable 0169
		static Delegate GetGetTestSampleWeightsHandler ()
		{
			if (cb_getTestSampleWeights == null)
				cb_getTestSampleWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTestSampleWeights);
			return cb_getTestSampleWeights;
		}

		static IntPtr n_GetTestSampleWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TestSampleWeights);
		}
#pragma warning restore 0169

		static IntPtr id_getTestSampleWeights;
		public virtual unsafe global::OpenCV.Core.Mat TestSampleWeights {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTestSampleWeights' and count(parameter)=0]"
			[Register ("getTestSampleWeights", "()Lorg/opencv/core/Mat;", "GetGetTestSampleWeightsHandler")]
			get {
				if (id_getTestSampleWeights == IntPtr.Zero)
					id_getTestSampleWeights = JNIEnv.GetMethodID (class_ref, "getTestSampleWeights", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTestSampleWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestSampleWeights", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainNormCatResponses;
#pragma warning disable 0169
		static Delegate GetGetTrainNormCatResponsesHandler ()
		{
			if (cb_getTrainNormCatResponses == null)
				cb_getTrainNormCatResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainNormCatResponses);
			return cb_getTrainNormCatResponses;
		}

		static IntPtr n_GetTrainNormCatResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainNormCatResponses);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainNormCatResponses;
		public virtual unsafe global::OpenCV.Core.Mat TrainNormCatResponses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainNormCatResponses' and count(parameter)=0]"
			[Register ("getTrainNormCatResponses", "()Lorg/opencv/core/Mat;", "GetGetTrainNormCatResponsesHandler")]
			get {
				if (id_getTrainNormCatResponses == IntPtr.Zero)
					id_getTrainNormCatResponses = JNIEnv.GetMethodID (class_ref, "getTrainNormCatResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainNormCatResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainNormCatResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainResponses;
#pragma warning disable 0169
		static Delegate GetGetTrainResponsesHandler ()
		{
			if (cb_getTrainResponses == null)
				cb_getTrainResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainResponses);
			return cb_getTrainResponses;
		}

		static IntPtr n_GetTrainResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainResponses);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainResponses;
		public virtual unsafe global::OpenCV.Core.Mat TrainResponses {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainResponses' and count(parameter)=0]"
			[Register ("getTrainResponses", "()Lorg/opencv/core/Mat;", "GetGetTrainResponsesHandler")]
			get {
				if (id_getTrainResponses == IntPtr.Zero)
					id_getTrainResponses = JNIEnv.GetMethodID (class_ref, "getTrainResponses", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainResponses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainResponses", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainSampleIdx;
#pragma warning disable 0169
		static Delegate GetGetTrainSampleIdxHandler ()
		{
			if (cb_getTrainSampleIdx == null)
				cb_getTrainSampleIdx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainSampleIdx);
			return cb_getTrainSampleIdx;
		}

		static IntPtr n_GetTrainSampleIdx (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainSampleIdx);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainSampleIdx;
		public virtual unsafe global::OpenCV.Core.Mat TrainSampleIdx {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainSampleIdx' and count(parameter)=0]"
			[Register ("getTrainSampleIdx", "()Lorg/opencv/core/Mat;", "GetGetTrainSampleIdxHandler")]
			get {
				if (id_getTrainSampleIdx == IntPtr.Zero)
					id_getTrainSampleIdx = JNIEnv.GetMethodID (class_ref, "getTrainSampleIdx", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainSampleIdx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainSampleIdx", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainSampleWeights;
#pragma warning disable 0169
		static Delegate GetGetTrainSampleWeightsHandler ()
		{
			if (cb_getTrainSampleWeights == null)
				cb_getTrainSampleWeights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainSampleWeights);
			return cb_getTrainSampleWeights;
		}

		static IntPtr n_GetTrainSampleWeights (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainSampleWeights);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainSampleWeights;
		public virtual unsafe global::OpenCV.Core.Mat TrainSampleWeights {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainSampleWeights' and count(parameter)=0]"
			[Register ("getTrainSampleWeights", "()Lorg/opencv/core/Mat;", "GetGetTrainSampleWeightsHandler")]
			get {
				if (id_getTrainSampleWeights == IntPtr.Zero)
					id_getTrainSampleWeights = JNIEnv.GetMethodID (class_ref, "getTrainSampleWeights", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainSampleWeights), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainSampleWeights", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrainSamples;
#pragma warning disable 0169
		static Delegate GetGetTrainSamplesHandler ()
		{
			if (cb_getTrainSamples == null)
				cb_getTrainSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainSamples);
			return cb_getTrainSamples;
		}

		static IntPtr n_GetTrainSamples (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrainSamples);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainSamples;
		public virtual unsafe global::OpenCV.Core.Mat TrainSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainSamples' and count(parameter)=0]"
			[Register ("getTrainSamples", "()Lorg/opencv/core/Mat;", "GetGetTrainSamplesHandler")]
			get {
				if (id_getTrainSamples == IntPtr.Zero)
					id_getTrainSamples = JNIEnv.GetMethodID (class_ref, "getTrainSamples", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainSamples), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainSamples", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVarIdx;
#pragma warning disable 0169
		static Delegate GetGetVarIdxHandler ()
		{
			if (cb_getVarIdx == null)
				cb_getVarIdx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVarIdx);
			return cb_getVarIdx;
		}

		static IntPtr n_GetVarIdx (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VarIdx);
		}
#pragma warning restore 0169

		static IntPtr id_getVarIdx;
		public virtual unsafe global::OpenCV.Core.Mat VarIdx {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getVarIdx' and count(parameter)=0]"
			[Register ("getVarIdx", "()Lorg/opencv/core/Mat;", "GetGetVarIdxHandler")]
			get {
				if (id_getVarIdx == IntPtr.Zero)
					id_getVarIdx = JNIEnv.GetMethodID (class_ref, "getVarIdx", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVarIdx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarIdx", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVarType;
#pragma warning disable 0169
		static Delegate GetGetVarTypeHandler ()
		{
			if (cb_getVarType == null)
				cb_getVarType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVarType);
			return cb_getVarType;
		}

		static IntPtr n_GetVarType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VarType);
		}
#pragma warning restore 0169

		static IntPtr id_getVarType;
		public virtual unsafe global::OpenCV.Core.Mat VarType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getVarType' and count(parameter)=0]"
			[Register ("getVarType", "()Lorg/opencv/core/Mat;", "GetGetVarTypeHandler")]
			get {
				if (id_getVarType == IntPtr.Zero)
					id_getVarType = JNIEnv.GetMethodID (class_ref, "getVarType", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVarType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarType", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCatCount_I;
#pragma warning disable 0169
		static Delegate GetGetCatCount_IHandler ()
		{
			if (cb_getCatCount_I == null)
				cb_getCatCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetCatCount_I);
			return cb_getCatCount_I;
		}

		static int n_GetCatCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCatCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getCatCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getCatCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCatCount", "(I)I", "GetGetCatCount_IHandler")]
		public virtual unsafe int GetCatCount (int p0)
		{
			if (id_getCatCount_I == IntPtr.Zero)
				id_getCatCount_I = JNIEnv.GetMethodID (class_ref, "getCatCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCatCount_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCatCount", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getSample_Lorg_opencv_core_Mat_IF;
#pragma warning disable 0169
		static Delegate GetGetSample_Lorg_opencv_core_Mat_IFHandler ()
		{
			if (cb_getSample_Lorg_opencv_core_Mat_IF == null)
				cb_getSample_Lorg_opencv_core_Mat_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, float>) n_GetSample_Lorg_opencv_core_Mat_IF);
			return cb_getSample_Lorg_opencv_core_Mat_IF;
		}

		static void n_GetSample_Lorg_opencv_core_Mat_IF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetSample (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getSample_Lorg_opencv_core_Mat_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getSample' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("getSample", "(Lorg/opencv/core/Mat;IF)V", "GetGetSample_Lorg_opencv_core_Mat_IFHandler")]
		public virtual unsafe void GetSample (global::OpenCV.Core.Mat p0, int p1, float p2)
		{
			if (id_getSample_Lorg_opencv_core_Mat_IF == IntPtr.Zero)
				id_getSample_Lorg_opencv_core_Mat_IF = JNIEnv.GetMethodID (class_ref, "getSample", "(Lorg/opencv/core/Mat;IF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getSample_Lorg_opencv_core_Mat_IF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSample", "(Lorg/opencv/core/Mat;IF)V"), __args);
			} finally {
			}
		}

		static IntPtr id_getSubVector_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getSubVector' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("getSubVector", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetSubVector (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_getSubVector_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_getSubVector_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "getSubVector", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubVector_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTrainSamples_IZZ;
#pragma warning disable 0169
		static Delegate GetGetTrainSamples_IZZHandler ()
		{
			if (cb_getTrainSamples_IZZ == null)
				cb_getTrainSamples_IZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool, IntPtr>) n_GetTrainSamples_IZZ);
			return cb_getTrainSamples_IZZ;
		}

		static IntPtr n_GetTrainSamples_IZZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1, bool p2)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTrainSamples (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getTrainSamples_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getTrainSamples' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("getTrainSamples", "(IZZ)Lorg/opencv/core/Mat;", "GetGetTrainSamples_IZZHandler")]
		public virtual unsafe global::OpenCV.Core.Mat GetTrainSamples (int p0, bool p1, bool p2)
		{
			if (id_getTrainSamples_IZZ == IntPtr.Zero)
				id_getTrainSamples_IZZ = JNIEnv.GetMethodID (class_ref, "getTrainSamples", "(IZZ)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainSamples_IZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainSamples", "(IZZ)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getValues_ILorg_opencv_core_Mat_F;
#pragma warning disable 0169
		static Delegate GetGetValues_ILorg_opencv_core_Mat_FHandler ()
		{
			if (cb_getValues_ILorg_opencv_core_Mat_F == null)
				cb_getValues_ILorg_opencv_core_Mat_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, float>) n_GetValues_ILorg_opencv_core_Mat_F);
			return cb_getValues_ILorg_opencv_core_Mat_F;
		}

		static void n_GetValues_ILorg_opencv_core_Mat_F (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, float p2)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetValues (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getValues_ILorg_opencv_core_Mat_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='getValues' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='float']]"
		[Register ("getValues", "(ILorg/opencv/core/Mat;F)V", "GetGetValues_ILorg_opencv_core_Mat_FHandler")]
		public virtual unsafe void GetValues (int p0, global::OpenCV.Core.Mat p1, float p2)
		{
			if (id_getValues_ILorg_opencv_core_Mat_F == IntPtr.Zero)
				id_getValues_ILorg_opencv_core_Mat_F = JNIEnv.GetMethodID (class_ref, "getValues", "(ILorg/opencv/core/Mat;F)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getValues_ILorg_opencv_core_Mat_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "(ILorg/opencv/core/Mat;F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrainTestSplit_I;
#pragma warning disable 0169
		static Delegate GetSetTrainTestSplit_IHandler ()
		{
			if (cb_setTrainTestSplit_I == null)
				cb_setTrainTestSplit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrainTestSplit_I);
			return cb_setTrainTestSplit_I;
		}

		static void n_SetTrainTestSplit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrainTestSplit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrainTestSplit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='setTrainTestSplit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTrainTestSplit", "(I)V", "GetSetTrainTestSplit_IHandler")]
		public virtual unsafe void SetTrainTestSplit (int p0)
		{
			if (id_setTrainTestSplit_I == IntPtr.Zero)
				id_setTrainTestSplit_I = JNIEnv.GetMethodID (class_ref, "setTrainTestSplit", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainTestSplit_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainTestSplit", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrainTestSplit_IZ;
#pragma warning disable 0169
		static Delegate GetSetTrainTestSplit_IZHandler ()
		{
			if (cb_setTrainTestSplit_IZ == null)
				cb_setTrainTestSplit_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetTrainTestSplit_IZ);
			return cb_setTrainTestSplit_IZ;
		}

		static void n_SetTrainTestSplit_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrainTestSplit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTrainTestSplit_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='setTrainTestSplit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setTrainTestSplit", "(IZ)V", "GetSetTrainTestSplit_IZHandler")]
		public virtual unsafe void SetTrainTestSplit (int p0, bool p1)
		{
			if (id_setTrainTestSplit_IZ == IntPtr.Zero)
				id_setTrainTestSplit_IZ = JNIEnv.GetMethodID (class_ref, "setTrainTestSplit", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainTestSplit_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainTestSplit", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrainTestSplitRatio_D;
#pragma warning disable 0169
		static Delegate GetSetTrainTestSplitRatio_DHandler ()
		{
			if (cb_setTrainTestSplitRatio_D == null)
				cb_setTrainTestSplitRatio_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetTrainTestSplitRatio_D);
			return cb_setTrainTestSplitRatio_D;
		}

		static void n_SetTrainTestSplitRatio_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrainTestSplitRatio (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrainTestSplitRatio_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='setTrainTestSplitRatio' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setTrainTestSplitRatio", "(D)V", "GetSetTrainTestSplitRatio_DHandler")]
		public virtual unsafe void SetTrainTestSplitRatio (double p0)
		{
			if (id_setTrainTestSplitRatio_D == IntPtr.Zero)
				id_setTrainTestSplitRatio_D = JNIEnv.GetMethodID (class_ref, "setTrainTestSplitRatio", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainTestSplitRatio_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainTestSplitRatio", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrainTestSplitRatio_DZ;
#pragma warning disable 0169
		static Delegate GetSetTrainTestSplitRatio_DZHandler ()
		{
			if (cb_setTrainTestSplitRatio_DZ == null)
				cb_setTrainTestSplitRatio_DZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, bool>) n_SetTrainTestSplitRatio_DZ);
			return cb_setTrainTestSplitRatio_DZ;
		}

		static void n_SetTrainTestSplitRatio_DZ (IntPtr jnienv, IntPtr native__this, double p0, bool p1)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrainTestSplitRatio (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTrainTestSplitRatio_DZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='setTrainTestSplitRatio' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='boolean']]"
		[Register ("setTrainTestSplitRatio", "(DZ)V", "GetSetTrainTestSplitRatio_DZHandler")]
		public virtual unsafe void SetTrainTestSplitRatio (double p0, bool p1)
		{
			if (id_setTrainTestSplitRatio_DZ == IntPtr.Zero)
				id_setTrainTestSplitRatio_DZ = JNIEnv.GetMethodID (class_ref, "setTrainTestSplitRatio", "(DZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrainTestSplitRatio_DZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrainTestSplitRatio", "(DZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shuffleTrainTest;
#pragma warning disable 0169
		static Delegate GetShuffleTrainTestHandler ()
		{
			if (cb_shuffleTrainTest == null)
				cb_shuffleTrainTest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShuffleTrainTest);
			return cb_shuffleTrainTest;
		}

		static void n_ShuffleTrainTest (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.TrainData __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.TrainData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShuffleTrainTest ();
		}
#pragma warning restore 0169

		static IntPtr id_shuffleTrainTest;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='TrainData']/method[@name='shuffleTrainTest' and count(parameter)=0]"
		[Register ("shuffleTrainTest", "()V", "GetShuffleTrainTestHandler")]
		public virtual unsafe void ShuffleTrainTest ()
		{
			if (id_shuffleTrainTest == IntPtr.Zero)
				id_shuffleTrainTest = JNIEnv.GetMethodID (class_ref, "shuffleTrainTest", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shuffleTrainTest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shuffleTrainTest", "()V"));
			} finally {
			}
		}

	}
}
