using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']"
	[global::Android.Runtime.Register ("org/opencv/android/JavaCameraView", DoNotGenerateAcw=true)]
	public partial class JavaCameraView : global::OpenCV.Android.CameraBridgeViewBase, global::Android.Hardware.Camera.IPreviewCallback {


		static IntPtr mCamera_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/field[@name='mCamera']"
		[Register ("mCamera")]
		protected global::Android.Hardware.Camera MCamera {
			get {
				if (mCamera_jfieldId == IntPtr.Zero)
					mCamera_jfieldId = JNIEnv.GetFieldID (class_ref, "mCamera", "Landroid/hardware/Camera;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCamera_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCamera_jfieldId == IntPtr.Zero)
					mCamera_jfieldId = JNIEnv.GetFieldID (class_ref, "mCamera", "Landroid/hardware/Camera;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCamera_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCameraFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/field[@name='mCameraFrame']"
		[Register ("mCameraFrame")]
		protected IList<OpenCV.Android.JavaCameraView.JavaCameraFrame> MCameraFrame {
			get {
				if (mCameraFrame_jfieldId == IntPtr.Zero)
					mCameraFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraFrame", "[Lorg/opencv/android/JavaCameraView$JavaCameraFrame;");
				return global::Android.Runtime.JavaArray<global::OpenCV.Android.JavaCameraView.JavaCameraFrame>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCameraFrame_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCameraFrame_jfieldId == IntPtr.Zero)
					mCameraFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCameraFrame", "[Lorg/opencv/android/JavaCameraView$JavaCameraFrame;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::OpenCV.Android.JavaCameraView.JavaCameraFrame>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCameraFrame_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.CameraWorker']"
		[global::Android.Runtime.Register ("org/opencv/android/JavaCameraView$CameraWorker", DoNotGenerateAcw=true)]
		public partial class CameraWorker : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/android/JavaCameraView$CameraWorker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CameraWorker); }
			}

			protected CameraWorker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::OpenCV.Android.JavaCameraView.CameraWorker __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.CameraWorker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.CameraWorker']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraFrame']"
		[global::Android.Runtime.Register ("org/opencv/android/JavaCameraView$JavaCameraFrame", DoNotGenerateAcw=true)]
		public partial class JavaCameraFrame : global::Java.Lang.Object, global::OpenCV.Android.CameraBridgeViewBase.ICvCameraViewFrame {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/android/JavaCameraView$JavaCameraFrame", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JavaCameraFrame); }
			}

			protected JavaCameraFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_opencv_android_JavaCameraView_Lorg_opencv_core_Mat_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraFrame']/constructor[@name='JavaCameraView.JavaCameraFrame' and count(parameter)=4 and parameter[1][@type='org.opencv.android.JavaCameraView'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lorg/opencv/android/JavaCameraView;Lorg/opencv/core/Mat;II)V", "")]
			public unsafe JavaCameraFrame (global::OpenCV.Android.JavaCameraView __self, global::OpenCV.Core.Mat p1, int p2, int p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (JavaCameraFrame)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/opencv/core/Mat;II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/opencv/core/Mat;II)V", __args);
						return;
					}

					if (id_ctor_Lorg_opencv_android_JavaCameraView_Lorg_opencv_core_Mat_II == IntPtr.Zero)
						id_ctor_Lorg_opencv_android_JavaCameraView_Lorg_opencv_core_Mat_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/android/JavaCameraView;Lorg/opencv/core/Mat;II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_android_JavaCameraView_Lorg_opencv_core_Mat_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_android_JavaCameraView_Lorg_opencv_core_Mat_II, __args);
				} finally {
				}
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
				global::OpenCV.Android.JavaCameraView.JavaCameraFrame __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.JavaCameraFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Gray ());
			}
#pragma warning restore 0169

			static IntPtr id_gray;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraFrame']/method[@name='gray' and count(parameter)=0]"
			[Register ("gray", "()Lorg/opencv/core/Mat;", "GetGrayHandler")]
			public virtual unsafe global::OpenCV.Core.Mat Gray ()
			{
				if (id_gray == IntPtr.Zero)
					id_gray = JNIEnv.GetMethodID (class_ref, "gray", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_gray), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gray", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
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
				global::OpenCV.Android.JavaCameraView.JavaCameraFrame __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.JavaCameraFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			static IntPtr id_release;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraFrame']/method[@name='release' and count(parameter)=0]"
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
				global::OpenCV.Android.JavaCameraView.JavaCameraFrame __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.JavaCameraFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Rgba ());
			}
