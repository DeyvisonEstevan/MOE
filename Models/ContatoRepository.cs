using System;
using MySqlConnector;
using System.Collections.Generic;
namespace moe.Models
{
    public class ContatoRepository
    {
        //credenciais de acesso ao banco de dados
        private const string DadosConexao = "Database=moe;Data Source=localhost;User Id=root";

        public Contato BuscarPorId(int IdUsuario)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para buscar por Id (select)
            String QuerySql = "select * from Contato WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            //executar o comando e retornar um único usuário quando encontrado
            MySqlDataReader Reader = Comando.ExecuteReader();
            Contato contatoEncontrado = new Contato();
            if (Reader.Read())
            {
                contatoEncontrado.IdUsuario = Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                    contatoEncontrado.nome = Reader.GetString("nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                    contatoEncontrado.email = Reader.GetString("email");
                if (!Reader.IsDBNull(Reader.GetOrdinal("assunto")))
                    contatoEncontrado.assunto = Reader.GetString("assunto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("mensagem")))
                    contatoEncontrado.assunto = Reader.GetString("mensagem");
            }

            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno o contatoEncontrado
            return contatoEncontrado;

        }

        // Inserir(insert)
        public void Inserir(Contato user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para alterar (update)
            String QuerySql = "insert into Contato (nome,email,assunto,mensagem) values (@nome,@email,@assunto,@mensagem)";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@nome", user.nome);
            Comando.Parameters.AddWithValue("@email", user.email);
            Comando.Parameters.AddWithValue("@assunto", user.assunto);
            Comando.Parameters.AddWithValue("@mensagem", user.mensagem);
            Comando.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }

        // Listar(select)
        public List<Contato> Listar()
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para listar (select)
            String QuerySql = "select * from Contato";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //executar o comando e retornar uma lista de dados no banco de dados
            MySqlDataReader Reader = Comando.ExecuteReader();
            //criação da lista de usuários
            List<Contato> Lista = new List<Contato>();
            //percorre todos os registros retornados no banco de dados(objeto.Reader)
            while (Reader.Read())
            {
                Contato contatoEncontrado = new Contato();
                //armazenamento de informações no objeto contatoEncontrado
                if (!Reader.IsDBNull(Reader.GetOrdinal("nome")))
                    contatoEncontrado.nome = Reader.GetString("nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                    contatoEncontrado.email = Reader.GetString("email");
                if (!Reader.IsDBNull(Reader.GetOrdinal("assunto")))
                    contatoEncontrado.assunto = Reader.GetString("assunto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("mensagem")))
                    contatoEncontrado.mensagem = Reader.GetString("mensagem");
                //adicionando na lista de usuarios
                Lista.Add(contatoEncontrado);
            }
            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno da lista com todos os registros armazenados no banco de dados
            return Lista;

        }

        // Alterar(update)
        public void Alterar(Contato user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para alterar (update)
            String QuerySql = "update Contato set nome=@nome, email=@email, assunto=@assunto, mensagem=@mensagem WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@nome", user.nome);
            Comando.Parameters.AddWithValue("@email", user.email);
            Comando.Parameters.AddWithValue("@assunto", user.assunto);
            Comando.Parameters.AddWithValue("@mensagem", user.mensagem);
            Comando.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }

        // Excluir(delete)
        public void Excluir(Contato user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para excluir (delete)
            String QuerySql = "delete from Contato WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }
    }
}