namespace Projeto_Agenda
{
    partial class frmCategorias
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
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnCriar = new Button();
            txtCategoria = new TextBox();
            dgvCategorias = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(239, 68);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 81);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(25, 102);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(149, 37);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            btnCriar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.Location = new Point(25, 59);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(149, 37);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 30);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(188, 23);
            txtCategoria.TabIndex = 3;
            txtCategoria.TextChanged += textBox1_TextChanged;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(357, 34);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(240, 150);
            dgvCategorias.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnCriar);
            groupBox1.Location = new Point(24, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 153);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da Categoria";
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 216);
            Controls.Add(groupBox1);
            Controls.Add(dgvCategorias);
            Controls.Add(btnExcluir);
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnCriar;
        private TextBox txtCategoria;
        private DataGridView dgvCategorias;
        private GroupBox groupBox1;
    }
}