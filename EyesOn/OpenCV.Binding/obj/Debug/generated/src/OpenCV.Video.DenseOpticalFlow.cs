using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='DenseOpticalFlow']"
	[global::Android.Runtime.Register ("org/opencv/video/DenseOpticalFlow", DoNotGenerateAcw=true)]
	public partial class DenseOpticalFlow : global::OpenCV.Core.Algorithm {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/DenseOpticalFlow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DenseOpticalFlow); }
		}

		protected DenseOpticalFlow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='DenseOpticalFlow']/constructor[@name='DenseOpticalFlow' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe DenseOpticalFlow (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DenseOpticalFlow)) {
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

		static Delegate cb_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCalc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Video.DenseOpticalFlow __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.DenseOpticalFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Calc (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='DenseOpticalFlow']/method[@name='calc' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("calc", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetCalc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Calc (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "calc", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calc_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calc", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
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
			global::OpenCV.Video.DenseOpticalFlow __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.DenseOpticalFlow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CollectGarbage ();
		}
#pragma warning restore 0169

		static IntPtr id_collectGarbage;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='DenseOpticalFlow']/method[@name='collectGarbage' and count(parameter)=0]"
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
