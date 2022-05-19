
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_excluiCurso = new System.Windows.Forms.Button();
            this.Txb_excluiCurso = new System.Windows.Forms.TextBox();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Txb_nomeAlterar = new System.Windows.Forms.TextBox();
            this.Txb_nomeNovo = new System.Windows.Forms.TextBox();
            this.Dgv_Cursos = new System.Windows.Forms.DataGridView();
            this.Btn_atualizaDgv = new System.Windows.Forms.Button();
            this.Cbx_Turno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_excluiCurso
            // 
            this.Btn_excluiCurso.Location = new System.Drawing.Point(219, 196);
            this.Btn_excluiCurso.Name = "Btn_excluiCurso";
            this.Btn_excluiCurso.Size = new System.Drawing.Size(75, 23);
            this.Btn_excluiCurso.TabIndex = 2;
            this.Btn_excluiCurso.Text = "button2";
            this.Btn_excluiCurso.UseVisualStyleBackColor = true;
            this.Btn_excluiCurso.Click += new System.EventHandler(this.Btn_excluiCurso_Click);
            // 
            // Txb_excluiCurso
            // 
            this.Txb_excluiCurso.Location = new System.Drawing.Point(113, 196);
            this.Txb_excluiCurso.Name = "Txb_excluiCurso";
            this.Txb_excluiCurso.Size = new System.Drawing.Size(100, 20);
            this.Txb_excluiCurso.TabIndex = 3;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(224, 287);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Editar.TabIndex = 4;
            this.Btn_Editar.Text = "button2";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Txb_nomeAlterar
            // 
            this.Txb_nomeAlterar.Location = new System.Drawing.Point(113, 255);
            this.Txb_nomeAlterar.Name = "Txb_nomeAlterar";
            this.Txb_nomeAlterar.Size = new System.Drawing.Size(100, 20);
            this.Txb_nomeAlterar.TabIndex = 5;
            // 
            // Txb_nomeNovo
            // 
            this.Txb_nomeNovo.Location = new System.Drawing.Point(113, 290);
            this.Txb_nomeNovo.Name = "Txb_nomeNovo";
            this.Txb_nomeNovo.Size = new System.Drawing.Size(100, 20);
            this.Txb_nomeNovo.TabIndex = 6;
            // 
            // Dgv_Cursos
            // 
            this.Dgv_Cursos.AllowUserToAddRows = false;
            this.Dgv_Cursos.AllowUserToDeleteRows = false;
            this.Dgv_Cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cursos.Location = new System.Drawing.Point(506, 144);
            this.Dgv_Cursos.Name = "Dgv_Cursos";
            this.Dgv_Cursos.ReadOnly = true;
            this.Dgv_Cursos.Size = new System.Drawing.Size(240, 150);
            this.Dgv_Cursos.TabIndex = 7;
            // 
            // Btn_atualizaDgv
            // 
            this.Btn_atualizaDgv.Location = new System.Drawing.Point(566, 353);
            this.Btn_atualizaDgv.Name = "Btn_atualizaDgv";
            this.Btn_atualizaDgv.Size = new System.Drawing.Size(75, 23);
            this.Btn_atualizaDgv.TabIndex = 8;
            this.Btn_atualizaDgv.Text = "button2";
            this.Btn_atualizaDgv.UseVisualStyleBackColor = true;
            this.Btn_atualizaDgv.Click += new System.EventHandler(this.Btn_atualizaDgv_Click);
            // 
            // Cbx_Turno
            // 
            this.Cbx_Turno.FormattingEnabled = true;
            this.Cbx_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.Cbx_Turno.Location = new System.Drawing.Point(369, 95);
            this.Cbx_Turno.Name = "Cbx_Turno";
            this.Cbx_Turno.Size = new System.Drawing.Size(125, 21);
            this.Cbx_Turno.TabIndex = 9;
            // 
            // Frm_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.Cbx_Turno);
            this.Controls.Add(this.Btn_atualizaDgv);
            this.Controls.Add(this.Dgv_Cursos);
            this.Controls.Add(this.Txb_nomeNovo);
            this.Controls.Add(this.Txb_nomeAlterar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Txb_excluiCurso);
            this.Controls.Add(this.Btn_excluiCurso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Frm_Curso";
            this.Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_excluiCurso;
        private System.Windows.Forms.TextBox Txb_excluiCurso;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.TextBox Txb_nomeAlterar;
        private System.Windows.Forms.TextBox Txb_nomeNovo;
        private System.Windows.Forms.DataGridView Dgv_Cursos;
        private System.Windows.Forms.Button Btn_atualizaDgv;
        private System.Windows.Forms.ComboBox Cbx_Turno;
    }
}

