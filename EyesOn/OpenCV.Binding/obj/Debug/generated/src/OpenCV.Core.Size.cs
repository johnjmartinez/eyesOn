using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']"
	[global::Android.Runtime.Register ("org/opencv/core/Size", DoNotGenerateAcw=true)]
	public partial class Size : global::Java.Lang.Object {


		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/field[@name='height']"
		[Register ("height")]
		public double Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/field[@name='width']"
		[Register ("width")]
		public double Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Size", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Size); }
		}

		protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/constructor[@name='Size' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Size (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Size)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/constructor[@name='Size' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register (".ctor", "(Lorg/opencv/core/Point;)V", "")]
		public unsafe Size (global::OpenCV.Core.Point p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Size)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/constructor[@name='Size' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Size ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Size)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/constructor[@name='Size' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe Size (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Size)) {
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
			global::OpenCV.Core.Size __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Area ();
		}
#pragma warning restore 0169

		static IntPtr id_area;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/method[@name='area' and count(parameter)=0]"
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
			global::OpenCV.Core.Size __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Size;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Size Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.Size __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Size']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
