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
    public partial class Frm_Materia : Form
    {
        DataTable dt = new DataTable();
        Verifica verifica = new Verifica();
        Busca busca = new Busca();

        public Frm_Materia()
        {
            InitializeComponent();
            AtualizaDataGridView();
            preencherCBcurso(Cbx_cursoMateria);
            preencherCBturma(Cbx_Turma);
            preencherCBcurso(Cbx_buscaCurso);
            preencherCBturma(Cbx_buscaTurma);
        }
        public void AtualizaDataGridView()
        {
            string select = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma ORDER BY nomeMateria LIMIT 100";
            busca.AtualizaDataGridView(select, Dgv_materias);
            //EditaColunaDgv();
        }

        public void BuscaTurmaDataGridView()
        {

            string selectTurno = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeTurma ='" + Cbx_buscaTurma.Text + "'  ORDER BY nomeMateria LIMIT 100";
            busca.BuscaDataGridView(Cbx_buscaTurma,selectTurno,Dgv_materias);
            //EditaColunaDgv();
        }

        public void BuscaDataGridView()
        {
            //string selectText = "SELECT nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE Curso.nomeCurso LIKE '%" + Txb_buscaTurma.Text + "%' ORDER BY nomeTurma LIMIT 100";
            //busca.AtualizaDataGridView(selectText, Dgv_turmas);
            //EditaColunaDgv();
        }

        private void preencherCBcurso(ComboBox cb)
        {
            string selectCurso = "SELECT idCurso, nomeCurso from Curso ORDER BY nomeCurso";
            string valueMember = "idCurso";
            string displayMember = "nomeCurso";
            busca.preencherComboBox(cb, selectCurso, valueMember, displayMember);
            preencherCBturma(Cbx_buscaTurma);
            preencherCBturma(Cbx_Turma);
        }

        private void preencherCBturma(ComboBox cb)
        {
            string selectCurso = "SELECT idTurma,nomeTurma,nomeCurso FROM Turma INNER JOIN Curso on FK_idCurso = idCurso WHERE nomeCurso ='" + Cbx_buscaCurso.Text + "' ORDER BY nomeTurma";
            string valueMember = "idTurma";
            string displayMember = "nomeTurma";
            busca.preencherComboBox(cb, selectCurso, valueMember, displayMember);
        }

        private void confereCampos()
        {
            verifica.VerificaNullorWhiteSpace(Txb_nomeMateria.Text);
            verifica.VerificaNullorWhiteSpace(Txb_descricao.Text);
            verifica.VerificaCbxVazio(Cbx_cursoMateria);
            verifica.VerificaCbxVazio(Cbx_Turma);
        }

        private void validaCampos(Materia materia)
        {
            if (string.IsNullOrWhiteSpace(Txb_nomeMateria.Text))
            {
                materia.mensagem = "Insira o nome da matéria";
            }
            else if (string.IsNullOrWhiteSpace(Txb_descricao.Text))
            {
                materia.mensagem = "Insira o nome da descrição";
            }
            else if (Cbx_Turma.SelectedItem == null)
            {
                materia.mensagem = "Insira a turma em que matéria pertence";
            }
            else if (Cbx_cursoMateria.SelectedItem == null)
            {
                materia.mensagem = "Escolha o curso que a matéria pertence";
            }
            MessageBox.Show(materia.mensagem);
        } 

        private void Btn_inserir_Click(object sender, EventArgs e)
        {
            Materia inserir = new Materia();
            try
            {
                confereCampos();
                inserir.Inserir(Txb_nomeMateria.Text,Txb_descricao.Text,(int)Cbx_cursoMateria.SelectedValue,(int)Cbx_Turma.SelectedValue);
                MessageBox.Show(inserir.mensagem);
            }
            catch(NullReferenceException)
            {
                validaCampos(inserir);
            }
            catch(Exception ex)
            {
                inserir.mensagem = "Erro na inserção:" + ex.Message;
                MessageBox.Show(inserir.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Materia editar = new Materia();
            try
            {
                verifica.VerificaNullorWhiteSpace(Txb_nomeAlterar.Text);
                confereCampos();
                editar.Editar(Txb_nomeAlterar.Text,Txb_nomeMateria.Text,Txb_descricao.Text, (int)Cbx_cursoMateria.SelectedValue, (int)Cbx_Turma.SelectedValue);
                MessageBox.Show(editar.mensagem);
            }
            catch(NullReferenceException)
            {
                if (string.IsNullOrWhiteSpace(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Digite o nome da matéria que deseja alterar";
                }
                validaCampos(editar);
            }
            catch(Exception ex)
            {
                editar.mensagem = "Erro na inserção:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Cbx_buscaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCBturma(Cbx_buscaTurma);
        }

        private void Cbx_cursoMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCBturma(Cbx_Turma);
        }
    }
}
