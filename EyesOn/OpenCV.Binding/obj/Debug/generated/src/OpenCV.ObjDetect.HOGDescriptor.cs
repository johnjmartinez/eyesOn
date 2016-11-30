using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ObjDetect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']"
	[global::Android.Runtime.Register ("org/opencv/objdetect/HOGDescriptor", DoNotGenerateAcw=true)]
	public partial class HOGDescriptor : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/field[@name='DEFAULT_NLEVELS']"
		[Register ("DEFAULT_NLEVELS")]
		public const int DefaultNlevels = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/field[@name='L2Hys']"
		[Register ("L2Hys")]
		public const int L2Hys = (int) 0;

		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/objdetect/HOGDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HOGDescriptor); }
		}

		protected HOGDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/constructor[@name='HOGDescriptor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HOGDescriptor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HOGDescriptor)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/constructor[@name='HOGDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HOGDescriptor (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HOGDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/constructor[@name='HOGDescriptor' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;I)V", "")]
		public unsafe HOGDescriptor (global::OpenCV.Core.Size p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Size p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (HOGDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;I)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_I == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_IIDIDZIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/constructor[@name='HOGDescriptor' and count(parameter)=12 and parameter[1][@type='org.opencv.core.Size'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='double'] and parameter[8][@type='int'] and parameter[9][@type='double'] and parameter[10][@type='boolean'] and parameter[11][@type='int'] and parameter[12][@type='boolean']]"
		[Register (".ctor", "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;IIDIDZIZ)V", "")]
		public unsafe HOGDescriptor (global::OpenCV.Core.Size p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Size p3, int p4, int p5, double p6, int p7, double p8, bool p9, int p10, bool p11)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				if (GetType () != typeof (HOGDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;IIDIDZIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;IIDIDZIZ)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_IIDIDZIZ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_IIDIDZIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/Size;IIDIDZIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_IIDIDZIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_Size_IIDIDZIZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/constructor[@name='HOGDescriptor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe HOGDescriptor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HOGDescriptor)) {
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

		static IntPtr id_getDaimlerPeopleDetector;
		public static unsafe global::OpenCV.Core.MatOfFloat DaimlerPeopleDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='getDaimlerPeopleDetector' and count(parameter)=0]"
			[Register ("getDaimlerPeopleDetector", "()Lorg/opencv/core/MatOfFloat;", "GetGetDaimlerPeopleDetectorHandler")]
			get {
				if (id_getDaimlerPeopleDetector == IntPtr.Zero)
					id_getDaimlerPeopleDetector = JNIEnv.GetStaticMethodID (class_ref, "getDaimlerPeopleDetector", "()Lorg/opencv/core/MatOfFloat;");
				try {
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDaimlerPeopleDetector), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDefaultPeopleDetector;
		public static unsafe global::OpenCV.Core.MatOfFloat DefaultPeopleDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='getDefaultPeopleDetector' and count(parameter)=0]"
			[Register ("getDefaultPeopleDetector", "()Lorg/opencv/core/MatOfFloat;", "GetGetDefaultPeopleDetectorHandler")]
			get {
				if (id_getDefaultPeopleDetector == IntPtr.Zero)
					id_getDefaultPeopleDetector = JNIEnv.GetStaticMethodID (class_ref, "getDefaultPeopleDetector", "()Lorg/opencv/core/MatOfFloat;");
				try {
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultPeopleDetector), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescriptorSize;
#pragma warning disable 0169
		static Delegate GetGetDescriptorSizeHandler ()
		{
			if (cb_getDescriptorSize == null)
				cb_getDescriptorSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDescriptorSize);
			return cb_getDescriptorSize;
		}

		static long n_GetDescriptorSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescriptorSize;
		}
#pragma warning restore 0169

		static IntPtr id_getDescriptorSize;
		public virtual unsafe long DescriptorSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='getDescriptorSize' and count(parameter)=0]"
			[Register ("getDescriptorSize", "()J", "GetGetDescriptorSizeHandler")]
			get {
				if (id_getDescriptorSize == IntPtr.Zero)
					id_getDescriptorSize = JNIEnv.GetMethodID (class_ref, "getDescriptorSize", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDescriptorSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescriptorSize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getWinSigma;
#pragma warning disable 0169
		static Delegate GetGetWinSigmaHandler ()
		{
			if (cb_getWinSigma == null)
				cb_getWinSigma = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetWinSigma);
			return cb_getWinSigma;
		}

		static double n_GetWinSigma (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WinSigma;
		}
#pragma warning restore 0169

		static IntPtr id_getWinSigma;
		public virtual unsafe double WinSigma {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='getWinSigma' and count(parameter)=0]"
			[Register ("getWinSigma", "()D", "GetGetWinSigmaHandler")]
			get {
				if (id_getWinSigma == IntPtr.Zero)
					id_getWinSigma = JNIEnv.GetMethodID (class_ref, "getWinSigma", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getWinSigma);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWinSigma", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_checkDetectorSize;
#pragma warning disable 0169
		static Delegate GetCheckDetectorSizeHandler ()
		{
			if (cb_checkDetectorSize == null)
				cb_checkDetectorSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckDetectorSize);
			return cb_checkDetectorSize;
		}

		static bool n_CheckDetectorSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckDetectorSize ();
		}
#pragma warning restore 0169

		static IntPtr id_checkDetectorSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='checkDetectorSize' and count(parameter)=0]"
		[Register ("checkDetectorSize", "()Z", "GetCheckDetectorSizeHandler")]
		public virtual unsafe bool CheckDetectorSize ()
		{
			if (id_checkDetectorSize == IntPtr.Zero)
				id_checkDetectorSize = JNIEnv.GetMethodID (class_ref, "checkDetectorSize", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkDetectorSize);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkDetectorSize", "()Z"));
			} finally {
			}
		}

		static Delegate cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Handler ()
		{
			if (cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ == null)
				cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_);
			return cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_;
		}

		static void n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfFloat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Compute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='compute' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfFloat']]"
		[Register ("compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;)V", "GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Handler")]
		public virtual unsafe void Compute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfFloat p1)
		{
			if (id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ == IntPtr.Zero)
				id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ = JNIEnv.GetMethodID (class_ref, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_Handler ()
		{
			if (cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ == null)
				cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_);
			return cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
		}

		static void n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfFloat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Compute (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='compute' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfFloat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.MatOfPoint']]"
		[Register ("compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V", "GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_Handler")]
		public virtual unsafe void Compute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfFloat p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.MatOfPoint p4)
		{
			if (id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ == IntPtr.Zero)
				id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ = JNIEnv.GetMethodID (class_ref, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == null)
				cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_);
			return cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		}

		static void n_ComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ComputeGradient (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='computeGradient' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "GetComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void ComputeGradient (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_;
#pragma warning disable 0169
		static Delegate GetComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Handler ()
		{
			if (cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_ == null)
				cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_);
			return cb_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_;
		}

		static void n_ComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.ComputeGradient (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='computeGradient' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Size']]"
		[Register ("computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;)V", "GetComputeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_Handler")]
		public virtual unsafe void ComputeGradient (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Size p4)
		{
			if (id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_computeGradient_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Size_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeGradient", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Size;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='detect' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='org.opencv.core.MatOfDouble']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, global::OpenCV.Core.MatOfDouble p2)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
#pragma warning disable 0169
		static Delegate GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_Handler ()
		{
			if (cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ == null)
				cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_);
			return cb_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
		}

		static void n_Detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p5 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint p6 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.Detect (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='detect' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfPoint'] and parameter[3][@type='org.opencv.core.MatOfDouble'] and parameter[4][@type='double'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='org.opencv.core.Size'] and parameter[7][@type='org.opencv.core.MatOfPoint']]"
		[Register ("detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V", "GetDetect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_Handler")]
		public virtual unsafe void Detect (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfPoint p1, global::OpenCV.Core.MatOfDouble p2, double p3, global::OpenCV.Core.Size p4, global::OpenCV.Core.Size p5, global::OpenCV.Core.MatOfPoint p6)
		{
			if (id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ == IntPtr.Zero)
				id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_ = JNIEnv.GetMethodID (class_ref, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detect_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfPoint_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detect", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfPoint;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_Handler ()
		{
			if (cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_ == null)
				cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_);
			return cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_;
		}

		static void n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='detectMultiScale' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfDouble']]"
		[Register ("detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;)V", "GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_Handler")]
		public virtual unsafe void DetectMultiScale (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfDouble p2)
		{
			if (id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_ == IntPtr.Zero)
				id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZHandler ()
		{
			if (cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ == null)
				cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr, IntPtr, double, double, bool>) n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ);
			return cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ;
		}

		static void n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, IntPtr native_p4, IntPtr native_p5, double p6, double p7, bool p8)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p5 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='detectMultiScale' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfDouble'] and parameter[4][@type='double'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='org.opencv.core.Size'] and parameter[7][@type='double'] and parameter[8][@type='double'] and parameter[9][@type='boolean']]"
		[Register ("detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;DDZ)V", "GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZHandler")]
		public virtual unsafe void DetectMultiScale (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfDouble p2, double p3, global::OpenCV.Core.Size p4, global::OpenCV.Core.Size p5, double p6, double p7, bool p8)
		{
			if (id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ == IntPtr.Zero)
				id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ = JNIEnv.GetMethodID (class_ref, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;DDZ)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfDouble_DLorg_opencv_core_Size_Lorg_opencv_core_Size_DDZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfDouble;DLorg/opencv/core/Size;Lorg/opencv/core/Size;DDZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_L2HysThreshold;
#pragma warning disable 0169
		static Delegate GetGet_L2HysThresholdHandler ()
		{
			if (cb_get_L2HysThreshold == null)
				cb_get_L2HysThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_L2HysThreshold);
			return cb_get_L2HysThreshold;
		}

		static double n_Get_L2HysThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_L2HysThreshold ();
		}
#pragma warning restore 0169

		static IntPtr id_get_L2HysThreshold;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_L2HysThreshold' and count(parameter)=0]"
		[Register ("get_L2HysThreshold", "()D", "GetGet_L2HysThresholdHandler")]
		public virtual unsafe double Get_L2HysThreshold ()
		{
			if (id_get_L2HysThreshold == IntPtr.Zero)
				id_get_L2HysThreshold = JNIEnv.GetMethodID (class_ref, "get_L2HysThreshold", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_L2HysThreshold);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_L2HysThreshold", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_blockSize;
#pragma warning disable 0169
		static Delegate GetGet_blockSizeHandler ()
		{
			if (cb_get_blockSize == null)
				cb_get_blockSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_blockSize);
			return cb_get_blockSize;
		}

		static IntPtr n_Get_blockSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_blockSize ());
		}
