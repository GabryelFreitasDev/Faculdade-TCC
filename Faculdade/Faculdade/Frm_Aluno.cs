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

        private void Test()
        {
            Conexao conexao = new Conexao();
            Cbx_Curso.DataSource = conexao;
            DataTable dt = new DataTable();
            ComboboxItem item = new ComboboxItem();
            var Sql = "SELECT idCurso, nomeCurso FROM Curso";
            NpgsqlCommand cmd = new NpgsqlCommand(Sql);
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            string idCurso = dt.Rows.ToString();
            cmd.CommandType = CommandType.Text;
            item.Text = idCurso;
            item.Value = 12;

            Cbx_Curso.Items.Add(item);

            Cbx_Curso.SelectedIndex = 0;

            MessageBox.Show((Cbx_Curso.SelectedItem as ComboboxItem).Value.ToString());
        }

        public void ComboBoxCursos()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeCurso FROM Curso";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            
            Cbx_Curso.DataSource = dt;
            dt.Rows.ToString();
            

        }
        private void Btn_insereAluno_Click(object sender, EventArgs e)
        {
            
            Aluno aluno = new Aluno();
            aluno.Inserir(Txb_nomeAluno.Text, Mtxb_cpf.Text, MTxb_dataNascimento.Text, MTxb_contato.Text, MTxb_contatoParente.Text, Txb_email.Text, Txb_endereco.Text, Txb_turma.Text,Cbx_Curso.SelectedItem.ToString());
            MessageBox.Show(aluno.mensagem);
        }

        private void Frm_Aluno_Load(object sender, EventArgs e)
        {
            Test();
        }

        private void Cbx_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
