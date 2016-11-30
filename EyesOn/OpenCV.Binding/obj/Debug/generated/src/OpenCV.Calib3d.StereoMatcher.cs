using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Calib3d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']"
	[global::Android.Runtime.Register ("org/opencv/calib3d/StereoMatcher", DoNotGenerateAcw=true)]
	public partial class StereoMatcher : global::OpenCV.Core.Algorithm {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/field[@name='DISP_SCALE']"
		[Register ("DISP_SCALE")]
		public const int DispScale = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/field[@name='DISP_SHIFT']"
		[Register ("DISP_SHIFT")]
		public const int DispShift = (int) 4;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/calib3d/StereoMatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StereoMatcher); }
		}

		protected StereoMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/constructor[@name='StereoMatcher' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe StereoMatcher (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StereoMatcher)) {
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

		static Delegate cb_getBlockSize;
#pragma warning disable 0169
		static Delegate GetGetBlockSizeHandler ()
		{
			if (cb_getBlockSize == null)
				cb_getBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlockSize);
			return cb_getBlockSize;
		}

		static int n_GetBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockSize;
		}
#pragma warning restore 0169

		static Delegate cb_setBlockSize_I;
#pragma warning disable 0169
		static Delegate GetSetBlockSize_IHandler ()
		{
			if (cb_setBlockSize_I == null)
				cb_setBlockSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlockSize_I);
			return cb_setBlockSize_I;
		}

		static void n_SetBlockSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockSize;
		static IntPtr id_setBlockSize_I;
		public virtual unsafe int BlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getBlockSize' and count(parameter)=0]"
			[Register ("getBlockSize", "()I", "GetGetBlockSizeHandler")]
			get {
				if (id_getBlockSize == IntPtr.Zero)
					id_getBlockSize = JNIEnv.GetMethodID (class_ref, "getBlockSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBlockSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlockSize", "(I)V", "GetSetBlockSize_IHandler")]
			set {
				if (id_setBlockSize_I == IntPtr.Zero)
					id_setBlockSize_I = JNIEnv.GetMethodID (class_ref, "setBlockSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisp12MaxDiff;
#pragma warning disable 0169
		static Delegate GetGetDisp12MaxDiffHandler ()
		{
			if (cb_getDisp12MaxDiff == null)
				cb_getDisp12MaxDiff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisp12MaxDiff);
			return cb_getDisp12MaxDiff;
		}

		static int n_GetDisp12MaxDiff (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Disp12MaxDiff;
		}
#pragma warning restore 0169

		static Delegate cb_setDisp12MaxDiff_I;
#pragma warning disable 0169
		static Delegate GetSetDisp12MaxDiff_IHandler ()
		{
			if (cb_setDisp12MaxDiff_I == null)
				cb_setDisp12MaxDiff_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisp12MaxDiff_I);
			return cb_setDisp12MaxDiff_I;
		}

		static void n_SetDisp12MaxDiff_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disp12MaxDiff = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisp12MaxDiff;
		static IntPtr id_setDisp12MaxDiff_I;
		public virtual unsafe int Disp12MaxDiff {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getDisp12MaxDiff' and count(parameter)=0]"
			[Register ("getDisp12MaxDiff", "()I", "GetGetDisp12MaxDiffHandler")]
			get {
				if (id_getDisp12MaxDiff == IntPtr.Zero)
					id_getDisp12MaxDiff = JNIEnv.GetMethodID (class_ref, "getDisp12MaxDiff", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisp12MaxDiff);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisp12MaxDiff", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setDisp12MaxDiff' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisp12MaxDiff", "(I)V", "GetSetDisp12MaxDiff_IHandler")]
			set {
				if (id_setDisp12MaxDiff_I == IntPtr.Zero)
					id_setDisp12MaxDiff_I = JNIEnv.GetMethodID (class_ref, "setDisp12MaxDiff", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisp12MaxDiff_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisp12MaxDiff", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinDisparity;
#pragma warning disable 0169
		static Delegate GetGetMinDisparityHandler ()
		{
			if (cb_getMinDisparity == null)
				cb_getMinDisparity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinDisparity);
			return cb_getMinDisparity;
		}

		static int n_GetMinDisparity (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDisparity;
		}
#pragma warning restore 0169

		static Delegate cb_setMinDisparity_I;
#pragma warning disable 0169
		static Delegate GetSetMinDisparity_IHandler ()
		{
			if (cb_setMinDisparity_I == null)
				cb_setMinDisparity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinDisparity_I);
			return cb_setMinDisparity_I;
		}

		static void n_SetMinDisparity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinDisparity = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinDisparity;
		static IntPtr id_setMinDisparity_I;
		public virtual unsafe int MinDisparity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getMinDisparity' and count(parameter)=0]"
			[Register ("getMinDisparity", "()I", "GetGetMinDisparityHandler")]
			get {
				if (id_getMinDisparity == IntPtr.Zero)
					id_getMinDisparity = JNIEnv.GetMethodID (class_ref, "getMinDisparity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinDisparity);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinDisparity", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setMinDisparity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinDisparity", "(I)V", "GetSetMinDisparity_IHandler")]
			set {
				if (id_setMinDisparity_I == IntPtr.Zero)
					id_setMinDisparity_I = JNIEnv.GetMethodID (class_ref, "setMinDisparity", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinDisparity_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinDisparity", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumDisparities;
#pragma warning disable 0169
		static Delegate GetGetNumDisparitiesHandler ()
		{
			if (cb_getNumDisparities == null)
				cb_getNumDisparities = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumDisparities);
			return cb_getNumDisparities;
		}

		static int n_GetNumDisparities (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumDisparities;
		}
#pragma warning restore 0169

		static Delegate cb_setNumDisparities_I;
#pragma warning disable 0169
		static Delegate GetSetNumDisparities_IHandler ()
		{
			if (cb_setNumDisparities_I == null)
				cb_setNumDisparities_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumDisparities_I);
			return cb_setNumDisparities_I;
		}

		static void n_SetNumDisparities_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumDisparities = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNumDisparities;
		static IntPtr id_setNumDisparities_I;
		public virtual unsafe int NumDisparities {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getNumDisparities' and count(parameter)=0]"
			[Register ("getNumDisparities", "()I", "GetGetNumDisparitiesHandler")]
			get {
				if (id_getNumDisparities == IntPtr.Zero)
					id_getNumDisparities = JNIEnv.GetMethodID (class_ref, "getNumDisparities", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumDisparities);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumDisparities", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setNumDisparities' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumDisparities", "(I)V", "GetSetNumDisparities_IHandler")]
			set {
				if (id_setNumDisparities_I == IntPtr.Zero)
					id_setNumDisparities_I = JNIEnv.GetMethodID (class_ref, "setNumDisparities", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumDisparities_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumDisparities", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpeckleRange;
#pragma warning disable 0169
		static Delegate GetGetSpeckleRangeHandler ()
		{
			if (cb_getSpeckleRange == null)
				cb_getSpeckleRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpeckleRange);
			return cb_getSpeckleRange;
		}

		static int n_GetSpeckleRange (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpeckleRange;
		}
#pragma warning restore 0169

		static Delegate cb_setSpeckleRange_I;
#pragma warning disable 0169
		static Delegate GetSetSpeckleRange_IHandler ()
		{
			if (cb_setSpeckleRange_I == null)
				cb_setSpeckleRange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSpeckleRange_I);
			return cb_setSpeckleRange_I;
		}

		static void n_SetSpeckleRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpeckleRange = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpeckleRange;
		static IntPtr id_setSpeckleRange_I;
		public virtual unsafe int SpeckleRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getSpeckleRange' and count(parameter)=0]"
			[Register ("getSpeckleRange", "()I", "GetGetSpeckleRangeHandler")]
			get {
				if (id_getSpeckleRange == IntPtr.Zero)
					id_getSpeckleRange = JNIEnv.GetMethodID (class_ref, "getSpeckleRange", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpeckleRange);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpeckleRange", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setSpeckleRange' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSpeckleRange", "(I)V", "GetSetSpeckleRange_IHandler")]
			set {
				if (id_setSpeckleRange_I == IntPtr.Zero)
					id_setSpeckleRange_I = JNIEnv.GetMethodID (class_ref, "setSpeckleRange", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpeckleRange_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpeckleRange", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpeckleWindowSize;
#pragma warning disable 0169
		static Delegate GetGetSpeckleWindowSizeHandler ()
		{
			if (cb_getSpeckleWindowSize == null)
				cb_getSpeckleWindowSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpeckleWindowSize);
			return cb_getSpeckleWindowSize;
		}

		static int n_GetSpeckleWindowSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpeckleWindowSize;
		}
#pragma warning restore 0169

		static Delegate cb_setSpeckleWindowSize_I;
#pragma warning disable 0169
		static Delegate GetSetSpeckleWindowSize_IHandler ()
		{
			if (cb_setSpeckleWindowSize_I == null)
				cb_setSpeckleWindowSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSpeckleWindowSize_I);
			return cb_setSpeckleWindowSize_I;
		}

		static void n_SetSpeckleWindowSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpeckleWindowSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpeckleWindowSize;
		static IntPtr id_setSpeckleWindowSize_I;
		public virtual unsafe int SpeckleWindowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='getSpeckleWindowSize' and count(parameter)=0]"
			[Register ("getSpeckleWindowSize", "()I", "GetGetSpeckleWindowSizeHandler")]
			get {
				if (id_getSpeckleWindowSize == IntPtr.Zero)
					id_getSpeckleWindowSize = JNIEnv.GetMethodID (class_ref, "getSpeckleWindowSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpeckleWindowSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpeckleWindowSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='setSpeckleWindowSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSpeckleWindowSize", "(I)V", "GetSetSpeckleWindowSize_IHandler")]
			set {
				if (id_setSpeckleWindowSize_I == IntPtr.Zero)
					id_setSpeckleWindowSize_I = JNIEnv.GetMethodID (class_ref, "setSpeckleWindowSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpeckleWindowSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpeckleWindowSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Calib3d.StereoMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Compute (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoMatcher']/method[@name='compute' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Compute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
