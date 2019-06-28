using Android.Content;
using ShellSamplePrism.Controls;
using ShellSamplePrism.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace ShellSamplePrism.Droid.Renderer
{
    public class CustomEntryRenderer:EntryRenderer
    {
        public CustomEntryRenderer(Context context):base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}