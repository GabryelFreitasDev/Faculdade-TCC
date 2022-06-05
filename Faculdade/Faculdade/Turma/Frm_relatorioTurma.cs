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
        Relatorios relatorios = new Relatorios();
        string buscaTudo = "SELECT idTurma,nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso";
        string turma = "turma";
        public Frm_relatorioTurma(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            relatorios.filtraRelatorio(relatorioTurma,buscaTudo,turma);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //Filtra somente pelo nome do curso
            if (!string.IsNullOrWhiteSpace(Txb_buscaTurma.Text) && string.IsNullOrWhiteSpace(Cbx_buscaTurno.Text))
            {
                string selectText = "SELECT idTurma,nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE lower(Curso.nomeCurso) LIKE '%" + Txb_buscaTurma.Text.ToLower() + "%' ORDER BY nomeTurma LIMIT 100";
                relatorios.filtraRelatorio(relatorioTurma, selectText, turma);
            }
            // Fltra somente pelo turno
            else if (string.IsNullOrWhiteSpace(Txb_buscaTurma.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurno.Text))
            {
                string selectTurno = "SELECT idTurma,nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE turno = '" + Cbx_buscaTurno.Text + "' ORDER BY nomeTurma LIMIT 100";
                relatorios.filtraRelatorio(relatorioTurma, selectTurno, turma);
            }
            //Filtra em conjunto
            else if (!string.IsNullOrWhiteSpace(Txb_buscaTurma.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurno.Text))
            {
                string selectTextTurno = "SELECT idTurma,nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE lower(Curso.nomeCurso) LIKE '%" + Txb_buscaTurma.Text.ToLower() + "%' and turno = '" + Cbx_buscaTurno.Text + "' ORDER BY nomeTurma LIMIT 100";
                relatorios.filtraRelatorio(relatorioTurma, selectTextTurno, turma);
            }
            else
            {
                relatorios.filtraRelatorio(relatorioTurma, buscaTudo, turma);
            }
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaTurma.Text = null;
            Cbx_buscaTurno.Text = null;
            relatorios.filtraRelatorio(relatorioTurma, buscaTudo, turma);
        }
    }
}
