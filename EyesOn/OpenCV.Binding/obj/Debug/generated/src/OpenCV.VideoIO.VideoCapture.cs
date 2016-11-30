using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.VideoIO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']"
	[global::Android.Runtime.Register ("org/opencv/videoio/VideoCapture", DoNotGenerateAcw=true)]
	public partial class VideoCapture : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/videoio/VideoCapture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCapture); }
		}

		protected VideoCapture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/constructor[@name='VideoCapture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoCapture ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoCapture)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/constructor[@name='VideoCapture' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe VideoCapture (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoCapture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/constructor[@name='VideoCapture' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe VideoCapture (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (VideoCapture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/constructor[@name='VideoCapture' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe VideoCapture (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VideoCapture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/constructor[@name='VideoCapture' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe VideoCapture (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoCapture)) {
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
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpened;
		}
#pragma warning restore 0169

		static IntPtr id_isOpened;
		public virtual unsafe bool IsOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='isOpened' and count(parameter)=0]"
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
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_grab;
#pragma warning disable 0169
		static Delegate GetGrabHandler ()
		{
			if (cb_grab == null)
				cb_grab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Grab);
			return cb_grab;
		}

		static bool n_Grab (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Grab ();
		}
#pragma warning restore 0169

		static IntPtr id_grab;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='grab' and count(parameter)=0]"
		[Register ("grab", "()Z", "GetGrabHandler")]
		public virtual unsafe bool Grab ()
		{
			if (id_grab == IntPtr.Zero)
				id_grab = JNIEnv.GetMethodID (class_ref, "grab", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_grab);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grab", "()Z"));
			} finally {
			}
		}

		static Delegate cb_open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_open_I == null)
				cb_open_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Open_I);
			return cb_open_I;
		}

		static bool n_Open_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)Z", "GetOpen_IHandler")]
		public virtual unsafe bool Open (int p0)
		{
			if (id_open_I == IntPtr.Zero)
				id_open_I = JNIEnv.GetMethodID (class_ref, "open", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_open_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_Handler ()
		{
			if (cb_open_Ljava_lang_String_ == null)
				cb_open_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Open_Ljava_lang_String_);
			return cb_open_Ljava_lang_String_;
		}

		static bool n_Open_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Open (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;)Z", "GetOpen_Ljava_lang_String_Handler")]
		public virtual unsafe bool Open (string p0)
		{
			if (id_open_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_open_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IHandler ()
		{
			if (cb_open_Ljava_lang_String_I == null)
				cb_open_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_Open_Ljava_lang_String_I);
			return cb_open_Ljava_lang_String_I;
		}

		static bool n_Open_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Open (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("open", "(Ljava/lang/String;I)Z", "GetOpen_Ljava_lang_String_IHandler")]
		public virtual unsafe bool Open (string p0, int p1)
		{
			if (id_open_Ljava_lang_String_I == IntPtr.Zero)
				id_open_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/String;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_read_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetRead_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_read_Lorg_opencv_core_Mat_ == null)
				cb_read_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Read_Lorg_opencv_core_Mat_);
			return cb_read_Lorg_opencv_core_Mat_;
		}

		static bool n_Read_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Read (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='read' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("read", "(Lorg/opencv/core/Mat;)Z", "GetRead_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool Read (global::OpenCV.Core.Mat p0)
		{
			if (id_read_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_read_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "read", "(Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_read_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
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
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_retrieve_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetRetrieve_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_retrieve_Lorg_opencv_core_Mat_ == null)
				cb_retrieve_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Retrieve_Lorg_opencv_core_Mat_);
			return cb_retrieve_Lorg_opencv_core_Mat_;
		}

		static bool n_Retrieve_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Retrieve (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_retrieve_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='retrieve' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("retrieve", "(Lorg/opencv/core/Mat;)Z", "GetRetrieve_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe bool Retrieve (global::OpenCV.Core.Mat p0)
		{
			if (id_retrieve_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_retrieve_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "retrieve", "(Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retrieve_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieve", "(Lorg/opencv/core/Mat;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_retrieve_Lorg_opencv_core_Mat_I;
#pragma warning disable 0169
		static Delegate GetRetrieve_Lorg_opencv_core_Mat_IHandler ()
		{
			if (cb_retrieve_Lorg_opencv_core_Mat_I == null)
				cb_retrieve_Lorg_opencv_core_Mat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_Retrieve_Lorg_opencv_core_Mat_I);
			return cb_retrieve_Lorg_opencv_core_Mat_I;
		}

		static bool n_Retrieve_Lorg_opencv_core_Mat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Retrieve (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_retrieve_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='retrieve' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int']]"
		[Register ("retrieve", "(Lorg/opencv/core/Mat;I)Z", "GetRetrieve_Lorg_opencv_core_Mat_IHandler")]
		public virtual unsafe bool Retrieve (global::OpenCV.Core.Mat p0, int p1)
		{
			if (id_retrieve_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_retrieve_Lorg_opencv_core_Mat_I = JNIEnv.GetMethodID (class_ref, "retrieve", "(Lorg/opencv/core/Mat;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retrieve_Lorg_opencv_core_Mat_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieve", "(Lorg/opencv/core/Mat;I)Z"), __args);
				return __ret;
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
			global::OpenCV.VideoIO.VideoCapture __this = global::Java.Lang.Object.GetObject<global::OpenCV.VideoIO.VideoCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Set (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_set_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.videoio']/class[@name='VideoCapture']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
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

	}
}