#pragma warning restore 0169

		static IntPtr id_get_blockSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_blockSize' and count(parameter)=0]"
		[Register ("get_blockSize", "()Lorg/opencv/core/Size;", "GetGet_blockSizeHandler")]
		public virtual unsafe global::OpenCV.Core.Size Get_blockSize ()
		{
			if (id_get_blockSize == IntPtr.Zero)
				id_get_blockSize = JNIEnv.GetMethodID (class_ref, "get_blockSize", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_blockSize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_blockSize", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_blockStride;
#pragma warning disable 0169
		static Delegate GetGet_blockStrideHandler ()
		{
			if (cb_get_blockStride == null)
				cb_get_blockStride = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_blockStride);
			return cb_get_blockStride;
		}

		static IntPtr n_Get_blockStride (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_blockStride ());
		}
#pragma warning restore 0169

		static IntPtr id_get_blockStride;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_blockStride' and count(parameter)=0]"
		[Register ("get_blockStride", "()Lorg/opencv/core/Size;", "GetGet_blockStrideHandler")]
		public virtual unsafe global::OpenCV.Core.Size Get_blockStride ()
		{
			if (id_get_blockStride == IntPtr.Zero)
				id_get_blockStride = JNIEnv.GetMethodID (class_ref, "get_blockStride", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_blockStride), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_blockStride", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_cellSize;
#pragma warning disable 0169
		static Delegate GetGet_cellSizeHandler ()
		{
			if (cb_get_cellSize == null)
				cb_get_cellSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_cellSize);
			return cb_get_cellSize;
		}

		static IntPtr n_Get_cellSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_cellSize ());
		}
