using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']"
	[global::Android.Runtime.Register ("org/opencv/core/Rect", DoNotGenerateAcw=true)]
	public partial class Rect : global::Java.Lang.Object {


		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/field[@name='x']"
		[Register ("x")]
		public int X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, x_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/field[@name='y']"
		[Register ("y")]
		public int Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, y_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Rect", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rect); }
		}

		protected Rect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/constructor[@name='Rect' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Rect (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Rect)) {
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

		static IntPtr id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/constructor[@name='Rect' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='org.opencv.core.Size']]"
		[Register (".ctor", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;)V", "")]
		public unsafe Rect (global::OpenCV.Core.Point p0, global::OpenCV.Core.Size p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Rect)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Point_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/constructor[@name='Rect' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='org.opencv.core.Point']]"
		[Register (".ctor", "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)V", "")]
		public unsafe Rect (global::OpenCV.Core.Point p0, global::OpenCV.Core.Point p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Rect)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Point_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Point_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/constructor[@name='Rect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Rect ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Rect)) {
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

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/constructor[@name='Rect' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe Rect (int p0, int p1, int p2, int p3)
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
				if (GetType () != typeof (Rect)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_area;
#pragma warning disable 0169
		static Delegate GetAreaHandler ()
		{
			if (cb_area == null)
				cb_area = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Area);
			return cb_area;
		}

		static double n_Area (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Area ();
		}
#pragma warning restore 0169

		static IntPtr id_area;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='area' and count(parameter)=0]"
		[Register ("area", "()D", "GetAreaHandler")]
		public virtual unsafe double Area ()
		{
			if (id_area == IntPtr.Zero)
				id_area = JNIEnv.GetMethodID (class_ref, "area", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_area);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "area", "()D"));
			} finally {
			}
		}

		static Delegate cb_br;
#pragma warning disable 0169
		static Delegate GetBrHandler ()
		{
			if (cb_br == null)
				cb_br = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Br);
			return cb_br;
		}

		static IntPtr n_Br (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Br ());
		}
#pragma warning restore 0169

		static IntPtr id_br;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='br' and count(parameter)=0]"
		[Register ("br", "()Lorg/opencv/core/Point;", "GetBrHandler")]
		public virtual unsafe global::OpenCV.Core.Point Br ()
		{
			if (id_br == IntPtr.Zero)
				id_br = JNIEnv.GetMethodID (class_ref, "br", "()Lorg/opencv/core/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_br), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "br", "()Lorg/opencv/core/Point;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Rect;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Rect Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Rect;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Rect;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_contains_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_contains_Lorg_opencv_core_Point_ == null)
				cb_contains_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lorg_opencv_core_Point_);
			return cb_contains_Lorg_opencv_core_Point_;
		}

		static bool n_Contains_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register ("contains", "(Lorg/opencv/core/Point;)Z", "GetContains_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe bool Contains (global::OpenCV.Core.Point p0)
		{
			if (id_contains_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_contains_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/opencv/core/Point;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lorg/opencv/core/Point;)Z"), __args);
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
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Size);
			return cb_size;
		}

		static IntPtr n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size ());
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()Lorg/opencv/core/Size;", "GetSizeHandler")]
		public virtual unsafe global::OpenCV.Core.Size Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_size), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tl;
#pragma warning disable 0169
		static Delegate GetTlHandler ()
		{
			if (cb_tl == null)
				cb_tl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Tl);
			return cb_tl;
		}

		static IntPtr n_Tl (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Rect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tl ());
		}
#pragma warning restore 0169

		static IntPtr id_tl;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Rect']/method[@name='tl' and count(parameter)=0]"
		[Register ("tl", "()Lorg/opencv/core/Point;", "GetTlHandler")]
		public virtual unsafe global::OpenCV.Core.Point Tl ()
		{
			if (id_tl == IntPtr.Zero)
				id_tl = JNIEnv.GetMethodID (class_ref, "tl", "()Lorg/opencv/core/Point;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_tl), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tl", "()Lorg/opencv/core/Point;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
