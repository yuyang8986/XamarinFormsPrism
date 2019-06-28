using System;
using Prism.Commands;
using Prism.Navigation;
using ShellSamplePrism.Services;

namespace ShellSamplePrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IFancyService _fancyService;
        private DelegateCommand<string>  _navigationCommand;

        public DelegateCommand<string> NavigationCommand =>
            _navigationCommand ?? new DelegateCommand<string>(ExecuteNavigationCommand);

        async void ExecuteNavigationCommand(string section)
        {
            switch (section)
            {
                case "Studies":
                    await _navigationService.NavigateAsync("StudiesPage");
                    break;

                case "Style":
                    await _navigationService.NavigateAsync("StylePage");
                    break;

                case "Material":
                    await _navigationService.NavigateAsync("MaterialPage");
                    break;

                case "Cupertino":
                    await _navigationService.NavigateAsync("CupertinoPage");
                    break;

                case "Media":
                    await _navigationService.NavigateAsync("MediaPage");
                    break;
            }
        }

        public MainPageViewModel(INavigationService navigationService, IFancyService fancyService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            _fancyService = fancyService;
            Title = "XF Gallery";
        }

    }
}
