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
    public partial class Frm_Curso : Form
    {
        public Frm_Curso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Inserir(textBox1.Text,Cbx_Turno.SelectedItem.ToString());
            MessageBox.Show(curso.mensagem);
        }

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Excluir(Txb_excluiCurso.Text);
            MessageBox.Show(curso.mensagem);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            //curso.Editar(Txb_nomeAlterar.Text, Txb_nomeNovo.Text);
            MessageBox.Show(curso.mensagem);
        }

        private void Txb_listaCurso_TextChanged(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.BuscarTudo();

        }

        private void Btn_atualizaDgv_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM \"Curso\"";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_Cursos.DataSource = null;
            Dgv_Cursos.DataSource = dt;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados da tabela atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
