using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace w09p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> lista = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void otworz_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            if (ofd.ShowDialog() == true)
            {
            if(File.Exists(ofd.FileName))
                {
                    StreamReader sr = File.OpenText(ofd.FileName);
/*                    while(!sr.EndOfStream)
                    {
                        okno.Text = okno.Text + sr.ReadLine() + "\n";
                    }*/
                    okno.Text = sr.ReadToEnd();
                    sr.Close();
                }

            }
        }

        private void otworz_2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            if(ofd.ShowDialog() == true)
            {
                lista = new List<string>(File.ReadAllLines(ofd.FileName));
                for (int i = 0; i < lista.Count; i++)
                {
                    okno.Text = okno.Text+ lista[i] + "\n";                 
                }
            }

        }

        private void otworz_3_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter= "Pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            if( sfd.ShowDialog() == true)
            {
                File.WriteAllLines(sfd.FileName, lista);
            }
        }
    }
}
