using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']"
	[global::Android.Runtime.Register ("org/opencv/ml/KNearest", DoNotGenerateAcw=true)]
	public partial class KNearest : global::OpenCV.ML.StatModel {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/field[@name='BRUTE_FORCE']"
		[Register ("BRUTE_FORCE")]
		public const int BruteForce = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/field[@name='KDTREE']"
		[Register ("KDTREE")]
		public const int Kdtree = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/KNearest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KNearest); }
		}

		protected KNearest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/constructor[@name='KNearest' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe KNearest (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (KNearest)) {
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

		static Delegate cb_getAlgorithmType;
#pragma warning disable 0169
		static Delegate GetGetAlgorithmTypeHandler ()
		{
			if (cb_getAlgorithmType == null)
				cb_getAlgorithmType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlgorithmType);
			return cb_getAlgorithmType;
		}

		static int n_GetAlgorithmType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlgorithmType;
		}
#pragma warning restore 0169

		static Delegate cb_setAlgorithmType_I;
#pragma warning disable 0169
		static Delegate GetSetAlgorithmType_IHandler ()
		{
			if (cb_setAlgorithmType_I == null)
				cb_setAlgorithmType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlgorithmType_I);
			return cb_setAlgorithmType_I;
		}

		static void n_SetAlgorithmType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AlgorithmType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlgorithmType;
		static IntPtr id_setAlgorithmType_I;
		public virtual unsafe int AlgorithmType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='getAlgorithmType' and count(parameter)=0]"
			[Register ("getAlgorithmType", "()I", "GetGetAlgorithmTypeHandler")]
			get {
				if (id_getAlgorithmType == IntPtr.Zero)
					id_getAlgorithmType = JNIEnv.GetMethodID (class_ref, "getAlgorithmType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlgorithmType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlgorithmType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='setAlgorithmType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAlgorithmType", "(I)V", "GetSetAlgorithmType_IHandler")]
			set {
				if (id_setAlgorithmType_I == IntPtr.Zero)
					id_setAlgorithmType_I = JNIEnv.GetMethodID (class_ref, "setAlgorithmType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlgorithmType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlgorithmType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultK;
#pragma warning disable 0169
		static Delegate GetGetDefaultKHandler ()
		{
			if (cb_getDefaultK == null)
				cb_getDefaultK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultK);
			return cb_getDefaultK;
		}

		static int n_GetDefaultK (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultK;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultK_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultK_IHandler ()
		{
			if (cb_setDefaultK_I == null)
				cb_setDefaultK_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultK_I);
			return cb_setDefaultK_I;
		}

		static void n_SetDefaultK_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultK = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultK;
		static IntPtr id_setDefaultK_I;
		public virtual unsafe int DefaultK {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='getDefaultK' and count(parameter)=0]"
			[Register ("getDefaultK", "()I", "GetGetDefaultKHandler")]
			get {
				if (id_getDefaultK == IntPtr.Zero)
					id_getDefaultK = JNIEnv.GetMethodID (class_ref, "getDefaultK", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultK);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultK", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='setDefaultK' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultK", "(I)V", "GetSetDefaultK_IHandler")]
			set {
				if (id_setDefaultK_I == IntPtr.Zero)
					id_setDefaultK_I = JNIEnv.GetMethodID (class_ref, "setDefaultK", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultK_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultK", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEmax;
#pragma warning disable 0169
		static Delegate GetGetEmaxHandler ()
		{
			if (cb_getEmax == null)
				cb_getEmax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEmax);
			return cb_getEmax;
		}

		static int n_GetEmax (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Emax;
		}
#pragma warning restore 0169

		static Delegate cb_setEmax_I;
#pragma warning disable 0169
		static Delegate GetSetEmax_IHandler ()
		{
			if (cb_setEmax_I == null)
				cb_setEmax_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEmax_I);
			return cb_setEmax_I;
		}

		static void n_SetEmax_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Emax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmax;
		static IntPtr id_setEmax_I;
		public virtual unsafe int Emax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='getEmax' and count(parameter)=0]"
			[Register ("getEmax", "()I", "GetGetEmaxHandler")]
			get {
				if (id_getEmax == IntPtr.Zero)
					id_getEmax = JNIEnv.GetMethodID (class_ref, "getEmax", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEmax);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmax", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='setEmax' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEmax", "(I)V", "GetSetEmax_IHandler")]
			set {
				if (id_setEmax_I == IntPtr.Zero)
					id_setEmax_I = JNIEnv.GetMethodID (class_ref, "setEmax", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmax_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmax", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIsClassifier;
#pragma warning disable 0169
		static Delegate GetGetIsClassifierHandler ()
		{
			if (cb_getIsClassifier == null)
				cb_getIsClassifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsClassifier);
			return cb_getIsClassifier;
		}

		static bool n_GetIsClassifier (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClassifier;
		}
#pragma warning restore 0169

		static IntPtr id_getIsClassifier;
		public override unsafe bool IsClassifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='getIsClassifier' and count(parameter)=0]"
			[Register ("getIsClassifier", "()Z", "GetGetIsClassifierHandler")]
			get {
				if (id_getIsClassifier == IntPtr.Zero)
					id_getIsClassifier = JNIEnv.GetMethodID (class_ref, "getIsClassifier", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getIsClassifier);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsClassifier", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/ml/KNearest;", "")]
		public static unsafe global::OpenCV.ML.KNearest Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/ml/KNearest;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetFindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Handler ()
		{
			if (cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == null)
				cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, float>) n_FindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_);
			return cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		}

		static float n_FindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.FindNearest (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='findNearest' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)F", "GetFindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Handler")]
		public virtual unsafe float FindNearest (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2)
		{
			if (id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetFindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, float>) n_FindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static float n_FindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.FindNearest (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='findNearest' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F", "GetFindNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe float FindNearest (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_findNearest_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findNearest", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setIsClassifier_Z;
#pragma warning disable 0169
		static Delegate GetSetIsClassifier_ZHandler ()
		{
			if (cb_setIsClassifier_Z == null)
				cb_setIsClassifier_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsClassifier_Z);
			return cb_setIsClassifier_Z;
		}

		static void n_SetIsClassifier_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.ML.KNearest __this = global::Java.Lang.Object.GetObject<global::OpenCV.ML.KNearest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsClassifier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsClassifier_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.ml']/class[@name='KNearest']/method[@name='setIsClassifier' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsClassifier", "(Z)V", "GetSetIsClassifier_ZHandler")]
		public virtual unsafe void SetIsClassifier (bool p0)
		{
			if (id_setIsClassifier_Z == IntPtr.Zero)
				id_setIsClassifier_Z = JNIEnv.GetMethodID (class_ref, "setIsClassifier", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsClassifier_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsClassifier", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
