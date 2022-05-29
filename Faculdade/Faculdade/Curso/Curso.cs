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
        public void Inserir(string nomeCurso,string cargaHoraria,string descricao)
        {
            
            var SQL = "SELECT idCurso, nomeCurso,cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeCurso + "'";
            var dt = db.NpgSQLQuery(SQL);
            if (dt.Rows.Count == 0)
            {
                try
                {
                    var Sql = "INSERT INTO Curso (nomeCurso ,cargaHoraria, descricao) VALUES ('" + nomeCurso + "','" + cargaHoraria + "','" + descricao + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Inserção bem sucedida ! \nCurso: " + nomeCurso;
                }
                catch (Exception ex)
                {
                    mensagem = "Erro na Inserção:" + ex.Message;
                }
            }
            else
            {
                status = false;
                mensagem = "Esse Curso já existe";
            }      
        }

        public void Excluir(string nomeCurso)
        {
            status = true;
            try
            {
                var SQL = "SELECT idCurso, nomeCurso, cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeCurso + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "DELETE FROM Curso WHERE nomeCurso =('" + nomeCurso + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Exclusão bem sucedida ! \nCurso: " + nomeCurso;
                }
                else
                {
                    status = false;
                    mensagem = "Esse Curso não existe";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Exclusão:" + ex.Message;
            }
        }
        public void Editar(string nomeAlterar, string nomeCurso, string cargaHoraria, string descricao)
        {
            status = true;
            try
            {
                var SQL = "SELECT idCurso, nomeCurso, cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeAlterar + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "UPDATE Curso SET nomeCurso = ('" + nomeCurso + "'), cargaHoraria = ('" + cargaHoraria + "'), descricao = ('" + descricao + "')  WHERE nomeCurso = ('" + nomeAlterar + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Edição bem sucedida ! \nCurso: " + nomeCurso;
                }
                else
                {
                    status = false;
                    mensagem = "Esse Curso não existe";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Edição:" + ex.Message;
            }
        }
    }
}   

