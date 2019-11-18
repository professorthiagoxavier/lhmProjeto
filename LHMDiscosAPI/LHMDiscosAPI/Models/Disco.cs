using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LHMDiscosAPI.Models
{
    public class Disco
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public string Cantor { get; set; }

        public string Genero { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEstoque { get; set; }
    }
}