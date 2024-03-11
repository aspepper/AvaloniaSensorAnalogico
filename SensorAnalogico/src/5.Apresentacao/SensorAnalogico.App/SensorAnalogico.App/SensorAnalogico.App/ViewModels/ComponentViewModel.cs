using Avalonia.Controls;
using ReactiveUI;
using System.Windows.Input;

namespace SensorAnalogico.App.ViewModels
{
    public class ComponentViewModel : ViewModelBase
    {

        public ICommand CommandOpenAnalogicIn { get; }
        public ICommand CommandOpenSensorClimatico { get; }
        public ICommand CommandOpenProtocoloLocal { get; }
        public ICommand CommandOpenVRPControl { get; }
        public ICommand CommandOpenPositionMarker { get; }

        public ComponentViewModel()
        {
            CommandOpenAnalogicIn = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenAnalogicIn_Action(tcc));
            CommandOpenSensorClimatico = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenSensorClimatico_Action(tcc));
            CommandOpenProtocoloLocal = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenSensorProtocoloLocal_Action(tcc));
            CommandOpenVRPControl = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenVRPControl_Action(tcc));
            CommandOpenPositionMarker = ReactiveCommand.Create((TransitioningContentControl tcc) => CommandOpenPositionMarker_Action(tcc));
        }

        private void CommandOpenAnalogicIn_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc,ResourcePages.PageName.AnalogicInput);
        }

        private void CommandOpenSensorClimatico_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc, ResourcePages.PageName.SensorClimatico);
        }

        private void CommandOpenSensorProtocoloLocal_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc, ResourcePages.PageName.LocalProtocol);
        }

        private void CommandOpenVRPControl_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc, ResourcePages.PageName.SensorMicrocontroladorVRP);
        }

        private void CommandOpenPositionMarker_Action(TransitioningContentControl tcc)
        {
            this.NavigateTo(tcc, ResourcePages.PageName.SensorPositionMarker);
        }
    }
}
