using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AirQualify
{

    public partial class MainWindow : Window
    {

        public static MainWindow? Window;
        public MainWindow()
        {
            InitializeComponent();
            Window = this;

        }

        private void Drag(object sender, RoutedEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                Window.DragMove();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

