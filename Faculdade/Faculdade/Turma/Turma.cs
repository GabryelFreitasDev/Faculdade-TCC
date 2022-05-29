using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Turma
    {
        public string mensagem = "";
        public bool status;
        public Conexao db;

        public Turma()
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
        public void Inserir(string nomeTurma, string turno, int idCurso)
        {
            try
            {
                var sql = "SELECT nomeTurma,turno FROM Turma WHERE nomeTurma = '" + nomeTurma + "' and FK_idCurso = '" + idCurso + "' and turno = '" + turno + "'";
                var dt = db.NpgSQLQuery(sql);
                if (dt.Rows.Count == 0)
                {
                    var Sql = "INSERT INTO Turma (nomeTurma, turno, FK_idCurso) VALUES ('" + nomeTurma + "','" + turno + "','" + idCurso + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Inserção bem sucessida! \nTurma: " + nomeTurma + "\nID: " + idCurso; ;
                }
                else
                {
                    mensagem = "Essa turma já existe!";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro na inserção: " + ex.Message;
            }
        }
        public void Editar(string nomeAlterar,string turnoAlterar, int idCursoAlterar, string nomeTurma, string turno, int idCurso)
        {
            try
            {
                var sql = "SELECT nomeTurma,turno FROM Turma WHERE nomeTurma = '" + nomeAlterar + "' and turno = '" + turnoAlterar + "' and FK_idCurso = '" + idCursoAlterar + "'";
                var dt = db.NpgSQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "UPDATE Turma SET nomeTurma = '" + nomeTurma + "', turno = '" + turno + "', FK_idCurso = '" + idCurso + "' WHERE nomeTurma = '" + nomeAlterar + "' and turno = '" + turnoAlterar + "' and FK_idCurso = '" + idCursoAlterar + "'";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Edição bem sucessida! \nTurma: " + nomeTurma + "\nID: " + idCurso; ;
                }
                else
                {
                    mensagem = "Essa turma não existe!\nConfira os campos";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na edição:" + ex.Message;
            }
        }
        public void Excluir(string nomeTurma, string turno, int idCurso)
        {
            try
            {
                var sql = "SELECT nomeTurma,turno FROM Turma WHERE nomeTurma = '" + nomeTurma + "' and turno = '" + turno + "' and FK_idCurso = '" + idCurso + "'";
                var dt = db.NpgSQLQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "DELETE FROM Turma WHERE nomeTurma = '" + nomeTurma + "' and turno = '" + turno + "' and FK_idCurso = '" + idCurso + "'";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Exclusão bem sucessida! \nTurma: " + nomeTurma + "\nID: " + idCurso;
                }
                else
                {
                    mensagem = "Essa turma não existe!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Exclusão:" + ex.Message;
            }
        }
    }
}
