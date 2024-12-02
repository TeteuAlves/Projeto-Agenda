namespace Projeto_Agenda
{
    partial class frmContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            dgvUsuarios = new DataGridView();
            txtCategoria = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Contato:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 127);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            label3.Click += label3_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 101);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(224, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(6, 47);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(226, 23);
            txtContato.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(10, 197);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(88, 39);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(10, 242);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(220, 38);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(141, 197);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 39);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(35, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 286);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Contato";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(293, 36);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(489, 276);
            dgvUsuarios.TabIndex = 10;
            // 
            // txtCategoria
            // 
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Location = new Point(6, 155);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(222, 23);
            txtCategoria.TabIndex = 9;
            // 
            // frmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 340);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox1);
            Name = "frmContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contatos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private DataGridView dgvUsuarios;
        private ComboBox txtCategoria;
    }
}