using System;
using System.ComponentModel;
using ShellSamplePrism.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Android.Widget.Button;
using Color = Android.Graphics.Color;


[assembly: ResolutionGroupName("btr")]
[assembly:ExportEffect(typeof(ButtonShadowEffect), nameof(ButtonShadowEffect))]
namespace ShellSamplePrism.Droid.Effects
{
    public class ButtonShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {
                if (Control is Button button)
                {
                    button.SetShadowLayer(4, 0, 2, Color.Black);
                }
            }
        }

        protected override void OnDetached()
        {
           
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (Control != null)
            {
                if (Control is Button button)
                {
                    button.SetShadowLayer(4,0,2,Color.Black);
                }
            }
        }
    }
}