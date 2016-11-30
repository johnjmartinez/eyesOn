using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Calib3d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']"
	[global::Android.Runtime.Register ("org/opencv/calib3d/StereoBM", DoNotGenerateAcw=true)]
	public partial class StereoBM : global::OpenCV.Calib3d.StereoMatcher {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/field[@name='PREFILTER_NORMALIZED_RESPONSE']"
		[Register ("PREFILTER_NORMALIZED_RESPONSE")]
		public const int PrefilterNormalizedResponse = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/field[@name='PREFILTER_XSOBEL']"
		[Register ("PREFILTER_XSOBEL")]
		public const int PrefilterXsobel = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/calib3d/StereoBM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StereoBM); }
		}

		protected StereoBM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/constructor[@name='StereoBM' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe StereoBM (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StereoBM)) {
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

		static Delegate cb_getPreFilterCap;
#pragma warning disable 0169
		static Delegate GetGetPreFilterCapHandler ()
		{
			if (cb_getPreFilterCap == null)
				cb_getPreFilterCap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreFilterCap);
			return cb_getPreFilterCap;
		}

		static int n_GetPreFilterCap (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreFilterCap;
		}
#pragma warning restore 0169

		static Delegate cb_setPreFilterCap_I;
#pragma warning disable 0169
		static Delegate GetSetPreFilterCap_IHandler ()
		{
			if (cb_setPreFilterCap_I == null)
				cb_setPreFilterCap_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreFilterCap_I);
			return cb_setPreFilterCap_I;
		}

		static void n_SetPreFilterCap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreFilterCap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreFilterCap;
		static IntPtr id_setPreFilterCap_I;
		public virtual unsafe int PreFilterCap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getPreFilterCap' and count(parameter)=0]"
			[Register ("getPreFilterCap", "()I", "GetGetPreFilterCapHandler")]
			get {
				if (id_getPreFilterCap == IntPtr.Zero)
					id_getPreFilterCap = JNIEnv.GetMethodID (class_ref, "getPreFilterCap", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreFilterCap);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreFilterCap", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setPreFilterCap' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreFilterCap", "(I)V", "GetSetPreFilterCap_IHandler")]
			set {
				if (id_setPreFilterCap_I == IntPtr.Zero)
					id_setPreFilterCap_I = JNIEnv.GetMethodID (class_ref, "setPreFilterCap", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreFilterCap_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreFilterCap", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreFilterSize;
#pragma warning disable 0169
		static Delegate GetGetPreFilterSizeHandler ()
		{
			if (cb_getPreFilterSize == null)
				cb_getPreFilterSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreFilterSize);
			return cb_getPreFilterSize;
		}

		static int n_GetPreFilterSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreFilterSize;
		}
#pragma warning restore 0169

		static Delegate cb_setPreFilterSize_I;
#pragma warning disable 0169
		static Delegate GetSetPreFilterSize_IHandler ()
		{
			if (cb_setPreFilterSize_I == null)
				cb_setPreFilterSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreFilterSize_I);
			return cb_setPreFilterSize_I;
		}

		static void n_SetPreFilterSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreFilterSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreFilterSize;
		static IntPtr id_setPreFilterSize_I;
		public virtual unsafe int PreFilterSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getPreFilterSize' and count(parameter)=0]"
			[Register ("getPreFilterSize", "()I", "GetGetPreFilterSizeHandler")]
			get {
				if (id_getPreFilterSize == IntPtr.Zero)
					id_getPreFilterSize = JNIEnv.GetMethodID (class_ref, "getPreFilterSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreFilterSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreFilterSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setPreFilterSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreFilterSize", "(I)V", "GetSetPreFilterSize_IHandler")]
			set {
				if (id_setPreFilterSize_I == IntPtr.Zero)
					id_setPreFilterSize_I = JNIEnv.GetMethodID (class_ref, "setPreFilterSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreFilterSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreFilterSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreFilterType;
#pragma warning disable 0169
		static Delegate GetGetPreFilterTypeHandler ()
		{
			if (cb_getPreFilterType == null)
				cb_getPreFilterType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreFilterType);
			return cb_getPreFilterType;
		}

		static int n_GetPreFilterType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreFilterType;
		}
#pragma warning restore 0169

		static Delegate cb_setPreFilterType_I;
