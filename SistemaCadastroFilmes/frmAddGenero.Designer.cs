namespace SistemaCadastroFilmes
{
    partial class frmAddGenero
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
            label1 = new Label();
            txtAddNome = new TextBox();
            lblNome = new Label();
            btnCadastrar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(115, 30);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Genero";
            // 
            // txtAddNome
            // 
            txtAddNome.Location = new Point(115, 118);
            txtAddNome.Name = "txtAddNome";
            txtAddNome.Size = new Size(329, 23);
            txtAddNome.TabIndex = 14;
            // 
            // lblNome
            // 
            lblNome.AccessibleRole = AccessibleRole.Alert;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(20, 118);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(66, 27);
            lblNome.TabIndex = 13;
            lblNome.Text = "Genero:";
            lblNome.UseCompatibleTextRendering = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Green;
            btnCadastrar.Location = new Point(205, 167);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 31);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(369, 39);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 21;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmAddGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 242);
            Controls.Add(btnFechar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtAddNome);
            Controls.Add(lblNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddGenero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddGenero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddNome;
        private Label lblNome;
        private Button btnCadastrar;
        private Button btnFechar;
    }
}