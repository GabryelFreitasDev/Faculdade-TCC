
namespace Faculdade
{
    partial class Frm_Curso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_excluiCurso = new System.Windows.Forms.Button();
            this.Txb_excluiCurso = new System.Windows.Forms.TextBox();
            this.Dgv_Curso = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Mtxb_cargaHoraNova = new System.Windows.Forms.MaskedTextBox();
            this.Txb_descricaoNova = new System.Windows.Forms.TextBox();
            this.Cbx_turnoNovo = new System.Windows.Forms.ComboBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txb_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Txb_nomeNovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MTxb_cargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.Txb_descricao = new System.Windows.Forms.TextBox();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            this.Btn_InsereCurso = new System.Windows.Forms.Button();
            this.Txb_nomeCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Curso)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_excluiCurso
            // 
            this.Btn_excluiCurso.Location = new System.Drawing.Point(330, 430);
            this.Btn_excluiCurso.Name = "Btn_excluiCurso";
            this.Btn_excluiCurso.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluiCurso.TabIndex = 2;
            this.Btn_excluiCurso.Text = "DELETAR";
            this.Btn_excluiCurso.UseVisualStyleBackColor = true;
            this.Btn_excluiCurso.Click += new System.EventHandler(this.Btn_excluiCurso_Click);
            // 
            // Txb_excluiCurso
            // 
            this.Txb_excluiCurso.Location = new System.Drawing.Point(3, 430);
            this.Txb_excluiCurso.Name = "Txb_excluiCurso";
            this.Txb_excluiCurso.Size = new System.Drawing.Size(297, 20);
            this.Txb_excluiCurso.TabIndex = 3;
            // 
            // Dgv_Curso
            // 
            this.Dgv_Curso.AllowUserToAddRows = false;
            this.Dgv_Curso.AllowUserToDeleteRows = false;
            this.Dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Curso.Location = new System.Drawing.Point(411, 232);
            this.Dgv_Curso.Name = "Dgv_Curso";
            this.Dgv_Curso.ReadOnly = true;
            this.Dgv_Curso.Size = new System.Drawing.Size(649, 413);
            this.Dgv_Curso.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "EDITAR";
            // 
            // Mtxb_cargaHoraNova
            // 
            this.Mtxb_cargaHoraNova.Location = new System.Drawing.Point(215, 190);
            this.Mtxb_cargaHoraNova.Mask = "0000 Hrs";
            this.Mtxb_cargaHoraNova.Name = "Mtxb_cargaHoraNova";
            this.Mtxb_cargaHoraNova.Size = new System.Drawing.Size(55, 20);
            this.Mtxb_cargaHoraNova.TabIndex = 19;
            // 
            // Txb_descricaoNova
            // 
            this.Txb_descricaoNova.Location = new System.Drawing.Point(3, 258);
            this.Txb_descricaoNova.Multiline = true;
            this.Txb_descricaoNova.Name = "Txb_descricaoNova";
            this.Txb_descricaoNova.Size = new System.Drawing.Size(297, 52);
            this.Txb_descricaoNova.TabIndex = 18;
            // 
            // Cbx_turnoNovo
            // 
            this.Cbx_turnoNovo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_turnoNovo.FormattingEnabled = true;
            this.Cbx_turnoNovo.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_turnoNovo.Location = new System.Drawing.Point(313, 189);
            this.Cbx_turnoNovo.Name = "Cbx_turnoNovo";
            this.Cbx_turnoNovo.Size = new System.Drawing.Size(153, 21);
            this.Cbx_turnoNovo.TabIndex = 17;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_editar.Location = new System.Drawing.Point(330, 287);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 16;
            this.Btn_editar.Text = "EDITAR";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click_1);
            // 
            // Txb_nomeAlterar
            // 
            this.Txb_nomeAlterar.Location = new System.Drawing.Point(3, 190);
            this.Txb_nomeAlterar.Name = "Txb_nomeAlterar";
            this.Txb_nomeAlterar.Size = new System.Drawing.Size(161, 20);
            this.Txb_nomeAlterar.TabIndex = 15;
            // 
            // Txb_nomeNovo
            // 
            this.Txb_nomeNovo.Location = new System.Drawing.Point(3, 232);
            this.Txb_nomeNovo.Name = "Txb_nomeNovo";
            this.Txb_nomeNovo.Size = new System.Drawing.Size(161, 20);
            this.Txb_nomeNovo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "DELETAR";
            // 
            // Txb_buscar
            // 
            this.Txb_buscar.Location = new System.Drawing.Point(472, 189);
            this.Txb_buscar.Name = "Txb_buscar";
            this.Txb_buscar.Size = new System.Drawing.Size(467, 20);
            this.Txb_buscar.TabIndex = 23;
            this.Txb_buscar.TextChanged += new System.EventHandler(this.Txb_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "INSERIR";
            // 
            // MTxb_cargaHoraria
            // 
            this.MTxb_cargaHoraria.Location = new System.Drawing.Point(234, 61);
            this.MTxb_cargaHoraria.Mask = "0000 Hrs";
            this.MTxb_cargaHoraria.Name = "MTxb_cargaHoraria";
            this.MTxb_cargaHoraria.Size = new System.Drawing.Size(55, 20);
            this.MTxb_cargaHoraria.TabIndex = 28;
            // 
            // Txb_descricao
            // 
            this.Txb_descricao.Location = new System.Drawing.Point(19, 102);
            this.Txb_descricao.Multiline = true;
            this.Txb_descricao.Name = "Txb_descricao";
            this.Txb_descricao.Size = new System.Drawing.Size(297, 52);
            this.Txb_descricao.TabIndex = 27;
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
            this.Cbx_Turno.Location = new System.Drawing.Point(327, 61);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(153, 21);
            this.Cbx_Turno.TabIndex = 26;
            // 
            // Btn_InsereCurso
            // 
            this.Btn_InsereCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_InsereCurso.Location = new System.Drawing.Point(361, 131);
            this.Btn_InsereCurso.Name = "Btn_InsereCurso";
            this.Btn_InsereCurso.Size = new System.Drawing.Size(75, 23);
            this.Btn_InsereCurso.TabIndex = 25;
            this.Btn_InsereCurso.Text = "INSERIR";
            this.Btn_InsereCurso.UseVisualStyleBackColor = true;
            this.Btn_InsereCurso.Click += new System.EventHandler(this.Btn_InsereCurso_Click);
            // 
            // Txb_nomeCurso
            // 
            this.Txb_nomeCurso.Location = new System.Drawing.Point(19, 61);
            this.Txb_nomeCurso.Name = "Txb_nomeCurso";
            this.Txb_nomeCurso.Size = new System.Drawing.Size(161, 20);
            this.Txb_nomeCurso.TabIndex = 24;
            this.Txb_nomeCurso.TextChanged += new System.EventHandler(this.Txb_nomeCurso_TextChanged);
            // 
            // Frm_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTxb_cargaHoraria);
            this.Controls.Add(this.Txb_descricao);
            this.Controls.Add(this.Cbx_Turno);
            this.Controls.Add(this.Btn_InsereCurso);
            this.Controls.Add(this.Txb_nomeCurso);
            this.Controls.Add(this.Txb_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_nomeNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mtxb_cargaHoraNova);
            this.Controls.Add(this.Txb_descricaoNova);
            this.Controls.Add(this.Cbx_turnoNovo);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Txb_nomeAlterar);
            this.Controls.Add(this.Dgv_Curso);
            this.Controls.Add(this.Txb_excluiCurso);
            this.Controls.Add(this.Btn_excluiCurso);
            this.Name = "Frm_Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Frm_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_excluiCurso;
        private System.Windows.Forms.TextBox Txb_excluiCurso;
        private System.Windows.Forms.DataGridView Dgv_Curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Mtxb_cargaHoraNova;
        private System.Windows.Forms.TextBox Txb_descricaoNova;
        private System.Windows.Forms.ComboBox Cbx_turnoNovo;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txb_nomeAlterar;
        private System.Windows.Forms.TextBox Txb_nomeNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTxb_cargaHoraria;
        private System.Windows.Forms.TextBox Txb_descricao;
        private System.Windows.Forms.ComboBox Cbx_Turno;
        private System.Windows.Forms.Button Btn_InsereCurso;
        private System.Windows.Forms.TextBox Txb_nomeCurso;
    }
}

