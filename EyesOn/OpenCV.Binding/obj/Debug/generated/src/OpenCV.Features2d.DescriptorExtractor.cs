using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Features2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']"
	[global::Android.Runtime.Register ("org/opencv/features2d/DescriptorExtractor", DoNotGenerateAcw=true)]
	public partial class DescriptorExtractor : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='AKAZE']"
		[Register ("AKAZE")]
		public const int Akaze = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='BRIEF']"
		[Register ("BRIEF")]
		public const int Brief = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='BRISK']"
		[Register ("BRISK")]
		public const int Brisk = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='FREAK']"
		[Register ("FREAK")]
		public const int Freak = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_AKAZE']"
		[Register ("OPPONENT_AKAZE")]
		public const int OpponentAkaze = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_BRIEF']"
		[Register ("OPPONENT_BRIEF")]
		public const int OpponentBrief = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_BRISK']"
		[Register ("OPPONENT_BRISK")]
		public const int OpponentBrisk = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_FREAK']"
		[Register ("OPPONENT_FREAK")]
		public const int OpponentFreak = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_ORB']"
		[Register ("OPPONENT_ORB")]
		public const int OpponentOrb = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_SIFT']"
		[Register ("OPPONENT_SIFT")]
		public const int OpponentSift = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='OPPONENT_SURF']"
		[Register ("OPPONENT_SURF")]
		public const int OpponentSurf = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='ORB']"
		[Register ("ORB")]
		public const int Orb = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='SIFT']"
		[Register ("SIFT")]
		public const int Sift = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='SURF']"
		[Register ("SURF")]
		public const int Surf = (int) 2;

		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/features2d/DescriptorExtractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DescriptorExtractor); }
		}

		protected DescriptorExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/constructor[@name='DescriptorExtractor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe DescriptorExtractor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DescriptorExtractor)) {
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

		static Delegate cb_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCompute_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
				cb_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_);
			return cb_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		static void n_Compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Compute (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='compute' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfKeyPoint&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("compute", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetCompute_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void Compute (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfKeyPoint> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2)
		{
			if (id_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "compute", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfKeyPoint>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_Ljava_util_List_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ == null)
				cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_);
			return cb_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
		}

		static void n_Compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfKeyPoint p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfKeyPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Compute (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='compute' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfKeyPoint'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V", "GetCompute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Compute (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfKeyPoint p1, global::OpenCV.Core.Mat p2)
		{
			if (id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compute_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfKeyPoint_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compute", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfKeyPoint;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/opencv/features2d/DescriptorExtractor;", "")]
		public static unsafe global::OpenCV.Features2d.DescriptorExtractor Create (int p0)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lorg/opencv/features2d/DescriptorExtractor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_descriptorSize;
#pragma warning disable 0169
		static Delegate GetDescriptorSizeHandler ()
		{
			if (cb_descriptorSize == null)
				cb_descriptorSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescriptorSize);
			return cb_descriptorSize;
		}

		static int n_DescriptorSize (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescriptorSize ();
		}
#pragma warning restore 0169

		static IntPtr id_descriptorSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='descriptorSize' and count(parameter)=0]"
		[Register ("descriptorSize", "()I", "GetDescriptorSizeHandler")]
		public virtual unsafe int DescriptorSize ()
		{
			if (id_descriptorSize == IntPtr.Zero)
				id_descriptorSize = JNIEnv.GetMethodID (class_ref, "descriptorSize", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_descriptorSize);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "descriptorSize", "()I"));
			} finally {
			}
		}

		static Delegate cb_descriptorType;
#pragma warning disable 0169
		static Delegate GetDescriptorTypeHandler ()
		{
			if (cb_descriptorType == null)
				cb_descriptorType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescriptorType);
			return cb_descriptorType;
		}

		static int n_DescriptorType (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescriptorType ();
		}
#pragma warning restore 0169

		static IntPtr id_descriptorType;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='descriptorType' and count(parameter)=0]"
		[Register ("descriptorType", "()I", "GetDescriptorTypeHandler")]
		public virtual unsafe int DescriptorType ()
		{
			if (id_descriptorType == IntPtr.Zero)
				id_descriptorType = JNIEnv.GetMethodID (class_ref, "descriptorType", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_descriptorType);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "descriptorType", "()I"));
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
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='empty' and count(parameter)=0]"
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

		static Delegate cb_read_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_lang_String_Handler ()
		{
			if (cb_read_Ljava_lang_String_ == null)
				cb_read_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_lang_String_);
			return cb_read_Ljava_lang_String_;
		}

		static void n_Read_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)V", "GetRead_Ljava_lang_String_Handler")]
		public virtual unsafe void Read (string p0)
		{
			if (id_read_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_String_Handler ()
		{
			if (cb_write_Ljava_lang_String_ == null)
				cb_write_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_String_);
			return cb_write_Ljava_lang_String_;
		}

		static void n_Write_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.DescriptorExtractor __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorExtractor']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("write", "(Ljava/lang/String;)V", "GetWrite_Ljava_lang_String_Handler")]
		public virtual unsafe void Write (string p0)
		{
			if (id_write_Ljava_lang_String_ == IntPtr.Zero)
				id_write_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
