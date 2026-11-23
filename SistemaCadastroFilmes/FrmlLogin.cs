using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCadastroFilmes
{
    public partial class FrmlLogin : Form
    {
        public FrmlLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();

            if (conecta.verifica(txtUserLogin.Text, txtUserLogin.Text) == true)
            {
                frmCadastroFilmes sis = new frmCadastroFilmes();
                this.Hide();
                sis.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretas!" + conecta.mensagem);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
