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
        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        Verifica verifica = new Verifica();
        public Frm_Aluno()
        {
            InitializeComponent();
            preencherCBCurso(Cbx_Curso);
            preencherCBCurso(Cbx_buscaCurso);
            preencherCBTurma();
        }

        public void Frm_Aluno_Load(object sender, EventArgs e)
        {
            Cbx_Curso.SelectedItem = null;
            Cbx_buscaCurso.SelectedItem = null;
            AtualizaDataGridView();
            preencherCBCurso(Cbx_Curso);
            preencherCBCurso(Cbx_buscaCurso);
            EditaColunaDgv();
            Txb_nomeAlterar.Visible = false;
            Lbl_nomeAlterar.Visible = false;
            Cbx_turmaAluno.Visible = false;
            Lbl_disponivel.Visible = false;
            Lbl_turma.Visible = false;
        }
        
        public void AtualizaDataGridView()
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_aluno.DataSource = null;
            Dgv_aluno.DataSource = dt;
            EditaColunaDgv();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.conn.Close();
            }
        }
        private void EditaColunaDgv()
        {
            Dgv_aluno.RowHeadersVisible = false;
            Dgv_aluno.Columns[0].HeaderText = "NOME";
            Dgv_aluno.Columns[0].Width = 150;
            Dgv_aluno.Columns[1].HeaderText = "CPF";
            Dgv_aluno.Columns[1].Width = 90;
            Dgv_aluno.Columns[2].HeaderText = "NASC.";
            Dgv_aluno.Columns[2].Width = 70;
            Dgv_aluno.Columns[3].HeaderText = "CONTATO";
            Dgv_aluno.Columns[3].Width = 90;
            Dgv_aluno.Columns[4].HeaderText = "CONTATO PARENTE";
            Dgv_aluno.Columns[4].Width = 90;
            Dgv_aluno.Columns[5].HeaderText = "EMAIL";
            Dgv_aluno.Columns[5].Width = 150;
            Dgv_aluno.Columns[6].HeaderText = "ENDEREÇO";
            Dgv_aluno.Columns[6].Width = 150;
            Dgv_aluno.Columns[7].HeaderText = "CURSO";
            Dgv_aluno.Columns[7].Width = 140;
            Dgv_aluno.Columns[8].HeaderText = "TURMA";
            Dgv_aluno.Columns[8].Width = 60;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void preencherCBCurso(ComboBox cb)
        {
            NpgsqlConnection con = new NpgsqlConnection(conexao.connString);
            try
            {
                con.Open();
                String scom = "SELECT idCurso, nomeCurso from Curso ORDER BY nomeCurso";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(scom, con);
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();
                cb.DataSource = null;
                da.Fill(dtResultado);
                cb.DataSource = dtResultado;
                cb.ValueMember = "idCurso";
                cb.DisplayMember = "nomeCurso";
                cb.Refresh();
            }
            catch (NpgsqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            finally
            {
                con.Close();
            }
        }

        private void preencherCBTurma()
        {
            NpgsqlConnection con = new NpgsqlConnection(conexao.connString);
            try
            {
                con.Open();
                String scom = "SELECT nomeCurso, idTurma, nomeTurma from Curso INNER JOIN Turma on FK_idCurso = idCurso WHERE nomeCurso = '" + Cbx_Curso.Text + "' ORDER BY nomeTurma";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(scom, con);
                DataTable dtResultado = new DataTable();
                dtResultado.Clear();
                Cbx_turmaAluno.DataSource = null;
                da.Fill(dtResultado);
                Cbx_turmaAluno.DataSource = dtResultado;
                Cbx_turmaAluno.ValueMember = "idTurma";
                Cbx_turmaAluno.DisplayMember = "nomeTurma";
                Cbx_turmaAluno.Refresh();
            }
            catch (NpgsqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            finally
            {
                con.Close();
            }
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

        public void BuscaDataGridView()
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeAluno LIKE '%" + Txb_buscaNome.Text + "%' ORDER BY nomeAluno";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_aluno.DataSource = null;
            Dgv_aluno.DataSource = dt;
            EditaColunaDgv();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.conn.Close();
            }
        }

        public void BuscaCursoDataGridView()
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            try
            {
                if (Cbx_buscaCurso.SelectedItem != null)
                {
                    cmd.Connection = conexao.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco, nomeCurso,nomeTurma FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso INNER JOIN Turma on idTurma = FK_idTurma WHERE nomeCurso = '" + Cbx_buscaCurso.Text + "' ORDER BY nomeAluno";
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Dgv_aluno.DataSource = null;
                    Dgv_aluno.DataSource = dt;
                    EditaColunaDgv();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    AtualizaDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.conn.Close();
            }
        }

        private void Btn_insereAluno_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_acao.Text == "INSERIR")
                {
                    verifica.VerificaNullorEmpty(Txb_nomeAluno.Text);
                    verifica.VerificaNullorEmpty(Txb_email.Text);
                    verifica.VerificaNullorEmpty(Txb_endereco.Text);

                    verifica.VerificaMaskFull(Mtxb_cpf);
                    verifica.VerificaMaskFull(MTxb_dataNascimento);
                    verifica.VerificaMaskFull(MTxb_contato);

                    verifica.VerificaCbxVazio(Cbx_Curso);
                    verifica.VerificaCbxVazio(Cbx_turmaAluno);

                    aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, (int)Cbx_Curso.SelectedValue, (int)Cbx_turmaAluno.SelectedValue);
                    MessageBox.Show(aluno.mensagem);
                }
                else
                {
                    Lbl_acao.Text = "INSERIR";
                    Lbl_nome.Text = "Nome do aluno:";
                    Txb_nomeAlterar.Enabled = false;
                    Txb_nomeAlterar.Visible = false;
                    Lbl_nomeAlterar.Visible = false;
                }

            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAluno.Text))
                {
                    aluno.mensagem = "Insira o nome do aluno";
                }
                else if (!Mtxb_cpf.MaskCompleted)
                {
                    aluno.mensagem = "Insira o CPF corretamente";
                }
                else if (!MTxb_dataNascimento.MaskCompleted)
                {
                    aluno.mensagem = "Digite o data de nascimento corretamente";
                }
                else if (!MTxb_contato.MaskCompleted)
                {
                    aluno.mensagem = "Digite o contato corretamente";
                }
                else if (string.IsNullOrEmpty(Txb_email.Text))
                {
                    aluno.mensagem = "Digite o email";
                }
                else if (string.IsNullOrEmpty(Txb_endereco.Text))
                {
                    aluno.mensagem = "Digite o endereço";
                }
                else if (Cbx_Curso.SelectedItem == null)
                {
                    aluno.mensagem = "Selecione o curso";
                }
                else if (Cbx_turmaAluno.SelectedItem == null)
                {
                    aluno.mensagem = "Selecione a turma";
                }
                MessageBox.Show(aluno.mensagem);
            }
            catch (Exception ex)
            {
                aluno.mensagem = "Erro na inserção: " + ex.Message;
            }
            AtualizaDataGridView();
        }

        private void Btn_excluiAluno_Click_1(object sender, EventArgs e)
        {

            Aluno excluir = new Aluno();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_acao.Text == "EXCLUIR")
                {
                    verifica.VerificaNullorEmpty(Txb_nomeAluno.Text);
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
                    Lbl_nome.Text = "Nome do aluno que será excluído:";
                    Txb_nomeAlterar.Enabled = false;
                    Txb_nomeAlterar.Visible = false;
                    Lbl_nomeAlterar.Visible = false;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAluno.Text))
                {
                    excluir.mensagem = "Digite o nome do aluno que deseja excluir";
                    MessageBox.Show(excluir.mensagem);
                }
                else
                {
                    excluir.mensagem = "Digite o CPF do aluno que deseja excluir";
                    MessageBox.Show(excluir.mensagem);
                }
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na Exclusão:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Btn_editaAluno_Click(object sender, EventArgs e)
        {
            Aluno editar = new Aluno();
            try
            {
                if (Txb_nomeAlterar.Visible && Lbl_acao.Text == "EDITAR")
                {
                    verifica.VerificaNullorEmpty(Txb_nomeAlterar.Text);
                    verifica.VerificaNullorEmpty(Txb_nomeAluno.Text);
                    verifica.VerificaNullorEmpty(Txb_email.Text);
                    verifica.VerificaNullorEmpty(Txb_endereco.Text);

                    verifica.VerificaMaskFull(Mtxb_cpf);
                    verifica.VerificaMaskFull(MTxb_dataNascimento);
                    verifica.VerificaMaskFull(MTxb_contato);

                    verifica.VerificaCbxVazio(Cbx_Curso);
                    verifica.VerificaCbxVazio(Cbx_turmaAluno);

                    editar.Editar(Txb_nomeAlterar.Text, Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, (int)Cbx_Curso.SelectedValue, (int)Cbx_turmaAluno.SelectedValue);
                    MessageBox.Show(editar.mensagem);
                }
                else
                {
                    Lbl_acao.Text = "EDITAR";
                    Lbl_nomeAlterar.Text = "Nome do aluno que será editado";
                    Lbl_nome.Text = "Nome do aluno:";
                    Txb_nomeAlterar.Enabled = true;
                    Txb_nomeAlterar.Visible = true;
                    Lbl_nomeAlterar.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Insira o nome do aluno que deseja editar";
                }
                if (string.IsNullOrEmpty(Txb_nomeAluno.Text))
                {
                    editar.mensagem = "Insira o nome do aluno";
                }
                else if (!Mtxb_cpf.MaskCompleted)
                {
                    editar.mensagem = "Insira o CPF corretamente";
                }
                else if (!MTxb_dataNascimento.MaskCompleted)
                {
                    editar.mensagem = "Digite o data de nascimento corretamente";
                }
                else if (!MTxb_contato.MaskCompleted)
                {
                    editar.mensagem = "Digite o contato corretamente";
                }
                else if (string.IsNullOrEmpty(Txb_email.Text))
                {
                    editar.mensagem = "Digite o email";
                }
                else if (string.IsNullOrEmpty(Txb_endereco.Text))
                {
                    editar.mensagem = "Digite seu endereço";
                }
                else if (Cbx_Curso.SelectedItem == null)
                {
                    editar.mensagem = "Selecione o curso";
                }
                else if (Cbx_turmaAluno.SelectedItem == null)
                {
                    editar.mensagem = "Selecione a turma";
                }
                MessageBox.Show(editar.mensagem);

            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na Edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
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

        private void Cbx_buscaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencherCBCurso(Cbx_buscaCurso);
            if (Cbx_buscaCurso.Text != null)
            {
                BuscaCursoDataGridView();
            }
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaNome.Clear();
            Cbx_buscaCurso.SelectedItem = null;
        }

        private void Cbx_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbx_turmaAluno.Visible = true;
            Lbl_turma.Text = "Escolha a Turma";
            preencherCBTurma();
            if (Cbx_turmaAluno.Items.Count == 0)
            {
                Lbl_disponivel.Visible = true;
            }
            else
            {
                Lbl_disponivel.Visible = false;
            }
        }

        private void Cbx_Curso_Click(object sender, EventArgs e)
        {
          preencherCBCurso(Cbx_Curso);
        }

        private void Cbx_buscaCurso_Click(object sender, EventArgs e)
        {
            preencherCBCurso(Cbx_buscaCurso);
        }
    }
}

