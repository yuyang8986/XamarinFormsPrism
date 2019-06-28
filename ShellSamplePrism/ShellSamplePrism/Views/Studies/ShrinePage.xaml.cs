using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSamplePrism.Views.Studies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShrinePage : ContentPage
    {
        public ShrinePage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.White;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.DodgerBlue;
        }
    }
}