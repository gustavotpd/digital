package md58f0a66066591687b576b0cdb3de8fb49;


public class SpinnerHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("digital.Droid.SpinnerHolder, digital.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SpinnerHolder.class, __md_methods);
	}


	public SpinnerHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SpinnerHolder.class)
			mono.android.TypeManager.Activate ("digital.Droid.SpinnerHolder, digital.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
