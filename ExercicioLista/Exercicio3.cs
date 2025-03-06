using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    /*
      *  Criar uma lista para armazenar o nome dos automóveis e seus preços da fipe 
            Criar um menu com os seguintes itens:
            1 - Cadastrar automóvel
            2 - Editar automóvel
            3 - Apagar automóvel
            4 - Listar todos os automóveis
            5 - Apresentar o nome e preço da fipe do automóvel mais caro
            6 - Apresentar o nome e preço da fipe do automóvel mais barato
            7 - Permitir o usuário buscar um automóvel pelo nome e apresentar o seu preço (n temos exemplo)
            8 - Apresentar a média dos preços dos carros
            9 - Sair
      */
    internal class Exercicio3
    {
        List<string> automoveis = new List<string>();
        List<double> precosAutomoveis = new List<double>();
        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 - Cadastrar automoveis
                    2 - Editar automoveis
                    3 - Apagar automoveis
                    4 - Listar todos os automoveis
                    5 - Apresentar o nome e preço da fipe mais caro
                    6- Apresentar o nome e o preço da fipe mais barato
                    7 - Buscar o automovel pelo nome
                    8 - Apresentar media dos carros
                    9 - Sair
                    """);
                Console.Write("Digite o que deseja do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1: CadastrarAutomoveis(); break;
                    case 2: EditarAutomoveis(); break;
                    case 3: RemoverCarro(); break;
                    case 4: ListaCarros(); break;
                    case 5: CarroMaisCaro(); break;
                    case 6: CarroMaisBarato(); break;
                    case 7: BuscarCarro(); break;
                    case 8: ValorMedioCarro(); break;
                    case 9: break;
                    default: Console.WriteLine("Numero invalido!"); break;
                }

            } while (menu != 9);

        }
        private void CadastrarAutomoveis()
        {
            Console.Write("Digite o carro que deseja cadastrar:");
            string automovel = Console.ReadLine();
            automoveis.Add(automovel);

            Console.Write("Digite a tabela fipe do carro: ");
            double fipe = Convert.ToDouble(Console.ReadLine());
            precosAutomoveis.Add(fipe);
            Console.Clear();
        }

        private void EditarAutomoveis()
        {
            Console.Write("Digite o nome do carro que deseja altera: ");
            string carroAlterar = Console.ReadLine();

            for (int i = 0; i < automoveis.Count; i += 1)
            {
                string carroPercorrido = automoveis[i];

                if (carroPercorrido == carroAlterar)
                {
                    Console.Write("Digite o novo nome do carro: ");
                    string carroNovo = Console.ReadLine();
                    automoveis[i] = carroNovo;

                    Console.Write("Digite a fipe do carro: ");
                    double fipeNova = Convert.ToDouble(Console.ReadLine());
                    precosAutomoveis[i] = fipeNova;
                    Console.WriteLine("Carro alterado com Sucesso!");
                    return;

                }
            }
            Console.WriteLine("Carro não encotrado!!");
        }

        private void ListaCarros()
        {
            if (automoveis.Count == 0)
            {
                Console.WriteLine("Lista está vazia!");
                return;
            }
            Console.WriteLine("Lista de carros:");
            for (int i = 0; i < automoveis.Count; i += 1)
            {
                Console.WriteLine(automoveis[i] + " " + " -> " + " R$ " + precosAutomoveis[i]);

            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

        private void RemoverCarro()
        {
            ListaCarros();
            Console.WriteLine("Qual carro deseja Remover:");
            string carroRemovido = Console.ReadLine();

            for (int i = 0; i < automoveis.Count; i += 1)
            {
                string carroPercorrido = automoveis[i];
                if (carroPercorrido == carroRemovido)
                {
                    automoveis.Remove(carroRemovido);
                    Console.WriteLine("Carro removido com Sucesso!");
                    return;
                }
            }
            Console.WriteLine("Carro não encontrado!");
        }
        private void CarroMaisCaro()
        {
            string carroMaisCaro = "";
            double fipeMaisCara = 0;
            for (int i = 0; i < automoveis.Count; i += 1)
            {
                if (precosAutomoveis[i] > fipeMaisCara)
                {
                    fipeMaisCara = precosAutomoveis[i];
                    carroMaisCaro = automoveis[i];

                }

            }
            Console.WriteLine("O carro com a fipe mais alta é: " + carroMaisCaro + " Com: R$" + fipeMaisCara);
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }
        private void CarroMaisBarato()
        {
            string carroMaisBarato = "";
            double fipeMaisBarata = 9999999999;
            for (int i = 0; i < automoveis.Count; i += 1)
            {
                if (precosAutomoveis[i] < fipeMaisBarata)
                {
                    fipeMaisBarata = precosAutomoveis[i];
                    carroMaisBarato = automoveis[i];

                }

            }
            Console.WriteLine("O carro com a fipe mais barata é:" + carroMaisBarato + " Com: R$" + fipeMaisBarata);
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

        private void BuscarCarro()
        {
            Console.WriteLine("Digite o nome do carro que deseja ver na tela?");
            string nomeBuscado = Console.ReadLine();

            for (int i = 0; i < automoveis.Count; i += 1)
            {
                if (nomeBuscado == automoveis[i])
                {
                    Console.WriteLine("Carro buscado: " + nomeBuscado);
                    Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }

            Console.WriteLine("Carro não encontrado!");
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

        private void ValorMedioCarro()
        {
            double somaCarros = 0;
            for (int i = 0; i < automoveis.Count; i += 1)
            {
                somaCarros += precosAutomoveis[i];

            }
            double mediaCarro = somaCarros / precosAutomoveis.Count;
            Console.WriteLine("O valor medio dos carros são: " + mediaCarro);
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
