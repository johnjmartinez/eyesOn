using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ImgProc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']"
	[global::Android.Runtime.Register ("org/opencv/imgproc/Moments", DoNotGenerateAcw=true)]
	public partial class Moments : global::Java.Lang.Object {


		static IntPtr m00_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m00']"
		[Register ("m00")]
		public double M00 {
			get {
				if (m00_jfieldId == IntPtr.Zero)
					m00_jfieldId = JNIEnv.GetFieldID (class_ref, "m00", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m00_jfieldId);
			}
			set {
				if (m00_jfieldId == IntPtr.Zero)
					m00_jfieldId = JNIEnv.GetFieldID (class_ref, "m00", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m00_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m01_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m01']"
		[Register ("m01")]
		public double M01 {
			get {
				if (m01_jfieldId == IntPtr.Zero)
					m01_jfieldId = JNIEnv.GetFieldID (class_ref, "m01", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m01_jfieldId);
			}
			set {
				if (m01_jfieldId == IntPtr.Zero)
					m01_jfieldId = JNIEnv.GetFieldID (class_ref, "m01", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m01_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m02_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m02']"
		[Register ("m02")]
		public double M02 {
			get {
				if (m02_jfieldId == IntPtr.Zero)
					m02_jfieldId = JNIEnv.GetFieldID (class_ref, "m02", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m02_jfieldId);
			}
			set {
				if (m02_jfieldId == IntPtr.Zero)
					m02_jfieldId = JNIEnv.GetFieldID (class_ref, "m02", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m02_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m03_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m03']"
		[Register ("m03")]
		public double M03 {
			get {
				if (m03_jfieldId == IntPtr.Zero)
					m03_jfieldId = JNIEnv.GetFieldID (class_ref, "m03", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m03_jfieldId);
			}
			set {
				if (m03_jfieldId == IntPtr.Zero)
					m03_jfieldId = JNIEnv.GetFieldID (class_ref, "m03", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m03_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m10']"
		[Register ("m10")]
		public double M10 {
			get {
				if (m10_jfieldId == IntPtr.Zero)
					m10_jfieldId = JNIEnv.GetFieldID (class_ref, "m10", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m10_jfieldId);
			}
			set {
				if (m10_jfieldId == IntPtr.Zero)
					m10_jfieldId = JNIEnv.GetFieldID (class_ref, "m10", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m10_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m11']"
		[Register ("m11")]
		public double M11 {
			get {
				if (m11_jfieldId == IntPtr.Zero)
					m11_jfieldId = JNIEnv.GetFieldID (class_ref, "m11", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m11_jfieldId);
			}
			set {
				if (m11_jfieldId == IntPtr.Zero)
					m11_jfieldId = JNIEnv.GetFieldID (class_ref, "m11", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m11_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m12_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m12']"
		[Register ("m12")]
		public double M12 {
			get {
				if (m12_jfieldId == IntPtr.Zero)
					m12_jfieldId = JNIEnv.GetFieldID (class_ref, "m12", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m12_jfieldId);
			}
			set {
				if (m12_jfieldId == IntPtr.Zero)
					m12_jfieldId = JNIEnv.GetFieldID (class_ref, "m12", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m12_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m20_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m20']"
		[Register ("m20")]
		public double M20 {
			get {
				if (m20_jfieldId == IntPtr.Zero)
					m20_jfieldId = JNIEnv.GetFieldID (class_ref, "m20", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m20_jfieldId);
			}
			set {
				if (m20_jfieldId == IntPtr.Zero)
					m20_jfieldId = JNIEnv.GetFieldID (class_ref, "m20", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m20_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m21_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m21']"
		[Register ("m21")]
		public double M21 {
			get {
				if (m21_jfieldId == IntPtr.Zero)
					m21_jfieldId = JNIEnv.GetFieldID (class_ref, "m21", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m21_jfieldId);
			}
			set {
				if (m21_jfieldId == IntPtr.Zero)
					m21_jfieldId = JNIEnv.GetFieldID (class_ref, "m21", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m21_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m30_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='m30']"
		[Register ("m30")]
		public double M30 {
			get {
				if (m30_jfieldId == IntPtr.Zero)
					m30_jfieldId = JNIEnv.GetFieldID (class_ref, "m30", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, m30_jfieldId);
			}
			set {
				if (m30_jfieldId == IntPtr.Zero)
					m30_jfieldId = JNIEnv.GetFieldID (class_ref, "m30", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m30_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu02_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu02']"
		[Register ("mu02")]
		public double Mu02 {
			get {
				if (mu02_jfieldId == IntPtr.Zero)
					mu02_jfieldId = JNIEnv.GetFieldID (class_ref, "mu02", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu02_jfieldId);
			}
			set {
				if (mu02_jfieldId == IntPtr.Zero)
					mu02_jfieldId = JNIEnv.GetFieldID (class_ref, "mu02", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu02_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu03_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu03']"
		[Register ("mu03")]
		public double Mu03 {
			get {
				if (mu03_jfieldId == IntPtr.Zero)
					mu03_jfieldId = JNIEnv.GetFieldID (class_ref, "mu03", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu03_jfieldId);
			}
			set {
				if (mu03_jfieldId == IntPtr.Zero)
					mu03_jfieldId = JNIEnv.GetFieldID (class_ref, "mu03", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu03_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu11']"
		[Register ("mu11")]
		public double Mu11 {
			get {
				if (mu11_jfieldId == IntPtr.Zero)
					mu11_jfieldId = JNIEnv.GetFieldID (class_ref, "mu11", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu11_jfieldId);
			}
			set {
				if (mu11_jfieldId == IntPtr.Zero)
					mu11_jfieldId = JNIEnv.GetFieldID (class_ref, "mu11", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu11_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu12_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu12']"
		[Register ("mu12")]
		public double Mu12 {
			get {
				if (mu12_jfieldId == IntPtr.Zero)
					mu12_jfieldId = JNIEnv.GetFieldID (class_ref, "mu12", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu12_jfieldId);
			}
			set {
				if (mu12_jfieldId == IntPtr.Zero)
					mu12_jfieldId = JNIEnv.GetFieldID (class_ref, "mu12", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu12_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu20_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu20']"
		[Register ("mu20")]
		public double Mu20 {
			get {
				if (mu20_jfieldId == IntPtr.Zero)
					mu20_jfieldId = JNIEnv.GetFieldID (class_ref, "mu20", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu20_jfieldId);
			}
			set {
				if (mu20_jfieldId == IntPtr.Zero)
					mu20_jfieldId = JNIEnv.GetFieldID (class_ref, "mu20", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu20_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu21_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu21']"
		[Register ("mu21")]
		public double Mu21 {
			get {
				if (mu21_jfieldId == IntPtr.Zero)
					mu21_jfieldId = JNIEnv.GetFieldID (class_ref, "mu21", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu21_jfieldId);
			}
			set {
				if (mu21_jfieldId == IntPtr.Zero)
					mu21_jfieldId = JNIEnv.GetFieldID (class_ref, "mu21", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu21_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mu30_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='mu30']"
		[Register ("mu30")]
		public double Mu30 {
			get {
				if (mu30_jfieldId == IntPtr.Zero)
					mu30_jfieldId = JNIEnv.GetFieldID (class_ref, "mu30", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mu30_jfieldId);
			}
			set {
				if (mu30_jfieldId == IntPtr.Zero)
					mu30_jfieldId = JNIEnv.GetFieldID (class_ref, "mu30", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mu30_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu02_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu02']"
		[Register ("nu02")]
		public double Nu02 {
			get {
				if (nu02_jfieldId == IntPtr.Zero)
					nu02_jfieldId = JNIEnv.GetFieldID (class_ref, "nu02", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu02_jfieldId);
			}
			set {
				if (nu02_jfieldId == IntPtr.Zero)
					nu02_jfieldId = JNIEnv.GetFieldID (class_ref, "nu02", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu02_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu03_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu03']"
		[Register ("nu03")]
		public double Nu03 {
			get {
				if (nu03_jfieldId == IntPtr.Zero)
					nu03_jfieldId = JNIEnv.GetFieldID (class_ref, "nu03", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu03_jfieldId);
			}
			set {
				if (nu03_jfieldId == IntPtr.Zero)
					nu03_jfieldId = JNIEnv.GetFieldID (class_ref, "nu03", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu03_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu11']"
		[Register ("nu11")]
		public double Nu11 {
			get {
				if (nu11_jfieldId == IntPtr.Zero)
					nu11_jfieldId = JNIEnv.GetFieldID (class_ref, "nu11", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu11_jfieldId);
			}
			set {
				if (nu11_jfieldId == IntPtr.Zero)
					nu11_jfieldId = JNIEnv.GetFieldID (class_ref, "nu11", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu11_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu12_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu12']"
		[Register ("nu12")]
		public double Nu12 {
			get {
				if (nu12_jfieldId == IntPtr.Zero)
					nu12_jfieldId = JNIEnv.GetFieldID (class_ref, "nu12", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu12_jfieldId);
			}
			set {
				if (nu12_jfieldId == IntPtr.Zero)
					nu12_jfieldId = JNIEnv.GetFieldID (class_ref, "nu12", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu12_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu20_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu20']"
		[Register ("nu20")]
		public double Nu20 {
			get {
				if (nu20_jfieldId == IntPtr.Zero)
					nu20_jfieldId = JNIEnv.GetFieldID (class_ref, "nu20", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu20_jfieldId);
			}
			set {
				if (nu20_jfieldId == IntPtr.Zero)
					nu20_jfieldId = JNIEnv.GetFieldID (class_ref, "nu20", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu20_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu21_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu21']"
		[Register ("nu21")]
		public double Nu21 {
			get {
				if (nu21_jfieldId == IntPtr.Zero)
					nu21_jfieldId = JNIEnv.GetFieldID (class_ref, "nu21", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu21_jfieldId);
			}
			set {
				if (nu21_jfieldId == IntPtr.Zero)
					nu21_jfieldId = JNIEnv.GetFieldID (class_ref, "nu21", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu21_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nu30_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/field[@name='nu30']"
		[Register ("nu30")]
		public double Nu30 {
			get {
				if (nu30_jfieldId == IntPtr.Zero)
					nu30_jfieldId = JNIEnv.GetFieldID (class_ref, "nu30", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, nu30_jfieldId);
			}
			set {
				if (nu30_jfieldId == IntPtr.Zero)
					nu30_jfieldId = JNIEnv.GetFieldID (class_ref, "nu30", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nu30_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/imgproc/Moments", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Moments); }
		}

		protected Moments (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/constructor[@name='Moments' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register (".ctor", "([D)V", "")]
		public unsafe Moments (double[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Moments)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([D)V", __args);
					return;
				}

				if (id_ctor_arrayD == IntPtr.Zero)
					id_ctor_arrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/constructor[@name='Moments' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Moments ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Moments)) {
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

		static IntPtr id_ctor_DDDDDDDDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/constructor[@name='Moments' and count(parameter)=10 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='double'] and parameter[9][@type='double'] and parameter[10][@type='double']]"
		[Register (".ctor", "(DDDDDDDDDD)V", "")]
		public unsafe Moments (double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7, double p8, double p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

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
				if (GetType () != typeof (Moments)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDDDDDDDD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DDDDDDDDDD)V", __args);
					return;
				}

				if (id_ctor_DDDDDDDDDD == IntPtr.Zero)
					id_ctor_DDDDDDDDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDDDDDDDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDDDDDDDD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DDDDDDDDDD, __args);
			} finally {
			}
		}

		static Delegate cb_completeState;
#pragma warning disable 0169
		static Delegate GetCompleteStateHandler ()
		{
			if (cb_completeState == null)
				cb_completeState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CompleteState);
			return cb_completeState;
		}

		static void n_CompleteState (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompleteState ();
		}
#pragma warning restore 0169

		static IntPtr id_completeState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='completeState' and count(parameter)=0]"
		[Register ("completeState", "()V", "GetCompleteStateHandler")]
		protected virtual unsafe void CompleteState ()
		{
			if (id_completeState == IntPtr.Zero)
				id_completeState = JNIEnv.GetMethodID (class_ref, "completeState", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_completeState);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "completeState", "()V"));
			} finally {
			}
		}

		static Delegate cb_get_m00;
#pragma warning disable 0169
		static Delegate GetGet_m00Handler ()
		{
			if (cb_get_m00 == null)
				cb_get_m00 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m00);
			return cb_get_m00;
		}

		static double n_Get_m00 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m00 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m00;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m00' and count(parameter)=0]"
		[Register ("get_m00", "()D", "GetGet_m00Handler")]
		public virtual unsafe double Get_m00 ()
		{
			if (id_get_m00 == IntPtr.Zero)
				id_get_m00 = JNIEnv.GetMethodID (class_ref, "get_m00", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m00);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m00", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m01;
#pragma warning disable 0169
		static Delegate GetGet_m01Handler ()
		{
			if (cb_get_m01 == null)
				cb_get_m01 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m01);
			return cb_get_m01;
		}

		static double n_Get_m01 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m01 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m01;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m01' and count(parameter)=0]"
		[Register ("get_m01", "()D", "GetGet_m01Handler")]
		public virtual unsafe double Get_m01 ()
		{
			if (id_get_m01 == IntPtr.Zero)
				id_get_m01 = JNIEnv.GetMethodID (class_ref, "get_m01", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m01);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m01", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m02;
#pragma warning disable 0169
		static Delegate GetGet_m02Handler ()
		{
			if (cb_get_m02 == null)
				cb_get_m02 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m02);
			return cb_get_m02;
		}

		static double n_Get_m02 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m02 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m02;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m02' and count(parameter)=0]"
		[Register ("get_m02", "()D", "GetGet_m02Handler")]
		public virtual unsafe double Get_m02 ()
		{
			if (id_get_m02 == IntPtr.Zero)
				id_get_m02 = JNIEnv.GetMethodID (class_ref, "get_m02", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m02);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m02", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m03;
#pragma warning disable 0169
		static Delegate GetGet_m03Handler ()
		{
			if (cb_get_m03 == null)
				cb_get_m03 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m03);
			return cb_get_m03;
		}

		static double n_Get_m03 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m03 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m03;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m03' and count(parameter)=0]"
		[Register ("get_m03", "()D", "GetGet_m03Handler")]
		public virtual unsafe double Get_m03 ()
		{
			if (id_get_m03 == IntPtr.Zero)
				id_get_m03 = JNIEnv.GetMethodID (class_ref, "get_m03", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m03);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m03", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m10;
#pragma warning disable 0169
		static Delegate GetGet_m10Handler ()
		{
			if (cb_get_m10 == null)
				cb_get_m10 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m10);
			return cb_get_m10;
		}

		static double n_Get_m10 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m10 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m10;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m10' and count(parameter)=0]"
		[Register ("get_m10", "()D", "GetGet_m10Handler")]
		public virtual unsafe double Get_m10 ()
		{
			if (id_get_m10 == IntPtr.Zero)
				id_get_m10 = JNIEnv.GetMethodID (class_ref, "get_m10", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m10);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m10", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m11;
#pragma warning disable 0169
		static Delegate GetGet_m11Handler ()
		{
			if (cb_get_m11 == null)
				cb_get_m11 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m11);
			return cb_get_m11;
		}

		static double n_Get_m11 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m11 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m11;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m11' and count(parameter)=0]"
		[Register ("get_m11", "()D", "GetGet_m11Handler")]
		public virtual unsafe double Get_m11 ()
		{
			if (id_get_m11 == IntPtr.Zero)
				id_get_m11 = JNIEnv.GetMethodID (class_ref, "get_m11", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m11);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m11", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m12;
#pragma warning disable 0169
		static Delegate GetGet_m12Handler ()
		{
			if (cb_get_m12 == null)
				cb_get_m12 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m12);
			return cb_get_m12;
		}

		static double n_Get_m12 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m12 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m12;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m12' and count(parameter)=0]"
		[Register ("get_m12", "()D", "GetGet_m12Handler")]
		public virtual unsafe double Get_m12 ()
		{
			if (id_get_m12 == IntPtr.Zero)
				id_get_m12 = JNIEnv.GetMethodID (class_ref, "get_m12", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m12);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m12", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m20;
#pragma warning disable 0169
		static Delegate GetGet_m20Handler ()
		{
			if (cb_get_m20 == null)
				cb_get_m20 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m20);
			return cb_get_m20;
		}

		static double n_Get_m20 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m20 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m20;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m20' and count(parameter)=0]"
		[Register ("get_m20", "()D", "GetGet_m20Handler")]
		public virtual unsafe double Get_m20 ()
		{
			if (id_get_m20 == IntPtr.Zero)
				id_get_m20 = JNIEnv.GetMethodID (class_ref, "get_m20", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m20);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m20", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m21;
#pragma warning disable 0169
		static Delegate GetGet_m21Handler ()
		{
			if (cb_get_m21 == null)
				cb_get_m21 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m21);
			return cb_get_m21;
		}

		static double n_Get_m21 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m21 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m21;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m21' and count(parameter)=0]"
		[Register ("get_m21", "()D", "GetGet_m21Handler")]
		public virtual unsafe double Get_m21 ()
		{
			if (id_get_m21 == IntPtr.Zero)
				id_get_m21 = JNIEnv.GetMethodID (class_ref, "get_m21", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m21);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m21", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_m30;
#pragma warning disable 0169
		static Delegate GetGet_m30Handler ()
		{
			if (cb_get_m30 == null)
				cb_get_m30 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_m30);
			return cb_get_m30;
		}

		static double n_Get_m30 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_m30 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_m30;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_m30' and count(parameter)=0]"
		[Register ("get_m30", "()D", "GetGet_m30Handler")]
		public virtual unsafe double Get_m30 ()
		{
			if (id_get_m30 == IntPtr.Zero)
				id_get_m30 = JNIEnv.GetMethodID (class_ref, "get_m30", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_m30);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_m30", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu02;
#pragma warning disable 0169
		static Delegate GetGet_mu02Handler ()
		{
			if (cb_get_mu02 == null)
				cb_get_mu02 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu02);
			return cb_get_mu02;
		}

		static double n_Get_mu02 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu02 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu02;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu02' and count(parameter)=0]"
		[Register ("get_mu02", "()D", "GetGet_mu02Handler")]
		public virtual unsafe double Get_mu02 ()
		{
			if (id_get_mu02 == IntPtr.Zero)
				id_get_mu02 = JNIEnv.GetMethodID (class_ref, "get_mu02", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu02);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu02", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu03;
#pragma warning disable 0169
		static Delegate GetGet_mu03Handler ()
		{
			if (cb_get_mu03 == null)
				cb_get_mu03 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu03);
			return cb_get_mu03;
		}

		static double n_Get_mu03 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu03 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu03;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu03' and count(parameter)=0]"
		[Register ("get_mu03", "()D", "GetGet_mu03Handler")]
		public virtual unsafe double Get_mu03 ()
		{
			if (id_get_mu03 == IntPtr.Zero)
				id_get_mu03 = JNIEnv.GetMethodID (class_ref, "get_mu03", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu03);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu03", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu11;
#pragma warning disable 0169
		static Delegate GetGet_mu11Handler ()
		{
			if (cb_get_mu11 == null)
				cb_get_mu11 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu11);
			return cb_get_mu11;
		}

		static double n_Get_mu11 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu11 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu11;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu11' and count(parameter)=0]"
		[Register ("get_mu11", "()D", "GetGet_mu11Handler")]
		public virtual unsafe double Get_mu11 ()
		{
			if (id_get_mu11 == IntPtr.Zero)
				id_get_mu11 = JNIEnv.GetMethodID (class_ref, "get_mu11", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu11);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu11", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu12;
#pragma warning disable 0169
		static Delegate GetGet_mu12Handler ()
		{
			if (cb_get_mu12 == null)
				cb_get_mu12 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu12);
			return cb_get_mu12;
		}

		static double n_Get_mu12 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu12 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu12;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu12' and count(parameter)=0]"
		[Register ("get_mu12", "()D", "GetGet_mu12Handler")]
		public virtual unsafe double Get_mu12 ()
		{
			if (id_get_mu12 == IntPtr.Zero)
				id_get_mu12 = JNIEnv.GetMethodID (class_ref, "get_mu12", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu12);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu12", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu20;
#pragma warning disable 0169
		static Delegate GetGet_mu20Handler ()
		{
			if (cb_get_mu20 == null)
				cb_get_mu20 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu20);
			return cb_get_mu20;
		}

		static double n_Get_mu20 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu20 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu20;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu20' and count(parameter)=0]"
		[Register ("get_mu20", "()D", "GetGet_mu20Handler")]
		public virtual unsafe double Get_mu20 ()
		{
			if (id_get_mu20 == IntPtr.Zero)
				id_get_mu20 = JNIEnv.GetMethodID (class_ref, "get_mu20", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu20);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu20", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu21;
#pragma warning disable 0169
		static Delegate GetGet_mu21Handler ()
		{
			if (cb_get_mu21 == null)
				cb_get_mu21 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu21);
			return cb_get_mu21;
		}

		static double n_Get_mu21 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu21 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu21;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu21' and count(parameter)=0]"
		[Register ("get_mu21", "()D", "GetGet_mu21Handler")]
		public virtual unsafe double Get_mu21 ()
		{
			if (id_get_mu21 == IntPtr.Zero)
				id_get_mu21 = JNIEnv.GetMethodID (class_ref, "get_mu21", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu21);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu21", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_mu30;
#pragma warning disable 0169
		static Delegate GetGet_mu30Handler ()
		{
			if (cb_get_mu30 == null)
				cb_get_mu30 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_mu30);
			return cb_get_mu30;
		}

		static double n_Get_mu30 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_mu30 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_mu30;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_mu30' and count(parameter)=0]"
		[Register ("get_mu30", "()D", "GetGet_mu30Handler")]
		public virtual unsafe double Get_mu30 ()
		{
			if (id_get_mu30 == IntPtr.Zero)
				id_get_mu30 = JNIEnv.GetMethodID (class_ref, "get_mu30", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_mu30);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_mu30", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu02;
#pragma warning disable 0169
		static Delegate GetGet_nu02Handler ()
		{
			if (cb_get_nu02 == null)
				cb_get_nu02 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu02);
			return cb_get_nu02;
		}

		static double n_Get_nu02 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu02 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu02;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu02' and count(parameter)=0]"
		[Register ("get_nu02", "()D", "GetGet_nu02Handler")]
		public virtual unsafe double Get_nu02 ()
		{
			if (id_get_nu02 == IntPtr.Zero)
				id_get_nu02 = JNIEnv.GetMethodID (class_ref, "get_nu02", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu02);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu02", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu03;
#pragma warning disable 0169
		static Delegate GetGet_nu03Handler ()
		{
			if (cb_get_nu03 == null)
				cb_get_nu03 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu03);
			return cb_get_nu03;
		}

		static double n_Get_nu03 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu03 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu03;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu03' and count(parameter)=0]"
		[Register ("get_nu03", "()D", "GetGet_nu03Handler")]
		public virtual unsafe double Get_nu03 ()
		{
			if (id_get_nu03 == IntPtr.Zero)
				id_get_nu03 = JNIEnv.GetMethodID (class_ref, "get_nu03", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu03);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu03", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu11;
#pragma warning disable 0169
		static Delegate GetGet_nu11Handler ()
		{
			if (cb_get_nu11 == null)
				cb_get_nu11 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu11);
			return cb_get_nu11;
		}

		static double n_Get_nu11 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu11 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu11;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu11' and count(parameter)=0]"
		[Register ("get_nu11", "()D", "GetGet_nu11Handler")]
		public virtual unsafe double Get_nu11 ()
		{
			if (id_get_nu11 == IntPtr.Zero)
				id_get_nu11 = JNIEnv.GetMethodID (class_ref, "get_nu11", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu11);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu11", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu12;
#pragma warning disable 0169
		static Delegate GetGet_nu12Handler ()
		{
			if (cb_get_nu12 == null)
				cb_get_nu12 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu12);
			return cb_get_nu12;
		}

		static double n_Get_nu12 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu12 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu12;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu12' and count(parameter)=0]"
		[Register ("get_nu12", "()D", "GetGet_nu12Handler")]
		public virtual unsafe double Get_nu12 ()
		{
			if (id_get_nu12 == IntPtr.Zero)
				id_get_nu12 = JNIEnv.GetMethodID (class_ref, "get_nu12", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu12);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu12", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu20;
#pragma warning disable 0169
		static Delegate GetGet_nu20Handler ()
		{
			if (cb_get_nu20 == null)
				cb_get_nu20 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu20);
			return cb_get_nu20;
		}

		static double n_Get_nu20 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu20 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu20;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu20' and count(parameter)=0]"
		[Register ("get_nu20", "()D", "GetGet_nu20Handler")]
		public virtual unsafe double Get_nu20 ()
		{
			if (id_get_nu20 == IntPtr.Zero)
				id_get_nu20 = JNIEnv.GetMethodID (class_ref, "get_nu20", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu20);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu20", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu21;
#pragma warning disable 0169
		static Delegate GetGet_nu21Handler ()
		{
			if (cb_get_nu21 == null)
				cb_get_nu21 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu21);
			return cb_get_nu21;
		}

		static double n_Get_nu21 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu21 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu21;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu21' and count(parameter)=0]"
		[Register ("get_nu21", "()D", "GetGet_nu21Handler")]
		public virtual unsafe double Get_nu21 ()
		{
			if (id_get_nu21 == IntPtr.Zero)
				id_get_nu21 = JNIEnv.GetMethodID (class_ref, "get_nu21", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu21);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu21", "()D"));
			} finally {
			}
		}

		static Delegate cb_get_nu30;
#pragma warning disable 0169
		static Delegate GetGet_nu30Handler ()
		{
			if (cb_get_nu30 == null)
				cb_get_nu30 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Get_nu30);
			return cb_get_nu30;
		}

		static double n_Get_nu30 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_nu30 ();
		}
#pragma warning restore 0169

		static IntPtr id_get_nu30;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='get_nu30' and count(parameter)=0]"
		[Register ("get_nu30", "()D", "GetGet_nu30Handler")]
		public virtual unsafe double Get_nu30 ()
		{
			if (id_get_nu30 == IntPtr.Zero)
				id_get_nu30 = JNIEnv.GetMethodID (class_ref, "get_nu30", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_get_nu30);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get_nu30", "()D"));
			} finally {
			}
		}

		static Delegate cb_set_arrayD;
#pragma warning disable 0169
		static Delegate GetSet_arrayDHandler ()
		{
			if (cb_set_arrayD == null)
				cb_set_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_arrayD);
			return cb_set_arrayD;
		}

		static void n_Set_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Set (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("set", "([D)V", "GetSet_arrayDHandler")]
		public virtual unsafe void Set (double[] p0)
		{
			if (id_set_arrayD == IntPtr.Zero)
				id_set_arrayD = JNIEnv.GetMethodID (class_ref, "set", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_set_m00_D;
#pragma warning disable 0169
		static Delegate GetSet_m00_DHandler ()
		{
			if (cb_set_m00_D == null)
				cb_set_m00_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m00_D);
			return cb_set_m00_D;
		}

		static void n_Set_m00_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m00 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m00_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m00' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m00", "(D)V", "GetSet_m00_DHandler")]
		public virtual unsafe void Set_m00 (double p0)
		{
			if (id_set_m00_D == IntPtr.Zero)
				id_set_m00_D = JNIEnv.GetMethodID (class_ref, "set_m00", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m00_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m00", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m01_D;
#pragma warning disable 0169
		static Delegate GetSet_m01_DHandler ()
		{
			if (cb_set_m01_D == null)
				cb_set_m01_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m01_D);
			return cb_set_m01_D;
		}

		static void n_Set_m01_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m01 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m01_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m01' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m01", "(D)V", "GetSet_m01_DHandler")]
		public virtual unsafe void Set_m01 (double p0)
		{
			if (id_set_m01_D == IntPtr.Zero)
				id_set_m01_D = JNIEnv.GetMethodID (class_ref, "set_m01", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m01_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m01", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m02_D;
#pragma warning disable 0169
		static Delegate GetSet_m02_DHandler ()
		{
			if (cb_set_m02_D == null)
				cb_set_m02_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m02_D);
			return cb_set_m02_D;
		}

		static void n_Set_m02_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m02 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m02_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m02' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m02", "(D)V", "GetSet_m02_DHandler")]
		public virtual unsafe void Set_m02 (double p0)
		{
			if (id_set_m02_D == IntPtr.Zero)
				id_set_m02_D = JNIEnv.GetMethodID (class_ref, "set_m02", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m02_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m02", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m03_D;
#pragma warning disable 0169
		static Delegate GetSet_m03_DHandler ()
		{
			if (cb_set_m03_D == null)
				cb_set_m03_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m03_D);
			return cb_set_m03_D;
		}

		static void n_Set_m03_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m03 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m03_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m03' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m03", "(D)V", "GetSet_m03_DHandler")]
		public virtual unsafe void Set_m03 (double p0)
		{
			if (id_set_m03_D == IntPtr.Zero)
				id_set_m03_D = JNIEnv.GetMethodID (class_ref, "set_m03", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m03_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m03", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m10_D;
#pragma warning disable 0169
		static Delegate GetSet_m10_DHandler ()
		{
			if (cb_set_m10_D == null)
				cb_set_m10_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m10_D);
			return cb_set_m10_D;
		}

		static void n_Set_m10_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m10 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m10_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m10' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m10", "(D)V", "GetSet_m10_DHandler")]
		public virtual unsafe void Set_m10 (double p0)
		{
			if (id_set_m10_D == IntPtr.Zero)
				id_set_m10_D = JNIEnv.GetMethodID (class_ref, "set_m10", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m10_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m10", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m11_D;
#pragma warning disable 0169
		static Delegate GetSet_m11_DHandler ()
		{
			if (cb_set_m11_D == null)
				cb_set_m11_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m11_D);
			return cb_set_m11_D;
		}

		static void n_Set_m11_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m11 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m11_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m11' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m11", "(D)V", "GetSet_m11_DHandler")]
		public virtual unsafe void Set_m11 (double p0)
		{
			if (id_set_m11_D == IntPtr.Zero)
				id_set_m11_D = JNIEnv.GetMethodID (class_ref, "set_m11", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m11_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m11", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m12_D;
#pragma warning disable 0169
		static Delegate GetSet_m12_DHandler ()
		{
			if (cb_set_m12_D == null)
				cb_set_m12_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m12_D);
			return cb_set_m12_D;
		}

		static void n_Set_m12_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m12 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m12_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m12' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m12", "(D)V", "GetSet_m12_DHandler")]
		public virtual unsafe void Set_m12 (double p0)
		{
			if (id_set_m12_D == IntPtr.Zero)
				id_set_m12_D = JNIEnv.GetMethodID (class_ref, "set_m12", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m12_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m12", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m20_D;
#pragma warning disable 0169
		static Delegate GetSet_m20_DHandler ()
		{
			if (cb_set_m20_D == null)
				cb_set_m20_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m20_D);
			return cb_set_m20_D;
		}

		static void n_Set_m20_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m20 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m20_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m20' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m20", "(D)V", "GetSet_m20_DHandler")]
		public virtual unsafe void Set_m20 (double p0)
		{
			if (id_set_m20_D == IntPtr.Zero)
				id_set_m20_D = JNIEnv.GetMethodID (class_ref, "set_m20", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m20_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m20", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m21_D;
#pragma warning disable 0169
		static Delegate GetSet_m21_DHandler ()
		{
			if (cb_set_m21_D == null)
				cb_set_m21_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m21_D);
			return cb_set_m21_D;
		}

		static void n_Set_m21_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m21 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m21_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m21' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m21", "(D)V", "GetSet_m21_DHandler")]
		public virtual unsafe void Set_m21 (double p0)
		{
			if (id_set_m21_D == IntPtr.Zero)
				id_set_m21_D = JNIEnv.GetMethodID (class_ref, "set_m21", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m21_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m21", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_m30_D;
#pragma warning disable 0169
		static Delegate GetSet_m30_DHandler ()
		{
			if (cb_set_m30_D == null)
				cb_set_m30_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_m30_D);
			return cb_set_m30_D;
		}

		static void n_Set_m30_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_m30 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_m30_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_m30' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_m30", "(D)V", "GetSet_m30_DHandler")]
		public virtual unsafe void Set_m30 (double p0)
		{
			if (id_set_m30_D == IntPtr.Zero)
				id_set_m30_D = JNIEnv.GetMethodID (class_ref, "set_m30", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_m30_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_m30", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu02_D;
#pragma warning disable 0169
		static Delegate GetSet_mu02_DHandler ()
		{
			if (cb_set_mu02_D == null)
				cb_set_mu02_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu02_D);
			return cb_set_mu02_D;
		}

		static void n_Set_mu02_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu02 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu02_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu02' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu02", "(D)V", "GetSet_mu02_DHandler")]
		public virtual unsafe void Set_mu02 (double p0)
		{
			if (id_set_mu02_D == IntPtr.Zero)
				id_set_mu02_D = JNIEnv.GetMethodID (class_ref, "set_mu02", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu02_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu02", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu03_D;
#pragma warning disable 0169
		static Delegate GetSet_mu03_DHandler ()
		{
			if (cb_set_mu03_D == null)
				cb_set_mu03_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu03_D);
			return cb_set_mu03_D;
		}

		static void n_Set_mu03_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu03 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu03_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu03' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu03", "(D)V", "GetSet_mu03_DHandler")]
		public virtual unsafe void Set_mu03 (double p0)
		{
			if (id_set_mu03_D == IntPtr.Zero)
				id_set_mu03_D = JNIEnv.GetMethodID (class_ref, "set_mu03", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu03_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu03", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu11_D;
#pragma warning disable 0169
		static Delegate GetSet_mu11_DHandler ()
		{
			if (cb_set_mu11_D == null)
				cb_set_mu11_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu11_D);
			return cb_set_mu11_D;
		}

		static void n_Set_mu11_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu11 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu11_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu11' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu11", "(D)V", "GetSet_mu11_DHandler")]
		public virtual unsafe void Set_mu11 (double p0)
		{
			if (id_set_mu11_D == IntPtr.Zero)
				id_set_mu11_D = JNIEnv.GetMethodID (class_ref, "set_mu11", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu11_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu11", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu12_D;
#pragma warning disable 0169
		static Delegate GetSet_mu12_DHandler ()
		{
			if (cb_set_mu12_D == null)
				cb_set_mu12_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu12_D);
			return cb_set_mu12_D;
		}

		static void n_Set_mu12_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu12 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu12_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu12' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu12", "(D)V", "GetSet_mu12_DHandler")]
		public virtual unsafe void Set_mu12 (double p0)
		{
			if (id_set_mu12_D == IntPtr.Zero)
				id_set_mu12_D = JNIEnv.GetMethodID (class_ref, "set_mu12", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu12_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu12", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu20_D;
#pragma warning disable 0169
		static Delegate GetSet_mu20_DHandler ()
		{
			if (cb_set_mu20_D == null)
				cb_set_mu20_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu20_D);
			return cb_set_mu20_D;
		}

		static void n_Set_mu20_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu20 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu20_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu20' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu20", "(D)V", "GetSet_mu20_DHandler")]
		public virtual unsafe void Set_mu20 (double p0)
		{
			if (id_set_mu20_D == IntPtr.Zero)
				id_set_mu20_D = JNIEnv.GetMethodID (class_ref, "set_mu20", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu20_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu20", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu21_D;
#pragma warning disable 0169
		static Delegate GetSet_mu21_DHandler ()
		{
			if (cb_set_mu21_D == null)
				cb_set_mu21_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu21_D);
			return cb_set_mu21_D;
		}

		static void n_Set_mu21_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu21 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu21_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu21' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu21", "(D)V", "GetSet_mu21_DHandler")]
		public virtual unsafe void Set_mu21 (double p0)
		{
			if (id_set_mu21_D == IntPtr.Zero)
				id_set_mu21_D = JNIEnv.GetMethodID (class_ref, "set_mu21", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu21_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu21", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_mu30_D;
#pragma warning disable 0169
		static Delegate GetSet_mu30_DHandler ()
		{
			if (cb_set_mu30_D == null)
				cb_set_mu30_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_mu30_D);
			return cb_set_mu30_D;
		}

		static void n_Set_mu30_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_mu30 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_mu30_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_mu30' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_mu30", "(D)V", "GetSet_mu30_DHandler")]
		public virtual unsafe void Set_mu30 (double p0)
		{
			if (id_set_mu30_D == IntPtr.Zero)
				id_set_mu30_D = JNIEnv.GetMethodID (class_ref, "set_mu30", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_mu30_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_mu30", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu02_D;
#pragma warning disable 0169
		static Delegate GetSet_nu02_DHandler ()
		{
			if (cb_set_nu02_D == null)
				cb_set_nu02_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu02_D);
			return cb_set_nu02_D;
		}

		static void n_Set_nu02_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu02 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu02_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu02' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu02", "(D)V", "GetSet_nu02_DHandler")]
		public virtual unsafe void Set_nu02 (double p0)
		{
			if (id_set_nu02_D == IntPtr.Zero)
				id_set_nu02_D = JNIEnv.GetMethodID (class_ref, "set_nu02", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu02_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu02", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu03_D;
#pragma warning disable 0169
		static Delegate GetSet_nu03_DHandler ()
		{
			if (cb_set_nu03_D == null)
				cb_set_nu03_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu03_D);
			return cb_set_nu03_D;
		}

		static void n_Set_nu03_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu03 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu03_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu03' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu03", "(D)V", "GetSet_nu03_DHandler")]
		public virtual unsafe void Set_nu03 (double p0)
		{
			if (id_set_nu03_D == IntPtr.Zero)
				id_set_nu03_D = JNIEnv.GetMethodID (class_ref, "set_nu03", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu03_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu03", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu11_D;
#pragma warning disable 0169
		static Delegate GetSet_nu11_DHandler ()
		{
			if (cb_set_nu11_D == null)
				cb_set_nu11_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu11_D);
			return cb_set_nu11_D;
		}

		static void n_Set_nu11_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu11 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu11_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu11' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu11", "(D)V", "GetSet_nu11_DHandler")]
		public virtual unsafe void Set_nu11 (double p0)
		{
			if (id_set_nu11_D == IntPtr.Zero)
				id_set_nu11_D = JNIEnv.GetMethodID (class_ref, "set_nu11", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu11_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu11", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu12_D;
#pragma warning disable 0169
		static Delegate GetSet_nu12_DHandler ()
		{
			if (cb_set_nu12_D == null)
				cb_set_nu12_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu12_D);
			return cb_set_nu12_D;
		}

		static void n_Set_nu12_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu12 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu12_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu12' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu12", "(D)V", "GetSet_nu12_DHandler")]
		public virtual unsafe void Set_nu12 (double p0)
		{
			if (id_set_nu12_D == IntPtr.Zero)
				id_set_nu12_D = JNIEnv.GetMethodID (class_ref, "set_nu12", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu12_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu12", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu20_D;
#pragma warning disable 0169
		static Delegate GetSet_nu20_DHandler ()
		{
			if (cb_set_nu20_D == null)
				cb_set_nu20_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu20_D);
			return cb_set_nu20_D;
		}

		static void n_Set_nu20_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu20 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu20_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu20' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu20", "(D)V", "GetSet_nu20_DHandler")]
		public virtual unsafe void Set_nu20 (double p0)
		{
			if (id_set_nu20_D == IntPtr.Zero)
				id_set_nu20_D = JNIEnv.GetMethodID (class_ref, "set_nu20", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu20_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu20", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu21_D;
#pragma warning disable 0169
		static Delegate GetSet_nu21_DHandler ()
		{
			if (cb_set_nu21_D == null)
				cb_set_nu21_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu21_D);
			return cb_set_nu21_D;
		}

		static void n_Set_nu21_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu21 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu21_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu21' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu21", "(D)V", "GetSet_nu21_DHandler")]
		public virtual unsafe void Set_nu21 (double p0)
		{
			if (id_set_nu21_D == IntPtr.Zero)
				id_set_nu21_D = JNIEnv.GetMethodID (class_ref, "set_nu21", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu21_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu21", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_nu30_D;
#pragma warning disable 0169
		static Delegate GetSet_nu30_DHandler ()
		{
			if (cb_set_nu30_D == null)
				cb_set_nu30_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Set_nu30_D);
			return cb_set_nu30_D;
		}

		static void n_Set_nu30_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::OpenCV.ImgProc.Moments __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Moments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_nu30 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_nu30_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Moments']/method[@name='set_nu30' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("set_nu30", "(D)V", "GetSet_nu30_DHandler")]
		public virtual unsafe void Set_nu30 (double p0)
		{
			if (id_set_nu30_D == IntPtr.Zero)
				id_set_nu30_D = JNIEnv.GetMethodID (class_ref, "set_nu30", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_nu30_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set_nu30", "(D)V"), __args);
			} finally {
			}
		}

	}
}
