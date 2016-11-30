package md52774b0d2abb5b5930fdc2b4e23b41882;


public class CameraCapturePreviewSessionCallback
	extends android.hardware.camera2.CameraCaptureSession.CaptureCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCaptureCompleted:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/TotalCaptureResult;)V:GetOnCaptureCompleted_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_TotalCaptureResult_Handler\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCapturePreviewSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CameraCapturePreviewSessionCallback.class, __md_methods);
	}


	public CameraCapturePreviewSessionCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraCapturePreviewSessionCallback.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCapturePreviewSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CameraCapturePreviewSessionCallback (md5ebf6dc060e0d46316a5781f4cd5b42de.TakePhotoActivity3 p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraCapturePreviewSessionCallback.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCapturePreviewSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "EyesOn.UI.Droid.TakePhoto.TakePhotoActivity3, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2)
	{
		n_onCaptureCompleted (p0, p1, p2);
	}

	private native void n_onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2);

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
