package md591c3b7381cd8e618f2bb5a45734b5f3e;


public class AutoFitTextureView
	extends android.view.TextureView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"";
		mono.android.Runtime.register ("BuildIt.Forms.Controls.Platforms.Android.AutoFitTextureView, BuildIt.Forms.Controls", AutoFitTextureView.class, __md_methods);
	}


	public AutoFitTextureView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AutoFitTextureView.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.AutoFitTextureView, BuildIt.Forms.Controls", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public AutoFitTextureView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AutoFitTextureView.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.AutoFitTextureView, BuildIt.Forms.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AutoFitTextureView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AutoFitTextureView.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.AutoFitTextureView, BuildIt.Forms.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public AutoFitTextureView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AutoFitTextureView.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.AutoFitTextureView, BuildIt.Forms.Controls", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);

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
