using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShellSamplePrism.Effects
{
    public class ButtonShadowEffect:RoutingEffect
    {
        public ButtonShadowEffect() : base($"btr.{nameof(ButtonShadowEffect)}")
        {
        }
    }
}
