using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exercicio4
    {
        int[] idades = new int[128];
       public void  Executar()
        {
            Cadastrar();
            Apresentar();
        }

        private void Cadastrar()
        {
            for(int i = 0; i < idades.Length; i += 1)
            {
                Console.Write("Digite sua idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
                if (idades[i] > idades.Length)
                {
                    Console.WriteLine("Idade superou o maximo que é 128 anos");
                    break;
                }
                Console.Clear();
            }
        }
        private void Apresentar()
        {
            Console.WriteLine("Idade Cadastradas: ");
            for(int i = 0; i < idades.Length; i += 1)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
