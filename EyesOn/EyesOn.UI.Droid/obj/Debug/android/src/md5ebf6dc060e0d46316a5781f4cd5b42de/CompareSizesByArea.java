package md5ebf6dc060e0d46316a5781f4cd5b42de;


public class CompareSizesByArea
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.util.Comparator
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_compare:(Ljava/lang/Object;Ljava/lang/Object;)I:GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler:Java.Util.IComparatorInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_equals:(Ljava/lang/Object;)Z:GetEquals_Ljava_lang_Object_Handler:Java.Util.IComparatorInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("EyesOn.UI.Droid.TakePhoto.CompareSizesByArea, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CompareSizesByArea.class, __md_methods);
	}


	public CompareSizesByArea () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CompareSizesByArea.class)
			mono.android.TypeManager.Activate ("EyesOn.UI.Droid.TakePhoto.CompareSizesByArea, EyesOn.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public int compare (java.lang.Object p0, java.lang.Object p1)
	{
		return n_compare (p0, p1);
	}

	private native int n_compare (java.lang.Object p0, java.lang.Object p1);


	public boolean equals (java.lang.Object p0)
	{
		return n_equals (p0);
	}

	private native boolean n_equals (java.lang.Object p0);

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
