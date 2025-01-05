namespace Stardust_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1?.Clear();
        }

        private void KillRoblox_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }
    }
}
