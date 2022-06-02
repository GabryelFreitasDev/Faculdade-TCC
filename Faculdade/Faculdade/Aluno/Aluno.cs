using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade
{
    class Aluno
    {
        public string mensagem = "";
        public Conexao db;

        public Aluno()
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
        public void Inserir(string nomeAluno, string cpf, string dataNascimento, string contato, string contatoParente, string email, string endereco, int idCurso, int idTurma)
        {
            try
            {
                var SQL = "SELECT idAluno, nomeAluno,cpf FROM Aluno WHERE cpf = '" + cpf + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    var Sql = "INSERT INTO Aluno (nomeAluno, cpf, dataNascimento, contato, contatoParente, email, endereco,FK_idCurso, FK_idTurma) VALUES ('" + nomeAluno + "','" + cpf + "','" + dataNascimento + "','" + contato + "','" + contatoParente + "','" + email + "','" + endereco + "','" + idCurso + "','" + idTurma + "')";
                    db.NpgSQLCommand(Sql);
                    mensagem = "Inserção bem sucedida!\nAluno = " + nomeAluno;
                }
                else
                {
                    mensagem = "Esse CPF já está cadastrado!\nInsira outra pessoa ou edite a existente";
                }

            }
            catch (Exception ex)
            {
                mensagem = "Erro na Inserção: " + ex.Message;
            }
        }

        public void Editar(string nomeAlterar, string nomeAluno, string cpf, string dataNascimento, string contato, string contatoParente, string email, string endereco, int idCurso, int idTurma)
        {
            try
            {
                var Sql = "UPDATE Aluno SET nomeAluno = '" + nomeAluno + "', cpf = '" + cpf + "', dataNascimento = '" + dataNascimento + "', contato = '" + contato + "', contatoParente = '" + contatoParente + "', email = '" + email + "', endereco ='" + endereco + "', FK_idCurso = '" + idCurso + "',FK_idTurma = '" + idTurma + "' WHERE nomeAluno = '" + nomeAlterar + "'";
                db.NpgSQLCommand(Sql);
                mensagem = "Edição bem sucedida!\nAluno = " + nomeAluno;
            }
            catch (Exception ex)
            {
                mensagem = "Erro na Edição: " + ex.Message;
            }
        }
        public void Excluir(string nomeAluno, string cpf)
        {

            try
            {
                var SQL = "SELECT idAluno, nomeAluno,cpf FROM Aluno WHERE cpf = '" + cpf + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    var Sql = "DELETE FROM Aluno WHERE cpf = '" + cpf + "'";
                    db.NpgSQLCommand(Sql);
                    mensagem = "Exclusão bem sucedida!\nAluno :" + nomeAluno;
                }
                else
                {
                    mensagem = "Esse aluno não existe";
                }
            }
            catch (Exception ex)
            {
                mensagem = "Erro na Exclusão: " + ex.Message;
            }
        }
    }
}
