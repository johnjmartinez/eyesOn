using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']"
	[global::Android.Runtime.Register ("org/opencv/android/CameraGLSurfaceView", DoNotGenerateAcw=true)]
	public partial class CameraGLSurfaceView : global::Android.Opengl.GLSurfaceView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraGLSurfaceView.CameraTextureListener']"
		[Register ("org/opencv/android/CameraGLSurfaceView$CameraTextureListener", "", "OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker")]
		public partial interface ICameraTextureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraGLSurfaceView.CameraTextureListener']/method[@name='onCameraTexture' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onCameraTexture", "(IIII)Z", "GetOnCameraTexture_IIIIHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV")]
			bool OnCameraTexture (int p0, int p1, int p2, int p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraGLSurfaceView.CameraTextureListener']/method[@name='onCameraViewStarted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onCameraViewStarted", "(II)V", "GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV")]
			void OnCameraViewStarted (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/interface[@name='CameraGLSurfaceView.CameraTextureListener']/method[@name='onCameraViewStopped' and count(parameter)=0]"
			[Register ("onCameraViewStopped", "()V", "GetOnCameraViewStoppedHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV")]
			void OnCameraViewStopped ();

		}

		[global::Android.Runtime.Register ("org/opencv/android/CameraGLSurfaceView$CameraTextureListener", DoNotGenerateAcw=true)]
		internal class ICameraTextureListenerInvoker : global::Java.Lang.Object, ICameraTextureListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/opencv/android/CameraGLSurfaceView$CameraTextureListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICameraTextureListenerInvoker); }
			}

			IntPtr class_ref;

			public static ICameraTextureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICameraTextureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.opencv.android.CameraGLSurfaceView.CameraTextureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICameraTextureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraTexture_IIII;
#pragma warning disable 0169
			static Delegate GetOnCameraTexture_IIIIHandler ()
			{
				if (cb_onCameraTexture_IIII == null)
					cb_onCameraTexture_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, bool>) n_OnCameraTexture_IIII);
				return cb_onCameraTexture_IIII;
			}

			static bool n_OnCameraTexture_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
			{
				global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnCameraTexture (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onCameraTexture_IIII;
			public unsafe bool OnCameraTexture (int p0, int p1, int p2, int p3)
			{
				if (id_onCameraTexture_IIII == IntPtr.Zero)
					id_onCameraTexture_IIII = JNIEnv.GetMethodID (class_ref, "onCameraTexture", "(IIII)Z");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCameraTexture_IIII, __args);
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
				global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		public partial class CameraTextureEventArgs : global::System.EventArgs {

			public CameraTextureEventArgs (bool handled, int p0, int p1, int p2, int p3)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

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

		[global::Android.Runtime.Register ("mono/org/opencv/android/CameraGLSurfaceView_CameraTextureListenerImplementor")]
		internal sealed partial class ICameraTextureListenerImplementor : global::Java.Lang.Object, ICameraTextureListener {

			object sender;

			public ICameraTextureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/opencv/android/CameraGLSurfaceView_CameraTextureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraTextureEventArgs> OnCameraTextureHandler;
#pragma warning restore 0649

			public bool OnCameraTexture (int p0, int p1, int p2, int p3)
			{
				var __h = OnCameraTextureHandler;
				if (__h == null)
					return false;
				var __e = new CameraTextureEventArgs (true, p0, p1, p2, p3);
				__h (sender, __e);
				return __e.Handled;
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

			internal static bool __IsEmpty (ICameraTextureListenerImplementor value)
			{
				return value.OnCameraTextureHandler == null && value.OnCameraViewStartedHandler == null && value.OnCameraViewStoppedHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/CameraGLSurfaceView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraGLSurfaceView); }
		}

		protected CameraGLSurfaceView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/constructor[@name='CameraGLSurfaceView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CameraGLSurfaceView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CameraGLSurfaceView)) {
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

		static Delegate cb_getCameraTextureListener;
#pragma warning disable 0169
		static Delegate GetGetCameraTextureListenerHandler ()
		{
			if (cb_getCameraTextureListener == null)
				cb_getCameraTextureListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraTextureListener);
			return cb_getCameraTextureListener;
		}

		static IntPtr n_GetCameraTextureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.CameraGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraTextureListener);
		}
#pragma warning restore 0169

		static IntPtr id_getCameraTextureListener;
		public virtual unsafe global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener CameraTextureListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/method[@name='getCameraTextureListener' and count(parameter)=0]"
			[Register ("getCameraTextureListener", "()Lorg/opencv/android/CameraGLSurfaceView$CameraTextureListener;", "GetGetCameraTextureListenerHandler")]
			get {
				if (id_getCameraTextureListener == IntPtr.Zero)
					id_getCameraTextureListener = JNIEnv.GetMethodID (class_ref, "getCameraTextureListener", "()Lorg/opencv/android/CameraGLSurfaceView$CameraTextureListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraTextureListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView.ICameraTextureListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCameraTextureListener", "()Lorg/opencv/android/CameraGLSurfaceView$CameraTextureListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::OpenCV.Android.CameraGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableView ();
		}
#pragma warning restore 0169

		static IntPtr id_disableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/method[@name='disableView' and count(parameter)=0]"
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
			global::OpenCV.Android.CameraGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableView ();
		}
#pragma warning restore 0169

		static IntPtr id_enableView;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/method[@name='enableView' and count(parameter)=0]"
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
			global::OpenCV.Android.CameraGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/method[@name='setCameraIndex' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::OpenCV.Android.CameraGLSurfaceView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.CameraGLSurfaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxCameraPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxCameraPreviewSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='CameraGLSurfaceView']/method[@name='setMaxCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

	}
}
