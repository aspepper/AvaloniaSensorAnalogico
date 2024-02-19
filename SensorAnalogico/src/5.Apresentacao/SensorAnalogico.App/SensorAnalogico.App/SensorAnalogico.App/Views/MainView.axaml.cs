using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using SensorAnalogico.App.ViewModels;

namespace SensorAnalogico.App.Views
{
    public partial class MainView : ReactiveUserControl<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            ((MainViewModel)DataContext).OpenInitialScreen(CurrentContentView, ResourcePages.PageName.Component);
        }

        /// <summary>
        /// Disables the status bar on mobile devices
        /// </summary>
        /// <param name="e"></param>
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