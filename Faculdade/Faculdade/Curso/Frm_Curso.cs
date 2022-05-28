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

        private void limpaCampos()
        {
            Txb_nomeCurso.Clear();
            Txb_nomeAlterar.Clear();
            MTxb_cargaHoraria.Clear();
            Txb_descricao.Clear();
            Cbx_Turno.SelectedItem = null;
        }

        private void Frm_Curso_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
            Txb_nomeAlterar.Enabled = false;
            Txb_nomeAlterar.Visible = false;
            Lbl_nomeAlterar.Visible = false;
            EditaDgv();
        }

        public void EditaDgv()
        {
            Dgv_cursos.RowHeadersVisible = false;
            Dgv_cursos.Columns[0].HeaderText = "ID"; 
            Dgv_cursos.Columns[0].Width = 25;
            Dgv_cursos.Columns[1].HeaderText = "CURSO";
            Dgv_cursos.Columns[1].Width = 150;
            Dgv_cursos.Columns[2].HeaderText = "TURNO";
            Dgv_cursos.Columns[2].Width = 60;
            Dgv_cursos.Columns[3].HeaderText = "CARGA HORÁRIA";
            Dgv_cursos.Columns[3].Width = 60;
            Dgv_cursos.Columns[4].HeaderText = "DESCRIÇÃO";
            Dgv_cursos.Columns[4].Width = 250;
       
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
            Dgv_cursos.DataSource = null;
            Dgv_cursos.DataSource = dt;
            EditaDgv();
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
            Dgv_cursos.DataSource = null;
            Dgv_cursos.DataSource = dt;
            

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

        //INSERIR
        private void Btn_InsereCurso_Click(object sender, EventArgs e)
        {
            Curso inserir = new Curso();
            try
            {
                if(!Txb_nomeAlterar.Visible && Lbl_operacao.Text == "INSERIR")
                {
                    VerificaNullorEmpty(Txb_nomeCurso.Text);
                    VerificaNullorEmpty(Cbx_Turno.Text);
                    VerificaNullorEmpty(Txb_descricao.Text);
                    VerificaMaskFull(MTxb_cargaHoraria);
                    inserir.Inserir(Txb_nomeCurso.Text, Cbx_Turno.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                    MessageBox.Show(inserir.mensagem);
                }
                else
                {
                    limpaCampos();
                    Lbl_operacao.Text = "INSERIR";
                    Lbl_nomeAcao.Text = "Nome do curso:";
                    Txb_nomeAlterar.Clear();
                    Txb_nomeAlterar.Enabled = false;
                    Txb_nomeAlterar.Visible = false;
                    Lbl_nomeAlterar.Visible = false;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeCurso.Text))
                {
                    inserir.mensagem = "Digite o nome do Curso";
                }
                else if (string.IsNullOrEmpty(Cbx_Turno.Text))
                {
                    inserir.mensagem = "Escolha o turno do Curso";
                }
                else if (!MTxb_cargaHoraria.MaskCompleted)
                {
                    inserir.mensagem = "Digite a carga horária do Curso";
                }
                else if (string.IsNullOrEmpty(Txb_descricao.Text))
                {
                    inserir.mensagem = "Digite a descrição do Curso";
                }
                MessageBox.Show(inserir.mensagem);
            }
            catch (Exception ex)
            {
                inserir.mensagem = "Erro na Edição:" + ex.Message;
                MessageBox.Show(inserir.mensagem);
            }
            
            AtualizaDataGridView();
        }

        //EDITAR
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Curso editar = new Curso();
            try
            {
                if (Txb_nomeAlterar.Visible && Lbl_operacao.Text == "EDITAR")
                {
                    VerificaNullorEmpty(Txb_nomeCurso.Text);
                    VerificaNullorEmpty(Cbx_Turno.Text);
                    VerificaNullorEmpty(Txb_descricao.Text);
                    VerificaNullorEmpty(Txb_nomeAlterar.Text);
                    VerificaMaskFull(MTxb_cargaHoraria);

                    if (MessageBox.Show("Deseja realmente editar o curso " + Txb_nomeAlterar.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        editar.Editar(Txb_nomeAlterar.Text, Txb_nomeCurso.Text, Cbx_Turno.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                        MessageBox.Show(editar.mensagem);
                    }
                }
                else
                {
                    Lbl_operacao.Text = "EDITAR";
                    Lbl_nomeAcao.Text = "Nome do curso:";
                    Txb_nomeCurso.Clear();
                    Txb_nomeAlterar.Visible = true;
                    Txb_nomeAlterar.Enabled = true;
                    Lbl_nomeAlterar.Visible = true;
                }

            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Digite o nome do Curso que deseja alterar";
                }
                if (string.IsNullOrEmpty(Txb_nomeCurso.Text))
                {
                    editar.mensagem = "Digite o nome do Curso que deseja alterar";
                }
                else if (string.IsNullOrEmpty(Cbx_Turno.Text))
                {
                    editar.mensagem = "Escolha o turno do Curso";
                }
                else if (MTxb_cargaHoraria.Text == "     Hrs")
                {
                    editar.mensagem = "Digite a carga horária do Curso";
                }
                else if (string.IsNullOrEmpty(Txb_descricao.Text))
                {
                    editar.mensagem = "Digite a descrição do Curso";
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
        //EXCLUIR
        private void Btn_excluiCurso_Click_1(object sender, EventArgs e)
        {
            Curso excluir = new Curso();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_operacao.Text == "EXCLUIR")
                {
                    VerificaNullorEmpty(Txb_nomeCurso.Text);
                    if (MessageBox.Show("Deseja realmente excluir o curso " + Txb_nomeCurso.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeCurso.Text);
                        MessageBox.Show(excluir.mensagem);
                    }
                }
                else
                {
                    Lbl_operacao.Text = "EXCLUIR";
                    Lbl_nomeAcao.Text = "Nome do curso que será excluído:";
                    Txb_nomeAlterar.Enabled = false;
                    Txb_nomeAlterar.Visible = false;
                    Lbl_nomeAlterar.Visible = false;
                }

            }
            catch (NullReferenceException)
            {
                excluir.mensagem = "Digite o nome do curso que deseja excluir";
                MessageBox.Show(excluir.mensagem);
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na Exclusão:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Txb_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }

        private void Dgv_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = Dgv_cursos.Rows[e.RowIndex];
                if (!Txb_nomeAlterar.Visible)
                {
                    Txb_nomeCurso.Text = row.Cells["nomecurso"].Value.ToString();
                    Txb_nomeAlterar.Text = row.Cells["nomecurso"].Value.ToString();
                }
                else
                {
                    Txb_nomeAlterar.Text = row.Cells["nomecurso"].Value.ToString();
                    Txb_nomeCurso.Clear();
                }

                Txb_descricao.Text = row.Cells["descricao"].Value.ToString();
                Cbx_Turno.Text = row.Cells["turno"].Value.ToString();
                MTxb_cargaHoraria.Text = row.Cells["cargaHoraria"].Value.ToString();

            }catch(Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
           
        }

        private void Btn_relatorioCurso_Click_1(object sender, EventArgs e)
        {

            using (Frm_relatorioCurso relatorioCurso = new Frm_relatorioCurso(dt))
            {
                relatorioCurso.ShowDialog();
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            Txb_buscar.Clear();
        }
    }
}

