namespace Faculdade
{
    partial class Frm_Turma
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
            this.Btn_insereTurma = new System.Windows.Forms.Button();
            this.Txb_nomeTurma = new System.Windows.Forms.TextBox();
            this.Cbx_cursoTurma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_insereTurma
            // 
            this.Btn_insereTurma.Location = new System.Drawing.Point(563, 131);
            this.Btn_insereTurma.Name = "Btn_insereTurma";
            this.Btn_insereTurma.Size = new System.Drawing.Size(75, 23);
            this.Btn_insereTurma.TabIndex = 0;
            this.Btn_insereTurma.Text = "INSERIR";
            this.Btn_insereTurma.UseVisualStyleBackColor = true;
            this.Btn_insereTurma.Click += new System.EventHandler(this.Btn_insereTurma_Click);
            // 
            // Txb_nomeTurma
            // 
            this.Txb_nomeTurma.Location = new System.Drawing.Point(37, 74);
            this.Txb_nomeTurma.Name = "Txb_nomeTurma";
            this.Txb_nomeTurma.Size = new System.Drawing.Size(461, 20);
            this.Txb_nomeTurma.TabIndex = 1;
            // 
            // Cbx_cursoTurma
            // 
            this.Cbx_cursoTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_cursoTurma.FormattingEnabled = true;
            this.Cbx_cursoTurma.Location = new System.Drawing.Point(575, 74);
            this.Cbx_cursoTurma.Name = "Cbx_cursoTurma";
            this.Cbx_cursoTurma.Size = new System.Drawing.Size(104, 21);
            this.Cbx_cursoTurma.TabIndex = 2;
            // 
            // Frm_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(59)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(698, 180);
            this.Controls.Add(this.Cbx_cursoTurma);
            this.Controls.Add(this.Txb_nomeTurma);
            this.Controls.Add(this.Btn_insereTurma);
            this.Name = "Frm_Turma";
            this.Text = "Turma";
            this.Load += new System.EventHandler(this.Frm_Turma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_insereTurma;
        private System.Windows.Forms.TextBox Txb_nomeTurma;
        private System.Windows.Forms.ComboBox Cbx_cursoTurma;
    }
}