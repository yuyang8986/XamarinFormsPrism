using Prism.Commands;
using Prism.Navigation;

namespace ShellSamplePrism.ViewModels.Style
{
    public class StylePageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public StylePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Style";
        }

        private DelegateCommand<string> _styleNavigationCommand;
        public DelegateCommand<string> StyleNavigationCommand =>
            _styleNavigationCommand ?? (_styleNavigationCommand = new DelegateCommand<string>(ExecuteStyleNavigationCommand));

        async void ExecuteStyleNavigationCommand(string section)
        {
            switch (section)
            {
                case "Colors":
                    await _navigationService.NavigateAsync("ColorsPage");
                    break;
            }

        }
    }
}
