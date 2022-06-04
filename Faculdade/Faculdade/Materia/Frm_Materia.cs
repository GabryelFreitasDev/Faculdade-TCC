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
            preencherCBturma(Cbx_buscaTurma, Cbx_buscaCurso);
            preencherCBturma(Cbx_Turma, Cbx_cursoMateria);
            preencherCBcurso(Cbx_buscaCurso);
            someCampos(false);
        }
        private void Frm_Materia_Load(object sender, EventArgs e)
        {
            Cbx_cursoMateria.SelectedItem = null;
            Cbx_buscaCurso.SelectedItem = null;
        }

        private void EditaColunaDgv()
        {
            Dgv_materias.Columns[0].HeaderText = "MATÉRIA";
            Dgv_materias.Columns[1].HeaderText = "DESCRIÇÃO";
            Dgv_materias.Columns[2].HeaderText = "CURSO";
            Dgv_materias.Columns[3].HeaderText = "TURMA";
        }
        private void someCampos(bool tf)
        {
            Txb_nomeAlterar.Visible = tf;
            Lbl_nomeAlterar.Visible = tf;
        }

        private void Dgv_materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Dgv_materias.Rows[e.RowIndex];
                if (!Txb_nomeAlterar.Visible)
                {
                    Txb_nomeMateria.Text = row.Cells["nomeMateria"].Value.ToString();
                    Txb_nomeAlterar.Text = row.Cells["nomeMateria"].Value.ToString();
                    Txb_descricao.Text = row.Cells["descricaoMateria"].Value.ToString();
                    Cbx_cursoMateria.Text = row.Cells["nomeCurso"].Value.ToString();
                    Cbx_buscaTurma.Text = row.Cells["nomeTurma"].Value.ToString();
                }
                else
                {
                    Txb_nomeAlterar.Text = row.Cells["nomeMateria"].Value.ToString();
                    Txb_nomeMateria.Clear();
                    Cbx_cursoMateria.Text = row.Cells["nomeCurso"].Value.ToString();
                    Cbx_buscaTurma.Text = row.Cells["nomeTurma"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
        }

        public void AtualizaDataGridView()
        {
            string select = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma ORDER BY nomeMateria LIMIT 100";
            busca.AtualizaDataGridView(select, Dgv_materias);
            EditaColunaDgv();
        }

        public void BuscaTurmaDataGridView()
        {
            string selectTurno = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeTurma ='" + Cbx_buscaTurma.Text + "'  ORDER BY nomeMateria LIMIT 100";
            busca.BuscaDataGridView(Cbx_buscaTurma, selectTurno, Dgv_materias);
            EditaColunaDgv();
        }

        public void BuscaNomeDataGridView()
        {
            string selectText = "SELECT nomeMateria, descricaoMateria, nomeCurso, nomeTurma FROM Materia INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeTurma ='" + Txb_buscaMateria.Text + "'  ORDER BY nomeMateria LIMIT 100";
            busca.AtualizaDataGridView(selectText, Dgv_materias);
            EditaColunaDgv();
        }

        private void preencherCBcurso(ComboBox cb)
        {
            string selectCurso = "SELECT idCurso, nomeCurso FROM Curso ORDER BY nomeCurso";
            string valueMember = "idCurso";
            string displayMember = "nomeCurso";
            busca.preencherComboBox(cb, selectCurso, valueMember, displayMember);
        }

        private void preencherCBturma(ComboBox cb, ComboBox parametro)
        {
            string selectCurso = "SELECT idTurma,nomeTurma,nomeCurso FROM Turma INNER JOIN Curso on FK_idCurso = idCurso WHERE nomeCurso ='" + parametro.Text + "' ORDER BY nomeTurma";
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
                if (!Lbl_nomeAlterar.Visible)
                {
                    confereCampos();
                    inserir.Inserir(Txb_nomeMateria.Text, Txb_descricao.Text, (int)Cbx_cursoMateria.SelectedValue, (int)Cbx_Turma.SelectedValue);
                    MessageBox.Show(inserir.mensagem);
                }
                else
                {
                    someCampos(false);
                    Lbl_nome.Text = "INSERIR";
                }
            }
            catch (NullReferenceException)
            {
                validaCampos(inserir);
            }
            catch (Exception ex)
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
                if (Lbl_nomeAlterar.Visible)
                {
                    verifica.VerificaNullorWhiteSpace(Txb_nomeAlterar.Text);
                    confereCampos();
                    if(MessageBox.Show("Deseja realmente editar a matéria " + Txb_nomeAlterar.Text + " do curso de " + Cbx_cursoMateria.Text + " da turma " + Cbx_Turma.Text + "?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        editar.Editar(Txb_nomeAlterar.Text, Txb_nomeMateria.Text, Txb_descricao.Text, (int)Cbx_cursoMateria.SelectedValue, (int)Cbx_Turma.SelectedValue);
                        MessageBox.Show(editar.mensagem);
                    }
                }
                else
                {
                    someCampos(true);
                    Lbl_nome.Text = "EDITAR";
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrWhiteSpace(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Digite o nome da matéria que deseja alterar";
                }
                validaCampos(editar);
            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            Materia excluir = new Materia();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_nome.Text == "EXCLUIR")
                {
                    confereCampos();
                    if (MessageBox.Show("Deseja realmente excluir a matéria " + Txb_nomeAlterar.Text + " do curso de " + Cbx_cursoMateria.Text + " da turma " + Cbx_Turma.Text + "?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeMateria.Text);
                        MessageBox.Show(excluir.mensagem);
                    }
                }
                else
                {
                    someCampos(false);
                    Lbl_nome.Text = "EXCLUIR";
                }
            }
            catch (NullReferenceException)
            {
                validaCampos(excluir);
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na exclusão:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Cbx_buscaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCBturma(Cbx_buscaTurma, Cbx_buscaCurso);
        }

        private void Cbx_cursoMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCBturma(Cbx_Turma, Cbx_cursoMateria);
        }

        private void Txb_buscaMateria_TextChanged(object sender, EventArgs e)
        {
            BuscaNomeDataGridView();
        }

        private void Cbx_cursoMateria_DropDown(object sender, EventArgs e)
        {
            preencherCBcurso(Cbx_cursoMateria);
        }

        private void Cbx_buscaCurso_DropDown(object sender, EventArgs e)
        {
            preencherCBcurso(Cbx_buscaCurso);
        }
    }
}
