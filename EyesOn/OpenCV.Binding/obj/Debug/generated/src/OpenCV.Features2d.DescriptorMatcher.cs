using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Features2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']"
	[global::Android.Runtime.Register ("org/opencv/features2d/DescriptorMatcher", DoNotGenerateAcw=true)]
	public partial class DescriptorMatcher : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='BRUTEFORCE']"
		[Register ("BRUTEFORCE")]
		public const int Bruteforce = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='BRUTEFORCE_HAMMING']"
		[Register ("BRUTEFORCE_HAMMING")]
		public const int BruteforceHamming = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='BRUTEFORCE_HAMMINGLUT']"
		[Register ("BRUTEFORCE_HAMMINGLUT")]
		public const int BruteforceHamminglut = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='BRUTEFORCE_L1']"
		[Register ("BRUTEFORCE_L1")]
		public const int BruteforceL1 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='BRUTEFORCE_SL2']"
		[Register ("BRUTEFORCE_SL2")]
		public const int BruteforceSl2 = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='FLANNBASED']"
		[Register ("FLANNBASED")]
		public const int Flannbased = (int) 1;

		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/field[@name='nativeObj']"
		[Register ("nativeObj")]
		protected long NativeObj {
			get {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId);
			}
			set {
				if (nativeObj_jfieldId == IntPtr.Zero)
					nativeObj_jfieldId = JNIEnv.GetFieldID (class_ref, "nativeObj", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nativeObj_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/features2d/DescriptorMatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DescriptorMatcher); }
		}

		protected DescriptorMatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/constructor[@name='DescriptorMatcher' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe DescriptorMatcher (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DescriptorMatcher)) {
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

		static Delegate cb_isMaskSupported;
#pragma warning disable 0169
		static Delegate GetIsMaskSupportedHandler ()
		{
			if (cb_isMaskSupported == null)
				cb_isMaskSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMaskSupported);
			return cb_isMaskSupported;
		}

		static bool n_IsMaskSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaskSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isMaskSupported;
		public virtual unsafe bool IsMaskSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='isMaskSupported' and count(parameter)=0]"
			[Register ("isMaskSupported", "()Z", "GetIsMaskSupportedHandler")]
			get {
				if (id_isMaskSupported == IntPtr.Zero)
					id_isMaskSupported = JNIEnv.GetMethodID (class_ref, "isMaskSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMaskSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMaskSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrainDescriptors;
#pragma warning disable 0169
		static Delegate GetGetTrainDescriptorsHandler ()
		{
			if (cb_getTrainDescriptors == null)
				cb_getTrainDescriptors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrainDescriptors);
			return cb_getTrainDescriptors;
		}

		static IntPtr n_GetTrainDescriptors (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (__this.TrainDescriptors);
		}
#pragma warning restore 0169

		static IntPtr id_getTrainDescriptors;
		public virtual unsafe global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> TrainDescriptors {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='getTrainDescriptors' and count(parameter)=0]"
			[Register ("getTrainDescriptors", "()Ljava/util/List;", "GetGetTrainDescriptorsHandler")]
			get {
				if (id_getTrainDescriptors == IntPtr.Zero)
					id_getTrainDescriptors = JNIEnv.GetMethodID (class_ref, "getTrainDescriptors", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrainDescriptors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrainDescriptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_util_List_Handler ()
		{
			if (cb_add_Ljava_util_List_ == null)
				cb_add_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Ljava_util_List_);
			return cb_add_Ljava_util_List_;
		}

		static void n_Add_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("add", "(Ljava/util/List;)V", "GetAdd_Ljava_util_List_Handler")]
		public virtual unsafe void Add (global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p0)
		{
			if (id_add_Ljava_util_List_ == IntPtr.Zero)
				id_add_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/opencv/features2d/DescriptorMatcher;", "GetCloneHandler")]
		public virtual unsafe global::OpenCV.Features2d.DescriptorMatcher Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/opencv/features2d/DescriptorMatcher;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/opencv/features2d/DescriptorMatcher;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clone_Z;
#pragma warning disable 0169
		static Delegate GetClone_ZHandler ()
		{
			if (cb_clone_Z == null)
				cb_clone_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Clone_Z);
			return cb_clone_Z;
		}

		static IntPtr n_Clone_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone (p0));
		}
