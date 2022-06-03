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
    public partial class Frm_relatorioAluno : Form
    {
        Conexao conexao = new Conexao();
        DataTable dt = new DataTable();
        string buscaTudo = "SELECT idAluno,nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on FK_idCurso = idCurso INNER JOIN Turma on FK_idTurma = idTurma";
        public Frm_relatorioAluno(DataTable dt)
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

        private void Frm_relatorioAluno_Load(object sender, EventArgs e)
        {
            this.RelatorioAluno.LocalReport.DataSources.Clear();
            ReportDataSource relatorio = new ReportDataSource("aluno", geraRelatorio(buscaTudo));
            this.RelatorioAluno.LocalReport.DataSources.Add(relatorio);
            this.RelatorioAluno.RefreshReport();
        }
    }
}
