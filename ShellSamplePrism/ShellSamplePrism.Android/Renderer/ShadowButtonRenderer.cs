using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ShellSamplePrism.Controls;
using ShellSamplePrism.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;
using Color = Android.Graphics.Color;


[assembly:ExportRenderer(typeof(ShadowButton),typeof(ShadowButtonRenderer))]
namespace ShellSamplePrism.Droid.Renderer
{
    public class ShadowButtonRenderer:ButtonRenderer
    {
        public ShadowButtonRenderer(Context ctx):base(ctx)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control?.SetShadowLayer(4,0,2,Color.Black);
        }
    }
}