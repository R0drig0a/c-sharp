using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExercicioLista
{
    /*
     * Criar uma lista para armazenar o nome das marcas, siga as seguintes etapas:
- Adicionar as marcas Coca-Cola, Pepsi, Apple, Sansung, Tesla e Volksvagem 
- Listar todas as marcas
- Remover o paciente com nome Pesi
- Listar todas as marcas
- Alterar o nome da 'Sansung' para 'Samsung'
- Alterar o nome da 'Volksvagem' para 'Volkswagem'
- Remover a marca do indice 0
- Listar todas as marcas
     */
    internal class Exercicio1
    {
        List<string> marcas = new List<string>();
        
        public void Executar()
        {
            AdicionarMarcas();
            ListaMarcas("Marcas Cadastradas: ");
            RemoverPepsi();
            ListaMarcas("Lista Atualizadas Apos removido pepsi: ");
            CorrigirNomes();
            ListaMarcas("Lista Atualizadas Apos corrigido Volksvagen e Samsung: ");
            RemoverCocaCola();
            ListaMarcas("Lista Atualizadas Apos removido Coca-Cola: ");
        }

        private void AdicionarMarcas()
        {
            marcas.Add("Coca-Cola");
            marcas.Add("Pepsi");
            marcas.Add("Apple");
            marcas.Add("Sansung");
            marcas.Add("Tesla");
            marcas.Add("Volksvagem");
        }
        private void ApresentarMarcas()
        {
            Console.WriteLine("Marcas Cadastradas: ");
            Console.WriteLine(marcas[0]);
            Console.WriteLine(marcas[1]);
            Console.WriteLine(marcas[2]);
            Console.WriteLine(marcas[3]);
            Console.WriteLine(marcas[4]);
            Console.WriteLine(marcas[5]); //Todo: Aqui nesse caso por que quando ele passa na segunda vez a lista automaticamente não retira o indice e  aparece ate o indice 4?
        }
        private void RemoverPepsi()
        {
            marcas.RemoveAt(index: 1);

            Console.WriteLine("\n------------------");
            Console.WriteLine("Pepsi removido com sucesso!");

        }
        private void ListaMarcas(string mensagem)
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine(mensagem);
            for (int i = 0; i < marcas.Count; i += 1)
            {
                Console.WriteLine(marcas[i]);
            }

        }
        private void CorrigirNomes()
        {
            //Todo: Tem como alterar o nome, puxando pelo nome? tipo marcas.nome[sansung] e alterar como
            //se eu nao soubesse o indice dele?

            marcas[2] = "Samsung";
            marcas[4] = "Volkswagen";
            Console.WriteLine("\n------------------");
            Console.WriteLine("Nomes alterados com Sucesso!");
          
                    
        }
        // Todo: Nesse caso eu não posso Utilizar o mesmo Metodo? Que nem eu queria utiliazar o metodo de remover novamente sem precisar criar novamente,
        // aqui estou criando  um metodo pra fazer a mesma coisa que o metodo de remover acima.
        private void RemoverCocaCola()
        {
            marcas.RemoveAt(index: 0);

            Console.WriteLine("\n------------------");
            Console.WriteLine("Coca-Cola removido com sucesso!");
            
        }

       

       
    }

}
