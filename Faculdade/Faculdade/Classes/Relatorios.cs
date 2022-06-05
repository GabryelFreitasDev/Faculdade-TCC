using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Relatorios
    {
        Conexao conexao = new Conexao();
        public DataTable geraRelatorio(string select)
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

        public void filtraRelatorio(ReportViewer documento, string select, string DataSource)
        {
            documento.LocalReport.DataSources.Clear();
            ReportDataSource relatorio = new ReportDataSource(DataSource, geraRelatorio(select));
            documento.LocalReport.DataSources.Add(relatorio);
            documento.RefreshReport();
        }
    }
}
