using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']"
	[global::Android.Runtime.Register ("org/opencv/core/Scalar", DoNotGenerateAcw=true)]
	public partial class Scalar : global::Java.Lang.Object {


		static IntPtr val_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/field[@name='val']"
		[Register ("val")]
		public IList<double> Val {
			get {
				if (val_jfieldId == IntPtr.Zero)
					val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, val_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (val_jfieldId == IntPtr.Zero)
					val_jfieldId = JNIEnv.GetFieldID (class_ref, "val", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, val_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Scalar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scalar); }
		}

		protected Scalar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/constructor[@name='Scalar' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Scalar (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Scalar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([D)V", __args);
					return;
				}

				if (id_ctor_arrayD == IntPtr.Zero)
					id_ctor_arrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/constructor[@name='Scalar' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register (".ctor", "(D)V", "")]
		public unsafe Scalar (double p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Scalar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(D)V", __args);
					return;
				}

				if (id_ctor_D == IntPtr.Zero)
					id_ctor_D = JNIEnv.GetMethodID (class_ref, "<init>", "(D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/constructor[@name='Scalar' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe Scalar (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Scalar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_DDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/constructor[@name='Scalar' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(DDD)V", "")]
		public unsafe Scalar (double p0, double p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Scalar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DDD)V", __args);
					return;
				}

				if (id_ctor_DDD == IntPtr.Zero)
					id_ctor_DDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_DDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/constructor[@name='Scalar' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register (".ctor", "(DDDD)V", "")]
		public unsafe Scalar (double p0, double p1, double p2, double p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Scalar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DDDD)V", __args);
					return;
				}

				if (id_ctor_DDDD == IntPtr.Zero)
					id_ctor_DDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DDDD, __args);
			} finally {
			}
		}

		static Delegate cb_isReal;
#pragma warning disable 0169
		static Delegate GetIsRealHandler ()
		{
			if (cb_isReal == null)
				cb_isReal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReal);
			return cb_isReal;
		}

		static bool n_IsReal (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReal;
		}
#pragma warning restore 0169

		static IntPtr id_isReal;
		public virtual unsafe bool IsReal {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='isReal' and count(parameter)=0]"
			[Register ("isReal", "()Z", "GetIsRealHandler")]
			get {
				if (id_isReal == IntPtr.Zero)
					id_isReal = JNIEnv.GetMethodID (class_ref, "isReal", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReal);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReal", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_all_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='all' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("all", "(D)Lorg/opencv/core/Scalar;", "")]
		public static unsafe global::OpenCV.Core.Scalar All (double p0)
		{
			if (id_all_D == IntPtr.Zero)
				id_all_D = JNIEnv.GetStaticMethodID (class_ref, "all", "(D)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_all_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Scalar;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Scalar Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Scalar;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Scalar;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_conj;
#pragma warning disable 0169
		static Delegate GetConjHandler ()
		{
			if (cb_conj == null)
				cb_conj = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Conj);
			return cb_conj;
		}

		static IntPtr n_Conj (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conj ());
		}
#pragma warning restore 0169

		static IntPtr id_conj;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='conj' and count(parameter)=0]"
		[Register ("conj", "()Lorg/opencv/core/Scalar;", "GetConjHandler")]
		public virtual unsafe global::OpenCV.Core.Scalar Conj ()
		{
			if (id_conj == IntPtr.Zero)
				id_conj = JNIEnv.GetMethodID (class_ref, "conj", "()Lorg/opencv/core/Scalar;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_conj), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "conj", "()Lorg/opencv/core/Scalar;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mul_Lorg_opencv_core_Scalar_;
#pragma warning disable 0169
		static Delegate GetMul_Lorg_opencv_core_Scalar_Handler ()
		{
			if (cb_mul_Lorg_opencv_core_Scalar_ == null)
				cb_mul_Lorg_opencv_core_Scalar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Mul_Lorg_opencv_core_Scalar_);
			return cb_mul_Lorg_opencv_core_Scalar_;
		}

		static IntPtr n_Mul_Lorg_opencv_core_Scalar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Scalar p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mul (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mul_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='mul' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Scalar']]"
		[Register ("mul", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Scalar;", "GetMul_Lorg_opencv_core_Scalar_Handler")]
		public virtual unsafe global::OpenCV.Core.Scalar Mul (global::OpenCV.Core.Scalar p0)
		{
			if (id_mul_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_mul_Lorg_opencv_core_Scalar_ = JNIEnv.GetMethodID (class_ref, "mul", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Scalar __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mul_Lorg_opencv_core_Scalar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mul", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Scalar;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mul_Lorg_opencv_core_Scalar_D;
#pragma warning disable 0169
		static Delegate GetMul_Lorg_opencv_core_Scalar_DHandler ()
		{
			if (cb_mul_Lorg_opencv_core_Scalar_D == null)
				cb_mul_Lorg_opencv_core_Scalar_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Mul_Lorg_opencv_core_Scalar_D);
			return cb_mul_Lorg_opencv_core_Scalar_D;
		}

		static IntPtr n_Mul_Lorg_opencv_core_Scalar_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Scalar p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mul (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mul_Lorg_opencv_core_Scalar_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='mul' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Scalar'] and parameter[2][@type='double']]"
		[Register ("mul", "(Lorg/opencv/core/Scalar;D)Lorg/opencv/core/Scalar;", "GetMul_Lorg_opencv_core_Scalar_DHandler")]
		public virtual unsafe global::OpenCV.Core.Scalar Mul (global::OpenCV.Core.Scalar p0, double p1)
		{
			if (id_mul_Lorg_opencv_core_Scalar_D == IntPtr.Zero)
				id_mul_Lorg_opencv_core_Scalar_D = JNIEnv.GetMethodID (class_ref, "mul", "(Lorg/opencv/core/Scalar;D)Lorg/opencv/core/Scalar;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Scalar __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mul_Lorg_opencv_core_Scalar_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mul", "(Lorg/opencv/core/Scalar;D)Lorg/opencv/core/Scalar;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_set_arrayD;
#pragma warning disable 0169
		static Delegate GetSet_arrayDHandler ()
		{
			if (cb_set_arrayD == null)
				cb_set_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_arrayD);
			return cb_set_arrayD;
		}

		static void n_Set_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Scalar __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Scalar']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("set", "([D)V", "GetSet_arrayDHandler")]
		public virtual unsafe void Set (double[] p0)
		{
			if (id_set_arrayD == IntPtr.Zero)
				id_set_arrayD = JNIEnv.GetMethodID (class_ref, "set", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
