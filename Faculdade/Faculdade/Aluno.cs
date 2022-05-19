//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Faculdade
//{
//    class Aluno
//    {
//        public string mensagem = "";
//        public bool status;
//        public Conexao db;

//        public Aluno()
//        {
//            status = true;
//            try
//            {
//                db = new Conexao();
//                mensagem = "Conexão com o banco efetuada com sucesso !";
//            }
//            catch (Exception ex)
//            {
//                status = false;
//                mensagem = "Falha ao se conectar com o banco !" + ex.Message;
//            }
//        }
//        public void Inserir(string nomeAluno, DateTime dataNascimento, string contato1, string endereco, string contatoParente, bool cursando)
//        {
//            status = true;
//            try
//            {
//                var Sql = "INSERT INTO Aluno (nomeAluno, dataNascimento, contato1, endereco, contatoParente, cursando,) VALUES (@"
//            }
//            catch (Exception ex0)
//            {

//            }
//        }
//    }
//}
