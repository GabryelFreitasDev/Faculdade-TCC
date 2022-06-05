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
        DataTable dt = new DataTable();
        Relatorios relatorios = new Relatorios();
        Frm_Aluno alunos = new Frm_Aluno(); 

        string aluno = "aluno";
        string buscaTudo = "SELECT idAluno,nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on FK_idCurso = idCurso INNER JOIN Turma on FK_idTurma = idTurma";
        public Frm_relatorioAluno(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            relatorios.filtraRelatorio(RelatorioAluno, buscaTudo, aluno);
        }
        private void Frm_relatorioAluno_Load(object sender, EventArgs e)
        {
            alunos.preencheCurso(Cbx_buscaCurso);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string select;
            //somente nome
            if (!string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
               select = "SELECT idAluno, nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeAluno) LIKE '%" + Txb_buscaNome.Text.ToLower() + "%' ORDER BY nomeAluno LIMIT 100";
               relatorios.filtraRelatorio(RelatorioAluno, select, aluno);

            }
            //somente curso
            else if (string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                select = "SELECT idAluno,nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeCurso = '" + Cbx_buscaCurso.Text + "' ORDER BY nomeAluno LIMIT 100";
                relatorios.filtraRelatorio(RelatorioAluno, select, aluno);
            }
            //nome e curso
            else if (!string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                select = "SELECT idAluno,nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeAluno) LIKE '%" + Txb_buscaNome.Text.ToLower() + "%' and nomeCurso = '" + Cbx_buscaCurso.Text + "' ORDER BY nomeAluno LIMIT 100";
                relatorios.filtraRelatorio(RelatorioAluno, select, aluno);
            }
            else
            {
                relatorios.filtraRelatorio(RelatorioAluno, buscaTudo, aluno);
            }
        }
        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaNome.Text = null;
            Cbx_buscaCurso.Text = null;
            relatorios.filtraRelatorio(RelatorioAluno, buscaTudo, aluno);
        }
    }
}
