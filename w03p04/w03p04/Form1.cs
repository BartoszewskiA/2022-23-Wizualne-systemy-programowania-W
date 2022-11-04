namespace w03p04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "";
            if(checkBox1.Checked == true)
            {
                s += "CheckBox 1 ";
            }
            if (checkBox2.Checked == true)
            {
                s += "CheckBox 2 ";
            }
            if (checkBox3.Checked == true)
            {
                s += "CheckBox 3 ";
            }
            label1.Text = s;
        }
    }
}