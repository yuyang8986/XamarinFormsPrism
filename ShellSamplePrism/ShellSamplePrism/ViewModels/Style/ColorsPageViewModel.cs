using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using ShellSamplePrism.Models;

namespace ShellSamplePrism.ViewModels.Style
{
    public class ColorsPageViewModel : ViewModelBase, IConfirmNavigationAsync
    {
        private readonly INavigationService _navigationService;


        public AppColor[] Colors { get; } =
        {
            new AppColor {Color = "Red", ColorCodes = new[] {"#FE8484", "#FE2020", "#FE4D4D", "#FE3939"}},
            new AppColor {Color = "Pink", ColorCodes = new[] {"#FFC1CC", "#F4C2C2", "#FF9393"}},
            new AppColor {Color = "Purple", ColorCodes = new[] {"#FF69B4", "#FF6969", "#FF69FF"}}
        };

        public ColorsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            Title = "Colors";

        }

        public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
