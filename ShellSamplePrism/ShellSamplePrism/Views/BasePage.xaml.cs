using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildIt.States;
using BuildIt.States.Interfaces;
using Prism.Commands;
using ShellSamplePrism.Views.ControlTemplate;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VisualStateManager = BuildIt.Forms.VisualStateManager;

namespace ShellSamplePrism.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage, IHasStates
    {

        private object BaseBindingContext;
        public BasePage()
        {
            InitializeComponent();
            SizeChanged += MainPage_SizeChanged;
            //StateManager.Group<MainMenuStates>().DefineAllStates();
            //StateManager.GoToState(MainMenuStates.HideMenu);


        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            bool isPortrait = this.Height > this.Width;

        }

        async void MenuToggle_OnClick(object sender, EventArgs e)
        {
            Xamarin.Forms.MessagingCenter.Send<App>((App)Xamarin.Forms.Application.Current, "CallMethod");
            //if (MenuGrid.TranslationY == 0)
            //{
            //    //MenuGrid.TranslationY = -500;
            //    MenuGrid.HeightRequest = 0;
            //    MenuGrid.TranslateTo(0, -600, 1000);
            //}

            //else
            //{
            //    //MenuGrid.TranslationY = 0;
            //    MenuGrid.HeightRequest = 600;
            //    MenuGrid.TranslateTo(0, 0, 1000);
            //}

            //if (MainContent.TranslationY == 0)
            //{
            //    // MainContent.TranslationY = 500;
            //    MainContent.HeightRequest = 0;
            //    MainContent.TranslateTo(0, 600, 1000);
            //}

            //else
            //{
            //    //MainContent.TranslationY = 0;
            //    MainContent.HeightRequest = 600;
            //    MainContent.TranslateTo(0, 0, 1000);
            //}

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

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    BaseBindingContext = BindingContext;
        //}

        public IStateManager StateManager { get; } = new StateManager();


        //public static readonly BindableProperty ParentContextProperty =
        //    BindableProperty.Create("ParentContext", typeof(object), typeof(BasePage), null, propertyChanged: OnParentContextPropertyChanged);

        //public object ParentContext
        //{
        //    get { return GetValue(ParentContextProperty); }
        //    set { SetValue(ParentContextProperty, value); }
        //}

        //private static void OnParentContextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    if (newValue != oldValue && newValue != null)
        //    {
        //        (bindable as BasePage).ParentContext = newValue;
        //    }
        //}
    }

    public enum MainMenuStates
    {
        ShowMenu,
        HideMenu
    }
}