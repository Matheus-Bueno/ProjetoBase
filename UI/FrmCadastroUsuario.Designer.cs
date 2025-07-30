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
            button1 = new Button();
            txtNome = new TextBox();
            txtUsername = new TextBox();
            txtSenha = new TextBox();
            txtConfirmacaoSenha = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            lblTituloUsername = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVerSenha = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(196, 345);
            button1.Name = "button1";
            button1.Size = new Size(92, 43);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(32, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 6;
            label1.Text = "Nome";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 8;
            label3.Text = "Digite sua senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(32, 193);
            label4.Name = "label4";
            label4.Size = new Size(183, 19);
            label4.TabIndex = 9;
            label4.Text = "Digite sua senha novamente";
            // 
            // btnVerSenha
            // 
            btnVerSenha.Font = new Font("Segoe UI", 10F);
            btnVerSenha.Location = new Point(251, 164);
            btnVerSenha.Name = "btnVerSenha";
            btnVerSenha.Size = new Size(31, 25);
            btnVerSenha.TabIndex = 10;
            btnVerSenha.Text = "👁️";
            btnVerSenha.TextAlign = ContentAlignment.TopCenter;
            btnVerSenha.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(251, 216);
            button2.Name = "button2";
            button2.Size = new Size(31, 25);
            button2.TabIndex = 11;
            button2.Text = "👁️";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(button2);
            Controls.Add(btnVerSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTituloUsername);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmacaoSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsername);
            Controls.Add(txtNome);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNome;
        private TextBox txtUsername;
        private TextBox txtSenha;
        private TextBox txtConfirmacaoSenha;
        private Button btnCadastrar;
        private Label label1;
        private Label lblTituloUsername;
        private Label label3;
        private Label label4;
        private Button btnVerSenha;
        private Button button2;
    }
}