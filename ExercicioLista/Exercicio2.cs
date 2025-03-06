using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Exercicio2
    {
        List<double> precos = new List<double>();
        
        // * Criar uma lista de preços
        //- Adicionar 7 preços nessa lista
        //- Listar todos os preços
        //- Apresentar a soma dos valores
        //- Apresentar o menor preço
        //- Apresentar o maior preço
        

        public void Executar()
        {
            AdicionarPreco();
            ListaDePrecos();
            ApresentarSoma();
            ApresentarMenorPreco();
            ApresentarMaiorPreco();
        }

        private void AdicionarPreco()
        {
            precos.Add(7.89);
            precos.Add(11.50);
            precos.Add(2.99);
            precos.Add(335.89);
            precos.Add(850.99);
            precos.Add(10.00);
            precos.Add(500.00);
        }
        private void ListaDePrecos()
        {
           
            Console.WriteLine("Preços cadastrados: ");
            for (int i = 0; i < precos.Count; i += 1)
            {
                Console.WriteLine(precos[i]);
               
            }
            Console.WriteLine("\n----------------------------------------------------------");

        }
        private void ApresentarSoma()
        {
            double soma = 0;
            for(int i = 0; i < precos.Count; i += 1)
            {
                soma += precos[i];
            }
            Console.WriteLine("A soma dos preços acima foi de: " + soma);
            Console.WriteLine("\n----------------------------------------------------------");

        }
        private void ApresentarMenorPreco()
        {
            double menorPreco = 9999999999;
            for(int i = 0; i < precos.Count; i += 1)
            {
                if (precos[i] < menorPreco)
                {
                    menorPreco = precos[i];
                }
               
            }
            Console.WriteLine("O menor preço cadastrado é: " + menorPreco);
            Console.WriteLine("\n----------------------------------------------------------");

        }
        private void ApresentarMaiorPreco()
        {
            double maiorNumero = 0;
            for(int i = 0; i < precos.Count; i += 1)
            {
                if(precos[i] > maiorNumero)
                {
                    maiorNumero = precos[i];
                }
            }
            Console.WriteLine("O maior numero cadastrado é: " + maiorNumero);
            Console.WriteLine("\n----------------------------------------------------------");

        }
    }
}
