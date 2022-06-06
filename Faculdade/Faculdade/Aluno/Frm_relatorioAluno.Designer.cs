namespace Faculdade
{
    partial class Frm_relatorioAluno
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
            this.RelatorioAluno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Cbx_buscaCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txb_buscaNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RelatorioAluno
            // 
            this.RelatorioAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelatorioAluno.LocalReport.ReportEmbeddedResource = "Faculdade.Aluno.Rlt_Aluno .rdlc";
            this.RelatorioAluno.Location = new System.Drawing.Point(0, 82);
            this.RelatorioAluno.Name = "RelatorioAluno";
            this.RelatorioAluno.ServerReport.BearerToken = null;
            this.RelatorioAluno.Size = new System.Drawing.Size(983, 736);
            this.RelatorioAluno.TabIndex = 0;
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LimparFiltro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(831, 47);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(136, 30);
            this.Btn_LimparFiltro.TabIndex = 73;
            this.Btn_LimparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Cbx_buscaCurso
            // 
            this.Cbx_buscaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaCurso.FormattingEnabled = true;
            this.Cbx_buscaCurso.Location = new System.Drawing.Point(397, 54);
            this.Cbx_buscaCurso.Name = "Cbx_buscaCurso";
            this.Cbx_buscaCurso.Size = new System.Drawing.Size(210, 21);
            this.Cbx_buscaCurso.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "CURSO:";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Btn_buscar.Location = new System.Drawing.Point(634, 43);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(111, 33);
            this.Btn_buscar.TabIndex = 76;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txb_buscaNome
            // 
            this.Txb_buscaNome.Location = new System.Drawing.Point(19, 54);
            this.Txb_buscaNome.Name = "Txb_buscaNome";
            this.Txb_buscaNome.Size = new System.Drawing.Size(329, 20);
            this.Txb_buscaNome.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "NOME DO ALUNO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "FILTROS:";
            // 
            // Frm_relatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 697);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LimparFiltro);
            this.Controls.Add(this.Cbx_buscaCurso);
            this.Controls.Add(this.Txb_buscaNome);
            this.Controls.Add(this.RelatorioAluno);
            this.Name = "Frm_relatorioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Aluno";
            this.Load += new System.EventHandler(this.Frm_relatorioAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RelatorioAluno;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        public System.Windows.Forms.ComboBox Cbx_buscaCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txb_buscaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}