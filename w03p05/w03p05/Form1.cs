namespace w03p05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (radioButton1.Checked)
            { panel1.BackColor = Color.Red; }
            else { panel1.BackColor = Color.Green; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Black;
                checkBox1.ForeColor = Color.White;
                checkBox1.Text = "tryb dzienny";
            }
            else
            {
                Form1.ActiveForm.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                checkBox1.Text = "tryb nocny";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            { panel1.BackColor = Color.Red; }
            else { panel1.BackColor = Color.Green; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { panel1.BackColor = Color.Red; }
            else { panel1.BackColor = Color.Green; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { panel1.BackColor = Color.Red; }
            else { panel1.BackColor = Color.Green; }
        }
    }
}