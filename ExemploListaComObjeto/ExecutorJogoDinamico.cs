using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaComObjeto
{
    internal class ExecutorJogoDinamico
    {
        private List<Jogo> jogos = new List<Jogo>();
        public void Executar()
        {
            Cadastrar();
            Listar();
            Cadastrar();
            Listar();
        }
        private void Listar()
        {
            for(int i = 0; i < jogos.Count; i += 1)
            {
                Jogo jogo = jogos[i];
                Console.WriteLine(jogo.Nome + " => " + jogo.Preco);
            }
        }
        private void Cadastrar()
        {
            Jogo jogo = new Jogo();
            Console.Write("Diigte o nome do jogo:");
            jogo.Nome = Console.ReadLine();

            Console.Write("Diigte o preço do jogo:");
            jogo.Preco = Convert.ToDouble(Console.ReadLine());

            jogos.Add(jogo);
        }
    }
}
