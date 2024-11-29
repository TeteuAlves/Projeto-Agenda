namespace Projeto_Agenda
{
    partial class frmSenha
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
            dgvSenha = new DataGridView();
            groupBox1 = new GroupBox();
            btnAlterSenha = new Button();
            txtNovaSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSenha).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSenha
            // 
            dgvSenha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSenha.Location = new Point(23, 37);
            dgvSenha.Name = "dgvSenha";
            dgvSenha.Size = new Size(324, 185);
            dgvSenha.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNovaSenha);
            groupBox1.Controls.Add(btnAlterSenha);
            groupBox1.Location = new Point(373, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 154);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira a nova senha";
            // 
            // btnAlterSenha
            // 
            btnAlterSenha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterSenha.Location = new Point(23, 94);
            btnAlterSenha.Name = "btnAlterSenha";
            btnAlterSenha.Size = new Size(174, 45);
            btnAlterSenha.TabIndex = 0;
            btnAlterSenha.Text = "Alterar";
            btnAlterSenha.UseVisualStyleBackColor = true;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(6, 33);
            txtNovaSenha.Multiline = true;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(207, 43);
            txtNovaSenha.TabIndex = 1;
            // 
            // frmSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 251);
            Controls.Add(groupBox1);
            Controls.Add(dgvSenha);
            Name = "frmSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Senha";
            ((System.ComponentModel.ISupportInitialize)dgvSenha).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSenha;
        private GroupBox groupBox1;
        private TextBox txtNovaSenha;
        private Button btnAlterSenha;
    }
}