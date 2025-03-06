using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exercicio3
    {
        string[] roupas = new string[2];
        double[] preco = new double[2];
        public void Executar()
        {
            Cadastrar();
            Apresentar();
        }
        private void Cadastrar()
        {
            for(int i = 0; i < roupas.Length; i += 1)
            {
                Console.Write("Digite o nome das peças: ");
                roupas[i] = Console.ReadLine();

                Console.Write("Digite o preço das roupas: ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
        }
        private void Apresentar()
        {
            
            Console.WriteLine("Produtos cadastrados: ");
            for (int i = 0; i < roupas.Length; i += 1)
            {
                Console.WriteLine(roupas[i] + "  ->  "+ " R$" + preco[i]);
            }

        }
    }
}
