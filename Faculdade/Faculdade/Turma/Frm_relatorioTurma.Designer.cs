
namespace Faculdade
{
    partial class Frm_relatorioTurma
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
            this.relatorioTurma = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // relatorioTurma
            // 
            this.relatorioTurma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatorioTurma.LocalReport.ReportEmbeddedResource = "Faculdade.Turma.Rlt_Turma.rdlc";
            this.relatorioTurma.Location = new System.Drawing.Point(0, 0);
            this.relatorioTurma.Name = "relatorioTurma";
            this.relatorioTurma.Size = new System.Drawing.Size(682, 508);
            this.relatorioTurma.TabIndex = 0;
            // 
            // Frm_relatorioTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 508);
            this.Controls.Add(this.relatorioTurma);
            this.Name = "Frm_relatorioTurma";
            this.Text = "Frm_relatorioTurma";
            this.Load += new System.EventHandler(this.Frm_relatorioTurma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioTurma;
    }
}