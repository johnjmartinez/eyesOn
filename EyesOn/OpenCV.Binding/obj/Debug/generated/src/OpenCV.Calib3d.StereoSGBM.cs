using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Calib3d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']"
	[global::Android.Runtime.Register ("org/opencv/calib3d/StereoSGBM", DoNotGenerateAcw=true)]
	public partial class StereoSGBM : global::OpenCV.Calib3d.StereoMatcher {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/field[@name='MODE_HH']"
		[Register ("MODE_HH")]
		public const int ModeHh = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/field[@name='MODE_SGBM']"
		[Register ("MODE_SGBM")]
		public const int ModeSgbm = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/field[@name='MODE_SGBM_3WAY']"
		[Register ("MODE_SGBM_3WAY")]
		public const int ModeSgbm3way = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/calib3d/StereoSGBM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StereoSGBM); }
		}

		protected StereoSGBM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/constructor[@name='StereoSGBM' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe StereoSGBM (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StereoSGBM)) {
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

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMode);
			return cb_getMode;
		}

		static int n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mode;
		}
#pragma warning restore 0169

		static Delegate cb_setMode_I;
#pragma warning disable 0169
		static Delegate GetSetMode_IHandler ()
		{
			if (cb_setMode_I == null)
				cb_setMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMode_I);
			return cb_setMode_I;
		}

		static void n_SetMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMode;
		static IntPtr id_setMode_I;
		public virtual unsafe int Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()I", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMode", "(I)V", "GetSetMode_IHandler")]
			set {
				if (id_setMode_I == IntPtr.Zero)
					id_setMode_I = JNIEnv.GetMethodID (class_ref, "setMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getP1;
#pragma warning disable 0169
		static Delegate GetGetP1Handler ()
		{
			if (cb_getP1 == null)
				cb_getP1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetP1);
			return cb_getP1;
		}

		static int n_GetP1 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.P1;
		}
#pragma warning restore 0169

		static Delegate cb_setP1_I;
