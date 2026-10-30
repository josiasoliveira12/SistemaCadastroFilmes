namespace SistemaCadastroFilmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ConectaBanco con = new ConectaBanco();
            Filme novoFilme = new Filme();
            novoFilme.Nome = txtNome.Text;
            novoFilme.Ano = Convert.ToInt32(txtAno.Text);
            novoFilme.Duracao = Convert.ToInt32(txtDuracao.Text);
            novoFilme.Genero = 1;

            bool retorno = con.insereFilme(novoFilme);
            if (retorno == false) {

                MessageBox.Show(con.mensagem);
            
            }

        }
    }
}