#pragma warning restore 0169

		static IntPtr id_clone_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='clone' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("clone", "(Z)Lorg/opencv/features2d/DescriptorMatcher;", "GetClone_ZHandler")]
		public virtual unsafe global::OpenCV.Features2d.DescriptorMatcher Clone (bool p0)
		{
			if (id_clone_Z == IntPtr.Zero)
				id_clone_Z = JNIEnv.GetMethodID (class_ref, "clone", "(Z)Lorg/opencv/features2d/DescriptorMatcher;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "(Z)Lorg/opencv/features2d/DescriptorMatcher;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/opencv/features2d/DescriptorMatcher;", "")]
		public static unsafe global::OpenCV.Features2d.DescriptorMatcher Create (int p0)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lorg/opencv/features2d/DescriptorMatcher;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		static IntPtr id_empty;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			if (id_empty == IntPtr.Zero)
				id_empty = JNIEnv.GetMethodID (class_ref, "empty", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_empty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "empty", "()Z"));
			} finally {
			}
		}

		static Delegate cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I;
#pragma warning disable 0169
		static Delegate GetKnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_IHandler ()
		{
			if (cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I == null)
				cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_KnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I);
			return cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I;
		}

		static void n_KnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.KnnMatch (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='knnMatch' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[3][@type='int']]"
		[Register ("knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;I)V", "GetKnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_IHandler")]
		public virtual unsafe void KnnMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p1, int p2)
		{
			if (id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I == IntPtr.Zero)
				id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I = JNIEnv.GetMethodID (class_ref, "knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;I)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetKnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_ZHandler ()
		{
			if (cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z == null)
				cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_KnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z);
			return cb_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z;
		}

		static void n_KnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, bool p4)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.KnnMatch (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='knnMatch' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[5][@type='boolean']]"
		[Register ("knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;ILjava/util/List;Z)V", "GetKnnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_ZHandler")]
		public virtual unsafe void KnnMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p1, int p2, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p3, bool p4)
		{
			if (id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z == IntPtr.Zero)
				id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z = JNIEnv.GetMethodID (class_ref, "knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;ILjava/util/List;Z)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_knnMatch_Lorg_opencv_core_Mat_Ljava_util_List_ILjava_util_List_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "knnMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;ILjava/util/List;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I;
#pragma warning disable 0169
		static Delegate GetKnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_IHandler ()
		{
			if (cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I == null)
				cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_KnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I);
			return cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I;
		}

		static void n_KnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.KnnMatch (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='knnMatch' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[4][@type='int']]"
		[Register ("knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;I)V", "GetKnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_IHandler")]
		public virtual unsafe void KnnMatch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p2, int p3)
		{
			if (id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I == IntPtr.Zero)
				id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I = JNIEnv.GetMethodID (class_ref, "knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;I)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z;
#pragma warning disable 0169
		static Delegate GetKnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_ZHandler ()
		{
			if (cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z == null)
				cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_KnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z);
			return cb_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z;
		}

		static void n_KnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, bool p5)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.KnnMatch (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='knnMatch' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[4][@type='int'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='boolean']]"
		[Register ("knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Mat;Z)V", "GetKnnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_ZHandler")]
		public virtual unsafe void KnnMatch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p2, int p3, global::OpenCV.Core.Mat p4, bool p5)
		{
			if (id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z = JNIEnv.GetMethodID (class_ref, "knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Mat;Z)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_knnMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_ILorg_opencv_core_Mat_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "knnMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;ILorg/opencv/core/Mat;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
#pragma warning disable 0169
		static Delegate GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Handler ()
		{
			if (cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ == null)
				cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_);
			return cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
		}

		static void n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDMatch p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDMatch> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='match' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfDMatch']]"
		[Register ("match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V", "GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Handler")]
		public virtual unsafe void Match (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfDMatch p2)
		{
			if (id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ == IntPtr.Zero)
				id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ = JNIEnv.GetMethodID (class_ref, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_;
#pragma warning disable 0169
		static Delegate GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Handler ()
		{
			if (cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ == null)
				cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_);
			return cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_;
		}

		static void n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDMatch p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDMatch> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p3 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='match' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='org.opencv.core.MatOfDMatch'] and parameter[4][@type='org.opencv.core.Mat']]"
		[Register ("match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;)V", "GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_Handler")]
		public virtual unsafe void Match (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::OpenCV.Core.MatOfDMatch p2, global::OpenCV.Core.Mat p3)
		{
			if (id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ == IntPtr.Zero)
				id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_ = JNIEnv.GetMethodID (class_ref, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Lorg_opencv_core_Mat_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Lorg/opencv/core/Mat;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
#pragma warning disable 0169
		static Delegate GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Handler ()
		{
			if (cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ == null)
				cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_);
			return cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
		}

		static void n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDMatch p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDMatch> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='match' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfDMatch']]"
		[Register ("match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V", "GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Handler")]
		public virtual unsafe void Match (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfDMatch p1)
		{
			if (id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ == IntPtr.Zero)
				id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_ = JNIEnv.GetMethodID (class_ref, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_Handler ()
		{
			if (cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_ == null)
				cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_);
			return cb_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_;
		}

		static void n_Match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfDMatch p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfDMatch> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='match' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.MatOfDMatch'] and parameter[3][@type='java.util.List&lt;org.opencv.core.Mat&gt;']]"
		[Register ("match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Ljava/util/List;)V", "GetMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_Handler")]
		public virtual unsafe void Match (global::OpenCV.Core.Mat p0, global::OpenCV.Core.MatOfDMatch p1, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p2)
		{
			if (id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_ == IntPtr.Zero)
				id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Ljava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lorg_opencv_core_Mat_Lorg_opencv_core_MatOfDMatch_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Lorg/opencv/core/Mat;Lorg/opencv/core/MatOfDMatch;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F;
#pragma warning disable 0169
		static Delegate GetRadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FHandler ()
		{
			if (cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F == null)
				cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float>) n_RadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F);
			return cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F;
		}

		static void n_RadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RadiusMatch (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='radiusMatch' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[3][@type='float']]"
		[Register ("radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;F)V", "GetRadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FHandler")]
		public virtual unsafe void RadiusMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p1, float p2)
		{
			if (id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F == IntPtr.Zero)
				id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F = JNIEnv.GetMethodID (class_ref, "radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;F)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetRadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_ZHandler ()
		{
			if (cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z == null)
				cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, IntPtr, bool>) n_RadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z);
			return cb_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z;
		}

		static void n_RadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, IntPtr native_p3, bool p4)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RadiusMatch (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='radiusMatch' and count(parameter)=5 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[3][@type='float'] and parameter[4][@type='java.util.List&lt;org.opencv.core.Mat&gt;'] and parameter[5][@type='boolean']]"
		[Register ("radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;FLjava/util/List;Z)V", "GetRadiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_ZHandler")]
		public virtual unsafe void RadiusMatch (global::OpenCV.Core.Mat p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p1, float p2, global::System.Collections.Generic.IList<global::OpenCV.Core.Mat> p3, bool p4)
		{
			if (id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z == IntPtr.Zero)
				id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z = JNIEnv.GetMethodID (class_ref, "radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;FLjava/util/List;Z)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::OpenCV.Core.Mat>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_radiusMatch_Lorg_opencv_core_Mat_Ljava_util_List_FLjava_util_List_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radiusMatch", "(Lorg/opencv/core/Mat;Ljava/util/List;FLjava/util/List;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F;
#pragma warning disable 0169
		static Delegate GetRadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FHandler ()
		{
			if (cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F == null)
				cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float>) n_RadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F);
			return cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F;
		}

		static void n_RadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RadiusMatch (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='radiusMatch' and count(parameter)=4 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[4][@type='float']]"
		[Register ("radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;F)V", "GetRadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FHandler")]
		public virtual unsafe void RadiusMatch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p2, float p3)
		{
			if (id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F == IntPtr.Zero)
				id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F = JNIEnv.GetMethodID (class_ref, "radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;F)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z;
#pragma warning disable 0169
		static Delegate GetRadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_ZHandler ()
		{
			if (cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z == null)
				cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, IntPtr, bool>) n_RadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z);
			return cb_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z;
		}

		static void n_RadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, IntPtr native_p4, bool p5)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Mat p4 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Mat> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.RadiusMatch (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='radiusMatch' and count(parameter)=6 and parameter[1][@type='org.opencv.core.Mat'] and parameter[2][@type='org.opencv.core.Mat'] and parameter[3][@type='java.util.List&lt;org.opencv.core.MatOfDMatch&gt;'] and parameter[4][@type='float'] and parameter[5][@type='org.opencv.core.Mat'] and parameter[6][@type='boolean']]"
		[Register ("radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;FLorg/opencv/core/Mat;Z)V", "GetRadiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_ZHandler")]
		public virtual unsafe void RadiusMatch (global::OpenCV.Core.Mat p0, global::OpenCV.Core.Mat p1, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfDMatch> p2, float p3, global::OpenCV.Core.Mat p4, bool p5)
		{
			if (id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z == IntPtr.Zero)
				id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z = JNIEnv.GetMethodID (class_ref, "radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;FLorg/opencv/core/Mat;Z)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfDMatch>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_radiusMatch_Lorg_opencv_core_Mat_Lorg_opencv_core_Mat_Ljava_util_List_FLorg_opencv_core_Mat_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "radiusMatch", "(Lorg/opencv/core/Mat;Lorg/opencv/core/Mat;Ljava/util/List;FLorg/opencv/core/Mat;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_read_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_lang_String_Handler ()
		{
			if (cb_read_Ljava_lang_String_ == null)
				cb_read_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_lang_String_);
			return cb_read_Ljava_lang_String_;
		}

		static void n_Read_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)V", "GetRead_Ljava_lang_String_Handler")]
		public virtual unsafe void Read (string p0)
		{
			if (id_read_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_train;
#pragma warning disable 0169
		static Delegate GetTrainHandler ()
		{
			if (cb_train == null)
				cb_train = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Train);
			return cb_train;
		}

		static void n_Train (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Train ();
		}
#pragma warning restore 0169

		static IntPtr id_train;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='train' and count(parameter)=0]"
		[Register ("train", "()V", "GetTrainHandler")]
		public virtual unsafe void Train ()
		{
			if (id_train == IntPtr.Zero)
				id_train = JNIEnv.GetMethodID (class_ref, "train", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_train);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "train", "()V"));
			} finally {
			}
		}

		static Delegate cb_write_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_lang_String_Handler ()
		{
			if (cb_write_Ljava_lang_String_ == null)
				cb_write_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_lang_String_);
			return cb_write_Ljava_lang_String_;
		}

		static void n_Write_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.Features2d.DescriptorMatcher __this = global::Java.Lang.Object.GetObject<global::OpenCV.Features2d.DescriptorMatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.features2d']/class[@name='DescriptorMatcher']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("write", "(Ljava/lang/String;)V", "GetWrite_Ljava_lang_String_Handler")]
		public virtual unsafe void Write (string p0)
		{
			if (id_write_Ljava_lang_String_ == IntPtr.Zero)
				id_write_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
