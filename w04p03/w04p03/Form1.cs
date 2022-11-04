namespace w04p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\nklik";
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n2xklik";
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + " " + e.Y.ToString();
            panel1.BackColor = Color.FromArgb(255, e.X, e.Y, 255);
        }
    }
}