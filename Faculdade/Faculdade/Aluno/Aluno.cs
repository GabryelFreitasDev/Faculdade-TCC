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
        public bool status;
        public Conexao db;

        public Aluno()
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
        public void Inserir(string nomeAluno, string cpf, string dataNascimento, string contato, string contatoParente, string email, string endereco, string turma, int idCurso)
        {
            try
            {
                var SQL = "SELECT idAluno, nomeAluno,cpf FROM Aluno WHERE cpf = '" + cpf + "'";
                var dt = db.NpgSQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    var Sql = "INSERT INTO Aluno (nomeAluno, cpf, dataNascimento, contato, contatoParente, email, endereco, turma, FK_idCurso) VALUES ('" + nomeAluno + "','" + cpf + "','" + dataNascimento + "','" + contato + "','" + contatoParente + "','" + email + "','" + endereco + "','" + turma + "','" + idCurso + "')";
                    db.NpgSQLCommand(Sql);
                    status = true;
                    mensagem = "Inserção bem sucedida!\nAluno = " + nomeAluno;
                }
                else
                {
                    mensagem = "Esse CPF já está cadastrado!\nInsira outra pessoa ou edite a existente";
                    status = false;
                }
                    
            }
            catch (Exception ex)
            {
                status=false;
                mensagem = "Erro na Inserção: " + ex.Message;
            }
        }

        public void Editar(string nomeAlterar, string nomeAluno, string cpf, string dataNascimento, string contato, string contatoParente, string email, string endereco, string turma, int idCurso)
        {
            try
            {
                var Sql = "UPDATE Aluno SET nomeAluno = '" + nomeAluno + "', cpf = '" + cpf + "', dataNascimento = '" + dataNascimento + "', contato = '" + contato + "', contatoParente = '" + contatoParente + "', email = '" + email + "', endereco ='" + endereco + "', turma = '" + turma + "', FK_idCurso = '" + idCurso + "' WHERE nomeAluno = '" + nomeAlterar + "'";
                db.NpgSQLCommand(Sql);
                status = true;
                mensagem = "Edição bem sucedida!\nAluno = " + nomeAluno;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Edição: " + ex.Message;
            }
        }
        public void Excluir(string nomeAluno,string cpf)
        {

            try
            {
                var Sql = "DELETE FROM Aluno WHERE nomeAluno = '" + nomeAluno + "', cpf = '" + cpf + "'";
                db.NpgSQLCommand(Sql);
                status = true;
                mensagem = "Exclusão bem sucedida!\nAluno :" + nomeAluno;
            }
            catch(Exception ex)
            {
                status = false;
                mensagem = "Erro na Exclusão: " + ex.Message;
            }
        }

        }

}
