using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasses
{
    internal class ExecutorCarro
    {
        public void Executar()
        {
            DateTime dataHoraAtual = DateTime.Now;
            Carro fusca = new Carro();
            fusca.Modelo = "hatch";
            fusca.Ano = 1969;
            fusca.Cor = "Branco";
            fusca.Marca = "Volkswagen";
            fusca.DataCompra = new DateTime(2024, 05, 22,dataHoraAtual.Hour,dataHoraAtual.Minute, dataHoraAtual.Second);

            Console.WriteLine($"O modelo do carro é: {fusca.Modelo}");
            Console.WriteLine($"o ano do carro é: {fusca.Ano}");
            Console.WriteLine($"A cor do carro é:{fusca.Cor}");
            Console.WriteLine($"A marca do carro é: {fusca.Marca}");
            Console.WriteLine($"A data da compra do carro é: {fusca.DataCompra}");

            Console.WriteLine("\n");
            Carro ka = new Carro();
            ka.Modelo = "Sedan";
            ka.Ano = 2023;
            ka.Cor = "Preto";
            ka.Marca = "Ford";


            Console.WriteLine($"O modelo do carro é: {ka.Modelo}");
            Console.WriteLine($"o ano do carro é: {ka.Ano}");
            Console.WriteLine($"A cor do carro é:{ka.Cor}");
            Console.WriteLine($"A marca do carro é: {ka.Marca}");
            if (ka.DataCompra is null)
                Console.WriteLine("Carro não comprado!");
            else
                Console.WriteLine($"Carro comprado em:{ka.DataCompra}");
        }

    }
}
