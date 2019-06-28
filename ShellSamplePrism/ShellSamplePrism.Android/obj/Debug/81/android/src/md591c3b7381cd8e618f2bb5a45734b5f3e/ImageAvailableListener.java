package md591c3b7381cd8e618f2bb5a45734b5f3e;


public class ImageAvailableListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.media.ImageReader.OnImageAvailableListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onImageAvailable:(Landroid/media/ImageReader;)V:GetOnImageAvailable_Landroid_media_ImageReader_Handler:Android.Media.ImageReader/IOnImageAvailableListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("BuildIt.Forms.Controls.Platforms.Android.ImageAvailableListener, BuildIt.Forms.Controls", ImageAvailableListener.class, __md_methods);
	}


	public ImageAvailableListener ()
	{
		super ();
		if (getClass () == ImageAvailableListener.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.ImageAvailableListener, BuildIt.Forms.Controls", "", this, new java.lang.Object[] {  });
	}

	public ImageAvailableListener (md591c3b7381cd8e618f2bb5a45734b5f3e.CameraPreviewControlRenderer p0)
	{
		super ();
		if (getClass () == ImageAvailableListener.class)
			mono.android.TypeManager.Activate ("BuildIt.Forms.Controls.Platforms.Android.ImageAvailableListener, BuildIt.Forms.Controls", "BuildIt.Forms.Controls.Platforms.Android.CameraPreviewControlRenderer, BuildIt.Forms.Controls", this, new java.lang.Object[] { p0 });
	}


	public void onImageAvailable (android.media.ImageReader p0)
	{
		n_onImageAvailable (p0);
	}

	private native void n_onImageAvailable (android.media.ImageReader p0);

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
