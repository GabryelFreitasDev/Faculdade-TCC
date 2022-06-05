
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
    public partial class Frm_relatorioMateria : Form
    {
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();
        string buscaTudo = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma ORDER BY nomeCurso LIMIT 100";
        public Frm_relatorioMateria(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
        }

        private DataTable geraRelatorio(string select)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.conn;
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = select;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        private void Frm_relatorioMateria_Load(object sender, EventArgs e)
        {
            this.relatorioMateria.LocalReport.DataSources.Clear();
            ReportDataSource relatorio = new ReportDataSource("materia", geraRelatorio(buscaTudo));
            this.relatorioMateria.LocalReport.DataSources.Add(relatorio);
            this.relatorioMateria.RefreshReport();
        }
    }
}
