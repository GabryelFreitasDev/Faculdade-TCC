namespace Faculdade
{
    partial class Frm_Turma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_turmas = new System.Windows.Forms.DataGridView();
            this.Txb_buscaTurma = new System.Windows.Forms.TextBox();
            this.Cbx_buscaTurno = new System.Windows.Forms.ComboBox();
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Btn_relatorioCurso = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_turno = new System.Windows.Forms.Label();
            this.Lbl_nomeTurma = new System.Windows.Forms.Label();
            this.Lbl_cursoAltera = new System.Windows.Forms.Label();
            this.Lbl_turmaAltera = new System.Windows.Forms.Label();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Cbx_cursoAntigo = new System.Windows.Forms.ComboBox();
            this.Cbx_turnoAntigo = new System.Windows.Forms.ComboBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.TxB_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Lbl_turnoAltera = new System.Windows.Forms.Label();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            this.Cbx_cursoTurma = new System.Windows.Forms.ComboBox();
            this.Txb_nomeTurma = new System.Windows.Forms.TextBox();
            this.Btn_insereTurma = new System.Windows.Forms.Button();
            this.Lbl_operacao = new System.Windows.Forms.Label();
            this.Lbl_buscaCurso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_turmas
            // 
            this.Dgv_turmas.AllowUserToAddRows = false;
            this.Dgv_turmas.AllowUserToDeleteRows = false;
            this.Dgv_turmas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_turmas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_turmas.DefaultCellStyle = dataGridViewCellStyle14;
            this.Dgv_turmas.Location = new System.Drawing.Point(432, 82);
            this.Dgv_turmas.Name = "Dgv_turmas";
            this.Dgv_turmas.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv_turmas.Size = new System.Drawing.Size(600, 444);
            this.Dgv_turmas.TabIndex = 3;
            this.Dgv_turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_turmas_CellContentClick);
            // 
            // Txb_buscaTurma
            // 
            this.Txb_buscaTurma.Location = new System.Drawing.Point(432, 47);
            this.Txb_buscaTurma.Name = "Txb_buscaTurma";
            this.Txb_buscaTurma.Size = new System.Drawing.Size(301, 20);
            this.Txb_buscaTurma.TabIndex = 51;
            this.Txb_buscaTurma.TextChanged += new System.EventHandler(this.Txb_buscaTurma_TextChanged);
            // 
            // Cbx_buscaTurno
            // 
            this.Cbx_buscaTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaTurno.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_buscaTurno.FormattingEnabled = true;
            this.Cbx_buscaTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_buscaTurno.Location = new System.Drawing.Point(751, 44);
            this.Cbx_buscaTurno.Name = "Cbx_buscaTurno";
            this.Cbx_buscaTurno.Size = new System.Drawing.Size(108, 23);
            this.Cbx_buscaTurno.TabIndex = 52;
            this.Cbx_buscaTurno.SelectedIndexChanged += new System.EventHandler(this.Cbx_buscaTurno_SelectedIndexChanged);
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LimparFiltro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_LimparFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(894, 43);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(138, 30);
            this.Btn_LimparFiltro.TabIndex = 69;
            this.Btn_LimparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Btn_relatorioCurso
            // 
            this.Btn_relatorioCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_relatorioCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_relatorioCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_relatorioCurso.Location = new System.Drawing.Point(932, 532);
            this.Btn_relatorioCurso.Name = "Btn_relatorioCurso";
            this.Btn_relatorioCurso.Size = new System.Drawing.Size(100, 32);
            this.Btn_relatorioCurso.TabIndex = 71;
            this.Btn_relatorioCurso.Text = "RELATÓRIO";
            this.Btn_relatorioCurso.UseVisualStyleBackColor = true;
            this.Btn_relatorioCurso.Click += new System.EventHandler(this.Btn_relatorioCurso_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_limpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_limpar.Location = new System.Drawing.Point(12, 500);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(84, 32);
            this.Btn_limpar.TabIndex = 87;
            this.Btn_limpar.Text = "LIMPAR";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "CURSO:";
            // 
            // Lbl_turno
            // 
            this.Lbl_turno.AutoSize = true;
            this.Lbl_turno.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_turno.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_turno.Location = new System.Drawing.Point(252, 198);
            this.Lbl_turno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turno.Name = "Lbl_turno";
            this.Lbl_turno.Size = new System.Drawing.Size(66, 20);
            this.Lbl_turno.TabIndex = 85;
            this.Lbl_turno.Text = "TURNO:";
            // 
            // Lbl_nomeTurma
            // 
            this.Lbl_nomeTurma.AutoSize = true;
            this.Lbl_nomeTurma.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_nomeTurma.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_nomeTurma.Location = new System.Drawing.Point(9, 198);
            this.Lbl_nomeTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nomeTurma.Name = "Lbl_nomeTurma";
            this.Lbl_nomeTurma.Size = new System.Drawing.Size(143, 20);
            this.Lbl_nomeTurma.TabIndex = 84;
            this.Lbl_nomeTurma.Text = "NOME DA TURMA:";
            // 
            // Lbl_cursoAltera
            // 
            this.Lbl_cursoAltera.AutoSize = true;
            this.Lbl_cursoAltera.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_cursoAltera.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_cursoAltera.Location = new System.Drawing.Point(9, 138);
            this.Lbl_cursoAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cursoAltera.Name = "Lbl_cursoAltera";
            this.Lbl_cursoAltera.Size = new System.Drawing.Size(115, 20);
            this.Lbl_cursoAltera.TabIndex = 83;
            this.Lbl_cursoAltera.Text = "CURSO ATUAL:";
            // 
            // Lbl_turmaAltera
            // 
            this.Lbl_turmaAltera.AutoSize = true;
            this.Lbl_turmaAltera.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_turmaAltera.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_turmaAltera.Location = new System.Drawing.Point(9, 78);
            this.Lbl_turmaAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turmaAltera.Name = "Lbl_turmaAltera";
            this.Lbl_turmaAltera.Size = new System.Drawing.Size(196, 20);
            this.Lbl_turmaAltera.TabIndex = 82;
            this.Lbl_turmaAltera.Text = "NOME ATUAL DA TURMA:";
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_excluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_excluir.Location = new System.Drawing.Point(208, 342);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(84, 32);
            this.Btn_excluir.TabIndex = 81;
            this.Btn_excluir.Text = "EXCLUIR";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Cbx_cursoAntigo
            // 
            this.Cbx_cursoAntigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoAntigo.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_cursoAntigo.FormattingEnabled = true;
            this.Cbx_cursoAntigo.Location = new System.Drawing.Point(12, 160);
            this.Cbx_cursoAntigo.Name = "Cbx_cursoAntigo";
            this.Cbx_cursoAntigo.Size = new System.Drawing.Size(220, 23);
            this.Cbx_cursoAntigo.TabIndex = 80;
            this.Cbx_cursoAntigo.SelectedIndexChanged += new System.EventHandler(this.Cbx_cursoAntigo_SelectedIndexChanged);
            // 
            // Cbx_turnoAntigo
            // 
            this.Cbx_turnoAntigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_turnoAntigo.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_turnoAntigo.FormattingEnabled = true;
            this.Cbx_turnoAntigo.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_turnoAntigo.Location = new System.Drawing.Point(257, 98);
            this.Cbx_turnoAntigo.Name = "Cbx_turnoAntigo";
            this.Cbx_turnoAntigo.Size = new System.Drawing.Size(108, 23);
            this.Cbx_turnoAntigo.TabIndex = 79;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_editar.Location = new System.Drawing.Point(108, 342);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(84, 32);
            this.Btn_editar.TabIndex = 78;
            this.Btn_editar.Text = "EDITAR";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // TxB_nomeAlterar
            // 
            this.TxB_nomeAlterar.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.TxB_nomeAlterar.Location = new System.Drawing.Point(12, 99);
            this.TxB_nomeAlterar.Name = "TxB_nomeAlterar";
            this.TxB_nomeAlterar.Size = new System.Drawing.Size(220, 23);
            this.TxB_nomeAlterar.TabIndex = 77;
            // 
            // Lbl_turnoAltera
            // 
            this.Lbl_turnoAltera.AutoSize = true;
            this.Lbl_turnoAltera.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_turnoAltera.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_turnoAltera.Location = new System.Drawing.Point(253, 78);
            this.Lbl_turnoAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turnoAltera.Name = "Lbl_turnoAltera";
            this.Lbl_turnoAltera.Size = new System.Drawing.Size(119, 20);
            this.Lbl_turnoAltera.TabIndex = 76;
            this.Lbl_turnoAltera.Text = "TURNO ATUAL:";
            // 
            // Cbx_Turno
            // 
            this.Cbx_Turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Turno.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_Turno.FormattingEnabled = true;
            this.Cbx_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_Turno.Location = new System.Drawing.Point(256, 223);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(108, 23);
            this.Cbx_Turno.TabIndex = 75;
            // 
            // Cbx_cursoTurma
            // 
            this.Cbx_cursoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoTurma.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_cursoTurma.FormattingEnabled = true;
            this.Cbx_cursoTurma.Location = new System.Drawing.Point(12, 276);
            this.Cbx_cursoTurma.Name = "Cbx_cursoTurma";
            this.Cbx_cursoTurma.Size = new System.Drawing.Size(220, 23);
            this.Cbx_cursoTurma.TabIndex = 74;
            this.Cbx_cursoTurma.SelectedIndexChanged += new System.EventHandler(this.Cbx_cursoTurma_SelectedIndexChanged);
            // 
            // Txb_nomeTurma
            // 
            this.Txb_nomeTurma.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Txb_nomeTurma.Location = new System.Drawing.Point(12, 223);
            this.Txb_nomeTurma.Name = "Txb_nomeTurma";
            this.Txb_nomeTurma.Size = new System.Drawing.Size(220, 23);
            this.Txb_nomeTurma.TabIndex = 73;
            // 
            // Btn_insereTurma
            // 
            this.Btn_insereTurma.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_insereTurma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_insereTurma.Location = new System.Drawing.Point(12, 342);
            this.Btn_insereTurma.Name = "Btn_insereTurma";
            this.Btn_insereTurma.Size = new System.Drawing.Size(84, 32);
            this.Btn_insereTurma.TabIndex = 72;
            this.Btn_insereTurma.Text = "INSERIR";
            this.Btn_insereTurma.UseVisualStyleBackColor = true;
            this.Btn_insereTurma.Click += new System.EventHandler(this.Btn_insereTurma_Click);
            // 
            // Lbl_operacao
            // 
            this.Lbl_operacao.AutoSize = true;
            this.Lbl_operacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Lbl_operacao.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.Lbl_operacao.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_operacao.Location = new System.Drawing.Point(12, 21);
            this.Lbl_operacao.Name = "Lbl_operacao";
            this.Lbl_operacao.Size = new System.Drawing.Size(142, 45);
            this.Lbl_operacao.TabIndex = 88;
            this.Lbl_operacao.Text = "INSERIR";
            // 
            // Lbl_buscaCurso
            // 
            this.Lbl_buscaCurso.AutoSize = true;
            this.Lbl_buscaCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_buscaCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_buscaCurso.Location = new System.Drawing.Point(428, 21);
            this.Lbl_buscaCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_buscaCurso.Name = "Lbl_buscaCurso";
            this.Lbl_buscaCurso.Size = new System.Drawing.Size(224, 20);
            this.Lbl_buscaCurso.TabIndex = 89;
            this.Lbl_buscaCurso.Text = "INFORME O NOME DO CURSO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(747, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "INFORME A TURMA:";
            // 
            // Frm_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_buscaCurso);
            this.Controls.Add(this.Lbl_operacao);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_turno);
            this.Controls.Add(this.Lbl_nomeTurma);
            this.Controls.Add(this.Lbl_cursoAltera);
            this.Controls.Add(this.Lbl_turmaAltera);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Cbx_cursoAntigo);
            this.Controls.Add(this.Cbx_turnoAntigo);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.TxB_nomeAlterar);
            this.Controls.Add(this.Lbl_turnoAltera);
            this.Controls.Add(this.Cbx_Turno);
            this.Controls.Add(this.Cbx_cursoTurma);
            this.Controls.Add(this.Txb_nomeTurma);
            this.Controls.Add(this.Btn_insereTurma);
            this.Controls.Add(this.Btn_relatorioCurso);
            this.Controls.Add(this.Btn_LimparFiltro);
            this.Controls.Add(this.Cbx_buscaTurno);
            this.Controls.Add(this.Txb_buscaTurma);
            this.Controls.Add(this.Dgv_turmas);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Frm_Turma";
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.Frm_Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_turmas;
        private System.Windows.Forms.TextBox Txb_buscaTurma;
        private System.Windows.Forms.ComboBox Cbx_buscaTurno;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        private System.Windows.Forms.Button Btn_relatorioCurso;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_turno;
        private System.Windows.Forms.Label Lbl_nomeTurma;
        private System.Windows.Forms.Label Lbl_cursoAltera;
        private System.Windows.Forms.Label Lbl_turmaAltera;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.ComboBox Cbx_cursoAntigo;
        private System.Windows.Forms.ComboBox Cbx_turnoAntigo;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox TxB_nomeAlterar;
        private System.Windows.Forms.Label Lbl_turnoAltera;
        private System.Windows.Forms.ComboBox Cbx_Turno;
        private System.Windows.Forms.ComboBox Cbx_cursoTurma;
        private System.Windows.Forms.TextBox Txb_nomeTurma;
        private System.Windows.Forms.Button Btn_insereTurma;
        private System.Windows.Forms.Label Lbl_operacao;
        private System.Windows.Forms.Label Lbl_buscaCurso;
        private System.Windows.Forms.Label label2;
    }
}