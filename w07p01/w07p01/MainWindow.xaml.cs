using Microsoft.Win32;
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

namespace w07p01
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

        private void button01_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tekst w oknie komunikatu");
        }

        private void button02_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tekst w oknie komunikatu", "Tytuł okna", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void button03_Click(object sender, RoutedEventArgs e)
        {

            /*          MessageBoxResult odpowiedz = MessageBox.Show("Zgadzasz się?", "Pytanie",MessageBoxButton.YesNo, MessageBoxImage.Question);
                       if(odpowiedz == MessageBoxResult.Yes)
                       {
                           label01.Content = "Odpowiedziano TAK";
                       }
                       else
                       {
                           label01.Content = "Odpowiedziano NIE";
                       }*/
            
            if(MessageBox.Show("Zgadzasz się?", "Pytanie", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                label01.Content = "Odpowiedziano TAK";
            }
            else
            {
                label01.Content = "Odpowiedziano NIE";
            }

        }

        private void button04_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Otwieranie pliku";
            openFileDialog.Filter = "Adobe Acrobat (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(openFileDialog.ShowDialog()==true)
            {
                String wynik = "";
                string[] nazwy = openFileDialog.FileNames;
                foreach(String s in nazwy)
                {
                    wynik += s;
                    wynik += "\n";
                }
                textBlock01.Text = wynik;
            }
        }

        private void button05_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Zapis do pliku";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            if(saveFileDialog.ShowDialog()==true)
            {
                textBlock02.Text = saveFileDialog.FileName;
            }
        }

        private void button06_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog fontDialog = new System.Windows.Forms.FontDialog();
            if(fontDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBlock03.Text = fontDialog.Font.Name.ToString();
                textBlock03.Text = textBlock03.Text + " "+ fontDialog.Font.Size.ToString();
                textBlock03.FontFamily = new FontFamily(fontDialog.Font.Name.ToString());
                textBlock03.FontSize = fontDialog.Font.Size;
            }
        }

        private void button07_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog01 = new System.Windows.Forms.ColorDialog();
            if(colorDialog01.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                byte R = colorDialog01.Color.R;
                byte G = colorDialog01.Color.G;
                byte B = colorDialog01.Color.B;
                SolidColorBrush pedzel = new SolidColorBrush(Color.FromRgb(R, G, B));
                probnikKoloru.Fill = pedzel;
            }

        }
    }
}
