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
        Frm_Menu menu = new Frm_Menu();
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
            Dgv_Curso.DataSource = null;
            Dgv_Curso.DataSource = dt;

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
        

        public void BuscaDataGridView()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM \"curso\" WHERE nomeCurso LIKE '%" + Txb_buscar.Text + "%' ORDER BY idCurso";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_Curso.DataSource = null;
            Dgv_Curso.DataSource = dt;

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

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso excluir = new Curso();

            try
            {
                if (string.IsNullOrEmpty(Txb_excluiCurso.Text))
                {
                    throw new NullReferenceException();
                }
                excluir.Excluir(Txb_excluiCurso.Text);
            }
            catch (NullReferenceException)
            {
                excluir.mensagem = "Digite o nome do curso que deseja excluir";
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na Exclusão:" + ex.Message;
            }

            MessageBox.Show(excluir.mensagem);
            AtualizaDataGridView();
        }

        private void Frm_Curso_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
            
        }
        private void Btn_editar_Click_1(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                if (Mtxb_cargaHoraNova.Text == "     Hrs")
                {
                    throw new NullReferenceException();
                }
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
                else if (Mtxb_cargaHoraNova.Text == "     Hrs")
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

        private void Txb_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }
    }
}
