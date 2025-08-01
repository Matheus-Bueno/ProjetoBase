namespace ProjetoBase.UI
{
    public partial class FrmCadastroUsuario : Form
    {
        private Form loginForm;

        public FrmCadastroUsuario(Form formLogin)
        {
            InitializeComponent();
            loginForm = formLogin;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void BtnVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void BtnVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void BtnVerConfSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmacaoSenha.UseSystemPasswordChar = false;
        }

        private void BtnVerConfSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmacaoSenha.UseSystemPasswordChar = true;
        }
    }
}
