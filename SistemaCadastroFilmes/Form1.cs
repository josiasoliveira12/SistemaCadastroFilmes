using System.Data;

namespace SistemaCadastroFilmes
{
    public partial class frmCadastroFilmes : Form
    {
        int idAlterar;
        public frmCadastroFilmes()
        {
            InitializeComponent();
        }

        void limpaCampos()
        {
            txtNome.Clear();
            cmbGenero.Text = "";
            txtAno.Clear();
            txtDuracao.Clear();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ConectaBanco con = new ConectaBanco();
            Filme novoFilme = new Filme();
            novoFilme.Nome = txtNome.Text;
            novoFilme.Ano = Convert.ToInt32(txtAno.Text);
            novoFilme.Duracao = Convert.ToInt32(txtDuracao.Text);
            novoFilme.Genero = Convert.ToInt32(cmbGenero.SelectedValue.ToString());

            bool retorno = con.insereFilme(novoFilme);
            if (retorno == false)
            {

                MessageBox.Show(con.mensagem);

            }
            limpaCampos();
            lista_gridFilmes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCBGeneros();
            lista_gridFilmes();
        }

        void lista_gridFilmes()
        {
            ConectaBanco con = new ConectaBanco();
            dgvFilmes.DataSource = con.listaFilmes();
            dgvFilmes.Columns["idfilme"].Visible = false;


        }

        public void listaCBGeneros()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaGeneros();
            cmbGenero.DataSource = tabelaDados;
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "idgenero";

            cmbAlterarGenero.DataSource = tabelaDados;
            cmbAlterarGenero.DisplayMember = "genero";
            cmbAlterarGenero.ValueMember = "idgenero";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tabBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            (dgvFilmes.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("titulo like '{0}%'", txtBuscar.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int linha = dgvFilmes.CurrentRow.Index;

            int id = Convert.ToInt32(
                dgvFilmes.Rows[linha].Cells["idfilme"].Value.ToString());

            DialogResult resp = MessageBox.Show(
                "Tem certeza que deseja excluir?",
                "Remove Filme",
                MessageBoxButtons.OKCancel);

            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();

                bool retorno = con.deletaFilme(id);

                if (retorno == true)
                {
                    MessageBox.Show("Filme excluído com sucesso!");
                    lista_gridFilmes();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Exclusão cancelada");






        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linha = dgvFilmes.CurrentRow.Index;

            idAlterar = Convert.ToInt32(
                dgvFilmes.Rows[linha].Cells["idfilme"].Value.ToString());

            txtAlterarNome.Text =
                dgvFilmes.Rows[linha].Cells["titulo"].Value.ToString();

            txtAlterarAno.Text =
                dgvFilmes.Rows[linha].Cells["ano"].Value.ToString();

            txtAlterarDuracao.Text =
                dgvFilmes.Rows[linha].Cells["duracao"].Value.ToString();

            cmbAlterarGenero.Text =
                dgvFilmes.Rows[linha].Cells["genero"].Value.ToString();

            tabControl1.SelectedTab = tabAlterar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Filme novoFilme = new Filme();
            novoFilme.Nome = txtAlterarNome.Text;
            novoFilme.Ano = Convert.ToInt32(txtAlterarAno.Text);
            novoFilme.Duracao = Convert.ToInt32(txtAlterarDuracao.Text);
            novoFilme.Genero = Convert.ToInt32(cmbAlterarGenero.SelectedValue.ToString());

            bool retorno = con.alteraFilme(novoFilme, idAlterar);
            if (retorno == false)
            {

                MessageBox.Show(con.mensagem);

            }
            else
            {
                MessageBox.Show("Alteração realizada com sucesso!");
            }

            lista_gridFilmes();
        }

        private void btnAdicionarGenero_Click(object sender, EventArgs e)
        {
           
            frmAddGenero formGenero = new frmAddGenero();
            this.Hide();
            formGenero.ShowDialog();
            this.Close();
           

        }
    }
}
