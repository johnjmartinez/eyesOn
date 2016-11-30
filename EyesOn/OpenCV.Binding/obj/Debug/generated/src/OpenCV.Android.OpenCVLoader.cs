using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']"
	[global::Android.Runtime.Register ("org/opencv/android/OpenCVLoader", DoNotGenerateAcw=true)]
	public partial class OpenCVLoader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_10']"
		[Register ("OPENCV_VERSION_2_4_10")]
		public const string OpencvVersion2410 = (string) "2.4.10";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_11']"
		[Register ("OPENCV_VERSION_2_4_11")]
		public const string OpencvVersion2411 = (string) "2.4.11";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_2']"
		[Register ("OPENCV_VERSION_2_4_2")]
		public const string OpencvVersion242 = (string) "2.4.2";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_3']"
		[Register ("OPENCV_VERSION_2_4_3")]
		public const string OpencvVersion243 = (string) "2.4.3";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_4']"
		[Register ("OPENCV_VERSION_2_4_4")]
		public const string OpencvVersion244 = (string) "2.4.4";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_5']"
		[Register ("OPENCV_VERSION_2_4_5")]
		public const string OpencvVersion245 = (string) "2.4.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_6']"
		[Register ("OPENCV_VERSION_2_4_6")]
		public const string OpencvVersion246 = (string) "2.4.6";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_7']"
		[Register ("OPENCV_VERSION_2_4_7")]
		public const string OpencvVersion247 = (string) "2.4.7";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_8']"
		[Register ("OPENCV_VERSION_2_4_8")]
		public const string OpencvVersion248 = (string) "2.4.8";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_2_4_9']"
		[Register ("OPENCV_VERSION_2_4_9")]
		public const string OpencvVersion249 = (string) "2.4.9";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_3_0_0']"
		[Register ("OPENCV_VERSION_3_0_0")]
		public const string OpencvVersion300 = (string) "3.0.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/field[@name='OPENCV_VERSION_3_1_0']"
		[Register ("OPENCV_VERSION_3_1_0")]
		public const string OpencvVersion310 = (string) "3.1.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/OpenCVLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenCVLoader); }
		}

		protected OpenCVLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/constructor[@name='OpenCVLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenCVLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OpenCVLoader)) {
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

		static IntPtr id_initAsync_Ljava_lang_String_Landroid_content_Context_Lorg_opencv_android_LoaderCallbackInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/method[@name='initAsync' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='org.opencv.android.LoaderCallbackInterface']]"
		[Register ("initAsync", "(Ljava/lang/String;Landroid/content/Context;Lorg/opencv/android/LoaderCallbackInterface;)Z", "")]
		public static unsafe bool InitAsync (string p0, global::Android.Content.Context p1, global::OpenCV.Android.ILoaderCallbackInterface p2)
		{
			if (id_initAsync_Ljava_lang_String_Landroid_content_Context_Lorg_opencv_android_LoaderCallbackInterface_ == IntPtr.Zero)
				id_initAsync_Ljava_lang_String_Landroid_content_Context_Lorg_opencv_android_LoaderCallbackInterface_ = JNIEnv.GetStaticMethodID (class_ref, "initAsync", "(Ljava/lang/String;Landroid/content/Context;Lorg/opencv/android/LoaderCallbackInterface;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initAsync_Ljava_lang_String_Landroid_content_Context_Lorg_opencv_android_LoaderCallbackInterface_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initDebug;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/method[@name='initDebug' and count(parameter)=0]"
		[Register ("initDebug", "()Z", "")]
		public static unsafe bool InitDebug ()
		{
			if (id_initDebug == IntPtr.Zero)
				id_initDebug = JNIEnv.GetStaticMethodID (class_ref, "initDebug", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_initDebug);
			} finally {
			}
		}

		static IntPtr id_initDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='OpenCVLoader']/method[@name='initDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("initDebug", "(Z)Z", "")]
		public static unsafe bool InitDebug (bool p0)
		{
			if (id_initDebug_Z == IntPtr.Zero)
				id_initDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "initDebug", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_initDebug_Z, __args);
			} finally {
			}
		}

	}
}
