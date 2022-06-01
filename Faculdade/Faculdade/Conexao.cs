using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Conexao
    {
        public string connString;
        public NpgsqlConnection conn;
        public Conexao()
        {
            try
            {
                connString = ("Host=localhost;Port=5432;Username=postgres;Password=123456789g;Database=Faculdade");
                conn = new NpgsqlConnection(connString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable NpgSQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new NpgsqlCommand(SQL, conn);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string NpgSQLCommand(string SQL)
        {
            try
            {
                var myCommand = new NpgsqlCommand(SQL, conn);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
