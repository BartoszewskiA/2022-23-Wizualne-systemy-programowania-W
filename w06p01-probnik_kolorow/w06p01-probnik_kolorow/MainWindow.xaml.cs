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

namespace w06p01_probnik_kolorow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        void zmien_kolor()
        {

            byte srednia = (byte)((suwakR.Value + suwakG.Value + suwakB.Value) / 3);
            if (srednia <100) 
                druk.Foreground = new SolidColorBrush(Colors.White);
            else
                druk.Foreground = new SolidColorBrush(Colors.Black);    
            if (druk.IsChecked == false)
            {
                probnik.Fill = new SolidColorBrush(
                  Color.FromRgb(
              (byte)suwakR.Value,
              (byte)suwakG.Value,
              (byte)suwakB.Value
              ));
            }
         else
            {
                probnik.Fill = new SolidColorBrush(Color.FromRgb(srednia, srednia, srednia));
            }
            
  
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelR.Content = Math.Round(suwakR.Value);
            p1.Fill = new SolidColorBrush(Color.FromRgb((byte)suwakR.Value, 0, 0));
            if (suwakG!=null && suwakB!=null)
            {
                zmien_kolor();
            }
        }

        private void suwakG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelG.Content = Math.Round(suwakG.Value);
            p2.Fill = new SolidColorBrush(Color.FromRgb(0, (byte)suwakG.Value, 0));
            if (suwakG != null && suwakB != null)
            {
                zmien_kolor();
            }
        }

        private void suwakB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelB.Content = Math.Round(suwakB.Value);
            p3.Fill = new SolidColorBrush(Color.FromRgb(0,0,(byte)suwakB.Value));
            if (suwakG != null && suwakB != null)
            {
                zmien_kolor();
            }
        }

        private void druk_Checked(object sender, RoutedEventArgs e)
        {
            zmien_kolor();
        }
    }
}
