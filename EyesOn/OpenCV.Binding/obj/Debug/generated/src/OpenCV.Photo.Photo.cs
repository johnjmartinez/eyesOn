using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Photo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']"
	[global::Android.Runtime.Register ("org/opencv/photo/Photo", DoNotGenerateAcw=true)]
	public partial class Photo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='INPAINT_NS']"
		[Register ("INPAINT_NS")]
		public const int InpaintNs = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='INPAINT_TELEA']"
		[Register ("INPAINT_TELEA")]
		public const int InpaintTelea = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='LDR_SIZE']"
		[Register ("LDR_SIZE")]
		public const int LdrSize = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='MIXED_CLONE']"
		[Register ("MIXED_CLONE")]
		public const int MixedClone = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='MONOCHROME_TRANSFER']"
		[Register ("MONOCHROME_TRANSFER")]
		public const int MonochromeTransfer = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='NORMAL_CLONE']"
		[Register ("NORMAL_CLONE")]
		public const int NormalClone = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='NORMCONV_FILTER']"
		[Register ("NORMCONV_FILTER")]
		public const int NormconvFilter = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/field[@name='RECURS_FILTER']"
		[Register ("RECURS_FILTER")]
		public const int RecursFilter = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/photo/Photo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Photo); }
		}

		protected Photo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/constructor[@name='Photo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Photo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Photo)) {
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

		static IntPtr id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='colorChange' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("colorChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ColorChange (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "colorChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='colorChange' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register ("colorChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFF)V", "")]
		public static unsafe void ColorChange (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, float p3, float p4, float p5)
		{
			if (id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF == IntPtr.Zero)
				id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF = JNIEnv.GetStaticMethodID (class_ref, "colorChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFF)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_colorChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_createAlignMTB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createAlignMTB' and count(parameter)=0]"
		[Register ("createAlignMTB", "()Lorg/opencv/photo/AlignMTB;", "")]
		public static unsafe global::OpenCV.Photo.AlignMTB CreateAlignMTB ()
		{
			if (id_createAlignMTB == IntPtr.Zero)
				id_createAlignMTB = JNIEnv.GetStaticMethodID (class_ref, "createAlignMTB", "()Lorg/opencv/photo/AlignMTB;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createAlignMTB), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createAlignMTB_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createAlignMTB' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("createAlignMTB", "(IIZ)Lorg/opencv/photo/AlignMTB;", "")]
		public static unsafe global::OpenCV.Photo.AlignMTB CreateAlignMTB (int p0, int p1, bool p2)
		{
			if (id_createAlignMTB_IIZ == IntPtr.Zero)
				id_createAlignMTB_IIZ = JNIEnv.GetStaticMethodID (class_ref, "createAlignMTB", "(IIZ)Lorg/opencv/photo/AlignMTB;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.AlignMTB> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createAlignMTB_IIZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCalibrateDebevec;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createCalibrateDebevec' and count(parameter)=0]"
		[Register ("createCalibrateDebevec", "()Lorg/opencv/photo/CalibrateDebevec;", "")]
		public static unsafe global::OpenCV.Photo.CalibrateDebevec CreateCalibrateDebevec ()
		{
			if (id_createCalibrateDebevec == IntPtr.Zero)
				id_createCalibrateDebevec = JNIEnv.GetStaticMethodID (class_ref, "createCalibrateDebevec", "()Lorg/opencv/photo/CalibrateDebevec;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCalibrateDebevec), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCalibrateDebevec_IFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createCalibrateDebevec' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("createCalibrateDebevec", "(IFZ)Lorg/opencv/photo/CalibrateDebevec;", "")]
		public static unsafe global::OpenCV.Photo.CalibrateDebevec CreateCalibrateDebevec (int p0, float p1, bool p2)
		{
			if (id_createCalibrateDebevec_IFZ == IntPtr.Zero)
				id_createCalibrateDebevec_IFZ = JNIEnv.GetStaticMethodID (class_ref, "createCalibrateDebevec", "(IFZ)Lorg/opencv/photo/CalibrateDebevec;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateDebevec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCalibrateDebevec_IFZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCalibrateRobertson;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createCalibrateRobertson' and count(parameter)=0]"
		[Register ("createCalibrateRobertson", "()Lorg/opencv/photo/CalibrateRobertson;", "")]
		public static unsafe global::OpenCV.Photo.CalibrateRobertson CreateCalibrateRobertson ()
		{
			if (id_createCalibrateRobertson == IntPtr.Zero)
				id_createCalibrateRobertson = JNIEnv.GetStaticMethodID (class_ref, "createCalibrateRobertson", "()Lorg/opencv/photo/CalibrateRobertson;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCalibrateRobertson), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createCalibrateRobertson_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createCalibrateRobertson' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("createCalibrateRobertson", "(IF)Lorg/opencv/photo/CalibrateRobertson;", "")]
		public static unsafe global::OpenCV.Photo.CalibrateRobertson CreateCalibrateRobertson (int p0, float p1)
		{
			if (id_createCalibrateRobertson_IF == IntPtr.Zero)
				id_createCalibrateRobertson_IF = JNIEnv.GetStaticMethodID (class_ref, "createCalibrateRobertson", "(IF)Lorg/opencv/photo/CalibrateRobertson;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.CalibrateRobertson> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCalibrateRobertson_IF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMergeDebevec;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createMergeDebevec' and count(parameter)=0]"
		[Register ("createMergeDebevec", "()Lorg/opencv/photo/MergeDebevec;", "")]
		public static unsafe global::OpenCV.Photo.MergeDebevec CreateMergeDebevec ()
		{
			if (id_createMergeDebevec == IntPtr.Zero)
				id_createMergeDebevec = JNIEnv.GetStaticMethodID (class_ref, "createMergeDebevec", "()Lorg/opencv/photo/MergeDebevec;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeDebevec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMergeDebevec), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMergeMertens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createMergeMertens' and count(parameter)=0]"
		[Register ("createMergeMertens", "()Lorg/opencv/photo/MergeMertens;", "")]
		public static unsafe global::OpenCV.Photo.MergeMertens CreateMergeMertens ()
		{
			if (id_createMergeMertens == IntPtr.Zero)
				id_createMergeMertens = JNIEnv.GetStaticMethodID (class_ref, "createMergeMertens", "()Lorg/opencv/photo/MergeMertens;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMergeMertens), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMergeMertens_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createMergeMertens' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("createMergeMertens", "(FFF)Lorg/opencv/photo/MergeMertens;", "")]
		public static unsafe global::OpenCV.Photo.MergeMertens CreateMergeMertens (float p0, float p1, float p2)
		{
			if (id_createMergeMertens_FFF == IntPtr.Zero)
				id_createMergeMertens_FFF = JNIEnv.GetStaticMethodID (class_ref, "createMergeMertens", "(FFF)Lorg/opencv/photo/MergeMertens;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeMertens> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMergeMertens_FFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMergeRobertson;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createMergeRobertson' and count(parameter)=0]"
		[Register ("createMergeRobertson", "()Lorg/opencv/photo/MergeRobertson;", "")]
		public static unsafe global::OpenCV.Photo.MergeRobertson CreateMergeRobertson ()
		{
			if (id_createMergeRobertson == IntPtr.Zero)
				id_createMergeRobertson = JNIEnv.GetStaticMethodID (class_ref, "createMergeRobertson", "()Lorg/opencv/photo/MergeRobertson;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.MergeRobertson> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMergeRobertson), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemap;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemap' and count(parameter)=0]"
		[Register ("createTonemap", "()Lorg/opencv/photo/Tonemap;", "")]
		public static unsafe global::OpenCV.Photo.Tonemap CreateTonemap ()
		{
			if (id_createTonemap == IntPtr.Zero)
				id_createTonemap = JNIEnv.GetStaticMethodID (class_ref, "createTonemap", "()Lorg/opencv/photo/Tonemap;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.Tonemap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemap), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemap_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemap' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("createTonemap", "(F)Lorg/opencv/photo/Tonemap;", "")]
		public static unsafe global::OpenCV.Photo.Tonemap CreateTonemap (float p0)
		{
			if (id_createTonemap_F == IntPtr.Zero)
				id_createTonemap_F = JNIEnv.GetStaticMethodID (class_ref, "createTonemap", "(F)Lorg/opencv/photo/Tonemap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.Tonemap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemap_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapDrago;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapDrago' and count(parameter)=0]"
		[Register ("createTonemapDrago", "()Lorg/opencv/photo/TonemapDrago;", "")]
		public static unsafe global::OpenCV.Photo.TonemapDrago CreateTonemapDrago ()
		{
			if (id_createTonemapDrago == IntPtr.Zero)
				id_createTonemapDrago = JNIEnv.GetStaticMethodID (class_ref, "createTonemapDrago", "()Lorg/opencv/photo/TonemapDrago;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapDrago), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapDrago_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapDrago' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("createTonemapDrago", "(FFF)Lorg/opencv/photo/TonemapDrago;", "")]
		public static unsafe global::OpenCV.Photo.TonemapDrago CreateTonemapDrago (float p0, float p1, float p2)
		{
			if (id_createTonemapDrago_FFF == IntPtr.Zero)
				id_createTonemapDrago_FFF = JNIEnv.GetStaticMethodID (class_ref, "createTonemapDrago", "(FFF)Lorg/opencv/photo/TonemapDrago;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDrago> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapDrago_FFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapDurand;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapDurand' and count(parameter)=0]"
		[Register ("createTonemapDurand", "()Lorg/opencv/photo/TonemapDurand;", "")]
		public static unsafe global::OpenCV.Photo.TonemapDurand CreateTonemapDurand ()
		{
			if (id_createTonemapDurand == IntPtr.Zero)
				id_createTonemapDurand = JNIEnv.GetStaticMethodID (class_ref, "createTonemapDurand", "()Lorg/opencv/photo/TonemapDurand;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapDurand), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapDurand_FFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapDurand' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("createTonemapDurand", "(FFFFF)Lorg/opencv/photo/TonemapDurand;", "")]
		public static unsafe global::OpenCV.Photo.TonemapDurand CreateTonemapDurand (float p0, float p1, float p2, float p3, float p4)
		{
			if (id_createTonemapDurand_FFFFF == IntPtr.Zero)
				id_createTonemapDurand_FFFFF = JNIEnv.GetStaticMethodID (class_ref, "createTonemapDurand", "(FFFFF)Lorg/opencv/photo/TonemapDurand;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapDurand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapDurand_FFFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapMantiuk;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapMantiuk' and count(parameter)=0]"
		[Register ("createTonemapMantiuk", "()Lorg/opencv/photo/TonemapMantiuk;", "")]
		public static unsafe global::OpenCV.Photo.TonemapMantiuk CreateTonemapMantiuk ()
		{
			if (id_createTonemapMantiuk == IntPtr.Zero)
				id_createTonemapMantiuk = JNIEnv.GetStaticMethodID (class_ref, "createTonemapMantiuk", "()Lorg/opencv/photo/TonemapMantiuk;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapMantiuk), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapMantiuk_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapMantiuk' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("createTonemapMantiuk", "(FFF)Lorg/opencv/photo/TonemapMantiuk;", "")]
		public static unsafe global::OpenCV.Photo.TonemapMantiuk CreateTonemapMantiuk (float p0, float p1, float p2)
		{
			if (id_createTonemapMantiuk_FFF == IntPtr.Zero)
				id_createTonemapMantiuk_FFF = JNIEnv.GetStaticMethodID (class_ref, "createTonemapMantiuk", "(FFF)Lorg/opencv/photo/TonemapMantiuk;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapMantiuk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapMantiuk_FFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapReinhard;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapReinhard' and count(parameter)=0]"
		[Register ("createTonemapReinhard", "()Lorg/opencv/photo/TonemapReinhard;", "")]
		public static unsafe global::OpenCV.Photo.TonemapReinhard CreateTonemapReinhard ()
		{
			if (id_createTonemapReinhard == IntPtr.Zero)
				id_createTonemapReinhard = JNIEnv.GetStaticMethodID (class_ref, "createTonemapReinhard", "()Lorg/opencv/photo/TonemapReinhard;");
			try {
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapReinhard), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createTonemapReinhard_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='createTonemapReinhard' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("createTonemapReinhard", "(FFFF)Lorg/opencv/photo/TonemapReinhard;", "")]
		public static unsafe global::OpenCV.Photo.TonemapReinhard CreateTonemapReinhard (float p0, float p1, float p2, float p3)
		{
			if (id_createTonemapReinhard_FFFF == IntPtr.Zero)
				id_createTonemapReinhard_FFFF = JNIEnv.GetStaticMethodID (class_ref, "createTonemapReinhard", "(FFFF)Lorg/opencv/photo/TonemapReinhard;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Photo.TonemapReinhard> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createTonemapReinhard_FFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_decolor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='decolor' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("decolor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Decolor (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_decolor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_decolor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "decolor", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decolor_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='denoise_TVL1' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("denoise_TVL1", "(Ljava/util/List;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Denoise_TVL1 (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1)
		{
			if (id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "denoise_TVL1", "(Ljava/util/List;Lorg/opencv/core/Mat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='denoise_TVL1' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register ("denoise_TVL1", "(Ljava/util/List;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Denoise_TVL1 (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, double p2, int p3)
		{
			if (id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "denoise_TVL1", "(Ljava/util/List;Lorg/opencv/core/Mat;DI)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_denoise_TVL1_Ljava_util_List_Lorg_opencv_core_Mat_DI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='detailEnhance' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("detailEnhance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DetailEnhance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "detailEnhance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='detailEnhance' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("detailEnhance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V", "")]
		public static unsafe void DetailEnhance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, float p2, float p3)
		{
			if (id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF == IntPtr.Zero)
				id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF = JNIEnv.GetStaticMethodID (class_ref, "detailEnhance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_detailEnhance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF, __args);
			} finally {
			}
		}

		static IntPtr id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='edgePreservingFilter' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("edgePreservingFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void EdgePreservingFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "edgePreservingFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='edgePreservingFilter' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("edgePreservingFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IFF)V", "")]
		public static unsafe void EdgePreservingFilter (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, float p3, float p4)
		{
			if (id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IFF == IntPtr.Zero)
				id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IFF = JNIEnv.GetStaticMethodID (class_ref, "edgePreservingFilter", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IFF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_edgePreservingFilter_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IFF, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoising' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void FastNlMeansDenoising (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoising' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FII)V", "")]
		public static unsafe void FastNlMeansDenoising (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, float p2, int p3, int p4)
		{
			if (id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FII == IntPtr.Zero)
				id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FII = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FII, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoising' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfFloat']]"
		[Register ("fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;)V", "")]
		public static unsafe void FastNlMeansDenoising (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfFloat p2)
		{
			if (id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ == IntPtr.Zero)
				id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_ = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoising' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfFloat'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;III)V", "")]
		public static unsafe void FastNlMeansDenoising (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfFloat p2, int p3, int p4, int p5)
		{
			if (id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_III == IntPtr.Zero)
				id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_III = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoising", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfFloat;III)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoising_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfFloat_III, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingColored' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("fastNlMeansDenoisingColored", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void FastNlMeansDenoisingColored (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingColored", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingColored' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("fastNlMeansDenoisingColored", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFII)V", "")]
		public static unsafe void FastNlMeansDenoisingColored (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, float p2, float p3, int p4, int p5)
		{
			if (id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFII == IntPtr.Zero)
				id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFII = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingColored", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFII)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingColored_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFII, __args);
			} finally {
			}
		}

		static IntPtr id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingColoredMulti' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("fastNlMeansDenoisingColoredMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void FastNlMeansDenoisingColoredMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingColoredMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;II)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingColoredMulti' and count(parameter)=8 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("fastNlMeansDenoisingColoredMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IIFFII)V", "")]
		public static unsafe void FastNlMeansDenoisingColoredMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3, float p4, float p5, int p6, int p7)
		{
			if (id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFFII == IntPtr.Zero)
				id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFFII = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingColoredMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IIFFII)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingColoredMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFFII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingMulti' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void FastNlMeansDenoisingMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;II)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingMulti' and count(parameter)=7 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IIFII)V", "")]
		public static unsafe void FastNlMeansDenoisingMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3, float p4, int p5, int p6)
		{
			if (id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFII == IntPtr.Zero)
				id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFII = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IIFII)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IIFII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingMulti' and count(parameter)=5 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.MatOfFloat']]"
		[Register ("fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/MatOfFloat;)V", "")]
		public static unsafe void FastNlMeansDenoisingMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3, global::OpenCV.Core.MatOfFloat p4)
		{
			if (id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_ == IntPtr.Zero)
				id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_ = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/MatOfFloat;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='fastNlMeansDenoisingMulti' and count(parameter)=8 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.MatOfFloat'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/MatOfFloat;III)V", "")]
		public static unsafe void FastNlMeansDenoisingMulti (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::OpenCV.Core.Mat p1, int p2, int p3, global::OpenCV.Core.MatOfFloat p4, int p5, int p6, int p7)
		{
			if (id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_III == IntPtr.Zero)
				id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_III = JNIEnv.GetStaticMethodID (class_ref, "fastNlMeansDenoisingMulti", "(Ljava/util/List;Lorg/opencv/core/Mat;IILorg/opencv/core/MatOfFloat;III)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastNlMeansDenoisingMulti_Ljava_util_List_Lorg_opencv_core_Mat_IILorg_opencv_core_MatOfFloat_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='illuminationChange' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("illuminationChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void IlluminationChange (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "illuminationChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='illuminationChange' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("illuminationChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V", "")]
		public static unsafe void IlluminationChange (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, float p3, float p4)
		{
			if (id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF == IntPtr.Zero)
				id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF = JNIEnv.GetStaticMethodID (class_ref, "illuminationChange", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_illuminationChange_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF, __args);
			} finally {
			}
		}

		static IntPtr id_inpaint_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='inpaint' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='double'] and parameter[5][@type='int']]"
		[Register ("inpaint", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V", "")]
		public static unsafe void Inpaint (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, double p3, int p4)
		{
			if (id_inpaint_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI == IntPtr.Zero)
				id_inpaint_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI = JNIEnv.GetStaticMethodID (class_ref, "inpaint", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_inpaint_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DI, __args);
			} finally {
			}
		}

		static IntPtr id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='pencilSketch' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("pencilSketch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void PencilSketch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "pencilSketch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='pencilSketch' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register ("pencilSketch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFF)V", "")]
		public static unsafe void PencilSketch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, float p3, float p4, float p5)
		{
			if (id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF == IntPtr.Zero)
				id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF = JNIEnv.GetStaticMethodID (class_ref, "pencilSketch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFF)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pencilSketch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_seamlessClone_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='seamlessClone' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int']]"
		[Register ("seamlessClone", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void SeamlessClone (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Point p3, global::OpenCV.Core.Mat p4, int p5)
		{
			if (id_seamlessClone_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_seamlessClone_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "seamlessClone", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Point;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_seamlessClone_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Point_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='stylization' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("stylization", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Stylization (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "stylization", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='stylization' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("stylization", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V", "")]
		public static unsafe void Stylization (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, float p2, float p3)
		{
			if (id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF == IntPtr.Zero)
				id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF = JNIEnv.GetStaticMethodID (class_ref, "stylization", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stylization_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FF, __args);
			} finally {
			}
		}

		static IntPtr id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='textureFlattening' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("textureFlattening", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void TextureFlattening (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "textureFlattening", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.photo']/class[@name='Photo']/method[@name='textureFlattening' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int']]"
		[Register ("textureFlattening", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFI)V", "")]
		public static unsafe void TextureFlattening (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, float p3, float p4, int p5)
		{
			if (id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFI == IntPtr.Zero)
				id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFI = JNIEnv.GetStaticMethodID (class_ref, "textureFlattening", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;FFI)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_textureFlattening_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_FFI, __args);
			} finally {
			}
		}

	}
}