#pragma warning restore 0169

		static IntPtr id_get_cellSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_cellSize' and count(parameter)=0]"
		[Register ("get_cellSize", "()Lorg/opencv/core/Size;", "GetGet_cellSizeHandler")]
		public virtual unsafe global::OpenCV.Core.Size Get_cellSize ()
		{
			if (id_get_cellSize == IntPtr.Zero)
				id_get_cellSize = JNIEnv.GetMethodID (class_ref, "get_cellSize", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_cellSize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_cellSize", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_derivAperture;
#pragma warning disable 0169
		static Delegate GetGet_derivApertureHandler ()
		{
			if (cb_get_derivAperture == null)
				cb_get_derivAperture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_derivAperture);
			return cb_get_derivAperture;
		}

		static int n_Get_derivAperture (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_derivAperture ();
		}
#pragma warning restore 0169

		static IntPtr id_get_derivAperture;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_derivAperture' and count(parameter)=0]"
		[Register ("get_derivAperture", "()I", "GetGet_derivApertureHandler")]
		public virtual unsafe int Get_derivAperture ()
		{
			if (id_get_derivAperture == IntPtr.Zero)
				id_get_derivAperture = JNIEnv.GetMethodID (class_ref, "get_derivAperture", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_derivAperture);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_derivAperture", "()I"));
			} finally {
			}
		}

		static Delegate cb_get_gammaCorrection;
