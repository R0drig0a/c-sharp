using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
    internal class Exemplo03
    {
        string[] produtos = new string[100];
        int[] quantidades = new int[100];
        double[] precos = new double[100];
        int quantidadeCadastrado = 0;

        public void Executar()
        {
            Menu();
        }

        private void Menu()
        {
            int opcao = 0;
            while (opcao != 8001)
            {
                Console.WriteLine("""
            1 -     Adicionar pedido
            2 -     Apresentar pedidos
            3 -     Apresentar total
            8001 -  Sair
            """);
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (opcao == 1)
                    AdicionarItem();
                else if (opcao == 2)
                    ApresentarPedidos();
                else if (opcao == 3)
                    ApresentarTotal();
                else if (opcao != 8001)
                    Console.WriteLine("Opção inválida!");
            }

        }

        private void AdicionarItem()
        {
            Console.WriteLine("Cadastrar Pedido:");
            Console.Write("Digite o nome do produto: ");
            produtos[quantidadeCadastrado] = Console.ReadLine();

            Console.Write("Digite a quantidade do produto: ");
            quantidades[quantidadeCadastrado] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a preço do produto: ");
            precos[quantidadeCadastrado] = Convert.ToDouble(Console.ReadLine());

            quantidadeCadastrado += 1;
        }

        private void ApresentarPedidos()
        {

            Console.WriteLine("Pedidos:");
            for (int i = 0; i < quantidadeCadastrado; i += 1)
            {
                Console.WriteLine("Nome: " + produtos[i] + " Qtd: " + quantidades[i] + " Preço: " + precos[i]);
            }
        }

        private void ApresentarTotal()
        {
            double total = 0;
            for (int i = 0; i < quantidadeCadastrado; i += 1)
            {
                double totalPedido = quantidades[i] * precos[i];
                total = total + totalPedido;
            }

            Console.WriteLine("O total dos pedidos é: " + total);
        }
    }
    }
