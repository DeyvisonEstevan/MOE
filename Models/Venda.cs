using System;
namespace moe.Models
{
    public class Venda
    {
        public int IdVenda {get; set;}
        public int IdUsuario {get; set;}
        public int IdProduto {get; set;}
        public string NomeProduto {get; set;}
        public int QuantidadeVendida {get; set;}
        public int ValorProduto {get; set;}
        public int ValorTotalProduto {get; set;}
    }
}