#pragma warning disable 0169
		static Delegate GetSetPreFilterType_IHandler ()
		{
			if (cb_setPreFilterType_I == null)
				cb_setPreFilterType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreFilterType_I);
			return cb_setPreFilterType_I;
		}

		static void n_SetPreFilterType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreFilterType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreFilterType;
		static IntPtr id_setPreFilterType_I;
		public virtual unsafe int PreFilterType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getPreFilterType' and count(parameter)=0]"
			[Register ("getPreFilterType", "()I", "GetGetPreFilterTypeHandler")]
			get {
				if (id_getPreFilterType == IntPtr.Zero)
					id_getPreFilterType = JNIEnv.GetMethodID (class_ref, "getPreFilterType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreFilterType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreFilterType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setPreFilterType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreFilterType", "(I)V", "GetSetPreFilterType_IHandler")]
			set {
				if (id_setPreFilterType_I == IntPtr.Zero)
					id_setPreFilterType_I = JNIEnv.GetMethodID (class_ref, "setPreFilterType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreFilterType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreFilterType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getROI1;
#pragma warning disable 0169
		static Delegate GetGetROI1Handler ()
		{
			if (cb_getROI1 == null)
				cb_getROI1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetROI1);
			return cb_getROI1;
		}

		static IntPtr n_GetROI1 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ROI1);
		}
#pragma warning restore 0169

		static Delegate cb_setROI1_Lorg_opencv_core_Rect_;
#pragma warning disable 0169
		static Delegate GetSetROI1_Lorg_opencv_core_Rect_Handler ()
		{
			if (cb_setROI1_Lorg_opencv_core_Rect_ == null)
				cb_setROI1_Lorg_opencv_core_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetROI1_Lorg_opencv_core_Rect_);
			return cb_setROI1_Lorg_opencv_core_Rect_;
		}

		static void n_SetROI1_Lorg_opencv_core_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Rect p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ROI1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getROI1;
		static IntPtr id_setROI1_Lorg_opencv_core_Rect_;
		public virtual unsafe global::OpenCV.Core.Rect ROI1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getROI1' and count(parameter)=0]"
			[Register ("getROI1", "()Lorg/opencv/core/Rect;", "GetGetROI1Handler")]
			get {
				if (id_getROI1 == IntPtr.Zero)
					id_getROI1 = JNIEnv.GetMethodID (class_ref, "getROI1", "()Lorg/opencv/core/Rect;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getROI1), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getROI1", "()Lorg/opencv/core/Rect;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setROI1' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
			[Register ("setROI1", "(Lorg/opencv/core/Rect;)V", "GetSetROI1_Lorg_opencv_core_Rect_Handler")]
			set {
				if (id_setROI1_Lorg_opencv_core_Rect_ == IntPtr.Zero)
					id_setROI1_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "setROI1", "(Lorg/opencv/core/Rect;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setROI1_Lorg_opencv_core_Rect_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setROI1", "(Lorg/opencv/core/Rect;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getROI2;
#pragma warning disable 0169
		static Delegate GetGetROI2Handler ()
		{
			if (cb_getROI2 == null)
				cb_getROI2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetROI2);
			return cb_getROI2;
		}

		static IntPtr n_GetROI2 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ROI2);
		}
#pragma warning restore 0169

		static Delegate cb_setROI2_Lorg_opencv_core_Rect_;
