using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade
{
    class Busca
    {
        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();
        DataTable dt = new DataTable();
        public void preencherComboBox(ComboBox cb,string select,string valueMember, string displayMember)
        {
            NpgsqlConnection con = new NpgsqlConnection(conexao.connString);
            try
            {
                con.Open();
                String scom = select;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(scom, con);
                DataTable dtResultado = new DataTable();
                da.Fill(dtResultado);
                cb.DataSource = dtResultado;
                cb.ValueMember = valueMember;
                cb.DisplayMember = displayMember;
                cb.Refresh();
            }
            catch (NpgsqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizaDataGridView(string atualiza, DataGridView Dgv)
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            cmd.Connection = conexao.conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = atualiza;
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Dgv.DataSource = null;
            Dgv.DataSource = dt;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(PostgresException)
            {
                MessageBox.Show("Erro na busca insira caracteres válidos");
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

        public void BuscaDataGridView(ComboBox cb,string busca, DataGridView DGV)
        {
            if (conexao.conn.State != ConnectionState.Open)
            {
                conexao.conn.Open();
            }
            try
            {
                if (cb.SelectedItem != null)
                {
                    cmd.Connection = conexao.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = busca;
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    DGV.DataSource = null;
                    DGV.DataSource = dt;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    DGV.Refresh();
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
    }
}
