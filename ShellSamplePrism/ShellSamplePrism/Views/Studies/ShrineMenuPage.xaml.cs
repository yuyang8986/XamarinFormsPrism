using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using ShellSamplePrism.ViewModels.Studies;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VisualStateManager = BuildIt.Forms.VisualStateManager;

namespace ShellSamplePrism.Views.Studies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShrineMenuPage : ContentPage
    {

        public ShrineMenuPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var vm = BindingContext as ShrineMenuPageViewModel;
            await VisualStateManager.Bind(this, vm.StateManager);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); 
            //VisualStateManager.GoToState(this, height > width ? "Portrait" : "LandScape");
        }

        private void RefreshCollectionViewPosition(object sender, EventArgs e)
        {
            ShrineItemsPage.ScrollTo(0);
        }

        private void ClearCartButton_OnClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as ShrineMenuPageViewModel;
            if (vm.CartItemsGroups == null || vm.ShrineCartItems == null) return;
            vm.ShrineCartItems.Clear();
            vm.CartItemsGroups.Clear();
            vm.ShowCartCommand.Execute();
        }
    }
}