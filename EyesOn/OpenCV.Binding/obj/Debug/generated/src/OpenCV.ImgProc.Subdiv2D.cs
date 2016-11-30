using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.ImgProc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']"
	[global::Android.Runtime.Register ("org/opencv/imgproc/Subdiv2D", DoNotGenerateAcw=true)]
	public partial class Subdiv2D : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='NEXT_AROUND_DST']"
		[Register ("NEXT_AROUND_DST")]
		public const int NextAroundDst = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='NEXT_AROUND_LEFT']"
		[Register ("NEXT_AROUND_LEFT")]
		public const int NextAroundLeft = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='NEXT_AROUND_ORG']"
		[Register ("NEXT_AROUND_ORG")]
		public const int NextAroundOrg = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='NEXT_AROUND_RIGHT']"
		[Register ("NEXT_AROUND_RIGHT")]
		public const int NextAroundRight = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PREV_AROUND_DST']"
		[Register ("PREV_AROUND_DST")]
		public const int PrevAroundDst = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PREV_AROUND_LEFT']"
		[Register ("PREV_AROUND_LEFT")]
		public const int PrevAroundLeft = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PREV_AROUND_ORG']"
		[Register ("PREV_AROUND_ORG")]
		public const int PrevAroundOrg = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PREV_AROUND_RIGHT']"
		[Register ("PREV_AROUND_RIGHT")]
		public const int PrevAroundRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PTLOC_ERROR']"
		[Register ("PTLOC_ERROR")]
		public const int PtlocError = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PTLOC_INSIDE']"
		[Register ("PTLOC_INSIDE")]
		public const int PtlocInside = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PTLOC_ON_EDGE']"
		[Register ("PTLOC_ON_EDGE")]
		public const int PtlocOnEdge = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PTLOC_OUTSIDE_RECT']"
		[Register ("PTLOC_OUTSIDE_RECT")]
		public const int PtlocOutsideRect = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='PTLOC_VERTEX']"
		[Register ("PTLOC_VERTEX")]
		public const int PtlocVertex = (int) 1;

		static IntPtr nativeObj_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/field[@name='nativeObj']"
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
				return JNIEnv.FindClass ("org/opencv/imgproc/Subdiv2D", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Subdiv2D); }
		}

		protected Subdiv2D (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/constructor[@name='Subdiv2D' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Subdiv2D ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Subdiv2D)) {
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

		static IntPtr id_ctor_Lorg_opencv_core_Rect_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/constructor[@name='Subdiv2D' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
		[Register (".ctor", "(Lorg/opencv/core/Rect;)V", "")]
		public unsafe Subdiv2D (global::OpenCV.Core.Rect p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Subdiv2D)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/opencv/core/Rect;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/opencv/core/Rect;)V", __args);
					return;
				}

				if (id_ctor_Lorg_opencv_core_Rect_ == IntPtr.Zero)
					id_ctor_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/opencv/core/Rect;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_opencv_core_Rect_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_opencv_core_Rect_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/constructor[@name='Subdiv2D' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Subdiv2D (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Subdiv2D)) {
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

		static Delegate cb_edgeDst_I;
#pragma warning disable 0169
		static Delegate GetEdgeDst_IHandler ()
		{
			if (cb_edgeDst_I == null)
				cb_edgeDst_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_EdgeDst_I);
			return cb_edgeDst_I;
		}

		static int n_EdgeDst_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EdgeDst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_edgeDst_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='edgeDst' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("edgeDst", "(I)I", "GetEdgeDst_IHandler")]
		public virtual unsafe int EdgeDst (int p0)
		{
			if (id_edgeDst_I == IntPtr.Zero)
				id_edgeDst_I = JNIEnv.GetMethodID (class_ref, "edgeDst", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_edgeDst_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "edgeDst", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_edgeDst_ILorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetEdgeDst_ILorg_opencv_core_Point_Handler ()
		{
			if (cb_edgeDst_ILorg_opencv_core_Point_ == null)
				cb_edgeDst_ILorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_EdgeDst_ILorg_opencv_core_Point_);
			return cb_edgeDst_ILorg_opencv_core_Point_;
		}

		static int n_EdgeDst_ILorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EdgeDst (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_edgeDst_ILorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='edgeDst' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Point']]"
		[Register ("edgeDst", "(ILorg/opencv/core/Point;)I", "GetEdgeDst_ILorg_opencv_core_Point_Handler")]
		public virtual unsafe int EdgeDst (int p0, global::OpenCV.Core.Point p1)
		{
			if (id_edgeDst_ILorg_opencv_core_Point_ == IntPtr.Zero)
				id_edgeDst_ILorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "edgeDst", "(ILorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_edgeDst_ILorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "edgeDst", "(ILorg/opencv/core/Point;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_edgeOrg_I;
#pragma warning disable 0169
		static Delegate GetEdgeOrg_IHandler ()
		{
			if (cb_edgeOrg_I == null)
				cb_edgeOrg_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_EdgeOrg_I);
			return cb_edgeOrg_I;
		}

		static int n_EdgeOrg_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EdgeOrg (p0);
		}
#pragma warning restore 0169

		static IntPtr id_edgeOrg_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='edgeOrg' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("edgeOrg", "(I)I", "GetEdgeOrg_IHandler")]
		public virtual unsafe int EdgeOrg (int p0)
		{
			if (id_edgeOrg_I == IntPtr.Zero)
				id_edgeOrg_I = JNIEnv.GetMethodID (class_ref, "edgeOrg", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_edgeOrg_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "edgeOrg", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_edgeOrg_ILorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetEdgeOrg_ILorg_opencv_core_Point_Handler ()
		{
			if (cb_edgeOrg_ILorg_opencv_core_Point_ == null)
				cb_edgeOrg_ILorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_EdgeOrg_ILorg_opencv_core_Point_);
			return cb_edgeOrg_ILorg_opencv_core_Point_;
		}

		static int n_EdgeOrg_ILorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EdgeOrg (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_edgeOrg_ILorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='edgeOrg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.opencv.core.Point']]"
		[Register ("edgeOrg", "(ILorg/opencv/core/Point;)I", "GetEdgeOrg_ILorg_opencv_core_Point_Handler")]
		public virtual unsafe int EdgeOrg (int p0, global::OpenCV.Core.Point p1)
		{
			if (id_edgeOrg_ILorg_opencv_core_Point_ == IntPtr.Zero)
				id_edgeOrg_ILorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "edgeOrg", "(ILorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_edgeOrg_ILorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "edgeOrg", "(ILorg/opencv/core/Point;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_findNearest_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetFindNearest_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_findNearest_Lorg_opencv_core_Point_ == null)
				cb_findNearest_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FindNearest_Lorg_opencv_core_Point_);
			return cb_findNearest_Lorg_opencv_core_Point_;
		}

		static int n_FindNearest_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindNearest (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findNearest_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='findNearest' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register ("findNearest", "(Lorg/opencv/core/Point;)I", "GetFindNearest_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe int FindNearest (global::OpenCV.Core.Point p0)
		{
			if (id_findNearest_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_findNearest_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "findNearest", "(Lorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findNearest_Lorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findNearest", "(Lorg/opencv/core/Point;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetFindNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ == null)
				cb_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_FindNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_);
			return cb_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_;
		}

		static int n_FindNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p1 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FindNearest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='findNearest' and count(parameter)=2 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='org.opencv.core.Point']]"
		[Register ("findNearest", "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)I", "GetFindNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe int FindNearest (global::OpenCV.Core.Point p0, global::OpenCV.Core.Point p1)
		{
			if (id_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "findNearest", "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findNearest_Lorg_opencv_core_Point_Lorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findNearest", "(Lorg/opencv/core/Point;Lorg/opencv/core/Point;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getEdge_II;
#pragma warning disable 0169
		static Delegate GetGetEdge_IIHandler ()
		{
			if (cb_getEdge_II == null)
				cb_getEdge_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetEdge_II);
			return cb_getEdge_II;
		}

		static int n_GetEdge_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetEdge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getEdge_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getEdge' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getEdge", "(II)I", "GetGetEdge_IIHandler")]
		public virtual unsafe int GetEdge (int p0, int p1)
		{
			if (id_getEdge_II == IntPtr.Zero)
				id_getEdge_II = JNIEnv.GetMethodID (class_ref, "getEdge", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEdge_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEdge", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getEdgeList_Lorg_opencv_core_MatOfFloat4_;
#pragma warning disable 0169
		static Delegate GetGetEdgeList_Lorg_opencv_core_MatOfFloat4_Handler ()
		{
			if (cb_getEdgeList_Lorg_opencv_core_MatOfFloat4_ == null)
				cb_getEdgeList_Lorg_opencv_core_MatOfFloat4_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetEdgeList_Lorg_opencv_core_MatOfFloat4_);
			return cb_getEdgeList_Lorg_opencv_core_MatOfFloat4_;
		}

		static void n_GetEdgeList_Lorg_opencv_core_MatOfFloat4_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfFloat4 p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat4> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetEdgeList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getEdgeList_Lorg_opencv_core_MatOfFloat4_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getEdgeList' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfFloat4']]"
		[Register ("getEdgeList", "(Lorg/opencv/core/MatOfFloat4;)V", "GetGetEdgeList_Lorg_opencv_core_MatOfFloat4_Handler")]
		public virtual unsafe void GetEdgeList (global::OpenCV.Core.MatOfFloat4 p0)
		{
			if (id_getEdgeList_Lorg_opencv_core_MatOfFloat4_ == IntPtr.Zero)
				id_getEdgeList_Lorg_opencv_core_MatOfFloat4_ = JNIEnv.GetMethodID (class_ref, "getEdgeList", "(Lorg/opencv/core/MatOfFloat4;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getEdgeList_Lorg_opencv_core_MatOfFloat4_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEdgeList", "(Lorg/opencv/core/MatOfFloat4;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTriangleList_Lorg_opencv_core_MatOfFloat6_;
#pragma warning disable 0169
		static Delegate GetGetTriangleList_Lorg_opencv_core_MatOfFloat6_Handler ()
		{
			if (cb_getTriangleList_Lorg_opencv_core_MatOfFloat6_ == null)
				cb_getTriangleList_Lorg_opencv_core_MatOfFloat6_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetTriangleList_Lorg_opencv_core_MatOfFloat6_);
			return cb_getTriangleList_Lorg_opencv_core_MatOfFloat6_;
		}

		static void n_GetTriangleList_Lorg_opencv_core_MatOfFloat6_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfFloat6 p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfFloat6> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetTriangleList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getTriangleList_Lorg_opencv_core_MatOfFloat6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getTriangleList' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfFloat6']]"
		[Register ("getTriangleList", "(Lorg/opencv/core/MatOfFloat6;)V", "GetGetTriangleList_Lorg_opencv_core_MatOfFloat6_Handler")]
		public virtual unsafe void GetTriangleList (global::OpenCV.Core.MatOfFloat6 p0)
		{
			if (id_getTriangleList_Lorg_opencv_core_MatOfFloat6_ == IntPtr.Zero)
				id_getTriangleList_Lorg_opencv_core_MatOfFloat6_ = JNIEnv.GetMethodID (class_ref, "getTriangleList", "(Lorg/opencv/core/MatOfFloat6;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTriangleList_Lorg_opencv_core_MatOfFloat6_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTriangleList", "(Lorg/opencv/core/MatOfFloat6;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getVertex_I;
#pragma warning disable 0169
		static Delegate GetGetVertex_IHandler ()
		{
			if (cb_getVertex_I == null)
				cb_getVertex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetVertex_I);
			return cb_getVertex_I;
		}

		static IntPtr n_GetVertex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVertex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getVertex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getVertex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVertex", "(I)Lorg/opencv/core/Point;", "GetGetVertex_IHandler")]
		public virtual unsafe global::OpenCV.Core.Point GetVertex (int p0)
		{
			if (id_getVertex_I == IntPtr.Zero)
				id_getVertex_I = JNIEnv.GetMethodID (class_ref, "getVertex", "(I)Lorg/opencv/core/Point;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVertex_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVertex", "(I)Lorg/opencv/core/Point;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getVertex_IarrayI;
#pragma warning disable 0169
		static Delegate GetGetVertex_IarrayIHandler ()
		{
			if (cb_getVertex_IarrayI == null)
				cb_getVertex_IarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetVertex_IarrayI);
			return cb_getVertex_IarrayI;
		}

		static IntPtr n_GetVertex_IarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetVertex (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVertex_IarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getVertex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("getVertex", "(I[I)Lorg/opencv/core/Point;", "GetGetVertex_IarrayIHandler")]
		public virtual unsafe global::OpenCV.Core.Point GetVertex (int p0, int[] p1)
		{
			if (id_getVertex_IarrayI == IntPtr.Zero)
				id_getVertex_IarrayI = JNIEnv.GetMethodID (class_ref, "getVertex", "(I[I)Lorg/opencv/core/Point;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::OpenCV.Core.Point __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVertex_IarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVertex", "(I[I)Lorg/opencv/core/Point;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_;
#pragma warning disable 0169
		static Delegate GetGetVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_Handler ()
		{
			if (cb_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_ == null)
				cb_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_);
			return cb_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_;
		}

		static void n_GetVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfInt p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfInt> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint2f p2 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint2f> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetVoronoiFacetList (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='getVoronoiFacetList' and count(parameter)=3 and parameter[1][@type='org.opencv.core.MatOfInt'] and parameter[2][@type='java.util.List&lt;org.opencv.core.MatOfPoint2f&gt;'] and parameter[3][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("getVoronoiFacetList", "(Lorg/opencv/core/MatOfInt;Ljava/util/List;Lorg/opencv/core/MatOfPoint2f;)V", "GetGetVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_Handler")]
		public virtual unsafe void GetVoronoiFacetList (global::OpenCV.Core.MatOfInt p0, global::System.Collections.Generic.IList<global::OpenCV.Core.MatOfPoint2f> p1, global::OpenCV.Core.MatOfPoint2f p2)
		{
			if (id_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetMethodID (class_ref, "getVoronoiFacetList", "(Lorg/opencv/core/MatOfInt;Ljava/util/List;Lorg/opencv/core/MatOfPoint2f;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::OpenCV.Core.MatOfPoint2f>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getVoronoiFacetList_Lorg_opencv_core_MatOfInt_Ljava_util_List_Lorg_opencv_core_MatOfPoint2f_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVoronoiFacetList", "(Lorg/opencv/core/MatOfInt;Ljava/util/List;Lorg/opencv/core/MatOfPoint2f;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_initDelaunay_Lorg_opencv_core_Rect_;
#pragma warning disable 0169
		static Delegate GetInitDelaunay_Lorg_opencv_core_Rect_Handler ()
		{
			if (cb_initDelaunay_Lorg_opencv_core_Rect_ == null)
				cb_initDelaunay_Lorg_opencv_core_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitDelaunay_Lorg_opencv_core_Rect_);
			return cb_initDelaunay_Lorg_opencv_core_Rect_;
		}

		static void n_InitDelaunay_Lorg_opencv_core_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Rect p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitDelaunay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initDelaunay_Lorg_opencv_core_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='initDelaunay' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Rect']]"
		[Register ("initDelaunay", "(Lorg/opencv/core/Rect;)V", "GetInitDelaunay_Lorg_opencv_core_Rect_Handler")]
		public virtual unsafe void InitDelaunay (global::OpenCV.Core.Rect p0)
		{
			if (id_initDelaunay_Lorg_opencv_core_Rect_ == IntPtr.Zero)
				id_initDelaunay_Lorg_opencv_core_Rect_ = JNIEnv.GetMethodID (class_ref, "initDelaunay", "(Lorg/opencv/core/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initDelaunay_Lorg_opencv_core_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initDelaunay", "(Lorg/opencv/core/Rect;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_insert_Lorg_opencv_core_MatOfPoint2f_;
#pragma warning disable 0169
		static Delegate GetInsert_Lorg_opencv_core_MatOfPoint2f_Handler ()
		{
			if (cb_insert_Lorg_opencv_core_MatOfPoint2f_ == null)
				cb_insert_Lorg_opencv_core_MatOfPoint2f_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_Lorg_opencv_core_MatOfPoint2f_);
			return cb_insert_Lorg_opencv_core_MatOfPoint2f_;
		}

		static void n_Insert_Lorg_opencv_core_MatOfPoint2f_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.MatOfPoint2f p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.MatOfPoint2f> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Lorg_opencv_core_MatOfPoint2f_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='org.opencv.core.MatOfPoint2f']]"
		[Register ("insert", "(Lorg/opencv/core/MatOfPoint2f;)V", "GetInsert_Lorg_opencv_core_MatOfPoint2f_Handler")]
		public virtual unsafe void Insert (global::OpenCV.Core.MatOfPoint2f p0)
		{
			if (id_insert_Lorg_opencv_core_MatOfPoint2f_ == IntPtr.Zero)
				id_insert_Lorg_opencv_core_MatOfPoint2f_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lorg/opencv/core/MatOfPoint2f;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lorg_opencv_core_MatOfPoint2f_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Lorg/opencv/core/MatOfPoint2f;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_insert_Lorg_opencv_core_Point_;
#pragma warning disable 0169
		static Delegate GetInsert_Lorg_opencv_core_Point_Handler ()
		{
			if (cb_insert_Lorg_opencv_core_Point_ == null)
				cb_insert_Lorg_opencv_core_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Insert_Lorg_opencv_core_Point_);
			return cb_insert_Lorg_opencv_core_Point_;
		}

		static int n_Insert_Lorg_opencv_core_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Insert (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Lorg_opencv_core_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='org.opencv.core.Point']]"
		[Register ("insert", "(Lorg/opencv/core/Point;)I", "GetInsert_Lorg_opencv_core_Point_Handler")]
		public virtual unsafe int Insert (global::OpenCV.Core.Point p0)
		{
			if (id_insert_Lorg_opencv_core_Point_ == IntPtr.Zero)
				id_insert_Lorg_opencv_core_Point_ = JNIEnv.GetMethodID (class_ref, "insert", "(Lorg/opencv/core/Point;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_insert_Lorg_opencv_core_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Lorg/opencv/core/Point;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_locate_Lorg_opencv_core_Point_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetLocate_Lorg_opencv_core_Point_arrayIarrayIHandler ()
		{
			if (cb_locate_Lorg_opencv_core_Point_arrayIarrayI == null)
				cb_locate_Lorg_opencv_core_Point_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Locate_Lorg_opencv_core_Point_arrayIarrayI);
			return cb_locate_Lorg_opencv_core_Point_arrayIarrayI;
		}

		static int n_Locate_Lorg_opencv_core_Point_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::OpenCV.Core.Point p0 = global::Java.Lang.Object.GetObject<global::OpenCV.Core.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.Locate (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_locate_Lorg_opencv_core_Point_arrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='locate' and count(parameter)=3 and parameter[1][@type='org.opencv.core.Point'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("locate", "(Lorg/opencv/core/Point;[I[I)I", "GetLocate_Lorg_opencv_core_Point_arrayIarrayIHandler")]
		public virtual unsafe int Locate (global::OpenCV.Core.Point p0, int[] p1, int[] p2)
		{
			if (id_locate_Lorg_opencv_core_Point_arrayIarrayI == IntPtr.Zero)
				id_locate_Lorg_opencv_core_Point_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "locate", "(Lorg/opencv/core/Point;[I[I)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_locate_Lorg_opencv_core_Point_arrayIarrayI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "locate", "(Lorg/opencv/core/Point;[I[I)I"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_nextEdge_I;
#pragma warning disable 0169
		static Delegate GetNextEdge_IHandler ()
		{
			if (cb_nextEdge_I == null)
				cb_nextEdge_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_NextEdge_I);
			return cb_nextEdge_I;
		}

		static int n_NextEdge_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_nextEdge_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='nextEdge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("nextEdge", "(I)I", "GetNextEdge_IHandler")]
		public virtual unsafe int NextEdge (int p0)
		{
			if (id_nextEdge_I == IntPtr.Zero)
				id_nextEdge_I = JNIEnv.GetMethodID (class_ref, "nextEdge", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_nextEdge_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextEdge", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_rotateEdge_II;
#pragma warning disable 0169
		static Delegate GetRotateEdge_IIHandler ()
		{
			if (cb_rotateEdge_II == null)
				cb_rotateEdge_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_RotateEdge_II);
			return cb_rotateEdge_II;
		}

		static int n_RotateEdge_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateEdge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_rotateEdge_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='rotateEdge' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rotateEdge", "(II)I", "GetRotateEdge_IIHandler")]
		public virtual unsafe int RotateEdge (int p0, int p1)
		{
			if (id_rotateEdge_II == IntPtr.Zero)
				id_rotateEdge_II = JNIEnv.GetMethodID (class_ref, "rotateEdge", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rotateEdge_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateEdge", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_symEdge_I;
#pragma warning disable 0169
		static Delegate GetSymEdge_IHandler ()
		{
			if (cb_symEdge_I == null)
				cb_symEdge_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SymEdge_I);
			return cb_symEdge_I;
		}

		static int n_SymEdge_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::OpenCV.ImgProc.Subdiv2D __this = global::Java.Lang.Object.GetObject<global::OpenCV.ImgProc.Subdiv2D> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SymEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_symEdge_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.imgproc']/class[@name='Subdiv2D']/method[@name='symEdge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("symEdge", "(I)I", "GetSymEdge_IHandler")]
		public virtual unsafe int SymEdge (int p0)
		{
			if (id_symEdge_I == IntPtr.Zero)
				id_symEdge_I = JNIEnv.GetMethodID (class_ref, "symEdge", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_symEdge_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "symEdge", "(I)I"), __args);
			} finally {
			}
		}

	}
}
