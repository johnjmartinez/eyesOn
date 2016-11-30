package md52774b0d2abb5b5930fdc2b4e23b41882;


public class ImageAvailableListener_ImageSaver
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.TakePhoto.Listeners.ImageAvailableListener+ImageSaver, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageAvailableListener_ImageSaver.class, __md_methods);
	}


	public ImageAvailableListener_ImageSaver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageAvailableListener_ImageSaver.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.ImageAvailableListener+ImageSaver, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ImageAvailableListener_ImageSaver (android.media.Image p0, java.io.File p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageAvailableListener_ImageSaver.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.Listeners.ImageAvailableListener+ImageSaver, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Media.Image, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Java.IO.File, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
