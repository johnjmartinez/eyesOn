package md52774b0d2abb5b5930fdc2b4e23b41882;


public class CameraCaptureSessionCallback
	extends android.hardware.camera2.CameraCaptureSession.StateCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConfigureFailed:(Landroid/hardware/camera2/CameraCaptureSession;)V:GetOnConfigureFailed_Landroid_hardware_camera2_CameraCaptureSession_Handler\n" +
			"n_onConfigured:(Landroid/hardware/camera2/CameraCaptureSession;)V:GetOnConfigured_Landroid_hardware_camera2_CameraCaptureSession_Handler\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCaptureSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CameraCaptureSessionCallback.class, __md_methods);
	}


	public CameraCaptureSessionCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraCaptureSessionCallback.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCaptureSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CameraCaptureSessionCallback (md5ebf6dc060e0d46316a5781f4cd5b42de.TakePhotoActivity3 p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraCaptureSessionCallback.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCaptureSessionCallback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "EyesOn.UI.Droid.TakePhoto.TakePhotoActivity3, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onConfigureFailed (android.hardware.camera2.CameraCaptureSession p0)
	{
		n_onConfigureFailed (p0);
	}

	private native void n_onConfigureFailed (android.hardware.camera2.CameraCaptureSession p0);


	public void onConfigured (android.hardware.camera2.CameraCaptureSession p0)
	{
		n_onConfigured (p0);
	}

	private native void n_onConfigured (android.hardware.camera2.CameraCaptureSession p0);

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
