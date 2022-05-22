namespace Faculdade
{
    partial class Frm_Menu
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
            this.Btn_Aluno = new System.Windows.Forms.Button();
            this.Btn_Curso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Aluno
            // 
            this.Btn_Aluno.Location = new System.Drawing.Point(134, 94);
            this.Btn_Aluno.Name = "Btn_Aluno";
            this.Btn_Aluno.Size = new System.Drawing.Size(90, 33);
            this.Btn_Aluno.TabIndex = 0;
            this.Btn_Aluno.Text = "Aluno";
            this.Btn_Aluno.UseVisualStyleBackColor = true;
            this.Btn_Aluno.Click += new System.EventHandler(this.Btn_Aluno_Click);
            // 
            // Btn_Curso
            // 
            this.Btn_Curso.Location = new System.Drawing.Point(134, 167);
            this.Btn_Curso.Name = "Btn_Curso";
            this.Btn_Curso.Size = new System.Drawing.Size(90, 33);
            this.Btn_Curso.TabIndex = 1;
            this.Btn_Curso.Text = "Curso";
            this.Btn_Curso.UseVisualStyleBackColor = true;
            this.Btn_Curso.Click += new System.EventHandler(this.Btn_Curso_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 275);
            this.Controls.Add(this.Btn_Curso);
            this.Controls.Add(this.Btn_Aluno);
            this.Name = "Frm_Menu";
            this.Text = "Frm_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aluno;
        private System.Windows.Forms.Button Btn_Curso;
    }
}