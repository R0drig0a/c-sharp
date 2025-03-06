using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaComObjeto
{
    internal class ExecutorJogoMenu
    {
        
        private List<Jogo> jogos = new List<Jogo>();
        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 - Cadastrar
                    2 - Listar
                    10 - Sair
                    """);
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1: Cadastrar();break;
                    case 2: Listar(); ;break;
                    case 10:  break;
                    default: Console.WriteLine("Opçao ivalida");break;
                }

            } while (menu != 10);
          
            
            
        }
        private void Listar()
        {
            for (int i = 0; i < jogos.Count; i += 1)
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
        private void Apagar()
        {
            Console.Write("Digite o nome do jogo para apagar: ");
            string nomeApagar = Console.ReadLine();
            for (int i = 0; i < jogos.Count; i += 1)
            {
                Jogo jogo = jogos[i];
                if (jogo.Nome == nomeApagar)
                {
                    Console.WriteLine("Jogo apagado com Sucesso!");
                    jogos.RemoveAt(i);
                    return;
                }

            }
            Console.WriteLine("Jogo não encotrado!");
        }
        private void Editar()
        {
            Console.Write("Digite o nome do jogo para editar: ");
            string nomeEditar = Console.ReadLine();
            for (int i = 0; i < jogos.Count; i += 1)
            {
                Jogo jogo = jogos[i];
                if (jogo.Nome == nomeEditar)
                {
                    Console.Write("Digite o nome do jogo: ");
                    jogo.Nome = Console.ReadLine();

                    Console.Write("Digite o preço do jogo: ");
                    jogo.Preco = Convert.ToDouble(Console.ReadLine());
                    return;
                }

            }
            Console.WriteLine("Jogo não encotrado!");
        }

    }
}