using System.Collections.Generic;
namespace moe.Models
{
    public class InfoContatos
    {
        public static List<Contato> contato = new List<Contato>();

        public static void Incluir(Contato item){
            contato.Add(item);
        }

        public static List<Contato> Listar(){
            return contato;
        }
    }
}