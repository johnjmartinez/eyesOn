using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	[Register ("org/opencv/android/LoaderCallbackInterface", DoNotGenerateAcw=true)]
	public abstract class LoaderCallbackInterface : Java.Lang.Object {

		internal LoaderCallbackInterface ()
		{
		}

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

	[Register ("org/opencv/android/LoaderCallbackInterface", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LoaderCallbackInterface' type. This type will be removed in a future release.")]
	public abstract class LoaderCallbackInterfaceConsts : LoaderCallbackInterface {

		private LoaderCallbackInterfaceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']"
	[Register ("org/opencv/android/LoaderCallbackInterface", "", "OpenCV.Android.ILoaderCallbackInterfaceInvoker")]
	public partial interface ILoaderCallbackInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/method[@name='onManagerConnected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onManagerConnected", "(I)V", "GetOnManagerConnected_IHandler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV")]
		void OnManagerConnected (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='LoaderCallbackInterface']/method[@name='onPackageInstall' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.android.InstallCallbackInterface']]"
		[Register ("onPackageInstall", "(ILorg/opencv/android/InstallCallbackInterface;)V", "GetOnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_Handler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV")]
		void OnPackageInstall (int p0, global::OpenCV.Android.IInstallCallbackInterface p1);

	}

	[global::Android.Runtime.Register ("org/opencv/android/LoaderCallbackInterface", DoNotGenerateAcw=true)]
	internal class ILoaderCallbackInterfaceInvoker : global::Java.Lang.Object, ILoaderCallbackInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/LoaderCallbackInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoaderCallbackInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static ILoaderCallbackInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoaderCallbackInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.LoaderCallbackInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoaderCallbackInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::OpenCV.Android.ILoaderCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.ILoaderCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnManagerConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onManagerConnected_I;
		public unsafe void OnManagerConnected (int p0)
		{
			if (id_onManagerConnected_I == IntPtr.Zero)
				id_onManagerConnected_I = JNIEnv.GetMethodID (class_ref, "onManagerConnected", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onManagerConnected_I, __args);
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
			global::OpenCV.Android.ILoaderCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.ILoaderCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Android.IInstallCallbackInterface p1 = (global::OpenCV.Android.IInstallCallbackInterface)global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPackageInstall (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_;
		public unsafe void OnPackageInstall (int p0, global::OpenCV.Android.IInstallCallbackInterface p1)
		{
			if (id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ == IntPtr.Zero)
				id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_ = JNIEnv.GetMethodID (class_ref, "onPackageInstall", "(ILorg/opencv/android/InstallCallbackInterface;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPackageInstall_ILorg_opencv_android_InstallCallbackInterface_, __args);
		}

	}

}
