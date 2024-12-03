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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void AtualizaDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategorias.DataSource = tabela;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(txtCategoria.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro feito com sucesso");
                AtualizaDataGrid();
            }
            else
            {
                MessageBox.Show("Houve um erro");
            }

            DataTable tabela = controleCategoria.GetCategorias();

            dgvCategorias.DataSource = tabela;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            { 
                int codigo = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value); 
                string novo_nome = txtCategoria.Text;
                CategoriaController controleCategoria = new CategoriaController();
                bool resultado = controleCategoria.UpdateCategoria(codigo, novo_nome);
                if (resultado)
                { 
                    MessageBox.Show("Alteração feita com sucesso!");
                    AtualizaDataGrid();
                } 
                else 
                { 
                    MessageBox.Show("Erro ao alterar sua categoria");
                } }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0) 
            { 
                int codigo = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value);
                CategoriaController controleCategoria = new CategoriaController();
                bool resultado = controleCategoria.ExCategoria(codigo); 
                if (resultado) 
                { 
                    MessageBox.Show("Exclusão feita com sucesso!");
                    AtualizaDataGrid();
                } 
                else 
                {
                    MessageBox.Show("Erro ao excluir sua categoria");
                } 
            } else 
                { 
                MessageBox.Show("Nenhuma linha selecionada.");
                }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }
    }
}
