namespace SensorAnalogico.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        CurrentContentView ??= new ComponentViewModel();
    }
}

