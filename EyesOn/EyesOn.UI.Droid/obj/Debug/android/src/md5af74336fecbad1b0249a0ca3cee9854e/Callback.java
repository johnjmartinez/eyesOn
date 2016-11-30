package md5af74336fecbad1b0249a0ca3cee9854e;


public class Callback
	extends org.opencv.android.BaseLoaderCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onManagerConnected:(I)V:GetOnManagerConnected_IHandler\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.ColorBlobDetection.Callback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Callback.class, __md_methods);
	}


	public Callback (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == Callback.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.ColorBlobDetection.Callback, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onManagerConnected (int p0)
	{
		n_onManagerConnected (p0);
	}

	private native void n_onManagerConnected (int p0);

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
