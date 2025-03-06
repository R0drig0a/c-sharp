using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exemplo01
    {
        string[] nomes = new string[3];

        public void Executar()
        {
            Cadastrar();
            Apresentar();
        }
        
        private void Cadastrar()
        {
            //0..2
            for(int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("Digite seu nome:");
                nomes[i] = Console.ReadLine();
            }
         
        }
        private void Apresentar()
        {
            Console.Clear();
            Console.WriteLine("Nomes: ");
            for(int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
