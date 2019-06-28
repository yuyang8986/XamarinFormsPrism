using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;
using ShellSamplePrism.Views.Studies;

namespace ShellSamplePrism.ViewModels.Studies
{
    public class ShrinePageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ShrinePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
        }

        private DelegateCommand _goBackButtonCommand;
        public DelegateCommand GoBackButtonCommand =>
            _goBackButtonCommand ?? (_goBackButtonCommand = new DelegateCommand(ExecuteCommandNameGoBack));

        async void ExecuteCommandNameGoBack()
        {
            await _navigationService.GoBackAsync();
        }


        private DelegateCommand _nextButtonNavigationCommand;
        public DelegateCommand NextButtonNavigationCommand =>
            _nextButtonNavigationCommand ?? (_nextButtonNavigationCommand = new DelegateCommand(ExecuteCommandNameNextButtonNavigation));

        void ExecuteCommandNameNextButtonNavigation()
        {
            _navigationService.NavigateAsync(nameof(ShrineMenuPage));
        }
    }
}
