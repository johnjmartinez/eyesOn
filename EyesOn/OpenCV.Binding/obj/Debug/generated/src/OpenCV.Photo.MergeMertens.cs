using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']"
	[global::Android.Runtime.Register ("org/opencv/photo/MergeMertens", DoNotGenerateAcw=true)]
	public partial class MergeMertens : global::OpenCV.Photo.MergeExposures {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/MergeMertens", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MergeMertens); }
		}

		protected MergeMertens (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/constructor[@name='MergeMertens' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe MergeMertens (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MergeMertens)) {
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

		static Delegate cb_getContrastWeight;
#pragma warning disable 0169
		static Delegate GetGetContrastWeightHandler ()
		{
			if (cb_getContrastWeight == null)
				cb_getContrastWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetContrastWeight);
			return cb_getContrastWeight;
		}

		static float n_GetContrastWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContrastWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setContrastWeight_F;
#pragma warning disable 0169
		static Delegate GetSetContrastWeight_FHandler ()
		{
			if (cb_setContrastWeight_F == null)
				cb_setContrastWeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetContrastWeight_F);
			return cb_setContrastWeight_F;
		}

		static void n_SetContrastWeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContrastWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContrastWeight;
		static IntPtr id_setContrastWeight_F;
		public virtual unsafe float ContrastWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='getContrastWeight' and count(parameter)=0]"
			[Register ("getContrastWeight", "()F", "GetGetContrastWeightHandler")]
			get {
				if (id_getContrastWeight == IntPtr.Zero)
					id_getContrastWeight = JNIEnv.GetMethodID (class_ref, "getContrastWeight", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getContrastWeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContrastWeight", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='setContrastWeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setContrastWeight", "(F)V", "GetSetContrastWeight_FHandler")]
			set {
				if (id_setContrastWeight_F == IntPtr.Zero)
					id_setContrastWeight_F = JNIEnv.GetMethodID (class_ref, "setContrastWeight", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContrastWeight_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContrastWeight", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExposureWeight;
#pragma warning disable 0169
		static Delegate GetGetExposureWeightHandler ()
		{
			if (cb_getExposureWeight == null)
				cb_getExposureWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExposureWeight);
			return cb_getExposureWeight;
		}

		static float n_GetExposureWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExposureWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setExposureWeight_F;
#pragma warning disable 0169
		static Delegate GetSetExposureWeight_FHandler ()
		{
			if (cb_setExposureWeight_F == null)
				cb_setExposureWeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExposureWeight_F);
			return cb_setExposureWeight_F;
		}

		static void n_SetExposureWeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExposureWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExposureWeight;
		static IntPtr id_setExposureWeight_F;
		public virtual unsafe float ExposureWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='getExposureWeight' and count(parameter)=0]"
			[Register ("getExposureWeight", "()F", "GetGetExposureWeightHandler")]
			get {
				if (id_getExposureWeight == IntPtr.Zero)
					id_getExposureWeight = JNIEnv.GetMethodID (class_ref, "getExposureWeight", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getExposureWeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExposureWeight", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='setExposureWeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExposureWeight", "(F)V", "GetSetExposureWeight_FHandler")]
			set {
				if (id_setExposureWeight_F == IntPtr.Zero)
					id_setExposureWeight_F = JNIEnv.GetMethodID (class_ref, "setExposureWeight", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExposureWeight_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureWeight", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSaturationWeight;
#pragma warning disable 0169
		static Delegate GetGetSaturationWeightHandler ()
		{
			if (cb_getSaturationWeight == null)
				cb_getSaturationWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSaturationWeight);
			return cb_getSaturationWeight;
		}

		static float n_GetSaturationWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaturationWeight;
		}
#pragma warning restore 0169

		static Delegate cb_setSaturationWeight_F;
#pragma warning disable 0169
		static Delegate GetSetSaturationWeight_FHandler ()
		{
			if (cb_setSaturationWeight_F == null)
				cb_setSaturationWeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSaturationWeight_F);
			return cb_setSaturationWeight_F;
		}

		static void n_SetSaturationWeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SaturationWeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSaturationWeight;
		static IntPtr id_setSaturationWeight_F;
		public virtual unsafe float SaturationWeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='getSaturationWeight' and count(parameter)=0]"
			[Register ("getSaturationWeight", "()F", "GetGetSaturationWeightHandler")]
			get {
				if (id_getSaturationWeight == IntPtr.Zero)
					id_getSaturationWeight = JNIEnv.GetMethodID (class_ref, "getSaturationWeight", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSaturationWeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSaturationWeight", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='setSaturationWeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSaturationWeight", "(F)V", "GetSetSaturationWeight_FHandler")]
			set {
				if (id_setSaturationWeight_F == IntPtr.Zero)
					id_setSaturationWeight_F = JNIEnv.GetMethodID (class_ref, "setSaturationWeight", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSaturationWeight_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSaturationWeight", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_process_Ljava_util_List_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetProcess_Ljava_util_List_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_process_Ljava_util_List_Lorg_opencv_core_Mat_ == null)
				cb_process_Ljava_util_List_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Ljava_util_List_Lorg_opencv_core_Mat_);
			return cb_process_Ljava_util_List_Lorg_opencv_core_Mat_;
		}

		static void n_Process_Ljava_util_List_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Photo.MergeMertens __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_process_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='MergeMertens']/method[@name='process' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("process", "(Ljava/util/List;Lorg/opencv/core/Mat;)V", "GetProcess_Ljava_util_List_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Process (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1)
		{
			if (id_process_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_process_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "process", "(Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "(Ljava/util/List;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
