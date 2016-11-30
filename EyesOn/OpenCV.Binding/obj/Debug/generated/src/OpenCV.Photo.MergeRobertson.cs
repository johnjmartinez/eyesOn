using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeRobertson']"
	[global::Android.Runtime.Register ("org/opencv/photo/MergeRobertson", DoNotGenerateAcw=true)]
	public partial class MergeRobertson : global::OpenCV.Photo.MergeExposures {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/MergeRobertson", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MergeRobertson); }
		}

		protected MergeRobertson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeRobertson']/constructor[@name='MergeRobertson' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe MergeRobertson (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MergeRobertson)) {
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

		static Delegate cb_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetProcess_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Photo.MergeRobertson __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeRobertson> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeRobertson']/method[@name='process' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("process", "(Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetProcess_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Process (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "process", "(Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "(Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
