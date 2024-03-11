using Avalonia.Controls;
using ReactiveUI;
using System;
using System.Windows.Input;

namespace SensorAnalogico.App.ViewModels
{
    public class MarcadorDePosicaoViewModel : ViewModelBase
    {
        private string microcontrollerId = "0";
        private string componentId = "0";

        public MarcadorDePosicaoViewModel()
        {
            CommandGoBack = ReactiveCommand.Create((TransitioningContentControl tcc) => { CommandGoBack_Action(tcc); });
            CommandGetInput = ReactiveCommand.Create(CommandGetInput_Action);
        }

        public string MicrocontrollerId
        {
            get => microcontrollerId;
            set => this.RaiseAndSetIfChanged(ref microcontrollerId, value);
        }

        public string ComponentId
        {
            get => componentId;
            set => this.RaiseAndSetIfChanged(ref componentId, value);
        }

        public ICommand CommandGoBack { get; }
        public ICommand CommandGetInput { get; }

        private void CommandGoBack_Action(TransitioningContentControl tcc)
        {
            NavigateTo(tcc, ResourcePages.PageName.Component);
        }

        private void CommandGetInput_Action()
        {
            throw new NotImplementedException();
        }

    }
}
