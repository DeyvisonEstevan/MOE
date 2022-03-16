using System;
using MySqlConnector;
using System.Collections.Generic;
namespace moe.Models
{
    public class VendaRepository
    {
        //credenciais de acesso ao banco de dados
        private const string DadosConexao = "Database=moe;Data Source=localhost;User Id=root";

        //testar conexão
        public void TestarConexao()
        {

            //informar a credencial de acesso
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            //abrir conexão
            Conexao.Open();
            //imprimir uma mensagem indicando o funcionamento
            Console.WriteLine("Banco de dados Funcionando!");
            //fechar conexão
            Conexao.Close();
        }

        

        public Venda BuscarPorId(int IdVenda)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para buscar por Id (select)
            String QuerySql = "select * from Venda WHERE IdVenda=@IdVenda";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdVenda", IdVenda);
            //executar o comando e retornar um único usuário quando encontrado
            MySqlDataReader Reader = Comando.ExecuteReader();
            Venda vendaEncontrada = new Venda();
            //armazenamento de informações no objeto vendaEncontrada
            if(Reader.Read()){
                vendaEncontrada.IdVenda = Reader.GetInt32("IdVenda");
                if (!Reader.IsDBNull(Reader.GetOrdinal("IdUsuario")))
                    vendaEncontrada.IdUsuario = Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("IdProduto")))
                    vendaEncontrada.IdProduto = Reader.GetInt32("IdProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                    vendaEncontrada.NomeProduto = Reader.GetString("NomeProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("QuantidadeVendida")))
                    vendaEncontrada.QuantidadeVendida = Reader.GetInt32("QuantidadeVendida");
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorProduto")))
                    vendaEncontrada.ValorProduto = Reader.GetInt32("ValorProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorTotalProduto")))
                    vendaEncontrada.ValorTotalProduto = Reader.GetInt32("ValorTotalProduto");
            }
            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno o UsuarioEncontrado
            return vendaEncontrada;

        }

        //CRUD - Inserir(insert), Listar(select), Alterar(update), Excluir(delete)

        // Inserir(insert)
        public void Inserir(Venda user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //int ValorTotalProduto = 0;
            //ValorTotalProduto=user.ValorProduto * user.QuantidadeVendida;

            //query em sql para alterar (update)
            String QuerySql = "insert into Venda (IdUsuario,IdProduto,NomeProduto,QuantidadeVendida,ValorProduto,ValorTotalProduto) values (@IdUsuario,@IdProduto,@NomeProduto,@QuantidadeVendida,@ValorProduto,@ValorTotalProduto)";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
            Comando.Parameters.AddWithValue("@IdProduto", user.IdProduto);
            Comando.Parameters.AddWithValue("@NomeProduto", user.NomeProduto);
            Comando.Parameters.AddWithValue("@QuantidadeVendida", user.QuantidadeVendida);
            Comando.Parameters.AddWithValue("@ValorProduto", user.ValorProduto);
            Comando.Parameters.AddWithValue("@ValorTotalProduto", user.ValorTotalProduto);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }

        // Listar(select)
        public List<Venda> Listar()
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para listar (select)
            String QuerySql = "select * from Venda";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //executar o comando e retornar uma lista de dados no banco de dados
            MySqlDataReader Reader = Comando.ExecuteReader();
            //criação da lista de usuários
            List<Venda> Lista = new List<Venda>();
            //percorre todos os registros retornados no banco de dados(objeto.Reader)
            while (Reader.Read())
            {
                Venda vendaEncontrada = new Venda();
                //armazenamento de informações no objeto vendaEncontrada
                vendaEncontrada.IdVenda = Reader.GetInt32("IdVenda");
                if (!Reader.IsDBNull(Reader.GetOrdinal("IdUsuario")))
                    vendaEncontrada.IdUsuario = Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("IdProduto")))
                    vendaEncontrada.IdProduto = Reader.GetInt32("IdProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                    vendaEncontrada.NomeProduto = Reader.GetString("NomeProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("QuantidadeVendida")))
                    vendaEncontrada.QuantidadeVendida = Reader.GetInt32("QuantidadeVendida");
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorProduto")))
                    vendaEncontrada.ValorProduto = Reader.GetInt32("ValorProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("ValorTotalProduto")))
                    vendaEncontrada.ValorTotalProduto = Reader.GetInt32("ValorTotalProduto");
                //adicionando na lista de usuarios
                Lista.Add(vendaEncontrada);
            }
            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno da lista com todos os registros armazenados no banco de dados
            return Lista;

        }

        // Alterar(update)
        public void Alterar(Venda user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para alterar (update)
            String QuerySql = "update Usuario set IdUsuario=@IdUsuario, IdProduto=@IdProduto, NomeProduto=@NomeProduto, QuantidadeVendida=@QuantidadeVendida, ValorProduto=@ValorProduto, ValorTotalProduto=@ValorTotalProduto WHERE IdVenda=@IdVenda";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario", user.IdUsuario);
            Comando.Parameters.AddWithValue("@IdProduto", user.IdProduto);
            Comando.Parameters.AddWithValue("@NomeProduto", user.NomeProduto);
            Comando.Parameters.AddWithValue("@QuantidadeVendida", user.QuantidadeVendida);
            Comando.Parameters.AddWithValue("@ValorProduto", user.ValorProduto);
            Comando.Parameters.AddWithValue("@ValorTotalProduto", user.ValorTotalProduto);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }

        // Excluir(delete)
        public void Excluir(Venda user)
        {
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para excluir (delete)
            String QuerySql = "delete from Venda WHERE IdVenda=@IdVenda";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdVenda", user.IdVenda);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }
    }
}