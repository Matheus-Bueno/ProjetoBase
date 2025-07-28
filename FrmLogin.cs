namespace ProjetoBase
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Realmente Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes) {
            Application.Exit();
            }
        }
    }
}
