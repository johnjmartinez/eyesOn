using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']"
	[global::Android.Runtime.Register ("org/opencv/engine/OpenCVEngineInterface$Stub", DoNotGenerateAcw=true)]
	public abstract partial class OpenCVEngineInterfaceStub : global::Android.OS.Binder, global::OpenCV.Engine.IOpenCVEngineInterface {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']"
		[global::Android.Runtime.Register ("org/opencv/engine/OpenCVEngineInterface$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::OpenCV.Engine.IOpenCVEngineInterface {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/engine/OpenCVEngineInterface$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getEngineVersion;
#pragma warning disable 0169
			static Delegate GetGetEngineVersionHandler ()
			{
				if (cb_getEngineVersion == null)
					cb_getEngineVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEngineVersion);
				return cb_getEngineVersion;
			}

			static int n_GetEngineVersion (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EngineVersion;
			}
#pragma warning restore 0169

			static IntPtr id_getEngineVersion;
			public virtual unsafe int EngineVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='getEngineVersion' and count(parameter)=0]"
				[Register ("getEngineVersion", "()I", "GetGetEngineVersionHandler")]
				get {
					if (id_getEngineVersion == IntPtr.Zero)
						id_getEngineVersion = JNIEnv.GetMethodID (class_ref, "getEngineVersion", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEngineVersion);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEngineVersion", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceDescriptor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getLibPathByVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetLibPathByVersion_Ljava_lang_String_Handler ()
			{
				if (cb_getLibPathByVersion_Ljava_lang_String_ == null)
					cb_getLibPathByVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibPathByVersion_Ljava_lang_String_);
				return cb_getLibPathByVersion_Ljava_lang_String_;
			}

			static IntPtr n_GetLibPathByVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetLibPathByVersion (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getLibPathByVersion_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='getLibPathByVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibPathByVersion_Ljava_lang_String_Handler")]
			public virtual unsafe string GetLibPathByVersion (string p0)
			{
				if (id_getLibPathByVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_getLibPathByVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					string __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibPathByVersion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getLibraryList_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetLibraryList_Ljava_lang_String_Handler ()
			{
				if (cb_getLibraryList_Ljava_lang_String_ == null)
					cb_getLibraryList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryList_Ljava_lang_String_);
				return cb_getLibraryList_Ljava_lang_String_;
			}

			static IntPtr n_GetLibraryList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetLibraryList (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getLibraryList_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='getLibraryList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibraryList_Ljava_lang_String_Handler")]
			public virtual unsafe string GetLibraryList (string p0)
			{
				if (id_getLibraryList_Ljava_lang_String_ == IntPtr.Zero)
					id_getLibraryList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					string __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibraryList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_installVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInstallVersion_Ljava_lang_String_Handler ()
			{
				if (cb_installVersion_Ljava_lang_String_ == null)
					cb_installVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InstallVersion_Ljava_lang_String_);
				return cb_installVersion_Ljava_lang_String_;
			}

			static bool n_InstallVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.InstallVersion (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_installVersion_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub.Proxy']/method[@name='installVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("installVersion", "(Ljava/lang/String;)Z", "GetInstallVersion_Ljava_lang_String_Handler")]
			public virtual unsafe bool InstallVersion (string p0)
			{
				if (id_installVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_installVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "installVersion", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_installVersion_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "installVersion", "(Ljava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/engine/OpenCVEngineInterface$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenCVEngineInterfaceStub); }
		}

		protected OpenCVEngineInterfaceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/constructor[@name='OpenCVEngineInterface.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenCVEngineInterfaceStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OpenCVEngineInterfaceStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lorg/opencv/engine/OpenCVEngineInterface;", "")]
		public static unsafe global::OpenCV.Engine.IOpenCVEngineInterface AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lorg/opencv/engine/OpenCVEngineInterface;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Engine.IOpenCVEngineInterface __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLibPathByVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibPathByVersion_Ljava_lang_String_Handler ()
		{
			if (cb_getLibPathByVersion_Ljava_lang_String_ == null)
				cb_getLibPathByVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibPathByVersion_Ljava_lang_String_);
			return cb_getLibPathByVersion_Ljava_lang_String_;
		}

		static IntPtr n_GetLibPathByVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLibPathByVersion (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibPathByVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibPathByVersion_Ljava_lang_String_Handler")]
		public abstract string GetLibPathByVersion (string p0);

		static Delegate cb_getLibraryList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibraryList_Ljava_lang_String_Handler ()
		{
			if (cb_getLibraryList_Ljava_lang_String_ == null)
				cb_getLibraryList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryList_Ljava_lang_String_);
			return cb_getLibraryList_Ljava_lang_String_;
		}

		static IntPtr n_GetLibraryList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLibraryList (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibraryList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibraryList_Ljava_lang_String_Handler")]
		public abstract string GetLibraryList (string p0);

		static Delegate cb_installVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInstallVersion_Ljava_lang_String_Handler ()
		{
			if (cb_installVersion_Ljava_lang_String_ == null)
				cb_installVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InstallVersion_Ljava_lang_String_);
			return cb_installVersion_Ljava_lang_String_;
		}

		static bool n_InstallVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InstallVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='installVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("installVersion", "(Ljava/lang/String;)Z", "GetInstallVersion_Ljava_lang_String_Handler")]
		public abstract bool InstallVersion (string p0);

		static Delegate cb_getEngineVersion;
#pragma warning disable 0169
		static Delegate GetGetEngineVersionHandler ()
		{
			if (cb_getEngineVersion == null)
				cb_getEngineVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEngineVersion);
			return cb_getEngineVersion;
		}

		static int n_GetEngineVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Engine.OpenCVEngineInterfaceStub __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.OpenCVEngineInterfaceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EngineVersion;
		}
#pragma warning restore 0169

		public abstract int EngineVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/method[@name='getEngineVersion' and count(parameter)=0]"
			[Register ("getEngineVersion", "()I", "GetGetEngineVersionHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("org/opencv/engine/OpenCVEngineInterface$Stub", DoNotGenerateAcw=true)]
	internal partial class OpenCVEngineInterfaceStubInvoker : OpenCVEngineInterfaceStub {

		public OpenCVEngineInterfaceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenCVEngineInterfaceStubInvoker); }
		}

		static IntPtr id_getEngineVersion;
		public override unsafe int EngineVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/class[@name='OpenCVEngineInterface.Stub']/method[@name='getEngineVersion' and count(parameter)=0]"
			[Register ("getEngineVersion", "()I", "GetGetEngineVersionHandler")]
			get {
				if (id_getEngineVersion == IntPtr.Zero)
					id_getEngineVersion = JNIEnv.GetMethodID (class_ref, "getEngineVersion", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEngineVersion);
				} finally {
				}
			}
		}

		static IntPtr id_getLibPathByVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibPathByVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibPathByVersion_Ljava_lang_String_Handler")]
		public override unsafe string GetLibPathByVersion (string p0)
		{
			if (id_getLibPathByVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_getLibPathByVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibPathByVersion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLibraryList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibraryList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibraryList_Ljava_lang_String_Handler")]
		public override unsafe string GetLibraryList (string p0)
		{
			if (id_getLibraryList_Ljava_lang_String_ == IntPtr.Zero)
				id_getLibraryList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibraryList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_installVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='installVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("installVersion", "(Ljava/lang/String;)Z", "GetInstallVersion_Ljava_lang_String_Handler")]
		public override unsafe bool InstallVersion (string p0)
		{
			if (id_installVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_installVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "installVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_installVersion_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']"
	[Register ("org/opencv/engine/OpenCVEngineInterface", "", "OpenCV.Engine.IOpenCVEngineInterfaceInvoker")]
	public partial interface IOpenCVEngineInterface : global::Android.OS.IInterface {

		int EngineVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getEngineVersion' and count(parameter)=0]"
			[Register ("getEngineVersion", "()I", "GetGetEngineVersionHandler:OpenCV.Engine.IOpenCVEngineInterfaceInvoker, OpenCV")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibPathByVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibPathByVersion_Ljava_lang_String_Handler:OpenCV.Engine.IOpenCVEngineInterfaceInvoker, OpenCV")]
		string GetLibPathByVersion (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='getLibraryList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLibraryList_Ljava_lang_String_Handler:OpenCV.Engine.IOpenCVEngineInterfaceInvoker, OpenCV")]
		string GetLibraryList (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.engine']/interface[@name='OpenCVEngineInterface']/method[@name='installVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("installVersion", "(Ljava/lang/String;)Z", "GetInstallVersion_Ljava_lang_String_Handler:OpenCV.Engine.IOpenCVEngineInterfaceInvoker, OpenCV")]
		bool InstallVersion (string p0);

	}

	[global::Android.Runtime.Register ("org/opencv/engine/OpenCVEngineInterface", DoNotGenerateAcw=true)]
	internal class IOpenCVEngineInterfaceInvoker : global::Java.Lang.Object, IOpenCVEngineInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/engine/OpenCVEngineInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOpenCVEngineInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IOpenCVEngineInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOpenCVEngineInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.opencv.engine.OpenCVEngineInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOpenCVEngineInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEngineVersion;
#pragma warning disable 0169
		static Delegate GetGetEngineVersionHandler ()
		{
			if (cb_getEngineVersion == null)
				cb_getEngineVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEngineVersion);
			return cb_getEngineVersion;
		}

		static int n_GetEngineVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Engine.IOpenCVEngineInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EngineVersion;
		}
#pragma warning restore 0169

		IntPtr id_getEngineVersion;
		public unsafe int EngineVersion {
			get {
				if (id_getEngineVersion == IntPtr.Zero)
					id_getEngineVersion = JNIEnv.GetMethodID (class_ref, "getEngineVersion", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEngineVersion);
			}
		}

		static Delegate cb_getLibPathByVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibPathByVersion_Ljava_lang_String_Handler ()
		{
			if (cb_getLibPathByVersion_Ljava_lang_String_ == null)
				cb_getLibPathByVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibPathByVersion_Ljava_lang_String_);
			return cb_getLibPathByVersion_Ljava_lang_String_;
		}

		static IntPtr n_GetLibPathByVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.IOpenCVEngineInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLibPathByVersion (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLibPathByVersion_Ljava_lang_String_;
		public unsafe string GetLibPathByVersion (string p0)
		{
			if (id_getLibPathByVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_getLibPathByVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibPathByVersion", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibPathByVersion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLibraryList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLibraryList_Ljava_lang_String_Handler ()
		{
			if (cb_getLibraryList_Ljava_lang_String_ == null)
				cb_getLibraryList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLibraryList_Ljava_lang_String_);
			return cb_getLibraryList_Ljava_lang_String_;
		}

		static IntPtr n_GetLibraryList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.IOpenCVEngineInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLibraryList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLibraryList_Ljava_lang_String_;
		public unsafe string GetLibraryList (string p0)
		{
			if (id_getLibraryList_Ljava_lang_String_ == IntPtr.Zero)
				id_getLibraryList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLibraryList", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLibraryList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_installVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInstallVersion_Ljava_lang_String_Handler ()
		{
			if (cb_installVersion_Ljava_lang_String_ == null)
				cb_installVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InstallVersion_Ljava_lang_String_);
			return cb_installVersion_Ljava_lang_String_;
		}

		static bool n_InstallVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Engine.IOpenCVEngineInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InstallVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_installVersion_Ljava_lang_String_;
		public unsafe bool InstallVersion (string p0)
		{
			if (id_installVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_installVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "installVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_installVersion_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Engine.IOpenCVEngineInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Engine.IOpenCVEngineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
