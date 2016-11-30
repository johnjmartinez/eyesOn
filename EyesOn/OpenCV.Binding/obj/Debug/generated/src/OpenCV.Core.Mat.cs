using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']"
	[global::Android.Runtime.Register ("org/opencv/core/Mat", DoNotGenerateAcw=true)]
	public partial class Mat : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		public long NativeObj {
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
				return JNIEnv.FindClass ("org/opencv/core/Mat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mat); }
		}

		protected Mat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIILorg_opencv_core_Scalar_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.opencv.core.Scalar']]"
		[Register (".ctor", "(IIILorg/opencv/core/Scalar;)V", "")]
		public unsafe Mat (int p0, int p1, int p2, global::OpenCV.Core.Scalar p3)
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
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIILorg/opencv/core/Scalar;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIILorg/opencv/core/Scalar;)V", __args);
					return;
				}

				if (id_ctor_IIILorg_opencv_core_Scalar_ == IntPtr.Zero)
					id_ctor_IIILorg_opencv_core_Scalar_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIILorg/opencv/core/Scalar;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIILorg_opencv_core_Scalar_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Size_ILorg_opencv_core_Scalar_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Scalar']]"
		[Register (".ctor", "(Lorg/opencv/core/Size;ILorg/opencv/core/Scalar;)V", "")]
		public unsafe Mat (global::OpenCV.Core.Size p0, int p1, global::OpenCV.Core.Scalar p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Size;ILorg/opencv/core/Scalar;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Size;ILorg/opencv/core/Scalar;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Size_ILorg_opencv_core_Scalar_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Size_ILorg_opencv_core_Scalar_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Size;ILorg/opencv/core/Scalar;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Size_ILorg_opencv_core_Scalar_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Size_ILorg_opencv_core_Scalar_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Range'] and parameter[3][@type='org.opencv.core.Range']]"
		[Register (".ctor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;Lorg/opencv/core/Range;)V", "")]
		public unsafe Mat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Range p1, global::OpenCV.Core.Range p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;Lorg/opencv/core/Range;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;Lorg/opencv/core/Range;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;Lorg/opencv/core/Range;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Range']]"
		[Register (".ctor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;)V", "")]
		public unsafe Mat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Range p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Range;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Range_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Rect']]"
		[Register (".ctor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;)V", "")]
		public unsafe Mat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Rect p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Rect;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Mat_Lorg_opencv_core_Rect_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Mat (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Mat)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Mat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Mat)) {
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

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe Mat (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/constructor[@name='Mat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/opencv/core/Size;I)V", "")]
		public unsafe Mat (global::OpenCV.Core.Size p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Mat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Size;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Size;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Size_I == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Size_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Size;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Size_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static Delegate cb_isContinuous;
#pragma warning disable 0169
		static Delegate GetIsContinuousHandler ()
		{
			if (cb_isContinuous == null)
				cb_isContinuous = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContinuous);
			return cb_isContinuous;
		}

		static bool n_IsContinuous (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContinuous;
		}
#pragma warning restore 0169

		static IntPtr id_isContinuous;
		public virtual unsafe bool IsContinuous {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='isContinuous' and count(parameter)=0]"
			[Register ("isContinuous", "()Z", "GetIsContinuousHandler")]
			get {
				if (id_isContinuous == IntPtr.Zero)
					id_isContinuous = JNIEnv.GetMethodID (class_ref, "isContinuous", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContinuous);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContinuous", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSubmatrix;
#pragma warning disable 0169
		static Delegate GetIsSubmatrixHandler ()
		{
			if (cb_isSubmatrix == null)
				cb_isSubmatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSubmatrix);
			return cb_isSubmatrix;
		}

		static bool n_IsSubmatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSubmatrix;
		}
#pragma warning restore 0169

		static IntPtr id_isSubmatrix;
		public virtual unsafe bool IsSubmatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='isSubmatrix' and count(parameter)=0]"
			[Register ("isSubmatrix", "()Z", "GetIsSubmatrixHandler")]
			get {
				if (id_isSubmatrix == IntPtr.Zero)
					id_isSubmatrix = JNIEnv.GetMethodID (class_ref, "isSubmatrix", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSubmatrix);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSubmatrix", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNativeObjAddr;
#pragma warning disable 0169
		static Delegate GetGetNativeObjAddrHandler ()
		{
			if (cb_getNativeObjAddr == null)
				cb_getNativeObjAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeObjAddr);
			return cb_getNativeObjAddr;
		}

		static long n_GetNativeObjAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeObjAddr;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeObjAddr;
		public virtual unsafe long NativeObjAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='getNativeObjAddr' and count(parameter)=0]"
			[Register ("getNativeObjAddr", "()J", "GetGetNativeObjAddrHandler")]
			get {
				if (id_getNativeObjAddr == IntPtr.Zero)
					id_getNativeObjAddr = JNIEnv.GetMethodID (class_ref, "getNativeObjAddr", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeObjAddr);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeObjAddr", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_adjustROI_IIII;
#pragma warning disable 0169
		static Delegate GetAdjustROI_IIIIHandler ()
		{
			if (cb_adjustROI_IIII == null)
				cb_adjustROI_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_AdjustROI_IIII);
			return cb_adjustROI_IIII;
		}

		static IntPtr n_AdjustROI_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdjustROI (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_adjustROI_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='adjustROI' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("adjustROI", "(IIII)Lorg/opencv/core/Mat;", "GetAdjustROI_IIIIHandler")]
		public virtual unsafe global::OpenCV.Core.Mat AdjustROI (int p0, int p1, int p2, int p3)
		{
			if (id_adjustROI_IIII == IntPtr.Zero)
				id_adjustROI_IIII = JNIEnv.GetMethodID (class_ref, "adjustROI", "(IIII)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adjustROI_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustROI", "(IIII)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_assignTo_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetAssignTo_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_assignTo_Lorg_opencv_core_Mat_ == null)
				cb_assignTo_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AssignTo_Lorg_opencv_core_Mat_);
			return cb_assignTo_Lorg_opencv_core_Mat_;
		}

		static void n_AssignTo_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AssignTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_assignTo_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='assignTo' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("assignTo", "(Lorg/opencv/core/Mat;)V", "GetAssignTo_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void AssignTo (global::OpenCV.Core.Mat p0)
		{
			if (id_assignTo_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_assignTo_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "assignTo", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_assignTo_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "assignTo", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_assignTo_Lorg_opencv_core_Mat_I;
#pragma warning disable 0169
		static Delegate GetAssignTo_Lorg_opencv_core_Mat_IHandler ()
		{
			if (cb_assignTo_Lorg_opencv_core_Mat_I == null)
				cb_assignTo_Lorg_opencv_core_Mat_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AssignTo_Lorg_opencv_core_Mat_I);
			return cb_assignTo_Lorg_opencv_core_Mat_I;
		}

		static void n_AssignTo_Lorg_opencv_core_Mat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AssignTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_assignTo_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='assignTo' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int']]"
		[Register ("assignTo", "(Lorg/opencv/core/Mat;I)V", "GetAssignTo_Lorg_opencv_core_Mat_IHandler")]
		public virtual unsafe void AssignTo (global::OpenCV.Core.Mat p0, int p1)
		{
			if (id_assignTo_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_assignTo_Lorg_opencv_core_Mat_I = JNIEnv.GetMethodID (class_ref, "assignTo", "(Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_assignTo_Lorg_opencv_core_Mat_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "assignTo", "(Lorg/opencv/core/Mat;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_channels;
#pragma warning disable 0169
		static Delegate GetChannelsHandler ()
		{
			if (cb_channels == null)
				cb_channels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Channels);
			return cb_channels;
		}

		static int n_Channels (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Channels ();
		}
#pragma warning restore 0169

		static IntPtr id_channels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='channels' and count(parameter)=0]"
		[Register ("channels", "()I", "GetChannelsHandler")]
		public virtual unsafe int Channels ()
		{
			if (id_channels == IntPtr.Zero)
				id_channels = JNIEnv.GetMethodID (class_ref, "channels", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_channels);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "channels", "()I"));
			} finally {
			}
		}

		static Delegate cb_checkVector_I;
#pragma warning disable 0169
		static Delegate GetCheckVector_IHandler ()
		{
			if (cb_checkVector_I == null)
				cb_checkVector_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_CheckVector_I);
			return cb_checkVector_I;
		}

		static int n_CheckVector_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckVector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkVector_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='checkVector' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkVector", "(I)I", "GetCheckVector_IHandler")]
		public virtual unsafe int CheckVector (int p0)
		{
			if (id_checkVector_I == IntPtr.Zero)
				id_checkVector_I = JNIEnv.GetMethodID (class_ref, "checkVector", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVector_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkVector", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_checkVector_II;
#pragma warning disable 0169
		static Delegate GetCheckVector_IIHandler ()
		{
			if (cb_checkVector_II == null)
				cb_checkVector_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_CheckVector_II);
			return cb_checkVector_II;
		}

		static int n_CheckVector_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckVector (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkVector_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='checkVector' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("checkVector", "(II)I", "GetCheckVector_IIHandler")]
		public virtual unsafe int CheckVector (int p0, int p1)
		{
			if (id_checkVector_II == IntPtr.Zero)
				id_checkVector_II = JNIEnv.GetMethodID (class_ref, "checkVector", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVector_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkVector", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_checkVector_IIZ;
#pragma warning disable 0169
		static Delegate GetCheckVector_IIZHandler ()
		{
			if (cb_checkVector_IIZ == null)
				cb_checkVector_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, int>) n_CheckVector_IIZ);
			return cb_checkVector_IIZ;
		}

		static int n_CheckVector_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckVector (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_checkVector_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='checkVector' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("checkVector", "(IIZ)I", "GetCheckVector_IIZHandler")]
		public virtual unsafe int CheckVector (int p0, int p1, bool p2)
		{
			if (id_checkVector_IIZ == IntPtr.Zero)
				id_checkVector_IIZ = JNIEnv.GetMethodID (class_ref, "checkVector", "(IIZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVector_IIZ, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkVector", "(IIZ)I"), __args);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/core/Mat;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_col_I;
#pragma warning disable 0169
		static Delegate GetCol_IHandler ()
		{
			if (cb_col_I == null)
				cb_col_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Col_I);
			return cb_col_I;
		}

		static IntPtr n_Col_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Col (p0));
		}
