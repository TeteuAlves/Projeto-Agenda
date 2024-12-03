using Projeto_Agenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }
        private void AtualizaDataGrid()
        {
            ContatoController controller = new ContatoController();
            DataTable tabela = controller.GetContatos();
            dgvContatos.DataSource = tabela;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            DataTable tabela = controller.GetCategorias();
            txtCategoria.DataSource = tabela;
            txtCategoria.DisplayMember = "Categoria";

            AtualizaDataGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ContatoController contatoController = new ContatoController();

            bool resultado = contatoController.AddContato(txtContato.Text, txtTelefone.Text, txtCategoria.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro feito com sucesso");
            }
            else
            {
                MessageBox.Show("Houve um erro");
            }

            DataTable tabela = contatoController.GetContatos();

            dgvContatos.DataSource = tabela;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
                ContatoController contatoController = new ContatoController();
                bool resultado = contatoController.ExContato(codigo);
                if (resultado)
                {
                    MessageBox.Show("Exclusão feita com sucesso!");
                    AtualizaDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir sua categoria");
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                
                int codigo = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells[0].Value);
                
                string novoContato = txtContato.Text;
                string novoTelefone = txtTelefone.Text;
                string novaCategoria = txtCategoria.Text;
                ContatoController contatoController = new ContatoController();
                
                bool resultado = contatoController.UpdateContato(codigo, novoContato, novoTelefone, novaCategoria);
                if (resultado)
                {
                    MessageBox.Show("Alteração feita com sucesso!");
                    AtualizaDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o contato");
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.");
            }
            AtualizaDataGrid();

        }
    }

}
    
