namespace Stardust
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1?.Clear();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void KillRoblox_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
