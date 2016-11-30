using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']"
	[global::Android.Runtime.Register ("org/opencv/core/DMatch", DoNotGenerateAcw=true)]
	public partial class DMatch : global::Java.Lang.Object {


		static IntPtr distance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/field[@name='distance']"
		[Register ("distance")]
		public float Distance {
			get {
				if (distance_jfieldId == IntPtr.Zero)
					distance_jfieldId = JNIEnv.GetFieldID (class_ref, "distance", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, distance_jfieldId);
			}
			set {
				if (distance_jfieldId == IntPtr.Zero)
					distance_jfieldId = JNIEnv.GetFieldID (class_ref, "distance", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, distance_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr imgIdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/field[@name='imgIdx']"
		[Register ("imgIdx")]
		public int ImgIdx {
			get {
				if (imgIdx_jfieldId == IntPtr.Zero)
					imgIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "imgIdx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, imgIdx_jfieldId);
			}
			set {
				if (imgIdx_jfieldId == IntPtr.Zero)
					imgIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "imgIdx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imgIdx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr queryIdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/field[@name='queryIdx']"
		[Register ("queryIdx")]
		public int QueryIdx {
			get {
				if (queryIdx_jfieldId == IntPtr.Zero)
					queryIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "queryIdx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, queryIdx_jfieldId);
			}
			set {
				if (queryIdx_jfieldId == IntPtr.Zero)
					queryIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "queryIdx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, queryIdx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr trainIdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/field[@name='trainIdx']"
		[Register ("trainIdx")]
		public int TrainIdx {
			get {
				if (trainIdx_jfieldId == IntPtr.Zero)
					trainIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "trainIdx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, trainIdx_jfieldId);
			}
			set {
				if (trainIdx_jfieldId == IntPtr.Zero)
					trainIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "trainIdx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, trainIdx_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/core/DMatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DMatch); }
		}

		protected DMatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIIF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/constructor[@name='DMatch' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register (".ctor", "(IIIF)V", "")]
		public unsafe DMatch (int p0, int p1, int p2, float p3)
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
				if (GetType () != typeof (DMatch)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIF)V", __args);
					return;
				}

				if (id_ctor_IIIF == IntPtr.Zero)
					id_ctor_IIIF = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/constructor[@name='DMatch' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register (".ctor", "(IIF)V", "")]
		public unsafe DMatch (int p0, int p1, float p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DMatch)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIF)V", __args);
					return;
				}

				if (id_ctor_IIF == IntPtr.Zero)
					id_ctor_IIF = JNIEnv.GetMethodID (class_ref, "<init>", "(IIF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/constructor[@name='DMatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DMatch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DMatch)) {
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

		static Delegate cb_lessThan_Lorg_opencv_core_DMatch_;
#pragma warning disable 0169
		static Delegate GetLessThan_Lorg_opencv_core_DMatch_Handler ()
		{
			if (cb_lessThan_Lorg_opencv_core_DMatch_ == null)
				cb_lessThan_Lorg_opencv_core_DMatch_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LessThan_Lorg_opencv_core_DMatch_);
			return cb_lessThan_Lorg_opencv_core_DMatch_;
		}

		static bool n_LessThan_Lorg_opencv_core_DMatch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Core.DMatch __this = global::Java.Lang.Object.GetObject<global::OpenCV.Core.DMatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.DMatch p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.DMatch> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LessThan (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lessThan_Lorg_opencv_core_DMatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.core']/class[@name='DMatch']/method[@name='lessThan' and count(parameter)=1 and parameter[1][@type='org.opencv.core.DMatch']]"
		[Register ("lessThan", "(Lorg/opencv/core/DMatch;)Z", "GetLessThan_Lorg_opencv_core_DMatch_Handler")]
		public virtual unsafe bool LessThan (global::OpenCV.Core.DMatch p0)
		{
			if (id_lessThan_Lorg_opencv_core_DMatch_ == IntPtr.Zero)
				id_lessThan_Lorg_opencv_core_DMatch_ = JNIEnv.GetMethodID (class_ref, "lessThan", "(Lorg/opencv/core/DMatch;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_lessThan_Lorg_opencv_core_DMatch_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lessThan", "(Lorg/opencv/core/DMatch;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
