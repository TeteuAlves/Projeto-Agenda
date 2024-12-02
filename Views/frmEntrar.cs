using Projeto_Agenda.Controller;

namespace Projeto_Agenda
{
    public partial class frmEntrar : Form
    {
        public frmEntrar()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length >= 4)
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar fmrcadastro = new frmCadastrar();
            fmrcadastro.ShowDialog();
        }

        private void frmEntrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_EnabledChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string txt_usuario = txtUsuario.Text;

            string txt_senha = txtSenha.Text;

            UsuarioController controleUsuario = new UsuarioController();

            bool resultado = controleUsuario.LoginUsuario(txt_usuario, txt_senha);

            if (resultado == true)
            {

                frmPrincipal fmrPrinci = new frmPrincipal();
                this.Hide();
                fmrPrinci.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Usuario não encontrado");
            }
        }
    }
}
