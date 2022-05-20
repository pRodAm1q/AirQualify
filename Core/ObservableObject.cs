using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AirQualify.Core
{
    public class ObservableObject : INotifyPropertyChanged //18.05 add "public"
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