#pragma warning restore 0169

		static IntPtr id_col_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='col' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("col", "(I)Lorg/opencv/core/Mat;", "GetCol_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Col (int p0)
		{
			if (id_col_I == IntPtr.Zero)
				id_col_I = JNIEnv.GetMethodID (class_ref, "col", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_col_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "col", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_colRange_II;
#pragma warning disable 0169
		static Delegate GetColRange_IIHandler ()
		{
			if (cb_colRange_II == null)
				cb_colRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_ColRange_II);
			return cb_colRange_II;
		}

		static IntPtr n_ColRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColRange (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_colRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='colRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("colRange", "(II)Lorg/opencv/core/Mat;", "GetColRange_IIHandler")]
		public virtual unsafe global::OpenCV.Core.Mat ColRange (int p0, int p1)
		{
			if (id_colRange_II == IntPtr.Zero)
				id_colRange_II = JNIEnv.GetMethodID (class_ref, "colRange", "(II)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_colRange_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "colRange", "(II)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_colRange_Lorg_opencv_core_Range_;
#pragma warning disable 0169
		static Delegate GetColRange_Lorg_opencv_core_Range_Handler ()
		{
			if (cb_colRange_Lorg_opencv_core_Range_ == null)
				cb_colRange_Lorg_opencv_core_Range_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ColRange_Lorg_opencv_core_Range_);
			return cb_colRange_Lorg_opencv_core_Range_;
		}

		static IntPtr n_ColRange_Lorg_opencv_core_Range_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Range p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ColRange (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_colRange_Lorg_opencv_core_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='colRange' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Range']]"
		[Register ("colRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;", "GetColRange_Lorg_opencv_core_Range_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat ColRange (global::OpenCV.Core.Range p0)
		{
			if (id_colRange_Lorg_opencv_core_Range_ == IntPtr.Zero)
				id_colRange_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "colRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_colRange_Lorg_opencv_core_Range_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "colRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cols;
#pragma warning disable 0169
		static Delegate GetColsHandler ()
		{
			if (cb_cols == null)
				cb_cols = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Cols);
			return cb_cols;
		}

		static int n_Cols (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cols ();
		}
#pragma warning restore 0169

		static IntPtr id_cols;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='cols' and count(parameter)=0]"
		[Register ("cols", "()I", "GetColsHandler")]
		public virtual unsafe int Cols ()
		{
			if (id_cols == IntPtr.Zero)
				id_cols = JNIEnv.GetMethodID (class_ref, "cols", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cols);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cols", "()I"));
			} finally {
			}
		}

		static Delegate cb_convertTo_Lorg_opencv_core_Mat_I;
#pragma warning disable 0169
		static Delegate GetConvertTo_Lorg_opencv_core_Mat_IHandler ()
		{
			if (cb_convertTo_Lorg_opencv_core_Mat_I == null)
				cb_convertTo_Lorg_opencv_core_Mat_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ConvertTo_Lorg_opencv_core_Mat_I);
			return cb_convertTo_Lorg_opencv_core_Mat_I;
		}

		static void n_ConvertTo_Lorg_opencv_core_Mat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConvertTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_convertTo_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='convertTo' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int']]"
		[Register ("convertTo", "(Lorg/opencv/core/Mat;I)V", "GetConvertTo_Lorg_opencv_core_Mat_IHandler")]
		public virtual unsafe void ConvertTo (global::OpenCV.Core.Mat p0, int p1)
		{
			if (id_convertTo_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_convertTo_Lorg_opencv_core_Mat_I = JNIEnv.GetMethodID (class_ref, "convertTo", "(Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertTo_Lorg_opencv_core_Mat_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertTo", "(Lorg/opencv/core/Mat;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_convertTo_Lorg_opencv_core_Mat_ID;
#pragma warning disable 0169
		static Delegate GetConvertTo_Lorg_opencv_core_Mat_IDHandler ()
		{
			if (cb_convertTo_Lorg_opencv_core_Mat_ID == null)
				cb_convertTo_Lorg_opencv_core_Mat_ID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, double>) n_ConvertTo_Lorg_opencv_core_Mat_ID);
			return cb_convertTo_Lorg_opencv_core_Mat_ID;
		}

		static void n_ConvertTo_Lorg_opencv_core_Mat_ID (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConvertTo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_convertTo_Lorg_opencv_core_Mat_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='convertTo' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("convertTo", "(Lorg/opencv/core/Mat;ID)V", "GetConvertTo_Lorg_opencv_core_Mat_IDHandler")]
		public virtual unsafe void ConvertTo (global::OpenCV.Core.Mat p0, int p1, double p2)
		{
			if (id_convertTo_Lorg_opencv_core_Mat_ID == IntPtr.Zero)
				id_convertTo_Lorg_opencv_core_Mat_ID = JNIEnv.GetMethodID (class_ref, "convertTo", "(Lorg/opencv/core/Mat;ID)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertTo_Lorg_opencv_core_Mat_ID, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertTo", "(Lorg/opencv/core/Mat;ID)V"), __args);
			} finally {
			}
		}

		static Delegate cb_convertTo_Lorg_opencv_core_Mat_IDD;
#pragma warning disable 0169
		static Delegate GetConvertTo_Lorg_opencv_core_Mat_IDDHandler ()
		{
			if (cb_convertTo_Lorg_opencv_core_Mat_IDD == null)
				cb_convertTo_Lorg_opencv_core_Mat_IDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, double, double>) n_ConvertTo_Lorg_opencv_core_Mat_IDD);
			return cb_convertTo_Lorg_opencv_core_Mat_IDD;
		}

		static void n_ConvertTo_Lorg_opencv_core_Mat_IDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2, double p3)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConvertTo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_convertTo_Lorg_opencv_core_Mat_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='convertTo' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("convertTo", "(Lorg/opencv/core/Mat;IDD)V", "GetConvertTo_Lorg_opencv_core_Mat_IDDHandler")]
		public virtual unsafe void ConvertTo (global::OpenCV.Core.Mat p0, int p1, double p2, double p3)
		{
			if (id_convertTo_Lorg_opencv_core_Mat_IDD == IntPtr.Zero)
				id_convertTo_Lorg_opencv_core_Mat_IDD = JNIEnv.GetMethodID (class_ref, "convertTo", "(Lorg/opencv/core/Mat;IDD)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertTo_Lorg_opencv_core_Mat_IDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertTo", "(Lorg/opencv/core/Mat;IDD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_copyTo_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_copyTo_Lorg_opencv_core_Mat_ == null)
				cb_copyTo_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyTo_Lorg_opencv_core_Mat_);
			return cb_copyTo_Lorg_opencv_core_Mat_;
		}

		static void n_CopyTo_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_copyTo_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='copyTo' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("copyTo", "(Lorg/opencv/core/Mat;)V", "GetCopyTo_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void CopyTo (global::OpenCV.Core.Mat p0)
		{
			if (id_copyTo_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_copyTo_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "copyTo", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyTo_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyTo", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCopyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_CopyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='copyTo' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("copyTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetCopyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void CopyTo (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "copyTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_create_III;
#pragma warning disable 0169
		static Delegate GetCreate_IIIHandler ()
		{
			if (cb_create_III == null)
				cb_create_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_Create_III);
			return cb_create_III;
		}

		static void n_Create_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_create_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='create' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("create", "(III)V", "GetCreate_IIIHandler")]
		public virtual unsafe void Create (int p0, int p1, int p2)
		{
			if (id_create_III == IntPtr.Zero)
				id_create_III = JNIEnv.GetMethodID (class_ref, "create", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_create_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_create_Lorg_opencv_core_Size_I;
#pragma warning disable 0169
		static Delegate GetCreate_Lorg_opencv_core_Size_IHandler ()
		{
			if (cb_create_Lorg_opencv_core_Size_I == null)
				cb_create_Lorg_opencv_core_Size_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Create_Lorg_opencv_core_Size_I);
			return cb_create_Lorg_opencv_core_Size_I;
		}

		static void n_Create_Lorg_opencv_core_Size_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_create_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int']]"
		[Register ("create", "(Lorg/opencv/core/Size;I)V", "GetCreate_Lorg_opencv_core_Size_IHandler")]
		public virtual unsafe void Create (global::OpenCV.Core.Size p0, int p1)
		{
			if (id_create_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_create_Lorg_opencv_core_Size_I = JNIEnv.GetMethodID (class_ref, "create", "(Lorg/opencv/core/Size;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_create_Lorg_opencv_core_Size_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Lorg/opencv/core/Size;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cross_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCross_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_cross_Lorg_opencv_core_Mat_ == null)
				cb_cross_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Cross_Lorg_opencv_core_Mat_);
			return cb_cross_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_Cross_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Cross (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cross_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='cross' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("cross", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetCross_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Cross (global::OpenCV.Core.Mat p0)
		{
			if (id_cross_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_cross_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "cross", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cross_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cross", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dataAddr;
#pragma warning disable 0169
		static Delegate GetDataAddrHandler ()
		{
			if (cb_dataAddr == null)
				cb_dataAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_DataAddr);
			return cb_dataAddr;
		}

		static long n_DataAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataAddr ();
		}
#pragma warning restore 0169

		static IntPtr id_dataAddr;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='dataAddr' and count(parameter)=0]"
		[Register ("dataAddr", "()J", "GetDataAddrHandler")]
		public virtual unsafe long DataAddr ()
		{
			if (id_dataAddr == IntPtr.Zero)
				id_dataAddr = JNIEnv.GetMethodID (class_ref, "dataAddr", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_dataAddr);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dataAddr", "()J"));
			} finally {
			}
		}

		static Delegate cb_depth;
#pragma warning disable 0169
		static Delegate GetDepthHandler ()
		{
			if (cb_depth == null)
				cb_depth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Depth);
			return cb_depth;
		}

		static int n_Depth (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Depth ();
		}
#pragma warning restore 0169

		static IntPtr id_depth;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='depth' and count(parameter)=0]"
		[Register ("depth", "()I", "GetDepthHandler")]
		public virtual unsafe int Depth ()
		{
			if (id_depth == IntPtr.Zero)
				id_depth = JNIEnv.GetMethodID (class_ref, "depth", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_depth);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "depth", "()I"));
			} finally {
			}
		}

		static Delegate cb_diag;
