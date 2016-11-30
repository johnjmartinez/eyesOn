using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='BaseLoaderCallback']"
	[global::Android.Runtime.Register ("org/opencv/android/BaseLoaderCallback", DoNotGenerateAcw=true)]
	public abstract partial class BaseLoaderCallback : global::Java.Lang.Object, global::OpenCV.Android.ILoaderCallbackInterface {


		static IntPtr mAppContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='BaseLoaderCallback']/field[@name='mAppContext']"
		[Register ("mAppContext")]
		protected global::Android.Content.Context MAppContext {
			get {
				if (mAppContext_jfieldId == IntPtr.Zero)
					mAppContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAppContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAppContext_jfieldId == IntPtr.Zero)
					mAppContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAppContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.opencv.android.LoaderCallbackInterface

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/field[@name='INCOMPATIBLE_MANAGER_VERSION']"
			[Register ("INCOMPATIBLE_MANAGER_VERSION")]
			public const int IncompatibleManagerVersion = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/field[@name='INIT_FAILED']"
			[Register ("INIT_FAILED")]
			public const int InitFailed = (int) 255;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/field[@name='INSTALL_CANCELED']"
			[Register ("INSTALL_CANCELED")]
			public const int InstallCanceled = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/field[@name='MARKET_ERROR']"
			[Register ("MARKET_ERROR")]
			public const int MarketError = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public const int Success = (int) 0;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/BaseLoaderCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseLoaderCallback); }
		}

		protected BaseLoaderCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='BaseLoaderCallback']/constructor[@name='BaseLoaderCallback' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BaseLoaderCallback (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseLoaderCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_onManagerConnected_I;
#pragma warning disable 0169
		static Delegate GetOnManagerConnected_IHandler ()
		{
			if (cb_onManagerConnected_I == null)
				cb_onManagerConnected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnManagerConnected_I);
			return cb_onManagerConnected_I;
		}

		static void n_OnManagerConnected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Android.BaseLoaderCallback __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.BaseLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnManagerConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onManagerConnected_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='BaseLoaderCallback']/method[@name='onManagerConnected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onManagerConnected", "(I)V", "GetOnManagerConnected_IHandler")]
		public virtual unsafe void OnManagerConnected (int p0)
		{
			if (id_onManagerConnected_I == IntPtr.Zero)
				id_onManagerConnected_I = JNIEnv.GetMethodID (class_ref, "onManagerConnected", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onManagerConnected_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onManagerConnected", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_;
#pragma warning disable 0169
		static Delegate GetOnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_Handler ()
		{
			if (cb_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ == null)
				cb_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_);
			return cb_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_;
		}

		static void n_OnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::OpenCV.Android.BaseLoaderCallback __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.BaseLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Android.IInstallCallbackInterface p1 = (global::OpenCV.Android.IInstallCallbackInterface)global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPackageInstall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='BaseLoaderCallback']/method[@name='onPackageInstall' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.android.InstallCallbackInterface']]"
		[Register ("onPackageInstall", "(ILorg/opencv/android/InstallCallbackInterface;)V", "GetOnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_Handler")]
		public virtual unsafe void OnPackageInstall (int p0, global::OpenCV.Android.IInstallCallbackInterface p1)
		{
			if (id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ == IntPtr.Zero)
				id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ = JNIEnv.GetMethodID (class_ref, "onPackageInstall", "(ILorg/opencv/android/InstallCallbackInterface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPackageInstall", "(ILorg/opencv/android/InstallCallbackInterface;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/opencv/android/BaseLoaderCallback", DoNotGenerateAcw=true)]
	internal partial class BaseLoaderCallbackInvoker : BaseLoaderCallback {

		public BaseLoaderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseLoaderCallbackInvoker); }
		}

	}

}
