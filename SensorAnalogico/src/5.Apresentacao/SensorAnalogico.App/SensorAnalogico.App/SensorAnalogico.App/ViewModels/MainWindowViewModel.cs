using ReactiveUI;

namespace SensorAnalogico.App.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public MainWindowViewModel()
    {
        _contentViewModel = new MainViewModel();
    }

}

