using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Frm_relatorioCurso : Form
    {
        DataTable dt = new DataTable();
        Relatorios relatorios = new Relatorios();

        string buscaTudo = "SELECT * FROM Curso";
        string cursos = "cursos";
        public Frm_relatorioCurso(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            relatorios.filtraRelatorio(relatorioCurso, buscaTudo, cursos);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Curso WHERE lower(nomeCurso) LIKE '%" + Txb_buscar.Text.ToLower() + "%' ORDER BY nomeCurso LIMIT 100";
            relatorios.filtraRelatorio(relatorioCurso, select, cursos);
        }

        private void Btn_limparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscar.Text = null;
            relatorios.filtraRelatorio(relatorioCurso, buscaTudo, cursos);
        }
    }
}