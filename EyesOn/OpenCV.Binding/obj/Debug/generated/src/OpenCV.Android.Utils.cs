using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']"
	[global::Android.Runtime.Register ("org/opencv/android/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Utils)) {
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

		static IntPtr id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='bitmapToMat' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("bitmapToMat", "(Landroid/graphics/Bitmap;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void BitmapToMat (global::Android.Graphics.Bitmap p0, global::OpenCV.Core.Mat p1)
		{
			if (id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "bitmapToMat", "(Landroid/graphics/Bitmap;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='bitmapToMat' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='boolean']]"
		[Register ("bitmapToMat", "(Landroid/graphics/Bitmap;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void BitmapToMat (global::Android.Graphics.Bitmap p0, global::OpenCV.Core.Mat p1, bool p2)
		{
			if (id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "bitmapToMat", "(Landroid/graphics/Bitmap;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_bitmapToMat_Landroid_graphics_Bitmap_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_exportResource_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='exportResource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("exportResource", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string ExportResource (global::Android.Content.Context p0, int p1)
		{
			if (id_exportResource_Landroid_content_Context_I == IntPtr.Zero)
				id_exportResource_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "exportResource", "(Landroid/content/Context;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_exportResource_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_exportResource_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='exportResource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("exportResource", "(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ExportResource (global::Android.Content.Context p0, int p1, string p2)
		{
			if (id_exportResource_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
				id_exportResource_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "exportResource", "(Landroid/content/Context;ILjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_exportResource_Landroid_content_Context_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_loadResource_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("loadResource", "(Landroid/content/Context;I)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat LoadResource (global::Android.Content.Context p0, int p1)
		{
			if (id_loadResource_Landroid_content_Context_I == IntPtr.Zero)
				id_loadResource_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "loadResource", "(Landroid/content/Context;I)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadResource_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadResource_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='loadResource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("loadResource", "(Landroid/content/Context;II)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat LoadResource (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_loadResource_Landroid_content_Context_II == IntPtr.Zero)
				id_loadResource_Landroid_content_Context_II = JNIEnv.GetStaticMethodID (class_ref, "loadResource", "(Landroid/content/Context;II)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadResource_Landroid_content_Context_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='matToBitmap' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("matToBitmap", "(Lorg/opencv/core/Mat;Landroid/graphics/Bitmap;)V", "")]
		public static unsafe void MatToBitmap (global::OpenCV.Core.Mat p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "matToBitmap", "(Lorg/opencv/core/Mat;Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='Utils']/method[@name='matToBitmap' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='boolean']]"
		[Register ("matToBitmap", "(Lorg/opencv/core/Mat;Landroid/graphics/Bitmap;Z)V", "")]
		public static unsafe void MatToBitmap (global::OpenCV.Core.Mat p0, global::Android.Graphics.Bitmap p1, bool p2)
		{
			if (id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_Z == IntPtr.Zero)
				id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_Z = JNIEnv.GetStaticMethodID (class_ref, "matToBitmap", "(Lorg/opencv/core/Mat;Landroid/graphics/Bitmap;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matToBitmap_Lorg_opencv_core_Mat_Landroid_graphics_Bitmap_Z, __args);
			} finally {
			}
		}

	}
}
