using Avalonia.Controls;
using ReactiveUI;
using SensorAnalogico.App.Services;

namespace SensorAnalogico.App.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {

        public ViewModelBase()
        {
        }

        public ViewModelBase CurrentContentView
        {
            get => PageService.CurrentPage;
            set => PageService.CurrentPage = value;
        }

        public void NavigateTo(TransitioningContentControl tcc, ResourcePages.PageName pageName)
        {
            PageService.CurrentPage = ResourcePages.GetPage(pageName);
            tcc.Content = CurrentContentView;
        }

    }
}
