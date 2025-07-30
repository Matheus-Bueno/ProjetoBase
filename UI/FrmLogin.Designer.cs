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
            btnSair = new Button();
            btnLogin = new Button();
            btnCadastrar = new Button();
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            lblTituloUsername = new Label();
            lblTituloSenha = new Label();
            btnVerSenha = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(239, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(49, 31);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += BtnSair_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(198, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 44);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(12, 336);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(90, 44);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(46, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Digite seu nome de usuario.";
            txtUsername.Size = new Size(211, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(46, 213);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha.";
            txtSenha.Size = new Size(211, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblTituloUsername
            // 
            lblTituloUsername.AutoSize = true;
            lblTituloUsername.Location = new Point(42, 131);
            lblTituloUsername.Name = "lblTituloUsername";
            lblTituloUsername.Size = new Size(60, 15);
            lblTituloUsername.TabIndex = 5;
            lblTituloUsername.Text = "Username";
            // 
            // lblTituloSenha
            // 
            lblTituloSenha.AutoSize = true;
            lblTituloSenha.Location = new Point(46, 195);
            lblTituloSenha.Name = "lblTituloSenha";
            lblTituloSenha.Size = new Size(39, 15);
            lblTituloSenha.TabIndex = 6;
            lblTituloSenha.Text = "Senha";
            // 
            // btnVerSenha
            // 
            btnVerSenha.Location = new Point(226, 213);
            btnVerSenha.Name = "btnVerSenha";
            btnVerSenha.Size = new Size(31, 23);
            btnVerSenha.TabIndex = 7;
            btnVerSenha.Text = "👁️";
            btnVerSenha.UseVisualStyleBackColor = true;
            btnVerSenha.MouseDown += BtnVerSenha_MouseDown;
            btnVerSenha.MouseUp += BtnVerSenha_MouseUp;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(btnVerSenha);
            Controls.Add(lblTituloSenha);
            Controls.Add(lblTituloUsername);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLogin);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnLogin;
        private Button btnCadastrar;
        private TextBox txtUsername;
        private TextBox txtSenha;
        private Label lblTituloUsername;
        private Label lblTituloSenha;
        private Button btnVerSenha;
    }
}
