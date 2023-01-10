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
using System.Windows.Shapes;

namespace w08p01
{
    /// <summary>
    /// Logika interakcji dla klasy OknoDialogowe1.xaml
    /// </summary>
    public partial class OknoDialogowe1 : Window
    {
        public OknoDialogowe1()
        {
            InitializeComponent();
        }

        private void w2_button01_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void w2_button02_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
