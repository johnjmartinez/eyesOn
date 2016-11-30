using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ObjDetect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']"
	[global::Android.Runtime.Register ("org/opencv/objdetect/CascadeClassifier", DoNotGenerateAcw=true)]
	public partial class CascadeClassifier : global::Java.Lang.Object {


		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/objdetect/CascadeClassifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CascadeClassifier); }
		}

		protected CascadeClassifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/constructor[@name='CascadeClassifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CascadeClassifier ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CascadeClassifier)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/constructor[@name='CascadeClassifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CascadeClassifier (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (CascadeClassifier)) {
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

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/constructor[@name='CascadeClassifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe CascadeClassifier (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CascadeClassifier)) {
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

		static Delegate cb_getFeatureType;
#pragma warning disable 0169
		static Delegate GetGetFeatureTypeHandler ()
		{
			if (cb_getFeatureType == null)
				cb_getFeatureType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFeatureType);
			return cb_getFeatureType;
		}

		static int n_GetFeatureType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FeatureType;
		}
#pragma warning restore 0169

		static IntPtr id_getFeatureType;
		public virtual unsafe int FeatureType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='getFeatureType' and count(parameter)=0]"
			[Register ("getFeatureType", "()I", "GetGetFeatureTypeHandler")]
			get {
				if (id_getFeatureType == IntPtr.Zero)
					id_getFeatureType = JNIEnv.GetMethodID (class_ref, "getFeatureType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFeatureType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatureType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isOldFormatCascade;
#pragma warning disable 0169
		static Delegate GetIsOldFormatCascadeHandler ()
		{
			if (cb_isOldFormatCascade == null)
				cb_isOldFormatCascade = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOldFormatCascade);
			return cb_isOldFormatCascade;
		}

		static bool n_IsOldFormatCascade (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOldFormatCascade;
		}
#pragma warning restore 0169

		static IntPtr id_isOldFormatCascade;
		public virtual unsafe bool IsOldFormatCascade {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='isOldFormatCascade' and count(parameter)=0]"
			[Register ("isOldFormatCascade", "()Z", "GetIsOldFormatCascadeHandler")]
			get {
				if (id_isOldFormatCascade == IntPtr.Zero)
					id_isOldFormatCascade = JNIEnv.GetMethodID (class_ref, "isOldFormatCascade", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOldFormatCascade);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOldFormatCascade", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOriginalWindowSize;
#pragma warning disable 0169
		static Delegate GetGetOriginalWindowSizeHandler ()
		{
			if (cb_getOriginalWindowSize == null)
				cb_getOriginalWindowSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalWindowSize);
			return cb_getOriginalWindowSize;
		}

		static IntPtr n_GetOriginalWindowSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OriginalWindowSize);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalWindowSize;
		public virtual unsafe global::OpenCV.Core.Size OriginalWindowSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='getOriginalWindowSize' and count(parameter)=0]"
			[Register ("getOriginalWindowSize", "()Lorg/opencv/core/Size;", "GetGetOriginalWindowSizeHandler")]
			get {
				if (id_getOriginalWindowSize == IntPtr.Zero)
					id_getOriginalWindowSize = JNIEnv.GetMethodID (class_ref, "getOriginalWindowSize", "()Lorg/opencv/core/Size;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalWindowSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalWindowSize", "()Lorg/opencv/core/Size;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_convert_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='convert' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("convert", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool Convert (string p0, string p1)
		{
			if (id_convert_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_convert_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convert", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_convert_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Handler ()
		{
			if (cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ == null)
				cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_);
			return cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_;
		}

		static void n_DetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfInt p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfInt> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale2 (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale2' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfInt']]"
		[Register ("detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;)V", "GetDetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Handler")]
		public virtual unsafe void DetectMultiScale2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfInt p2)
		{
			if (id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ == IntPtr.Zero)
				id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Handler ()
		{
			if (cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ == null)
				cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, IntPtr, IntPtr>) n_DetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_);
			return cb_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
		}

		static void n_DetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, double p3, int p4, int p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfInt p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfInt> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p6 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p7 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale2 (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale2' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfInt'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Size'] and parameter[8][@type='org.opencv.core.Size']]"
		[Register ("detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V", "GetDetectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Handler")]
		public virtual unsafe void DetectMultiScale2 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfInt p2, double p3, int p4, int p5, global::OpenCV.Core.Size p6, global::OpenCV.Core.Size p7)
		{
			if (id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale2_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale2", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_Handler ()
		{
			if (cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_ == null)
				cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_);
			return cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_;
		}

		static void n_DetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfInt p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfInt> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale3 (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale3' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfInt'] and parameter[4][@type='org.opencv.core.MatOfDouble']]"
		[Register ("detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;)V", "GetDetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_Handler")]
		public virtual unsafe void DetectMultiScale3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfInt p2, global::OpenCV.Core.MatOfDouble p3)
		{
			if (id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_ == IntPtr.Zero)
				id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ZHandler ()
		{
			if (cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z == null)
				cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, IntPtr, IntPtr, bool>) n_DetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z);
			return cb_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z;
		}

		static void n_DetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, double p4, int p5, int p6, IntPtr native_p7, IntPtr native_p8, bool p9)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfInt p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfInt> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDouble p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDouble> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p7 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p7, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p8 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale3 (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale3' and count(parameter)=10 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='org.opencv.core.MatOfInt'] and parameter[4][@type='org.opencv.core.MatOfDouble'] and parameter[5][@type='double'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Size'] and parameter[10][@type='boolean']]"
		[Register ("detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;Z)V", "GetDetectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ZHandler")]
		public virtual unsafe void DetectMultiScale3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, global::OpenCV.Core.MatOfInt p2, global::OpenCV.Core.MatOfDouble p3, double p4, int p5, int p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Size p8, bool p9)
		{
			if (id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z == IntPtr.Zero)
				id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z = JNIEnv.GetMethodID (class_ref, "detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;Z)V");
			try {
				JValue* __args = stackalloc JValue [10];
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale3_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_Lorg_opencv_core_MatOfDouble_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;Lorg/opencv/core/MatOfDouble;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Handler ()
		{
			if (cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_ == null)
				cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_);
			return cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_;
		}

		static void n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect']]"
		[Register ("detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;)V", "GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_Handler")]
		public virtual unsafe void DetectMultiScale (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1)
		{
			if (id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_ == IntPtr.Zero)
				id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
#pragma warning disable 0169
		static Delegate GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Handler ()
		{
			if (cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ == null)
				cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double, int, int, IntPtr, IntPtr>) n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_);
			return cb_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
		}

		static void n_DetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2, int p3, int p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfRect p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfRect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p5 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Size p6 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Size> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.DetectMultiScale (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='detectMultiScale' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfRect'] and parameter[3][@type='double'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.opencv.core.Size'] and parameter[7][@type='org.opencv.core.Size']]"
		[Register ("detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V", "GetDetectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_Handler")]
		public virtual unsafe void DetectMultiScale (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfRect p1, double p2, int p3, int p4, global::OpenCV.Core.Size p5, global::OpenCV.Core.Size p6)
		{
			if (id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_ = JNIEnv.GetMethodID (class_ref, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V");
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
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectMultiScale_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfRect_DIILorg_opencv_core_Size_Lorg_opencv_core_Size_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectMultiScale", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfRect;DIILorg/opencv/core/Size;Lorg/opencv/core/Size;)V"), __args);
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
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='empty' and count(parameter)=0]"
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
			global::OpenCV.ObjDetect.CascadeClassifier __this = global::Java.Lang.Object.GetObject<global::OpenCV.ObjDetect.CascadeClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Load (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_load_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='CascadeClassifier']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
