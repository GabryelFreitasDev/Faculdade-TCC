﻿using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
    public partial class Frm_relatorioCurso : Form
    {
       
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();

        public Frm_relatorioCurso(DataTable dt)
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
            cmd.CommandText = "SELECT * FROM \"curso\""; 
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        private void Frm_relatorioCurso_Load(object sender, EventArgs e)
        {
            relatorioCurso.LocalReport.DataSources.Clear();
            ReportDataSource relatorio = new ReportDataSource("cursos", geraRelatorio());
            this.relatorioCurso.LocalReport.DataSources.Add(relatorio);
            this.relatorioCurso.RefreshReport();
            this.relatorioCurso.RefreshReport();
        }
    }
}