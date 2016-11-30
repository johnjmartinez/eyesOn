using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']"
	[global::Android.Runtime.Register ("org/opencv/core/Algorithm", DoNotGenerateAcw=true)]
	public partial class Algorithm : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		protected long NativeObj {
			get {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId);
			}
			set {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/Algorithm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Algorithm); }
		}

		protected Algorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']/constructor[@name='Algorithm' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Algorithm (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Algorithm)) {
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

		static Delegate cb_getDefaultName;
#pragma warning disable 0169
		static Delegate GetGetDefaultNameHandler ()
		{
			if (cb_getDefaultName == null)
				cb_getDefaultName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultName);
			return cb_getDefaultName;
		}

		static IntPtr n_GetDefaultName (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Algorithm __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Algorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultName);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultName;
		public virtual unsafe string DefaultName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']/method[@name='getDefaultName' and count(parameter)=0]"
			[Register ("getDefaultName", "()Ljava/lang/String;", "GetGetDefaultNameHandler")]
			get {
				if (id_getDefaultName == IntPtr.Zero)
					id_getDefaultName = JNIEnv.GetMethodID (class_ref, "getDefaultName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Algorithm __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Algorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_save_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Algorithm __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Algorithm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Algorithm']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string p0)
		{
			if (id_save_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
