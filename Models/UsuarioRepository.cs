using System;
using MySqlConnector;
using System.Collections.Generic;
namespace moe.Models
{
    public class UsuarioRepository
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
            //implimir uma mensagem indicando o funcionamento
            Console.WriteLine("Banco de dados Funcionando!");
            //fechar conexão
            Conexao.Close();
        }

        public Usuario ValidarLogin(Usuario user){
           //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para buscar por Login e Senha (select)
            String QuerySql = "select * from Usuario WHERE Login=@Login and Senha=@Senha";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);
            //executar o comando e retornar um único usuário quando encontrado
            MySqlDataReader Reader = Comando.ExecuteReader();
            // inicializa o objeto UsuarioEncontrado com null caso o comando Reader não encontre nenhum registro
            Usuario UsuarioEncontrado = null;
            // aqui o objeto Reader será validado
            if(Reader.Read()){
                //se for encontrado o login e senha do usuário, a validação ocorrerá por este script
                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.IdUsuario=Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome=Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login=Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))   
                    UsuarioEncontrado.Senha=Reader.GetString("Senha");
                UsuarioEncontrado.DataNascimento=Reader.GetDateTime("DataNascimento");
            }

            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno o UsuarioEncontrado
            return UsuarioEncontrado;
 
        }

        public Usuario BuscarPorId(int IdUsuario){
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para buscar por Id (select)
            String QuerySql = "select * from Usuario WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario",IdUsuario);
            //executar o comando e retornar um único usuário quando encontrado
            MySqlDataReader Reader = Comando.ExecuteReader();
            Usuario UsuarioEncontrado = new Usuario();
            if(Reader.Read()){
                UsuarioEncontrado.IdUsuario=Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome=Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login=Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))   
                    UsuarioEncontrado.Senha=Reader.GetString("Senha");
                UsuarioEncontrado.DataNascimento=Reader.GetDateTime("DataNascimento");
            }

            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno o UsuarioEncontrado
            return UsuarioEncontrado;

        }
        //CRUD - Inserir(insert), Listar(select), Alterar(update), Excluir(delete)

        // Inserir(insert)
        public void Inserir(Usuario user){
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para alterar (update)
            String QuerySql = "insert into Usuario (Nome,Login,Senha,DataNascimento) values (@Nome,@Login,@Senha,@DataNascimento)";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao); 
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@Nome",user.Nome);
            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento",user.DataNascimento);
            Comando.Parameters.AddWithValue("@IdUsuario",user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }
        // Listar(select)
        public List<Usuario> Listar(){
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para listar (select)
            String QuerySql = "select * from Usuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);
            //executar o comando e retornar uma lista de dados no banco de dados
            MySqlDataReader Reader = Comando.ExecuteReader(); 
            //criação da lista de usuários
            List<Usuario> Lista = new List<Usuario>();
            //percorre todos os registros retornados no banco de dados(objeto.Reader)
            while(Reader.Read()){
                Usuario userEncontrado = new Usuario();
                //armazenamento de informações no objeto userEncontrado
                userEncontrado.IdUsuario=Reader.GetInt32("IdUsuario");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome=Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login=Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))   
                    userEncontrado.Senha=Reader.GetString("Senha");
                userEncontrado.DataNascimento=Reader.GetDateTime("DataNascimento");
                //adicionando na lista de usuarios
                Lista.Add(userEncontrado);
            }
            //fechar a conexão com banco de dados
            Conexao.Close();
            //retorno da lista com todos os registros armazenados no banco de dados
            return Lista;

        }
        // Alterar(update)
        public void Alterar(Usuario user){
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para alterar (update)
            String QuerySql = "update Usuario set Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao); 
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@Nome",user.Nome);
            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento",user.DataNascimento);
            Comando.Parameters.AddWithValue("@IdUsuario",user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }
        // Excluir(delete)
        public void Excluir(Usuario user){
            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //query em sql para excluir (delete)
            String QuerySql = "delete from Usuario WHERE IdUsuario=@IdUsuario";
            //preparar um comando, passando: sql + conexão com banco de dados
            MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao); 
            //tratamento devido ao sql injection
            Comando.Parameters.AddWithValue("@IdUsuario",user.IdUsuario);
            //executar o comando no banco de dados
            Comando.ExecuteNonQuery();
            //fechar a conexão com banco de dados
            Conexao.Close();
        }
    }
}