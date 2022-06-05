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
        DataTable dt = new DataTable();
        Frm_Materia materia = new Frm_Materia();
        Relatorios relatorios = new Relatorios();
 
        string DataSource = "materia";
        string buscaTudo = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma ORDER BY nomeCurso LIMIT 100";
        public Frm_relatorioMateria(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            materia.preencherCBcurso(Cbx_buscaCurso);
        }

        private void Frm_relatorioMateria_Load(object sender, EventArgs e)
        {
            relatorios.filtraRelatorio(relatorioMateria,buscaTudo,DataSource);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string select;
            if (!string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeMateria) LIKE '%" + Txb_buscaMateria.Text.ToLower() + "%' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria,select, DataSource);
            }
            //somente curso
            else if (string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeCurso ='" + Cbx_buscaCurso.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            //somente turma
            else if (string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeTurma ='" + Cbx_buscaTurma.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            //materia e curso
            else if (!string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeMateria) LIKE '%" + Txb_buscaMateria.Text.ToLower() + "%' and nomeCurso ='" + Cbx_buscaCurso.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            //materia e turma
            else if (!string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeMateria) LIKE '%" + Txb_buscaMateria.Text.ToLower() + "%' and nomeTurma ='" + Cbx_buscaTurma.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            //curso e turma
            else if (string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
                select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeCurso ='" + Cbx_buscaCurso.Text + "' and nomeTurma ='" + Cbx_buscaTurma.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            // materia, curso e turma
            else if (!string.IsNullOrWhiteSpace(Txb_buscaMateria.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaTurma.Text))
            {
               select = "SELECT idMateria,nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeMateria) LIKE '%" + Txb_buscaMateria.Text.ToLower() + "%' and nomeCurso ='" + Cbx_buscaCurso.Text + "' and nomeTurma ='" + Cbx_buscaTurma.Text + "' ORDER BY nomeMateria LIMIT 100";
                relatorios.filtraRelatorio(relatorioMateria, select,DataSource);
            }
            else
            {
                relatorios.filtraRelatorio(relatorioMateria, buscaTudo,DataSource);
            }
        }

        private void Cbx_buscaCurso_DropDownClosed(object sender, EventArgs e)
        {
            materia.preencherCBturma(Cbx_buscaTurma, Cbx_buscaCurso);
        }

        private void Btn_limparFiltro_Click(object sender, EventArgs e)
        {
            Cbx_buscaCurso.Text = null;
            Cbx_buscaTurma.Text = null;
            Txb_buscaMateria.Text = null;
            relatorios.filtraRelatorio(relatorioMateria, buscaTudo,DataSource);
        }
    }
}
