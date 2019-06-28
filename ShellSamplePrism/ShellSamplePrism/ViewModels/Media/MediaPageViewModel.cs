using Prism.Navigation;

namespace ShellSamplePrism.ViewModels.Media
{
    public class MediaPageViewModel:ViewModelBase
    {
        public MediaPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Media";
        }
    }
}
