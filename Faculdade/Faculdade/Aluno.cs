using Npgsql;
using System;
using System.Collections.Generic;
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
                var Sql = "INSERT INTO Aluno (nomeAluno, cpf, dataNascimento, contato, contatoParente, email, endereco, turma, idCurso) VALUES ('" + nomeAluno + "','" + cpf + "','" + dataNascimento + "','" + contato + "','" + contatoParente + "','" + email + "','" + endereco + "','" + turma + "','" + idCurso + "')";
                db.NpgSQLCommand(Sql);
                status = true;
            }
            catch (Exception ex)
            {
                status=false;
                mensagem = "Erro na Inserção" + ex.Message;
            }
            
        }
    }
}
