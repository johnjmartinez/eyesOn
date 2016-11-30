using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']"
	[global::Android.Runtime.Register ("org/opencv/video/KalmanFilter", DoNotGenerateAcw=true)]
	public partial class KalmanFilter : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		protected long NativeObj {
			get {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId);
			}
			set {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/video/KalmanFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalmanFilter); }
		}

		protected KalmanFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalmanFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (KalmanFilter)) {
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

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe KalmanFilter (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (KalmanFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe KalmanFilter (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (KalmanFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe KalmanFilter (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (KalmanFilter)) {
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

		static Delegate cb_correct_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCorrect_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_correct_Lorg_opencv_core_Mat_ == null)
				cb_correct_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Correct_Lorg_opencv_core_Mat_);
			return cb_correct_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_Correct_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Correct (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_correct_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='correct' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("correct", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetCorrect_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Correct (global::OpenCV.Core.Mat p0)
		{
			if (id_correct_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_correct_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "correct", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_correct_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "correct", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_controlMatrix;
#pragma warning disable 0169
		static Delegate GetGet_controlMatrixHandler ()
		{
			if (cb_get_controlMatrix == null)
				cb_get_controlMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_controlMatrix);
			return cb_get_controlMatrix;
		}

		static IntPtr n_Get_controlMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_controlMatrix ());
		}
#pragma warning restore 0169

		static IntPtr id_get_controlMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_controlMatrix' and count(parameter)=0]"
		[Register ("get_controlMatrix", "()Lorg/opencv/core/Mat;", "GetGet_controlMatrixHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_controlMatrix ()
		{
			if (id_get_controlMatrix == IntPtr.Zero)
				id_get_controlMatrix = JNIEnv.GetMethodID (class_ref, "get_controlMatrix", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_controlMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_controlMatrix", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_errorCovPost;
#pragma warning disable 0169
		static Delegate GetGet_errorCovPostHandler ()
		{
			if (cb_get_errorCovPost == null)
				cb_get_errorCovPost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_errorCovPost);
			return cb_get_errorCovPost;
		}

		static IntPtr n_Get_errorCovPost (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_errorCovPost ());
		}
#pragma warning restore 0169

		static IntPtr id_get_errorCovPost;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_errorCovPost' and count(parameter)=0]"
		[Register ("get_errorCovPost", "()Lorg/opencv/core/Mat;", "GetGet_errorCovPostHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_errorCovPost ()
		{
			if (id_get_errorCovPost == IntPtr.Zero)
				id_get_errorCovPost = JNIEnv.GetMethodID (class_ref, "get_errorCovPost", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_errorCovPost), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_errorCovPost", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_errorCovPre;
#pragma warning disable 0169
		static Delegate GetGet_errorCovPreHandler ()
		{
			if (cb_get_errorCovPre == null)
				cb_get_errorCovPre = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_errorCovPre);
			return cb_get_errorCovPre;
		}

		static IntPtr n_Get_errorCovPre (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_errorCovPre ());
		}
#pragma warning restore 0169

		static IntPtr id_get_errorCovPre;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_errorCovPre' and count(parameter)=0]"
		[Register ("get_errorCovPre", "()Lorg/opencv/core/Mat;", "GetGet_errorCovPreHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_errorCovPre ()
		{
			if (id_get_errorCovPre == IntPtr.Zero)
				id_get_errorCovPre = JNIEnv.GetMethodID (class_ref, "get_errorCovPre", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_errorCovPre), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_errorCovPre", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_gain;
#pragma warning disable 0169
		static Delegate GetGet_gainHandler ()
		{
			if (cb_get_gain == null)
				cb_get_gain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_gain);
			return cb_get_gain;
		}

		static IntPtr n_Get_gain (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_gain ());
		}
#pragma warning restore 0169

		static IntPtr id_get_gain;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_gain' and count(parameter)=0]"
		[Register ("get_gain", "()Lorg/opencv/core/Mat;", "GetGet_gainHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_gain ()
		{
			if (id_get_gain == IntPtr.Zero)
				id_get_gain = JNIEnv.GetMethodID (class_ref, "get_gain", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_gain), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_gain", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_measurementMatrix;
#pragma warning disable 0169
		static Delegate GetGet_measurementMatrixHandler ()
		{
			if (cb_get_measurementMatrix == null)
				cb_get_measurementMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_measurementMatrix);
			return cb_get_measurementMatrix;
		}

		static IntPtr n_Get_measurementMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_measurementMatrix ());
		}
#pragma warning restore 0169

		static IntPtr id_get_measurementMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_measurementMatrix' and count(parameter)=0]"
		[Register ("get_measurementMatrix", "()Lorg/opencv/core/Mat;", "GetGet_measurementMatrixHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_measurementMatrix ()
		{
			if (id_get_measurementMatrix == IntPtr.Zero)
				id_get_measurementMatrix = JNIEnv.GetMethodID (class_ref, "get_measurementMatrix", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_measurementMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_measurementMatrix", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_measurementNoiseCov;
#pragma warning disable 0169
		static Delegate GetGet_measurementNoiseCovHandler ()
		{
			if (cb_get_measurementNoiseCov == null)
				cb_get_measurementNoiseCov = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_measurementNoiseCov);
			return cb_get_measurementNoiseCov;
		}

		static IntPtr n_Get_measurementNoiseCov (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_measurementNoiseCov ());
		}
#pragma warning restore 0169

		static IntPtr id_get_measurementNoiseCov;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_measurementNoiseCov' and count(parameter)=0]"
		[Register ("get_measurementNoiseCov", "()Lorg/opencv/core/Mat;", "GetGet_measurementNoiseCovHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_measurementNoiseCov ()
		{
			if (id_get_measurementNoiseCov == IntPtr.Zero)
				id_get_measurementNoiseCov = JNIEnv.GetMethodID (class_ref, "get_measurementNoiseCov", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_measurementNoiseCov), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_measurementNoiseCov", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_processNoiseCov;
#pragma warning disable 0169
		static Delegate GetGet_processNoiseCovHandler ()
		{
			if (cb_get_processNoiseCov == null)
				cb_get_processNoiseCov = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_processNoiseCov);
			return cb_get_processNoiseCov;
		}

		static IntPtr n_Get_processNoiseCov (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_processNoiseCov ());
		}
#pragma warning restore 0169

		static IntPtr id_get_processNoiseCov;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_processNoiseCov' and count(parameter)=0]"
		[Register ("get_processNoiseCov", "()Lorg/opencv/core/Mat;", "GetGet_processNoiseCovHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_processNoiseCov ()
		{
			if (id_get_processNoiseCov == IntPtr.Zero)
				id_get_processNoiseCov = JNIEnv.GetMethodID (class_ref, "get_processNoiseCov", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_processNoiseCov), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_processNoiseCov", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_statePost;
#pragma warning disable 0169
		static Delegate GetGet_statePostHandler ()
		{
			if (cb_get_statePost == null)
				cb_get_statePost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_statePost);
			return cb_get_statePost;
		}

		static IntPtr n_Get_statePost (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_statePost ());
		}
#pragma warning restore 0169

		static IntPtr id_get_statePost;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_statePost' and count(parameter)=0]"
		[Register ("get_statePost", "()Lorg/opencv/core/Mat;", "GetGet_statePostHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_statePost ()
		{
			if (id_get_statePost == IntPtr.Zero)
				id_get_statePost = JNIEnv.GetMethodID (class_ref, "get_statePost", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_statePost), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_statePost", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_statePre;
#pragma warning disable 0169
		static Delegate GetGet_statePreHandler ()
		{
			if (cb_get_statePre == null)
				cb_get_statePre = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_statePre);
			return cb_get_statePre;
		}

		static IntPtr n_Get_statePre (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_statePre ());
		}
#pragma warning restore 0169

		static IntPtr id_get_statePre;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_statePre' and count(parameter)=0]"
		[Register ("get_statePre", "()Lorg/opencv/core/Mat;", "GetGet_statePreHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_statePre ()
		{
			if (id_get_statePre == IntPtr.Zero)
				id_get_statePre = JNIEnv.GetMethodID (class_ref, "get_statePre", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_statePre), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_statePre", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_transitionMatrix;
#pragma warning disable 0169
		static Delegate GetGet_transitionMatrixHandler ()
		{
			if (cb_get_transitionMatrix == null)
				cb_get_transitionMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_transitionMatrix);
			return cb_get_transitionMatrix;
		}

		static IntPtr n_Get_transitionMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_transitionMatrix ());
		}
#pragma warning restore 0169

		static IntPtr id_get_transitionMatrix;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='get_transitionMatrix' and count(parameter)=0]"
		[Register ("get_transitionMatrix", "()Lorg/opencv/core/Mat;", "GetGet_transitionMatrixHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Get_transitionMatrix ()
		{
			if (id_get_transitionMatrix == IntPtr.Zero)
				id_get_transitionMatrix = JNIEnv.GetMethodID (class_ref, "get_transitionMatrix", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_transitionMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_transitionMatrix", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_predict;
#pragma warning disable 0169
		static Delegate GetPredictHandler ()
		{
			if (cb_predict == null)
				cb_predict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Predict);
			return cb_predict;
		}

		static IntPtr n_Predict (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Predict ());
		}
#pragma warning restore 0169

		static IntPtr id_predict;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='predict' and count(parameter)=0]"
		[Register ("predict", "()Lorg/opencv/core/Mat;", "GetPredictHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Predict ()
		{
			if (id_predict == IntPtr.Zero)
				id_predict = JNIEnv.GetMethodID (class_ref, "predict", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_predict), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_predict_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetPredict_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_predict_Lorg_opencv_core_Mat_ == null)
				cb_predict_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Predict_Lorg_opencv_core_Mat_);
			return cb_predict_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_Predict_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Predict (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_predict_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='predict' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("predict", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetPredict_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Predict (global::OpenCV.Core.Mat p0)
		{
			if (id_predict_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_predict_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "predict", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_predict_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_set_controlMatrix_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_controlMatrix_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_controlMatrix_Lorg_opencv_core_Mat_ == null)
				cb_set_controlMatrix_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_controlMatrix_Lorg_opencv_core_Mat_);
			return cb_set_controlMatrix_Lorg_opencv_core_Mat_;
		}

		static void n_Set_controlMatrix_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_controlMatrix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_controlMatrix_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_controlMatrix' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_controlMatrix", "(Lorg/opencv/core/Mat;)V", "GetSet_controlMatrix_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_controlMatrix (global::OpenCV.Core.Mat p0)
		{
			if (id_set_controlMatrix_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_controlMatrix_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_controlMatrix", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_controlMatrix_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_controlMatrix", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_errorCovPost_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_errorCovPost_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_errorCovPost_Lorg_opencv_core_Mat_ == null)
				cb_set_errorCovPost_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_errorCovPost_Lorg_opencv_core_Mat_);
			return cb_set_errorCovPost_Lorg_opencv_core_Mat_;
		}

		static void n_Set_errorCovPost_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_errorCovPost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_errorCovPost_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_errorCovPost' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_errorCovPost", "(Lorg/opencv/core/Mat;)V", "GetSet_errorCovPost_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_errorCovPost (global::OpenCV.Core.Mat p0)
		{
			if (id_set_errorCovPost_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_errorCovPost_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_errorCovPost", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_errorCovPost_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_errorCovPost", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_errorCovPre_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_errorCovPre_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_errorCovPre_Lorg_opencv_core_Mat_ == null)
				cb_set_errorCovPre_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_errorCovPre_Lorg_opencv_core_Mat_);
			return cb_set_errorCovPre_Lorg_opencv_core_Mat_;
		}

		static void n_Set_errorCovPre_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_errorCovPre (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_errorCovPre_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_errorCovPre' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_errorCovPre", "(Lorg/opencv/core/Mat;)V", "GetSet_errorCovPre_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_errorCovPre (global::OpenCV.Core.Mat p0)
		{
			if (id_set_errorCovPre_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_errorCovPre_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_errorCovPre", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_errorCovPre_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_errorCovPre", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_gain_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_gain_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_gain_Lorg_opencv_core_Mat_ == null)
				cb_set_gain_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_gain_Lorg_opencv_core_Mat_);
			return cb_set_gain_Lorg_opencv_core_Mat_;
		}

		static void n_Set_gain_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_gain (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_gain_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_gain' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_gain", "(Lorg/opencv/core/Mat;)V", "GetSet_gain_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_gain (global::OpenCV.Core.Mat p0)
		{
			if (id_set_gain_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_gain_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_gain", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_gain_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_gain", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_measurementMatrix_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_measurementMatrix_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_measurementMatrix_Lorg_opencv_core_Mat_ == null)
				cb_set_measurementMatrix_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_measurementMatrix_Lorg_opencv_core_Mat_);
			return cb_set_measurementMatrix_Lorg_opencv_core_Mat_;
		}

		static void n_Set_measurementMatrix_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_measurementMatrix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_measurementMatrix_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_measurementMatrix' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_measurementMatrix", "(Lorg/opencv/core/Mat;)V", "GetSet_measurementMatrix_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_measurementMatrix (global::OpenCV.Core.Mat p0)
		{
			if (id_set_measurementMatrix_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_measurementMatrix_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_measurementMatrix", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_measurementMatrix_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_measurementMatrix", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_measurementNoiseCov_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_measurementNoiseCov_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_measurementNoiseCov_Lorg_opencv_core_Mat_ == null)
				cb_set_measurementNoiseCov_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_measurementNoiseCov_Lorg_opencv_core_Mat_);
			return cb_set_measurementNoiseCov_Lorg_opencv_core_Mat_;
		}

		static void n_Set_measurementNoiseCov_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_measurementNoiseCov (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_measurementNoiseCov_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_measurementNoiseCov' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_measurementNoiseCov", "(Lorg/opencv/core/Mat;)V", "GetSet_measurementNoiseCov_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_measurementNoiseCov (global::OpenCV.Core.Mat p0)
		{
			if (id_set_measurementNoiseCov_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_measurementNoiseCov_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_measurementNoiseCov", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_measurementNoiseCov_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_measurementNoiseCov", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_processNoiseCov_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_processNoiseCov_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_processNoiseCov_Lorg_opencv_core_Mat_ == null)
				cb_set_processNoiseCov_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_processNoiseCov_Lorg_opencv_core_Mat_);
			return cb_set_processNoiseCov_Lorg_opencv_core_Mat_;
		}

		static void n_Set_processNoiseCov_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_processNoiseCov (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_processNoiseCov_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_processNoiseCov' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_processNoiseCov", "(Lorg/opencv/core/Mat;)V", "GetSet_processNoiseCov_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_processNoiseCov (global::OpenCV.Core.Mat p0)
		{
			if (id_set_processNoiseCov_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_processNoiseCov_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_processNoiseCov", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_processNoiseCov_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_processNoiseCov", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_statePost_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_statePost_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_statePost_Lorg_opencv_core_Mat_ == null)
				cb_set_statePost_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_statePost_Lorg_opencv_core_Mat_);
			return cb_set_statePost_Lorg_opencv_core_Mat_;
		}

		static void n_Set_statePost_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_statePost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_statePost_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_statePost' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_statePost", "(Lorg/opencv/core/Mat;)V", "GetSet_statePost_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_statePost (global::OpenCV.Core.Mat p0)
		{
			if (id_set_statePost_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_statePost_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_statePost", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_statePost_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_statePost", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_statePre_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_statePre_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_statePre_Lorg_opencv_core_Mat_ == null)
				cb_set_statePre_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_statePre_Lorg_opencv_core_Mat_);
			return cb_set_statePre_Lorg_opencv_core_Mat_;
		}

		static void n_Set_statePre_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_statePre (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_statePre_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_statePre' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_statePre", "(Lorg/opencv/core/Mat;)V", "GetSet_statePre_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_statePre (global::OpenCV.Core.Mat p0)
		{
			if (id_set_statePre_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_statePre_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_statePre", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_statePre_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_statePre", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_transitionMatrix_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSet_transitionMatrix_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_set_transitionMatrix_Lorg_opencv_core_Mat_ == null)
				cb_set_transitionMatrix_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_transitionMatrix_Lorg_opencv_core_Mat_);
			return cb_set_transitionMatrix_Lorg_opencv_core_Mat_;
		}

		static void n_Set_transitionMatrix_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Video.KalmanFilter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Video.KalmanFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set_transitionMatrix (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_transitionMatrix_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.video']/class[@name='KalmanFilter']/method[@name='set_transitionMatrix' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("set_transitionMatrix", "(Lorg/opencv/core/Mat;)V", "GetSet_transitionMatrix_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Set_transitionMatrix (global::OpenCV.Core.Mat p0)
		{
			if (id_set_transitionMatrix_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_set_transitionMatrix_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "set_transitionMatrix", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_transitionMatrix_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_transitionMatrix", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