#pragma warning disable 0169
		static Delegate GetSetROI2_Lorg_opencv_core_Rect_Handler ()
		{
			if (cb_setROI2_Lorg_opencv_core_Rect_ == null)
				cb_setROI2_Lorg_opencv_core_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetROI2_Lorg_opencv_core_Rect_);
			return cb_setROI2_Lorg_opencv_core_Rect_;
		}

		static void n_SetROI2_Lorg_opencv_core_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Rect p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ROI2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getROI2;
		static IntPtr id_setROI2_Lorg_opencv_core_Rect_;
		public virtual unsafe global::OpenCV.Core.Rect ROI2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getROI2' and count(parameter)=0]"
			[Register ("getROI2", "()Lorg/opencv/core/Rect;", "GetGetROI2Handler")]
			get {
				if (id_getROI2 == IntPtr.Zero)
					id_getROI2 = JNIEnv.GetMethodID (class_ref, "getROI2", "()Lorg/opencv/core/Rect;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getROI2), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getROI2", "()Lorg/opencv/core/Rect;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setROI2' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
			[Register ("setROI2", "(Lorg/opencv/core/Rect;)V", "GetSetROI2_Lorg_opencv_core_Rect_Handler")]
			set {
				if (id_setROI2_Lorg_opencv_core_Rect_ == IntPtr.Zero)
					id_setROI2_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "setROI2", "(Lorg/opencv/core/Rect;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setROI2_Lorg_opencv_core_Rect_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setROI2", "(Lorg/opencv/core/Rect;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmallerBlockSize;
#pragma warning disable 0169
		static Delegate GetGetSmallerBlockSizeHandler ()
		{
			if (cb_getSmallerBlockSize == null)
				cb_getSmallerBlockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSmallerBlockSize);
			return cb_getSmallerBlockSize;
		}

		static int n_GetSmallerBlockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallerBlockSize;
		}
#pragma warning restore 0169

		static Delegate cb_setSmallerBlockSize_I;
#pragma warning disable 0169
		static Delegate GetSetSmallerBlockSize_IHandler ()
		{
			if (cb_setSmallerBlockSize_I == null)
				cb_setSmallerBlockSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSmallerBlockSize_I);
			return cb_setSmallerBlockSize_I;
		}

		static void n_SetSmallerBlockSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmallerBlockSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmallerBlockSize;
		static IntPtr id_setSmallerBlockSize_I;
		public virtual unsafe int SmallerBlockSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getSmallerBlockSize' and count(parameter)=0]"
			[Register ("getSmallerBlockSize", "()I", "GetGetSmallerBlockSizeHandler")]
			get {
				if (id_getSmallerBlockSize == IntPtr.Zero)
					id_getSmallerBlockSize = JNIEnv.GetMethodID (class_ref, "getSmallerBlockSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSmallerBlockSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmallerBlockSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setSmallerBlockSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSmallerBlockSize", "(I)V", "GetSetSmallerBlockSize_IHandler")]
			set {
				if (id_setSmallerBlockSize_I == IntPtr.Zero)
					id_setSmallerBlockSize_I = JNIEnv.GetMethodID (class_ref, "setSmallerBlockSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmallerBlockSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmallerBlockSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextureThreshold;
#pragma warning disable 0169
		static Delegate GetGetTextureThresholdHandler ()
		{
			if (cb_getTextureThreshold == null)
				cb_getTextureThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextureThreshold);
			return cb_getTextureThreshold;
		}

		static int n_GetTextureThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setTextureThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetTextureThreshold_IHandler ()
		{
			if (cb_setTextureThreshold_I == null)
				cb_setTextureThreshold_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextureThreshold_I);
			return cb_setTextureThreshold_I;
		}

		static void n_SetTextureThreshold_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextureThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextureThreshold;
		static IntPtr id_setTextureThreshold_I;
		public virtual unsafe int TextureThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getTextureThreshold' and count(parameter)=0]"
			[Register ("getTextureThreshold", "()I", "GetGetTextureThresholdHandler")]
			get {
				if (id_getTextureThreshold == IntPtr.Zero)
					id_getTextureThreshold = JNIEnv.GetMethodID (class_ref, "getTextureThreshold", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextureThreshold);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextureThreshold", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setTextureThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextureThreshold", "(I)V", "GetSetTextureThreshold_IHandler")]
			set {
				if (id_setTextureThreshold_I == IntPtr.Zero)
					id_setTextureThreshold_I = JNIEnv.GetMethodID (class_ref, "setTextureThreshold", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextureThreshold_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextureThreshold", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUniquenessRatio;
#pragma warning disable 0169
		static Delegate GetGetUniquenessRatioHandler ()
		{
			if (cb_getUniquenessRatio == null)
				cb_getUniquenessRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUniquenessRatio);
			return cb_getUniquenessRatio;
		}

		static int n_GetUniquenessRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UniquenessRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setUniquenessRatio_I;
#pragma warning disable 0169
		static Delegate GetSetUniquenessRatio_IHandler ()
		{
			if (cb_setUniquenessRatio_I == null)
				cb_setUniquenessRatio_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUniquenessRatio_I);
			return cb_setUniquenessRatio_I;
		}

		static void n_SetUniquenessRatio_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UniquenessRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUniquenessRatio;
		static IntPtr id_setUniquenessRatio_I;
		public virtual unsafe int UniquenessRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='getUniquenessRatio' and count(parameter)=0]"
			[Register ("getUniquenessRatio", "()I", "GetGetUniquenessRatioHandler")]
			get {
				if (id_getUniquenessRatio == IntPtr.Zero)
					id_getUniquenessRatio = JNIEnv.GetMethodID (class_ref, "getUniquenessRatio", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUniquenessRatio);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniquenessRatio", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='setUniquenessRatio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUniquenessRatio", "(I)V", "GetSetUniquenessRatio_IHandler")]
			set {
				if (id_setUniquenessRatio_I == IntPtr.Zero)
					id_setUniquenessRatio_I = JNIEnv.GetMethodID (class_ref, "setUniquenessRatio", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUniquenessRatio_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUniquenessRatio", "(I)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/opencv/calib3d/StereoBM;", "")]
		public static unsafe global::OpenCV.Calib3d.StereoBM Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/opencv/calib3d/StereoBM;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoBM']/method[@name='create' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("create", "(II)Lorg/opencv/calib3d/StereoBM;", "")]
		public static unsafe global::OpenCV.Calib3d.StereoBM Create (int p0, int p1)
		{
			if (id_create_II == IntPtr.Zero)
				id_create_II = JNIEnv.GetStaticMethodID (class_ref, "create", "(II)Lorg/opencv/calib3d/StereoBM;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoBM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
