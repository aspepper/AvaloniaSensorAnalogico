using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using SensorAnalogico.App.Services;
using SensorAnalogico.App.ViewModels;

namespace SensorAnalogico.App.Views
{
    public partial class MainView : ReactiveUserControl<MainViewModel>
    {
        protected MainViewModel viewModel = new();

        public MainView()
        {
            InitializeComponent();
            DataContext = viewModel;
            CurrentContentView.Content = PageService.CurrentPage;
        }

        protected override void OnLoaded(RoutedEventArgs e)
        {
            base.OnLoaded(e);

            var insetsManager = TopLevel.GetTopLevel(this)?.InsetsManager;

            if (insetsManager != null)
            {
                insetsManager.DisplayEdgeToEdge = true;
                insetsManager.IsSystemBarVisible = false;
            }
        }

    }
}