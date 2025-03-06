using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses
{
    internal class Carro
    {
        public string Modelo { get; set;}
        public int Ano { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        //Interrogação quer dizer que é Nullable, quer dizer que pode ser ou não preenchido
        public DateTime? DataCompra { get; set; }


    }
}
