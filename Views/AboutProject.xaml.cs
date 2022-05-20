using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace AirQualify.Views
{
    /// <summary>
    /// Логика взаимодействия для AboutProject.xaml
    /// </summary>
    public partial class AboutProject : UserControl
    {
        public AboutProject()
        {
            InitializeComponent();
        }

        private void LinkClick(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/pRodAm1q/AirQualify/tree/test") { UseShellExecute = true });
        }
    }
}
