
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
            this.Dgv_curso = new System.Windows.Forms.DataGridView();
            this.Txb_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MTxb_cargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.Txb_descricao = new System.Windows.Forms.TextBox();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            this.Btn_InsereCurso = new System.Windows.Forms.Button();
            this.Txb_nomeCurso = new System.Windows.Forms.TextBox();
            this.Btn_excluiCurso = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txb_nomeAlterar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_curso
            // 
            this.Dgv_curso.AllowUserToAddRows = false;
            this.Dgv_curso.AllowUserToDeleteRows = false;
            this.Dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_curso.Location = new System.Drawing.Point(332, 115);
            this.Dgv_curso.Name = "Dgv_curso";
            this.Dgv_curso.ReadOnly = true;
            this.Dgv_curso.Size = new System.Drawing.Size(649, 413);
            this.Dgv_curso.TabIndex = 7;
            this.Dgv_curso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_curso_CellContentClick);
            // 
            // Txb_buscar
            // 
            this.Txb_buscar.Location = new System.Drawing.Point(332, 74);
            this.Txb_buscar.Name = "Txb_buscar";
            this.Txb_buscar.Size = new System.Drawing.Size(649, 20);
            this.Txb_buscar.TabIndex = 23;
            this.Txb_buscar.TextChanged += new System.EventHandler(this.Txb_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "INSERIR";
            // 
            // MTxb_cargaHoraria
            // 
            this.MTxb_cargaHoraria.Location = new System.Drawing.Point(19, 201);
            this.MTxb_cargaHoraria.Mask = "0000 Hrs";
            this.MTxb_cargaHoraria.Name = "MTxb_cargaHoraria";
            this.MTxb_cargaHoraria.Size = new System.Drawing.Size(55, 20);
            this.MTxb_cargaHoraria.TabIndex = 28;
            // 
            // Txb_descricao
            // 
            this.Txb_descricao.Location = new System.Drawing.Point(19, 238);
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
            this.Cbx_Turno.Location = new System.Drawing.Point(19, 174);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(153, 21);
            this.Cbx_Turno.TabIndex = 26;
            // 
            // Btn_InsereCurso
            // 
            this.Btn_InsereCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_InsereCurso.Location = new System.Drawing.Point(19, 399);
            this.Btn_InsereCurso.Name = "Btn_InsereCurso";
            this.Btn_InsereCurso.Size = new System.Drawing.Size(75, 23);
            this.Btn_InsereCurso.TabIndex = 25;
            this.Btn_InsereCurso.Text = "INSERIR";
            this.Btn_InsereCurso.UseVisualStyleBackColor = true;
            this.Btn_InsereCurso.Click += new System.EventHandler(this.Btn_InsereCurso_Click);
            // 
            // Txb_nomeCurso
            // 
            this.Txb_nomeCurso.Location = new System.Drawing.Point(19, 134);
            this.Txb_nomeCurso.Name = "Txb_nomeCurso";
            this.Txb_nomeCurso.Size = new System.Drawing.Size(161, 20);
            this.Txb_nomeCurso.TabIndex = 24;
            // 
            // Btn_excluiCurso
            // 
            this.Btn_excluiCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_excluiCurso.Location = new System.Drawing.Point(251, 399);
            this.Btn_excluiCurso.Name = "Btn_excluiCurso";
            this.Btn_excluiCurso.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluiCurso.TabIndex = 30;
            this.Btn_excluiCurso.Text = "DELETAR";
            this.Btn_excluiCurso.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_editar.Location = new System.Drawing.Point(144, 399);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 31;
            this.Btn_editar.Text = "EDITAR";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Txb_nomeAlterar
            // 
            this.Txb_nomeAlterar.Location = new System.Drawing.Point(19, 108);
            this.Txb_nomeAlterar.Name = "Txb_nomeAlterar";
            this.Txb_nomeAlterar.Size = new System.Drawing.Size(161, 20);
            this.Txb_nomeAlterar.TabIndex = 32;
            // 
            // Frm_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 563);
            this.Controls.Add(this.Txb_nomeAlterar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_excluiCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTxb_cargaHoraria);
            this.Controls.Add(this.Txb_descricao);
            this.Controls.Add(this.Cbx_Turno);
            this.Controls.Add(this.Btn_InsereCurso);
            this.Controls.Add(this.Txb_nomeCurso);
            this.Controls.Add(this.Txb_buscar);
            this.Controls.Add(this.Dgv_curso);
            this.Name = "Frm_Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Frm_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_curso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_curso;
        private System.Windows.Forms.TextBox Txb_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTxb_cargaHoraria;
        private System.Windows.Forms.TextBox Txb_descricao;
        private System.Windows.Forms.ComboBox Cbx_Turno;
        private System.Windows.Forms.Button Btn_InsereCurso;
        private System.Windows.Forms.TextBox Txb_nomeCurso;
        private System.Windows.Forms.Button Btn_excluiCurso;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txb_nomeAlterar;
    }
}

