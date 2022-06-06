
namespace Faculdade
{
    partial class Frm_contaCursos
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
            this.Lbl_contadorCursos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_contadorCursos
            // 
            this.Lbl_contadorCursos.AutoSize = true;
            this.Lbl_contadorCursos.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contadorCursos.Location = new System.Drawing.Point(357, 135);
            this.Lbl_contadorCursos.Name = "Lbl_contadorCursos";
            this.Lbl_contadorCursos.Size = new System.Drawing.Size(0, 128);
            this.Lbl_contadorCursos.TabIndex = 0;
            // 
            // Frm_contaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_contadorCursos);
            this.Name = "Frm_contaCursos";
            this.Text = "Conta cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_contadorCursos;
    }
}