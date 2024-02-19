using ReactiveUI;
using System.Windows.Input;
using SensorAnalogico.App.ViewModels;

namespace SensorAnalogico.App.Services
{
    /// <summary>
    /// An abstract class for enabling page navigation.
    /// </summary>
    public class PageService
    {

        public PageService()
        {
            // Set current page to first on start up
            _CurrentPage = ResourcePages.GetPage(ResourcePages.PageName.MainView);

            // Create Observables which will activate to deactivate our commands based on CurrentPage state
            NavigateToCommand = ReactiveCommand.Create<ResourcePages.PageName>((pagename) => NavigateTo(pagename));
        }
        /// <summary>
        /// Gets if the user can navigate to the next page
        /// </summary>
        public bool CanNavigateNext { get; protected set; }

        /// <summary>
        /// Gets if the user can navigate to the previous page
        /// </summary>
        public bool CanNavigatePrevious { get; protected set; }

        public ViewModelBase ViewModelBase { get; protected set; } = new MainViewModel();

        // The default is the first page
        private static ViewModelBase _CurrentPage;

        /// <summary>
        /// Gets the current page. The property is read-only
        /// </summary>
        public static ViewModelBase CurrentPage
        {
            get => _CurrentPage;
            set => _CurrentPage = value;
        }

        public ICommand NavigateToCommand { get; }

        protected void NavigateTo(ResourcePages.PageName pageName)
        {
            CurrentPage = ResourcePages.GetPage(pageName);
        }

    }
}
