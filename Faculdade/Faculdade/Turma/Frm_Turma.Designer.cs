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
            this.Lbl_turno = new System.Windows.Forms.Label();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            this.TxB_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Cbx_turnoAntigo = new System.Windows.Forms.ComboBox();
            this.Cbx_cursoAntigo = new System.Windows.Forms.ComboBox();
            this.Btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_insereTurma
            // 
            this.Btn_insereTurma.Location = new System.Drawing.Point(769, 195);
            this.Btn_insereTurma.Name = "Btn_insereTurma";
            this.Btn_insereTurma.Size = new System.Drawing.Size(75, 23);
            this.Btn_insereTurma.TabIndex = 0;
            this.Btn_insereTurma.Text = "INSERIR";
            this.Btn_insereTurma.UseVisualStyleBackColor = true;
            this.Btn_insereTurma.Click += new System.EventHandler(this.Btn_insereTurma_Click);
            // 
            // Txb_nomeTurma
            // 
            this.Txb_nomeTurma.Location = new System.Drawing.Point(488, 152);
            this.Txb_nomeTurma.Name = "Txb_nomeTurma";
            this.Txb_nomeTurma.Size = new System.Drawing.Size(220, 20);
            this.Txb_nomeTurma.TabIndex = 1;
            // 
            // Cbx_cursoTurma
            // 
            this.Cbx_cursoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoTurma.FormattingEnabled = true;
            this.Cbx_cursoTurma.Location = new System.Drawing.Point(488, 205);
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
            this.Dgv_turmas.Size = new System.Drawing.Size(409, 338);
            this.Dgv_turmas.TabIndex = 3;
            this.Dgv_turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_turmas_CellContentClick);
            // 
            // Lbl_turno
            // 
            this.Lbl_turno.AutoSize = true;
            this.Lbl_turno.Location = new System.Drawing.Point(733, 42);
            this.Lbl_turno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_turno.Name = "Lbl_turno";
            this.Lbl_turno.Size = new System.Drawing.Size(38, 13);
            this.Lbl_turno.TabIndex = 40;
            this.Lbl_turno.Text = "Turno:";
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
            this.Cbx_Turno.Location = new System.Drawing.Point(736, 152);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(108, 21);
            this.Cbx_Turno.TabIndex = 39;
            // 
            // TxB_nomeAlterar
            // 
            this.TxB_nomeAlterar.Location = new System.Drawing.Point(488, 58);
            this.TxB_nomeAlterar.Name = "TxB_nomeAlterar";
            this.TxB_nomeAlterar.Size = new System.Drawing.Size(220, 20);
            this.TxB_nomeAlterar.TabIndex = 41;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(850, 195);
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
            this.Cbx_turnoAntigo.Location = new System.Drawing.Point(736, 57);
            this.Cbx_turnoAntigo.Name = "Cbx_turnoAntigo";
            this.Cbx_turnoAntigo.Size = new System.Drawing.Size(108, 21);
            this.Cbx_turnoAntigo.TabIndex = 43;
            // 
            // Cbx_cursoAntigo
            // 
            this.Cbx_cursoAntigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoAntigo.FormattingEnabled = true;
            this.Cbx_cursoAntigo.Location = new System.Drawing.Point(488, 102);
            this.Cbx_cursoAntigo.Name = "Cbx_cursoAntigo";
            this.Cbx_cursoAntigo.Size = new System.Drawing.Size(220, 21);
            this.Cbx_cursoAntigo.TabIndex = 44;
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Location = new System.Drawing.Point(941, 195);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluir.TabIndex = 45;
            this.Btn_excluir.Text = "EXCLUIR";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Frm_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 701);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Cbx_cursoAntigo);
            this.Controls.Add(this.Cbx_turnoAntigo);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.TxB_nomeAlterar);
            this.Controls.Add(this.Lbl_turno);
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
        private System.Windows.Forms.Label Lbl_turno;
        private System.Windows.Forms.ComboBox Cbx_Turno;
        private System.Windows.Forms.TextBox TxB_nomeAlterar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.ComboBox Cbx_turnoAntigo;
        private System.Windows.Forms.ComboBox Cbx_cursoAntigo;
        private System.Windows.Forms.Button Btn_excluir;
    }
}