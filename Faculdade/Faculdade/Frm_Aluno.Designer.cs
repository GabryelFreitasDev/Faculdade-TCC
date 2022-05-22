namespace Faculdade
{
    partial class Frm_Aluno
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
            this.Btn_insereAluno = new System.Windows.Forms.Button();
            this.Txb_nomeAluno = new System.Windows.Forms.TextBox();
            this.Txb_email = new System.Windows.Forms.TextBox();
            this.Txb_endereco = new System.Windows.Forms.TextBox();
            this.Txb_turma = new System.Windows.Forms.TextBox();
            this.MTxb_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.MTxb_contato = new System.Windows.Forms.MaskedTextBox();
            this.Mtxb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.MTxb_contatoParente = new System.Windows.Forms.MaskedTextBox();
            this.Cbx_Curso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_insereAluno
            // 
            this.Btn_insereAluno.Location = new System.Drawing.Point(500, 358);
            this.Btn_insereAluno.Name = "Btn_insereAluno";
            this.Btn_insereAluno.Size = new System.Drawing.Size(88, 24);
            this.Btn_insereAluno.TabIndex = 0;
            this.Btn_insereAluno.Text = "INSERIR";
            this.Btn_insereAluno.UseVisualStyleBackColor = true;
            this.Btn_insereAluno.Click += new System.EventHandler(this.Btn_insereAluno_Click);
            // 
            // Txb_nomeAluno
            // 
            this.Txb_nomeAluno.Location = new System.Drawing.Point(55, 47);
            this.Txb_nomeAluno.Name = "Txb_nomeAluno";
            this.Txb_nomeAluno.Size = new System.Drawing.Size(236, 20);
            this.Txb_nomeAluno.TabIndex = 1;
            // 
            // Txb_email
            // 
            this.Txb_email.Location = new System.Drawing.Point(55, 209);
            this.Txb_email.Name = "Txb_email";
            this.Txb_email.Size = new System.Drawing.Size(286, 20);
            this.Txb_email.TabIndex = 2;
            // 
            // Txb_endereco
            // 
            this.Txb_endereco.Location = new System.Drawing.Point(55, 254);
            this.Txb_endereco.Multiline = true;
            this.Txb_endereco.Name = "Txb_endereco";
            this.Txb_endereco.Size = new System.Drawing.Size(313, 35);
            this.Txb_endereco.TabIndex = 3;
            // 
            // Txb_turma
            // 
            this.Txb_turma.Location = new System.Drawing.Point(55, 295);
            this.Txb_turma.Name = "Txb_turma";
            this.Txb_turma.Size = new System.Drawing.Size(100, 20);
            this.Txb_turma.TabIndex = 4;
            // 
            // MTxb_dataNascimento
            // 
            this.MTxb_dataNascimento.Location = new System.Drawing.Point(55, 114);
            this.MTxb_dataNascimento.Mask = "00/00/0000";
            this.MTxb_dataNascimento.Name = "MTxb_dataNascimento";
            this.MTxb_dataNascimento.Size = new System.Drawing.Size(100, 20);
            this.MTxb_dataNascimento.TabIndex = 6;
            this.MTxb_dataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // MTxb_contato
            // 
            this.MTxb_contato.Location = new System.Drawing.Point(55, 157);
            this.MTxb_contato.Mask = "(00) 00000-0000";
            this.MTxb_contato.Name = "MTxb_contato";
            this.MTxb_contato.Size = new System.Drawing.Size(100, 20);
            this.MTxb_contato.TabIndex = 7;
            // 
            // Mtxb_cpf
            // 
            this.Mtxb_cpf.Location = new System.Drawing.Point(55, 88);
            this.Mtxb_cpf.Mask = "000,000,000-00";
            this.Mtxb_cpf.Name = "Mtxb_cpf";
            this.Mtxb_cpf.Size = new System.Drawing.Size(100, 20);
            this.Mtxb_cpf.TabIndex = 8;
            // 
            // MTxb_contatoParente
            // 
            this.MTxb_contatoParente.Location = new System.Drawing.Point(55, 183);
            this.MTxb_contatoParente.Mask = "(00) 00000-0000";
            this.MTxb_contatoParente.Name = "MTxb_contatoParente";
            this.MTxb_contatoParente.Size = new System.Drawing.Size(100, 20);
            this.MTxb_contatoParente.TabIndex = 9;
            // 
            // Cbx_Curso
            // 
            this.Cbx_Curso.FormattingEnabled = true;
            this.Cbx_Curso.Location = new System.Drawing.Point(55, 321);
            this.Cbx_Curso.Name = "Cbx_Curso";
            this.Cbx_Curso.Size = new System.Drawing.Size(636, 21);
            this.Cbx_Curso.TabIndex = 10;
            // 
            // Frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cbx_Curso);
            this.Controls.Add(this.MTxb_contatoParente);
            this.Controls.Add(this.Mtxb_cpf);
            this.Controls.Add(this.MTxb_contato);
            this.Controls.Add(this.MTxb_dataNascimento);
            this.Controls.Add(this.Txb_turma);
            this.Controls.Add(this.Txb_endereco);
            this.Controls.Add(this.Txb_email);
            this.Controls.Add(this.Txb_nomeAluno);
            this.Controls.Add(this.Btn_insereAluno);
            this.Name = "Frm_Aluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Frm_Aluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_insereAluno;
        private System.Windows.Forms.TextBox Txb_nomeAluno;
        private System.Windows.Forms.TextBox Txb_email;
        private System.Windows.Forms.TextBox Txb_endereco;
        private System.Windows.Forms.TextBox Txb_turma;
        private System.Windows.Forms.MaskedTextBox MTxb_dataNascimento;
        private System.Windows.Forms.MaskedTextBox MTxb_contato;
        private System.Windows.Forms.MaskedTextBox Mtxb_cpf;
        private System.Windows.Forms.MaskedTextBox MTxb_contatoParente;
        private System.Windows.Forms.ComboBox Cbx_Curso;
    }
}