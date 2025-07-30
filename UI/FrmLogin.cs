using ProjetoBase.Data;
using ProjetoBase.UI;

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

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnVerSenha_MouseDown(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void BtnVerSenha_MouseUp(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginRepository.VerificaLogin(txtUsername.Text, txtSenha.Text);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
            frmCadastro.ShowDialog();
        }
    }
}
