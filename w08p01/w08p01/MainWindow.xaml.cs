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

namespace w08p01
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
            OknoDialogowe1 okno = new OknoDialogowe1();
            if (okno.ShowDialog() == true)
            {
                label01.Content = okno.w2_textBox01.Text;
            }
            else
                label01.Content = "wybrano Cancel";
        }
    }
}
