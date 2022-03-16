using System; 
namespace moe.Models
{
    public class Usuario
    {
        public int IdUsuario {get; set;}
        public string Nome {get; set;}
        public string Login {get; set;}
        public string Senha {get; set;}
        public DateTime DataNascimento {get; set;}
    }
}