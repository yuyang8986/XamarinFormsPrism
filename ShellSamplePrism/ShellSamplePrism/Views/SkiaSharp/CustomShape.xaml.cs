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
    public partial class CustomShape
    {
        public CustomShape()
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
                Color = SKColors.Bisque,
                StrokeWidth = 5,
            };

            SKPath path = new SKPath();
            //start point is the top left, has x = 0 and y = 0
            path.MoveTo(width, height); // start point
            path.LineTo(width, 0);
            path.LineTo(75, height / 2);
            path.LineTo(75, height);
            path.LineTo(width, height);

            //path.MoveTo(200, 200); // start point
            //path.LineTo(300,300);




            path.Close();

            skCanvas.DrawPath(path, strokePaint);
        }
    }
    }
