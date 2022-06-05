
namespace Faculdade
{
    partial class Frm_relatorioCurso
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
            this.relatorioCurso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_buscar = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_limparFiltro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // relatorioCurso
            // 
            this.relatorioCurso.LocalReport.ReportEmbeddedResource = "Faculdade.Curso.Rlt_Curso.rdlc";
            this.relatorioCurso.Location = new System.Drawing.Point(0, 71);
            this.relatorioCurso.Name = "relatorioCurso";
            this.relatorioCurso.ServerReport.BearerToken = null;
            this.relatorioCurso.Size = new System.Drawing.Size(712, 678);
            this.relatorioCurso.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "FILTROS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 79;
            this.label1.Text = "NOME :";
            // 
            // Txb_buscar
            // 
            this.Txb_buscar.Location = new System.Drawing.Point(16, 45);
            this.Txb_buscar.Name = "Txb_buscar";
            this.Txb_buscar.Size = new System.Drawing.Size(329, 20);
            this.Txb_buscar.TabIndex = 78;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_buscar.Location = new System.Drawing.Point(366, 37);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(94, 28);
            this.Btn_buscar.TabIndex = 81;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_limparFiltro
            // 
            this.Btn_limparFiltro.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_limparFiltro.Location = new System.Drawing.Point(582, 37);
            this.Btn_limparFiltro.Name = "Btn_limparFiltro";
            this.Btn_limparFiltro.Size = new System.Drawing.Size(118, 28);
            this.Btn_limparFiltro.TabIndex = 82;
            this.Btn_limparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_limparFiltro.UseVisualStyleBackColor = true;
            this.Btn_limparFiltro.Click += new System.EventHandler(this.Btn_limparFiltro_Click);
            // 
            // Frm_relatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 749);
            this.Controls.Add(this.Btn_limparFiltro);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_buscar);
            this.Controls.Add(this.relatorioCurso);
            this.Name = "Frm_relatorioCurso";
            this.Text = "Frm_relatorioCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_buscar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limparFiltro;
    }
}