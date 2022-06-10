using AirQualify.Core;
using System.Windows;
using System.Windows.Input;

namespace AirQualify.ViewModel
{
    class MainViewModel : ObservableObject
    {
        #region CloseApplication
        /// <summary>
        /// Закрывает приложение
        /// </summary>
        public RelayCommand CloseApp { get; }

        private bool CanCloseApp(object p) => true;

        private void OnCloseApp(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region Navigate commands
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutAQIViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand AboutProjectViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public AboutAQIViewModel AboutAQIVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public AboutProjectViewModel AboutProjectVM { get; set; }
        #endregion

        private object? _currentView;
        public object? CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            #region CloseApp
            CloseApp = new RelayCommand(OnCloseApp, CanCloseApp);
            #endregion

            #region Navigation
            HomeVM = new HomeViewModel();
            AboutAQIVM = new AboutAQIViewModel();
            SettingsVM = new SettingsViewModel();
            AboutProjectVM = new AboutProjectViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            AboutAQIViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutAQIVM;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
            AboutProjectViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutProjectVM;
            });

            #endregion
        }
    }
}
