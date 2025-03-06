using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exercicio5
    {
        int[] numeros = new int[2];
        
        public void Executar()
        {
            CadastrarNumeros();
            ApresentarNumeros();
            somarNumeros();
            SubtrairNumeros();
            MultiplicarNumeros();
            DividirNumeros();
           
        }

        private void CadastrarNumeros()
        {
            for (int i = 0; i < numeros.Length; i += 1)
            {
                Console.Write("Digite os numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

               
            }
        }

        private void ApresentarNumeros()
        {
            Console.WriteLine("Numero digitados: ");
            for(int i = 0; i < numeros.Length; i += 1)
            {
                
                Console.WriteLine(numeros[i]);
            }
        }

        private void somarNumeros()
        {
            Console.WriteLine("--- Adição ---");

            int  soma = 0;
            for(int i = 0; i < numeros.Length; i += 1)
            {
                int somar = numeros[i];
                soma = soma + somar;
            }
            Console.WriteLine("O total da soma é: " + soma);
        }

        private void SubtrairNumeros()
        {
            Console.WriteLine("--- Subtração ---");

            int subtrair = 0;
            for(int i = 0; i < numeros.Length; i += 1)
            {
                int operacao = numeros[i];
                subtrair = operacao - subtrair;
            }
            Console.WriteLine("O total da subtração é: " + subtrair);
        }

        private void MultiplicarNumeros()
        {
            //Aqui pedi ajuda do chatGPT o por que que não estava conseguindo fazer essa conta
            //Antes
            //    int multiplicar = 0;
            //    for(int i =0; i < numeros.Length; i += 1)
            //    {
            //        int multiplicacao = numeros[i];
            //        multiplicar = multiplicar * multiplicacao;
            //    }
            //    Console.WriteLine("O total da subtração é: " + multiplicar);

            
            int multiplicar = 1;
            for(int i = 0; i < numeros.Length; i += 1)
            {
                int multiplicacao = numeros[i];
                multiplicar *= numeros[i];
            }
            Console.WriteLine("O total da multiplicação é: " + multiplicar);
        }

        private void DividirNumeros()
        {
            int dividir = 1;
            for (int i = 0; i < numeros.Length; i += 1)
            {
                int divisao = numeros[i];
                dividir /= numeros[i];
            }
        }

    }
}
//TODO: Conversar e pedir pra ele explicar com funciona esse tipo de calculo += -= *= /= chat gpt me ajudou nisso