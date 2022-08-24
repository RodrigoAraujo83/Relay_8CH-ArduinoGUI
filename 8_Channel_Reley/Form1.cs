namespace _8_Channel_Reley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_status.Visible = false;
        }

        private void btn_ch1ON_Click(object sender, EventArgs e)
        {
            label_status.Visible = true;
            label_status.ForeColor = Color.Green;
            label_status.Text = "Ligado!";
        }
    }
}