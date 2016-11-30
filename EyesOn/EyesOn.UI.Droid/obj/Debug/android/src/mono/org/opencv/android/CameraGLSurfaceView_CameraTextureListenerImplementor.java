package mono.org.opencv.android;


public class CameraGLSurfaceView_CameraTextureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.opencv.android.CameraGLSurfaceView.CameraTextureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraTexture:(IIII)Z:GetOnCameraTexture_IIIIHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV\n" +
			"n_onCameraViewStarted:(II)V:GetOnCameraViewStarted_IIHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV\n" +
			"n_onCameraViewStopped:()V:GetOnCameraViewStoppedHandler:OpenCV.Android.CameraGLSurfaceView/ICameraTextureListenerInvoker, OpenCV\n" +
			"";
		mono.android.Runtime.register ("OpenCV.Android.CameraGLSurfaceView+ICameraTextureListenerImplementor, OpenCV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CameraGLSurfaceView_CameraTextureListenerImplementor.class, __md_methods);
	}


	public CameraGLSurfaceView_CameraTextureListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CameraGLSurfaceView_CameraTextureListenerImplementor.class)
			mono.android.TypeManager.Activate ("OpenCV.Android.CameraGLSurfaceView+ICameraTextureListenerImplementor, OpenCV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onCameraTexture (int p0, int p1, int p2, int p3)
	{
		return n_onCameraTexture (p0, p1, p2, p3);
	}

	private native boolean n_onCameraTexture (int p0, int p1, int p2, int p3);


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