#pragma warning disable 0169
		static Delegate GetGet_gammaCorrectionHandler ()
		{
			if (cb_get_gammaCorrection == null)
				cb_get_gammaCorrection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Get_gammaCorrection);
			return cb_get_gammaCorrection;
		}

		static bool n_Get_gammaCorrection (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_gammaCorrection ();
		}
#pragma warning restore 0169

		static IntPtr id_get_gammaCorrection;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_gammaCorrection' and count(parameter)=0]"
		[Register ("get_gammaCorrection", "()Z", "GetGet_gammaCorrectionHandler")]
		public virtual unsafe bool Get_gammaCorrection ()
		{
			if (id_get_gammaCorrection == IntPtr.Zero)
				id_get_gammaCorrection = JNIEnv.GetMethodID (class_ref, "get_gammaCorrection", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_get_gammaCorrection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_gammaCorrection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_get_histogramNormType;
#pragma warning disable 0169
		static Delegate GetGet_histogramNormTypeHandler ()
		{
			if (cb_get_histogramNormType == null)
				cb_get_histogramNormType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_histogramNormType);
			return cb_get_histogramNormType;
		}

		static int n_Get_histogramNormType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_histogramNormType ();
		}
#pragma warning restore 0169

		static IntPtr id_get_histogramNormType;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_histogramNormType' and count(parameter)=0]"
		[Register ("get_histogramNormType", "()I", "GetGet_histogramNormTypeHandler")]
		public virtual unsafe int Get_histogramNormType ()
		{
			if (id_get_histogramNormType == IntPtr.Zero)
				id_get_histogramNormType = JNIEnv.GetMethodID (class_ref, "get_histogramNormType", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_histogramNormType);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_histogramNormType", "()I"));
			} finally {
			}
		}

		static Delegate cb_get_nbins;
#pragma warning disable 0169
		static Delegate GetGet_nbinsHandler ()
		{
			if (cb_get_nbins == null)
				cb_get_nbins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_nbins);
			return cb_get_nbins;
		}

		static int n_Get_nbins (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nbins ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nbins;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_nbins' and count(parameter)=0]"
		[Register ("get_nbins", "()I", "GetGet_nbinsHandler")]
		public virtual unsafe int Get_nbins ()
		{
			if (id_get_nbins == IntPtr.Zero)
				id_get_nbins = JNIEnv.GetMethodID (class_ref, "get_nbins", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_nbins);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nbins", "()I"));
			} finally {
			}
		}

		static Delegate cb_get_nlevels;
#pragma warning disable 0169
		static Delegate GetGet_nlevelsHandler ()
		{
			if (cb_get_nlevels == null)
				cb_get_nlevels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_nlevels);
			return cb_get_nlevels;
		}

		static int n_Get_nlevels (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nlevels ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nlevels;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_nlevels' and count(parameter)=0]"
		[Register ("get_nlevels", "()I", "GetGet_nlevelsHandler")]
		public virtual unsafe int Get_nlevels ()
		{
			if (id_get_nlevels == IntPtr.Zero)
				id_get_nlevels = JNIEnv.GetMethodID (class_ref, "get_nlevels", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_get_nlevels);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nlevels", "()I"));
			} finally {
			}
		}

		static Delegate cb_get_signedGradient;
#pragma warning disable 0169
		static Delegate GetGet_signedGradientHandler ()
		{
			if (cb_get_signedGradient == null)
				cb_get_signedGradient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Get_signedGradient);
			return cb_get_signedGradient;
		}

		static bool n_Get_signedGradient (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_signedGradient ();
		}
