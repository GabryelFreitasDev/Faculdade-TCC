
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
            this.RelatorioCurso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RelatorioCurso
            // 
            this.RelatorioCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelatorioCurso.LocalReport.ReportEmbeddedResource = "Faculdade.Rlt_Curso.rdlc";
            this.RelatorioCurso.Location = new System.Drawing.Point(0, 0);
            this.RelatorioCurso.Name = "RelatorioCurso";
            this.RelatorioCurso.ServerReport.BearerToken = null;
            this.RelatorioCurso.Size = new System.Drawing.Size(1134, 701);
            this.RelatorioCurso.TabIndex = 0;
            // 
            // Frm_relatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 701);
            this.Controls.Add(this.RelatorioCurso);
            this.Name = "Frm_relatorioCurso";
            this.Text = "Frm_relatorioCurso";
            this.Load += new System.EventHandler(this.Frm_relatorioCurso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RelatorioCurso;
    }
}