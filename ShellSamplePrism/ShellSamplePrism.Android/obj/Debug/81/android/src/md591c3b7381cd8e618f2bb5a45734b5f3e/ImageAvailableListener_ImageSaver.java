package md591c3b7381cd8e618f2bb5a45734b5f3e;


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
		mono.android.Runtime.register ("BuildIt.Forms.Controls.Platforms.Android.ImageAvailableListener+ImageSaver, BuildIt.Forms.Controls", ImageAvailableListener_ImageSaver.class, __md_methods);
	}


	public ImageAvailableListener_ImageSaver ()
	{
		super ();
		if (getClass () == ImageAvailableListener_ImageSaver.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.ImageAvailableListener+ImageSaver, BuildIt.Forms.Controls", "", this, new java.lang.Object[] {  });
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
