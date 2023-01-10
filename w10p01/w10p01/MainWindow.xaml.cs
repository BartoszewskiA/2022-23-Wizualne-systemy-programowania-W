using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace w10p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(400);
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            textBlock01.Text += "tick ";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBlock01.Text = "kliknięto pozycję \"Otworz plik\"";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock01.Text = "kliknięto pozycję \"Zamknji plik\"";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            textBlock01.Text = "kliknięto pozycję \"01\" w menu kontekstowym";
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
