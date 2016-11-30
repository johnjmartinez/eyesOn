using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']"
	[global::Android.Runtime.Register ("org/opencv/ml/StatModel", DoNotGenerateAcw=true)]
	public partial class StatModel : global::OpenCV.Core.Algorithm {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/field[@name='COMPRESSED_INPUT']"
		[Register ("COMPRESSED_INPUT")]
		public const int CompressedInput = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/field[@name='PREPROCESSED_INPUT']"
		[Register ("PREPROCESSED_INPUT")]
		public const int PreprocessedInput = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/field[@name='RAW_OUTPUT']"
		[Register ("RAW_OUTPUT")]
		public const int RawOutput = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/field[@name='UPDATE_MODEL']"
		[Register ("UPDATE_MODEL")]
		public const int UpdateModel = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/StatModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatModel); }
		}

		protected StatModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/constructor[@name='StatModel' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe StatModel (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StatModel)) {
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

		static Delegate cb_isClassifier;
#pragma warning disable 0169
		static Delegate GetIsClassifierHandler ()
		{
			if (cb_isClassifier == null)
				cb_isClassifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClassifier);
			return cb_isClassifier;
		}

		static bool n_IsClassifier (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClassifier;
		}
#pragma warning restore 0169

		static IntPtr id_isClassifier;
		public virtual unsafe bool IsClassifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='isClassifier' and count(parameter)=0]"
			[Register ("isClassifier", "()Z", "GetIsClassifierHandler")]
			get {
				if (id_isClassifier == IntPtr.Zero)
					id_isClassifier = JNIEnv.GetMethodID (class_ref, "isClassifier", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClassifier);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClassifier", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTrained;
#pragma warning disable 0169
		static Delegate GetIsTrainedHandler ()
		{
			if (cb_isTrained == null)
				cb_isTrained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrained);
			return cb_isTrained;
		}

		static bool n_IsTrained (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTrained;
		}
#pragma warning restore 0169

		static IntPtr id_isTrained;
		public virtual unsafe bool IsTrained {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='isTrained' and count(parameter)=0]"
			[Register ("isTrained", "()Z", "GetIsTrainedHandler")]
			get {
				if (id_isTrained == IntPtr.Zero)
					id_isTrained = JNIEnv.GetMethodID (class_ref, "isTrained", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTrained);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTrained", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getVarCount;
#pragma warning disable 0169
		static Delegate GetGetVarCountHandler ()
		{
			if (cb_getVarCount == null)
				cb_getVarCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVarCount);
			return cb_getVarCount;
		}

		static int n_GetVarCount (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VarCount;
		}
#pragma warning restore 0169

		static IntPtr id_getVarCount;
		public virtual unsafe int VarCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='getVarCount' and count(parameter)=0]"
			[Register ("getVarCount", "()I", "GetGetVarCountHandler")]
			get {
				if (id_getVarCount == IntPtr.Zero)
					id_getVarCount = JNIEnv.GetMethodID (class_ref, "getVarCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVarCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVarCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetMethodID (class_ref, "empty", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_empty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "empty", "()Z"));
			} finally {
			}
		}

		static Delegate cb_predict_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetPredict_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_predict_Lorg_opencv_core_Mat_ == null)
				cb_predict_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_Predict_Lorg_opencv_core_Mat_);
			return cb_predict_Lorg_opencv_core_Mat_;
		}

		static float n_Predict_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.Predict (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_predict_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='predict' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("predict", "(Lorg/opencv/core/Mat;)F", "GetPredict_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe float Predict (global::OpenCV.Core.Mat p0)
		{
			if (id_predict_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_predict_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "predict", "(Lorg/opencv/core/Mat;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_predict_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "(Lorg/opencv/core/Mat;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
#pragma warning disable 0169
		static Delegate GetPredict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IHandler ()
		{
			if (cb_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == null)
				cb_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, float>) n_Predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I);
			return cb_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		}

		static float n_Predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.Predict (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='predict' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int']]"
		[Register ("predict", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)F", "GetPredict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IHandler")]
		public virtual unsafe float Predict (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2)
		{
			if (id_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetMethodID (class_ref, "predict", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_predict_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetTrain_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Handler ()
		{
			if (cb_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == null)
				cb_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_Train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_);
			return cb_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		}

		static bool n_Train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.ML.StatModel __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.StatModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Train (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='StatModel']/method[@name='train' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("train", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)Z", "GetTrain_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool Train (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2)
		{
			if (id_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "train", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_train_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "train", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
