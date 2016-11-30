using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']"
	[global::Android.Runtime.Register ("org/opencv/core/Point3", DoNotGenerateAcw=true)]
	public partial class Point3 : global::Java.Lang.Object {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/field[@name='x']"
		[Register ("x")]
		public double X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, x_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/field[@name='y']"
		[Register ("y")]
		public double Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, y_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/field[@name='z']"
		[Register ("z")]
		public double Z {
			get {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, z_jfieldId);
			}
			set {
				if (z_jfieldId == IntPtr.Zero)
					z_jfieldId = JNIEnv.GetFieldID (class_ref, "z", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, z_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Point3", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point3); }
		}

		protected Point3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/constructor[@name='Point3' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Point3 (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Point3)) {
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

		static IntPtr id_ctor_Lorg_opencv_core_Point_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/constructor[@name='Point3' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register (".ctor", "(Lorg/opencv/core/Point;)V", "")]
		public unsafe Point3 (global::OpenCV.Core.Point p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Point3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Point;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Point;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Point_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Point;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Point_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/constructor[@name='Point3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Point3 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Point3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_DDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/constructor[@name='Point3' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(DDD)V", "")]
		public unsafe Point3 (double p0, double p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Point3)) {
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
			global::OpenCV.Core.Point3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Point3;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Point3 Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Point3;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Point3;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cross_Lorg_opencv_core_Point3_;
#pragma warning disable 0169
		static Delegate GetCross_Lorg_opencv_core_Point3_Handler ()
		{
			if (cb_cross_Lorg_opencv_core_Point3_ == null)
				cb_cross_Lorg_opencv_core_Point3_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Cross_Lorg_opencv_core_Point3_);
			return cb_cross_Lorg_opencv_core_Point3_;
		}

		static IntPtr n_Cross_Lorg_opencv_core_Point3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Point3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point3 p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Cross (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cross_Lorg_opencv_core_Point3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/method[@name='cross' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point3']]"
		[Register ("cross", "(Lorg/opencv/core/Point3;)Lorg/opencv/core/Point3;", "GetCross_Lorg_opencv_core_Point3_Handler")]
		public virtual unsafe global::OpenCV.Core.Point3 Cross (global::OpenCV.Core.Point3 p0)
		{
			if (id_cross_Lorg_opencv_core_Point3_ == IntPtr.Zero)
				id_cross_Lorg_opencv_core_Point3_ = JNIEnv.GetMethodID (class_ref, "cross", "(Lorg/opencv/core/Point3;)Lorg/opencv/core/Point3;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Point3 __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cross_Lorg_opencv_core_Point3_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cross", "(Lorg/opencv/core/Point3;)Lorg/opencv/core/Point3;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dot_Lorg_opencv_core_Point3_;
#pragma warning disable 0169
		static Delegate GetDot_Lorg_opencv_core_Point3_Handler ()
		{
			if (cb_dot_Lorg_opencv_core_Point3_ == null)
				cb_dot_Lorg_opencv_core_Point3_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Dot_Lorg_opencv_core_Point3_);
			return cb_dot_Lorg_opencv_core_Point3_;
		}

		static double n_Dot_Lorg_opencv_core_Point3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Point3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point3 p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Dot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dot_Lorg_opencv_core_Point3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/method[@name='dot' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point3']]"
		[Register ("dot", "(Lorg/opencv/core/Point3;)D", "GetDot_Lorg_opencv_core_Point3_Handler")]
		public virtual unsafe double Dot (global::OpenCV.Core.Point3 p0)
		{
			if (id_dot_Lorg_opencv_core_Point3_ == IntPtr.Zero)
				id_dot_Lorg_opencv_core_Point3_ = JNIEnv.GetMethodID (class_ref, "dot", "(Lorg/opencv/core/Point3;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_dot_Lorg_opencv_core_Point3_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dot", "(Lorg/opencv/core/Point3;)D"), __args);
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
			global::OpenCV.Core.Point3 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point3']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
