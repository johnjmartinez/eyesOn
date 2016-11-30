using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ObjDetect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']"
	[global::Android.Runtime.Register ("org/opencv/objdetect/Objdetect", DoNotGenerateAcw=true)]
	public partial class Objdetect : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/field[@name='CASCADE_DO_CANNY_PRUNING']"
		[Register ("CASCADE_DO_CANNY_PRUNING")]
		public const int CascadeDoCannyPruning = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/field[@name='CASCADE_DO_ROUGH_SEARCH']"
		[Register ("CASCADE_DO_ROUGH_SEARCH")]
		public const int CascadeDoRoughSearch = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/field[@name='CASCADE_FIND_BIGGEST_OBJECT']"
		[Register ("CASCADE_FIND_BIGGEST_OBJECT")]
		public const int CascadeFindBiggestObject = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/field[@name='CASCADE_SCALE_IMAGE']"
		[Register ("CASCADE_SCALE_IMAGE")]
		public const int CascadeScaleImage = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/objdetect/Objdetect", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Objdetect); }
		}

		protected Objdetect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/constructor[@name='Objdetect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Objdetect ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Objdetect)) {
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

		static IntPtr id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/method[@name='groupRectangles' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfRect'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='int']]"
		[Register ("groupRectangles", "(Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;I)V", "")]
		public static unsafe void GroupRectangles (global::OpenCV.Core.MatOfRect p0, global::OpenCV.Core.MatOfInt p1, int p2)
		{
			if (id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_I == IntPtr.Zero)
				id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_I = JNIEnv.GetStaticMethodID (class_ref, "groupRectangles", "(Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_I, __args);
			} finally {
			}
		}

		static IntPtr id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.objdetect']/class[@name='Objdetect']/method[@name='groupRectangles' and count(parameter)=4 and parameter[1][@type='org.opencv.core.MatOfRect'] and parameter[2][@type='org.opencv.core.MatOfInt'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("groupRectangles", "(Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;ID)V", "")]
		public static unsafe void GroupRectangles (global::OpenCV.Core.MatOfRect p0, global::OpenCV.Core.MatOfInt p1, int p2, double p3)
		{
			if (id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ID == IntPtr.Zero)
				id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ID = JNIEnv.GetStaticMethodID (class_ref, "groupRectangles", "(Lorg/opencv/core/MatOfRect;Lorg/opencv/core/MatOfInt;ID)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_groupRectangles_Lorg_opencv_core_MatOfRect_Lorg_opencv_core_MatOfInt_ID, __args);
			} finally {
			}
		}

	}
}