#pragma warning disable 0169
		static Delegate GetSetP1_IHandler ()
		{
			if (cb_setP1_I == null)
				cb_setP1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetP1_I);
			return cb_setP1_I;
		}

		static void n_SetP1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.P1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getP1;
		static IntPtr id_setP1_I;
		public virtual unsafe int P1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='getP1' and count(parameter)=0]"
			[Register ("getP1", "()I", "GetGetP1Handler")]
			get {
				if (id_getP1 == IntPtr.Zero)
					id_getP1 = JNIEnv.GetMethodID (class_ref, "getP1", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getP1);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getP1", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='setP1' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setP1", "(I)V", "GetSetP1_IHandler")]
			set {
				if (id_setP1_I == IntPtr.Zero)
					id_setP1_I = JNIEnv.GetMethodID (class_ref, "setP1", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setP1_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setP1", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getP2;
#pragma warning disable 0169
		static Delegate GetGetP2Handler ()
		{
			if (cb_getP2 == null)
				cb_getP2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetP2);
			return cb_getP2;
		}

		static int n_GetP2 (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.P2;
		}
#pragma warning restore 0169

		static Delegate cb_setP2_I;
#pragma warning disable 0169
		static Delegate GetSetP2_IHandler ()
		{
			if (cb_setP2_I == null)
				cb_setP2_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetP2_I);
			return cb_setP2_I;
		}

		static void n_SetP2_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.P2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getP2;
		static IntPtr id_setP2_I;
		public virtual unsafe int P2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='getP2' and count(parameter)=0]"
			[Register ("getP2", "()I", "GetGetP2Handler")]
			get {
				if (id_getP2 == IntPtr.Zero)
					id_getP2 = JNIEnv.GetMethodID (class_ref, "getP2", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getP2);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getP2", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='setP2' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setP2", "(I)V", "GetSetP2_IHandler")]
			set {
				if (id_setP2_I == IntPtr.Zero)
					id_setP2_I = JNIEnv.GetMethodID (class_ref, "setP2", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setP2_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setP2", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreFilterCap;
#pragma warning disable 0169
		static Delegate GetGetPreFilterCapHandler ()
		{
			if (cb_getPreFilterCap == null)
				cb_getPreFilterCap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreFilterCap);
			return cb_getPreFilterCap;
		}

		static int n_GetPreFilterCap (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreFilterCap;
		}
#pragma warning restore 0169

		static Delegate cb_setPreFilterCap_I;
#pragma warning disable 0169
		static Delegate GetSetPreFilterCap_IHandler ()
		{
			if (cb_setPreFilterCap_I == null)
				cb_setPreFilterCap_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreFilterCap_I);
			return cb_setPreFilterCap_I;
		}

		static void n_SetPreFilterCap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreFilterCap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreFilterCap;
		static IntPtr id_setPreFilterCap_I;
		public virtual unsafe int PreFilterCap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='getPreFilterCap' and count(parameter)=0]"
			[Register ("getPreFilterCap", "()I", "GetGetPreFilterCapHandler")]
			get {
				if (id_getPreFilterCap == IntPtr.Zero)
					id_getPreFilterCap = JNIEnv.GetMethodID (class_ref, "getPreFilterCap", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreFilterCap);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreFilterCap", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='setPreFilterCap' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreFilterCap", "(I)V", "GetSetPreFilterCap_IHandler")]
			set {
				if (id_setPreFilterCap_I == IntPtr.Zero)
					id_setPreFilterCap_I = JNIEnv.GetMethodID (class_ref, "setPreFilterCap", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreFilterCap_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreFilterCap", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUniquenessRatio;
#pragma warning disable 0169
		static Delegate GetGetUniquenessRatioHandler ()
		{
			if (cb_getUniquenessRatio == null)
				cb_getUniquenessRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUniquenessRatio);
			return cb_getUniquenessRatio;
		}

		static int n_GetUniquenessRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UniquenessRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setUniquenessRatio_I;
#pragma warning disable 0169
		static Delegate GetSetUniquenessRatio_IHandler ()
		{
			if (cb_setUniquenessRatio_I == null)
				cb_setUniquenessRatio_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUniquenessRatio_I);
			return cb_setUniquenessRatio_I;
		}

		static void n_SetUniquenessRatio_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.Calib3d.StereoSGBM __this = global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UniquenessRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUniquenessRatio;
		static IntPtr id_setUniquenessRatio_I;
		public virtual unsafe int UniquenessRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='getUniquenessRatio' and count(parameter)=0]"
			[Register ("getUniquenessRatio", "()I", "GetGetUniquenessRatioHandler")]
			get {
				if (id_getUniquenessRatio == IntPtr.Zero)
					id_getUniquenessRatio = JNIEnv.GetMethodID (class_ref, "getUniquenessRatio", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUniquenessRatio);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniquenessRatio", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='setUniquenessRatio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUniquenessRatio", "(I)V", "GetSetUniquenessRatio_IHandler")]
			set {
				if (id_setUniquenessRatio_I == IntPtr.Zero)
					id_setUniquenessRatio_I = JNIEnv.GetMethodID (class_ref, "setUniquenessRatio", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUniquenessRatio_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUniquenessRatio", "(I)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_create_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='create' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("create", "(III)Lorg/opencv/calib3d/StereoSGBM;", "")]
		public static unsafe global::OpenCV.Calib3d.StereoSGBM Create (int p0, int p1, int p2)
		{
			if (id_create_III == IntPtr.Zero)
				id_create_III = JNIEnv.GetStaticMethodID (class_ref, "create", "(III)Lorg/opencv/calib3d/StereoSGBM;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_III, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_IIIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.calib3d']/class[@name='StereoSGBM']/method[@name='create' and count(parameter)=11 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int']]"
		[Register ("create", "(IIIIIIIIIII)Lorg/opencv/calib3d/StereoSGBM;", "")]
		public static unsafe global::OpenCV.Calib3d.StereoSGBM Create (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10)
		{
			if (id_create_IIIIIIIIIII == IntPtr.Zero)
				id_create_IIIIIIIIIII = JNIEnv.GetStaticMethodID (class_ref, "create", "(IIIIIIIIIII)Lorg/opencv/calib3d/StereoSGBM;");
			try {
				JValue* __args = stackalloc JValue [11];
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
				return global::Java.Lang.Object.GetObject<global::OpenCV.Calib3d.StereoSGBM> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_IIIIIIIIIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
