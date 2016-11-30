using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']"
	[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase", DoNotGenerateAcw=true)]
	public abstract partial class CameraBridgeViewBase : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolderCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='CAMERA_ID_ANY']"
		[Register ("CAMERA_ID_ANY")]
		public const int CameraIdAny = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='CAMERA_ID_BACK']"
		[Register ("CAMERA_ID_BACK")]
		public const int CameraIdBack = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='CAMERA_ID_FRONT']"
		[Register ("CAMERA_ID_FRONT")]
		public const int CameraIdFront = (int) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='GRAY']"
		[Register ("GRAY")]
		public const int Gray = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='RGBA']"
		[Register ("RGBA")]
		public const int Rgba = (int) 1;

		static IntPtr mCameraIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mCameraIndex']"
		[Register ("mCameraIndex")]
		protected int MCameraIndex {
			get {
				if (mCameraIndex_jfieldId == IntPtr.Zero)
					mCameraIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraIndex", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCameraIndex_jfieldId);
			}
			set {
				if (mCameraIndex_jfieldId == IntPtr.Zero)
					mCameraIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraIndex", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCameraIndex_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mEnabled']"
		[Register ("mEnabled")]
		protected bool MEnabled {
			get {
				if (mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mEnabled_jfieldId);
			}
			set {
				if (mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEnabled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFpsMeter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mFpsMeter']"
		[Register ("mFpsMeter")]
		protected global::OpenCV.Android.FpsMeter MFpsMeter {
			get {
				if (mFpsMeter_jfieldId == IntPtr.Zero)
					mFpsMeter_jfieldId = JNIEnv.GetFieldID (class_ref, "mFpsMeter", "Lorg/opencv/android/FpsMeter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFpsMeter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Android.FpsMeter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFpsMeter_jfieldId == IntPtr.Zero)
					mFpsMeter_jfieldId = JNIEnv.GetFieldID (class_ref, "mFpsMeter", "Lorg/opencv/android/FpsMeter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFpsMeter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFrameHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mFrameHeight']"
		[Register ("mFrameHeight")]
		protected int MFrameHeight {
			get {
				if (mFrameHeight_jfieldId == IntPtr.Zero)
					mFrameHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFrameHeight_jfieldId);
			}
			set {
				if (mFrameHeight_jfieldId == IntPtr.Zero)
					mFrameHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFrameHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFrameWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mFrameWidth']"
		[Register ("mFrameWidth")]
		protected int MFrameWidth {
			get {
				if (mFrameWidth_jfieldId == IntPtr.Zero)
					mFrameWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFrameWidth_jfieldId);
			}
			set {
				if (mFrameWidth_jfieldId == IntPtr.Zero)
					mFrameWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFrameWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mMaxHeight']"
		[Register ("mMaxHeight")]
		protected int MMaxHeight {
			get {
				if (mMaxHeight_jfieldId == IntPtr.Zero)
					mMaxHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMaxHeight_jfieldId);
			}
			set {
				if (mMaxHeight_jfieldId == IntPtr.Zero)
					mMaxHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mMaxWidth']"
		[Register ("mMaxWidth")]
		protected int MMaxWidth {
			get {
				if (mMaxWidth_jfieldId == IntPtr.Zero)
					mMaxWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMaxWidth_jfieldId);
			}
			set {
				if (mMaxWidth_jfieldId == IntPtr.Zero)
					mMaxWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPreviewFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mPreviewFormat']"
		[Register ("mPreviewFormat")]
		protected int MPreviewFormat {
			get {
				if (mPreviewFormat_jfieldId == IntPtr.Zero)
					mPreviewFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewFormat", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mPreviewFormat_jfieldId);
			}
			set {
				if (mPreviewFormat_jfieldId == IntPtr.Zero)
					mPreviewFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewFormat", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreviewFormat_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/field[@name='mScale']"
		[Register ("mScale")]
		protected float MScale {
			get {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, mScale_jfieldId);
			}
			set {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mScale_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewFrame']"
		[Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewFrame", "", "OpenCV.Android.CameraBridgeViewBase/ICvCameraViewFrameInvoker")]
		public partial interface ICvCameraViewFrame : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewFrame']/method[@name='gray' and count(parameter)=0]"
			[Register ("gray", "()Lorg/opencv/core/Mat;", "GetGrayHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewFrameInvoker, OpenCV")]
			global::OpenCV.Core.Mat Gray ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewFrame']/method[@name='rgba' and count(parameter)=0]"
			[Register ("rgba", "()Lorg/opencv/core/Mat;", "GetRgbaHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewFrameInvoker, OpenCV")]
			global::OpenCV.Core.Mat Rgba ();

		}

		[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewFrame", DoNotGenerateAcw=true)]
		internal class ICvCameraViewFrameInvoker : global::Java.Lang.Object, ICvCameraViewFrame {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase$CvCameraViewFrame");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICvCameraViewFrameInvoker); }
			}

			IntPtr class_ref;

			public static ICvCameraViewFrame GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICvCameraViewFrame> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.CameraBridgeViewBase.CvCameraViewFrame"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICvCameraViewFrameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_gray;
#pragma warning disable 0169
			static Delegate GetGrayHandler ()
			{
				if (cb_gray == null)
					cb_gray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Gray);
				return cb_gray;
			}

			static IntPtr n_Gray (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Gray ());
			}
#pragma warning restore 0169

			IntPtr id_gray;
			public unsafe global::OpenCV.Core.Mat Gray ()
			{
				if (id_gray == IntPtr.Zero)
					id_gray = JNIEnv.GetMethodID (class_ref, "gray", "()Lorg/opencv/core/Mat;");
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_gray), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_rgba;
#pragma warning disable 0169
			static Delegate GetRgbaHandler ()
			{
				if (cb_rgba == null)
					cb_rgba = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Rgba);
				return cb_rgba;
			}

			static IntPtr n_Rgba (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Rgba ());
			}
#pragma warning restore 0169

			IntPtr id_rgba;
			public unsafe global::OpenCV.Core.Mat Rgba ()
			{
				if (id_rgba == IntPtr.Zero)
					id_rgba = JNIEnv.GetMethodID (class_ref, "rgba", "()Lorg/opencv/core/Mat;");
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rgba), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener']"
		[Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener", "", "OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker")]
		public partial interface ICvCameraViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener']/method[@name='onCameraFrame' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
			[Register ("onCameraFrame", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetOnCameraFrame_Lorg_opencv_core_Mat_Handler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV")]
			global::OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Core.Mat p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener']/method[@name='onCameraViewStarted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onCameraViewStarted", "(II)V", "GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV")]
			void OnCameraViewStarted (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener']/method[@name='onCameraViewStopped' and count(parameter)=0]"
			[Register ("onCameraViewStopped", "()V", "GetOnCameraViewStoppedHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV")]
			void OnCameraViewStopped ();

		}

		[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener", DoNotGenerateAcw=true)]
		internal class ICvCameraViewListenerInvoker : global::Java.Lang.Object, ICvCameraViewListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICvCameraViewListenerInvoker); }
			}

			IntPtr class_ref;

			public static ICvCameraViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICvCameraViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.CameraBridgeViewBase.CvCameraViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICvCameraViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraFrame_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
			static Delegate GetOnCameraFrame_Lorg_opencv_core_Mat_Handler ()
			{
				if (cb_onCameraFrame_Lorg_opencv_core_Mat_ == null)
					cb_onCameraFrame_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCameraFrame_Lorg_opencv_core_Mat_);
				return cb_onCameraFrame_Lorg_opencv_core_Mat_;
			}

			static IntPtr n_OnCameraFrame_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCameraFrame (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCameraFrame_Lorg_opencv_core_Mat_;
			public unsafe global::OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Core.Mat p0)
			{
				if (id_onCameraFrame_Lorg_opencv_core_Mat_ == IntPtr.Zero)
					id_onCameraFrame_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "onCameraFrame", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCameraFrame_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_onCameraViewStarted_II;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStarted_IIHandler ()
			{
				if (cb_onCameraViewStarted_II == null)
					cb_onCameraViewStarted_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnCameraViewStarted_II);
				return cb_onCameraViewStarted_II;
			}

			static void n_OnCameraViewStarted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStarted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCameraViewStarted_II;
			public unsafe void OnCameraViewStarted (int p0, int p1)
			{
				if (id_onCameraViewStarted_II == IntPtr.Zero)
					id_onCameraViewStarted_II = JNIEnv.GetMethodID (class_ref, "onCameraViewStarted", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStarted_II, __args);
			}

			static Delegate cb_onCameraViewStopped;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStoppedHandler ()
			{
				if (cb_onCameraViewStopped == null)
					cb_onCameraViewStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraViewStopped);
				return cb_onCameraViewStopped;
			}

			static void n_OnCameraViewStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStopped ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraViewStopped;
			public unsafe void OnCameraViewStopped ()
			{
				if (id_onCameraViewStopped == IntPtr.Zero)
					id_onCameraViewStopped = JNIEnv.GetMethodID (class_ref, "onCameraViewStopped", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStopped);
			}

		}

		public delegate global::OpenCV.Core.Mat CvCameraViewOnCameraFrameHandler (global::OpenCV.Core.Mat p0);

		public partial class CameraViewStartedEventArgs : global::System.EventArgs {

			public CameraViewStartedEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/opencv/android/CameraBridgeViewBase_CvCameraViewListenerImplementor")]
		internal sealed partial class ICvCameraViewListenerImplementor : global::Java.Lang.Object, ICvCameraViewListener {

			object sender;

			public ICvCameraViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/opencv/android/CameraBridgeViewBase_CvCameraViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public CvCameraViewOnCameraFrameHandler OnCameraFrameHandler;
#pragma warning restore 0649

			public OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Core.Mat p0)
			{
				var __h = OnCameraFrameHandler;
				return __h != null ? __h (p0) : default (global::OpenCV.Core.Mat);
			}
#pragma warning disable 0649
			public EventHandler<CameraViewStartedEventArgs> OnCameraViewStartedHandler;
#pragma warning restore 0649

			public void OnCameraViewStarted (int p0, int p1)
			{
				var __h = OnCameraViewStartedHandler;
				if (__h != null)
					__h (sender, new CameraViewStartedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnCameraViewStoppedHandler;
#pragma warning restore 0649

			public void OnCameraViewStopped ()
			{
				var __h = OnCameraViewStoppedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ICvCameraViewListenerImplementor value)
			{
				return value.OnCameraFrameHandler == null && value.OnCameraViewStartedHandler == null && value.OnCameraViewStoppedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener2']"
		[Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener2", "", "OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker")]
		public partial interface ICvCameraViewListener2 : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener2']/method[@name='onCameraViewStarted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onCameraViewStarted", "(II)V", "GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV")]
			void OnCameraViewStarted (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener2']/method[@name='onCameraViewStopped' and count(parameter)=0]"
			[Register ("onCameraViewStopped", "()V", "GetOnCameraViewStoppedHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV")]
			void OnCameraViewStopped ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.CvCameraViewListener2']/method[@name='onCameraFrame' and count(parameter)=1 and parameter[1][@type='org.opencv.android.CameraBridgeViewBase.CvCameraViewFrame']]"
			[global::Java.Interop.JavaInterfaceDefaultMethod]
			[Register ("onCameraFrame", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;", "GetOnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_Handler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV")]
			global::OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame inputFrame);

		}

		[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener2", DoNotGenerateAcw=true)]
		internal class ICvCameraViewListener2Invoker : global::Java.Lang.Object, ICvCameraViewListener2 {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListener2");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICvCameraViewListener2Invoker); }
			}

			IntPtr class_ref;

			public static ICvCameraViewListener2 GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICvCameraViewListener2> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.CameraBridgeViewBase.CvCameraViewListener2"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICvCameraViewListener2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraViewStarted_II;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStarted_IIHandler ()
			{
				if (cb_onCameraViewStarted_II == null)
					cb_onCameraViewStarted_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnCameraViewStarted_II);
				return cb_onCameraViewStarted_II;
			}

			static void n_OnCameraViewStarted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStarted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCameraViewStarted_II;
			public unsafe void OnCameraViewStarted (int p0, int p1)
			{
				if (id_onCameraViewStarted_II == IntPtr.Zero)
					id_onCameraViewStarted_II = JNIEnv.GetMethodID (class_ref, "onCameraViewStarted", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStarted_II, __args);
			}

			static Delegate cb_onCameraViewStopped;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStoppedHandler ()
			{
				if (cb_onCameraViewStopped == null)
					cb_onCameraViewStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraViewStopped);
				return cb_onCameraViewStopped;
			}

			static void n_OnCameraViewStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStopped ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraViewStopped;
			public unsafe void OnCameraViewStopped ()
			{
				if (id_onCameraViewStopped == IntPtr.Zero)
					id_onCameraViewStopped = JNIEnv.GetMethodID (class_ref, "onCameraViewStopped", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStopped);
			}

			static Delegate cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
#pragma warning disable 0169
			static Delegate GetOnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_Handler ()
			{
				if (cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ == null)
					cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_);
				return cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
			}

			static IntPtr n_OnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFrame)
			{
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame inputFrame = (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame)global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame> (native_inputFrame, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCameraFrame (inputFrame));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
			public unsafe global::OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame inputFrame)
			{
				if (id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ == IntPtr.Zero)
					id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ = JNIEnv.GetMethodID (class_ref, "onCameraFrame", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (inputFrame);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase.CvCameraViewListenerAdapter']"
		[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListenerAdapter", DoNotGenerateAcw=true)]
		protected internal partial class CvCameraViewListenerAdapter : global::Java.Lang.Object, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase$CvCameraViewListenerAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CvCameraViewListenerAdapter); }
			}

			protected CvCameraViewListenerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCameraViewStarted_II;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStarted_IIHandler ()
			{
				if (cb_onCameraViewStarted_II == null)
					cb_onCameraViewStarted_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnCameraViewStarted_II);
				return cb_onCameraViewStarted_II;
			}

			static void n_OnCameraViewStarted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStarted (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraViewStarted_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase.CvCameraViewListenerAdapter']/method[@name='onCameraViewStarted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onCameraViewStarted", "(II)V", "GetOnCameraViewStarted_IIHandler")]
			public virtual unsafe void OnCameraViewStarted (int p0, int p1)
			{
				if (id_onCameraViewStarted_II == IntPtr.Zero)
					id_onCameraViewStarted_II = JNIEnv.GetMethodID (class_ref, "onCameraViewStarted", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStarted_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraViewStarted", "(II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraViewStopped;
#pragma warning disable 0169
			static Delegate GetOnCameraViewStoppedHandler ()
			{
				if (cb_onCameraViewStopped == null)
					cb_onCameraViewStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraViewStopped);
				return cb_onCameraViewStopped;
			}

			static void n_OnCameraViewStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraViewStopped ();
			}
#pragma warning restore 0169

			static IntPtr id_onCameraViewStopped;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase.CvCameraViewListenerAdapter']/method[@name='onCameraViewStopped' and count(parameter)=0]"
			[Register ("onCameraViewStopped", "()V", "GetOnCameraViewStoppedHandler")]
			public virtual unsafe void OnCameraViewStopped ()
			{
				if (id_onCameraViewStopped == IntPtr.Zero)
					id_onCameraViewStopped = JNIEnv.GetMethodID (class_ref, "onCameraViewStopped", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraViewStopped);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraViewStopped", "()V"));
				} finally {
				}
			}

			static Delegate cb_setFrameFormat_I;
#pragma warning disable 0169
			static Delegate GetSetFrameFormat_IHandler ()
			{
				if (cb_setFrameFormat_I == null)
					cb_setFrameFormat_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFrameFormat_I);
				return cb_setFrameFormat_I;
			}

			static void n_SetFrameFormat_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetFrameFormat (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setFrameFormat_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase.CvCameraViewListenerAdapter']/method[@name='setFrameFormat' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFrameFormat", "(I)V", "GetSetFrameFormat_IHandler")]
			public virtual unsafe void SetFrameFormat (int p0)
			{
				if (id_setFrameFormat_I == IntPtr.Zero)
					id_setFrameFormat_I = JNIEnv.GetMethodID (class_ref, "setFrameFormat", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFrameFormat_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFrameFormat", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
#pragma warning disable 0169
			static Delegate GetOnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_Handler ()
			{
				if (cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ == null)
					cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_);
				return cb_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
			}

			static IntPtr n_OnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFrame)
			{
				global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame inputFrame = (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame)global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame> (native_inputFrame, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCameraFrame (inputFrame));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase.CvCameraViewListenerAdapter']/method[@name='onCameraFrame' and count(parameter)=1 and parameter[1][@type='org.opencv.android.CameraBridgeViewBase.CvCameraViewFrame']]"
			[Register ("onCameraFrame", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;", "GetOnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_Handler")]
			public virtual unsafe global::OpenCV.Core.Mat OnCameraFrame (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame inputFrame)
			{
				if (id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ == IntPtr.Zero)
					id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_ = JNIEnv.GetMethodID (class_ref, "onCameraFrame", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (inputFrame);

					global::OpenCV.Core.Mat __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraFrame", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.ListItemAccessor']"
		[Register ("org/opencv/android/CameraBridgeViewBase$ListItemAccessor", "", "OpenCV.Android.CameraBridgeViewBase/IListItemAccessorInvoker")]
		public partial interface IListItemAccessor : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.ListItemAccessor']/method[@name='getHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("getHeight", "(Ljava/lang/Object;)I", "GetGetHeight_Ljava_lang_Object_Handler:OpenCV.Android.CameraBridgeViewBase/IListItemAccessorInvoker, OpenCV")]
			int GetHeight (global::Java.Lang.Object p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraBridgeViewBase.ListItemAccessor']/method[@name='getWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("getWidth", "(Ljava/lang/Object;)I", "GetGetWidth_Ljava_lang_Object_Handler:OpenCV.Android.CameraBridgeViewBase/IListItemAccessorInvoker, OpenCV")]
			int GetWidth (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase$ListItemAccessor", DoNotGenerateAcw=true)]
		internal class IListItemAccessorInvoker : global::Java.Lang.Object, IListItemAccessor {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase$ListItemAccessor");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListItemAccessorInvoker); }
			}

			IntPtr class_ref;

			public static IListItemAccessor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListItemAccessor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.CameraBridgeViewBase.ListItemAccessor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListItemAccessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getHeight_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetHeight_Ljava_lang_Object_Handler ()
			{
				if (cb_getHeight_Ljava_lang_Object_ == null)
					cb_getHeight_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetHeight_Ljava_lang_Object_);
				return cb_getHeight_Ljava_lang_Object_;
			}

			static int n_GetHeight_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Android.CameraBridgeViewBase.IListItemAccessor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.IListItemAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetHeight (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getHeight_Ljava_lang_Object_;
			public unsafe int GetHeight (global::Java.Lang.Object p0)
			{
				if (id_getHeight_Ljava_lang_Object_ == IntPtr.Zero)
					id_getHeight_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getHeight", "(Ljava/lang/Object;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_getWidth_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetGetWidth_Ljava_lang_Object_Handler ()
			{
				if (cb_getWidth_Ljava_lang_Object_ == null)
					cb_getWidth_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetWidth_Ljava_lang_Object_);
				return cb_getWidth_Ljava_lang_Object_;
			}

			static int n_GetWidth_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::OpenCV.Android.CameraBridgeViewBase.IListItemAccessor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.IListItemAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetWidth (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getWidth_Ljava_lang_Object_;
			public unsafe int GetWidth (global::Java.Lang.Object p0)
			{
				if (id_getWidth_Ljava_lang_Object_ == IntPtr.Zero)
					id_getWidth_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getWidth", "(Ljava/lang/Object;)I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth_Ljava_lang_Object_, __args);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/CameraBridgeViewBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraBridgeViewBase); }
		}

		protected CameraBridgeViewBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/constructor[@name='CameraBridgeViewBase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe CameraBridgeViewBase (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CameraBridgeViewBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/constructor[@name='CameraBridgeViewBase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CameraBridgeViewBase (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CameraBridgeViewBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_AllocateCache;
#pragma warning disable 0169
		static Delegate GetAllocateCacheHandler ()
		{
			if (cb_AllocateCache == null)
				cb_AllocateCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AllocateCache);
			return cb_AllocateCache;
		}

		static void n_AllocateCache (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllocateCache ();
		}
#pragma warning restore 0169

		static IntPtr id_AllocateCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='AllocateCache' and count(parameter)=0]"
		[Register ("AllocateCache", "()V", "GetAllocateCacheHandler")]
		protected virtual unsafe void AllocateCache ()
		{
			if (id_AllocateCache == IntPtr.Zero)
				id_AllocateCache = JNIEnv.GetMethodID (class_ref, "AllocateCache", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AllocateCache);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "AllocateCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_SetCaptureFormat_I;
#pragma warning disable 0169
		static Delegate GetSetCaptureFormat_IHandler ()
		{
			if (cb_SetCaptureFormat_I == null)
				cb_SetCaptureFormat_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCaptureFormat_I);
			return cb_SetCaptureFormat_I;
		}

		static void n_SetCaptureFormat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCaptureFormat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_SetCaptureFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='SetCaptureFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetCaptureFormat", "(I)V", "GetSetCaptureFormat_IHandler")]
		public virtual unsafe void SetCaptureFormat (int p0)
		{
			if (id_SetCaptureFormat_I == IntPtr.Zero)
				id_SetCaptureFormat_I = JNIEnv.GetMethodID (class_ref, "SetCaptureFormat", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_SetCaptureFormat_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCaptureFormat", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectCamera_II;
#pragma warning disable 0169
		static Delegate GetConnectCamera_IIHandler ()
		{
			if (cb_connectCamera_II == null)
				cb_connectCamera_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_ConnectCamera_II);
			return cb_connectCamera_II;
		}

		static bool n_ConnectCamera_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectCamera (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='connectCamera' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("connectCamera", "(II)Z", "GetConnectCamera_IIHandler")]
		protected abstract bool ConnectCamera (int p0, int p1);

		static Delegate cb_disableFpsMeter;
#pragma warning disable 0169
		static Delegate GetDisableFpsMeterHandler ()
		{
			if (cb_disableFpsMeter == null)
				cb_disableFpsMeter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableFpsMeter);
			return cb_disableFpsMeter;
		}

		static void n_DisableFpsMeter (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableFpsMeter ();
		}
#pragma warning restore 0169

		static IntPtr id_disableFpsMeter;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='disableFpsMeter' and count(parameter)=0]"
		[Register ("disableFpsMeter", "()V", "GetDisableFpsMeterHandler")]
		public virtual unsafe void DisableFpsMeter ()
		{
			if (id_disableFpsMeter == IntPtr.Zero)
				id_disableFpsMeter = JNIEnv.GetMethodID (class_ref, "disableFpsMeter", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableFpsMeter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableFpsMeter", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableView;
#pragma warning disable 0169
		static Delegate GetDisableViewHandler ()
		{
			if (cb_disableView == null)
				cb_disableView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableView);
			return cb_disableView;
		}

		static void n_DisableView (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableView ();
		}
#pragma warning restore 0169

		static IntPtr id_disableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='disableView' and count(parameter)=0]"
		[Register ("disableView", "()V", "GetDisableViewHandler")]
		public virtual unsafe void DisableView ()
		{
			if (id_disableView == IntPtr.Zero)
				id_disableView = JNIEnv.GetMethodID (class_ref, "disableView", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableView);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableView", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectCamera;
#pragma warning disable 0169
		static Delegate GetDisconnectCameraHandler ()
		{
			if (cb_disconnectCamera == null)
				cb_disconnectCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectCamera);
			return cb_disconnectCamera;
		}

		static void n_DisconnectCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectCamera ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='disconnectCamera' and count(parameter)=0]"
		[Register ("disconnectCamera", "()V", "GetDisconnectCameraHandler")]
		protected abstract void DisconnectCamera ();

		static Delegate cb_enableFpsMeter;
#pragma warning disable 0169
		static Delegate GetEnableFpsMeterHandler ()
		{
			if (cb_enableFpsMeter == null)
				cb_enableFpsMeter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableFpsMeter);
			return cb_enableFpsMeter;
		}

		static void n_EnableFpsMeter (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableFpsMeter ();
		}
#pragma warning restore 0169

		static IntPtr id_enableFpsMeter;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='enableFpsMeter' and count(parameter)=0]"
		[Register ("enableFpsMeter", "()V", "GetEnableFpsMeterHandler")]
		public virtual unsafe void EnableFpsMeter ()
		{
			if (id_enableFpsMeter == IntPtr.Zero)
				id_enableFpsMeter = JNIEnv.GetMethodID (class_ref, "enableFpsMeter", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableFpsMeter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableFpsMeter", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableView;
#pragma warning disable 0169
		static Delegate GetEnableViewHandler ()
		{
			if (cb_enableView == null)
				cb_enableView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableView);
			return cb_enableView;
		}

		static void n_EnableView (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableView ();
		}
#pragma warning restore 0169

		static IntPtr id_enableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='enableView' and count(parameter)=0]"
		[Register ("enableView", "()V", "GetEnableViewHandler")]
		public virtual unsafe void EnableView ()
		{
			if (id_enableView == IntPtr.Zero)
				id_enableView = JNIEnv.GetMethodID (class_ref, "enableView", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableView);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableView", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCameraIndex_I;
#pragma warning disable 0169
		static Delegate GetSetCameraIndex_IHandler ()
		{
			if (cb_setCameraIndex_I == null)
				cb_setCameraIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCameraIndex_I);
			return cb_setCameraIndex_I;
		}

		static void n_SetCameraIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='setCameraIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCameraIndex", "(I)V", "GetSetCameraIndex_IHandler")]
		public virtual unsafe void SetCameraIndex (int p0)
		{
			if (id_setCameraIndex_I == IntPtr.Zero)
				id_setCameraIndex_I = JNIEnv.GetMethodID (class_ref, "setCameraIndex", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraIndex_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCameraIndex", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMaxFrameSize_II;
#pragma warning disable 0169
		static Delegate GetSetMaxFrameSize_IIHandler ()
		{
			if (cb_setMaxFrameSize_II == null)
				cb_setMaxFrameSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetMaxFrameSize_II);
			return cb_setMaxFrameSize_II;
		}

		static void n_SetMaxFrameSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxFrameSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxFrameSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='setMaxFrameSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMaxFrameSize", "(II)V", "GetSetMaxFrameSize_IIHandler")]
		public virtual unsafe void SetMaxFrameSize (int p0, int p1)
		{
			if (id_setMaxFrameSize_II == IntPtr.Zero)
				id_setMaxFrameSize_II = JNIEnv.GetMethodID (class_ref, "setMaxFrameSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxFrameSize_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxFrameSize", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_;
#pragma warning disable 0169
		static Delegate GetSetCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_Handler ()
		{
			if (cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_ == null)
				cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_);
			return cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_;
		}

		static void n_SetCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener listener = (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener)global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCvCameraViewListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='setCvCameraViewListener' and count(parameter)=1 and parameter[1][@type='org.opencv.android.CameraBridgeViewBase.CvCameraViewListener']]"
		[Register ("setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener;)V", "GetSetCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_Handler")]
		public virtual unsafe void SetCvCameraViewListener (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener listener)
		{
			if (id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_ == IntPtr.Zero)
				id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_ = JNIEnv.GetMethodID (class_ref, "setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_;
#pragma warning disable 0169
		static Delegate GetSetCvCameraViewListener2_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_Handler ()
		{
			if (cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_ == null)
				cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCvCameraViewListener2_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_);
			return cb_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_;
		}

		static void n_SetCvCameraViewListener2_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::OpenCV.Android.CameraBridgeViewBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 listener = (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2)global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetCvCameraViewListener2 (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='setCvCameraViewListener' and count(parameter)=1 and parameter[1][@type='org.opencv.android.CameraBridgeViewBase.CvCameraViewListener2']]"
		[Register ("setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener2;)V", "GetSetCvCameraViewListener2_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_Handler")]
		public virtual unsafe void SetCvCameraViewListener2 (global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener2 listener)
		{
			if (id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_ == IntPtr.Zero)
				id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_ = JNIEnv.GetMethodID (class_ref, "setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener2;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCvCameraViewListener_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewListener2_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCvCameraViewListener", "(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewListener2;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener"
		WeakReference weak_implementor_CameraFrame;
		global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor ImplCameraFrame {
			get {
				if (weak_implementor_CameraFrame == null || !weak_implementor_CameraFrame.IsAlive)
					return null;
				return weak_implementor_CameraFrame.Target as global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor;
			}
			set { weak_implementor_CameraFrame = new WeakReference (value, true); }
		}

		public global::OpenCV.Android.CameraBridgeViewBase.CvCameraViewOnCameraFrameHandler CameraFrame {
			get {
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor impl = ImplCameraFrame;
				return impl == null ? null : impl.OnCameraFrameHandler;
			}
			set {
				global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor impl = ImplCameraFrame;
				if (impl == null) {
					impl = new global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor (this);
					ImplCameraFrame = impl;
				} else
					impl.OnCameraFrameHandler = value;
			}
		}

		public event EventHandler<global::OpenCV.Android.CameraBridgeViewBase.CameraViewStartedEventArgs> CameraViewStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor>(
						ref weak_implementor_SetCvCameraViewListener,
						__CreateICvCameraViewListenerImplementor,
						SetCvCameraViewListener,
						__h => __h.OnCameraViewStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor>(
						ref weak_implementor_SetCvCameraViewListener,
						global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor.__IsEmpty,
						__v => SetCvCameraViewListener (null),
						__h => __h.OnCameraViewStartedHandler -= value);
			}
		}

		public event EventHandler CameraViewStopped {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor>(
						ref weak_implementor_SetCvCameraViewListener,
						__CreateICvCameraViewListenerImplementor,
						SetCvCameraViewListener,
						__h => __h.OnCameraViewStoppedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListener, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor>(
						ref weak_implementor_SetCvCameraViewListener,
						global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor.__IsEmpty,
						__v => SetCvCameraViewListener (null),
						__h => __h.OnCameraViewStoppedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetCvCameraViewListener;

		global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor __CreateICvCameraViewListenerImplementor ()
		{
			return new global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("org/opencv/android/CameraBridgeViewBase", DoNotGenerateAcw=true)]
	internal partial class CameraBridgeViewBaseInvoker : CameraBridgeViewBase {

		public CameraBridgeViewBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraBridgeViewBaseInvoker); }
		}

		static IntPtr id_connectCamera_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='connectCamera' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("connectCamera", "(II)Z", "GetConnectCamera_IIHandler")]
		protected override unsafe bool ConnectCamera (int p0, int p1)
		{
			if (id_connectCamera_II == IntPtr.Zero)
				id_connectCamera_II = JNIEnv.GetMethodID (class_ref, "connectCamera", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_connectCamera_II, __args);
			} finally {
			}
		}

		static IntPtr id_disconnectCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraBridgeViewBase']/method[@name='disconnectCamera' and count(parameter)=0]"
		[Register ("disconnectCamera", "()V", "GetDisconnectCameraHandler")]
		protected override unsafe void DisconnectCamera ()
		{
			if (id_disconnectCamera == IntPtr.Zero)
				id_disconnectCamera = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera);
			} finally {
			}
		}

	}

}
