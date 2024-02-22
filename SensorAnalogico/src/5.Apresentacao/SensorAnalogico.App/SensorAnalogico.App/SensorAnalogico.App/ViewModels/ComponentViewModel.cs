using Avalonia.Controls;
using ReactiveUI;
using System.Windows.Input;

namespace SensorAnalogico.App.ViewModels
{
    public class ComponentViewModel : ViewModelBase
    {

        public ICommand CommandOpenAnalogicIn { get; }
        public ICommand CommandOpenSensorClimatico { get; }

        public ComponentViewModel()
        {
            CommandOpenAnalogicIn = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenAnalogicIn_Action(tcc));
            CommandOpenSensorClimatico = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenSensorClimatico_Action(tcc));
        }

        private void CommandOpenAnalogicIn_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc,ResourcePages.PageName.AnalogicInput);
        }

        private void CommandOpenSensorClimatico_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc, ResourcePages.PageName.SensorClimatico);
        }
    }
}
