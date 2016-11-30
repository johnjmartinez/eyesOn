package md5af74336fecbad1b0249a0ca3cee9854e;


public class ColorBlobDetectionActivity2
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		org.opencv.android.CameraBridgeViewBase.CvCameraViewListener2
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onCameraViewStarted:(II)V:GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV\n" +
			"n_onCameraViewStopped:()V:GetOnCameraViewStoppedHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV\n" +
			"n_onCameraFrame:(Lorg/opencv/android/CameraBridgeViewBase$CvCameraViewFrame;)Lorg/opencv/core/Mat;:GetOnCameraFrame_Lorg_opencv_android_CameraBridgeViewBase_CvCameraViewFrame_Handler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListener2Invoker, OpenCV\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.ColorBlobDetection.ColorBlobDetectionActivity2, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ColorBlobDetectionActivity2.class, __md_methods);
	}


	public ColorBlobDetectionActivity2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ColorBlobDetectionActivity2.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.ColorBlobDetection.ColorBlobDetectionActivity2, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onCameraViewStarted (int p0, int p1)
	{
		n_onCameraViewStarted (p0, p1);
	}

	private native void n_onCameraViewStarted (int p0, int p1);


	public void onCameraViewStopped ()
	{
		n_onCameraViewStopped ();
	}

	private native void n_onCameraViewStopped ();


	public org.opencv.core.Mat onCameraFrame (org.opencv.android.CameraBridgeViewBase.CvCameraViewFrame p0)
	{
		return n_onCameraFrame (p0);
	}

	private native org.opencv.core.Mat n_onCameraFrame (org.opencv.android.CameraBridgeViewBase.CvCameraViewFrame p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
