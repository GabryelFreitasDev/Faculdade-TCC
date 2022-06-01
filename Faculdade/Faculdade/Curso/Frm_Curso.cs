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
        DataTable dt = new DataTable();
        Verifica verifica = new Verifica();
        Busca busca = new Busca();

        private void limpaCampos()
        {
            Txb_nomeCurso.Clear();
            Txb_nomeAlterar.Clear();
            MTxb_cargaHoraria.Clear();
            Txb_descricao.Clear();
        }

        public void AtualizaDataGridView()
        {
            string select = "SELECT * FROM Curso";
            busca.AtualizaDataGridView(select, Dgv_cursos);
        }

        public void EditaDgv()
        {
            Dgv_cursos.RowHeadersVisible = false;
            Dgv_cursos.Columns[0].HeaderText = "ID"; 
            Dgv_cursos.Columns[0].Width = 25;
            Dgv_cursos.Columns[1].HeaderText = "CURSO";
            Dgv_cursos.Columns[1].Width = 200;
            Dgv_cursos.Columns[2].HeaderText = "CARGA HORÁRIA";
            Dgv_cursos.Columns[2].Width = 70;
            Dgv_cursos.Columns[3].HeaderText = "DESCRIÇÃO";
            Dgv_cursos.Columns[3].Width = 300;
        }
       
        public void BuscaDataGridView()
        {
            string select = "SELECT * FROM \"curso\" WHERE nomeCurso LIKE '%" + Txb_buscar.Text + "%' ORDER BY nomeCurso LIMIT 100";
            busca.AtualizaDataGridView(select,Dgv_cursos);
        }

        private void verificaIsNullOrWhiteSpace()
        {
            verifica.VerificaNullorWhiteSpace(Txb_nomeCurso.Text);
            verifica.VerificaNullorWhiteSpace(Txb_descricao.Text);
            verifica.VerificaMaskFull(MTxb_cargaHoraria);
        }

        private void someCampos()
        {
            Txb_nomeAlterar.Clear();
            Txb_nomeAlterar.Enabled = false;
            Txb_nomeAlterar.Visible = false;
            Lbl_nomeAlterar.Visible = false;
        }

        private void confereCampos(Curso curso)
        {
            if (string.IsNullOrWhiteSpace(Txb_nomeCurso.Text))
                curso.mensagem = "Digite o nome do Curso";
            else if (!MTxb_cargaHoraria.MaskCompleted)
                curso.mensagem = "Digite a carga horária do Curso";
            else if (string.IsNullOrWhiteSpace(Txb_descricao.Text))
            {
                curso.mensagem = "Digite a descrição do Curso";
            }
            MessageBox.Show(curso.mensagem);
        }
        public Frm_Curso()
        {
            InitializeComponent();
        }

        private void Frm_Curso_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
            EditaDgv();
            someCampos();
        }

        private void Btn_InsereCurso_Click(object sender, EventArgs e)
        {
            Curso inserir = new Curso();
            try
            {
                if(!Txb_nomeAlterar.Visible && Lbl_operacao.Text == "INSERIR")
                {
                    verificaIsNullOrWhiteSpace();
                    inserir.Inserir(Txb_nomeCurso.Text,MTxb_cargaHoraria.Text, Txb_descricao.Text);
                    MessageBox.Show(inserir.mensagem);
                }
                else
                {
                    limpaCampos();
                    Lbl_operacao.Text = "INSERIR";
                    Lbl_nomeAcao.Text = "NOME DO CURSO:";
                    someCampos();
                }
            }
            catch (NullReferenceException)
            {
                confereCampos(inserir);
            }
            catch (Exception ex)
            {
                inserir.mensagem = "Erro na Edição:" + ex.Message;
                MessageBox.Show(inserir.mensagem);
            }
            AtualizaDataGridView();
            EditaDgv();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Curso editar = new Curso();
            try
            {
                if (Txb_nomeAlterar.Visible && Lbl_operacao.Text == "EDITAR")
                {
                    verifica.VerificaNullorWhiteSpace(Txb_nomeAlterar.Text);
                    verificaIsNullOrWhiteSpace();

                    if (MessageBox.Show("Deseja realmente editar o curso " + Txb_nomeAlterar.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        editar.Editar(Txb_nomeAlterar.Text, Txb_nomeCurso.Text, MTxb_cargaHoraria.Text, Txb_descricao.Text);
                        MessageBox.Show(editar.mensagem);
                    }
                }
                else
                {
                    Lbl_operacao.Text = "EDITAR";
                    Lbl_nomeAcao.Text = "NOME DO CURSO:";
                    Txb_nomeCurso.Clear();
                    Txb_nomeAlterar.Visible = true;
                    Txb_nomeAlterar.Enabled = true;
                    Lbl_nomeAlterar.Visible = true;
                    Txb_descricao.Clear();
                    MTxb_cargaHoraria.Text = null;   
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeAlterar.Text))
                {
                    editar.mensagem = "Digite o nome do curso que deseja alterar";
                    MessageBox.Show(editar.mensagem);
                }
                else
                {
                    confereCampos(editar);
                }
            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na Edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
            EditaDgv();
        }

        private void Btn_excluiCurso_Click_1(object sender, EventArgs e)
        {
            Curso excluir = new Curso();
            try
            {
                if (!Txb_nomeAlterar.Visible && Lbl_operacao.Text == "EXCLUIR")
                {
                    verifica.VerificaNullorWhiteSpace(Txb_nomeCurso.Text);
                    if (MessageBox.Show("Deseja realmente excluir o curso " + Txb_nomeCurso.Text + " ?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeCurso.Text);
                        MessageBox.Show(excluir.mensagem);
                    }
                }
                else
                {
                    Lbl_operacao.Text = "EXCLUIR";
                    Lbl_nomeAcao.Text = "NOME DO CURSO QUE SERÁ EXCLUIDO:";
                    someCampos();
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
            EditaDgv();
        }

        private void Txb_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
            EditaDgv();
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
                MTxb_cargaHoraria.Text = row.Cells["cargaHoraria"].Value.ToString();
            }
            catch(Exception)
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

