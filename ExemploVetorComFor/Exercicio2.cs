using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exercicio2
    {
        int[] numeros = new int[5];
        public void Executar()
        {
            Cadastrar();
            Apresentar();
        }
        private void Cadastrar()
        {
            for (int i = 0; i < numeros.Length; i += 1)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        private void Apresentar()
        {
            Console.Clear();
            Console.WriteLine("numero digitados: ");
            for (int i = 0; i < numeros.Length; i += 1)
            {
                Console.WriteLine(numeros[i]);               
            }
        }
    }
}
