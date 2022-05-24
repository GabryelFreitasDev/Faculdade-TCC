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
                var Sql = "INSERT INTO Aluno (nomeAluno, cpf, dataNascimento, contato, contatoParente, email, endereco, turma, FK_idCurso) VALUES ('" + nomeAluno + "','" + cpf + "','" + dataNascimento + "','" + contato + "','" + contatoParente + "','" + email + "','" + endereco + "','" + turma + "','" + idCurso + "')";
                db.NpgSQLCommand(Sql);
                status = true;
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
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro na Edição: " + ex.Message;
            }
        }
        public void Excluir(string cpf)
        {

            try
            {
                var Sql = "DELETE Aluno WHERE cpf = '" + cpf + "'";
                db.NpgSQLCommand(Sql);
                status = true;
            }
            catch(Exception ex)
            {
                status = false;
                mensagem = "Erro na Exclusão: " + ex.Message;
            }
        }

        }

}
