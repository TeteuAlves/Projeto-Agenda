using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda.Controller;

namespace Projeto_Agenda
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }
        private void habilitarCadastro()
        {
            if (txtNome.Text.Length > 0 && txtUsuario.Text.Length > 0 && txtSenha.Text.Length >= 4 && txtRep.Text.Length >= 4 && txtSenha.Text == txtRep.Text)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void txtRep_TextChanged(object sender, EventArgs e)
        {
            habilitarCadastro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            UsuarioController usuarioController = new UsuarioController();
            bool resultado = usuarioController.AddUsuario(nome, usuario, senha);
            if (resultado)
            {
                MessageBox.Show("Cadastro feito com sucesso");
                this.Hide();
            }
        }
    }
}
