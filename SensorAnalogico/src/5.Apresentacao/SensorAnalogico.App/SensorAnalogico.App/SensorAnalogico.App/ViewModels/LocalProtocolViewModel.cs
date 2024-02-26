using Avalonia.Controls;
using Avalonia.Media;
using ReactiveUI;
using SensorAnalogico.App.Services;
using System;
using System.Windows.Input;

namespace SensorAnalogico.App.ViewModels
{
    public class LocalProtocolViewModel : ViewModelBase
    {

        private IBrush statusColor = Brushes.Red;

        public IBrush StatusColor
        {
            get => statusColor; 
            set => this.RaiseAndSetIfChanged(ref statusColor, value);
        }

        private IBrush commandColor = Brushes.Red;

        public IBrush CommandColor
        {
            get => commandColor;
            set => this.RaiseAndSetIfChanged(ref commandColor, value);
        }

        private string microcontrollerId = "0";
        public string MicrocontrollerId
        {
            get => microcontrollerId;
            set => this.RaiseAndSetIfChanged(ref microcontrollerId, value);
        }

        private string componentId = "0";
        public string ComponentId
        {
            get => componentId;
            set => this.RaiseAndSetIfChanged(ref componentId, value);
        }

        public AnalogicService Service { get; set; } = new();

        public ICommand CommandGoBack { get; }
        public ICommand CommandChangeConfiguration { get; }
        public ICommand CommandChangeCommand { get; }
        public ICommand CommandGetInput { get; }

        public LocalProtocolViewModel()
        {
            StatusColor = Brushes.Red;
            CommandColor = Brushes.Green;
            CommandGoBack = ReactiveCommand.Create((TransitioningContentControl tcc) => { CommandGoBack_Action(tcc); });
            CommandChangeConfiguration = ReactiveCommand.Create((TransitioningContentControl tcc) => { CommandChangeConfiguration_Action(tcc); });
            CommandChangeCommand = ReactiveCommand.Create(CommandChangeCommand_Action);
            CommandGetInput = ReactiveCommand.Create(CommandGetInput_Action);
        }

        private void CommandGoBack_Action(TransitioningContentControl tcc)
        {
            NavigateTo(tcc, ResourcePages.PageName.Component);
        }

        private void CommandChangeConfiguration_Action(TransitioningContentControl tcc)
        {
            NavigateTo(tcc, ResourcePages.PageName.ConfigurationAnalogicInput);
        }

        private void CommandChangeCommand_Action()
        {
            throw new NotImplementedException();
        }

        private void CommandGetInput_Action()
        {
            throw new NotImplementedException();
        }

    }
}
