namespace w04p05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q')
                progressBar1.Value++;
            else if (e.KeyChar == 'a')
                progressBar1.Value--;
        }
    }
}