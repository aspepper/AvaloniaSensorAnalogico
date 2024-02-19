using Avalonia.Controls;
using ReactiveUI;
using SensorAnalogico.App.Services;
using System.Windows.Input;

namespace SensorAnalogico.App.ViewModels
{
    public class AnalogicInConfigViewModel : ViewModelBase
    {

        public AnalogicService Service { get; set; } = new();

        public ICommand CommandGoBack { get; }

        public AnalogicInConfigViewModel()
        {
            CommandGoBack = ReactiveCommand.Create((TransitioningContentControl tcc) => { CommandGoBack_Action(tcc); });
        }

        private void CommandGoBack_Action(TransitioningContentControl tcc)
        {
            NavigateTo(tcc, ResourcePages.PageName.AnalogicInput);
        }
    }
}
