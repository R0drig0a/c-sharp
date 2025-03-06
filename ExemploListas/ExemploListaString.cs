using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListas
{
    internal class ExemploListaString
    {
        public void Executar()
        {
            // Criando uma lista vazia de strings
            List<string> nomes = new List<string>();

            //Adicionar um elemento na lista
            nomes.Add("Rodrigo");

            //Adicionar um elemento na lista
            nomes.Add("João");

            //Alterar nome João, que é o elemento da segunda posição, ou seja posição 1
            nomes[1] = "Marcos";

            //Adicionar Julio e Julia na lista de nomes 
            nomes.Add("Julio");
            nomes.Add("Julia");

            //Remover o julio que esta na posição 2, fazendo a julia assumir a posição 2
            nomes.Remove("Julio");
            //Remover a julia que esta na posição 2
            nomes.RemoveAt(index: 2);

            //Obter a qauntidade de item da lista
            int quatidadeNomes = nomes.Count;

            Console.WriteLine("Quantidade de nomes: " + quatidadeNomes);
            Console.WriteLine("Nome da Lista: ");
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
        }
    }
}
