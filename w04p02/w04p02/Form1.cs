using System.Net.Sockets;

namespace w04p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Treœæ okienka", "tytu³",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                label1.Text = "Potwierdzono";
            }
            else
            {
                label1.Text = "NIEPOTWIERDZONO";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Napewno?","Czy zamkn¹æ",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Text = Form1.ActiveForm.Width.ToString() + "  "+
                Form1.ActiveForm.Height.ToString();
        }
    }
}