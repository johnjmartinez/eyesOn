using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.VideoIO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']"
	[global::Android.Runtime.Register ("org/opencv/videoio/VideoWriter", DoNotGenerateAcw=true)]
	public partial class VideoWriter : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/videoio/VideoWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoWriter); }
		}

		protected VideoWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/constructor[@name='VideoWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoWriter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoWriter)) {
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

		static IntPtr id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/constructor[@name='VideoWriter' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register (".ctor", "(Ljava/lang/String;IDLorg/opencv/core/Size;)V", "")]
		public unsafe VideoWriter (string p0, int p1, double p2, global::OpenCV.Core.Size p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (VideoWriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IDLorg/opencv/core/Size;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IDLorg/opencv/core/Size;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IDLorg/opencv/core/Size;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/constructor[@name='VideoWriter' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)V", "")]
		public unsafe VideoWriter (string p0, int p1, double p2, global::OpenCV.Core.Size p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (VideoWriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IDLorg_opencv_core_Size_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/constructor[@name='VideoWriter' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe VideoWriter (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoWriter)) {
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

		static Delegate cb_isOpened;
#pragma warning disable 0169
		static Delegate GetIsOpenedHandler ()
		{
			if (cb_isOpened == null)
				cb_isOpened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpened);
			return cb_isOpened;
		}

		static bool n_IsOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpened;
		}
#pragma warning restore 0169

		static IntPtr id_isOpened;
		public virtual unsafe bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='isOpened' and count(parameter)=0]"
			[Register ("isOpened", "()Z", "GetIsOpenedHandler")]
			get {
				if (id_isOpened == IntPtr.Zero)
					id_isOpened = JNIEnv.GetMethodID (class_ref, "isOpened", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpened);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpened", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_fourcc_CCCC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='fourcc' and count(parameter)=4 and parameter[1][@type='char'] and parameter[2][@type='char'] and parameter[3][@type='char'] and parameter[4][@type='char']]"
		[Register ("fourcc", "(CCCC)I", "")]
		public static unsafe int Fourcc (char p0, char p1, char p2, char p3)
		{
			if (id_fourcc_CCCC == IntPtr.Zero)
				id_fourcc_CCCC = JNIEnv.GetStaticMethodID (class_ref, "fourcc", "(CCCC)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_fourcc_CCCC, __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_Get_I);
			return cb_get_I;
		}

		static double n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)D", "GetGet_IHandler")]
		public virtual unsafe double Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IDLorg_opencv_core_Size_Handler ()
		{
			if (cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_ == null)
				cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, double, IntPtr, bool>) n_Open_Ljava_lang_String_IDLorg_opencv_core_Size_);
			return cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_;
		}

		static bool n_Open_Ljava_lang_String_IDLorg_opencv_core_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2, IntPtr native_p3)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Open (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_String_IDLorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='open' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Size']]"
		[Register ("open", "(Ljava/lang/String;IDLorg/opencv/core/Size;)Z", "GetOpen_Ljava_lang_String_IDLorg_opencv_core_Size_Handler")]
		public virtual unsafe bool Open (string p0, int p1, double p2, global::OpenCV.Core.Size p3)
		{
			if (id_open_Ljava_lang_String_IDLorg_opencv_core_Size_ == IntPtr.Zero)
				id_open_Ljava_lang_String_IDLorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;IDLorg/opencv/core/Size;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_IDLorg_opencv_core_Size_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/String;IDLorg/opencv/core/Size;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IDLorg_opencv_core_Size_ZHandler ()
		{
			if (cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z == null)
				cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, double, IntPtr, bool, bool>) n_Open_Ljava_lang_String_IDLorg_opencv_core_Size_Z);
			return cb_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z;
		}

		static bool n_Open_Ljava_lang_String_IDLorg_opencv_core_Size_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2, IntPtr native_p3, bool p4)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Open (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='open' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='boolean']]"
		[Register ("open", "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)Z", "GetOpen_Ljava_lang_String_IDLorg_opencv_core_Size_ZHandler")]
		public virtual unsafe bool Open (string p0, int p1, double p2, global::OpenCV.Core.Size p3, bool p4)
		{
			if (id_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z == IntPtr.Zero)
				id_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_IDLorg_opencv_core_Size_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/String;IDLorg/opencv/core/Size;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_set_ID;
#pragma warning disable 0169
		static Delegate GetSet_IDHandler ()
		{
			if (cb_set_ID == null)
				cb_set_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double, bool>) n_Set_ID);
			return cb_set_ID;
		}

		static bool n_Set_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("set", "(ID)Z", "GetSet_IDHandler")]
		public virtual unsafe bool Set (int p0, double p1)
		{
			if (id_set_ID == IntPtr.Zero)
				id_set_ID = JNIEnv.GetMethodID (class_ref, "set", "(ID)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_set_ID, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ID)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_write_Lorg_opencv_core_Mat_ == null)
				cb_write_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lorg_opencv_core_Mat_);
			return cb_write_Lorg_opencv_core_Mat_;
		}

		static void n_Write_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.VideoIO.VideoWriter __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoWriter']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("write", "(Lorg/opencv/core/Mat;)V", "GetWrite_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Write (global::OpenCV.Core.Mat p0)
		{
			if (id_write_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_write_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "write", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
