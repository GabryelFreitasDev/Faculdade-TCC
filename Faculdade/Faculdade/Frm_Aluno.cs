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
            String scom = "SELECT nomeCurso from Curso";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            Cbx_Curso.DataSource = null;
            da.Fill(dtResultado);
            Cbx_Curso.DataSource = dtResultado;
            Cbx_Curso.ValueMember = "nomeCurso";
            Cbx_Curso.DisplayMember = "nomeCurso";
            Cbx_Curso.Refresh();
        }

        private void Btn_insereAluno_Click(object sender, EventArgs e)
        {
            int idCurso;
            Aluno aluno = new Aluno();
            var FK = "SELECT idCurso FROM curso WHERE nomeCurso = '" + Cbx_Curso.SelectedItem.ToString() + "'";
            NpgsqlCommand comando = new NpgsqlCommand(FK,aluno.db.conn);
            comando.Parameters.Add(Cbx_Curso.SelectedItem.ToString(), NpgsqlDbType.Varchar).Value = Cbx_Curso.SelectedItem.ToString();
            NpgsqlDataReader variavel = comando.ExecuteReader();
            variavel.Read();
            if (variavel.HasRows)
            {
                idCurso = variavel.GetInt32(0);
                aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text, idCurso);
            }
            else
            {
                MessageBox.Show("Curso nao encontrado");
            }

            
            MessageBox.Show(aluno.mensagem);
        }

        private void Frm_Aluno_Load(object sender, EventArgs e)
        {
            preencherCBDescricao();
        }
    }
}
