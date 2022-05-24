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
            Dgv_Alunos.Columns[0].Width = 110;
            Dgv_Alunos.Columns[1].HeaderText = "CPF";
            Dgv_Alunos.Columns[1].Width = 90;
            Dgv_Alunos.Columns[2].HeaderText = "NASC.";
            Dgv_Alunos.Columns[2].Width = 70;
            Dgv_Alunos.Columns[3].HeaderText = "CONTATO";
            Dgv_Alunos.Columns[3].Width = 90;

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
            aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text, (int)Cbx_Curso.SelectedValue);
            MessageBox.Show(aluno.mensagem);
            MessageBox.Show(Cbx_Curso.SelectedValue.ToString());
        }
        private void Frm_Aluno_Load(object sender, EventArgs e)
        {
            preencherCBDescricao();
            AtualizaDataGridView();
            EditaColunaDgv();
        }
    }
}
