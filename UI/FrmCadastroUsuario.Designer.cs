namespace ProjetoBase.UI
{
    partial class FrmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new Button();
            txtNome = new TextBox();
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            txtConfirmacaoSenha = new TextBox();
            btnCadastrar = new Button();
            lblTituloNome = new Label();
            lblTituloUsername = new Label();
            lblTituloSenha = new Label();
            LblTituloConfirmacaoSenha = new Label();
            btnVerSenha = new Button();
            BtnVerConfSenha = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.LightGray;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 10F);
            btnVoltar.Location = new Point(196, 345);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(92, 43);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(32, 60);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite seu Nome ";
            txtNome.Size = new Size(213, 25);
            txtNome.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(32, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nome de usuário";
            txtUsername.Size = new Size(213, 25);
            txtUsername.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(32, 164);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(213, 25);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Font = new Font("Segoe UI", 10F);
            txtConfirmacaoSenha.Location = new Point(32, 216);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.PlaceholderText = "Confirme sua senha";
            txtConfirmacaoSenha.Size = new Size(213, 25);
            txtConfirmacaoSenha.TabIndex = 4;
            txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.LightGreen;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 10F);
            btnCadastrar.Location = new Point(92, 284);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 43);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblTituloNome
            // 
            lblTituloNome.AutoSize = true;
            lblTituloNome.Font = new Font("Segoe UI", 10F);
            lblTituloNome.Location = new Point(32, 40);
            lblTituloNome.Margin = new Padding(3);
            lblTituloNome.Name = "lblTituloNome";
            lblTituloNome.Size = new Size(46, 19);
            lblTituloNome.TabIndex = 6;
            lblTituloNome.Text = "Nome";
            // 
            // lblTituloUsername
            // 
            lblTituloUsername.AutoSize = true;
            lblTituloUsername.FlatStyle = FlatStyle.Flat;
            lblTituloUsername.Font = new Font("Segoe UI", 10F);
            lblTituloUsername.Location = new Point(32, 89);
            lblTituloUsername.Name = "lblTituloUsername";
            lblTituloUsername.Size = new Size(71, 19);
            lblTituloUsername.TabIndex = 7;
            lblTituloUsername.Text = "Username";
            // 
            // lblTituloSenha
            // 
            lblTituloSenha.AutoSize = true;
            lblTituloSenha.FlatStyle = FlatStyle.Flat;
            lblTituloSenha.Font = new Font("Segoe UI", 10F);
            lblTituloSenha.Location = new Point(32, 141);
            lblTituloSenha.Name = "lblTituloSenha";
            lblTituloSenha.Size = new Size(110, 19);
            lblTituloSenha.TabIndex = 8;
            lblTituloSenha.Text = "Digite sua senha";
            // 
            // LblTituloConfirmacaoSenha
            // 
            LblTituloConfirmacaoSenha.AutoSize = true;
            LblTituloConfirmacaoSenha.FlatStyle = FlatStyle.Flat;
            LblTituloConfirmacaoSenha.Font = new Font("Segoe UI", 10F);
            LblTituloConfirmacaoSenha.Location = new Point(32, 193);
            LblTituloConfirmacaoSenha.Name = "LblTituloConfirmacaoSenha";
            LblTituloConfirmacaoSenha.Size = new Size(183, 19);
            LblTituloConfirmacaoSenha.TabIndex = 9;
            LblTituloConfirmacaoSenha.Text = "Digite sua senha novamente";
            // 
            // btnVerSenha
            // 
            btnVerSenha.BackColor = Color.Transparent;
            btnVerSenha.Cursor = Cursors.Hand;
            btnVerSenha.FlatAppearance.BorderSize = 0;
            btnVerSenha.FlatStyle = FlatStyle.Flat;
            btnVerSenha.Font = new Font("Segoe UI", 10F);
            btnVerSenha.Location = new Point(214, 164);
            btnVerSenha.Name = "btnVerSenha";
            btnVerSenha.Size = new Size(31, 25);
            btnVerSenha.TabIndex = 10;
            btnVerSenha.Text = "👁️";
            btnVerSenha.TextAlign = ContentAlignment.TopCenter;
            btnVerSenha.UseVisualStyleBackColor = false;
            btnVerSenha.MouseDown += BtnVerSenha_MouseDown;
            btnVerSenha.MouseUp += BtnVerSenha_MouseUp;
            // 
            // BtnVerConfSenha
            // 
            BtnVerConfSenha.BackColor = Color.Transparent;
            BtnVerConfSenha.Cursor = Cursors.Hand;
            BtnVerConfSenha.FlatAppearance.BorderSize = 0;
            BtnVerConfSenha.FlatStyle = FlatStyle.Flat;
            BtnVerConfSenha.Font = new Font("Segoe UI", 10F);
            BtnVerConfSenha.Location = new Point(214, 216);
            BtnVerConfSenha.Name = "BtnVerConfSenha";
            BtnVerConfSenha.Size = new Size(31, 25);
            BtnVerConfSenha.TabIndex = 11;
            BtnVerConfSenha.Text = "👁️";
            BtnVerConfSenha.TextAlign = ContentAlignment.TopCenter;
            BtnVerConfSenha.UseVisualStyleBackColor = false;
            BtnVerConfSenha.MouseDown += BtnVerConfSenha_MouseDown;
            BtnVerConfSenha.MouseUp += BtnVerConfSenha_MouseUp;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(BtnVerConfSenha);
            Controls.Add(btnVerSenha);
            Controls.Add(LblTituloConfirmacaoSenha);
            Controls.Add(lblTituloSenha);
            Controls.Add(lblTituloUsername);
            Controls.Add(lblTituloNome);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmacaoSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            Controls.Add(txtNome);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private TextBox txtNome;
        private TextBox txtUsername;
        private TextBox txtSenha;
        private TextBox txtConfirmacaoSenha;
        private Button btnCadastrar;
        private Label lblTituloNome;
        private Label lblTituloUsername;
        private Label lblTituloSenha;
        private Label LblTituloConfirmacaoSenha;
        private Button btnVerSenha;
        private Button BtnVerConfSenha;
    }
}