using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']"
	[global::Android.Runtime.Register ("org/opencv/android/CameraGLRendererBase", DoNotGenerateAcw=true)]
	public abstract partial class CameraGLRendererBase : global::Java.Lang.Object, global::Android.Graphics.SurfaceTexture.IOnFrameAvailableListener, global::Android.Opengl.GLSurfaceView.IRenderer {


		static IntPtr LOGTAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		protected string Logtag {
			get {
				if (LOGTAG_jfieldId == IntPtr.Zero)
					LOGTAG_jfieldId = JNIEnv.GetFieldID (class_ref, "LOGTAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, LOGTAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOGTAG_jfieldId == IntPtr.Zero)
					LOGTAG_jfieldId = JNIEnv.GetFieldID (class_ref, "LOGTAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, LOGTAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCameraHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mCameraHeight']"
		[Register ("mCameraHeight")]
		protected int MCameraHeight {
			get {
				if (mCameraHeight_jfieldId == IntPtr.Zero)
					mCameraHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCameraHeight_jfieldId);
			}
			set {
				if (mCameraHeight_jfieldId == IntPtr.Zero)
					mCameraHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCameraHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCameraIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mCameraIndex']"
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

		static IntPtr mCameraWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mCameraWidth']"
		[Register ("mCameraWidth")]
		protected int MCameraWidth {
			get {
				if (mCameraWidth_jfieldId == IntPtr.Zero)
					mCameraWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCameraWidth_jfieldId);
			}
			set {
				if (mCameraWidth_jfieldId == IntPtr.Zero)
					mCameraWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCameraWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mEnabled']"
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

		static IntPtr mFBOHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mFBOHeight']"
		[Register ("mFBOHeight")]
		protected int MFBOHeight {
			get {
				if (mFBOHeight_jfieldId == IntPtr.Zero)
					mFBOHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mFBOHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFBOHeight_jfieldId);
			}
			set {
				if (mFBOHeight_jfieldId == IntPtr.Zero)
					mFBOHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mFBOHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFBOHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFBOWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mFBOWidth']"
		[Register ("mFBOWidth")]
		protected int MFBOWidth {
			get {
				if (mFBOWidth_jfieldId == IntPtr.Zero)
					mFBOWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mFBOWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFBOWidth_jfieldId);
			}
			set {
				if (mFBOWidth_jfieldId == IntPtr.Zero)
					mFBOWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mFBOWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFBOWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHaveFBO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mHaveFBO']"
		[Register ("mHaveFBO")]
		protected bool MHaveFBO {
			get {
				if (mHaveFBO_jfieldId == IntPtr.Zero)
					mHaveFBO_jfieldId = JNIEnv.GetFieldID (class_ref, "mHaveFBO", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mHaveFBO_jfieldId);
			}
			set {
				if (mHaveFBO_jfieldId == IntPtr.Zero)
					mHaveFBO_jfieldId = JNIEnv.GetFieldID (class_ref, "mHaveFBO", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHaveFBO_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHaveSurface_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mHaveSurface']"
		[Register ("mHaveSurface")]
		protected bool MHaveSurface {
			get {
				if (mHaveSurface_jfieldId == IntPtr.Zero)
					mHaveSurface_jfieldId = JNIEnv.GetFieldID (class_ref, "mHaveSurface", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mHaveSurface_jfieldId);
			}
			set {
				if (mHaveSurface_jfieldId == IntPtr.Zero)
					mHaveSurface_jfieldId = JNIEnv.GetFieldID (class_ref, "mHaveSurface", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHaveSurface_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mIsStarted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mIsStarted']"
		[Register ("mIsStarted")]
		protected bool MIsStarted {
			get {
				if (mIsStarted_jfieldId == IntPtr.Zero)
					mIsStarted_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsStarted", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsStarted_jfieldId);
			}
			set {
				if (mIsStarted_jfieldId == IntPtr.Zero)
					mIsStarted_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsStarted", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsStarted_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxCameraHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mMaxCameraHeight']"
		[Register ("mMaxCameraHeight")]
		protected int MMaxCameraHeight {
			get {
				if (mMaxCameraHeight_jfieldId == IntPtr.Zero)
					mMaxCameraHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxCameraHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMaxCameraHeight_jfieldId);
			}
			set {
				if (mMaxCameraHeight_jfieldId == IntPtr.Zero)
					mMaxCameraHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxCameraHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxCameraHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxCameraWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mMaxCameraWidth']"
		[Register ("mMaxCameraWidth")]
		protected int MMaxCameraWidth {
			get {
				if (mMaxCameraWidth_jfieldId == IntPtr.Zero)
					mMaxCameraWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxCameraWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMaxCameraWidth_jfieldId);
			}
			set {
				if (mMaxCameraWidth_jfieldId == IntPtr.Zero)
					mMaxCameraWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxCameraWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxCameraWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSTexture_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mSTexture']"
		[Register ("mSTexture")]
		protected global::Android.Graphics.SurfaceTexture MSTexture {
			get {
				if (mSTexture_jfieldId == IntPtr.Zero)
					mSTexture_jfieldId = JNIEnv.GetFieldID (class_ref, "mSTexture", "Landroid/graphics/SurfaceTexture;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSTexture_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSTexture_jfieldId == IntPtr.Zero)
					mSTexture_jfieldId = JNIEnv.GetFieldID (class_ref, "mSTexture", "Landroid/graphics/SurfaceTexture;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSTexture_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUpdateST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mUpdateST']"
		[Register ("mUpdateST")]
		protected bool MUpdateST {
			get {
				if (mUpdateST_jfieldId == IntPtr.Zero)
					mUpdateST_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpdateST", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mUpdateST_jfieldId);
			}
			set {
				if (mUpdateST_jfieldId == IntPtr.Zero)
					mUpdateST_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpdateST", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUpdateST_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/field[@name='mView']"
		[Register ("mView")]
		protected global::OpenCV.Android.CameraGLSurfaceView MView {
			get {
				if (mView_jfieldId == IntPtr.Zero)
					mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Lorg/opencv/android/CameraGLSurfaceView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mView_jfieldId == IntPtr.Zero)
					mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Lorg/opencv/android/CameraGLSurfaceView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/CameraGLRendererBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraGLRendererBase); }
		}

		protected CameraGLRendererBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_opencv_android_CameraGLSurfaceView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/constructor[@name='CameraGLRendererBase' and count(parameter)=1 and parameter[1][@type='org.opencv.android.CameraGLSurfaceView']]"
		[Register (".ctor", "(Lorg/opencv/android/CameraGLSurfaceView;)V", "")]
		public unsafe CameraGLRendererBase (global::OpenCV.Android.CameraGLSurfaceView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CameraGLRendererBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/android/CameraGLSurfaceView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/android/CameraGLSurfaceView;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_android_CameraGLSurfaceView_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_android_CameraGLSurfaceView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/android/CameraGLSurfaceView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_android_CameraGLSurfaceView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_android_CameraGLSurfaceView_, __args);
			} finally {
			}
		}

		static Delegate cb_closeCamera;
#pragma warning disable 0169
		static Delegate GetCloseCameraHandler ()
		{
			if (cb_closeCamera == null)
				cb_closeCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseCamera);
			return cb_closeCamera;
		}

		static void n_CloseCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseCamera ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='closeCamera' and count(parameter)=0]"
		[Register ("closeCamera", "()V", "GetCloseCameraHandler")]
		protected abstract void CloseCamera ();

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
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableView ();
		}
#pragma warning restore 0169

		static IntPtr id_disableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='disableView' and count(parameter)=0]"
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

		static Delegate cb_doStart;
#pragma warning disable 0169
		static Delegate GetDoStartHandler ()
		{
			if (cb_doStart == null)
				cb_doStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoStart);
			return cb_doStart;
		}

		static void n_DoStart (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoStart ();
		}
#pragma warning restore 0169

		static IntPtr id_doStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='doStart' and count(parameter)=0]"
		[Register ("doStart", "()V", "GetDoStartHandler")]
		protected virtual unsafe void DoStart ()
		{
			if (id_doStart == IntPtr.Zero)
				id_doStart = JNIEnv.GetMethodID (class_ref, "doStart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_doStop;
#pragma warning disable 0169
		static Delegate GetDoStopHandler ()
		{
			if (cb_doStop == null)
				cb_doStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoStop);
			return cb_doStop;
		}

		static void n_DoStop (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoStop ();
		}
#pragma warning restore 0169

		static IntPtr id_doStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='doStop' and count(parameter)=0]"
		[Register ("doStop", "()V", "GetDoStopHandler")]
		protected virtual unsafe void DoStop ()
		{
			if (id_doStop == IntPtr.Zero)
				id_doStop = JNIEnv.GetMethodID (class_ref, "doStop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doStop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doStop", "()V"));
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
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableView ();
		}
#pragma warning restore 0169

		static IntPtr id_enableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='enableView' and count(parameter)=0]"
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

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
		{
			if (id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetMethodID (class_ref, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ == null)
				cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_);
			return cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onFrameAvailable' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnFrameAvailable (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onFrameAvailable_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onFrameAvailable_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameAvailable_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, int p1, int p2)
		{
			if (id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == IntPtr.Zero)
				id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNIEnv.GetMethodID (class_ref, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLConfig p1)
		{
			if (id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
				id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openCamera_I;
#pragma warning disable 0169
		static Delegate GetOpenCamera_IHandler ()
		{
			if (cb_openCamera_I == null)
				cb_openCamera_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OpenCamera_I);
			return cb_openCamera_I;
		}

		static void n_OpenCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenCamera (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='openCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openCamera", "(I)V", "GetOpenCamera_IHandler")]
		protected abstract void OpenCamera (int p0);

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
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='setCameraIndex' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_setCameraPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewSize_IIHandler ()
		{
			if (cb_setCameraPreviewSize_II == null)
				cb_setCameraPreviewSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetCameraPreviewSize_II);
			return cb_setCameraPreviewSize_II;
		}

		static void n_SetCameraPreviewSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='setCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCameraPreviewSize", "(II)V", "GetSetCameraPreviewSize_IIHandler")]
		protected abstract void SetCameraPreviewSize (int p0, int p1);

		static Delegate cb_setMaxCameraPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetMaxCameraPreviewSize_IIHandler ()
		{
			if (cb_setMaxCameraPreviewSize_II == null)
				cb_setMaxCameraPreviewSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetMaxCameraPreviewSize_II);
			return cb_setMaxCameraPreviewSize_II;
		}

		static void n_SetMaxCameraPreviewSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxCameraPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxCameraPreviewSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='setMaxCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setMaxCameraPreviewSize", "(II)V", "GetSetMaxCameraPreviewSize_IIHandler")]
		public virtual unsafe void SetMaxCameraPreviewSize (int p0, int p1)
		{
			if (id_setMaxCameraPreviewSize_II == IntPtr.Zero)
				id_setMaxCameraPreviewSize_II = JNIEnv.GetMethodID (class_ref, "setMaxCameraPreviewSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxCameraPreviewSize_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCameraPreviewSize", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetPreviewSize_IIHandler ()
		{
			if (cb_setPreviewSize_II == null)
				cb_setPreviewSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetPreviewSize_II);
			return cb_setPreviewSize_II;
		}

		static void n_SetPreviewSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPreviewSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='setPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setPreviewSize", "(II)V", "GetSetPreviewSize_IIHandler")]
		protected virtual unsafe void SetPreviewSize (int p0, int p1)
		{
			if (id_setPreviewSize_II == IntPtr.Zero)
				id_setPreviewSize_II = JNIEnv.GetMethodID (class_ref, "setPreviewSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviewSize_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviewSize", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateState;
#pragma warning disable 0169
		static Delegate GetUpdateStateHandler ()
		{
			if (cb_updateState == null)
				cb_updateState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateState);
			return cb_updateState;
		}

		static void n_UpdateState (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLRendererBase __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLRendererBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateState ();
		}
#pragma warning restore 0169

		static IntPtr id_updateState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='updateState' and count(parameter)=0]"
		[Register ("updateState", "()V", "GetUpdateStateHandler")]
		protected virtual unsafe void UpdateState ()
		{
			if (id_updateState == IntPtr.Zero)
				id_updateState = JNIEnv.GetMethodID (class_ref, "updateState", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateState);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateState", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/opencv/android/CameraGLRendererBase", DoNotGenerateAcw=true)]
	internal partial class CameraGLRendererBaseInvoker : CameraGLRendererBase {

		public CameraGLRendererBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraGLRendererBaseInvoker); }
		}

		static IntPtr id_closeCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='closeCamera' and count(parameter)=0]"
		[Register ("closeCamera", "()V", "GetCloseCameraHandler")]
		protected override unsafe void CloseCamera ()
		{
			if (id_closeCamera == IntPtr.Zero)
				id_closeCamera = JNIEnv.GetMethodID (class_ref, "closeCamera", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeCamera);
			} finally {
			}
		}

		static IntPtr id_openCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='openCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openCamera", "(I)V", "GetOpenCamera_IHandler")]
		protected override unsafe void OpenCamera (int p0)
		{
			if (id_openCamera_I == IntPtr.Zero)
				id_openCamera_I = JNIEnv.GetMethodID (class_ref, "openCamera", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openCamera_I, __args);
			} finally {
			}
		}

		static IntPtr id_setCameraPreviewSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLRendererBase']/method[@name='setCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCameraPreviewSize", "(II)V", "GetSetCameraPreviewSize_IIHandler")]
		protected override unsafe void SetCameraPreviewSize (int p0, int p1)
		{
			if (id_setCameraPreviewSize_II == IntPtr.Zero)
				id_setCameraPreviewSize_II = JNIEnv.GetMethodID (class_ref, "setCameraPreviewSize", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraPreviewSize_II, __args);
			} finally {
			}
		}

	}

}
