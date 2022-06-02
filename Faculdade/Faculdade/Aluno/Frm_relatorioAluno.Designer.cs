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
            this.SuspendLayout();
            // 
            // RelatorioAluno
            // 
            this.RelatorioAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelatorioAluno.LocalReport.ReportEmbeddedResource = "Faculdade.Aluno.Rlt_Aluno .rdlc";
            this.RelatorioAluno.Location = new System.Drawing.Point(0, 0);
            this.RelatorioAluno.Name = "RelatorioAluno";
            this.RelatorioAluno.Size = new System.Drawing.Size(1184, 661);
            this.RelatorioAluno.TabIndex = 0;
            // 
            // Frm_relatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.RelatorioAluno);
            this.MaximumSize = new System.Drawing.Size(1400, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Frm_relatorioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_relatorioAluno";
            this.Load += new System.EventHandler(this.Frm_relatorioAluno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RelatorioAluno;
    }
}