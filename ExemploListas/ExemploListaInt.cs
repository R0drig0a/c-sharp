using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListas
{
    internal class ExemploListaInt
    {
        // Criar lista de números que será utilizada nos métodos abaixo
        private List<int> numeros = new List<int>();

        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                              1 - Adicionar
                              2 - Atualizar
                              3 - Remover
                              4 - Listar todos
                              5 - Menor Valor
                              6 - Somar Números
                              7 - Sair
                              """);
                Console.Write("Escolha o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // if(menu == 1)
                //     Adicionar();
                // else if (menu == 2)
                //     Atualizar();
                // else if (menu == 3)
                //     Remover();
                // else if (menu == 4)
                //     ListarTodos();
                // else if (menu == 5)
                //     ApresentarMenorValor();
                // else if (menu == 6)
                //     ApresentarSoma();

                switch (menu)
                {
                    case 1: Adicionar(); break;
                    case 2: Atualizar(); break;
                    case 3: Remover(); break;
                    case 4: ListarTodos(); break;
                    case 5: ApresentarMenorValor(); break;
                    case 6: ApresentarSoma(); break;
                    case 7: break;
                    default: Console.WriteLine("Opção inválida"); break;
                }

            } while (menu != 7);
        }

        private void Adicionar()
        {
            bool desejaAdicionar = true;
            // do while: Tem a mesma função do while, que seria repetir, porém no do while
            // é executado no mínimo 1 vez o código de dentro das chaves e no máximo n(de acordo com a condição)
            do
            {
                // Solicitando o número
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                // Adicionar o número na lista de números
                numeros.Add(numero);

                // Perguntar se deseja continuar
                Console.Write("Deseja adicionar? [S/N] ");
                // Ler uma tecla
                ConsoleKeyInfo opcao = Console.ReadKey();
                Console.Clear();
                // Transformar essa tecla em maíscula
                if (char.ToUpper(opcao.KeyChar) != 'S')
                    desejaAdicionar = false;
            } while (desejaAdicionar == true);
        }

        private void Atualizar()
        {
            // Chamar o listar todos, para apresnetar para o usuário todas as opções disponíveis
            ListarTodos();
            Console.Write("Digite o número que deseja alterar: ");
            int numeroAlterar = Convert.ToInt32(Console.ReadLine());

            // Percorrer toda a lista de números buscando o número que o usuário deseja alterar
            for (int i = 0; i < numeros.Count; i++)
            {
                // Obter da lista o número que está sendo percorrido
                int numeroPercorrido = numeros[i];
                // Verificar se o número percorrido é o mesmo que o usuário informou para alterar
                if (numeroPercorrido == numeroAlterar)
                {
                    // Perguntar o valor do número que será armazenado na posição daquele número que o usuário escolheu
                    Console.Write("Digite o novo valor do número: ");
                    int novoValor = Convert.ToInt32(Console.ReadLine());
                    // Atualizar a lista na posição do número que o usuário escolheu com o novo valor
                    numeros[i] = novoValor;
                    Console.WriteLine("Número alterado com sucesso");
                    // Encerrar a execução desse método
                    return;
                }
            }
            // Se cair nessa linha, quer dizer que o número que o usuário escolheu para alterar não existe na
            // lista de números
            Console.WriteLine("Número não encontrado");
        }

        private void Remover()
        {
            // Chamar o listar todos, para apresnetar para o usuário todas as opções disponíveis
            ListarTodos();
            Console.Write("Digite o número que deseja apagar: ");
            int numeroApagar = Convert.ToInt32(Console.ReadLine());

            // Percorrer toda a lista de números buscando o número que o usuário deseja apagar
            for (int i = 0; i < numeros.Count; i++)
            {
                // Obter da lista o número que está sendo percorrido
                int numeroPercorrido = numeros[i];
                // Verificar se o número percorrido é o mesmo que o usuário informou para apagar
                if (numeroPercorrido == numeroApagar)
                {
                    // Remover o número da lista
                    numeros.Remove(numeroApagar);
                    Console.WriteLine("Número removido com sucesso");
                    return;
                }
            }
            // Se cair nessa linha, quer dizer que o número que o usuário escolheu para apagar não existe na
            // lista de números
            Console.WriteLine("Número não encontrado");
        }

        private void ListarTodos()
        {
            // Verificar se a lista está vazia
            if (numeros.Count == 0)
            {
                // Apresentar feedback que a lista está vazia
                Console.WriteLine("Nenhum número cadastrado");
                return;
            }

            // Percorrer a lista apresentando cada um dos itens da lista
            Console.WriteLine("Lista de números:");
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        private void ApresentarMenorValor()
        {
            if (numeros.Count == 0)
            {
                Console.WriteLine("Nenhum número cadastrado");
                return;
            }

            int menorNumero = 99999999;
            for (int i = 0; i < numeros.Count; i += 1)
            {
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }

            Console.WriteLine($"Menor número: {menorNumero}");
        }

        private void ApresentarSoma()
        {
            if (numeros.Count == 0)
            {
                Console.WriteLine("Nenhum número cadastrado");
                return;
            }

            int soma = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                soma += numeros[i];
            }

            // Console.WriteLine("Soma: " + soma);
            Console.WriteLine($"Soma: {soma}");
        }
    }
}
