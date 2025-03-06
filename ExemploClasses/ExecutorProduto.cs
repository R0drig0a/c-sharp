using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses
{
    internal class ExecutorProduto
    {
        public void Executar()
        {
            Produto produto1 = new Produto();

            Console.Write("Digite o nome do produto: ");
            produto1.Nome = Console.ReadLine();

            Console.Write("Descrição do produto: ");
            produto1.Descricao = Console.ReadLine();

            Console.Write("Digite a quantidade em estoque: ");
            produto1.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o preço do produto: ");
            produto1.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Clear();



            double total = produto1.Quantidade * produto1.Preco;

            Console.WriteLine($"O nome do produto é: {produto1.Nome}");
            Console.WriteLine($"A descrição do produto é: {produto1.Descricao}");
            Console.WriteLine($"A quantidade do produto é: {produto1.Quantidade}");
            Console.WriteLine($"O preco do produto é: {produto1.Preco}");
            Console.WriteLine($"O total da compra foi: {total}");



        }
    }
}
