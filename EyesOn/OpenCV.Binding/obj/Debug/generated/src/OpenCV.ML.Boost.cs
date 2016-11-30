using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']"
	[global::Android.Runtime.Register ("org/opencv/ml/Boost", DoNotGenerateAcw=true)]
	public partial class Boost : global::OpenCV.ML.DTrees {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/field[@name='DISCRETE']"
		[Register ("DISCRETE")]
		public const int Discrete = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/field[@name='GENTLE']"
		[Register ("GENTLE")]
		public const int Gentle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/field[@name='LOGIT']"
		[Register ("LOGIT")]
		public const int Logit = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/field[@name='REAL']"
		[Register ("REAL")]
		public const int Real = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/Boost", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Boost); }
		}

		protected Boost (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/constructor[@name='Boost' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Boost (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Boost)) {
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

		static Delegate cb_getBoostType;
#pragma warning disable 0169
		static Delegate GetGetBoostTypeHandler ()
		{
			if (cb_getBoostType == null)
				cb_getBoostType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBoostType);
			return cb_getBoostType;
		}

		static int n_GetBoostType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BoostType;
		}
#pragma warning restore 0169

		static Delegate cb_setBoostType_I;
#pragma warning disable 0169
		static Delegate GetSetBoostType_IHandler ()
		{
			if (cb_setBoostType_I == null)
				cb_setBoostType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBoostType_I);
			return cb_setBoostType_I;
		}

		static void n_SetBoostType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BoostType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBoostType;
		static IntPtr id_setBoostType_I;
		public virtual unsafe int BoostType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='getBoostType' and count(parameter)=0]"
			[Register ("getBoostType", "()I", "GetGetBoostTypeHandler")]
			get {
				if (id_getBoostType == IntPtr.Zero)
					id_getBoostType = JNIEnv.GetMethodID (class_ref, "getBoostType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBoostType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoostType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='setBoostType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBoostType", "(I)V", "GetSetBoostType_IHandler")]
			set {
				if (id_setBoostType_I == IntPtr.Zero)
					id_setBoostType_I = JNIEnv.GetMethodID (class_ref, "setBoostType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBoostType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBoostType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeakCount;
#pragma warning disable 0169
		static Delegate GetGetWeakCountHandler ()
		{
			if (cb_getWeakCount == null)
				cb_getWeakCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWeakCount);
			return cb_getWeakCount;
		}

		static int n_GetWeakCount (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeakCount;
		}
#pragma warning restore 0169

		static Delegate cb_setWeakCount_I;
#pragma warning disable 0169
		static Delegate GetSetWeakCount_IHandler ()
		{
			if (cb_setWeakCount_I == null)
				cb_setWeakCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWeakCount_I);
			return cb_setWeakCount_I;
		}

		static void n_SetWeakCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WeakCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeakCount;
		static IntPtr id_setWeakCount_I;
		public virtual unsafe int WeakCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='getWeakCount' and count(parameter)=0]"
			[Register ("getWeakCount", "()I", "GetGetWeakCountHandler")]
			get {
				if (id_getWeakCount == IntPtr.Zero)
					id_getWeakCount = JNIEnv.GetMethodID (class_ref, "getWeakCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWeakCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeakCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='setWeakCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWeakCount", "(I)V", "GetSetWeakCount_IHandler")]
			set {
				if (id_setWeakCount_I == IntPtr.Zero)
					id_setWeakCount_I = JNIEnv.GetMethodID (class_ref, "setWeakCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWeakCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeakCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeightTrimRate;
#pragma warning disable 0169
		static Delegate GetGetWeightTrimRateHandler ()
		{
			if (cb_getWeightTrimRate == null)
				cb_getWeightTrimRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetWeightTrimRate);
			return cb_getWeightTrimRate;
		}

		static double n_GetWeightTrimRate (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeightTrimRate;
		}
#pragma warning restore 0169

		static Delegate cb_setWeightTrimRate_D;
#pragma warning disable 0169
		static Delegate GetSetWeightTrimRate_DHandler ()
		{
			if (cb_setWeightTrimRate_D == null)
				cb_setWeightTrimRate_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetWeightTrimRate_D);
			return cb_setWeightTrimRate_D;
		}

		static void n_SetWeightTrimRate_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ML.Boost __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WeightTrimRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeightTrimRate;
		static IntPtr id_setWeightTrimRate_D;
		public virtual unsafe double WeightTrimRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='getWeightTrimRate' and count(parameter)=0]"
			[Register ("getWeightTrimRate", "()D", "GetGetWeightTrimRateHandler")]
			get {
				if (id_getWeightTrimRate == IntPtr.Zero)
					id_getWeightTrimRate = JNIEnv.GetMethodID (class_ref, "getWeightTrimRate", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getWeightTrimRate);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightTrimRate", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='setWeightTrimRate' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setWeightTrimRate", "(D)V", "GetSetWeightTrimRate_DHandler")]
			set {
				if (id_setWeightTrimRate_D == IntPtr.Zero)
					id_setWeightTrimRate_D = JNIEnv.GetMethodID (class_ref, "setWeightTrimRate", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWeightTrimRate_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeightTrimRate", "(D)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='Boost']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/Boost;", "")]
		public static unsafe global::OpenCV.ML.Boost Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/Boost;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.Boost> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
