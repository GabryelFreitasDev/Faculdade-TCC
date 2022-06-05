using Npgsql;
using NpgsqlTypes;
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
    public partial class Frm_Aluno : Form
    {
        DataTable dt = new DataTable();
        Verifica verifica = new Verifica();
        Busca busca = new Busca();

        string preecheCurso = "SELECT idCurso, nomeCurso from Curso ORDER BY nomeCurso";
        string valueCurso = "idCurso";
        string displayCurso = "nomeCurso";
        private void preencheCurso(ComboBox cb)
        {
            busca.preencherComboBox(cb, preecheCurso, valueCurso, displayCurso);
            cb.Text = null;
        }
        private void preencheTurma()
        {
            string preencheTurma = "SELECT nomeCurso, idTurma, nomeTurma from Curso INNER JOIN Turma on FK_idCurso = idCurso WHERE nomeCurso = '" + Cbx_Curso.Text + "' ORDER BY nomeTurma";
            string valueTurma = "idTurma";
            string displayTurma = "nomeTurma";
            busca.preencherComboBox(Cbx_turmaAluno, preencheTurma, valueTurma, displayTurma);
        }

        private void BuscaDataGridView()
        {
            //somente nome
            if (!string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                string selectText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeAluno) LIKE '%" + Txb_buscaNome.Text.ToLower() + "%' ORDER BY nomeAluno LIMIT 100";
                busca.AtualizaDataGridView(selectText, Dgv_aluno);
            }
            //somente curso
            else if (string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                string selectCurso = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeCurso = '" + Cbx_buscaCurso.Text + "' ORDER BY nomeAluno LIMIT 100";
                busca.BuscaDataGridView(Cbx_buscaCurso, selectCurso, Dgv_aluno);
            }
            //nome e curso
            else if (!string.IsNullOrWhiteSpace(Txb_buscaNome.Text) && !string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                string selectTextCurso = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE lower(nomeAluno) LIKE '%" + Txb_buscaNome.Text.ToLower() + "%' and nomeCurso = '" + Cbx_buscaCurso.Text + "' ORDER BY nomeAluno LIMIT 100";
                busca.AtualizaDataGridView(selectTextCurso, Dgv_aluno);
            }
            EditaColunaDgv();
        }

        private void AtualizaDGV()
        {
            string dgvSelect = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma";
            busca.AtualizaDataGridView(dgvSelect, Dgv_aluno);
            EditaColunaDgv();
        }

        private void someCamposEditar(bool ft)
        {
            Txb_nomeAlterar.Enabled = ft;
            Txb_nomeAlterar.Visible = ft;
            Lbl_nomeAlterar.Visible = ft;
        }

        private void verificaIsNullOrWhiteSpace()
        {
            verifica.VerificaNullorWhiteSpace(Txb_nomeAluno.Text);
            verifica.VerificaNullorWhiteSpace(Txb_email.Text);
            verifica.VerificaNullorWhiteSpace(Txb_endereco.Text);

            verifica.VerificaMaskFull(Mtxb_cpf);
            verifica.VerificaMaskFull(MTxb_dataNascimento);
            verifica.VerificaMaskFull(MTxb_contato);

            verifica.VerificaCbxVazio(Cbx_Curso);
            verifica.VerificaCbxVazio(Cbx_turmaAluno);
        }
        private void confereCampos(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(Txb_nomeAluno.Text))
                aluno.mensagem = "Insira o nome do aluno";
            else if (!Mtxb_cpf.MaskCompleted)
                aluno.mensagem = "Insira o CPF corretamente";
            else if (!MTxb_dataNascimento.MaskCompleted)
                aluno.mensagem = "Digite o data de nascimento corretamente";
            else if (!MTxb_contato.MaskCompleted)
                aluno.mensagem = "Digite o contato corretamente";
            else if (string.IsNullOrWhiteSpace(Txb_email.Text))
                aluno.mensagem = "Digite o email";
            else if (string.IsNullOrWhiteSpace(Txb_endereco.Text))
                aluno.mensagem = "Digite o endereço";
            else if (Cbx_Curso.SelectedItem == null)
                aluno.mensagem = "Selecione o curso";
            else if (Cbx_turmaAluno.SelectedItem == null)
            {
                aluno.mensagem = "Selecione a turma";
            }
            MessageBox.Show(aluno.mensagem);
        }

        private void EditaColunaDgv()
        {
            Dgv_aluno.RowHeadersVisible = false;
            Dgv_aluno.Columns[0].HeaderText = "NOME";
            Dgv_aluno.Columns[1].HeaderText = "CPF";
            Dgv_aluno.Columns[2].HeaderText = "NASCIMENTO";
            Dgv_aluno.Columns[3].HeaderText = "CONTATO";
            Dgv_aluno.Columns[4].HeaderText = "CONTATO PARENTE";
            Dgv_aluno.Columns[5].HeaderText = "EMAIL";
            Dgv_aluno.Columns[6].HeaderText = "ENDEREÇO";
            Dgv_aluno.Columns[7].HeaderText = "CURSO";
            Dgv_aluno.Columns[8].HeaderText = "TURMA";
        }

        private void limpaCampos()
        {
            Txb_nomeAluno.Clear();
            Cbx_Curso.SelectedItem = null;
            Txb_nomeAlterar.Clear();
            Mtxb_cpf.Clear();
            MTxb_dataNascimento.Clear();
            MTxb_contato.Clear();
            MTxb_contatoParente.Clear();
            Txb_email.Clear();
            Txb_endereco.Clear();
            Cbx_turmaAluno.SelectedItem = null;
            Lbl_turma.Visible = false;
            Cbx_turmaAluno.Visible = false;
            Lbl_disponivel.Visible = false;
        }

        private void Dgv_Alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = Dgv_aluno.Rows[e.RowIndex];
                if (!Txb_nomeAlterar.Visible)
                {
                    Txb_nomeAluno.Text = row.Cells["nomealuno"].Value.ToString();
                    Txb_nomeAlterar.Text = row.Cells["nomealuno"].Value.ToString();
                }
                else
                {
                    Txb_nomeAlterar.Text = row.Cells["nomealuno"].Value.ToString();
                    Txb_nomeAluno.Clear();
                }
                Mtxb_cpf.Text = row.Cells["cpf"].Value.ToString();
                MTxb_dataNascimento.Text = row.Cells["datanascimento"].Value.ToString();
                MTxb_contato.Text = row.Cells["contato"].Value.ToString();
                MTxb_contatoParente.Text = row.Cells["contatoparente"].Value.ToString();
                Txb_email.Text = row.Cells["email"].Value.ToString();
                Txb_endereco.Text = row.Cells["endereco"].Value.ToString();
                Cbx_Curso.Text = row.Cells["nomeCurso"].Value.ToString();
                Cbx_turmaAluno.Text = row.Cells["nomeTurma"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
        }
        public Frm_Aluno()
        {
            InitializeComponent();
            preencheCurso(Cbx_Curso);
            preencheCurso(Cbx_buscaCurso);
            preencheTurma();
        }

        public void Frm_Aluno_Load(object sender, EventArgs e)
        {
            Cbx_Curso.SelectedItem = null;
            Cbx_buscaCurso.Text = null;
            AtualizaDGV();
            EditaColunaDgv();
            someCamposEditar(false);
            Cbx_turmaAluno.Visible = false;
            Lbl_disponivel.Visible = false;
            Lbl_turma.Visible = false;
        }
        private void Btn_insereAluno_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_acao.Text == "INSERIR")
                {
                    verificaIsNullOrWhiteSpace();
                    aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, (int)Cbx_Curso.SelectedValue, (int)Cbx_turmaAluno.SelectedValue);
                    MessageBox.Show(aluno.mensagem);
                }
                else
                {
                    Lbl_acao.Text = "INSERIR";
                    Lbl_nome.Text = "NOME DO ALUNO:";
                    someCamposEditar(false);
                }
            }
            catch (NullReferenceException)
            {
                confereCampos(aluno);
            }
            catch (Exception ex)
            {
                aluno.mensagem = "Erro na inserção: " + ex.Message;
            }
            AtualizaDGV();
        }

        private void Btn_excluiAluno_Click_1(object sender, EventArgs e)
        {

            Aluno excluir = new Aluno();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_acao.Text == "EXCLUIR")
                {
                    verifica.VerificaNullorWhiteSpace(Txb_nomeAluno.Text);
                    verifica.VerificaMaskFull(Mtxb_cpf);
                    if (MessageBox.Show("Deseja realmente excluir o aluno: " + Txb_nomeAluno.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeAluno.Text, Mtxb_cpf.Text);
                        MessageBox.Show(excluir.mensagem);
                    }
                }
                else
                {
                    Lbl_acao.Text = "EXCLUIR";
                    Lbl_nome.Text = "NOME DO ALUNO QUE SERÁ EXCLUÍDO:";
                    someCamposEditar(false);
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrWhiteSpace(Txb_nomeAluno.Text))
                    excluir.mensagem = "Digite o nome do aluno que deseja excluir";
                else
                {
                    excluir.mensagem = "Digite o CPF do aluno que deseja excluir";
                }
                MessageBox.Show(excluir.mensagem);
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na Exclusão:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDGV();
        }

        private void Btn_editaAluno_Click(object sender, EventArgs e)
        {
            Aluno editar = new Aluno();
            try
            {
                if (Txb_nomeAlterar.Visible && Lbl_acao.Text == "EDITAR")
                {
                    verifica.VerificaNullorWhiteSpace(Txb_nomeAlterar.Text);
                    verificaIsNullOrWhiteSpace();
                    if (MessageBox.Show("Deseja realmente editar o aluno: " + Txb_nomeAluno.Text + " ?\n\n*Todos os aluno cadastrados irão para a turma nova*", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        editar.Editar(Txb_nomeAlterar.Text, Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, (int)Cbx_Curso.SelectedValue, (int)Cbx_turmaAluno.SelectedValue);
                    MessageBox.Show(editar.mensagem);
                }
                else
                {
                    Lbl_acao.Text = "EDITAR";
                    Lbl_nomeAlterar.Text = "NOME DO ALUNO QUE SERÁ EDITADO:";
                    Lbl_nome.Text = "NOME DO ALUNO:";
                    someCamposEditar(true);
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrWhiteSpace(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Insira o nome do aluno que deseja editar";
                    MessageBox.Show(editar.mensagem);
                }
                else
                {
                    confereCampos(editar);
                }
            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na Edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDGV();
        }

        private void Btn_relatorio_Click(object sender, EventArgs e)
        {
            using (Frm_relatorioAluno relatorioAluno = new Frm_relatorioAluno(dt))
            {
                relatorioAluno.ShowDialog();
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void Txb_buscaNome_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaNome.Clear();
            Cbx_buscaCurso.SelectedItem = null;
            AtualizaDGV();
        }

        private void Cbx_buscaCurso_DropDown(object sender, EventArgs e)
        {
            preencheCurso(Cbx_buscaCurso);
        }
        private void Cbx_Curso_DropDown(object sender, EventArgs e)
        {
            preencheCurso(Cbx_Curso);
        }

        private void Cbx_buscaCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Cbx_buscaCurso.Text))
            {
                BuscaDataGridView();
            }
        }

        private void Cbx_Curso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cbx_turmaAluno.Visible = true;
            Lbl_turma.Visible = true;
            preencheTurma();
            if (Cbx_turmaAluno.Items.Count == 0)
                Lbl_disponivel.Visible = true;
            else
                Lbl_disponivel.Visible = false;
        }

        private void Cbx_turmaAluno_DropDown(object sender, EventArgs e)
        {
            preencheTurma();
        }
    }
}

