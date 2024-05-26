namespace wf_chat_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel2.Visible = false;
            bt1.BackColor = Color.DarkGreen;
            bt2.BackColor = Color.Gray;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            bt2.BackColor = Color.DarkGreen;
            bt1.BackColor= Color.Gray;
        }
    }
}
