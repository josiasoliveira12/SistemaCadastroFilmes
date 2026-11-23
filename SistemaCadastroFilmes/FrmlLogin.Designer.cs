namespace SistemaCadastroFilmes
{
    partial class FrmlLogin
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
            btnFechar = new Button();
            txtUserLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(640, 23);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 22;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(226, 168);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(329, 23);
            txtUserLogin.TabIndex = 23;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(226, 234);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.Size = new Size(329, 23);
            txtSenhaLogin.TabIndex = 24;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(316, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 31);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "Acessar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(121, 163);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 26;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(136, 226);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 27;
            label2.Text = "Senha: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(316, 86);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 28;
            label3.Text = "Login";
            // 
            // FrmlLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 353);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmlLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineManager - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtUserLogin;
        private TextBox txtSenhaLogin;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}