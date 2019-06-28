package md591c3b7381cd8e618f2bb5a45734b5f3e;


public class ImageScanCompletedListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.media.MediaScannerConnection.OnScanCompletedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScanCompleted:(Ljava/lang/String;Landroid/net/Uri;)V:GetOnScanCompleted_Ljava_lang_String_Landroid_net_Uri_Handler:Android.Media.MediaScannerConnection/IOnScanCompletedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("BuildIt.Forms.Controls.Platforms.Android.ImageScanCompletedListener, BuildIt.Forms.Controls", ImageScanCompletedListener.class, __md_methods);
	}


	public ImageScanCompletedListener ()
	{
		super ();
		if (getClass () == ImageScanCompletedListener.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.ImageScanCompletedListener, BuildIt.Forms.Controls", "", this, new java.lang.Object[] {  });
	}


	public void onScanCompleted (java.lang.String p0, android.net.Uri p1)
	{
		n_onScanCompleted (p0, p1);
	}

	private native void n_onScanCompleted (java.lang.String p0, android.net.Uri p1);

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
