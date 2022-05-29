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
        public void Inserir(string nomeTurma, int idCurso)
        {
            try
            {
                var sql = "SELECT nomeTurma FROM Turma WHERE nomeTurma = '" + nomeTurma + "' and FK_idCurso = '" + idCurso + "'";
                var dt = db.NpgSQLQuery(sql);
                if (dt.Rows.Count == 0)
                {
                    var Sql = "INSERT INTO Turma (nomeTurma,FK_idCurso) VALUES ('" + nomeTurma + "','" + idCurso + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Inserção bem sucessida! \nTurma: " + nomeTurma;
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
        public void Editar(string nomeAlterar,int idCurso)
        {

        }
    }
}
