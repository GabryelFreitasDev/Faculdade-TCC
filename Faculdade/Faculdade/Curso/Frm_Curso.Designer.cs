
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txb_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_operacao = new System.Windows.Forms.Label();
            this.MTxb_cargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.Txb_descricao = new System.Windows.Forms.TextBox();
            this.Btn_InsereCurso = new System.Windows.Forms.Button();
            this.Txb_nomeCurso = new System.Windows.Forms.TextBox();
            this.Btn_excluiCurso = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txb_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Btn_relatorioCurso = new System.Windows.Forms.Button();
            this.Lbl_nomeAlterar = new System.Windows.Forms.Label();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Lbl_cargaHoraria = new System.Windows.Forms.Label();
            this.Lbl_buscaCurso = new System.Windows.Forms.Label();
            this.Lbl_descricao = new System.Windows.Forms.Label();
            this.Dgv_cursos = new System.Windows.Forms.DataGridView();
            this.Lbl_operacaoEscolha = new System.Windows.Forms.Label();
            this.Lbl_nomeAcao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_buscar
            // 
            this.Txb_buscar.Location = new System.Drawing.Point(432, 47);
            this.Txb_buscar.Name = "Txb_buscar";
            this.Txb_buscar.Size = new System.Drawing.Size(598, 20);
            this.Txb_buscar.TabIndex = 23;
            this.Txb_buscar.TextChanged += new System.EventHandler(this.Txb_buscar_TextChanged);
            // 
            // Lbl_operacao
            // 
            this.Lbl_operacao.AutoSize = true;
            this.Lbl_operacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Lbl_operacao.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_operacao.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_operacao.Location = new System.Drawing.Point(12, 21);
            this.Lbl_operacao.Name = "Lbl_operacao";
            this.Lbl_operacao.Size = new System.Drawing.Size(142, 45);
            this.Lbl_operacao.TabIndex = 29;
            this.Lbl_operacao.Text = "INSERIR";
            // 
            // MTxb_cargaHoraria
            // 
            this.MTxb_cargaHoraria.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxb_cargaHoraria.Location = new System.Drawing.Point(11, 234);
            this.MTxb_cargaHoraria.Mask = "0000 Hrs";
            this.MTxb_cargaHoraria.Name = "MTxb_cargaHoraria";
            this.MTxb_cargaHoraria.Size = new System.Drawing.Size(55, 23);
            this.MTxb_cargaHoraria.TabIndex = 28;
            // 
            // Txb_descricao
            // 
            this.Txb_descricao.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_descricao.Location = new System.Drawing.Point(11, 291);
            this.Txb_descricao.Multiline = true;
            this.Txb_descricao.Name = "Txb_descricao";
            this.Txb_descricao.Size = new System.Drawing.Size(379, 67);
            this.Txb_descricao.TabIndex = 27;
            // 
            // Btn_InsereCurso
            // 
            this.Btn_InsereCurso.BackColor = System.Drawing.Color.Transparent;
            this.Btn_InsereCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_InsereCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_InsereCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_InsereCurso.Location = new System.Drawing.Point(13, 415);
            this.Btn_InsereCurso.Name = "Btn_InsereCurso";
            this.Btn_InsereCurso.Size = new System.Drawing.Size(84, 32);
            this.Btn_InsereCurso.TabIndex = 25;
            this.Btn_InsereCurso.Text = "INSERIR";
            this.Btn_InsereCurso.UseVisualStyleBackColor = false;
            this.Btn_InsereCurso.Click += new System.EventHandler(this.Btn_InsereCurso_Click);
            // 
            // Txb_nomeCurso
            // 
            this.Txb_nomeCurso.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_nomeCurso.Location = new System.Drawing.Point(11, 162);
            this.Txb_nomeCurso.Name = "Txb_nomeCurso";
            this.Txb_nomeCurso.Size = new System.Drawing.Size(379, 23);
            this.Txb_nomeCurso.TabIndex = 24;
            // 
            // Btn_excluiCurso
            // 
            this.Btn_excluiCurso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_excluiCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_excluiCurso.Location = new System.Drawing.Point(214, 415);
            this.Btn_excluiCurso.Name = "Btn_excluiCurso";
            this.Btn_excluiCurso.Size = new System.Drawing.Size(84, 32);
            this.Btn_excluiCurso.TabIndex = 30;
            this.Btn_excluiCurso.Text = "EXCLUIR";
            this.Btn_excluiCurso.UseVisualStyleBackColor = false;
            this.Btn_excluiCurso.Click += new System.EventHandler(this.Btn_excluiCurso_Click_1);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_editar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_editar.Location = new System.Drawing.Point(115, 415);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(84, 32);
            this.Btn_editar.TabIndex = 31;
            this.Btn_editar.Text = "EDITAR";
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Txb_nomeAlterar
            // 
            this.Txb_nomeAlterar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_nomeAlterar.Location = new System.Drawing.Point(12, 99);
            this.Txb_nomeAlterar.Name = "Txb_nomeAlterar";
            this.Txb_nomeAlterar.Size = new System.Drawing.Size(379, 23);
            this.Txb_nomeAlterar.TabIndex = 32;
            // 
            // Btn_relatorioCurso
            // 
            this.Btn_relatorioCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_relatorioCurso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_relatorioCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_relatorioCurso.Location = new System.Drawing.Point(918, 532);
            this.Btn_relatorioCurso.Name = "Btn_relatorioCurso";
            this.Btn_relatorioCurso.Size = new System.Drawing.Size(112, 32);
            this.Btn_relatorioCurso.TabIndex = 33;
            this.Btn_relatorioCurso.Text = "RELATÓRIO";
            this.Btn_relatorioCurso.UseVisualStyleBackColor = false;
            this.Btn_relatorioCurso.Click += new System.EventHandler(this.Btn_relatorioCurso_Click_1);
            // 
            // Lbl_nomeAlterar
            // 
            this.Lbl_nomeAlterar.AutoSize = true;
            this.Lbl_nomeAlterar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nomeAlterar.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_nomeAlterar.Location = new System.Drawing.Point(9, 78);
            this.Lbl_nomeAlterar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nomeAlterar.Name = "Lbl_nomeAlterar";
            this.Lbl_nomeAlterar.Size = new System.Drawing.Size(190, 20);
            this.Lbl_nomeAlterar.TabIndex = 35;
            this.Lbl_nomeAlterar.Text = "NOME ATUAL DO CURSO:";
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_limpar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_limpar.Location = new System.Drawing.Point(12, 532);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(84, 32);
            this.Btn_limpar.TabIndex = 37;
            this.Btn_limpar.Text = "LIMPAR";
            this.Btn_limpar.UseVisualStyleBackColor = false;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Lbl_cargaHoraria
            // 
            this.Lbl_cargaHoraria.AutoSize = true;
            this.Lbl_cargaHoraria.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_cargaHoraria.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_cargaHoraria.Location = new System.Drawing.Point(8, 211);
            this.Lbl_cargaHoraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cargaHoraria.Name = "Lbl_cargaHoraria";
            this.Lbl_cargaHoraria.Size = new System.Drawing.Size(138, 20);
            this.Lbl_cargaHoraria.TabIndex = 39;
            this.Lbl_cargaHoraria.Text = "CARGA HORÁRIA:";
            // 
            // Lbl_buscaCurso
            // 
            this.Lbl_buscaCurso.AutoSize = true;
            this.Lbl_buscaCurso.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_buscaCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_buscaCurso.Location = new System.Drawing.Point(428, 21);
            this.Lbl_buscaCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_buscaCurso.Name = "Lbl_buscaCurso";
            this.Lbl_buscaCurso.Size = new System.Drawing.Size(359, 20);
            this.Lbl_buscaCurso.TabIndex = 40;
            this.Lbl_buscaCurso.Text = "DIGITE O NOME DO CURSO QUE DESEJA BUSCAR:";
            // 
            // Lbl_descricao
            // 
            this.Lbl_descricao.AutoSize = true;
            this.Lbl_descricao.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_descricao.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_descricao.Location = new System.Drawing.Point(8, 269);
            this.Lbl_descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_descricao.Name = "Lbl_descricao";
            this.Lbl_descricao.Size = new System.Drawing.Size(95, 20);
            this.Lbl_descricao.TabIndex = 41;
            this.Lbl_descricao.Text = "DESCRIÇÃO:";
            // 
            // Dgv_cursos
            // 
            this.Dgv_cursos.AllowUserToAddRows = false;
            this.Dgv_cursos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_cursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_cursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_cursos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_cursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_cursos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_cursos.Location = new System.Drawing.Point(432, 82);
            this.Dgv_cursos.Name = "Dgv_cursos";
            this.Dgv_cursos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_cursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_cursos.RowHeadersWidth = 62;
            this.Dgv_cursos.Size = new System.Drawing.Size(598, 438);
            this.Dgv_cursos.TabIndex = 7;
            this.Dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_curso_CellContentClick);
            // 
            // Lbl_operacaoEscolha
            // 
            this.Lbl_operacaoEscolha.AutoSize = true;
            this.Lbl_operacaoEscolha.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_operacaoEscolha.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_operacaoEscolha.Location = new System.Drawing.Point(9, 389);
            this.Lbl_operacaoEscolha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_operacaoEscolha.Name = "Lbl_operacaoEscolha";
            this.Lbl_operacaoEscolha.Size = new System.Drawing.Size(167, 20);
            this.Lbl_operacaoEscolha.TabIndex = 42;
            this.Lbl_operacaoEscolha.Text = "O QUE DESEJA FAZER?";
            // 
            // Lbl_nomeAcao
            // 
            this.Lbl_nomeAcao.AutoSize = true;
            this.Lbl_nomeAcao.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_nomeAcao.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_nomeAcao.Location = new System.Drawing.Point(8, 140);
            this.Lbl_nomeAcao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nomeAcao.Name = "Lbl_nomeAcao";
            this.Lbl_nomeAcao.Size = new System.Drawing.Size(137, 20);
            this.Lbl_nomeAcao.TabIndex = 43;
            this.Lbl_nomeAcao.Text = "NOME DO CURSO:";
            // 
            // Frm_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.Lbl_nomeAcao);
            this.Controls.Add(this.Lbl_operacaoEscolha);
            this.Controls.Add(this.Lbl_descricao);
            this.Controls.Add(this.Lbl_buscaCurso);
            this.Controls.Add(this.Lbl_cargaHoraria);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Lbl_nomeAlterar);
            this.Controls.Add(this.Btn_relatorioCurso);
            this.Controls.Add(this.Txb_nomeAlterar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_excluiCurso);
            this.Controls.Add(this.Lbl_operacao);
            this.Controls.Add(this.MTxb_cargaHoraria);
            this.Controls.Add(this.Txb_descricao);
            this.Controls.Add(this.Btn_InsereCurso);
            this.Controls.Add(this.Txb_nomeCurso);
            this.Controls.Add(this.Txb_buscar);
            this.Controls.Add(this.Dgv_cursos);
            this.Name = "Frm_Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Frm_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txb_buscar;
        private System.Windows.Forms.Label Lbl_operacao;
        private System.Windows.Forms.MaskedTextBox MTxb_cargaHoraria;
        private System.Windows.Forms.TextBox Txb_descricao;
        private System.Windows.Forms.Button Btn_InsereCurso;
        private System.Windows.Forms.TextBox Txb_nomeCurso;
        private System.Windows.Forms.Button Btn_excluiCurso;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txb_nomeAlterar;
        private System.Windows.Forms.Button Btn_relatorioCurso;
        private System.Windows.Forms.Label Lbl_nomeAlterar;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Label Lbl_cargaHoraria;
        private System.Windows.Forms.Label Lbl_buscaCurso;
        private System.Windows.Forms.Label Lbl_descricao;
        private System.Windows.Forms.DataGridView Dgv_cursos;
        private System.Windows.Forms.Label Lbl_operacaoEscolha;
        private System.Windows.Forms.Label Lbl_nomeAcao;
    }
}

