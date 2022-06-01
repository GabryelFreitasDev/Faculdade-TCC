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
    public partial class Frm_Turma : Form
    {
        DataTable dt = new DataTable();
        Verifica verifica = new Verifica();
        Busca busca = new Busca();

        public Frm_Turma()
        {
            InitializeComponent();
            AtualizaDataGridView();
            EditaColunaDgv();
        }

        private void Frm_Turma_Load(object sender, EventArgs e)
        {

            Cbx_cursoTurma.SelectedItem = null;
            Cbx_Turno.SelectedItem = null;
            Cbx_cursoAntigo.SelectedItem = null;
            someCampos(false);
            preencherCBcurso(Cbx_cursoTurma);
            preencherCBcurso(Cbx_cursoAntigo);
        }

        private void EditaColunaDgv()
        {
            Dgv_turmas.RowHeadersVisible = false;
            Dgv_turmas.Columns[0].HeaderText = "TURMA";
            Dgv_turmas.Columns[0].Width = 100;
            Dgv_turmas.Columns[1].HeaderText = "TURNO";
            Dgv_turmas.Columns[1].Width = 80;
            Dgv_turmas.Columns[2].HeaderText = "CURSO";
            Dgv_turmas.Columns[2].Width = 280;
        }

        public void AtualizaDataGridView()
        {
            string select = "SELECT nomeTurma, turno, nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso ORDER BY nomeCurso LIMIT 100";
            busca.AtualizaDataGridView(select, Dgv_turmas);
            EditaColunaDgv();
        }

        public void BuscaTurnoDataGridView()
        {

            string selectTurno = "SELECT nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE turno = '" + Cbx_buscaTurno.Text + "' ORDER BY nomeTurma LIMIT 100";
            busca.BuscaDataGridView(Cbx_buscaTurno, selectTurno, Dgv_turmas);
            EditaColunaDgv();
        }

        public void BuscaDataGridView()
        {
            string selectText = "SELECT nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE Curso.nomeCurso LIKE '%" + Txb_buscaTurma.Text + "%' ORDER BY nomeTurma LIMIT 100";
            busca.AtualizaDataGridView(selectText, Dgv_turmas);
            EditaColunaDgv();
        }

        private void preencherCBcurso(ComboBox cb)
        {
            string selectCurso = "SELECT idCurso, nomeCurso from Curso ORDER BY nomeCurso";
            string valueMember = "idCurso";
            string displayMember = "nomeCurso";
            busca.preencherComboBox(cb, selectCurso, valueMember, displayMember);

        }

        private void someCampos(bool ft)
        {
            TxB_nomeAlterar.Visible = ft;
            Cbx_cursoAntigo.Visible = ft;
            Cbx_turnoAntigo.Visible = ft;
            Lbl_cursoAltera.Visible = ft;
            Lbl_turmaAltera.Visible = ft;
            Lbl_turnoAltera.Visible = ft;
        }

        private void verificaIsNullOrWhiteSpace()
        {
            verifica.VerificaCbxVazio(Cbx_cursoTurma);
            verifica.VerificaCbxVazio(Cbx_Turno);
            verifica.VerificaNullorWhiteSpace(Txb_nomeTurma.Text);
        }

        private void confereCampos(Turma turma)
        {
            if (string.IsNullOrWhiteSpace(Txb_nomeTurma.Text))
            {
                turma.mensagem = "Insira o nome da turma";
            }
            else if (Cbx_Turno.SelectedItem == null)
            {
                turma.mensagem = "Insira o turno da turma";
            }
            else if (Cbx_cursoTurma.SelectedItem == null)
            {
                turma.mensagem = "Escolha o curso que a turma pertence";
            }
            MessageBox.Show(turma.mensagem);
        }

        private void Btn_insereTurma_Click(object sender, EventArgs e)
        {
            Turma inserir = new Turma();
            try
            {
                if (!TxB_nomeAlterar.Visible)
                {
                    verificaIsNullOrWhiteSpace();
                    inserir.Inserir(Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                    MessageBox.Show(inserir.mensagem);
                }
                else
                {
                    someCampos(false);
                }
            }
            catch (NullReferenceException)
            {
                confereCampos(inserir);
            }

            catch (Exception ex)
            {
                inserir.mensagem = "Erro na inserção:" + ex.Message;
                MessageBox.Show(inserir.mensagem);
            }
            AtualizaDataGridView();
            EditaColunaDgv();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Turma editar = new Turma();
            try
            {
                if (TxB_nomeAlterar.Visible)
                {
                    verifica.VerificaNullorWhiteSpace(TxB_nomeAlterar.Text);
                    verifica.VerificaCbxVazio(Cbx_turnoAntigo);
                    verifica.VerificaCbxVazio(Cbx_cursoAntigo);
                    verificaIsNullOrWhiteSpace();
                    if (MessageBox.Show("Deseja realmente editar a turma " + Txb_nomeTurma.Text + " do curso de " + Cbx_cursoTurma.Text + " do turno " + Cbx_Turno.Text + "?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        editar.Editar(TxB_nomeAlterar.Text, Cbx_turnoAntigo.Text, (int)Cbx_cursoAntigo.SelectedValue, Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                        MessageBox.Show(editar.mensagem);
                    }
                }
                else
                {
                    someCampos(true);
                    Cbx_cursoTurma.SelectedItem = null;
                    Cbx_Turno.SelectedItem = null;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(TxB_nomeAlterar.Text))
                {
                    editar.mensagem = "Escolha o curso que deseja alterar";
                    MessageBox.Show(editar.mensagem);
                }

                else if (Cbx_turnoAntigo.SelectedItem == null)
                {
                    editar.mensagem = "Selecione o turno do curso que deseja alterar";
                    MessageBox.Show(editar.mensagem);
                }

                else if (Cbx_cursoAntigo.SelectedItem == null)
                {
                    editar.mensagem = "Selecione o curso da turma que está tentando alterar";
                    MessageBox.Show(editar.mensagem);
                }
                verificaIsNullOrWhiteSpace();
            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
            EditaColunaDgv();
        }

        private void Dgv_turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Dgv_turmas.Rows[e.RowIndex];
                if (!TxB_nomeAlterar.Visible)
                {
                    Txb_nomeTurma.Text = row.Cells["nomeTurma"].Value.ToString();
                    TxB_nomeAlterar.Text = row.Cells["nomeTurma"].Value.ToString();
                    Cbx_Turno.Text = row.Cells["turno"].Value.ToString();
                    Cbx_cursoTurma.Text = row.Cells["nomeCurso"].Value.ToString();
                    Cbx_turnoAntigo.Text = row.Cells["turno"].Value.ToString();
                    Cbx_cursoAntigo.Text = row.Cells["nomecurso"].Value.ToString();
                }
                else
                {
                    TxB_nomeAlterar.Text = row.Cells["nomeTurma"].Value.ToString();
                    Cbx_cursoAntigo.Text = row.Cells["nomecurso"].Value.ToString();
                    Cbx_turnoAntigo.Text = row.Cells["turno"].Value.ToString();
                    Txb_nomeTurma.Clear();
                    Cbx_Turno.Text = null;
                    Cbx_cursoTurma.SelectedItem = null;
                }
                Cbx_cursoTurma.Text = row.Cells["nomeCurso"].Value.ToString();
                Cbx_Turno.Text = row.Cells["turno"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            Turma excluir = new Turma();
            try
            {
                if (!TxB_nomeAlterar.Visible)
                {
                    verificaIsNullOrWhiteSpace();
                    if (MessageBox.Show("Deseja realmente excluir a turma " + Txb_nomeTurma.Text + " do curso de " + Cbx_cursoTurma.Text + " do turno " + Cbx_Turno.Text + "?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                        MessageBox.Show(excluir.mensagem);
                    }
                }
                else
                {
                    someCampos(false);
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na e:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDataGridView();
            EditaColunaDgv();
        }

        private void Txb_buscaTurma_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }

        private void Cbx_buscaTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscaTurnoDataGridView();
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaTurma.Clear();
            Cbx_buscaTurno.SelectedItem = null;
            AtualizaDataGridView();
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            Txb_nomeTurma.Clear();
            TxB_nomeAlterar.Clear();
            Cbx_cursoAntigo.SelectedItem = null;
            Cbx_cursoTurma.SelectedItem = null;
            Cbx_Turno.SelectedItem = null;
            Cbx_turnoAntigo.SelectedItem = null;
        }

        private void Btn_relatorioCurso_Click(object sender, EventArgs e)
        {
            using (Frm_relatorioTurma relatorioTurma = new Frm_relatorioTurma(dt))
            {
                relatorioTurma.ShowDialog();
            }
        }

        private void Cbx_cursoTurma_Click(object sender, EventArgs e)
        {
            preencherCBcurso(Cbx_cursoTurma);
        }

        private void Cbx_cursoAntigo_Click(object sender, EventArgs e)
        {
            preencherCBcurso(Cbx_cursoAntigo);
        }
    }
}