#pragma warning restore 0169

			static IntPtr id_rgba;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraFrame']/method[@name='rgba' and count(parameter)=0]"
			[Register ("rgba", "()Lorg/opencv/core/Mat;", "GetRgbaHandler")]
			public virtual unsafe global::OpenCV.Core.Mat Rgba ()
			{
				if (id_rgba == IntPtr.Zero)
					id_rgba = JNIEnv.GetMethodID (class_ref, "rgba", "()Lorg/opencv/core/Mat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rgba), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rgba", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraSizeAccessor']"
		[global::Android.Runtime.Register ("org/opencv/android/JavaCameraView$JavaCameraSizeAccessor", DoNotGenerateAcw=true)]
		public partial class JavaCameraSizeAccessor : global::Java.Lang.Object, global::OpenCV.Android.CameraBridgeViewBase.IListItemAccessor {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/opencv/android/JavaCameraView$JavaCameraSizeAccessor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JavaCameraSizeAccessor); }
			}

			protected JavaCameraSizeAccessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraSizeAccessor']/constructor[@name='JavaCameraView.JavaCameraSizeAccessor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe JavaCameraSizeAccessor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (JavaCameraSizeAccessor)) {
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
				global::OpenCV.Android.JavaCameraView.JavaCameraSizeAccessor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.JavaCameraSizeAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetHeight (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getHeight_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraSizeAccessor']/method[@name='getHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("getHeight", "(Ljava/lang/Object;)I", "GetGetHeight_Ljava_lang_Object_Handler")]
			public virtual unsafe int GetHeight (global::Java.Lang.Object p0)
			{
				if (id_getHeight_Ljava_lang_Object_ == IntPtr.Zero)
					id_getHeight_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getHeight", "(Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "(Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
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
				global::OpenCV.Android.JavaCameraView.JavaCameraSizeAccessor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView.JavaCameraSizeAccessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetWidth (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getWidth_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView.JavaCameraSizeAccessor']/method[@name='getWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("getWidth", "(Ljava/lang/Object;)I", "GetGetWidth_Ljava_lang_Object_Handler")]
			public virtual unsafe int GetWidth (global::Java.Lang.Object p0)
			{
				if (id_getWidth_Ljava_lang_Object_ == IntPtr.Zero)
					id_getWidth_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getWidth", "(Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "(Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/JavaCameraView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JavaCameraView); }
		}

		protected JavaCameraView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/constructor[@name='JavaCameraView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe JavaCameraView (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JavaCameraView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/constructor[@name='JavaCameraView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe JavaCameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JavaCameraView)) {
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
			global::OpenCV.Android.JavaCameraView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectCamera (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectCamera_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/method[@name='connectCamera' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("connectCamera", "(II)Z", "GetConnectCamera_IIHandler")]
		protected override unsafe bool ConnectCamera (int p0, int p1)
		{
			if (id_connectCamera_II == IntPtr.Zero)
				id_connectCamera_II = JNIEnv.GetMethodID (class_ref, "connectCamera", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_connectCamera_II, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectCamera", "(II)Z"), __args);
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
			global::OpenCV.Android.JavaCameraView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/method[@name='disconnectCamera' and count(parameter)=0]"
		[Register ("disconnectCamera", "()V", "GetDisconnectCameraHandler")]
		protected override unsafe void DisconnectCamera ()
		{
			if (id_disconnectCamera == IntPtr.Zero)
				id_disconnectCamera = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectCamera", "()V"));
			} finally {
			}
		}

		static Delegate cb_initializeCamera_II;
#pragma warning disable 0169
		static Delegate GetInitializeCamera_IIHandler ()
		{
			if (cb_initializeCamera_II == null)
				cb_initializeCamera_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_InitializeCamera_II);
			return cb_initializeCamera_II;
		}

		static bool n_InitializeCamera_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.JavaCameraView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitializeCamera (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initializeCamera_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/method[@name='initializeCamera' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initializeCamera", "(II)Z", "GetInitializeCamera_IIHandler")]
		protected virtual unsafe bool InitializeCamera (int p0, int p1)
		{
			if (id_initializeCamera_II == IntPtr.Zero)
				id_initializeCamera_II = JNIEnv.GetMethodID (class_ref, "initializeCamera", "(II)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_initializeCamera_II, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeCamera", "(II)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler ()
		{
			if (cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ == null)
				cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewFrame_arrayBLandroid_hardware_Camera_);
			return cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		}

		static void n_OnPreviewFrame_arrayBLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Android.JavaCameraView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Hardware.Camera p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewFrame (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/method[@name='onPreviewFrame' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onPreviewFrame", "([BLandroid/hardware/Camera;)V", "GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnPreviewFrame (byte[] p0, global::Android.Hardware.Camera p1)
		{
			if (id_onPreviewFrame_arrayBLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreviewFrame_arrayBLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_releaseCamera;
#pragma warning disable 0169
		static Delegate GetReleaseCameraHandler ()
		{
			if (cb_releaseCamera == null)
				cb_releaseCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseCamera);
			return cb_releaseCamera;
		}

		static void n_ReleaseCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.JavaCameraView __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.JavaCameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='JavaCameraView']/method[@name='releaseCamera' and count(parameter)=0]"
		[Register ("releaseCamera", "()V", "GetReleaseCameraHandler")]
		protected virtual unsafe void ReleaseCamera ()
		{
			if (id_releaseCamera == IntPtr.Zero)
				id_releaseCamera = JNIEnv.GetMethodID (class_ref, "releaseCamera", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseCamera);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseCamera", "()V"));
			} finally {
			}
		}

	}
}
