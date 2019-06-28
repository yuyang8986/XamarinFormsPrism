using Prism.Commands;
using Prism.Navigation;
using ShellSamplePrism.Models;
using ShellSamplePrism.Views.Cupertino;

namespace ShellSamplePrism.ViewModels.Cupertino
{
    public class CupertinoPageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public CupertinoItem[] CupertinoItems { get; }= new CupertinoItem[]{};

        public CupertinoPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Cupertino";

            CupertinoItems = new []{
                new CupertinoItem
                {
                    Title = "Activity Indicator",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Alerts",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Buttons",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Navigation",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Pickers",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Pull to refresh",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Segmented Control",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Silders",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Switches",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                },
                new CupertinoItem
                {
                    Title = "Text Fields",
                    ImageUrl = "tab_about.png",
                    ItemNavigateCommand = ItemNavigateCommand
                }
            };
        }

        private DelegateCommand<string> _itemNavigateCommand;
        public DelegateCommand<string> ItemNavigateCommand =>
            _itemNavigateCommand ?? (_itemNavigateCommand = new DelegateCommand<string>(ExecuteCommandItemNavigation));

        async void ExecuteCommandItemNavigation(string item)
        {
            switch (item)
            {
                case "Activity Indicator":
                    await _navigationService.NavigateAsync("ActivityIndicatorPage");
                    break;

                case "Alerts":
                    await _navigationService.NavigateAsync(nameof(Alerts));
                    break;
            }
        }
    }
}
