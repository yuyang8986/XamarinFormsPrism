using Prism.Commands;
using Prism.Navigation;
using ShellSamplePrism.Views.Studies;

namespace ShellSamplePrism.ViewModels.Studies
{
    public class StudiesPageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public StudiesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Studies";
        }

        private DelegateCommand<string> _studiesNavigationCommand;
        public DelegateCommand<string> StudiesNavigationCommand =>
            _studiesNavigationCommand ?? (_studiesNavigationCommand = new DelegateCommand<string>(ExecuteCommandStudiesNavigation));

        async void ExecuteCommandStudiesNavigation(string section)
        {
            switch (section)
            {
                case "ContactProfile":
                    await _navigationService.NavigateAsync(nameof(ContactProfilePage));
                    break;

                case "Shrine":
                    await _navigationService.NavigateAsync(nameof(ShrinePage));
                    break;
            }
        }
    }
}
