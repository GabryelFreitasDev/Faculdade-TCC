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
        public Frm_Aluno()
        {
            InitializeComponent();
        }

        private void Frm_Aluno_Load(object sender, EventArgs e)
        {
            preencherCBDescricao();
            AtualizaDataGridView();
            EditaColunaDgv();
            Txb_nomeAlterar.Visible = false;
            Lbl_nomeAlterar.Visible = false;
        }
        public void AtualizaDataGridView()
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,turma,nomeCurso FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_alunos.DataSource = null;
            Dgv_alunos.DataSource = dt;
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
            Dgv_alunos.RowHeadersVisible = false;
            Dgv_alunos.Columns[0].HeaderText = "NOME";
            Dgv_alunos.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Dgv_alunos.Columns[0].Width = 150;
            Dgv_alunos.Columns[1].HeaderText = "CPF";
            Dgv_alunos.Columns[1].Width = 90;
            Dgv_alunos.Columns[2].HeaderText = "NASC.";
            Dgv_alunos.Columns[2].Width = 70;
            Dgv_alunos.Columns[3].HeaderText = "CONTATO";
            Dgv_alunos.Columns[3].Width = 90;
            Dgv_alunos.Columns[4].HeaderText = "CONTATO PARENTE";
            Dgv_alunos.Columns[4].Width = 90;
            Dgv_alunos.Columns[5].HeaderText = "EMAIL";
            Dgv_alunos.Columns[5].Width = 150;
            Dgv_alunos.Columns[6].HeaderText = "ENDEREÇO";
            Dgv_alunos.Columns[6].Width = 150;
            Dgv_alunos.Columns[7].HeaderText = "TURMA";
            Dgv_alunos.Columns[7].Width = 60;
            Dgv_alunos.Columns[8].HeaderText = "CURSO";
            Dgv_alunos.Columns[8].Width = 140;
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

        private void preencherCBDescricao()
        {
            String scon = "Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade";
            NpgsqlConnection con = new NpgsqlConnection(scon);
            try
            {
                con.Open();
            }
            catch (NpgsqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "SELECT idCurso, nomeCurso from Curso";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            Cbx_Curso.DataSource = null;
            da.Fill(dtResultado);
            Cbx_Curso.DataSource = dtResultado;
            Cbx_Curso.ValueMember = "idCurso";
            Cbx_Curso.DisplayMember = "nomeCurso";
            Cbx_Curso.Refresh();
        }

        private void VerificaNullorEmpty(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new NullReferenceException();
            }
        }
        private void VerificaMaskFull(MaskedTextBox valor)
        {
            if (!valor.MaskCompleted)
            {
                throw new NullReferenceException();
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
            Txb_turma.Clear();
        }
        private void Dgv_Alunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = Dgv_alunos.Rows[e.RowIndex];
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
                Txb_turma.Text = row.Cells["turma"].Value.ToString();
                Cbx_Curso.Text = row.Cells["nomeCurso"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
        }

        private void Btn_insereAluno_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_acao.Text == "INSERIR")
                {
                    VerificaNullorEmpty(Txb_nomeAluno.Text);
                    VerificaNullorEmpty(Txb_email.Text);
                    VerificaNullorEmpty(Txb_endereco.Text);
                    VerificaNullorEmpty(Txb_turma.Text);

                    VerificaMaskFull(Mtxb_cpf);
                    VerificaMaskFull(MTxb_dataNascimento);
                    VerificaMaskFull(MTxb_contato);
                    
                    aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text, (int)Cbx_Curso.SelectedValue);
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
                else if (!MTxb_contatoParente.MaskCompleted)
                {
                    aluno.mensagem = "Digite o contato do parente corretamente";
                }
                else if (string.IsNullOrEmpty(Txb_email.Text))
                {
                    aluno.mensagem = "Digite o email";
                }
                else if (string.IsNullOrEmpty(Txb_endereco.Text))
                {
                    aluno.mensagem = "Digite o endereço";
                }
                else if (string.IsNullOrEmpty(Txb_turma.Text))
                {
                    aluno.mensagem = "Insira a turma";
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
                    VerificaNullorEmpty(Txb_nomeAluno.Text);
                    VerificaMaskFull(Mtxb_cpf);
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
                    VerificaNullorEmpty(Txb_nomeAlterar.Text);
                    VerificaNullorEmpty(Txb_nomeAluno.Text);
                    VerificaNullorEmpty(Txb_email.Text);
                    VerificaNullorEmpty(Txb_endereco.Text);
                    VerificaNullorEmpty(Txb_turma.Text);

                    VerificaMaskFull(Mtxb_cpf);
                    VerificaMaskFull(MTxb_dataNascimento);
                    VerificaMaskFull(MTxb_contato);

                    editar.Editar(Txb_nomeAlterar.Text, Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text, (int)Cbx_Curso.SelectedValue);
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
                else if (!MTxb_contatoParente.MaskCompleted)
                {
                    editar.mensagem = "Digite o contato do parente corretamente";
                }
                else if (string.IsNullOrEmpty(Txb_email.Text))
                {
                    editar.mensagem = "Digite o email email";
                }
                else if (string.IsNullOrEmpty(Txb_endereco.Text))
                {
                    editar.mensagem = "Digite seu endereço";
                }
                else if (string.IsNullOrEmpty(Txb_turma.Text))
                {
                    editar.mensagem = "Insira a turma";
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
    }
}

