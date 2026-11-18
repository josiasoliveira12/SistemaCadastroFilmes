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
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(617, 28);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 22;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(215, 132);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(329, 23);
            txtUserLogin.TabIndex = 23;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(215, 198);
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
            btnLogin.Location = new Point(395, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 31);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "Acessar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmlLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmlLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmlLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtUserLogin;
        private TextBox txtSenhaLogin;
        private Button btnLogin;
    }
}