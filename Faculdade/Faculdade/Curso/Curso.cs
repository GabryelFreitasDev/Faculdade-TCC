using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;
using System.Windows.Forms;

namespace Faculdade
{
    class Curso
    {
        public string mensagem = "";
        public Conexao db;

        public Curso()
        {
            try
            {
                db = new Conexao();
                mensagem = "Conexão com o banco efetuada com sucesso !";
            }
            catch (Exception ex)
            {
                mensagem = "Falha ao se conectar com o banco !" + ex.Message;
            }
        }

        public void Inserir(string nomeCurso, string cargaHoraria, string descricao)
        {

            var SQL = "SELECT idCurso, nomeCurso,cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeCurso + "'";
            var dt = db.NpgSQLQuery(SQL);
            if (dt.Rows.Count == 0)
            {
                try
                {
                    var Sql = "INSERT INTO Curso (nomeCurso ,cargaHoraria, descricao) VALUES ('" + nomeCurso + "','" + cargaHoraria + "','" + descricao + "')";
                    db.NpgSQLCommand(Sql);
                    mensagem = "Inserção bem sucedida ! \nCurso: " + nomeCurso;
                }
                catch (Exception ex)
                {
                    mensagem = "Erro na Inserção:" + ex.Message;
                }
            }
            else
            {
                mensagem = "Esse Curso já existe";
            }
        }

        public void Excluir(string nomeCurso)
        {
            try
            {
                var SQL = "SELECT nomeAluno,nomeCurso FROM Aluno INNER JOIN Curso on idCurso = FK_idCurso WHERE nomeCurso = '" + nomeCurso + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    SQL = "SELECT idCurso, nomeCurso, cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeCurso + "'";
                    dt = db.NpgSQLQuery(SQL);
                    if (dt.Rows.Count > 0)
                    {
                        var Sql = "DELETE FROM Curso WHERE nomeCurso =('" + nomeCurso + "')";
                        db.NpgSQLCommand(Sql);
                        mensagem = "Exclusão bem sucedida ! \nCurso: " + nomeCurso;
                    }
                    else
                    {
                        mensagem = "Esse Curso não existe";
                    }
                }
                else
                {
                    mensagem = "Esse curso possui alunos! \nVocê não pode excluí-la!";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro na Exclusão:" + ex.Message;
            }
        }
        public void Editar(string nomeAlterar, string nomeCurso, string cargaHoraria, string descricao)
        {
            try
            {

                var SQL = "SELECT idCurso, nomeCurso, cargaHoraria, descricao FROM Curso WHERE nomeCurso = '" + nomeAlterar + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "UPDATE Curso SET nomeCurso = ('" + nomeCurso + "'), cargaHoraria = ('" + cargaHoraria + "'), descricao = ('" + descricao + "')  WHERE nomeCurso = ('" + nomeAlterar + "')";
                    db.NpgSQLCommand(Sql);
                    mensagem = "Edição bem sucedida ! \nCurso: " + nomeCurso;
                }
                else
                {
                    mensagem = "Esse Curso não existe";
                }

            }
            catch (Exception ex)
            {
                mensagem = "Erro na Edição:" + ex.Message;
            }
        }
    }
}

