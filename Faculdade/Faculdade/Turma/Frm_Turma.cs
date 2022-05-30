﻿using Npgsql;
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
    public partial class Frm_Turma : Form
    {
        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        public Frm_Turma()
        {
            InitializeComponent();
            AtualizaDataGridView();
            preencherCBDescricao(Cbx_cursoTurma);
        }

        private void Frm_Turma_Load(object sender, EventArgs e)
        {
            preencherCBDescricao(Cbx_cursoAntigo);
            Cbx_cursoAntigo.Visible = false;
            Cbx_turnoAntigo.Visible = false;
            TxB_nomeAlterar.Visible = false;
            Cbx_cursoTurma.SelectedItem = null;
            Cbx_Turno.SelectedItem = null;
            Cbx_cursoAntigo.SelectedItem = null;
            Lbl_cursoAltera.Visible = false;
            Lbl_turmaAltera.Visible = false;
            Lbl_turnoAltera.Visible = false;
            preencherCBDescricao(Cbx_cursoTurma);
        }

        private void EditaColunaDgv()
        {
            Dgv_turmas.RowHeadersVisible = false;
            Dgv_turmas.Columns[0].HeaderText = "TURMA";
            Dgv_turmas.Columns[0].Width = 100;
            Dgv_turmas.Columns[1].HeaderText = "TURNO";
            Dgv_turmas.Columns[1].Width = 80;
            Dgv_turmas.Columns[2].HeaderText = "CURSO";
            Dgv_turmas.Columns[2].Width = 280;
        }

        public void AtualizaDataGridView()
        {

            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nomeTurma, turno, nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso ORDER BY nomeCurso LIMIT 100";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_turmas.DataSource = null;
            Dgv_turmas.DataSource = dt;
            EditaColunaDgv();

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

        public void BuscaTurnoDataGridView()
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            try
            {
                if (Cbx_buscaTurno.SelectedItem != null)
                {
                    cmd.Connection = conexao.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE turno = '" + Cbx_buscaTurno.Text + "' ORDER BY nomeTurma LIMIT 100" ;
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Dgv_turmas.DataSource = null;
                    Dgv_turmas.DataSource = dt;
                    EditaColunaDgv();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    AtualizaDataGridView();
                }
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
            cmd.CommandText = "SELECT nomeTurma,turno,nomeCurso FROM Turma INNER JOIN Curso on idCurso = FK_idCurso WHERE Curso.nomeCurso LIKE '%" + Txb_buscaTurma.Text + "%' ORDER BY nomeTurma LIMIT 100";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv_turmas.DataSource = null;
            Dgv_turmas.DataSource = dt;
            EditaColunaDgv();

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
        private void preencherCBDescricao(ComboBox cb)
        {
            NpgsqlConnection con = new NpgsqlConnection(conexao.connString);
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
            cb.DataSource = null;
            da.Fill(dtResultado);
            cb.DataSource = dtResultado;
            cb.ValueMember = "idCurso";
            cb.DisplayMember = "nomeCurso";
            cb.Refresh();
        }
        private void VerificaNullorEmpty(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new NullReferenceException();
            }
        }
        private void VerificaCbxVazio(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                throw new NullReferenceException();
            }
        }

        private void Btn_insereTurma_Click(object sender, EventArgs e)
        {
            Turma inserir = new Turma();
            try
            {
                if (!TxB_nomeAlterar.Visible)
                {
                    VerificaNullorEmpty(Txb_nomeTurma.Text);

                    VerificaCbxVazio(Cbx_Turno);
                    VerificaCbxVazio(Cbx_cursoTurma);

                    inserir.Inserir(Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                    MessageBox.Show(inserir.mensagem);
                    AtualizaDataGridView();
                }
                else
                {
                    TxB_nomeAlterar.Visible = false;
                    Cbx_cursoAntigo.Visible = false;
                    Cbx_turnoAntigo.Visible = false;
                    Lbl_cursoAltera.Visible = false;
                    Lbl_turmaAltera.Visible = false;
                    Lbl_turnoAltera.Visible = false;
                }

            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeTurma.Text))
                {
                    inserir.mensagem = "Insira o nome da turma";
                }
                else if (Cbx_Turno.SelectedItem == null)
                {
                    inserir.mensagem = "Insira o turno da turma";
                }
                else if (Cbx_cursoTurma.SelectedItem == null)
                {
                    inserir.mensagem = "Escolha o curso que a turma pertence";
                }
                MessageBox.Show(inserir.mensagem);
            }

            catch (Exception ex)
            {
                inserir.mensagem = "Erro na inserção:" + ex.Message;
                MessageBox.Show(inserir.mensagem);
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            Turma editar = new Turma();
            try
            {
                if (TxB_nomeAlterar.Visible)
                {

                    VerificaNullorEmpty(TxB_nomeAlterar.Text);
                    VerificaNullorEmpty(Txb_nomeTurma.Text);

                    VerificaCbxVazio(Cbx_turnoAntigo);
                    VerificaCbxVazio(Cbx_cursoAntigo);

                    VerificaCbxVazio(Cbx_Turno);
                    VerificaCbxVazio(Cbx_cursoTurma);

                    editar.Editar(TxB_nomeAlterar.Text, Cbx_turnoAntigo.Text, (int)Cbx_cursoAntigo.SelectedValue, Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                    MessageBox.Show(editar.mensagem);
                    AtualizaDataGridView();

                }
                else
                {
                    TxB_nomeAlterar.Visible = true;
                    Cbx_cursoAntigo.Visible = true;
                    Cbx_turnoAntigo.Visible = true;
                    Lbl_cursoAltera.Visible = true;
                    Lbl_turmaAltera.Visible = true;
                    Lbl_turnoAltera.Visible = true;
                    Cbx_cursoTurma.SelectedItem = null;
                    Cbx_Turno.SelectedItem = null;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeTurma.Text))
                {
                    editar.mensagem = "Insira o nome da turma";
                }
                else if (string.IsNullOrEmpty(TxB_nomeAlterar.Text))
                {
                    editar.mensagem = "Escolha o curso que deseja alterar";
                }
                else if (Cbx_Turno.SelectedItem == null)
                {
                    editar.mensagem = "Insira o turno da turma";
                }
                else if (Cbx_turnoAntigo.SelectedItem == null)
                {
                    editar.mensagem = "Selecione o turno do curso que deseja alterar";
                }
                else if (Cbx_cursoTurma.SelectedItem == null)
                {
                    editar.mensagem = "Escolha o curso que a turma pertence";
                }
                else if (Cbx_cursoAntigo.SelectedItem == null)
                {
                    editar.mensagem = "Selecione o curso da turma que está tentando alterar";
                }
                MessageBox.Show(editar.mensagem);
            }
            catch (Exception ex)
            {
                editar.mensagem = "Erro na edição:" + ex.Message;
                MessageBox.Show(editar.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Dgv_turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = Dgv_turmas.Rows[e.RowIndex];
                if (!TxB_nomeAlterar.Visible)
                {
                    Txb_nomeTurma.Text = row.Cells["nomeTurma"].Value.ToString();
                    TxB_nomeAlterar.Text = row.Cells["nomeTurma"].Value.ToString();
                    Cbx_Turno.Text = row.Cells["turno"].Value.ToString();
                    Cbx_cursoTurma.Text = row.Cells["nomeCurso"].Value.ToString();
                    Cbx_turnoAntigo.Text = row.Cells["turno"].Value.ToString();
                    Cbx_cursoAntigo.Text = row.Cells["nomecurso"].Value.ToString();
                }
                else
                {
                    TxB_nomeAlterar.Text = row.Cells["nomeTurma"].Value.ToString();
                    Cbx_cursoAntigo.Text = row.Cells["nomecurso"].Value.ToString();
                    Cbx_turnoAntigo.Text = row.Cells["turno"].Value.ToString();
                    Txb_nomeTurma.Clear();
                    Cbx_Turno.Text = null;
                    Cbx_cursoTurma.SelectedItem = null;
                }
                Cbx_cursoTurma.Text = row.Cells["nomeCurso"].Value.ToString();
                Cbx_Turno.Text = row.Cells["turno"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o curso que deseja editar");
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            Turma excluir = new Turma();
            try
            {
                if (!TxB_nomeAlterar.Visible)
                {
                    VerificaCbxVazio(Cbx_cursoTurma);
                    VerificaCbxVazio(Cbx_Turno);
                    VerificaNullorEmpty(Txb_nomeTurma.Text);
                    if (MessageBox.Show("Deseja realmente excluir a turma " + Txb_nomeTurma.Text + " do curso de " +  Cbx_cursoTurma.Text + " do turno "+ Cbx_Turno.Text + "?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        excluir.Excluir(Txb_nomeTurma.Text, Cbx_Turno.Text, (int)Cbx_cursoTurma.SelectedValue);
                        MessageBox.Show(excluir.mensagem);
                    } 
                    AtualizaDataGridView();
                }
                else
                {
                    TxB_nomeAlterar.Visible = false;
                    Cbx_cursoAntigo.Visible = false;
                    Cbx_turnoAntigo.Visible = false;
                    Lbl_cursoAltera.Visible = false;
                    Lbl_turmaAltera.Visible = false;
                    Lbl_turnoAltera.Visible = false;
                }
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeTurma.Text))
                {
                    excluir.mensagem = "Insira o nome da turma";
                }
                else if (Cbx_Turno.SelectedItem == null)
                {
                    excluir.mensagem = "Insira o turno da turma";
                }
                else if (Cbx_cursoTurma.SelectedItem == null)
                {
                    excluir.mensagem = "Escolha o curso que a turma pertence";
                }
                MessageBox.Show(excluir.mensagem);
            }
            catch (Exception ex)
            {
                excluir.mensagem = "Erro na e:" + ex.Message;
                MessageBox.Show(excluir.mensagem);
            }
            AtualizaDataGridView();
        }

        private void Txb_buscaTurma_TextChanged(object sender, EventArgs e)
        {
            BuscaDataGridView();
        }

        private void Cbx_buscaTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscaTurnoDataGridView();
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            Txb_buscaTurma.Clear();
            Cbx_buscaTurno.SelectedItem = null;
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            Txb_nomeTurma.Clear();
            TxB_nomeAlterar.Clear();
            Cbx_cursoAntigo.SelectedItem = null;
            Cbx_cursoTurma.SelectedItem = null;
            Cbx_Turno.SelectedItem = null;
            Cbx_turnoAntigo.SelectedItem = null;
        }

        private void Btn_relatorioCurso_Click(object sender, EventArgs e)
        {
            using (Frm_relatorioTurma relatorioTurma = new Frm_relatorioTurma(dt))
            {
                relatorioTurma.ShowDialog();
            }
        }
    }
}
