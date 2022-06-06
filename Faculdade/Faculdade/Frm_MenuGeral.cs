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
    public partial class Frm_menuGeral : Form
    {
        Conexao db;
        string selectCurso = "SELECT nomeCurso FROM Curso";
        string selectAluno = "SELECT nomeAluno FROM Aluno";
        string selectTurma = "SELECT nomeTurma FROM Turma";
        string selectMateria = "SELECT nomeMateria FROM Materia";
        public Frm_menuGeral()
        {
            InitializeComponent();
            Lbl_contadorCursos.Text = contador(selectCurso);
            Lbl_contadorTurmas.Text = contador(selectAluno);
            Lbl_contadorAlunos.Text = contador(selectTurma);
            Lbl_contadorMaterias.Text = contador(selectMateria);
        }
        private string contador(string contador)
        {
            db = new Conexao();
            var SQL = contador;
            var dt = db.NpgSQLQuery(SQL);
            string quantia = dt.Rows.Count.ToString();
            return quantia;
        }
    }
}
