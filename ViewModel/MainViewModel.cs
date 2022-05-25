using AirQualify.Core;


namespace AirQualify.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutAQIViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand AboutProjectViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public AboutAQIViewModel AboutAQIVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public AboutProjectViewModel AboutProjectVM { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
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
        }
    }
}
