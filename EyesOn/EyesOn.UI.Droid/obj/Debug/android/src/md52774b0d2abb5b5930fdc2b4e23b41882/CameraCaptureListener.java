package md52774b0d2abb5b5930fdc2b4e23b41882;


public class CameraCaptureListener
	extends android.hardware.camera2.CameraCaptureSession.CaptureCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCaptureCompleted:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/TotalCaptureResult;)V:GetOnCaptureCompleted_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_TotalCaptureResult_Handler\n" +
			"n_onCaptureProgressed:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CaptureResult;)V:GetOnCaptureProgressed_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_CaptureResult_Handler\n" +
			"n_onCaptureStarted:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;JJ)V:GetOnCaptureStarted_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_JJHandler\n" +
			"n_onCaptureSequenceCompleted:(Landroid/hardware/camera2/CameraCaptureSession;IJ)V:GetOnCaptureSequenceCompleted_Landroid_hardware_camera2_CameraCaptureSession_IJHandler\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCaptureListener, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CameraCaptureListener.class, __md_methods);
	}


	public CameraCaptureListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraCaptureListener.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.CameraCaptureListener, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2)
	{
		n_onCaptureCompleted (p0, p1, p2);
	}

	private native void n_onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2);


	public void onCaptureProgressed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureResult p2)
	{
		n_onCaptureProgressed (p0, p1, p2);
	}

	private native void n_onCaptureProgressed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureResult p2);


	public void onCaptureStarted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, long p2, long p3)
	{
		n_onCaptureStarted (p0, p1, p2, p3);
	}

	private native void n_onCaptureStarted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, long p2, long p3);


	public void onCaptureSequenceCompleted (android.hardware.camera2.CameraCaptureSession p0, int p1, long p2)
	{
		n_onCaptureSequenceCompleted (p0, p1, p2);
	}

	private native void n_onCaptureSequenceCompleted (android.hardware.camera2.CameraCaptureSession p0, int p1, long p2);

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
