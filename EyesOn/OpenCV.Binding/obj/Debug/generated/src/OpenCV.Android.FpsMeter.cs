using System;
using System.Collections.Generic;
using Android.Runtime;

namespace OpenCV.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']"
	[global::Android.Runtime.Register ("org/opencv/android/FpsMeter", DoNotGenerateAcw=true)]
	public partial class FpsMeter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/opencv/android/FpsMeter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FpsMeter); }
		}

		protected FpsMeter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']/constructor[@name='FpsMeter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FpsMeter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FpsMeter)) {
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

		static Delegate cb_draw_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_FF == null)
				cb_draw_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_Draw_Landroid_graphics_Canvas_FF);
			return cb_draw_Landroid_graphics_Canvas_FF;
		}

		static void n_Draw_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::OpenCV.Android.FpsMeter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.FpsMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("draw", "(Landroid/graphics/Canvas;FF)V", "GetDraw_Landroid_graphics_Canvas_FFHandler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas p0, float p1, float p2)
		{
			if (id_draw_Landroid_graphics_Canvas_FF == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_FF = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;FF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.FpsMeter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.FpsMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_measure;
#pragma warning disable 0169
		static Delegate GetMeasureHandler ()
		{
			if (cb_measure == null)
				cb_measure = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Measure);
			return cb_measure;
		}

		static void n_Measure (IntPtr jnienv, IntPtr native__this)
		{
			global::OpenCV.Android.FpsMeter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.FpsMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Measure ();
		}
#pragma warning restore 0169

		static IntPtr id_measure;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']/method[@name='measure' and count(parameter)=0]"
		[Register ("measure", "()V", "GetMeasureHandler")]
		public virtual unsafe void Measure ()
		{
			if (id_measure == IntPtr.Zero)
				id_measure = JNIEnv.GetMethodID (class_ref, "measure", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_measure);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "measure", "()V"));
			} finally {
			}
		}

		static Delegate cb_setResolution_II;
#pragma warning disable 0169
		static Delegate GetSetResolution_IIHandler ()
		{
			if (cb_setResolution_II == null)
				cb_setResolution_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetResolution_II);
			return cb_setResolution_II;
		}

		static void n_SetResolution_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::OpenCV.Android.FpsMeter __this = global::Java.Lang.Object.GetObject<global::OpenCV.Android.FpsMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetResolution (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setResolution_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.opencv.android']/class[@name='FpsMeter']/method[@name='setResolution' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setResolution", "(II)V", "GetSetResolution_IIHandler")]
		public virtual unsafe void SetResolution (int p0, int p1)
		{
			if (id_setResolution_II == IntPtr.Zero)
				id_setResolution_II = JNIEnv.GetMethodID (class_ref, "setResolution", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResolution_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResolution", "(II)V"), __args);
			} finally {
			}
		}

	}
}