#pragma warning restore 0169

		static IntPtr id_get_signedGradient;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_signedGradient' and count(parameter)=0]"
		[Register ("get_signedGradient", "()Z", "GetGet_signedGradientHandler")]
		public virtual unsafe bool Get_signedGradient ()
		{
			if (id_get_signedGradient == IntPtr.Zero)
				id_get_signedGradient = JNIEnv.GetMethodID (class_ref, "get_signedGradient", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_get_signedGradient);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_signedGradient", "()Z"));
			} finally {
			}
		}

		static Delegate cb_get_svmDetector;
#pragma warning disable 0169
		static Delegate GetGet_svmDetectorHandler ()
		{
			if (cb_get_svmDetector == null)
				cb_get_svmDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_svmDetector);
			return cb_get_svmDetector;
		}

		static IntPtr n_Get_svmDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_svmDetector ());
		}
#pragma warning restore 0169

		static IntPtr id_get_svmDetector;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_svmDetector' and count(parameter)=0]"
		[Register ("get_svmDetector", "()Lorg/opencv/core/MatOfFloat;", "GetGet_svmDetectorHandler")]
		public virtual unsafe global::OpenCV.Core.MatOfFloat Get_svmDetector ()
		{
			if (id_get_svmDetector == IntPtr.Zero)
				id_get_svmDetector = JNIEnv.GetMethodID (class_ref, "get_svmDetector", "()Lorg/opencv/core/MatOfFloat;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_svmDetector), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_svmDetector", "()Lorg/opencv/core/MatOfFloat;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_winSigma;
#pragma warning disable 0169
		static Delegate GetGet_winSigmaHandler ()
		{
			if (cb_get_winSigma == null)
				cb_get_winSigma = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_winSigma);
			return cb_get_winSigma;
		}

		static double n_Get_winSigma (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_winSigma ();
		}
#pragma warning restore 0169

		static IntPtr id_get_winSigma;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_winSigma' and count(parameter)=0]"
		[Register ("get_winSigma", "()D", "GetGet_winSigmaHandler")]
		public virtual unsafe double Get_winSigma ()
		{
			if (id_get_winSigma == IntPtr.Zero)
				id_get_winSigma = JNIEnv.GetMethodID (class_ref, "get_winSigma", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_winSigma);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_winSigma", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_winSize;
#pragma warning disable 0169
		static Delegate GetGet_winSizeHandler ()
		{
			if (cb_get_winSize == null)
				cb_get_winSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_winSize);
			return cb_get_winSize;
		}

		static IntPtr n_Get_winSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_winSize ());
		}
#pragma warning restore 0169

		static IntPtr id_get_winSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='get_winSize' and count(parameter)=0]"
		[Register ("get_winSize", "()Lorg/opencv/core/Size;", "GetGet_winSizeHandler")]
		public virtual unsafe global::OpenCV.Core.Size Get_winSize ()
		{
			if (id_get_winSize == IntPtr.Zero)
				id_get_winSize = JNIEnv.GetMethodID (class_ref, "get_winSize", "()Lorg/opencv/core/Size;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_winSize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_winSize", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static bool n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Load (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)Z", "GetLoad_Ljava_lang_String_Handler")]
		public virtual unsafe bool Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_load_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Load_Ljava_lang_String_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Load_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Load (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='load' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetLoad_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Load (string p0, string p1)
		{
			if (id_load_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_save_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='save' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string p0)
		{
			if (id_save_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_save_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string p0, string p1)
		{
			if (id_save_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setSVMDetector_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetSetSVMDetector_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_setSVMDetector_Lorg_opencv_core_Mat_ == null)
				cb_setSVMDetector_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSVMDetector_Lorg_opencv_core_Mat_);
			return cb_setSVMDetector_Lorg_opencv_core_Mat_;
		}

		static void n_SetSVMDetector_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ObjDetect.HOGDescriptor __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.HOGDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSVMDetector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSVMDetector_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='HOGDescriptor']/method[@name='setSVMDetector' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Mat']]"
		[Register ("setSVMDetector", "(Lorg/opencv/core/Mat;)V", "GetSetSVMDetector_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void SetSVMDetector (global::OpenCV.Core.Mat p0)
		{
			if (id_setSVMDetector_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_setSVMDetector_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "setSVMDetector", "(Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSVMDetector_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSVMDetector", "(Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

	}
}
