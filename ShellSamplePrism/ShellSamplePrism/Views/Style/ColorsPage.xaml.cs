using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellSamplePrism.ViewModels.Style;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSamplePrism.Views.Style
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsPage 
    {
        public ColorsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //this.ItemsSource = (BindingContext as ColorsPageViewModel).Colors;
            if (this.ItemsSource == null)
            {
                this.ItemsSource = (BindingContext as ColorsPageViewModel).Colors;
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}