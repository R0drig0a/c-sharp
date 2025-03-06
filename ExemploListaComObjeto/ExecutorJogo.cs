using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaComObjeto
{
    internal class ExecutorJogo
    {
        List<Jogo> jogos = new List<Jogo>();

        public void Executar()
        {
            CadastrarJogo();
            ApresentarJogo();
        }
        private void ApresentarJogo()
        {
            Jogo jogo1 = jogos[0];
            Console.WriteLine(jogo1.Nome + " =>" + jogo1.Preco);
                  Jogo jogo2 = jogos[1];
            Console.WriteLine(jogo2.Nome + " =>" + jogo2.Preco);

        }
        private void CadastrarJogo()
        {
            Jogo jogo1 = new Jogo();
            jogo1.Nome = "Fortnite";
            jogo1.Preco = 0;
            jogos.Add(jogo1);

            Jogo jogo2 = new Jogo();
            jogo2.Nome = "Gta V";
            jogo2.Preco = 150;
            jogos.Add(jogo2);
        }
    }
}
