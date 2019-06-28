using Prism;
using Prism.Ioc;
using ShellSamplePrism.Services;
using ShellSamplePrism.ViewModels;
using ShellSamplePrism.ViewModels.Cupertino;
using ShellSamplePrism.ViewModels.Material;
using ShellSamplePrism.ViewModels.Media;
using ShellSamplePrism.ViewModels.Studies;
using ShellSamplePrism.ViewModels.Style;
using ShellSamplePrism.Views;
using ShellSamplePrism.Views.Cupertino;
using ShellSamplePrism.Views.Material;
using ShellSamplePrism.Views.Media;
using ShellSamplePrism.Views.Studies;
using ShellSamplePrism.Views.Style;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ShellSamplePrism
{
    public partial class App
    {
        /*
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor.
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {

            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<StudiesPage, StudiesPageViewModel>();
            containerRegistry.RegisterForNavigation<StylePage, StylePageViewModel>();
            containerRegistry.RegisterForNavigation<MaterialPage, MaterialPageViewModel>();
            containerRegistry.RegisterForNavigation<CupertinoPage, CupertinoPageViewModel>();
            containerRegistry.RegisterForNavigation<MediaPage, MediaPageViewModel>();
            containerRegistry.RegisterForNavigation<ColorsPage, ColorsPageViewModel>();
            containerRegistry.RegisterForNavigation<ActivityIndicatorPage>();
            containerRegistry.RegisterForNavigation<ContactProfilePage, ContactProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<ShrinePage, ShrinePageViewModel>();
            containerRegistry.RegisterForNavigation<ShrineMenuPage, ShrineMenuPageViewModel>();
            containerRegistry.RegisterForNavigation<Alerts, AlertsPageViewModel>();

            //containerRegistry.RegisterForNavigation<ShrineItemsPage, ShrineItemsPageViewModel>();

            containerRegistry.Register<IFancyService, FancyService>();
        }
    }
}