#pragma warning disable 0169
		static Delegate GetDiagHandler ()
		{
			if (cb_diag == null)
				cb_diag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Diag);
			return cb_diag;
		}

		static IntPtr n_Diag (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Diag ());
		}
#pragma warning restore 0169

		static IntPtr id_diag;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='diag' and count(parameter)=0]"
		[Register ("diag", "()Lorg/opencv/core/Mat;", "GetDiagHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Diag ()
		{
			if (id_diag == IntPtr.Zero)
				id_diag = JNIEnv.GetMethodID (class_ref, "diag", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_diag), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "diag", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_diag_I;
#pragma warning disable 0169
		static Delegate GetDiag_IHandler ()
		{
			if (cb_diag_I == null)
				cb_diag_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Diag_I);
			return cb_diag_I;
		}

		static IntPtr n_Diag_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Diag (p0));
		}
#pragma warning restore 0169

		static IntPtr id_diag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='diag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("diag", "(I)Lorg/opencv/core/Mat;", "GetDiag_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Diag (int p0)
		{
			if (id_diag_I == IntPtr.Zero)
				id_diag_I = JNIEnv.GetMethodID (class_ref, "diag", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_diag_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "diag", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_diag_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='diag' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("diag", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Diag (global::OpenCV.Core.Mat p0)
		{
			if (id_diag_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_diag_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "diag", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_diag_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dims;
#pragma warning disable 0169
		static Delegate GetDimsHandler ()
		{
			if (cb_dims == null)
				cb_dims = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Dims);
			return cb_dims;
		}

		static int n_Dims (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dims ();
		}
#pragma warning restore 0169

		static IntPtr id_dims;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='dims' and count(parameter)=0]"
		[Register ("dims", "()I", "GetDimsHandler")]
		public virtual unsafe int Dims ()
		{
			if (id_dims == IntPtr.Zero)
				id_dims = JNIEnv.GetMethodID (class_ref, "dims", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_dims);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dims", "()I"));
			} finally {
			}
		}

		static Delegate cb_dot_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetDot_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_dot_Lorg_opencv_core_Mat_ == null)
				cb_dot_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Dot_Lorg_opencv_core_Mat_);
			return cb_dot_Lorg_opencv_core_Mat_;
		}

		static double n_Dot_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Dot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dot_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='dot' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("dot", "(Lorg/opencv/core/Mat;)D", "GetDot_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe double Dot (global::OpenCV.Core.Mat p0)
		{
			if (id_dot_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_dot_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "dot", "(Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_dot_Lorg_opencv_core_Mat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dot", "(Lorg/opencv/core/Mat;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dump;
#pragma warning disable 0169
		static Delegate GetDumpHandler ()
		{
			if (cb_dump == null)
				cb_dump = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Dump);
			return cb_dump;
		}

		static IntPtr n_Dump (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Dump ());
		}
#pragma warning restore 0169

		static IntPtr id_dump;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='dump' and count(parameter)=0]"
		[Register ("dump", "()Ljava/lang/String;", "GetDumpHandler")]
		public virtual unsafe string Dump ()
		{
			if (id_dump == IntPtr.Zero)
				id_dump = JNIEnv.GetMethodID (class_ref, "dump", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dump), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dump", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_elemSize;
#pragma warning disable 0169
		static Delegate GetElemSizeHandler ()
		{
			if (cb_elemSize == null)
				cb_elemSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ElemSize);
			return cb_elemSize;
		}

		static long n_ElemSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElemSize ();
		}
