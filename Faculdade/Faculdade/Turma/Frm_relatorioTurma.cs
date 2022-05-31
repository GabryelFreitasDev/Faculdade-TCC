using Microsoft.Reporting.WinForms;
using Npgsql;
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
    public partial class Frm_relatorioTurma : Form
    {
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();
        public Frm_relatorioTurma(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
        }
        private DataTable geraRelatorio()
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.conn;
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idTurma,nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        private void Frm_relatorioTurma_Load(object sender, EventArgs e)
        {
            relatorioTurma.LocalReport.DataSources.Clear();
            ReportDataSource relatorio = new ReportDataSource("turma", geraRelatorio());
            this.relatorioTurma.LocalReport.DataSources.Add(relatorio);
            this.relatorioTurma.RefreshReport();
            this.relatorioTurma.RefreshReport();
        }
    }
}
