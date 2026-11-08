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
            tabControl1 = new TabControl();
            tabCadastro = new TabPage();
            btnCadastrar = new Button();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            txtDuracao = new TextBox();
            lblDuracao = new Label();
            txtAno = new TextBox();
            lblAno = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblTitulo = new Label();
            tabBuscar = new TabPage();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            dgvFilmes = new DataGridView();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            tabControl1.SuspendLayout();
            tabCadastro.SuspendLayout();
            tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCadastro);
            tabControl1.Controls.Add(tabBuscar);
            tabControl1.Location = new Point(-2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 461);
            tabControl1.TabIndex = 10;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(btnCadastrar);
            tabCadastro.Controls.Add(cmbGenero);
            tabCadastro.Controls.Add(lblGenero);
            tabCadastro.Controls.Add(txtDuracao);
            tabCadastro.Controls.Add(lblDuracao);
            tabCadastro.Controls.Add(txtAno);
            tabCadastro.Controls.Add(lblAno);
            tabCadastro.Controls.Add(txtNome);
            tabCadastro.Controls.Add(lblNome);
            tabCadastro.Controls.Add(lblTitulo);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(781, 433);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastrar";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = true;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Green;
            btnCadastrar.Location = new Point(328, 379);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 31);
            btnCadastrar.TabIndex = 19;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(328, 296);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(190, 23);
            cmbGenero.TabIndex = 18;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGenero.Location = new Point(171, 298);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 21);
            lblGenero.TabIndex = 17;
            lblGenero.Text = "Gênero:";
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(328, 228);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(216, 23);
            txtDuracao.TabIndex = 16;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDuracao.Location = new Point(124, 226);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(157, 21);
            lblDuracao.TabIndex = 15;
            lblDuracao.Text = "Duração (minutos):";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(328, 158);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(216, 23);
            txtAno.TabIndex = 14;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAno.Location = new Point(191, 158);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(45, 21);
            lblAno.TabIndex = 13;
            lblAno.Text = "Ano:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(328, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(329, 23);
            txtNome.TabIndex = 12;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(155, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(126, 27);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome do filme:";
            lblNome.UseCompatibleTextRendering = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(301, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 30);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "CADASTRO DE FILMES";
            // 
            // tabBuscar
            // 
            tabBuscar.Controls.Add(btnAtualizar);
            tabBuscar.Controls.Add(btnDeletar);
            tabBuscar.Controls.Add(dgvFilmes);
            tabBuscar.Controls.Add(txtBuscar);
            tabBuscar.Controls.Add(lblBuscar);
            tabBuscar.Location = new Point(4, 24);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Padding = new Padding(3);
            tabBuscar.Size = new Size(781, 433);
            tabBuscar.TabIndex = 1;
            tabBuscar.Text = "Buscar";
            tabBuscar.UseVisualStyleBackColor = true;
            tabBuscar.Click += tabBuscar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizar.Location = new Point(648, 30);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += button2_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletar.Location = new Point(567, 30);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += button1_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AllowUserToAddRows = false;
            dgvFilmes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Location = new Point(142, 84);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.RowTemplate.ReadOnly = true;
            dgvFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmes.Size = new Size(523, 282);
            dgvFilmes.TabIndex = 3;
            dgvFilmes.CellContentClick += dgvFilmes_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(270, 30);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(291, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(142, 30);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(93, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Nome do filme:";
            lblBuscar.Click += lblBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Filmes";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            tabBuscar.ResumeLayout(false);
            tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl TabControl;
        private TabPage tabCadastro;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabBuscar;
        private Button btnCadastrar;
        private ComboBox cmbGenero;
        private Label lblGenero;
        private TextBox txtDuracao;
        private Label lblDuracao;
        private TextBox txtAno;
        private Label lblAno;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTitulo;
        private Label lblBuscar;
        private DataGridView dgvFilmes;
        private TextBox txtBuscar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
