namespace w03p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = hScrollBar1.Value;
            label1.Text = x.ToString();
            progressBar1.Value = hScrollBar1.Value;
        }
    }
}