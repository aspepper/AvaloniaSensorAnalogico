using Avalonia.Controls;

namespace SensorAnalogico.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{

    public void OpenInitialScreen(TransitioningContentControl tcc, ResourcePages.PageName page)
    {
        this.NavigateTo(tcc, page);
    }
}

