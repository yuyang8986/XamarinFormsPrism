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
    public partial class ReverseTriangle 
    {
        public ReverseTriangle()
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
                StrokeWidth = 5,
            };

            SKPath path = new SKPath();
            //start point is the top left, has x = 0 and y = 0
            path.MoveTo(width, 0); // start point
            path.LineTo(0, 0);
            path.LineTo(0, height);
            path.LineTo(width, 0);



            //path.MoveTo(200, 200); // start point
            //path.LineTo(300,300);




            path.Close();

            skCanvas.DrawPath(path, strokePaint);
        }

    }
}