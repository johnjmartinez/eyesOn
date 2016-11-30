using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ML {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']"
	[global::Android.Runtime.Register ("org/opencv/ml/Ml", DoNotGenerateAcw=true)]
	public partial class Ml : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='COL_SAMPLE']"
		[Register ("COL_SAMPLE")]
		public const int ColSample = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='ROW_SAMPLE']"
		[Register ("ROW_SAMPLE")]
		public const int RowSample = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='TEST_ERROR']"
		[Register ("TEST_ERROR")]
		public const int TestError = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='TRAIN_ERROR']"
		[Register ("TRAIN_ERROR")]
		public const int TrainError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='VAR_CATEGORICAL']"
		[Register ("VAR_CATEGORICAL")]
		public const int VarCategorical = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='VAR_NUMERICAL']"
		[Register ("VAR_NUMERICAL")]
		public const int VarNumerical = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/field[@name='VAR_ORDERED']"
		[Register ("VAR_ORDERED")]
		public const int VarOrdered = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/ml/Ml", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ml); }
		}

		protected Ml (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.ml']/class[@name='Ml']/constructor[@name='Ml' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ml ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Ml)) {
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

	}
}
