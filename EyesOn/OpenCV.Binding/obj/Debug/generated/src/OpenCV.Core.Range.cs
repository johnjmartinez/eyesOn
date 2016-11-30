using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']"
	[global::Android.Runtime.Register ("org/opencv/core/Range", DoNotGenerateAcw=true)]
	public partial class Range : global::Java.Lang.Object {


		static IntPtr end_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/field[@name='end']"
		[Register ("end")]
		public int End {
			get {
				if (end_jfieldId == IntPtr.Zero)
					end_jfieldId = JNIEnv.GetFieldID (class_ref, "end", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, end_jfieldId);
			}
			set {
				if (end_jfieldId == IntPtr.Zero)
					end_jfieldId = JNIEnv.GetFieldID (class_ref, "end", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, end_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr start_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/field[@name='start']"
		[Register ("start")]
		public int Start {
			get {
				if (start_jfieldId == IntPtr.Zero)
					start_jfieldId = JNIEnv.GetFieldID (class_ref, "start", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, start_jfieldId);
			}
			set {
				if (start_jfieldId == IntPtr.Zero)
					start_jfieldId = JNIEnv.GetFieldID (class_ref, "start", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, start_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Range", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Range); }
		}

		protected Range (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/constructor[@name='Range' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Range (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Range)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/constructor[@name='Range' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Range ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Range)) {
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

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/constructor[@name='Range' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Range (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Range)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_all;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='all' and count(parameter)=0]"
		[Register ("all", "()Lorg/opencv/core/Range;", "")]
		public static unsafe global::OpenCV.Core.Range All ()
		{
			if (id_all == IntPtr.Zero)
				id_all = JNIEnv.GetStaticMethodID (class_ref, "all", "()Lorg/opencv/core/Range;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallStaticObjectMethod  (class_ref, id_all), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Range;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Range Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Range;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Range;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='empty' and count(parameter)=0]"
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

		static Delegate cb_intersection_Lorg_opencv_core_Range_;
#pragma warning disable 0169
		static Delegate GetIntersection_Lorg_opencv_core_Range_Handler ()
		{
			if (cb_intersection_Lorg_opencv_core_Range_ == null)
				cb_intersection_Lorg_opencv_core_Range_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Intersection_Lorg_opencv_core_Range_);
			return cb_intersection_Lorg_opencv_core_Range_;
		}

		static IntPtr n_Intersection_Lorg_opencv_core_Range_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Range p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Intersection (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_intersection_Lorg_opencv_core_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='intersection' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Range']]"
		[Register ("intersection", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Range;", "GetIntersection_Lorg_opencv_core_Range_Handler")]
		public virtual unsafe global::OpenCV.Core.Range Intersection (global::OpenCV.Core.Range p0)
		{
			if (id_intersection_Lorg_opencv_core_Range_ == IntPtr.Zero)
				id_intersection_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "intersection", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Range;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Range __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intersection_Lorg_opencv_core_Range_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intersection", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Range;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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

		static Delegate cb_shift_I;
#pragma warning disable 0169
		static Delegate GetShift_IHandler ()
		{
			if (cb_shift_I == null)
				cb_shift_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Shift_I);
			return cb_shift_I;
		}

		static IntPtr n_Shift_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Shift (p0));
		}
#pragma warning restore 0169

		static IntPtr id_shift_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='shift' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shift", "(I)Lorg/opencv/core/Range;", "GetShift_IHandler")]
		public virtual unsafe global::OpenCV.Core.Range Shift (int p0)
		{
			if (id_shift_I == IntPtr.Zero)
				id_shift_I = JNIEnv.GetMethodID (class_ref, "shift", "(I)Lorg/opencv/core/Range;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_shift_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shift", "(I)Lorg/opencv/core/Range;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Range __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Range']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
