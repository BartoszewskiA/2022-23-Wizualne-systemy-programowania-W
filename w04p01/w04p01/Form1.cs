namespace w04p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            s += "\nZadziałała metoda Load";
            textBox1.Text = s;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            s += "\nZadziałała metoda Activated";
            textBox1.Text = s;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            s += "\nZadziałała metoda DeActivated";
            textBox1.Text = s;
        }
    }
}