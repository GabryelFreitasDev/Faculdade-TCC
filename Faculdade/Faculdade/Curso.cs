using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;

namespace Faculdade
{
    class Curso
    {
        public string mensagem = "";
        public bool status;
        public Conexao db;
        NpgsqlCommand cmd = new NpgsqlCommand();

        public Curso()
        {
            status = true;
            try
            {
                db = new Conexao();
                mensagem = "Conexão com o banco efetuada com sucesso !";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Falha ao se conectar com o banco !" + ex.Message;
            }
        }
        public void Inserir(string nomeCurso)
        {
            status = true;
            try
            {
                var SQL = "SELECT idCurso, nomeCurso FROM Curso WHERE nomeCurso = '" + nomeCurso + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    var Sql = "INSERT INTO Curso (nomeCurso) VALUES ('" + nomeCurso + "')";
                    //cmd.Parameters.AddWithValue("@nomeCurso", nomeCurso);
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Inserção bem sucedida ! Curso: " + nomeCurso;
                }
                else
                {
                    status = false;
                    mensagem = "Esse Curso já existe";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Inserção:" + ex.Message;
            }
        }
    }
}   

