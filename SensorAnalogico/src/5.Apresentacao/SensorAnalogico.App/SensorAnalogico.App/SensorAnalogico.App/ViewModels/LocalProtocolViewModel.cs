using Avalonia.Controls;
using Avalonia.Media;
using DynamicData;
using Microsoft.Extensions.Logging;
using ReactiveUI;
using SensorAnalogico.App.Services;
using System;
using System.Collections.ObjectModel;
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

        public string Notes { get; set; }

        public string Events { get; set; }

        public ObservableCollection<string> ListaPorta01 { get; set; } = [  "PonteH",
                                                                            "Hidráulico",
                                                                            "Eletronico"
                                                                         ];
        public ObservableCollection<string> ListaPorta02 { get; set; } = [  "PonteH",
                                                                            "Hidráulico",
                                                                            "Eletronico"
                                                                         ];
        public ObservableCollection<string> ListaPorta03 { get; set; } = [  "PonteH",
                                                                            "Hidráulico",
                                                                            "Eletronico"
                                                                         ];
        private string selectedPort1;
        public string SelectedPort1 { get => selectedPort1; set => this.RaiseAndSetIfChanged(ref selectedPort1, value); }
        private string selectedPort2;
        public string SelectedPort2 { get => selectedPort2; set => this.RaiseAndSetIfChanged(ref selectedPort2, value); }
        private string selectedPort3;
        public string SelectedPort3 { get => selectedPort3; set => this.RaiseAndSetIfChanged(ref selectedPort3, value); }
        private string baldRate;
        public string BaldRate { get => baldRate; set => this.RaiseAndSetIfChanged(ref baldRate, value); }


        public AnalogicService Service { get; set; } = new();

        public ICommand CommandGoBack { get; }
        public ICommand CommandChangeConfiguration { get; }
        public ICommand CommandChangeCommand { get; }
        public ICommand CommandGetInput { get; }

        public LocalProtocolViewModel()
        {
            Notes = "Isso é um teste, um teste de anotações. \r\nIsso é um teste, um teste de anotações. \r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\nIsso é um teste, um teste de anotações.\r\n";
            Events = "";
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
