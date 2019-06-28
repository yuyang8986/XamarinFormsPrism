using System;
using System.Collections.Generic;
using System.Text;
using BuildIt.States;
using BuildIt.States.Interfaces;
using Prism.Navigation;

namespace ShellSamplePrism.ViewModels.Material
{
    public enum RotationStates
    {
        Base,
        Vertical,
        Horizontal
    }

    public class MaterialPageViewModel:ViewModelBase, IHasStates
    {
        public IStateManager StateManager { get; } = new StateManager();

        public MaterialPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Material";

            StateManager.Group<RotationStates>().DefineAllStates();
        }

        public void GoVertical()
        {
            StateManager.CurrentState<RotationStates>();

            StateManager.GoToState(RotationStates.Vertical);
        }

        public void GoHorizontal()
        {
            StateManager.GoToState(RotationStates.Horizontal);
        }
    }
}
