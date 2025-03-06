using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses
{
    internal class Produto
    {
        //Nome, descriçaõ tem que ser Nullable, quantidade, preço
        public string Nome { get; set; }
        public string? Descricao {get;set;}
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}
