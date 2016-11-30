using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ImgProc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']"
	[global::Android.Runtime.Register ("org/opencv/imgproc/CLAHE", DoNotGenerateAcw=true)]
	public partial class CLAHE : global::OpenCV.Core.Algorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/imgproc/CLAHE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CLAHE); }
		}

		protected CLAHE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/constructor[@name='CLAHE' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe CLAHE (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CLAHE)) {
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

		static Delegate cb_getClipLimit;
#pragma warning disable 0169
		static Delegate GetGetClipLimitHandler ()
		{
			if (cb_getClipLimit == null)
				cb_getClipLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetClipLimit);
			return cb_getClipLimit;
		}

		static double n_GetClipLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClipLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setClipLimit_D;
#pragma warning disable 0169
		static Delegate GetSetClipLimit_DHandler ()
		{
			if (cb_setClipLimit_D == null)
				cb_setClipLimit_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetClipLimit_D);
			return cb_setClipLimit_D;
		}

		static void n_SetClipLimit_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClipLimit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClipLimit;
		static IntPtr id_setClipLimit_D;
		public virtual unsafe double ClipLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='getClipLimit' and count(parameter)=0]"
			[Register ("getClipLimit", "()D", "GetGetClipLimitHandler")]
			get {
				if (id_getClipLimit == IntPtr.Zero)
					id_getClipLimit = JNIEnv.GetMethodID (class_ref, "getClipLimit", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getClipLimit);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClipLimit", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='setClipLimit' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setClipLimit", "(D)V", "GetSetClipLimit_DHandler")]
			set {
				if (id_setClipLimit_D == IntPtr.Zero)
					id_setClipLimit_D = JNIEnv.GetMethodID (class_ref, "setClipLimit", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClipLimit_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClipLimit", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTilesGridSize;
#pragma warning disable 0169
		static Delegate GetGetTilesGridSizeHandler ()
		{
			if (cb_getTilesGridSize == null)
				cb_getTilesGridSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTilesGridSize);
			return cb_getTilesGridSize;
		}

		static IntPtr n_GetTilesGridSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TilesGridSize);
		}
#pragma warning restore 0169

		static Delegate cb_setTilesGridSize_Lorg_opencv_core_Size_;
#pragma warning disable 0169
		static Delegate GetSetTilesGridSize_Lorg_opencv_core_Size_Handler ()
		{
			if (cb_setTilesGridSize_Lorg_opencv_core_Size_ == null)
				cb_setTilesGridSize_Lorg_opencv_core_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTilesGridSize_Lorg_opencv_core_Size_);
			return cb_setTilesGridSize_Lorg_opencv_core_Size_;
		}

		static void n_SetTilesGridSize_Lorg_opencv_core_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TilesGridSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTilesGridSize;
		static IntPtr id_setTilesGridSize_Lorg_opencv_core_Size_;
		public virtual unsafe global::OpenCV.Core.Size TilesGridSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='getTilesGridSize' and count(parameter)=0]"
			[Register ("getTilesGridSize", "()Lorg/opencv/core/Size;", "GetGetTilesGridSizeHandler")]
			get {
				if (id_getTilesGridSize == IntPtr.Zero)
					id_getTilesGridSize = JNIEnv.GetMethodID (class_ref, "getTilesGridSize", "()Lorg/opencv/core/Size;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTilesGridSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTilesGridSize", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='setTilesGridSize' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Size']]"
			[Register ("setTilesGridSize", "(Lorg/opencv/core/Size;)V", "GetSetTilesGridSize_Lorg_opencv_core_Size_Handler")]
			set {
				if (id_setTilesGridSize_Lorg_opencv_core_Size_ == IntPtr.Zero)
					id_setTilesGridSize_Lorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "setTilesGridSize", "(Lorg/opencv/core/Size;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTilesGridSize_Lorg_opencv_core_Size_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTilesGridSize", "(Lorg/opencv/core/Size;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetApply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Apply (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_collectGarbage;
#pragma warning disable 0169
		static Delegate GetCollectGarbageHandler ()
		{
			if (cb_collectGarbage == null)
				cb_collectGarbage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CollectGarbage);
			return cb_collectGarbage;
		}

		static void n_CollectGarbage (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.CLAHE __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.CLAHE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CollectGarbage ();
		}
#pragma warning restore 0169

		static IntPtr id_collectGarbage;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='CLAHE']/method[@name='collectGarbage' and count(parameter)=0]"
		[Register ("collectGarbage", "()V", "GetCollectGarbageHandler")]
		public virtual unsafe void CollectGarbage ()
		{
			if (id_collectGarbage == IntPtr.Zero)
				id_collectGarbage = JNIEnv.GetMethodID (class_ref, "collectGarbage", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_collectGarbage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collectGarbage", "()V"));
			} finally {
			}
		}

	}
}
