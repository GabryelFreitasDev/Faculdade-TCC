using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Materia
    {
        public string mensagem = "";
        public Conexao db;
        public Materia()
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

        public void Inserir(string nomeMateria, string descricao, int idTurma,int idCurso)
        {
            try
            {
                var SQL = "SELECT nomeMateria,nomeTurma FROM Materia INNER JOIN Turma on FK_idTurma = idTurma WHERE nomeMateria ='" + nomeMateria + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    SQL = "INSERT INTO Materia (nomeMateria, descricaoMateria, FK_idTurma, FK_idCurso) VALUES ('" + nomeMateria + "','" + descricao + "','" + idTurma + "','" + idCurso + "')";
                    db.NpgSQLCommand(SQL);
                    mensagem = "Inserção bem sucedida!\nMatéria = " + nomeMateria;
                }
                else
                {
                    mensagem = "Essa matéria já existe neste Curso";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro na Inserção: " + ex.Message;
            }
        }

        public void Editar(string nomeAlterar, string nomeMateria, string descricao, int idTurma,int idCurso)
        {
            try
            {
                var SQL = "SELECT nomeMateria,nomeTurma FROM Materia INNER JOIN Turma on FK_idTurma = idTurma WHERE nomeMateria ='" + nomeAlterar + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    SQL = "UPDATE Materia SET nomeMateria = '" + nomeMateria + "', descricaoMateria = '" + descricao + "', FK_idTurma = '" + idTurma + "', FK_idCurso = '" + idCurso + "' WHERE nomeMateria = '" + nomeAlterar + "'";
                    db.NpgSQLCommand(SQL);
                    mensagem = "Edição bem sucedida!\nMatéria = " + nomeMateria;
                }
                else
                {
                    mensagem = "Essa matéria não existe";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro na Edição: " + ex.Message;
            }
        }

        public void Excluir(string nomeMateria)
        {
            try
            {
                var SQL = "SELECT nomeMateria FROM Materia WHERE nomeMateria = '" + nomeMateria + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    SQL = "DELETE FROM Materia WHERE nomeMateria = '" + nomeMateria + "'";
                    db.NpgSQLCommand(SQL);
                    mensagem = "Excluão bem sucedida!\nMatéria = " + nomeMateria;
                }
                else
                {
                    mensagem = "Essa Materia não existe";
                }

            }
            catch (Exception ex)
            {
                mensagem = "Erro na Exclusão: " + ex.Message;
            }
        }
    }
}
