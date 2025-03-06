using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exemplo02
    {
        int[] numeros = new int[4];

        public void Executar()
        {
            Cadastrar();
            ApresentarNumeros();
            ApresentarSoma();
            ApresentarMedia();
            ApresentarMenorNumero();
            ApresentarMaiorNumero();
        }

        private void Cadastrar()
        {
            for (int i = 0; i < numeros.Length; i += 1)
            {
                Console.Write("Digite o número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private void ApresentarSoma()
        {
            //int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            int soma = 0;
            for (int i = 0; i < numeros.Length; i += 1)
            {
                int numero = numeros[i];
                soma = soma + numero;
                //soma += numero;
            }

            Console.WriteLine("Soma: " + soma);
        }

        private void ApresentarNumeros()
        {
            Console.Clear();
            Console.WriteLine("Números digitados: ");
            for (int i = 0; i < numeros.Length; i += 1)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        private void ApresentarMedia()
        {
            double soma = 0;
            for (int i = 0; i < numeros.Length; i += 1)
            {
                soma = soma + numeros[i];
            }
            double media = soma / numeros.Length;
            Console.WriteLine("Média: " + media);
        }

        private void ApresentarMenorNumero()
        {
            int menorNumero = 9999999;
            for (int i = 0; i < numeros.Length; i += 1)
            {
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }
            Console.WriteLine("Menor número: " + menorNumero);
        }

        private void ApresentarMaiorNumero()
        {
            int maiorNumero = 0;
            for (int i = 0; i < numeros.Length; i += 1)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }
            Console.WriteLine("Maior número: " + maiorNumero);
        }
    }
}



