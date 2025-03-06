using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses
{

    internal class ExecutorVeiculo
    {
        double valorPago;
        Veiculo veiculo = new Veiculo();
        public void Executar()
        {
            CadastrarVeiculo();
            ValorPago();
            ValorJuros();
        }
        private void CadastrarVeiculo()
        {
            Console.WriteLine("Digite o modelo do veiculo: ");
            veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do seu veiculo: ");
            veiculo.Marca = Console.ReadLine();

            Console.WriteLine("Digite a categoria do veiculo: ");
            veiculo.Categoria = Console.ReadLine();

            Console.WriteLine("Digite o valor da parcela do veiculo: ");
            veiculo.ValorParcela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de parcelas do veiculo: ");
            veiculo.QuantidadeParcelas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da fipe do veiculo: ");
            veiculo.ValorFipe = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }
        private void ValorPago()
        {
            valorPago = veiculo.QuantidadeParcelas * veiculo.ValorParcela;

            Console.WriteLine("O valor pago pelo carro nas parcelas foi de: " + valorPago);
        }

        private void ValorJuros()
        {
            double valorJuros = veiculo.ValorFipe - valorPago;
            if (valorJuros > 0)
            {
                Console.WriteLine("O valor pago a mais foi de: " + valorJuros);
            }
            else
            {
                Console.WriteLine("Nenhum juros em cima do veiculo!");
            }

        }
    }
}
