package md5f406deb7cf15f94c9e5d0a1d3e0971d3;


public class XFGlossShaderFactory
	extends android.graphics.drawable.ShapeDrawable.ShaderFactory
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_resize:(II)Landroid/graphics/Shader;:GetResize_IIHandler\n" +
			"";
		mono.android.Runtime.register ("XFGloss.Droid.Drawables.XFGlossShaderFactory, XFGloss.Droid, Version=1.0.4.38, Culture=neutral, PublicKeyToken=null", XFGlossShaderFactory.class, __md_methods);
	}


	public XFGlossShaderFactory () throws java.lang.Throwable
	{
		super ();
		if (getClass () == XFGlossShaderFactory.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Drawables.XFGlossShaderFactory, XFGloss.Droid, Version=1.0.4.38, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.graphics.Shader resize (int p0, int p1)
	{
		return n_resize (p0, p1);
	}

	private native android.graphics.Shader n_resize (int p0, int p1);

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
