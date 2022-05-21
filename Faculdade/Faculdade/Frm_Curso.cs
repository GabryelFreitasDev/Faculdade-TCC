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

        public void AtualizaDataGridView()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM \"curso\"";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Cbx_editaCurso.DataSource = null;
            Cbx_editaCurso.DataSource = dt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                curso.Inserir(Txb_nomeCurso.Text, Cbx_Turno.SelectedItem.ToString(), MTxb_cargaHoraria.Text, Txb_descricao.Text);
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeCurso.Text))
                {
                    curso.mensagem = "Digite o nome do Curso";
                }
                else if (string.IsNullOrEmpty(Cbx_Turno.SelectedItem.ToString()))
                {
                    curso.mensagem = "Escolha o turno do Curso";
                }
                else if (string.IsNullOrEmpty(MTxb_cargaHoraria.Text))
                {
                    curso.mensagem = "Digite a carga horária do Curso";
                }
                else if (string.IsNullOrEmpty(Txb_descricao.Text))
                {
                    curso.mensagem = "Digite o nome do Curso";
                }

            }
            catch (Exception ex)
            {
                curso.mensagem = "Erro na Inserção:" + ex.Message;
            }
            MessageBox.Show(curso.mensagem);
            AtualizaDataGridView();
        }

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                curso.Excluir(Txb_excluiCurso.Text);

            }
            catch (NullReferenceException)
            {
                curso.mensagem = "Digite o nome do curso que deseja excluir";
            }
            catch (Exception ex)
            {
                curso.mensagem = "Erro na Exclusão:" + ex.Message;
            }

            MessageBox.Show(curso.mensagem);
            AtualizaDataGridView();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                curso.Editar(Txb_nomeAlterar.Text, Txb_nomeNovo.Text, Cbx_turnoNovo.Text, Mtxb_cargaHoraNova.Text, Txb_descricaoNova.Text);
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAlterar.Text))
                {
                    curso.mensagem = "Digite o nome do Curso que deseja alterar";
                }
                else if (string.IsNullOrEmpty(Txb_nomeNovo.Text))
                {
                    curso.mensagem = "Digite o novo nome do Curso";
                }
                else if (string.IsNullOrEmpty(Cbx_turnoNovo.Text))
                {
                    curso.mensagem = "Escolha o turno do Curso";
                }
                else if (string.IsNullOrEmpty(Mtxb_cargaHoraNova.Text))
                {
                    curso.mensagem = "Digite a carga horária do Curso";
                }
                else if (string.IsNullOrEmpty(Txb_descricaoNova.Text))
                {
                    curso.mensagem = "Digite a descrição do Curso";
                }
            }
            catch (Exception ex)
            {
                curso.mensagem = "Erro na Edição:" + ex.Message;
            }
            MessageBox.Show(curso.mensagem);
            AtualizaDataGridView();
        }

        private void Txb_listaCurso_TextChanged(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.BuscarTudo();

        }


        private void Btn_atualizaDgv_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Cursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Curso_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txb_excluiCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
