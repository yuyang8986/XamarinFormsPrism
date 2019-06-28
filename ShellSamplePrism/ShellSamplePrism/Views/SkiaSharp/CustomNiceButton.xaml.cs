using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSamplePrism.Views.SkiaSharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomNiceButton
    {
        public CustomNiceButton()
        {
            InitializeComponent();
        }

        private void CanvasView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            var skCanvas = args.Surface.Canvas;

            float width = args.Info.Width;
            float height = args.Info.Height;

            skCanvas.Clear(SKColors.White);
            SKPaint strokePaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.LightPink,
                StrokeWidth = 25,
            };

            //SKColor shadowColor = new SKColor(0, 0, 0, 70);
            //strokePaint.ImageFilter = SKImageFilter.CreateDropShadow(
            //    0f, 20f, 0f, 20f, shadowColor, SKDropShadowImageFilterShadowMode.DrawShadowAndForeground, null, null);

            SKPath path = new SKPath();
            //top left point, has x = 0 and y = 0
            path.MoveTo(25, 0); // start point
            path.LineTo(width-25, 0);
            path.LineTo(width, 25);
            path.LineTo(width, height-25);
            path.LineTo(width-25, height);
            path.LineTo(25, height);
            path.LineTo(0, height-25);
            path.LineTo(0, 25);
            path.LineTo(25, 0);


            //path.MoveTo(250, 250); // start point
            //path.LineTo(300,300);




            path.Close();

            skCanvas.DrawPath(path, strokePaint);
        }
    }
}