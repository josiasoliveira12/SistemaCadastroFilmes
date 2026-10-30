namespace SistemaCadastroFilmes
{
    partial class Form1
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
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblAno = new Label();
            txtAno = new TextBox();
            lblDuracao = new Label();
            txtDuracao = new TextBox();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(231, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CADASTRO DE FILMES";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(85, 106);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(126, 27);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome do filme:";
            lblNome.UseCompatibleTextRendering = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(258, 106);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(329, 23);
            txtNome.TabIndex = 2;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAno.Location = new Point(121, 159);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(45, 21);
            lblAno.TabIndex = 3;
            lblAno.Text = "Ano:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(258, 159);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(216, 23);
            txtAno.TabIndex = 4;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDuracao.Location = new Point(54, 227);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(157, 21);
            lblDuracao.TabIndex = 5;
            lblDuracao.Text = "Duração (minutos):";
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(258, 229);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(216, 23);
            txtDuracao.TabIndex = 6;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGenero.Location = new Point(101, 299);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 21);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Gênero:";
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(258, 297);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(190, 23);
            cmbGenero.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Green;
            btnCadastrar.Location = new Point(258, 380);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 31);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtDuracao);
            Controls.Add(lblDuracao);
            Controls.Add(txtAno);
            Controls.Add(lblAno);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Filmes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblAno;
        private TextBox txtAno;
        private Label lblDuracao;
        private TextBox txtDuracao;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private Button btnCadastrar;
    }
}
