using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Calib3d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']"
	[global::Android.Runtime.Register ("org/opencv/calib3d/Calib3d", DoNotGenerateAcw=true)]
	public partial class Calib3d : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_ADAPTIVE_THRESH']"
		[Register ("CALIB_CB_ADAPTIVE_THRESH")]
		public const int CalibCbAdaptiveThresh = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_ASYMMETRIC_GRID']"
		[Register ("CALIB_CB_ASYMMETRIC_GRID")]
		public const int CalibCbAsymmetricGrid = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_CLUSTERING']"
		[Register ("CALIB_CB_CLUSTERING")]
		public const int CalibCbClustering = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_FAST_CHECK']"
		[Register ("CALIB_CB_FAST_CHECK")]
		public const int CalibCbFastCheck = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_FILTER_QUADS']"
		[Register ("CALIB_CB_FILTER_QUADS")]
		public const int CalibCbFilterQuads = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_NORMALIZE_IMAGE']"
		[Register ("CALIB_CB_NORMALIZE_IMAGE")]
		public const int CalibCbNormalizeImage = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CB_SYMMETRIC_GRID']"
		[Register ("CALIB_CB_SYMMETRIC_GRID")]
		public const int CalibCbSymmetricGrid = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_CHECK_COND']"
		[Register ("CALIB_CHECK_COND")]
		public const int CalibCheckCond = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_ASPECT_RATIO']"
		[Register ("CALIB_FIX_ASPECT_RATIO")]
		public const int CalibFixAspectRatio = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_FOCAL_LENGTH']"
		[Register ("CALIB_FIX_FOCAL_LENGTH")]
		public const int CalibFixFocalLength = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_INTRINSIC']"
		[Register ("CALIB_FIX_INTRINSIC")]
		public const int CalibFixIntrinsic = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K1']"
		[Register ("CALIB_FIX_K1")]
		public const int CalibFixK1 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K2']"
		[Register ("CALIB_FIX_K2")]
		public const int CalibFixK2 = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K3']"
		[Register ("CALIB_FIX_K3")]
		public const int CalibFixK3 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K4']"
		[Register ("CALIB_FIX_K4")]
		public const int CalibFixK4 = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K5']"
		[Register ("CALIB_FIX_K5")]
		public const int CalibFixK5 = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_K6']"
		[Register ("CALIB_FIX_K6")]
		public const int CalibFixK6 = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_PRINCIPAL_POINT']"
		[Register ("CALIB_FIX_PRINCIPAL_POINT")]
		public const int CalibFixPrincipalPoint = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_S1_S2_S3_S4']"
		[Register ("CALIB_FIX_S1_S2_S3_S4")]
		public const int CalibFixS1S2S3S4 = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_SKEW']"
		[Register ("CALIB_FIX_SKEW")]
		public const int CalibFixSkew = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_FIX_TAUX_TAUY']"
		[Register ("CALIB_FIX_TAUX_TAUY")]
		public const int CalibFixTauxTauy = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_RATIONAL_MODEL']"
		[Register ("CALIB_RATIONAL_MODEL")]
		public const int CalibRationalModel = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_RECOMPUTE_EXTRINSIC']"
		[Register ("CALIB_RECOMPUTE_EXTRINSIC")]
		public const int CalibRecomputeExtrinsic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_SAME_FOCAL_LENGTH']"
		[Register ("CALIB_SAME_FOCAL_LENGTH")]
		public const int CalibSameFocalLength = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_THIN_PRISM_MODEL']"
		[Register ("CALIB_THIN_PRISM_MODEL")]
		public const int CalibThinPrismModel = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_TILTED_MODEL']"
		[Register ("CALIB_TILTED_MODEL")]
		public const int CalibTiltedModel = (int) 262144;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_USE_INTRINSIC_GUESS']"
		[Register ("CALIB_USE_INTRINSIC_GUESS")]
		public const int CalibUseIntrinsicGuess = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_USE_LU']"
		[Register ("CALIB_USE_LU")]
		public const int CalibUseLu = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_ZERO_DISPARITY']"
		[Register ("CALIB_ZERO_DISPARITY")]
		public const int CalibZeroDisparity = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CALIB_ZERO_TANGENT_DIST']"
		[Register ("CALIB_ZERO_TANGENT_DIST")]
		public const int CalibZeroTangentDist = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CV_DLS']"
		[Register ("CV_DLS")]
		public const int CvDls = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CV_EPNP']"
		[Register ("CV_EPNP")]
		public const int CvEpnp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CV_ITERATIVE']"
		[Register ("CV_ITERATIVE")]
		public const int CvIterative = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='CV_P3P']"
		[Register ("CV_P3P")]
		public const int CvP3p = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='FM_7POINT']"
		[Register ("FM_7POINT")]
		public const int Fm7point = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='FM_8POINT']"
		[Register ("FM_8POINT")]
		public const int Fm8point = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='FM_LMEDS']"
		[Register ("FM_LMEDS")]
		public const int FmLmeds = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='FM_RANSAC']"
		[Register ("FM_RANSAC")]
		public const int FmRansac = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='LMEDS']"
		[Register ("LMEDS")]
		public const int Lmeds = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='RANSAC']"
		[Register ("RANSAC")]
		public const int Ransac = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='RHO']"
		[Register ("RHO")]
		public const int Rho = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='SOLVEPNP_DLS']"
		[Register ("SOLVEPNP_DLS")]
		public const int SolvepnpDls = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='SOLVEPNP_EPNP']"
		[Register ("SOLVEPNP_EPNP")]
		public const int SolvepnpEpnp = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='SOLVEPNP_ITERATIVE']"
		[Register ("SOLVEPNP_ITERATIVE")]
		public const int SolvepnpIterative = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='SOLVEPNP_P3P']"
		[Register ("SOLVEPNP_P3P")]
		public const int SolvepnpP3p = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/field[@name='SOLVEPNP_UPNP']"
		[Register ("SOLVEPNP_UPNP")]
		public const int SolvepnpUpnp = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/calib3d/Calib3d", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Calib3d); }
		}

		protected Calib3d (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/constructor[@name='Calib3d' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Calib3d ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Calib3d)) {
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

		static IntPtr id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='RQDecomp3x3' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("RQDecomp3x3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D", "")]
		public static unsafe double[] RQDecomp3x3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "RQDecomp3x3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='RQDecomp3x3' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("RQDecomp3x3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D", "")]
		public static unsafe double[] RQDecomp3x3 (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "RQDecomp3x3", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)[D");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_RQDecomp3x3_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='Rodrigues' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("Rodrigues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Rodrigues (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "Rodrigues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='Rodrigues' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("Rodrigues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void Rodrigues (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "Rodrigues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Rodrigues_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrate' and count(parameter)=7 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;)D", "")]
		public static unsafe double Calibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6)
		{
			if (id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrate' and count(parameter)=8 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[8][@type='int']]"
		[Register ("calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;I)D", "")]
		public static unsafe double Calibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6, int p7)
		{
			if (id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I == IntPtr.Zero)
				id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;I)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrate' and count(parameter)=9 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[8][@type='int'] and parameter[9][@type='org.opencv.core.TermCriteria']]"
		[Register ("calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;ILorg/opencv/core/TermCriteria;)D", "")]
		public static unsafe double Calibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6, int p7, global::OpenCV.Core.TermCriteria p8)
		{
			if (id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "calibrate", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;ILorg/opencv/core/TermCriteria;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrate_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrateCamera' and count(parameter)=7 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;)D", "")]
		public static unsafe double CalibrateCamera (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6)
		{
			if (id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrateCamera' and count(parameter)=8 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[8][@type='int']]"
		[Register ("calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;I)D", "")]
		public static unsafe double CalibrateCamera (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6, int p7)
		{
			if (id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I == IntPtr.Zero)
				id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;I)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrateCamera' and count(parameter)=9 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[7][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[8][@type='int'] and parameter[9][@type='org.opencv.core.TermCriteria']]"
		[Register ("calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;ILorg/opencv/core/TermCriteria;)D", "")]
		public static unsafe double CalibrateCamera (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p5, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p6, int p7, global::OpenCV.Core.TermCriteria p8)
		{
			if (id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "calibrateCamera", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;ILorg/opencv/core/TermCriteria;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p5);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_calibrateCamera_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_ILorg_opencv_core_TermCriteria_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_calibrationMatrixValues_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDarrayDarrayDarrayDLorg_opencv_core_Point_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='calibrationMatrixValues' and count(parameter)=9 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double[]'] and parameter[6][@type='double[]'] and parameter[7][@type='double[]'] and parameter[8][@type='org.opencv.core.Point'] and parameter[9][@type='double[]']]"
		[Register ("calibrationMatrixValues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DD[D[D[DLorg/opencv/core/Point;[D)V", "")]
		public static unsafe void CalibrationMatrixValues (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, double p2, double p3, double[] p4, double[] p5, double[] p6, global::OpenCV.Core.Point p7, double[] p8)
		{
			if (id_calibrationMatrixValues_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDarrayDarrayDarrayDLorg_opencv_core_Point_arrayD == IntPtr.Zero)
				id_calibrationMatrixValues_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDarrayDarrayDarrayDLorg_opencv_core_Point_arrayD = JNIEnv.GetStaticMethodID (class_ref, "calibrationMatrixValues", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DD[D[D[DLorg/opencv/core/Point;[D)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_calibrationMatrixValues_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DDarrayDarrayDarrayDLorg_opencv_core_Point_arrayD, __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p5 != null) {
					JNIEnv.CopyArray (native_p5, p5);
					JNIEnv.DeleteLocalRef (native_p5);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

		static IntPtr id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='composeRT' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("composeRT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ComposeRT (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "composeRT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='composeRT' and count(parameter)=14 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat'] and parameter[13][@type='org.opencv.core.Mat'] and parameter[14][@type='org.opencv.core.Mat']]"
		[Register ("composeRT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ComposeRT (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11, global::OpenCV.Core.Mat p12, global::OpenCV.Core.Mat p13)
		{
			if (id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "composeRT", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [14];
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
				__args [12] = new JValue (p12);
				__args [13] = new JValue (p13);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_composeRT_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_computeCorrespondEpilines_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='computeCorrespondEpilines' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='int'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("computeCorrespondEpilines", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ComputeCorrespondEpilines (global::OpenCV.Core.Mat p0, int p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_computeCorrespondEpilines_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_computeCorrespondEpilines_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "computeCorrespondEpilines", "(Lorg/opencv/core/Mat;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_computeCorrespondEpilines_Lorg_opencv_core_Mat_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_convertPointsFromHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='convertPointsFromHomogeneous' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("convertPointsFromHomogeneous", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ConvertPointsFromHomogeneous (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_convertPointsFromHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_convertPointsFromHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "convertPointsFromHomogeneous", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertPointsFromHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_convertPointsToHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='convertPointsToHomogeneous' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("convertPointsToHomogeneous", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ConvertPointsToHomogeneous (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_convertPointsToHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_convertPointsToHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "convertPointsToHomogeneous", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertPointsToHomogeneous_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_correctMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='correctMatches' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("correctMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void CorrectMatches (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_correctMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_correctMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "correctMatches", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_correctMatches_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_decomposeEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='decomposeEssentialMat' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("decomposeEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DecomposeEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_decomposeEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_decomposeEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "decomposeEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decomposeEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_decomposeHomographyMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='decomposeHomographyMat' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[5][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("decomposeHomographyMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;Ljava/util/List;)I", "")]
		public static unsafe int DecomposeHomographyMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p3, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p4)
		{
			if (id_decomposeHomographyMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_decomposeHomographyMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "decomposeHomographyMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;Ljava/util/List;Ljava/util/List;)I");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_decomposeHomographyMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_Ljava_util_List_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='decomposeProjectionMatrix' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("decomposeProjectionMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DecomposeProjectionMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "decomposeProjectionMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='decomposeProjectionMatrix' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("decomposeProjectionMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DecomposeProjectionMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7)
		{
			if (id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "decomposeProjectionMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_decomposeProjectionMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='distortPoints' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("distortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void DistortPoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "distortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='distortPoints' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double']]"
		[Register ("distortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void DistortPoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, double p4)
		{
			if (id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "distortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_distortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_drawChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='drawChessboardCorners' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.MatOfPoint2f'] and parameter[4][@type='boolean']]"
		[Register ("drawChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;Z)V", "")]
		public static unsafe void DrawChessboardCorners (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.MatOfPoint2f p2, bool p3)
		{
			if (id_drawChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_Z == IntPtr.Zero)
				id_drawChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_Z = JNIEnv.GetStaticMethodID (class_ref, "drawChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_drawChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_Z, __args);
			} finally {
			}
		}

		static IntPtr id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='estimateAffine3D' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("estimateAffine3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int EstimateAffine3D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "estimateAffine3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='estimateAffine3D' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("estimateAffine3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)I", "")]
		public static unsafe int EstimateAffine3D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, double p4, double p5)
		{
			if (id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD == IntPtr.Zero)
				id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD = JNIEnv.GetStaticMethodID (class_ref, "estimateAffine3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DD)I");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_estimateAffine3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DD, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='estimateNewCameraMatrixForUndistortRectify' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("estimateNewCameraMatrixForUndistortRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void EstimateNewCameraMatrixForUndistortRectify (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "estimateNewCameraMatrixForUndistortRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Size_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='estimateNewCameraMatrixForUndistortRectify' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Size'] and parameter[8][@type='double']]"
		[Register ("estimateNewCameraMatrixForUndistortRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Size;D)V", "")]
		public static unsafe void EstimateNewCameraMatrixForUndistortRectify (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, double p5, global::OpenCV.Core.Size p6, double p7)
		{
			if (id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Size_D == IntPtr.Zero)
				id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Size_D = JNIEnv.GetStaticMethodID (class_ref, "estimateNewCameraMatrixForUndistortRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Size;D)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_estimateNewCameraMatrixForUndistortRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Size_D, __args);
			} finally {
			}
		}

		static IntPtr id_filterSpeckles_Lorg_opencv_core_Mat_DID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='filterSpeckles' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("filterSpeckles", "(Lorg/opencv/core/Mat;DID)V", "")]
		public static unsafe void FilterSpeckles (global::OpenCV.Core.Mat p0, double p1, int p2, double p3)
		{
			if (id_filterSpeckles_Lorg_opencv_core_Mat_DID == IntPtr.Zero)
				id_filterSpeckles_Lorg_opencv_core_Mat_DID = JNIEnv.GetStaticMethodID (class_ref, "filterSpeckles", "(Lorg/opencv/core/Mat;DID)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_filterSpeckles_Lorg_opencv_core_Mat_DID, __args);
			} finally {
			}
		}

		static IntPtr id_filterSpeckles_Lorg_opencv_core_Mat_DIDLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='filterSpeckles' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("filterSpeckles", "(Lorg/opencv/core/Mat;DIDLorg/opencv/core/Mat;)V", "")]
		public static unsafe void FilterSpeckles (global::OpenCV.Core.Mat p0, double p1, int p2, double p3, global::OpenCV.Core.Mat p4)
		{
			if (id_filterSpeckles_Lorg_opencv_core_Mat_DIDLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_filterSpeckles_Lorg_opencv_core_Mat_DIDLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "filterSpeckles", "(Lorg/opencv/core/Mat;DIDLorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_filterSpeckles_Lorg_opencv_core_Mat_DIDLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findChessboardCorners' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("findChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;)Z", "")]
		public static unsafe bool FindChessboardCorners (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.MatOfPoint2f p2)
		{
			if (id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "findChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findChessboardCorners' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.MatOfPoint2f'] and parameter[4][@type='int']]"
		[Register ("findChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;I)Z", "")]
		public static unsafe bool FindChessboardCorners (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.MatOfPoint2f p2, int p3)
		{
			if (id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_I == IntPtr.Zero)
				id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_I = JNIEnv.GetStaticMethodID (class_ref, "findChessboardCorners", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/MatOfPoint2f;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_findChessboardCorners_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_MatOfPoint2f_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findCirclesGrid' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("findCirclesGrid", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool FindCirclesGrid (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Mat p2)
		{
			if (id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findCirclesGrid", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findCirclesGrid' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Size'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int']]"
		[Register ("findCirclesGrid", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;I)Z", "")]
		public static unsafe bool FindCirclesGrid (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Size p1, global::OpenCV.Core.Mat p2, int p3)
		{
			if (id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "findCirclesGrid", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_findCirclesGrid_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;IDD)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, global::OpenCV.Core.Point p3, int p4, double p5, double p6)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDD == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDD = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;IDD)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDDLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='double'] and parameter[4][@type='org.opencv.core.Point'] and parameter[5][@type='int'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, double p2, global::OpenCV.Core.Point p3, int p4, double p5, double p6, global::OpenCV.Core.Mat p7)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDDLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDDLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
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
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_IDDLorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, double p4, double p5)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDD)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findEssentialMat' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='int'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindEssentialMat (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, int p3, double p4, double p5, global::OpenCV.Core.Mat p6)
		{
			if (id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findEssentialMat", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findEssentialMat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_IDDLorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findFundamentalMat' and count(parameter)=2 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindFundamentalMat (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1)
		{
			if (id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findFundamentalMat' and count(parameter)=5 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDD)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindFundamentalMat (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, int p2, double p3, double p4)
		{
			if (id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDD == IntPtr.Zero)
				id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDD = JNIEnv.GetStaticMethodID (class_ref, "findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDD)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDD, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDDLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findFundamentalMat' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindFundamentalMat (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, int p2, double p3, double p4, global::OpenCV.Core.Mat p5)
		{
			if (id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDDLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDDLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "findFundamentalMat", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDDLorg/opencv/core/Mat;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findFundamentalMat_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDDLorg_opencv_core_Mat_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findHomography' and count(parameter)=2 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindHomography (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1)
		{
			if (id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findHomography' and count(parameter)=4 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;ID)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindHomography (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, int p2, double p3)
		{
			if (id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ID == IntPtr.Zero)
				id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ID = JNIEnv.GetStaticMethodID (class_ref, "findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;ID)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_ID, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDLorg_opencv_core_Mat_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='findHomography' and count(parameter)=7 and parameter[1][@type='org.opencv.core.MatOfPoint2f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='int'] and parameter[7][@type='double']]"
		[Register ("findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDLorg/opencv/core/Mat;ID)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat FindHomography (global::OpenCV.Core.MatOfPoint2f p0, global::OpenCV.Core.MatOfPoint2f p1, int p2, double p3, global::OpenCV.Core.Mat p4, int p5, double p6)
		{
			if (id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDLorg_opencv_core_Mat_ID == IntPtr.Zero)
				id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDLorg_opencv_core_Mat_ID = JNIEnv.GetStaticMethodID (class_ref, "findHomography", "(Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/MatOfPoint2f;IDLorg/opencv/core/Mat;ID)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findHomography_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_MatOfPoint2f_IDLorg_opencv_core_Mat_ID, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='getOptimalNewCameraMatrix' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double']]"
		[Register ("getOptimalNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;D)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetOptimalNewCameraMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3)
		{
			if (id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D == IntPtr.Zero)
				id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D = JNIEnv.GetStaticMethodID (class_ref, "getOptimalNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;D)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_D, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DLorg_opencv_core_Size_Lorg_opencv_core_Rect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='getOptimalNewCameraMatrix' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='org.opencv.core.Rect'] and parameter[7][@type='boolean']]"
		[Register ("getOptimalNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DLorg/opencv/core/Size;Lorg/opencv/core/Rect;Z)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat GetOptimalNewCameraMatrix (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Size p2, double p3, global::OpenCV.Core.Size p4, global::OpenCV.Core.Rect p5, bool p6)
		{
			if (id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DLorg_opencv_core_Size_Lorg_opencv_core_Rect_Z == IntPtr.Zero)
				id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DLorg_opencv_core_Size_Lorg_opencv_core_Rect_Z = JNIEnv.GetStaticMethodID (class_ref, "getOptimalNewCameraMatrix", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;DLorg/opencv/core/Size;Lorg/opencv/core/Rect;Z)Lorg/opencv/core/Mat;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOptimalNewCameraMatrix_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_DLorg_opencv_core_Size_Lorg_opencv_core_Rect_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getValidDisparityROI_Lorg_opencv_core_Rect_Lorg_opencv_core_Rect_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='getValidDisparityROI' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Rect'] and parameter[2][@type='org.opencv.core.Rect'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getValidDisparityROI", "(Lorg/opencv/core/Rect;Lorg/opencv/core/Rect;III)Lorg/opencv/core/Rect;", "")]
		public static unsafe global::OpenCV.Core.Rect GetValidDisparityROI (global::OpenCV.Core.Rect p0, global::OpenCV.Core.Rect p1, int p2, int p3, int p4)
		{
			if (id_getValidDisparityROI_Lorg_opencv_core_Rect_Lorg_opencv_core_Rect_III == IntPtr.Zero)
				id_getValidDisparityROI_Lorg_opencv_core_Rect_Lorg_opencv_core_Rect_III = JNIEnv.GetStaticMethodID (class_ref, "getValidDisparityROI", "(Lorg/opencv/core/Rect;Lorg/opencv/core/Rect;III)Lorg/opencv/core/Rect;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::OpenCV.Core.Rect __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getValidDisparityROI_Lorg_opencv_core_Rect_Lorg_opencv_core_Rect_III, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='initCameraMatrix2D' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfPoint3f&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint2f&gt;'] and parameter[3][@type='org.opencv.core.Size']]"
		[Register ("initCameraMatrix2D", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat InitCameraMatrix2D (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint3f> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint2f> p1, global::OpenCV.Core.Size p2)
		{
			if (id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "initCameraMatrix2D", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint3f>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='initCameraMatrix2D' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;org.opencv.core.MatOfPoint3f&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint2f&gt;'] and parameter[3][@type='org.opencv.core.Size'] and parameter[4][@type='double']]"
		[Register ("initCameraMatrix2D", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;D)Lorg/opencv/core/Mat;", "")]
		public static unsafe global::OpenCV.Core.Mat InitCameraMatrix2D (global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint3f> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint2f> p1, global::OpenCV.Core.Size p2, double p3)
		{
			if (id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_D == IntPtr.Zero)
				id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_D = JNIEnv.GetStaticMethodID (class_ref, "initCameraMatrix2D", "(Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Size;D)Lorg/opencv/core/Mat;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint3f>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::OpenCV.Core.Mat __ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_initCameraMatrix2D_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Size_D, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='initUndistortRectifyMap' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='int'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("initUndistortRectifyMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void InitUndistortRectifyMap (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Size p4, int p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7)
		{
			if (id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "initUndistortRectifyMap", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;ILorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initUndistortRectifyMap_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ILorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_matMulDeriv_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='matMulDeriv' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("matMulDeriv", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void MatMulDeriv (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_matMulDeriv_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_matMulDeriv_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "matMulDeriv", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_matMulDeriv_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='projectPoints' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.MatOfDouble'] and parameter[6][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfPoint2f;)V", "")]
		public static unsafe void ProjectPoints (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.MatOfDouble p4, global::OpenCV.Core.MatOfPoint2f p5)
		{
			if (id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetStaticMethodID (class_ref, "projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfPoint2f;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_, __args);
			} finally {
			}
		}

		static IntPtr id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='projectPoints' and count(parameter)=8 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.MatOfDouble'] and parameter[6][@type='org.opencv.core.MatOfPoint2f'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='double']]"
		[Register ("projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;D)V", "")]
		public static unsafe void ProjectPoints (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.MatOfDouble p4, global::OpenCV.Core.MatOfPoint2f p5, global::OpenCV.Core.Mat p6, double p7)
		{
			if (id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;D)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_D, __args);
			} finally {
			}
		}

		static IntPtr id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='projectPoints' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ProjectPoints (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='projectPoints' and count(parameter)=8 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='double'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V", "")]
		public static unsafe void ProjectPoints (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, double p6, global::OpenCV.Core.Mat p7)
		{
			if (id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ == IntPtr.Zero)
				id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "projectPoints", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Mat;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_projectPoints_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='recoverPose' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int RecoverPose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='recoverPose' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Point']]"
		[Register ("recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;)I", "")]
		public static unsafe int RecoverPose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, double p5, global::OpenCV.Core.Point p6)
		{
			if (id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_ == IntPtr.Zero)
				id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_ = JNIEnv.GetStaticMethodID (class_ref, "recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='recoverPose' and count(parameter)=8 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='double'] and parameter[7][@type='org.opencv.core.Point'] and parameter[8][@type='org.opencv.core.Mat']]"
		[Register ("recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int RecoverPose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, double p5, global::OpenCV.Core.Point p6, global::OpenCV.Core.Mat p7)
		{
			if (id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;DLorg/opencv/core/Point;Lorg/opencv/core/Mat;)I");
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
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_DLorg_opencv_core_Point_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='recoverPose' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int RecoverPose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='recoverPose' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat']]"
		[Register ("recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I", "")]
		public static unsafe int RecoverPose (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6)
		{
			if (id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "recoverPose", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)I");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_recoverPose_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='reprojectImageTo3D' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void ReprojectImageTo3D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='reprojectImageTo3D' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='boolean']]"
		[Register ("reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V", "")]
		public static unsafe void ReprojectImageTo3D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, bool p3)
		{
			if (id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z = JNIEnv.GetStaticMethodID (class_ref, "reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Z, __args);
			} finally {
			}
		}

		static IntPtr id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='reprojectImageTo3D' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZI)V", "")]
		public static unsafe void ReprojectImageTo3D (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, bool p3, int p4)
		{
			if (id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI == IntPtr.Zero)
				id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI = JNIEnv.GetStaticMethodID (class_ref, "reprojectImageTo3D", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reprojectImageTo3D_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI, __args);
			} finally {
			}
		}

		static IntPtr id_sampsonDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='sampsonDistance' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat']]"
		[Register ("sampsonDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double SampsonDistance (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2)
		{
			if (id_sampsonDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_sampsonDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "sampsonDistance", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_sampsonDistance_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='solvePnP' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfDouble'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("solvePnP", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool SolvePnP (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfDouble p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "solvePnP", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='solvePnP' and count(parameter)=8 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfDouble'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='boolean'] and parameter[8][@type='int']]"
		[Register ("solvePnP", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZI)Z", "")]
		public static unsafe bool SolvePnP (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfDouble p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, bool p6, int p7)
		{
			if (id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI == IntPtr.Zero)
				id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI = JNIEnv.GetStaticMethodID (class_ref, "solvePnP", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZI)Z");
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
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solvePnP_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZI, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='solvePnPRansac' and count(parameter)=6 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfDouble'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("solvePnPRansac", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool SolvePnPRansac (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfDouble p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "solvePnPRansac", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZIFDLorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='solvePnPRansac' and count(parameter)=12 and parameter[1][@type='org.opencv.core.MatOfPoint3f'] and parameter[2][@type='org.opencv.core.MatOfPoint2f'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.MatOfDouble'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='boolean'] and parameter[8][@type='int'] and parameter[9][@type='float'] and parameter[10][@type='double'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='int']]"
		[Register ("solvePnPRansac", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZIFDLorg/opencv/core/Mat;I)Z", "")]
		public static unsafe bool SolvePnPRansac (global::OpenCV.Core.MatOfPoint3f p0, global::OpenCV.Core.MatOfPoint2f p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.MatOfDouble p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, bool p6, int p7, float p8, double p9, global::OpenCV.Core.Mat p10, int p11)
		{
			if (id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZIFDLorg_opencv_core_Mat_I == IntPtr.Zero)
				id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZIFDLorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "solvePnPRansac", "(Lorg/opencv/core/MatOfPoint3f;Lorg/opencv/core/MatOfPoint2f;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDouble;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ZIFDLorg/opencv/core/Mat;I)Z");
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
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_solvePnPRansac_Lorg_opencv_core_MatOfPoint3f_Lorg_opencv_core_MatOfPoint2f_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDouble_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ZIFDLorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=10 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=11 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='int']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, int p10)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=12 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='int'] and parameter[12][@type='org.opencv.core.TermCriteria']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, int p10, global::OpenCV.Core.TermCriteria p11)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=12 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=13 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat'] and parameter[13][@type='int']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11, int p12)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				__args [12] = new JValue (p12);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoCalibrate' and count(parameter)=14 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[2][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Size'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat'] and parameter[13][@type='int'] and parameter[14][@type='org.opencv.core.TermCriteria']]"
		[Register ("stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;)D", "")]
		public static unsafe double StereoCalibrate (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Size p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11, int p12, global::OpenCV.Core.TermCriteria p13)
		{
			if (id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_ == IntPtr.Zero)
				id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_ = JNIEnv.GetStaticMethodID (class_ref, "stereoCalibrate", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;ILorg/opencv/core/TermCriteria;)D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [14];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				__args [12] = new JValue (p12);
				__args [13] = new JValue (p13);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_stereoCalibrate_Ljava_util_List_Ljava_util_List_Ljava_util_List_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ILorg_opencv_core_TermCriteria_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoRectify' and count(parameter)=12 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat']]"
		[Register ("stereoRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void StereoRectify (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Size p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11)
		{
			if (id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "stereoRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
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
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoRectify' and count(parameter)=13 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Size'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='org.opencv.core.Mat'] and parameter[8][@type='org.opencv.core.Mat'] and parameter[9][@type='org.opencv.core.Mat'] and parameter[10][@type='org.opencv.core.Mat'] and parameter[11][@type='org.opencv.core.Mat'] and parameter[12][@type='org.opencv.core.Mat'] and parameter[13][@type='int']]"
		[Register ("stereoRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V", "")]
		public static unsafe void StereoRectify (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Size p4, global::OpenCV.Core.Mat p5, global::OpenCV.Core.Mat p6, global::OpenCV.Core.Mat p7, global::OpenCV.Core.Mat p8, global::OpenCV.Core.Mat p9, global::OpenCV.Core.Mat p10, global::OpenCV.Core.Mat p11, int p12)
		{
			if (id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I == IntPtr.Zero)
				id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I = JNIEnv.GetStaticMethodID (class_ref, "stereoRectify", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;I)V");
			try {
				JValue* __args = stackalloc JValue [13];
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
				__args [12] = new JValue (p12);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stereoRectify_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_I, __args);
			} finally {
			}
		}

		static IntPtr id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoRectifyUncalibrated' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("stereoRectifyUncalibrated", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z", "")]
		public static unsafe bool StereoRectifyUncalibrated (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "stereoRectifyUncalibrated", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)Z");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='stereoRectifyUncalibrated' and count(parameter)=7 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Size'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat'] and parameter[7][@type='double']]"
		[Register ("stereoRectifyUncalibrated", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)Z", "")]
		public static unsafe bool StereoRectifyUncalibrated (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Size p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5, double p6)
		{
			if (id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D == IntPtr.Zero)
				id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D = JNIEnv.GetStaticMethodID (class_ref, "stereoRectifyUncalibrated", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;D)Z");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_stereoRectifyUncalibrated_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_D, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_triangulatePoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='triangulatePoints' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat']]"
		[Register ("triangulatePoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void TriangulatePoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4)
		{
			if (id_triangulatePoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_triangulatePoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "triangulatePoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_triangulatePoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='undistortImage' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("undistortImage", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void UndistortImage (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistortImage", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='undistortImage' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Size']]"
		[Register ("undistortImage", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V", "")]
		public static unsafe void UndistortImage (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Size p5)
		{
			if (id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ == IntPtr.Zero)
				id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_ = JNIEnv.GetStaticMethodID (class_ref, "undistortImage", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Size;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortImage_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='undistortPoints' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("undistortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void UndistortPoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3)
		{
			if (id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='undistortPoints' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.Mat'] and parameter[4][@type='org.opencv.core.Mat'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='org.opencv.core.Mat']]"
		[Register ("undistortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V", "")]
		public static unsafe void UndistortPoints (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.Mat p2, global::OpenCV.Core.Mat p3, global::OpenCV.Core.Mat p4, global::OpenCV.Core.Mat p5)
		{
			if (id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_ = JNIEnv.GetStaticMethodID (class_ref, "undistortPoints", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_undistortPoints_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_, __args);
			} finally {
			}
		}

		static IntPtr id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='validateDisparity' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("validateDisparity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V", "")]
		public static unsafe void ValidateDisparity (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3)
		{
			if (id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II == IntPtr.Zero)
				id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II = JNIEnv.GetStaticMethodID (class_ref, "validateDisparity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_II, __args);
			} finally {
			}
		}

		static IntPtr id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='Calib3d']/method[@name='validateDisparity' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("validateDisparity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V", "")]
		public static unsafe void ValidateDisparity (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, int p2, int p3, int p4)
		{
			if (id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III == IntPtr.Zero)
				id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III = JNIEnv.GetStaticMethodID (class_ref, "validateDisparity", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;III)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validateDisparity_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_III, __args);
			} finally {
			}
		}

	}
}
