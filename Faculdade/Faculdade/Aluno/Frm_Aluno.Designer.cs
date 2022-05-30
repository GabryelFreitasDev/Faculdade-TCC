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
            this.Dgv_aluno = new System.Windows.Forms.DataGridView();
            this.Lbl_acao = new System.Windows.Forms.Label();
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.Lbl_nomeAlterar = new System.Windows.Forms.Label();
            this.Txb_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Btn_editaAluno = new System.Windows.Forms.Button();
            this.Btn_excluiAluno = new System.Windows.Forms.Button();
            this.Btn_relatorio = new System.Windows.Forms.Button();
            this.Cbx_Curso = new System.Windows.Forms.ComboBox();
            this.MTxb_contatoParente = new System.Windows.Forms.MaskedTextBox();
            this.Mtxb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.MTxb_contato = new System.Windows.Forms.MaskedTextBox();
            this.MTxb_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Txb_endereco = new System.Windows.Forms.TextBox();
            this.Txb_email = new System.Windows.Forms.TextBox();
            this.Txb_nomeAluno = new System.Windows.Forms.TextBox();
            this.Btn_insereAluno = new System.Windows.Forms.Button();
            this.Lbl_cpf = new System.Windows.Forms.Label();
            this.Lbl_dataNascimento = new System.Windows.Forms.Label();
            this.Lbl_contatoAluno = new System.Windows.Forms.Label();
            this.Lbl_contatoParente = new System.Windows.Forms.Label();
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Lbl_turma = new System.Windows.Forms.Label();
            this.Lbl_cursoAluno = new System.Windows.Forms.Label();
            this.Lbl_endereco = new System.Windows.Forms.Label();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Txb_buscaNome = new System.Windows.Forms.TextBox();
            this.Lbl_buscaNome = new System.Windows.Forms.Label();
            this.Cbx_buscaCurso = new System.Windows.Forms.ComboBox();
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Lbl_buscaCurso = new System.Windows.Forms.Label();
            this.Lbl_operacaoEscolha = new System.Windows.Forms.Label();
            this.Cbx_turmaAluno = new System.Windows.Forms.ComboBox();
            this.Lbl_disponivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_aluno
            // 
            this.Dgv_aluno.AllowUserToAddRows = false;
            this.Dgv_aluno.AllowUserToDeleteRows = false;
            this.Dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aluno.Location = new System.Drawing.Point(76, 53);
            this.Dgv_aluno.Name = "Dgv_aluno";
            this.Dgv_aluno.ReadOnly = true;
            this.Dgv_aluno.Size = new System.Drawing.Size(993, 283);
            this.Dgv_aluno.TabIndex = 11;
            this.Dgv_aluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Alunos_CellContentClick);
            // 
            // Lbl_acao
            // 
            this.Lbl_acao.AutoSize = true;
            this.Lbl_acao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Lbl_acao.Location = new System.Drawing.Point(67, 339);
            this.Lbl_acao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_acao.Name = "Lbl_acao";
            this.Lbl_acao.Size = new System.Drawing.Size(126, 31);
            this.Lbl_acao.TabIndex = 55;
            this.Lbl_acao.Text = "INSERIR";
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Location = new System.Drawing.Point(70, 412);
            this.Lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(82, 13);
            this.Lbl_nome.TabIndex = 54;
            this.Lbl_nome.Text = "Nome do aluno:";
            // 
            // Lbl_nomeAlterar
            // 
            this.Lbl_nomeAlterar.AutoSize = true;
            this.Lbl_nomeAlterar.Location = new System.Drawing.Point(73, 371);
            this.Lbl_nomeAlterar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nomeAlterar.Name = "Lbl_nomeAlterar";
            this.Lbl_nomeAlterar.Size = new System.Drawing.Size(173, 13);
            this.Lbl_nomeAlterar.TabIndex = 53;
            this.Lbl_nomeAlterar.Text = "Nome do aluno que está alterando:";
            // 
            // Txb_nomeAlterar
            // 
            this.Txb_nomeAlterar.Location = new System.Drawing.Point(73, 387);
            this.Txb_nomeAlterar.Name = "Txb_nomeAlterar";
            this.Txb_nomeAlterar.Size = new System.Drawing.Size(236, 20);
            this.Txb_nomeAlterar.TabIndex = 52;
            // 
            // Btn_editaAluno
            // 
            this.Btn_editaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_editaAluno.Location = new System.Drawing.Point(946, 458);
            this.Btn_editaAluno.Name = "Btn_editaAluno";
            this.Btn_editaAluno.Size = new System.Drawing.Size(75, 23);
            this.Btn_editaAluno.TabIndex = 51;
            this.Btn_editaAluno.Text = "EDITAR";
            this.Btn_editaAluno.UseVisualStyleBackColor = true;
            this.Btn_editaAluno.Click += new System.EventHandler(this.Btn_editaAluno_Click);
            // 
            // Btn_excluiAluno
            // 
            this.Btn_excluiAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_excluiAluno.Location = new System.Drawing.Point(1047, 458);
            this.Btn_excluiAluno.Name = "Btn_excluiAluno";
            this.Btn_excluiAluno.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluiAluno.TabIndex = 50;
            this.Btn_excluiAluno.Text = "EXCLUIR";
            this.Btn_excluiAluno.UseVisualStyleBackColor = true;
            this.Btn_excluiAluno.Click += new System.EventHandler(this.Btn_excluiAluno_Click_1);
            // 
            // Btn_relatorio
            // 
            this.Btn_relatorio.Location = new System.Drawing.Point(949, 339);
            this.Btn_relatorio.Name = "Btn_relatorio";
            this.Btn_relatorio.Size = new System.Drawing.Size(120, 23);
            this.Btn_relatorio.TabIndex = 49;
            this.Btn_relatorio.Text = "RELATORIO";
            this.Btn_relatorio.UseVisualStyleBackColor = true;
            this.Btn_relatorio.Click += new System.EventHandler(this.Btn_relatorio_Click);
            // 
            // Cbx_Curso
            // 
            this.Cbx_Curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Curso.FormattingEnabled = true;
            this.Cbx_Curso.Location = new System.Drawing.Point(475, 429);
            this.Cbx_Curso.Name = "Cbx_Curso";
            this.Cbx_Curso.Size = new System.Drawing.Size(315, 21);
            this.Cbx_Curso.TabIndex = 48;
            this.Cbx_Curso.SelectedIndexChanged += new System.EventHandler(this.Cbx_Curso_SelectedIndexChanged);
            // 
            // MTxb_contatoParente
            // 
            this.MTxb_contatoParente.Location = new System.Drawing.Point(73, 535);
            this.MTxb_contatoParente.Mask = "(00) 00000-0000";
            this.MTxb_contatoParente.Name = "MTxb_contatoParente";
            this.MTxb_contatoParente.Size = new System.Drawing.Size(100, 20);
            this.MTxb_contatoParente.TabIndex = 47;
            // 
            // Mtxb_cpf
            // 
            this.Mtxb_cpf.Location = new System.Drawing.Point(342, 429);
            this.Mtxb_cpf.Mask = "000,000,000-00";
            this.Mtxb_cpf.Name = "Mtxb_cpf";
            this.Mtxb_cpf.Size = new System.Drawing.Size(100, 20);
            this.Mtxb_cpf.TabIndex = 46;
            // 
            // MTxb_contato
            // 
            this.MTxb_contato.Location = new System.Drawing.Point(218, 477);
            this.MTxb_contato.Mask = "(00) 00000-0000";
            this.MTxb_contato.Name = "MTxb_contato";
            this.MTxb_contato.Size = new System.Drawing.Size(100, 20);
            this.MTxb_contato.TabIndex = 45;
            // 
            // MTxb_dataNascimento
            // 
            this.MTxb_dataNascimento.Location = new System.Drawing.Point(73, 477);
            this.MTxb_dataNascimento.Mask = "00/00/0000";
            this.MTxb_dataNascimento.Name = "MTxb_dataNascimento";
            this.MTxb_dataNascimento.Size = new System.Drawing.Size(100, 20);
            this.MTxb_dataNascimento.TabIndex = 44;
            this.MTxb_dataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Txb_endereco
            // 
            this.Txb_endereco.Location = new System.Drawing.Point(218, 535);
            this.Txb_endereco.Multiline = true;
            this.Txb_endereco.Name = "Txb_endereco";
            this.Txb_endereco.Size = new System.Drawing.Size(437, 39);
            this.Txb_endereco.TabIndex = 42;
            // 
            // Txb_email
            // 
            this.Txb_email.Location = new System.Drawing.Point(342, 477);
            this.Txb_email.Name = "Txb_email";
            this.Txb_email.Size = new System.Drawing.Size(313, 20);
            this.Txb_email.TabIndex = 41;
            // 
            // Txb_nomeAluno
            // 
            this.Txb_nomeAluno.Location = new System.Drawing.Point(73, 428);
            this.Txb_nomeAluno.Name = "Txb_nomeAluno";
            this.Txb_nomeAluno.Size = new System.Drawing.Size(236, 20);
            this.Txb_nomeAluno.TabIndex = 40;
            // 
            // Btn_insereAluno
            // 
            this.Btn_insereAluno.Location = new System.Drawing.Point(848, 457);
            this.Btn_insereAluno.Name = "Btn_insereAluno";
            this.Btn_insereAluno.Size = new System.Drawing.Size(75, 23);
            this.Btn_insereAluno.TabIndex = 39;
            this.Btn_insereAluno.Text = "INSERIR";
            this.Btn_insereAluno.UseVisualStyleBackColor = true;
            this.Btn_insereAluno.Click += new System.EventHandler(this.Btn_insereAluno_Click_1);
            // 
            // Lbl_cpf
            // 
            this.Lbl_cpf.AutoSize = true;
            this.Lbl_cpf.Location = new System.Drawing.Point(339, 416);
            this.Lbl_cpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cpf.Name = "Lbl_cpf";
            this.Lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.Lbl_cpf.TabIndex = 56;
            this.Lbl_cpf.Text = "CPF:";
            // 
            // Lbl_dataNascimento
            // 
            this.Lbl_dataNascimento.AutoSize = true;
            this.Lbl_dataNascimento.Location = new System.Drawing.Point(70, 461);
            this.Lbl_dataNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_dataNascimento.Name = "Lbl_dataNascimento";
            this.Lbl_dataNascimento.Size = new System.Drawing.Size(105, 13);
            this.Lbl_dataNascimento.TabIndex = 57;
            this.Lbl_dataNascimento.Text = "Data de nascimento:";
            // 
            // Lbl_contatoAluno
            // 
            this.Lbl_contatoAluno.AutoSize = true;
            this.Lbl_contatoAluno.Location = new System.Drawing.Point(218, 461);
            this.Lbl_contatoAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_contatoAluno.Name = "Lbl_contatoAluno";
            this.Lbl_contatoAluno.Size = new System.Drawing.Size(91, 13);
            this.Lbl_contatoAluno.TabIndex = 58;
            this.Lbl_contatoAluno.Text = "Contato do aluno:";
            // 
            // Lbl_contatoParente
            // 
            this.Lbl_contatoParente.AutoSize = true;
            this.Lbl_contatoParente.Location = new System.Drawing.Point(70, 519);
            this.Lbl_contatoParente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_contatoParente.Name = "Lbl_contatoParente";
            this.Lbl_contatoParente.Size = new System.Drawing.Size(132, 13);
            this.Lbl_contatoParente.TabIndex = 59;
            this.Lbl_contatoParente.Text = "Contato de algum parente:";
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Location = new System.Drawing.Point(339, 461);
            this.Lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(35, 13);
            this.Lbl_email.TabIndex = 60;
            this.Lbl_email.Text = "Email:";
            // 
            // Lbl_turma
            // 
            this.Lbl_turma.AutoSize = true;
            this.Lbl_turma.Location = new System.Drawing.Point(687, 461);
            this.Lbl_turma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turma.Name = "Lbl_turma";
            this.Lbl_turma.Size = new System.Drawing.Size(40, 13);
            this.Lbl_turma.TabIndex = 61;
            this.Lbl_turma.Text = "Turma:";
            // 
            // Lbl_cursoAluno
            // 
            this.Lbl_cursoAluno.AutoSize = true;
            this.Lbl_cursoAluno.Location = new System.Drawing.Point(472, 412);
            this.Lbl_cursoAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cursoAluno.Name = "Lbl_cursoAluno";
            this.Lbl_cursoAluno.Size = new System.Drawing.Size(37, 13);
            this.Lbl_cursoAluno.TabIndex = 62;
            this.Lbl_cursoAluno.Text = "Curso:";
            // 
            // Lbl_endereco
            // 
            this.Lbl_endereco.AutoSize = true;
            this.Lbl_endereco.Location = new System.Drawing.Point(215, 519);
            this.Lbl_endereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_endereco.Name = "Lbl_endereco";
            this.Lbl_endereco.Size = new System.Drawing.Size(56, 13);
            this.Lbl_endereco.TabIndex = 63;
            this.Lbl_endereco.Text = "Endereço:";
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_limpar.Location = new System.Drawing.Point(1033, 541);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpar.TabIndex = 64;
            this.Btn_limpar.Text = "LIMPAR";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Txb_buscaNome
            // 
            this.Txb_buscaNome.Location = new System.Drawing.Point(73, 25);
            this.Txb_buscaNome.Name = "Txb_buscaNome";
            this.Txb_buscaNome.Size = new System.Drawing.Size(441, 20);
            this.Txb_buscaNome.TabIndex = 65;
            this.Txb_buscaNome.TextChanged += new System.EventHandler(this.Txb_buscaNome_TextChanged);
            // 
            // Lbl_buscaNome
            // 
            this.Lbl_buscaNome.AutoSize = true;
            this.Lbl_buscaNome.Location = new System.Drawing.Point(70, 9);
            this.Lbl_buscaNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_buscaNome.Name = "Lbl_buscaNome";
            this.Lbl_buscaNome.Size = new System.Drawing.Size(119, 13);
            this.Lbl_buscaNome.TabIndex = 66;
            this.Lbl_buscaNome.Text = "Digite o nome do aluno:";
            // 
            // Cbx_buscaCurso
            // 
            this.Cbx_buscaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaCurso.FormattingEnabled = true;
            this.Cbx_buscaCurso.Location = new System.Drawing.Point(677, 24);
            this.Cbx_buscaCurso.Name = "Cbx_buscaCurso";
            this.Cbx_buscaCurso.Size = new System.Drawing.Size(286, 21);
            this.Cbx_buscaCurso.TabIndex = 67;
            this.Cbx_buscaCurso.SelectedIndexChanged += new System.EventHandler(this.Cbx_buscaCurso_SelectedIndexChanged);
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(969, 22);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(97, 23);
            this.Btn_LimparFiltro.TabIndex = 68;
            this.Btn_LimparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Lbl_buscaCurso
            // 
            this.Lbl_buscaCurso.AutoSize = true;
            this.Lbl_buscaCurso.Location = new System.Drawing.Point(674, 8);
            this.Lbl_buscaCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_buscaCurso.Name = "Lbl_buscaCurso";
            this.Lbl_buscaCurso.Size = new System.Drawing.Size(79, 13);
            this.Lbl_buscaCurso.TabIndex = 69;
            this.Lbl_buscaCurso.Text = "Filtre por curso:";
            // 
            // Lbl_operacaoEscolha
            // 
            this.Lbl_operacaoEscolha.AutoSize = true;
            this.Lbl_operacaoEscolha.Location = new System.Drawing.Point(934, 420);
            this.Lbl_operacaoEscolha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_operacaoEscolha.Name = "Lbl_operacaoEscolha";
            this.Lbl_operacaoEscolha.Size = new System.Drawing.Size(102, 13);
            this.Lbl_operacaoEscolha.TabIndex = 70;
            this.Lbl_operacaoEscolha.Text = "O que deseja fazer?";
            // 
            // Cbx_turmaAluno
            // 
            this.Cbx_turmaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_turmaAluno.FormattingEnabled = true;
            this.Cbx_turmaAluno.Location = new System.Drawing.Point(690, 476);
            this.Cbx_turmaAluno.Name = "Cbx_turmaAluno";
            this.Cbx_turmaAluno.Size = new System.Drawing.Size(100, 21);
            this.Cbx_turmaAluno.TabIndex = 71;
            // 
            // Lbl_disponivel
            // 
            this.Lbl_disponivel.AutoSize = true;
            this.Lbl_disponivel.ForeColor = System.Drawing.Color.Red;
            this.Lbl_disponivel.Location = new System.Drawing.Point(687, 500);
            this.Lbl_disponivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_disponivel.Name = "Lbl_disponivel";
            this.Lbl_disponivel.Size = new System.Drawing.Size(161, 26);
            this.Lbl_disponivel.TabIndex = 72;
            this.Lbl_disponivel.Text = "Infelizmente o curso selecionado\r\n não possui turmas disponíveis";
            // 
            // Frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.Lbl_disponivel);
            this.Controls.Add(this.Cbx_turmaAluno);
            this.Controls.Add(this.Lbl_operacaoEscolha);
            this.Controls.Add(this.Lbl_buscaCurso);
            this.Controls.Add(this.Btn_LimparFiltro);
            this.Controls.Add(this.Cbx_buscaCurso);
            this.Controls.Add(this.Lbl_buscaNome);
            this.Controls.Add(this.Txb_buscaNome);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Lbl_endereco);
            this.Controls.Add(this.Lbl_cursoAluno);
            this.Controls.Add(this.Lbl_turma);
            this.Controls.Add(this.Lbl_email);
            this.Controls.Add(this.Lbl_contatoParente);
            this.Controls.Add(this.Lbl_contatoAluno);
            this.Controls.Add(this.Lbl_dataNascimento);
            this.Controls.Add(this.Lbl_cpf);
            this.Controls.Add(this.Lbl_acao);
            this.Controls.Add(this.Lbl_nome);
            this.Controls.Add(this.Lbl_nomeAlterar);
            this.Controls.Add(this.Txb_nomeAlterar);
            this.Controls.Add(this.Btn_editaAluno);
            this.Controls.Add(this.Btn_excluiAluno);
            this.Controls.Add(this.Btn_relatorio);
            this.Controls.Add(this.Cbx_Curso);
            this.Controls.Add(this.MTxb_contatoParente);
            this.Controls.Add(this.Mtxb_cpf);
            this.Controls.Add(this.MTxb_contato);
            this.Controls.Add(this.MTxb_dataNascimento);
            this.Controls.Add(this.Txb_endereco);
            this.Controls.Add(this.Txb_email);
            this.Controls.Add(this.Txb_nomeAluno);
            this.Controls.Add(this.Btn_insereAluno);
            this.Controls.Add(this.Dgv_aluno);
            this.Name = "Frm_Aluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Frm_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_aluno;
        private System.Windows.Forms.Label Lbl_acao;
        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.Label Lbl_nomeAlterar;
        private System.Windows.Forms.TextBox Txb_nomeAlterar;
        private System.Windows.Forms.Button Btn_editaAluno;
        private System.Windows.Forms.Button Btn_excluiAluno;
        private System.Windows.Forms.Button Btn_relatorio;
        private System.Windows.Forms.ComboBox Cbx_Curso;
        private System.Windows.Forms.MaskedTextBox MTxb_contatoParente;
        private System.Windows.Forms.MaskedTextBox Mtxb_cpf;
        private System.Windows.Forms.MaskedTextBox MTxb_contato;
        private System.Windows.Forms.MaskedTextBox MTxb_dataNascimento;
        private System.Windows.Forms.TextBox Txb_endereco;
        private System.Windows.Forms.TextBox Txb_email;
        private System.Windows.Forms.TextBox Txb_nomeAluno;
        private System.Windows.Forms.Button Btn_insereAluno;
        private System.Windows.Forms.Label Lbl_cpf;
        private System.Windows.Forms.Label Lbl_dataNascimento;
        private System.Windows.Forms.Label Lbl_contatoAluno;
        private System.Windows.Forms.Label Lbl_contatoParente;
        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.Label Lbl_turma;
        private System.Windows.Forms.Label Lbl_cursoAluno;
        private System.Windows.Forms.Label Lbl_endereco;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.TextBox Txb_buscaNome;
        private System.Windows.Forms.Label Lbl_buscaNome;
        private System.Windows.Forms.ComboBox Cbx_buscaCurso;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        private System.Windows.Forms.Label Lbl_buscaCurso;
        private System.Windows.Forms.Label Lbl_operacaoEscolha;
        private System.Windows.Forms.ComboBox Cbx_turmaAluno;
        private System.Windows.Forms.Label Lbl_disponivel;
    }
}