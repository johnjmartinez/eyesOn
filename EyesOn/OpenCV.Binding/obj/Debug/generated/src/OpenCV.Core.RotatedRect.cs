using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']"
	[global::Android.Runtime.Register ("org/opencv/core/RotatedRect", DoNotGenerateAcw=true)]
	public partial class RotatedRect : global::Java.Lang.Object {


		static IntPtr angle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/field[@name='angle']"
		[Register ("angle")]
		public double Angle {
			get {
				if (angle_jfieldId == IntPtr.Zero)
					angle_jfieldId = JNIEnv.GetFieldID (class_ref, "angle", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, angle_jfieldId);
			}
			set {
				if (angle_jfieldId == IntPtr.Zero)
					angle_jfieldId = JNIEnv.GetFieldID (class_ref, "angle", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, angle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr center_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/field[@name='center']"
		[Register ("center")]
		public global::OpenCV.Core.Point Center {
			get {
				if (center_jfieldId == IntPtr.Zero)
					center_jfieldId = JNIEnv.GetFieldID (class_ref, "center", "Lorg/opencv/core/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, center_jfieldId);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (center_jfieldId == IntPtr.Zero)
					center_jfieldId = JNIEnv.GetFieldID (class_ref, "center", "Lorg/opencv/core/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, center_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/field[@name='size']"
		[Register ("size")]
		public global::OpenCV.Core.Size Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "Lorg/opencv/core/Size;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, size_jfieldId);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "Lorg/opencv/core/Size;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, size_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/RotatedRect", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RotatedRect); }
		}

		protected RotatedRect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/constructor[@name='RotatedRect' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe RotatedRect (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (RotatedRect)) {
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

		static IntPtr id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_D;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/constructor[@name='RotatedRect' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='double']]"
		[Register (".ctor", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;D)V", "")]
		public unsafe RotatedRect (global::OpenCV.Core.Point p0, global::OpenCV.Core.Size p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RotatedRect)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;D)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_D == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_D = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Point;Lorg/opencv/core/Size;D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_D, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Point_Lorg_opencv_core_Size_D, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/constructor[@name='RotatedRect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RotatedRect ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RotatedRect)) {
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

		static Delegate cb_boundingRect;
#pragma warning disable 0169
		static Delegate GetBoundingRectHandler ()
		{
			if (cb_boundingRect == null)
				cb_boundingRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BoundingRect);
			return cb_boundingRect;
		}

		static IntPtr n_BoundingRect (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.RotatedRect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BoundingRect ());
		}
#pragma warning restore 0169

		static IntPtr id_boundingRect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/method[@name='boundingRect' and count(parameter)=0]"
		[Register ("boundingRect", "()Lorg/opencv/core/Rect;", "GetBoundingRectHandler")]
		public virtual unsafe global::OpenCV.Core.Rect BoundingRect ()
		{
			if (id_boundingRect == IntPtr.Zero)
				id_boundingRect = JNIEnv.GetMethodID (class_ref, "boundingRect", "()Lorg/opencv/core/Rect;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_boundingRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "boundingRect", "()Lorg/opencv/core/Rect;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.RotatedRect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/RotatedRect;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.RotatedRect Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/RotatedRect;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/RotatedRect;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_points_arrayLorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetPoints_arrayLorg_opencv_core_Point_Handler ()
		{
			if (cb_points_arrayLorg_opencv_core_Point_ == null)
				cb_points_arrayLorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Points_arrayLorg_opencv_core_Point_);
			return cb_points_arrayLorg_opencv_core_Point_;
		}

		static void n_Points_arrayLorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.RotatedRect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point[] p0 = (global::OpenCV.Core.Point[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::OpenCV.Core.Point));
			__this.Points (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_points_arrayLorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/method[@name='points' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point[]']]"
		[Register ("points", "([Lorg/opencv/core/Point;)V", "GetPoints_arrayLorg_opencv_core_Point_Handler")]
		public virtual unsafe void Points (global::OpenCV.Core.Point[] p0)
		{
			if (id_points_arrayLorg_opencv_core_Point_ == IntPtr.Zero)
				id_points_arrayLorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "points", "([Lorg/opencv/core/Point;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_points_arrayLorg_opencv_core_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "points", "([Lorg/opencv/core/Point;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::OpenCV.Core.RotatedRect __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.RotatedRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='RotatedRect']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
