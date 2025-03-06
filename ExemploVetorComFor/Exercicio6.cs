using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComFor
{
   
    internal class Exercicio6
    {
        
        string[] nomes = new string[2];
        int[] idades = new int[2];
        double[] pesos = new double[2];
        string[] sexos = new string[2];
        double[] alturas = new double[2];
        int[] golsmarcados = new int[2];
        int[] quantidadesCartoesAmareloTomados = new int[2];
        int[] quantidadesCartoesVermelhoTomados = new int[2];

        double menorPeso = 999999;
        double maiorAltura = 0;
        double maiorPeso = 0;

        int menorQuantidadeDeCartaoVermelhoRecebido = 9999999;
        int menorQuantidadeDeCartoesAmarelosRecebidos = 9999999;
        int quantidadeDeSexoMasculino = 0;
        int quantidadeDeSexoFeminino = 0;
        int maiorQuantidadeDeCartaoVermelhoRecebido = 0;
        int maiorQuantidadeDeCartaoAmareloRecebido = 0;

        string nomeMenorPeso = "";
        string nomeMaiorAltura = "";
        string maiorNome = "";
        string nomeMaior = "";
        string nomeMenorQuantidadeDeCartoesAmarelosRecebidos = "";
        string nomeMaiorPeso = "";
        string nomeMaiorQuantidadeDeCartaoVermelhoRecebido = "";
        string nomeMaiorQuantidadeDeCartaoAmareloRecebido = "";
        string nomeMenorQuantidadeDeCartaoVermelhoRecebido = "";
        public void Executar()
        {
            Cadastrar();
            ApresentarJogadores();
            Estatisticas();
        }
        private void Cadastrar()
        {
            for(int i = 0; i < nomes.Length; i += 1)
            {
                Console.Write("Digite seu nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Digite sua idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite seu peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite seu sexo: ");
                sexos[i] = Console.ReadLine();

                Console.Write("Digite sua altura: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de Cartões amarelos tomados: ");
                quantidadesCartoesAmareloTomados[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de Cartões vermelhos tomados: ");
                quantidadesCartoesVermelhoTomados[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }

        private void ApresentarJogadores()
        {
            Console.WriteLine("Jogadores Cadastrados: ");
            for(int i = 0; i < nomes.Length; i += 1)
            {
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("idade: " + idades[i]);
                Console.WriteLine("peso: " + pesos[i]);
                Console.WriteLine("sexo: " + sexos[i]);
                Console.WriteLine("altura: " + alturas[i]);
                Console.WriteLine("quantidade de Cartões amarelo tomados: " + quantidadesCartoesAmareloTomados[i]);
                Console.WriteLine("quantidade de Cartões vermelho tomados: " + quantidadesCartoesVermelhoTomados[i]);

                Console.WriteLine("---------------------------------");
            }
        }
        private void Estatisticas()
        {
            Console.WriteLine("Estatísticas dos jogadores: ");
            for (int i = 0; i < nomes.Length; i += 1)
            {
                if(pesos[i] < menorPeso)
                {
                    menorPeso = pesos[i];
                    nomeMenorPeso = nomes[i];
                }
                if (pesos[i] > maiorPeso)
                {
                    maiorPeso = pesos[i];
                    nomeMaiorPeso = nomes[i];
                }

                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                    nomeMaiorAltura = nomes[i];

                }
                //if (nomes[i].Length > maiorNome[i])
                //{
                //    maiorNome = nomes[i]; // TODO: Pedir pra ajudar e explicar como fazer esse do nome.
                //    nomeMaior = nomes[i];
                    
                //}

                if (sexos[i].ToUpper().StartsWith("M"))
                {
                    quantidadeDeSexoMasculino = quantidadeDeSexoMasculino + 1;
                }
                if (sexos[i].ToUpper().StartsWith("F"))
                {
                    quantidadeDeSexoFeminino = quantidadeDeSexoFeminino + 1;
                }

                if(quantidadesCartoesAmareloTomados[i] < menorQuantidadeDeCartoesAmarelosRecebidos)
                {
                    menorQuantidadeDeCartoesAmarelosRecebidos = quantidadesCartoesAmareloTomados[i];
                    nomeMenorQuantidadeDeCartoesAmarelosRecebidos = nomes[i];
                }
                if (quantidadesCartoesAmareloTomados[i] > maiorQuantidadeDeCartaoAmareloRecebido)
                {
                    maiorQuantidadeDeCartaoAmareloRecebido = quantidadesCartoesAmareloTomados[i];
                    nomeMaiorQuantidadeDeCartaoAmareloRecebido = nomes[i];
                }

                if (quantidadesCartoesVermelhoTomados[i] > maiorQuantidadeDeCartaoVermelhoRecebido)
                {
                    maiorQuantidadeDeCartaoVermelhoRecebido = quantidadesCartoesVermelhoTomados[i];
                    nomeMaiorQuantidadeDeCartaoVermelhoRecebido = nomes[i];
                }
                if (quantidadesCartoesVermelhoTomados[i] < menorQuantidadeDeCartaoVermelhoRecebido)
                {
                    menorQuantidadeDeCartaoVermelhoRecebido = quantidadesCartoesVermelhoTomados[i];
                    nomeMenorQuantidadeDeCartaoVermelhoRecebido = nomes[i];
                }
            }
            Console.WriteLine("O jogador(@) com o menor peso é: " + nomeMenorPeso + " com " +menorPeso + "Kg ");
            Console.WriteLine("O jogador(@) com a maior  altura é: " + nomeMaiorAltura + " com " + maiorAltura + "Cm ");
            Console.WriteLine("Quantidades de jogadores Masculino: " + quantidadeDeSexoMasculino);
            Console.WriteLine("Quantidades de jogadoras Feminino: " + quantidadeDeSexoFeminino);
            Console.WriteLine("O jogador(@) com a menor quantidade de cartões amarelo recebidos é: " + nomeMenorQuantidadeDeCartoesAmarelosRecebidos + " com " + menorQuantidadeDeCartoesAmarelosRecebidos);
            Console.WriteLine("O jogador(@) com maior peso é: " + nomeMaiorPeso + " com " + maiorPeso +"Kg ");
            Console.WriteLine("O jogador(@) com a maior quantidade de cartão vermelho recebido é: " + nomeMaiorQuantidadeDeCartaoVermelhoRecebido + " com " + maiorQuantidadeDeCartaoVermelhoRecebido);
            Console.WriteLine("O jogador(@) com a maior quantidade de cartões amarelo recebidos é: " + nomeMaiorQuantidadeDeCartaoAmareloRecebido + " com " + maiorQuantidadeDeCartaoAmareloRecebido);
            Console.WriteLine("O jogador(@) com a menor quantidade de cartão vermelho recebido é: " + nomeMenorQuantidadeDeCartaoVermelhoRecebido + " com " + menorQuantidadeDeCartaoVermelhoRecebido);




        }
    }
}
