
namespace Faculdade
{
    partial class Frm_relatorioMateria
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
            this.relatorioMateria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Txb_buscaMateria = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Filtro = new System.Windows.Forms.Label();
            this.Cbx_buscaTurma = new System.Windows.Forms.ComboBox();
            this.Cbx_buscaCurso = new System.Windows.Forms.ComboBox();
            this.Btn_limparFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // relatorioMateria
            // 
            this.relatorioMateria.LocalReport.ReportEmbeddedResource = "Faculdade.Materia.Rlt_Materia.rdlc";
            this.relatorioMateria.Location = new System.Drawing.Point(0, 73);
            this.relatorioMateria.Name = "relatorioMateria";
            this.relatorioMateria.ServerReport.BearerToken = null;
            this.relatorioMateria.Size = new System.Drawing.Size(800, 425);
            this.relatorioMateria.TabIndex = 0;
            // 
            // Txb_buscaMateria
            // 
            this.Txb_buscaMateria.Location = new System.Drawing.Point(12, 47);
            this.Txb_buscaMateria.Name = "Txb_buscaMateria";
            this.Txb_buscaMateria.Size = new System.Drawing.Size(438, 20);
            this.Txb_buscaMateria.TabIndex = 1;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.Location = new System.Drawing.Point(681, 31);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(107, 36);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Filtro
            // 
            this.Lbl_Filtro.AutoSize = true;
            this.Lbl_Filtro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Filtro.Location = new System.Drawing.Point(8, 23);
            this.Lbl_Filtro.Name = "Lbl_Filtro";
            this.Lbl_Filtro.Size = new System.Drawing.Size(163, 21);
            this.Lbl_Filtro.TabIndex = 95;
            this.Lbl_Filtro.Text = "NOME DA MATÉRIA:";
            // 
            // Cbx_buscaTurma
            // 
            this.Cbx_buscaTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaTurma.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_buscaTurma.FormattingEnabled = true;
            this.Cbx_buscaTurma.Location = new System.Drawing.Point(584, 44);
            this.Cbx_buscaTurma.Name = "Cbx_buscaTurma";
            this.Cbx_buscaTurma.Size = new System.Drawing.Size(79, 23);
            this.Cbx_buscaTurma.TabIndex = 93;
            // 
            // Cbx_buscaCurso
            // 
            this.Cbx_buscaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaCurso.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_buscaCurso.FormattingEnabled = true;
            this.Cbx_buscaCurso.Location = new System.Drawing.Point(456, 44);
            this.Cbx_buscaCurso.Name = "Cbx_buscaCurso";
            this.Cbx_buscaCurso.Size = new System.Drawing.Size(122, 23);
            this.Cbx_buscaCurso.TabIndex = 94;
            this.Cbx_buscaCurso.DropDownClosed += new System.EventHandler(this.Cbx_buscaCurso_DropDownClosed);
            // 
            // Btn_limparFiltro
            // 
            this.Btn_limparFiltro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limparFiltro.Location = new System.Drawing.Point(681, 1);
            this.Btn_limparFiltro.Name = "Btn_limparFiltro";
            this.Btn_limparFiltro.Size = new System.Drawing.Size(119, 23);
            this.Btn_limparFiltro.TabIndex = 96;
            this.Btn_limparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_limparFiltro.UseVisualStyleBackColor = true;
            this.Btn_limparFiltro.Click += new System.EventHandler(this.Btn_limparFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 97;
            this.label1.Text = "FILTROS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "CURSO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "TURMA:";
            // 
            // Frm_relatorioMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_limparFiltro);
            this.Controls.Add(this.Lbl_Filtro);
            this.Controls.Add(this.Cbx_buscaCurso);
            this.Controls.Add(this.Cbx_buscaTurma);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txb_buscaMateria);
            this.Controls.Add(this.relatorioMateria);
            this.Name = "Frm_relatorioMateria";
            this.Text = "Frm_relatorioMateria";
            this.Load += new System.EventHandler(this.Frm_relatorioMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioMateria;
        private System.Windows.Forms.TextBox Txb_buscaMateria;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Filtro;
        public System.Windows.Forms.ComboBox Cbx_buscaTurma;
        public System.Windows.Forms.ComboBox Cbx_buscaCurso;
        private System.Windows.Forms.Button Btn_limparFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}