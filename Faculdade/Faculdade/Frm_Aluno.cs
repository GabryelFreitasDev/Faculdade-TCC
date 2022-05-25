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
        public Frm_Aluno()
        {
            InitializeComponent();
        }

        public void AtualizaDataGridView()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeAluno,cpf,dataNascimento,contato,contatoParente,email,endereco,turma,nomeCurso FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_Alunos.DataSource = null;
            Dgv_Alunos.DataSource = dt;
            
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
                conn.Close();
            }
        }
        private void EditaColunaDgv()
        {
            Dgv_Alunos.RowHeadersVisible = false;
            Dgv_Alunos.Columns[0].HeaderText = "NOME";
            Dgv_Alunos.Columns[0].Width = 150;
            Dgv_Alunos.Columns[1].HeaderText = "CPF";
            Dgv_Alunos.Columns[1].Width = 90;
            Dgv_Alunos.Columns[2].HeaderText = "NASC.";
            Dgv_Alunos.Columns[2].Width = 70;
            Dgv_Alunos.Columns[3].HeaderText = "CONTATO";
            Dgv_Alunos.Columns[3].Width = 90;
            Dgv_Alunos.Columns[4].HeaderText = "CONTATO PARENTE";
            Dgv_Alunos.Columns[4].Width = 90;
            Dgv_Alunos.Columns[5].HeaderText = "EMAIL";
            Dgv_Alunos.Columns[5].Width = 150;
            Dgv_Alunos.Columns[6].HeaderText = "ENDEREÇO";
            Dgv_Alunos.Columns[6].Width = 150;
            Dgv_Alunos.Columns[7].HeaderText = "TURMA";
            Dgv_Alunos.Columns[7].Width = 60;
            Dgv_Alunos.Columns[8].HeaderText = "CURSO";
            Dgv_Alunos.Columns[8].Width = 140;
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

        private void Btn_insereAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            try
            {
                if (Mtxb_cpf.Text.Length < 14)
                {
                    throw new NullReferenceException();
                }
                if(MTxb_dataNascimento.Text.Length < 10)
                {
                    throw new NullReferenceException();
                }
                if (MTxb_contato.Text.Length < 15)
                {
                    throw new NullReferenceException();
                }
                if (MTxb_contatoParente.Text.Length < 15)
                {
                    throw new NullReferenceException();
                }
                    aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text, (int)Cbx_Curso.SelectedValue);
                    AtualizaDataGridView();
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAluno.Text))
                {
                    aluno.mensagem = "Insira o nome do aluno";
                }
                else if (Mtxb_cpf.Text.Length < 14)
                {
                    aluno.mensagem = "Insira seu CPF corretamente";
                }
                else if (MTxb_dataNascimento.Text.Length < 10)
                {
                    aluno.mensagem = "Digite sua data de nascimento corretamente";
                }
                else if (MTxb_contato.Text.Length < 15)
                {
                    aluno.mensagem = "Digite seu contato corretamente";
                }
                else if (MTxb_contatoParente.Text.Length < 15)
                {
                    aluno.mensagem = "Digite o contato do parente corretamente";
                }
                else if (string.IsNullOrEmpty(Txb_email.Text))
                {
                    aluno.mensagem = "Digite seu email";
                }
                else if (string.IsNullOrEmpty(Txb_endereco.Text))
                {
                    aluno.mensagem = "Digite seu endereço";
                }
                else if (string.IsNullOrEmpty(Txb_turma.Text))
                {
                    aluno.mensagem = "Insira a turma";
                }
            }
            catch (Exception ex)
            {
                aluno.mensagem  = "Erro na inserção: " + ex.Message;
            }
            
            MessageBox.Show(aluno.mensagem);
        }
        private void Frm_Aluno_Load(object sender, EventArgs e)
        {
            preencherCBDescricao();
            AtualizaDataGridView();
            EditaColunaDgv();
        }

        private void MTxb_dataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
