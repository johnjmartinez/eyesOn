using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']"
	[global::Android.Runtime.Register ("org/opencv/core/TermCriteria", DoNotGenerateAcw=true)]
	public partial class TermCriteria : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='COUNT']"
		[Register ("COUNT")]
		public const int Count = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='EPS']"
		[Register ("EPS")]
		public const int Eps = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='MAX_ITER']"
		[Register ("MAX_ITER")]
		public const int MaxIter = (int) 1;

		static IntPtr epsilon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='epsilon']"
		[Register ("epsilon")]
		public double Epsilon {
			get {
				if (epsilon_jfieldId == IntPtr.Zero)
					epsilon_jfieldId = JNIEnv.GetFieldID (class_ref, "epsilon", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, epsilon_jfieldId);
			}
			set {
				if (epsilon_jfieldId == IntPtr.Zero)
					epsilon_jfieldId = JNIEnv.GetFieldID (class_ref, "epsilon", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, epsilon_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='maxCount']"
		[Register ("maxCount")]
		public int MaxCount {
			get {
				if (maxCount_jfieldId == IntPtr.Zero)
					maxCount_jfieldId = JNIEnv.GetFieldID (class_ref, "maxCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxCount_jfieldId);
			}
			set {
				if (maxCount_jfieldId == IntPtr.Zero)
					maxCount_jfieldId = JNIEnv.GetFieldID (class_ref, "maxCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/TermCriteria", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TermCriteria); }
		}

		protected TermCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/constructor[@name='TermCriteria' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe TermCriteria (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TermCriteria)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/constructor[@name='TermCriteria' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TermCriteria ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TermCriteria)) {
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

		static IntPtr id_ctor_IID;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/constructor[@name='TermCriteria' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register (".ctor", "(IID)V", "")]
		public unsafe TermCriteria (int p0, int p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TermCriteria)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IID)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IID)V", __args);
					return;
				}

				if (id_ctor_IID == IntPtr.Zero)
					id_ctor_IID = JNIEnv.GetMethodID (class_ref, "<init>", "(IID)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IID, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IID, __args);
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
			global::OpenCV.Core.TermCriteria __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/TermCriteria;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.TermCriteria Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/TermCriteria;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/TermCriteria;")), JniHandleOwnership.TransferLocalRef);
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
			global::OpenCV.Core.TermCriteria __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.TermCriteria> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='TermCriteria']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
