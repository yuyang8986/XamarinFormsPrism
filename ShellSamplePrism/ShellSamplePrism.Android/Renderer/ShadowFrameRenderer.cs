using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ShellSamplePrism.Controls;
using ShellSamplePrism.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly:ExportRenderer(typeof(ShadowFrame), typeof(ShadowFrameRenderer))]
namespace ShellSamplePrism.Droid.Renderer
{
    public class ShadowFrameRenderer:FrameRenderer
    {
        public ShadowFrameRenderer(Context context):base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            var frame = (Frame) Element;
            frame.HasShadow = true;


            int[] colors = { Element.BackgroundColor.ToAndroid(), Element.BackgroundColor.ToAndroid() };
            var gradientDrawable = new GradientDrawable(GradientDrawable.Orientation.LeftRight, colors);
            gradientDrawable.SetCornerRadius(20);
            //gradientDrawable.SetCornerRadius(Element.CornerRadius * 2); // CornerRadius = HeightRequest in my case

            this.SetBackground(gradientDrawable);
            this.Elevation = Element.HasShadow ? 5 : 0;
        }
    }
}