using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    class Exercicio1
    {
        int[] idades = new int[5];
       public void  Executar()
        {
            Cadastrar();
            Apresentar();
        }
        private void Cadastrar()
        {
            for (int i = 0; i <idades.Length; i += 1)
            {
                Console.WriteLine("Digite sua idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        private void Apresentar()
        {
            Console.WriteLine("Idades cadastradas: ");
            for(int i = 0; i < idades.Length; i += 1)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
