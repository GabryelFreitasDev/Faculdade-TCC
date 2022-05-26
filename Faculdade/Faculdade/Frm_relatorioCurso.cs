using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Frm_relatorioCurso : Form
    {
        DataTable dt = new DataTable();
        public Frm_relatorioCurso(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void Frm_relatorioCurso_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Data", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
