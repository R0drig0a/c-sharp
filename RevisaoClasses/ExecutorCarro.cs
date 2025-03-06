using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoClasses
{
    class ExecutorCarro
    {
        public void Executar()
        {
            MostrarInformacoes();
        }

        private void MostrarInformacoes()
        {

            Carro Ford = new Carro();
            Ford.Nome = "Ka";
            Ford.Ano = 2020;
            Ford.Modelo = "Sedan";
            Ford.Cor = "Branco";

            Console.WriteLine($"Nome do carro é: {Ford.Nome}");
            Console.WriteLine($"O ano do carro é: {Ford.Ano}");
            Console.WriteLine($"O modelo do carro é: {Ford.Modelo}");
            Console.WriteLine($"A Cor do carro é: {Ford.Cor}");

            Console.WriteLine("\n -----------------------");

            Carro Volkswagen = new Carro();
            Volkswagen.Nome = "Jetta";
            Volkswagen.Modelo = "Sedan";
            Volkswagen.Ano = 2025;
            Volkswagen.Cor = "Cinza";

            Console.WriteLine($"Nome do carro é: {Volkswagen.Nome}");
            Console.WriteLine($"O modelo do carro é: {Volkswagen.Modelo}");
            Console.WriteLine($"O ano do carro é: {Volkswagen.Ano}");
            Console.WriteLine($"A cor do carro é: {Volkswagen.Cor}");
        }
    }
}
