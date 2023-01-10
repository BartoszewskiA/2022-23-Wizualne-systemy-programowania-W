using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace w11p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker worker;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            textBox01.Text = (string)e.Result;
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            
            int ile = 0, x;
            bool pow=false;
            List<int> list = new List<int>();
            if (e.Argument != null) ile = (int)e.Argument;
            for(int i=0; i<ile; i++)
            {
                do
                {
                    x = random.Next(ile);
                    pow = false;
                    foreach (int pole in list)
                        if (pole == x)
                            pow = true;
                        if(!pow) list.Add(x);
                } while (pow);
            }
            String wynik = "";
            foreach (int pole in list)
                wynik += " " + pole.ToString();
            e.Result = wynik;
        }

        private void button01_Click(object sender, RoutedEventArgs e)
        {
            textBox01.Text = "";
            if(textBox02.Text.Length >0) 
                worker.RunWorkerAsync(int.Parse(textBox02.Text));
        }
    }
}
