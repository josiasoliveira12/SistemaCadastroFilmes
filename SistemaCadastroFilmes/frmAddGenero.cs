using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCadastroFilmes
{
    public partial class frmAddGenero : Form
    {
        public frmAddGenero()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)

        {
            frmCadastroFilmes formCad = new frmCadastroFilmes();
            formCad.ShowDialog();

            this.Close();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereGenero(txtAddNome.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Genero adicionado com sucesso!");
            txtAddNome.Clear();
            txtAddNome.Focus();
            
        }
    }
}
