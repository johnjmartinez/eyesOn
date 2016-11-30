using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	[Register ("org/opencv/android/InstallCallbackInterface", DoNotGenerateAcw=true)]
	public abstract class InstallCallbackInterface : Java.Lang.Object {

		internal InstallCallbackInterface ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/field[@name='INSTALLATION_PROGRESS']"
		[Register ("INSTALLATION_PROGRESS")]
		public const int InstallationProgress = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/field[@name='NEW_INSTALLATION']"
		[Register ("NEW_INSTALLATION")]
		public const int NewInstallation = (int) 0;
	}

	[Register ("org/opencv/android/InstallCallbackInterface", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'InstallCallbackInterface' type. This type will be removed in a future release.")]
	public abstract class InstallCallbackInterfaceConsts : InstallCallbackInterface {

		private InstallCallbackInterfaceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']"
	[Register ("org/opencv/android/InstallCallbackInterface", "", "OpenCV.Android.IInstallCallbackInterfaceInvoker")]
	public partial interface IInstallCallbackInterface : IJavaObject {

		string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler:OpenCV.Android.IInstallCallbackInterfaceInvoker, OpenCV")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:OpenCV.Android.IInstallCallbackInterfaceInvoker, OpenCV")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/method[@name='install' and count(parameter)=0]"
		[Register ("install", "()V", "GetInstallHandler:OpenCV.Android.IInstallCallbackInterfaceInvoker, OpenCV")]
		void Install ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='InstallCallbackInterface']/method[@name='wait_install' and count(parameter)=0]"
		[Register ("wait_install", "()V", "GetWait_installHandler:OpenCV.Android.IInstallCallbackInterfaceInvoker, OpenCV")]
		void Wait_install ();

	}

	[global::Android.Runtime.Register ("org/opencv/android/InstallCallbackInterface", DoNotGenerateAcw=true)]
	internal class IInstallCallbackInterfaceInvoker : global::Java.Lang.Object, IInstallCallbackInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/InstallCallbackInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInstallCallbackInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IInstallCallbackInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstallCallbackInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.InstallCallbackInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstallCallbackInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.IInstallCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		IntPtr id_getPackageName;
		public unsafe string PackageName {
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.IInstallCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_install;
#pragma warning disable 0169
		static Delegate GetInstallHandler ()
		{
			if (cb_install == null)
				cb_install = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Install);
			return cb_install;
		}

		static void n_Install (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.IInstallCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Install ();
		}
#pragma warning restore 0169

		IntPtr id_install;
		public unsafe void Install ()
		{
			if (id_install == IntPtr.Zero)
				id_install = JNIEnv.GetMethodID (class_ref, "install", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_install);
		}

		static Delegate cb_wait_install;
#pragma warning disable 0169
		static Delegate GetWait_installHandler ()
		{
			if (cb_wait_install == null)
				cb_wait_install = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Wait_install);
			return cb_wait_install;
		}

		static void n_Wait_install (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.IInstallCallbackInterface __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.IInstallCallbackInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Wait_install ();
		}
#pragma warning restore 0169

		IntPtr id_wait_install;
		public unsafe void Wait_install ()
		{
			if (id_wait_install == IntPtr.Zero)
				id_wait_install = JNIEnv.GetMethodID (class_ref, "wait_install", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_wait_install);
		}

	}

}
