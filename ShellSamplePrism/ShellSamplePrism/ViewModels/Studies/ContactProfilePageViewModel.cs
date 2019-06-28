using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.Toast;
using Prism.Commands;
using Prism.Navigation;

namespace ShellSamplePrism.ViewModels.Studies
{
    public class ContactProfilePageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ContactProfilePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Contact Profile";
        }

        private DelegateCommand _sMSImageTappedCommand;
        public DelegateCommand SMSImageTappedCommand =>
            _sMSImageTappedCommand ?? (_sMSImageTappedCommand = new DelegateCommand(ExecuteCommandSMSImageTapped));

         void ExecuteCommandSMSImageTapped()
        {
             CrossToastPopUp.Current.ShowToastMessage("Pretend this opens SMS application");
        }


        private DelegateCommand _emailImageTappedCommand;
        public DelegateCommand EmailImageTappedCommand =>
            _emailImageTappedCommand ?? (_emailImageTappedCommand = new DelegateCommand(ExecuteEmailImageTappedCommand));

        void ExecuteEmailImageTappedCommand()
       {
           CrossToastPopUp.Current.ShowToastMessage("Hey, this will open your email app");
       }


        private DelegateCommand _mapImageTappedCommand;
        public DelegateCommand MapImageTappedCommand =>
            _mapImageTappedCommand ?? (_mapImageTappedCommand = new DelegateCommand(ExecuteMapImageTappedCommand));

        void ExecuteMapImageTappedCommand()
        {
            CrossToastPopUp.Current.ShowToastMessage("This will open map app");
        }
     }
}
