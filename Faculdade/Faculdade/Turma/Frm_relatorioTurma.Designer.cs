
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
            this.Btn_LimparFiltro = new System.Windows.Forms.Button();
            this.Cbx_buscaTurno = new System.Windows.Forms.ComboBox();
            this.Txb_buscaTurma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // relatorioTurma
            // 
            this.relatorioTurma.LocalReport.ReportEmbeddedResource = "Faculdade.Turma.Rlt_Turma.rdlc";
            this.relatorioTurma.Location = new System.Drawing.Point(0, 73);
            this.relatorioTurma.Name = "relatorioTurma";
            this.relatorioTurma.ServerReport.BearerToken = null;
            this.relatorioTurma.Size = new System.Drawing.Size(682, 435);
            this.relatorioTurma.TabIndex = 0;
            // 
            // Btn_LimparFiltro
            // 
            this.Btn_LimparFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_LimparFiltro.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_LimparFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_LimparFiltro.Location = new System.Drawing.Point(546, 40);
            this.Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            this.Btn_LimparFiltro.Size = new System.Drawing.Size(124, 27);
            this.Btn_LimparFiltro.TabIndex = 93;
            this.Btn_LimparFiltro.Text = "LIMPAR FILTRO";
            this.Btn_LimparFiltro.UseVisualStyleBackColor = true;
            this.Btn_LimparFiltro.Click += new System.EventHandler(this.Btn_LimparFiltro_Click);
            // 
            // Cbx_buscaTurno
            // 
            this.Cbx_buscaTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_buscaTurno.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.Cbx_buscaTurno.FormattingEnabled = true;
            this.Cbx_buscaTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno",
            "Integral"});
            this.Cbx_buscaTurno.Location = new System.Drawing.Point(331, 44);
            this.Cbx_buscaTurno.Name = "Cbx_buscaTurno";
            this.Cbx_buscaTurno.Size = new System.Drawing.Size(108, 23);
            this.Cbx_buscaTurno.TabIndex = 92;
            // 
            // Txb_buscaTurma
            // 
            this.Txb_buscaTurma.Location = new System.Drawing.Point(12, 44);
            this.Txb_buscaTurma.Name = "Txb_buscaTurma";
            this.Txb_buscaTurma.Size = new System.Drawing.Size(301, 20);
            this.Txb_buscaTurma.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "FILTROS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "NOME DO CURSO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 96;
            this.label2.Text = "TURNO:";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_buscar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_buscar.Location = new System.Drawing.Point(445, 40);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(83, 27);
            this.Btn_buscar.TabIndex = 97;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Frm_relatorioTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 508);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LimparFiltro);
            this.Controls.Add(this.Cbx_buscaTurno);
            this.Controls.Add(this.Txb_buscaTurma);
            this.Controls.Add(this.relatorioTurma);
            this.Name = "Frm_relatorioTurma";
            this.Text = "Frm_relatorioTurma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer relatorioTurma;
        private System.Windows.Forms.Button Btn_LimparFiltro;
        private System.Windows.Forms.ComboBox Cbx_buscaTurno;
        private System.Windows.Forms.TextBox Txb_buscaTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_buscar;
    }
}