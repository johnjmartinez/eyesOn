using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']"
	[global::Android.Runtime.Register ("org/opencv/photo/AlignMTB", DoNotGenerateAcw=true)]
	public partial class AlignMTB : global::OpenCV.Photo.AlignExposures {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/AlignMTB", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlignMTB); }
		}

		protected AlignMTB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/constructor[@name='AlignMTB' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AlignMTB (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AlignMTB)) {
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

		static Delegate cb_getCut;
#pragma warning disable 0169
		static Delegate GetGetCutHandler ()
		{
			if (cb_getCut == null)
				cb_getCut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCut);
			return cb_getCut;
		}

		static bool n_GetCut (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cut;
		}
#pragma warning restore 0169

		static Delegate cb_setCut_Z;
#pragma warning disable 0169
		static Delegate GetSetCut_ZHandler ()
		{
			if (cb_setCut_Z == null)
				cb_setCut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCut_Z);
			return cb_setCut_Z;
		}

		static void n_SetCut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cut = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCut;
		static IntPtr id_setCut_Z;
		public virtual unsafe bool Cut {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='getCut' and count(parameter)=0]"
			[Register ("getCut", "()Z", "GetGetCutHandler")]
			get {
				if (id_getCut == IntPtr.Zero)
					id_getCut = JNIEnv.GetMethodID (class_ref, "getCut", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getCut);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCut", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='setCut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCut", "(Z)V", "GetSetCut_ZHandler")]
			set {
				if (id_setCut_Z == IntPtr.Zero)
					id_setCut_Z = JNIEnv.GetMethodID (class_ref, "setCut", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCut_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCut", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExcludeRange;
#pragma warning disable 0169
		static Delegate GetGetExcludeRangeHandler ()
		{
			if (cb_getExcludeRange == null)
				cb_getExcludeRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExcludeRange);
			return cb_getExcludeRange;
		}

		static int n_GetExcludeRange (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExcludeRange;
		}
#pragma warning restore 0169

		static Delegate cb_setExcludeRange_I;
#pragma warning disable 0169
		static Delegate GetSetExcludeRange_IHandler ()
		{
			if (cb_setExcludeRange_I == null)
				cb_setExcludeRange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetExcludeRange_I);
			return cb_setExcludeRange_I;
		}

		static void n_SetExcludeRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExcludeRange = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExcludeRange;
		static IntPtr id_setExcludeRange_I;
		public virtual unsafe int ExcludeRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='getExcludeRange' and count(parameter)=0]"
			[Register ("getExcludeRange", "()I", "GetGetExcludeRangeHandler")]
			get {
				if (id_getExcludeRange == IntPtr.Zero)
					id_getExcludeRange = JNIEnv.GetMethodID (class_ref, "getExcludeRange", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getExcludeRange);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExcludeRange", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='setExcludeRange' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExcludeRange", "(I)V", "GetSetExcludeRange_IHandler")]
			set {
				if (id_setExcludeRange_I == IntPtr.Zero)
					id_setExcludeRange_I = JNIEnv.GetMethodID (class_ref, "setExcludeRange", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExcludeRange_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExcludeRange", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxBits;
#pragma warning disable 0169
		static Delegate GetGetMaxBitsHandler ()
		{
			if (cb_getMaxBits == null)
				cb_getMaxBits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxBits);
			return cb_getMaxBits;
		}

		static int n_GetMaxBits (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxBits;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxBits_I;
#pragma warning disable 0169
		static Delegate GetSetMaxBits_IHandler ()
		{
			if (cb_setMaxBits_I == null)
				cb_setMaxBits_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxBits_I);
			return cb_setMaxBits_I;
		}

		static void n_SetMaxBits_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxBits = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxBits;
		static IntPtr id_setMaxBits_I;
		public virtual unsafe int MaxBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='getMaxBits' and count(parameter)=0]"
			[Register ("getMaxBits", "()I", "GetGetMaxBitsHandler")]
			get {
				if (id_getMaxBits == IntPtr.Zero)
					id_getMaxBits = JNIEnv.GetMethodID (class_ref, "getMaxBits", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxBits);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxBits", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='setMaxBits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxBits", "(I)V", "GetSetMaxBits_IHandler")]
			set {
				if (id_setMaxBits_I == IntPtr.Zero)
					id_setMaxBits_I = JNIEnv.GetMethodID (class_ref, "setMaxBits", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxBits_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxBits", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCalculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CalculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_CalculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CalculateShift (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='calculateShift' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("calculateShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Point;", "GetCalculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Point CalculateShift (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "calculateShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Point;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Point __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_calculateShift_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateShift", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetComputeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ComputeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_ComputeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ComputeBitmaps (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='computeBitmaps' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("computeBitmaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetComputeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void ComputeBitmaps (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "computeBitmaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_computeBitmaps_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeBitmaps", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_process_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetProcess_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_process_Ljava_util_List_Ljava_util_List_ == null)
				cb_process_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Process_Ljava_util_List_Ljava_util_List_);
			return cb_process_Ljava_util_List_Ljava_util_List_;
		}

		static void n_Process_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Process (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_process_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='process' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("process", "(Ljava/util/List;Ljava/util/List;)V", "GetProcess_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void Process (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1)
		{
			if (id_process_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_process_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "process", "(Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "(Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetShiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ == null)
				cb_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_);
			return cb_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_;
		}

		static void n_ShiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Photo.AlignMTB __this = global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShiftMat (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='AlignMTB']/method[@name='shiftMat' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Point']]"
		[Register ("shiftMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;)V", "GetShiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe void ShiftMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Point p2)
		{
			if (id_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "shiftMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shiftMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shiftMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;)V"), __args);
			} finally {
			}
		}

	}
}
