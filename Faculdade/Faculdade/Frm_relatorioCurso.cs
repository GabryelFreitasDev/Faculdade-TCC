using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Frm_relatorioCurso : Form
    {
        DataTable dt = new DataTable();
        Conexao conexao = new Conexao();
        public Frm_relatorioCurso(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void Frm_relatorioCurso_Load(object sender, EventArgs e)
        {
            this.RelatorioCurso.LocalReport.DataSources.Clear();
            this.RelatorioCurso.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Data", dt));
            this.RelatorioCurso.RefreshReport();
        }
    }
}