#pragma warning restore 0169

		static IntPtr id_elemSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='elemSize' and count(parameter)=0]"
		[Register ("elemSize", "()J", "GetElemSizeHandler")]
		public virtual unsafe long ElemSize ()
		{
			if (id_elemSize == IntPtr.Zero)
				id_elemSize = JNIEnv.GetMethodID (class_ref, "elemSize", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_elemSize);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "elemSize", "()J"));
			} finally {
			}
		}

		static Delegate cb_elemSize1;
#pragma warning disable 0169
		static Delegate GetElemSize1Handler ()
		{
			if (cb_elemSize1 == null)
				cb_elemSize1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ElemSize1);
			return cb_elemSize1;
		}

		static long n_ElemSize1 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElemSize1 ();
		}
#pragma warning restore 0169

		static IntPtr id_elemSize1;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='elemSize1' and count(parameter)=0]"
		[Register ("elemSize1", "()J", "GetElemSize1Handler")]
		public virtual unsafe long ElemSize1 ()
		{
			if (id_elemSize1 == IntPtr.Zero)
				id_elemSize1 = JNIEnv.GetMethodID (class_ref, "elemSize1", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_elemSize1);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "elemSize1", "()J"));
			} finally {
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetMethodID (class_ref, "empty", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_empty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "empty", "()Z"));
			} finally {
			}
		}

		static IntPtr id_eye_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='eye' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("eye", "(III)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Eye (int p0, int p1, int p2)
		{
			if (id_eye_III == IntPtr.Zero)
				id_eye_III = JNIEnv.GetStaticMethodID (class_ref, "eye", "(III)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_eye_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_eye_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='eye' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int']]"
		[Register ("eye", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Eye (global::OpenCV.Core.Size p0, int p1)
		{
			if (id_eye_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_eye_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "eye", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_eye_Lorg_opencv_core_Size_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_II;
#pragma warning disable 0169
		static Delegate GetGet_IIHandler ()
		{
			if (cb_get_II == null)
				cb_get_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Get_II);
			return cb_get_II;
		}

		static IntPtr n_Get_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Get (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_get_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("get", "(II)[D", "GetGet_IIHandler")]
		public virtual unsafe double[] Get (int p0, int p1)
		{
			if (id_get_II == IntPtr.Zero)
				id_get_II = JNIEnv.GetMethodID (class_ref, "get", "(II)[D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_II, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_get_IIarrayB;
#pragma warning disable 0169
		static Delegate GetGet_IIarrayBHandler ()
		{
			if (cb_get_IIarrayB == null)
				cb_get_IIarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Get_IIarrayB);
			return cb_get_IIarrayB;
		}

		static int n_Get_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Get (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("get", "(II[B)I", "GetGet_IIarrayBHandler")]
		public virtual unsafe int Get (int p0, int p1, byte[] p2)
		{
			if (id_get_IIarrayB == IntPtr.Zero)
				id_get_IIarrayB = JNIEnv.GetMethodID (class_ref, "get", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_IIarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II[B)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_get_IIarrayD;
#pragma warning disable 0169
		static Delegate GetGet_IIarrayDHandler ()
		{
			if (cb_get_IIarrayD == null)
				cb_get_IIarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Get_IIarrayD);
			return cb_get_IIarrayD;
		}

		static int n_Get_IIarrayD (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.Get (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IIarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("get", "(II[D)I", "GetGet_IIarrayDHandler")]
		public virtual unsafe int Get (int p0, int p1, double[] p2)
		{
			if (id_get_IIarrayD == IntPtr.Zero)
				id_get_IIarrayD = JNIEnv.GetMethodID (class_ref, "get", "(II[D)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_IIarrayD, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II[D)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_get_IIarrayF;
#pragma warning disable 0169
		static Delegate GetGet_IIarrayFHandler ()
		{
			if (cb_get_IIarrayF == null)
				cb_get_IIarrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Get_IIarrayF);
			return cb_get_IIarrayF;
		}

		static int n_Get_IIarrayF (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			int __ret = __this.Get (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float[]']]"
		[Register ("get", "(II[F)I", "GetGet_IIarrayFHandler")]
		public virtual unsafe int Get (int p0, int p1, float[] p2)
		{
			if (id_get_IIarrayF == IntPtr.Zero)
				id_get_IIarrayF = JNIEnv.GetMethodID (class_ref, "get", "(II[F)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_IIarrayF, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II[F)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_get_IIarrayI;
#pragma warning disable 0169
		static Delegate GetGet_IIarrayIHandler ()
		{
			if (cb_get_IIarrayI == null)
				cb_get_IIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Get_IIarrayI);
			return cb_get_IIarrayI;
		}

		static int n_Get_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.Get (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("get", "(II[I)I", "GetGet_IIarrayIHandler")]
		public virtual unsafe int Get (int p0, int p1, int[] p2)
		{
			if (id_get_IIarrayI == IntPtr.Zero)
				id_get_IIarrayI = JNIEnv.GetMethodID (class_ref, "get", "(II[I)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_IIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II[I)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_get_IIarrayS;
#pragma warning disable 0169
		static Delegate GetGet_IIarraySHandler ()
		{
			if (cb_get_IIarrayS == null)
				cb_get_IIarrayS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Get_IIarrayS);
			return cb_get_IIarrayS;
		}

		static int n_Get_IIarrayS (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p2 = (short[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.Get (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_IIarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='get' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='short[]']]"
		[Register ("get", "(II[S)I", "GetGet_IIarraySHandler")]
		public virtual unsafe int Get (int p0, int p1, short[] p2)
		{
			if (id_get_IIarrayS == IntPtr.Zero)
				id_get_IIarrayS = JNIEnv.GetMethodID (class_ref, "get", "(II[S)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_IIarrayS, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(II[S)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_height;
#pragma warning disable 0169
		static Delegate GetHeightHandler ()
		{
			if (cb_height == null)
				cb_height = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Height);
			return cb_height;
		}

		static int n_Height (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height ();
		}
#pragma warning restore 0169

		static IntPtr id_height;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='height' and count(parameter)=0]"
		[Register ("height", "()I", "GetHeightHandler")]
		public virtual unsafe int Height ()
		{
			if (id_height == IntPtr.Zero)
				id_height = JNIEnv.GetMethodID (class_ref, "height", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_height);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "height", "()I"));
			} finally {
			}
		}

		static Delegate cb_inv;
#pragma warning disable 0169
		static Delegate GetInvHandler ()
		{
			if (cb_inv == null)
				cb_inv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Inv);
			return cb_inv;
		}

		static IntPtr n_Inv (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inv ());
		}
#pragma warning restore 0169

		static IntPtr id_inv;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='inv' and count(parameter)=0]"
		[Register ("inv", "()Lorg/opencv/core/Mat;", "GetInvHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Inv ()
		{
			if (id_inv == IntPtr.Zero)
				id_inv = JNIEnv.GetMethodID (class_ref, "inv", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inv), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inv", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_inv_I;
#pragma warning disable 0169
		static Delegate GetInv_IHandler ()
		{
			if (cb_inv_I == null)
				cb_inv_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Inv_I);
			return cb_inv_I;
		}

		static IntPtr n_Inv_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inv (p0));
		}
#pragma warning restore 0169

		static IntPtr id_inv_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='inv' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("inv", "(I)Lorg/opencv/core/Mat;", "GetInv_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Inv (int p0)
		{
			if (id_inv_I == IntPtr.Zero)
				id_inv_I = JNIEnv.GetMethodID (class_ref, "inv", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inv_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inv", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetLocateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ == null)
				cb_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_);
			return cb_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_;
		}

		static void n_LocateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LocateROI (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='locateROI' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='org.opencv.core.Point']]"
		[Register ("locateROI", "(Lorg/opencv/core/Size;Lorg/opencv/core/Point;)V", "GetLocateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe void LocateROI (global::OpenCV.Core.Size p0, global::OpenCV.Core.Point p1)
		{
			if (id_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "locateROI", "(Lorg/opencv/core/Size;Lorg/opencv/core/Point;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_locateROI_Lorg_opencv_core_Size_Lorg_opencv_core_Point_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "locateROI", "(Lorg/opencv/core/Size;Lorg/opencv/core/Point;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_mul_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetMul_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_mul_Lorg_opencv_core_Mat_ == null)
				cb_mul_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Mul_Lorg_opencv_core_Mat_);
			return cb_mul_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_Mul_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mul (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mul_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='mul' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("mul", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetMul_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Mul (global::OpenCV.Core.Mat p0)
		{
			if (id_mul_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_mul_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "mul", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mul_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mul", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mul_Lorg_opencv_core_Mat_D;
#pragma warning disable 0169
		static Delegate GetMul_Lorg_opencv_core_Mat_DHandler ()
		{
			if (cb_mul_Lorg_opencv_core_Mat_D == null)
				cb_mul_Lorg_opencv_core_Mat_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double, IntPtr>) n_Mul_Lorg_opencv_core_Mat_D);
			return cb_mul_Lorg_opencv_core_Mat_D;
		}

		static IntPtr n_Mul_Lorg_opencv_core_Mat_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mul (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mul_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='mul' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double']]"
		[Register ("mul", "(Lorg/opencv/core/Mat;D)Lorg/opencv/core/Mat;", "GetMul_Lorg_opencv_core_Mat_DHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Mul (global::OpenCV.Core.Mat p0, double p1)
		{
			if (id_mul_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_mul_Lorg_opencv_core_Mat_D = JNIEnv.GetMethodID (class_ref, "mul", "(Lorg/opencv/core/Mat;D)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mul_Lorg_opencv_core_Mat_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mul", "(Lorg/opencv/core/Mat;D)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ones_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='ones' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ones", "(III)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Ones (int p0, int p1, int p2)
		{
			if (id_ones_III == IntPtr.Zero)
				id_ones_III = JNIEnv.GetStaticMethodID (class_ref, "ones", "(III)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ones_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ones_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='ones' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int']]"
		[Register ("ones", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Ones (global::OpenCV.Core.Size p0, int p1)
		{
			if (id_ones_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_ones_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "ones", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ones_Lorg_opencv_core_Size_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_push_back_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetPush_back_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_push_back_Lorg_opencv_core_Mat_ == null)
				cb_push_back_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Push_back_Lorg_opencv_core_Mat_);
			return cb_push_back_Lorg_opencv_core_Mat_;
		}

		static void n_Push_back_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Push_back (p0);
		}
#pragma warning restore 0169

		static IntPtr id_push_back_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='push_back' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("push_back", "(Lorg/opencv/core/Mat;)V", "GetPush_back_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Push_back (global::OpenCV.Core.Mat p0)
		{
			if (id_push_back_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_push_back_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "push_back", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_back_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "push_back", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_IIarrayB;
#pragma warning disable 0169
		static Delegate GetPut_IIarrayBHandler ()
		{
			if (cb_put_IIarrayB == null)
				cb_put_IIarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Put_IIarrayB);
			return cb_put_IIarrayB;
		}

		static int n_Put_IIarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Put (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_IIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("put", "(II[B)I", "GetPut_IIarrayBHandler")]
		public virtual unsafe int Put (int p0, int p1, byte[] p2)
		{
			if (id_put_IIarrayB == IntPtr.Zero)
				id_put_IIarrayB = JNIEnv.GetMethodID (class_ref, "put", "(II[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_put_IIarrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(II[B)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_put_IIarrayD;
#pragma warning disable 0169
		static Delegate GetPut_IIarrayDHandler ()
		{
			if (cb_put_IIarrayD == null)
				cb_put_IIarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Put_IIarrayD);
			return cb_put_IIarrayD;
		}

		static int n_Put_IIarrayD (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.Put (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_IIarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double...']]"
		[Register ("put", "(II[D)I", "GetPut_IIarrayDHandler")]
		public virtual unsafe int Put (int p0, int p1, params  double[] p2)
		{
			if (id_put_IIarrayD == IntPtr.Zero)
				id_put_IIarrayD = JNIEnv.GetMethodID (class_ref, "put", "(II[D)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_put_IIarrayD, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(II[D)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_put_IIarrayF;
#pragma warning disable 0169
		static Delegate GetPut_IIarrayFHandler ()
		{
			if (cb_put_IIarrayF == null)
				cb_put_IIarrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Put_IIarrayF);
			return cb_put_IIarrayF;
		}

		static int n_Put_IIarrayF (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			int __ret = __this.Put (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_IIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float[]']]"
		[Register ("put", "(II[F)I", "GetPut_IIarrayFHandler")]
		public virtual unsafe int Put (int p0, int p1, float[] p2)
		{
			if (id_put_IIarrayF == IntPtr.Zero)
				id_put_IIarrayF = JNIEnv.GetMethodID (class_ref, "put", "(II[F)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_put_IIarrayF, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(II[F)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_put_IIarrayI;
#pragma warning disable 0169
		static Delegate GetPut_IIarrayIHandler ()
		{
			if (cb_put_IIarrayI == null)
				cb_put_IIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Put_IIarrayI);
			return cb_put_IIarrayI;
		}

		static int n_Put_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.Put (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("put", "(II[I)I", "GetPut_IIarrayIHandler")]
		public virtual unsafe int Put (int p0, int p1, int[] p2)
		{
			if (id_put_IIarrayI == IntPtr.Zero)
				id_put_IIarrayI = JNIEnv.GetMethodID (class_ref, "put", "(II[I)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_put_IIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(II[I)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_put_IIarrayS;
#pragma warning disable 0169
		static Delegate GetPut_IIarraySHandler ()
		{
			if (cb_put_IIarrayS == null)
				cb_put_IIarrayS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_Put_IIarrayS);
			return cb_put_IIarrayS;
		}

		static int n_Put_IIarrayS (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p2 = (short[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.Put (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_IIarrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='put' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='short[]']]"
		[Register ("put", "(II[S)I", "GetPut_IIarraySHandler")]
		public virtual unsafe int Put (int p0, int p1, short[] p2)
		{
			if (id_put_IIarrayS == IntPtr.Zero)
				id_put_IIarrayS = JNIEnv.GetMethodID (class_ref, "put", "(II[S)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_put_IIarrayS, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(II[S)I"), __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
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
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_reshape_I;
#pragma warning disable 0169
		static Delegate GetReshape_IHandler ()
		{
			if (cb_reshape_I == null)
				cb_reshape_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Reshape_I);
			return cb_reshape_I;
		}

		static IntPtr n_Reshape_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reshape (p0));
		}
#pragma warning restore 0169

		static IntPtr id_reshape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='reshape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reshape", "(I)Lorg/opencv/core/Mat;", "GetReshape_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Reshape (int p0)
		{
			if (id_reshape_I == IntPtr.Zero)
				id_reshape_I = JNIEnv.GetMethodID (class_ref, "reshape", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reshape_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reshape", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reshape_II;
#pragma warning disable 0169
		static Delegate GetReshape_IIHandler ()
		{
			if (cb_reshape_II == null)
				cb_reshape_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Reshape_II);
			return cb_reshape_II;
		}

		static IntPtr n_Reshape_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reshape (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_reshape_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='reshape' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reshape", "(II)Lorg/opencv/core/Mat;", "GetReshape_IIHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Reshape (int p0, int p1)
		{
			if (id_reshape_II == IntPtr.Zero)
				id_reshape_II = JNIEnv.GetMethodID (class_ref, "reshape", "(II)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reshape_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reshape", "(II)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_row_I;
#pragma warning disable 0169
		static Delegate GetRow_IHandler ()
		{
			if (cb_row_I == null)
				cb_row_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Row_I);
			return cb_row_I;
		}

		static IntPtr n_Row_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Row (p0));
		}
#pragma warning restore 0169

		static IntPtr id_row_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='row' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("row", "(I)Lorg/opencv/core/Mat;", "GetRow_IHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Row (int p0)
		{
			if (id_row_I == IntPtr.Zero)
				id_row_I = JNIEnv.GetMethodID (class_ref, "row", "(I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_row_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "row", "(I)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rowRange_II;
#pragma warning disable 0169
		static Delegate GetRowRange_IIHandler ()
		{
			if (cb_rowRange_II == null)
				cb_rowRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_RowRange_II);
			return cb_rowRange_II;
		}

		static IntPtr n_RowRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RowRange (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_rowRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='rowRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rowRange", "(II)Lorg/opencv/core/Mat;", "GetRowRange_IIHandler")]
		public virtual unsafe global::OpenCV.Core.Mat RowRange (int p0, int p1)
		{
			if (id_rowRange_II == IntPtr.Zero)
				id_rowRange_II = JNIEnv.GetMethodID (class_ref, "rowRange", "(II)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rowRange_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rowRange", "(II)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rowRange_Lorg_opencv_core_Range_;
#pragma warning disable 0169
		static Delegate GetRowRange_Lorg_opencv_core_Range_Handler ()
		{
			if (cb_rowRange_Lorg_opencv_core_Range_ == null)
				cb_rowRange_Lorg_opencv_core_Range_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RowRange_Lorg_opencv_core_Range_);
			return cb_rowRange_Lorg_opencv_core_Range_;
		}

		static IntPtr n_RowRange_Lorg_opencv_core_Range_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Range p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RowRange (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rowRange_Lorg_opencv_core_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='rowRange' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Range']]"
		[Register ("rowRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;", "GetRowRange_Lorg_opencv_core_Range_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat RowRange (global::OpenCV.Core.Range p0)
		{
			if (id_rowRange_Lorg_opencv_core_Range_ == IntPtr.Zero)
				id_rowRange_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "rowRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rowRange_Lorg_opencv_core_Range_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rowRange", "(Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_rows;
#pragma warning disable 0169
		static Delegate GetRowsHandler ()
		{
			if (cb_rows == null)
				cb_rows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Rows);
			return cb_rows;
		}

		static int n_Rows (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rows ();
		}
#pragma warning restore 0169

		static IntPtr id_rows;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='rows' and count(parameter)=0]"
		[Register ("rows", "()I", "GetRowsHandler")]
		public virtual unsafe int Rows ()
		{
			if (id_rows == IntPtr.Zero)
				id_rows = JNIEnv.GetMethodID (class_ref, "rows", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rows);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rows", "()I"));
			} finally {
			}
		}

		static Delegate cb_setTo_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetTo_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setTo_Lorg_opencv_core_Mat_ == null)
				cb_setTo_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Lorg_opencv_core_Mat_);
			return cb_setTo_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_SetTo_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTo_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("setTo", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetSetTo_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat SetTo (global::OpenCV.Core.Mat p0)
		{
			if (id_setTo_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_setTo_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_SetTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='setTo' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("setTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetSetTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat SetTo (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTo_Lorg_opencv_core_Scalar_;
#pragma warning disable 0169
		static Delegate GetSetTo_Lorg_opencv_core_Scalar_Handler ()
		{
			if (cb_setTo_Lorg_opencv_core_Scalar_ == null)
				cb_setTo_Lorg_opencv_core_Scalar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Lorg_opencv_core_Scalar_);
			return cb_setTo_Lorg_opencv_core_Scalar_;
		}

		static IntPtr n_SetTo_Lorg_opencv_core_Scalar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Scalar p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTo_Lorg_opencv_core_Scalar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Scalar']]"
		[Register ("setTo", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Mat;", "GetSetTo_Lorg_opencv_core_Scalar_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat SetTo (global::OpenCV.Core.Scalar p0)
		{
			if (id_setTo_Lorg_opencv_core_Scalar_ == IntPtr.Zero)
				id_setTo_Lorg_opencv_core_Scalar_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Lorg_opencv_core_Scalar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Lorg/opencv/core/Scalar;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == null)
				cb_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_);
			return cb_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		}

		static IntPtr n_SetTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Scalar p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Scalar> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='setTo' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Scalar'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("setTo", "(Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "GetSetTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat SetTo (global::OpenCV.Core.Scalar p0, global::OpenCV.Core.Mat p1)
		{
			if (id_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Lorg_opencv_core_Scalar_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Lorg/opencv/core/Scalar;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Size);
			return cb_size;
		}

		static IntPtr n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size ());
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()Lorg/opencv/core/Size;", "GetSizeHandler")]
		public virtual unsafe global::OpenCV.Core.Size Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_size), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_step1;
#pragma warning disable 0169
		static Delegate GetStep1Handler ()
		{
			if (cb_step1 == null)
				cb_step1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Step1);
			return cb_step1;
		}

		static long n_Step1 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Step1 ();
		}
#pragma warning restore 0169

		static IntPtr id_step1;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='step1' and count(parameter)=0]"
		[Register ("step1", "()J", "GetStep1Handler")]
		public virtual unsafe long Step1 ()
		{
			if (id_step1 == IntPtr.Zero)
				id_step1 = JNIEnv.GetMethodID (class_ref, "step1", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_step1);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "step1", "()J"));
			} finally {
			}
		}

		static Delegate cb_step1_I;
#pragma warning disable 0169
		static Delegate GetStep1_IHandler ()
		{
			if (cb_step1_I == null)
				cb_step1_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_Step1_I);
			return cb_step1_I;
		}

		static long n_Step1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Step1 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_step1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='step1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("step1", "(I)J", "GetStep1_IHandler")]
		public virtual unsafe long Step1 (int p0)
		{
			if (id_step1_I == IntPtr.Zero)
				id_step1_I = JNIEnv.GetMethodID (class_ref, "step1", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_step1_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "step1", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_submat_IIII;
#pragma warning disable 0169
		static Delegate GetSubmat_IIIIHandler ()
		{
			if (cb_submat_IIII == null)
				cb_submat_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Submat_IIII);
			return cb_submat_IIII;
		}

		static IntPtr n_Submat_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Submat (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		static IntPtr id_submat_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='submat' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("submat", "(IIII)Lorg/opencv/core/Mat;", "GetSubmat_IIIIHandler")]
		public virtual unsafe global::OpenCV.Core.Mat Submat (int p0, int p1, int p2, int p3)
		{
			if (id_submat_IIII == IntPtr.Zero)
				id_submat_IIII = JNIEnv.GetMethodID (class_ref, "submat", "(IIII)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_submat_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "submat", "(IIII)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_;
#pragma warning disable 0169
		static Delegate GetSubmat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_Handler ()
		{
			if (cb_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ == null)
				cb_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_);
			return cb_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_;
		}

		static IntPtr n_Submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Range p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Range p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Range> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Submat (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='submat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Range'] and parameter[2][@type='org.opencv.core.Range']]"
		[Register ("submat", "(Lorg/opencv/core/Range;Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;", "GetSubmat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Submat (global::OpenCV.Core.Range p0, global::OpenCV.Core.Range p1)
		{
			if (id_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ == IntPtr.Zero)
				id_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_ = JNIEnv.GetMethodID (class_ref, "submat", "(Lorg/opencv/core/Range;Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_submat_Lorg_opencv_core_Range_Lorg_opencv_core_Range_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "submat", "(Lorg/opencv/core/Range;Lorg/opencv/core/Range;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_submat_Lorg_opencv_core_Rect_;
#pragma warning disable 0169
		static Delegate GetSubmat_Lorg_opencv_core_Rect_Handler ()
		{
			if (cb_submat_Lorg_opencv_core_Rect_ == null)
				cb_submat_Lorg_opencv_core_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Submat_Lorg_opencv_core_Rect_);
			return cb_submat_Lorg_opencv_core_Rect_;
		}

		static IntPtr n_Submat_Lorg_opencv_core_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Rect p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Submat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_submat_Lorg_opencv_core_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='submat' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
		[Register ("submat", "(Lorg/opencv/core/Rect;)Lorg/opencv/core/Mat;", "GetSubmat_Lorg_opencv_core_Rect_Handler")]
		public virtual unsafe global::OpenCV.Core.Mat Submat (global::OpenCV.Core.Rect p0)
		{
			if (id_submat_Lorg_opencv_core_Rect_ == IntPtr.Zero)
				id_submat_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "submat", "(Lorg/opencv/core/Rect;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::OpenCV.Core.Mat __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_submat_Lorg_opencv_core_Rect_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "submat", "(Lorg/opencv/core/Rect;)Lorg/opencv/core/Mat;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_t;
#pragma warning disable 0169
		static Delegate GetTHandler ()
		{
			if (cb_t == null)
				cb_t = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_T);
			return cb_t;
		}

		static IntPtr n_T (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.T ());
		}
#pragma warning restore 0169

		static IntPtr id_t;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='t' and count(parameter)=0]"
		[Register ("t", "()Lorg/opencv/core/Mat;", "GetTHandler")]
		public virtual unsafe global::OpenCV.Core.Mat T ()
		{
			if (id_t == IntPtr.Zero)
				id_t = JNIEnv.GetMethodID (class_ref, "t", "()Lorg/opencv/core/Mat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_t), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "t", "()Lorg/opencv/core/Mat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_total;
#pragma warning disable 0169
		static Delegate GetTotalHandler ()
		{
			if (cb_total == null)
				cb_total = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Total);
			return cb_total;
		}

		static long n_Total (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total ();
		}
#pragma warning restore 0169

		static IntPtr id_total;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='total' and count(parameter)=0]"
		[Register ("total", "()J", "GetTotalHandler")]
		public virtual unsafe long Total ()
		{
			if (id_total == IntPtr.Zero)
				id_total = JNIEnv.GetMethodID (class_ref, "total", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_total);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "total", "()J"));
			} finally {
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
			return cb_type;
		}

		static int n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()I", "GetTypeHandler")]
		public virtual unsafe int Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_type);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "type", "()I"));
			} finally {
			}
		}

		static Delegate cb_width;
#pragma warning disable 0169
		static Delegate GetWidthHandler ()
		{
			if (cb_width == null)
				cb_width = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Width);
			return cb_width;
		}

		static int n_Width (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Core.Mat __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width ();
		}
#pragma warning restore 0169

		static IntPtr id_width;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='width' and count(parameter)=0]"
		[Register ("width", "()I", "GetWidthHandler")]
		public virtual unsafe int Width ()
		{
			if (id_width == IntPtr.Zero)
				id_width = JNIEnv.GetMethodID (class_ref, "width", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_width);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "width", "()I"));
			} finally {
			}
		}

		static IntPtr id_zeros_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='zeros' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("zeros", "(III)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Zeros (int p0, int p1, int p2)
		{
			if (id_zeros_III == IntPtr.Zero)
				id_zeros_III = JNIEnv.GetStaticMethodID (class_ref, "zeros", "(III)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zeros_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_zeros_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='Mat']/method[@name='zeros' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='int']]"
		[Register ("zeros", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat Zeros (global::OpenCV.Core.Size p0, int p1)
		{
			if (id_zeros_Lorg_opencv_core_Size_I == IntPtr.Zero)
				id_zeros_Lorg_opencv_core_Size_I = JNIEnv.GetStaticMethodID (class_ref, "zeros", "(Lorg/opencv/core/Size;I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_zeros_Lorg_opencv_core_Size_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
