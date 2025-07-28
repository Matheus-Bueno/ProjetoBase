namespace ProjetoBase
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSair = new Button();
            BtnLogin = new Button();
            BtnCadastrar = new Button();
            TxtUsername = new TextBox();
            TxtSenha = new TextBox();
            LblTituloUsername = new Label();
            LblTituloSenha = new Label();
            SuspendLayout();
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.Transparent;
            BtnSair.Cursor = Cursors.Hand;
            BtnSair.FlatAppearance.BorderSize = 0;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Location = new Point(239, 12);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(49, 31);
            BtnSair.TabIndex = 0;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Transparent;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Location = new Point(198, 336);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(90, 44);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.BackColor = Color.Transparent;
            BtnCadastrar.FlatAppearance.BorderSize = 0;
            BtnCadastrar.FlatStyle = FlatStyle.Flat;
            BtnCadastrar.Location = new Point(12, 336);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(90, 44);
            BtnCadastrar.TabIndex = 2;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = false;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(46, 149);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.PlaceholderText = "Digite seu nome de usuario.";
            TxtUsername.Size = new Size(211, 23);
            TxtUsername.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(46, 213);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.PlaceholderText = "Digite sua senha.";
            TxtSenha.Size = new Size(211, 23);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblTituloUsername
            // 
            LblTituloUsername.AutoSize = true;
            LblTituloUsername.Location = new Point(42, 131);
            LblTituloUsername.Name = "LblTituloUsername";
            LblTituloUsername.Size = new Size(60, 15);
            LblTituloUsername.TabIndex = 5;
            LblTituloUsername.Text = "Username";
            // 
            // LblTituloSenha
            // 
            LblTituloSenha.AutoSize = true;
            LblTituloSenha.Location = new Point(46, 195);
            LblTituloSenha.Name = "LblTituloSenha";
            LblTituloSenha.Size = new Size(39, 15);
            LblTituloSenha.TabIndex = 6;
            LblTituloSenha.Text = "Senha";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(LblTituloSenha);
            Controls.Add(LblTituloUsername);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUsername);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnLogin);
            Controls.Add(BtnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSair;
        private Button BtnLogin;
        private Button BtnCadastrar;
        private TextBox TxtUsername;
        private TextBox TxtSenha;
        private Label LblTituloUsername;
        private Label LblTituloSenha;
    }
}
