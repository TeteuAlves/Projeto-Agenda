namespace Projeto_Agenda
{
    partial class frmCadastrar
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
            btnCadastrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtRep = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(4, 289);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(132, 34);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(142, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 34);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(195, 37);
            label3.TabIndex = 4;
            label3.Text = "Repetir Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(116, 37);
            label4.TabIndex = 5;
            label4.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 181);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(255, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(255, 23);
            txtNome.TabIndex = 7;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtRep
            // 
            txtRep.Location = new Point(12, 247);
            txtRep.Name = "txtRep";
            txtRep.Size = new Size(255, 23);
            txtRep.TabIndex = 8;
            txtRep.TextChanged += txtRep_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 115);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(255, 23);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // frmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 334);
            Controls.Add(txtUsuario);
            Controls.Add(txtRep);
            Controls.Add(txtNome);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Name = "frmCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosed += frmCadastrar_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtRep;
        private TextBox txtUsuario;
    }
}