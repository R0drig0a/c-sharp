using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses
{
    internal class Jogo
    {
        public int AnoLancamento { get; set; }
        public string Categoria { get; set; }
        public double? Custo { get; set; }
        public string Nome { get; set; }
        public List<string> Plataformas { get; set; }
        public string Desenvolvedor { get; set; }
    }
}
