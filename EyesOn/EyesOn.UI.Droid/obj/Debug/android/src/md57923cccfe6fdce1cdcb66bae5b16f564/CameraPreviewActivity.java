package md57923cccfe6fdce1cdcb66bae5b16f564;


public class CameraPreviewActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		org.opencv.android.LoaderCallbackInterface,
		org.opencv.android.CameraBridgeViewBase.CvCameraViewListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_onManagerConnected:(I)V:GetOnManagerConnected_IHandler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV\n" +
			"n_onPackageInstall:(ILorg/opencv/android/InstallCallbackInterface;)V:GetOnPackageInstall_ILorg_opencv_android_InstallCallbackInterface_Handler:OpenCV.Android.ILoaderCallbackInterfaceInvoker, OpenCV\n" +
			"n_onCameraFrame:(Lorg/opencv/core/Mat;)Lorg/opencv/core/Mat;:GetOnCameraFrame_Lorg_opencv_core_Mat_Handler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"n_onCameraViewStarted:(II)V:GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"n_onCameraViewStopped:()V:GetOnCameraViewStoppedHandler:OpenCV.Android.CameraBridgeViewBase/ICvCameraViewListenerInvoker, OpenCV\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.CameraPreview.CameraPreviewActivity, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CameraPreviewActivity.class, __md_methods);
	}


	public CameraPreviewActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraPreviewActivity.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.CameraPreview.CameraPreviewActivity, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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


	public void onManagerConnected (int p0)
	{
		n_onManagerConnected (p0);
	}

	private native void n_onManagerConnected (int p0);


	public void onPackageInstall (int p0, org.opencv.android.InstallCallbackInterface p1)
	{
		n_onPackageInstall (p0, p1);
	}

	private native void n_onPackageInstall (int p0, org.opencv.android.InstallCallbackInterface p1);


	public org.opencv.core.Mat onCameraFrame (org.opencv.core.Mat p0)
	{
		return n_onCameraFrame (p0);
	}

	private native org.opencv.core.Mat n_onCameraFrame (org.opencv.core.Mat p0);


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
