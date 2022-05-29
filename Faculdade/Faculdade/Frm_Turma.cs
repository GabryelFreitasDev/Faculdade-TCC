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
    public partial class Frm_Turma : Form
    {
        Conexao conexao = new Conexao();
        public Frm_Turma()
        {
            InitializeComponent();
            preencherCBDescricao(Cbx_cursoTurma);
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

        private void Btn_insereTurma_Click(object sender, EventArgs e)
        {
            Turma inserir = new Turma();
            try
            {
                VerificaNullorEmpty(Txb_nomeTurma.Text);
                inserir.Inserir(Txb_nomeTurma.Text, (int)Cbx_cursoTurma.SelectedValue);
                MessageBox.Show(inserir.mensagem);
            }
            catch (NullReferenceException)
            {
                if (string.IsNullOrEmpty(Txb_nomeTurma.Text))
                {
                    inserir.mensagem = "Insira o nome da turma";
                }
                else
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

        private void Frm_Turma_Load(object sender, EventArgs e)
        {

        }
    }
}
