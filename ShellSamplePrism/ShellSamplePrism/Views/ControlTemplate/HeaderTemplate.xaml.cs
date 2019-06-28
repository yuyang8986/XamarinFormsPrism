using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSamplePrism.Views.ControlTemplate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderTemplate : ContentView
    {
        public HeaderTemplate()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<App>(this, "CallMethod", (sender) => {
               
               HeaderMenuToggle_OnClick(sender,null);
            });
        }


        public async void HeaderMenuToggle_OnClick(object sender, EventArgs e)
        {

            if (MenuGrid.TranslationY == 0)
            {
                //MenuGrid.TranslationY = -500;
                MenuGrid.HeightRequest = 0;
                MenuGrid.TranslateTo(0, -1000, 200);
            }

            else
            {
                //MenuGrid.TranslationY = 0;
                MenuGrid.HeightRequest = 1000;
                MenuGrid.TranslateTo(0, 0, 200);
            }

            if (MainContent.TranslationY < 1000)
            {
                // MainContent.TranslationY = 500;
                MainContent.HeightRequest = 0;
                MainContent.TranslateTo(0, 1000, 200);
            }

            else
            {
                //MainContent.TranslationY = 0;
                MainContent.HeightRequest = 1000;
                MainContent.TranslateTo(0, 0, 200);
            }

            //VisualStateManager.Bind(this.Parent.LogicalChildren.First(), StateManager);
            //var currentState = StateManager.CurrentState<MainMenuStates>();

            //if (currentState == MainMenuStates.ShowMenu)
            //{
            //   await StateManager.GoToState(MainMenuStates.HideMenu);
            //}

            //else
            //{
            //    try
            //    {
            //        await StateManager.GoToState(MainMenuStates.ShowMenu);
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception);
            //        throw;
            //    }
            //}

        }

        private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}