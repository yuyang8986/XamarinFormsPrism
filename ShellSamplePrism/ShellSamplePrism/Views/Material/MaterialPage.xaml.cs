
using System;
using BuildIt.States.Interfaces;
using ShellSamplePrism.ViewModels.Material;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VisualStateManager = BuildIt.Forms.VisualStateManager;

namespace ShellSamplePrism.Views.Material
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialPage 
    {
        public MaterialPage()
        {
            InitializeComponent();
        }

        private void VerticalClicked(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(this, "Vertical");

            SomeContent.TranslateTo(100, 100, 1000);
        }

        private void HorizontalClicked(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(this, "Horizontal");
            SomeContent.TranslateTo(0, 0, 1000);
        }
    }
}