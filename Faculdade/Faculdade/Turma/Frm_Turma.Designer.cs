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
            this.Btn_insereTurma = new System.Windows.Forms.Button();
            this.Txb_nomeTurma = new System.Windows.Forms.TextBox();
            this.Cbx_cursoTurma = new System.Windows.Forms.ComboBox();
            this.Dgv_turmas = new System.Windows.Forms.DataGridView();
            this.Lbl_turnoAltera = new System.Windows.Forms.Label();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            this.TxB_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Cbx_turnoAntigo = new System.Windows.Forms.ComboBox();
            this.Cbx_cursoAntigo = new System.Windows.Forms.ComboBox();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Lbl_turmaAltera = new System.Windows.Forms.Label();
            this.Lbl_cursoAltera = new System.Windows.Forms.Label();
            this.Lbl_nomeTurma = new System.Windows.Forms.Label();
            this.Lbl_turno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_buscaTurma = new System.Windows.Forms.TextBox();
            this.Cbx_buscaTurno = new System.Windows.Forms.ComboBox();
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_insereTurma
            // 
            this.Btn_insereTurma.Location = new System.Drawing.Point(544, 352);
            this.Btn_insereTurma.Name = "Btn_insereTurma";
            this.Btn_insereTurma.Size = new System.Drawing.Size(75, 23);
            this.Btn_insereTurma.TabIndex = 0;
            this.Btn_insereTurma.Text = "INSERIR";
            this.Btn_insereTurma.UseVisualStyleBackColor = true;
            this.Btn_insereTurma.Click += new System.EventHandler(this.Btn_insereTurma_Click);
            // 
            // Txb_nomeTurma
            // 
            this.Txb_nomeTurma.Location = new System.Drawing.Point(545, 249);
            this.Txb_nomeTurma.Name = "Txb_nomeTurma";
            this.Txb_nomeTurma.Size = new System.Drawing.Size(220, 20);
            this.Txb_nomeTurma.TabIndex = 1;
            // 
            // Cbx_cursoTurma
            // 
            this.Cbx_cursoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoTurma.FormattingEnabled = true;
            this.Cbx_cursoTurma.Location = new System.Drawing.Point(545, 302);
            this.Cbx_cursoTurma.Name = "Cbx_cursoTurma";
            this.Cbx_cursoTurma.Size = new System.Drawing.Size(220, 21);
            this.Cbx_cursoTurma.TabIndex = 2;
            // 
            // Dgv_turmas
            // 
            this.Dgv_turmas.AllowUserToAddRows = false;
            this.Dgv_turmas.AllowUserToDeleteRows = false;
            this.Dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_turmas.Location = new System.Drawing.Point(45, 56);
            this.Dgv_turmas.Name = "Dgv_turmas";
            this.Dgv_turmas.ReadOnly = true;
            this.Dgv_turmas.Size = new System.Drawing.Size(463, 338);
            this.Dgv_turmas.TabIndex = 3;
            this.Dgv_turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_turmas_CellContentClick);
            // 
            // Lbl_turnoAltera
            // 
            this.Lbl_turnoAltera.AutoSize = true;
            this.Lbl_turnoAltera.Location = new System.Drawing.Point(790, 121);
            this.Lbl_turnoAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turnoAltera.Name = "Lbl_turnoAltera";
            this.Lbl_turnoAltera.Size = new System.Drawing.Size(155, 13);
            this.Lbl_turnoAltera.TabIndex = 40;
            this.Lbl_turnoAltera.Text = "Turno que está sendo alterado:";
            // 
            // Cbx_Turno
            // 
            this.Cbx_Turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Turno.FormattingEnabled = true;
            this.Cbx_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_Turno.Location = new System.Drawing.Point(793, 249);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(108, 21);
            this.Cbx_Turno.TabIndex = 39;
            // 
            // TxB_nomeAlterar
            // 
            this.TxB_nomeAlterar.Location = new System.Drawing.Point(545, 137);
            this.TxB_nomeAlterar.Name = "TxB_nomeAlterar";
            this.TxB_nomeAlterar.Size = new System.Drawing.Size(220, 20);
            this.TxB_nomeAlterar.TabIndex = 41;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(625, 352);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 42;
            this.Btn_editar.Text = "EDITAR";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Cbx_turnoAntigo
            // 
            this.Cbx_turnoAntigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_turnoAntigo.FormattingEnabled = true;
            this.Cbx_turnoAntigo.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_turnoAntigo.Location = new System.Drawing.Point(793, 136);
            this.Cbx_turnoAntigo.Name = "Cbx_turnoAntigo";
            this.Cbx_turnoAntigo.Size = new System.Drawing.Size(108, 21);
            this.Cbx_turnoAntigo.TabIndex = 43;
            // 
            // Cbx_cursoAntigo
            // 
            this.Cbx_cursoAntigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoAntigo.FormattingEnabled = true;
            this.Cbx_cursoAntigo.Location = new System.Drawing.Point(545, 192);
            this.Cbx_cursoAntigo.Name = "Cbx_cursoAntigo";
            this.Cbx_cursoAntigo.Size = new System.Drawing.Size(220, 21);
            this.Cbx_cursoAntigo.TabIndex = 44;
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Location = new System.Drawing.Point(716, 352);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluir.TabIndex = 45;
            this.Btn_excluir.Text = "EXCLUIR";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Lbl_turmaAltera
            // 
            this.Lbl_turmaAltera.AutoSize = true;
            this.Lbl_turmaAltera.Location = new System.Drawing.Point(542, 121);
            this.Lbl_turmaAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turmaAltera.Name = "Lbl_turmaAltera";
            this.Lbl_turmaAltera.Size = new System.Drawing.Size(199, 13);
            this.Lbl_turmaAltera.TabIndex = 46;
            this.Lbl_turmaAltera.Text = "Nome da turma que está sendo alterada:";
            // 
            // Lbl_cursoAltera
            // 
            this.Lbl_cursoAltera.AutoSize = true;
            this.Lbl_cursoAltera.Location = new System.Drawing.Point(542, 176);
            this.Lbl_cursoAltera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cursoAltera.Name = "Lbl_cursoAltera";
            this.Lbl_cursoAltera.Size = new System.Drawing.Size(158, 13);
            this.Lbl_cursoAltera.TabIndex = 47;
            this.Lbl_cursoAltera.Text = "Curso no qual a turma pertence:";
            // 
            // Lbl_nomeTurma
            // 
            this.Lbl_nomeTurma.AutoSize = true;
            this.Lbl_nomeTurma.Location = new System.Drawing.Point(545, 233);
            this.Lbl_nomeTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nomeTurma.Name = "Lbl_nomeTurma";
            this.Lbl_nomeTurma.Size = new System.Drawing.Size(82, 13);
            this.Lbl_nomeTurma.TabIndex = 48;
            this.Lbl_nomeTurma.Text = "Nome da turma:";
            // 
            // Lbl_turno
            // 
            this.Lbl_turno.AutoSize = true;
            this.Lbl_turno.Location = new System.Drawing.Point(790, 233);
            this.Lbl_turno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turno.Name = "Lbl_turno";
            this.Lbl_turno.Size = new System.Drawing.Size(38, 13);
            this.Lbl_turno.TabIndex = 49;
            this.Lbl_turno.Text = "Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Curso:";
            // 
            // Txb_buscaTurma
            // 
            this.Txb_buscaTurma.Location = new System.Drawing.Point(45, 30);
            this.Txb_buscaTurma.Name = "Txb_buscaTurma";
            this.Txb_buscaTurma.Size = new System.Drawing.Size(342, 20);
            this.Txb_buscaTurma.TabIndex = 51;
            this.Txb_buscaTurma.TextChanged += new System.EventHandler(this.Txb_buscaTurma_TextChanged);
            // 
            // Cbx_buscaTurno
            // 
            this.Cbx_buscaTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaTurno.FormattingEnabled = true;
            this.Cbx_buscaTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_buscaTurno.Location = new System.Drawing.Point(400, 30);
            this.Cbx_buscaTurno.Name = "Cbx_buscaTurno";
            this.Cbx_buscaTurno.Size = new System.Drawing.Size(108, 21);
            this.Cbx_buscaTurno.TabIndex = 52;
            this.Cbx_buscaTurno.SelectedIndexChanged += new System.EventHandler(this.Cbx_buscaTurno_SelectedIndexChanged);
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(519, 30);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(108, 23);
            this.Btn_LimparFiltro.TabIndex = 69;
            this.Btn_LimparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_limpar.Location = new System.Drawing.Point(927, 352);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpar.TabIndex = 70;
            this.Btn_limpar.Text = "LIMPAR";
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Frm_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 701);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Btn_LimparFiltro);
            this.Controls.Add(this.Cbx_buscaTurno);
            this.Controls.Add(this.Txb_buscaTurma);
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
            this.Controls.Add(this.Dgv_turmas);
            this.Controls.Add(this.Cbx_cursoTurma);
            this.Controls.Add(this.Txb_nomeTurma);
            this.Controls.Add(this.Btn_insereTurma);
            this.Name = "Frm_Turma";
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.Frm_Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_insereTurma;
        private System.Windows.Forms.TextBox Txb_nomeTurma;
        private System.Windows.Forms.ComboBox Cbx_cursoTurma;
        private System.Windows.Forms.DataGridView Dgv_turmas;
        private System.Windows.Forms.Label Lbl_turnoAltera;
        private System.Windows.Forms.ComboBox Cbx_Turno;
        private System.Windows.Forms.TextBox TxB_nomeAlterar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.ComboBox Cbx_turnoAntigo;
        private System.Windows.Forms.ComboBox Cbx_cursoAntigo;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Label Lbl_turmaAltera;
        private System.Windows.Forms.Label Lbl_cursoAltera;
        private System.Windows.Forms.Label Lbl_nomeTurma;
        private System.Windows.Forms.Label Lbl_turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_buscaTurma;
        private System.Windows.Forms.ComboBox Cbx_buscaTurno;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        private System.Windows.Forms.Button Btn_limpar;
    }
}