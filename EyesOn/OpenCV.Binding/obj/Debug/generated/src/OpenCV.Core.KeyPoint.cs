using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']"
	[global::Android.Runtime.Register ("org/opencv/core/KeyPoint", DoNotGenerateAcw=true)]
	public partial class KeyPoint : global::Java.Lang.Object {


		static IntPtr angle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='angle']"
		[Register ("angle")]
		public float Angle {
			get {
				if (angle_jfieldId == IntPtr.Zero)
					angle_jfieldId = JNIEnv.GetFieldID (class_ref, "angle", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, angle_jfieldId);
			}
			set {
				if (angle_jfieldId == IntPtr.Zero)
					angle_jfieldId = JNIEnv.GetFieldID (class_ref, "angle", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, angle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr class_id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='class_id']"
		[Register ("class_id")]
		public int ClassId {
			get {
				if (class_id_jfieldId == IntPtr.Zero)
					class_id_jfieldId = JNIEnv.GetFieldID (class_ref, "class_id", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, class_id_jfieldId);
			}
			set {
				if (class_id_jfieldId == IntPtr.Zero)
					class_id_jfieldId = JNIEnv.GetFieldID (class_ref, "class_id", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, class_id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr octave_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='octave']"
		[Register ("octave")]
		public int Octave {
			get {
				if (octave_jfieldId == IntPtr.Zero)
					octave_jfieldId = JNIEnv.GetFieldID (class_ref, "octave", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, octave_jfieldId);
			}
			set {
				if (octave_jfieldId == IntPtr.Zero)
					octave_jfieldId = JNIEnv.GetFieldID (class_ref, "octave", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, octave_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='pt']"
		[Register ("pt")]
		public global::OpenCV.Core.Point Pt {
			get {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lorg/opencv/core/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pt_jfieldId == IntPtr.Zero)
					pt_jfieldId = JNIEnv.GetFieldID (class_ref, "pt", "Lorg/opencv/core/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr response_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='response']"
		[Register ("response")]
		public float Response {
			get {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, response_jfieldId);
			}
			set {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, response_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/field[@name='size']"
		[Register ("size")]
		public float Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, size_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/KeyPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyPoint); }
		}

		protected KeyPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(FFF)V", "")]
		public unsafe KeyPoint (float p0, float p1, float p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (KeyPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFF)V", __args);
					return;
				}

				if (id_ctor_FFF == IntPtr.Zero)
					id_ctor_FFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_FFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public unsafe KeyPoint (float p0, float p1, float p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (KeyPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFF)V", __args);
					return;
				}

				if (id_ctor_FFFF == IntPtr.Zero)
					id_ctor_FFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_FFFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register (".ctor", "(FFFFF)V", "")]
		public unsafe KeyPoint (float p0, float p1, float p2, float p3, float p4)
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
				if (GetType () != typeof (KeyPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFF)V", __args);
					return;
				}

				if (id_ctor_FFFFF == IntPtr.Zero)
					id_ctor_FFFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_FFFFFII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=7 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register (".ctor", "(FFFFFII)V", "")]
		public unsafe KeyPoint (float p0, float p1, float p2, float p3, float p4, int p5, int p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (KeyPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFFII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFFII)V", __args);
					return;
				}

				if (id_ctor_FFFFFII == IntPtr.Zero)
					id_ctor_FFFFFII = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFFII, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KeyPoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (KeyPoint)) {
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

		static IntPtr id_ctor_FFFFFI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='KeyPoint']/constructor[@name='KeyPoint' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int']]"
		[Register (".ctor", "(FFFFFI)V", "")]
		public unsafe KeyPoint (float p0, float p1, float p2, float p3, float p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (KeyPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(FFFFFI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFFI)V", __args);
					return;
				}

				if (id_ctor_FFFFFI == IntPtr.Zero)
					id_ctor_FFFFFI = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFFI, __args);
			} finally {
			}
		}

	}
}
