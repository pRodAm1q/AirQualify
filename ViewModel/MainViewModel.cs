using AirQualify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualify.ViewModel
{
    class MainViewModel : ObservableObject
    {


        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutAQIViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }
        public RelayCommand ABoutProjectViewCommand { get; set; }

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
            ABoutProjectViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutProjectVM;
            });
        }
    }
}
