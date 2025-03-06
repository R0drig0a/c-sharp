using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses
{
    internal class ExecutorJogo
    {
        Jogo jogo = new Jogo();

        public void Executar()
        {
            CadastrarJogo();
            ApresentarJogo();
        }
        private void CadastrarJogo()
        {
            Console.Write("Digite o nome do jogo: ");
            jogo.Nome = Console.ReadLine();

            Console.Write("Digite o ano de Lançamento:");
            jogo.AnoLancamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você deseja preencher o custo do jogo? [S/N] ");
            string possuiCusto = Console.ReadLine();
            if (possuiCusto.Trim().ToUpper() == "S")
            {
                Console.Write("Digite o custo do jogo:");
                jogo.Custo = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Digite a categoria do jogo: ");
            jogo.Categoria = Console.ReadLine();

            Console.Write("Digite o nome dos desenvolvedores: ");
            jogo.Desenvolvedor = Console.ReadLine();

            jogo.Plataformas = new List<string>();
            string desejaCadastrarPlataforma;
            do
            {
                Console.Write("Digite a plataforma do jogo : ");
                string plataforma = Console.ReadLine();

                jogo.Plataformas.Add(plataforma);

                Console.WriteLine("Você deseja Cadastrar outras plataforma? ");
                desejaCadastrarPlataforma = Console.ReadLine();

            } while (desejaCadastrarPlataforma.ToUpper() == "S");
        }
        private void ApresentarJogo()
        {
            Console.WriteLine("---------- Descrição do Jogo ----------");
            Console.WriteLine(jogo.Nome);
            Console.WriteLine(jogo.AnoLancamento);
            Console.WriteLine(jogo.Categoria);
            Console.WriteLine(jogo.Desenvolvedor);
            for(int i = 0; i < jogo.Plataformas.Count; i += 1)
            {
                Console.WriteLine(jogo.Plataformas[i]);
            }
          
            Console.WriteLine(jogo.Custo);
        }
    }
}
