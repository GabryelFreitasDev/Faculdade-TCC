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
        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        public Frm_Curso()
        {
            InitializeComponent();
        }

        public void AtualizaDataGridView()
        {
          if(conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
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
                conexao.conn.Close();
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
                conexao.conn.Close();
            }
        }
        private void Frm_Curso_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();

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

        private void Btn_InsereCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                VerificaNullorEmpty(Txb_nomeCurso.Text);
                VerificaNullorEmpty(Cbx_Turno.Text);
                VerificaNullorEmpty(Txb_descricao.Text);
                VerificaMaskFull(MTxb_cargaHoraria);
                curso.Inserir(Txb_nomeCurso.Text, Cbx_Turno.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeCurso.Text))
                {
                    curso.mensagem = "Digite o nome do Curso";
                }
                else if (string.IsNullOrEmpty(Cbx_Turno.Text))
                {
                    curso.mensagem = "Escolha o turno do Curso";
                }
                else if (!MTxb_cargaHoraria.MaskCompleted)
                {
                    curso.mensagem = "Digite a carga horária do Curso";
                }
                else if (string.IsNullOrEmpty(Txb_descricao.Text))
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

        private void Btn_editar_Click_1(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                VerificaNullorEmpty(Txb_nomeAlterar.Text);
                VerificaNullorEmpty(Txb_nomeNovo.Text);
                VerificaNullorEmpty(Cbx_turnoNovo.Text);
                VerificaNullorEmpty(Txb_descricaoNova.Text);
                VerificaMaskFull(Mtxb_cargaHoraNova);
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

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso excluir = new Curso();

            try
            {
                VerificaNullorEmpty(Txb_excluiCurso.Text);
                if (MessageBox.Show("Deseja realmente excluir o curso " + Txb_excluiCurso.Text + " ?","Validação",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    excluir.Excluir(Txb_excluiCurso.Text);
                }    
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

        private void Txb_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }
    }
}

