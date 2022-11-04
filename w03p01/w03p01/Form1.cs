namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);*/
            int x, y;
            if(int.TryParse(textBox1.Text, out x)) {}
            else
            {
                x = 0;
                textBox1.Text = 0.ToString();
            }
            if (int.TryParse(textBox2.Text, out y)) { }
            else
            {
                y = 0;
                textBox2.Text = 0.ToString();
            }
            double srednia = (x + y) / 2.0;
            textBox3.Text = srednia.ToString();
        }
    }
}