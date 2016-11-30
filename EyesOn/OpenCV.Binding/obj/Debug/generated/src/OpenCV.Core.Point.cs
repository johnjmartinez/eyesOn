using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']"
	[global::Android.Runtime.Register ("org/opencv/core/Point", DoNotGenerateAcw=true)]
	public partial class Point : global::Java.Lang.Object {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/field[@name='x']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/field[@name='y']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Point", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point); }
		}

		protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/constructor[@name='Point' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Point (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Point)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Point ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Point)) {
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

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/constructor[@name='Point' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe Point (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Point)) {
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
			global::OpenCV.Core.Point __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Point;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Point Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dot_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetDot_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_dot_Lorg_opencv_core_Point_ == null)
				cb_dot_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Dot_Lorg_opencv_core_Point_);
			return cb_dot_Lorg_opencv_core_Point_;
		}

		static double n_Dot_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Point __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Dot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dot_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/method[@name='dot' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register ("dot", "(Lorg/opencv/core/Point;)D", "GetDot_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe double Dot (global::OpenCV.Core.Point p0)
		{
			if (id_dot_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_dot_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "dot", "(Lorg/opencv/core/Point;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_dot_Lorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dot", "(Lorg/opencv/core/Point;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_inside_Lorg_opencv_core_Rect_;
#pragma warning disable 0169
		static Delegate GetInside_Lorg_opencv_core_Rect_Handler ()
		{
			if (cb_inside_Lorg_opencv_core_Rect_ == null)
				cb_inside_Lorg_opencv_core_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Inside_Lorg_opencv_core_Rect_);
			return cb_inside_Lorg_opencv_core_Rect_;
		}

		static bool n_Inside_Lorg_opencv_core_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Point __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Rect p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Inside (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_inside_Lorg_opencv_core_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/method[@name='inside' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
		[Register ("inside", "(Lorg/opencv/core/Rect;)Z", "GetInside_Lorg_opencv_core_Rect_Handler")]
		public virtual unsafe bool Inside (global::OpenCV.Core.Rect p0)
		{
			if (id_inside_Lorg_opencv_core_Rect_ == IntPtr.Zero)
				id_inside_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "inside", "(Lorg/opencv/core/Rect;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_inside_Lorg_opencv_core_Rect_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inside", "(Lorg/opencv/core/Rect;)Z"), __args);
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
			global::OpenCV.Core.Point __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Point']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
