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
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM \"curso\"";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_curso.DataSource = null;
            Dgv_curso.DataSource = dt;

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
            Dgv_curso.DataSource = null;
            Dgv_curso.DataSource = dt;

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
            Txb_nomeAlterar.Enabled = false;
            Txb_nomeAlterar.Visible = false;
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
                if(!Txb_nomeAlterar.Visible)
                {
                    VerificaNullorEmpty(Txb_nomeCurso.Text);
                    VerificaNullorEmpty(Cbx_Turno.Text);
                    VerificaNullorEmpty(Txb_descricao.Text);
                    VerificaMaskFull(MTxb_cargaHoraria);
                    curso.Inserir(Txb_nomeCurso.Text, Cbx_Turno.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                }
                else
                {
                    Txb_nomeAlterar.Enabled = false;
                    Txb_nomeAlterar.Visible = false;
                }


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

        private void Btn_excluiCurso_Click(object sender, EventArgs e)
        {
            Curso excluir = new Curso();

            try
            {
                VerificaNullorEmpty(Txb_nomeCurso.Text);
                if (MessageBox.Show("Deseja realmente excluir o curso " + Txb_nomeCurso.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    excluir.Excluir(Txb_nomeCurso.Text);
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

        private void Btn_relatorioCurso_Click(object sender, EventArgs e)
        {
            using (Frm_relatorioCurso rCurso = new Frm_relatorioCurso(dt))
            {
                rCurso.ShowDialog();
            }
        }

        private void Dgv_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                DataGridViewRow row = Dgv_curso.Rows[e.RowIndex];
                if (!Txb_nomeAlterar.Visible)
                {
                    Txb_nomeCurso.Text = row.Cells["nomecurso"].Value.ToString();
                }
                else
                {
                    Txb_nomeAlterar.Text = row.Cells["nomecurso"].Value.ToString();
                    Txb_nomeCurso.Clear();
                }
                Txb_descricao.Text = row.Cells["descricao"].Value.ToString();
                Cbx_Turno.Text = row.Cells["turno"].Value.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
           
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            try
            {
                if(Txb_nomeAlterar.Visible)
                {
                    VerificaNullorEmpty(Txb_nomeCurso.Text);
                    VerificaNullorEmpty(Cbx_Turno.Text);
                    VerificaNullorEmpty(Txb_descricao.Text);
                    VerificaNullorEmpty(Txb_nomeAlterar.Text);
                    VerificaMaskFull(MTxb_cargaHoraria);

                    if (MessageBox.Show("Deseja realmente editar o curso " + Txb_nomeCurso.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        curso.Editar(Txb_nomeAlterar.Text, Txb_nomeCurso.Text, Cbx_Turno.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                    }
                }
                else
                {
                    Txb_nomeAlterar.Visible = true;
                    Txb_nomeAlterar.Enabled = true;
                }
               
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAlterar.Text))
                {
                    curso.mensagem = "Digite o nome do Curso que deseja alterar";
                }
                if (string.IsNullOrEmpty(Txb_nomeCurso.Text))
                {
                    curso.mensagem = "Digite o nome do Curso que deseja alterar";
                }
                else if (string.IsNullOrEmpty(Cbx_Turno.Text))
                {
                    curso.mensagem = "Escolha o turno do Curso";
                }
                else if (MTxb_cargaHoraria.Text == "     Hrs")
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
    }
}

