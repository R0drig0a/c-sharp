namespace ExercicioComListaEClasse
{
    internal class ExecutorVeiculo
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        public void Executar()
        {
            CadastrarCarro();
            MostrarCarros();
            ValorPago();
            JurosPago();
        }
        private void CadastrarCarro()
        {
            Console.WriteLine("\nLISTA DE CARROS CADASTRADOS!!:");
            Veiculo veiculo1 = new Veiculo();
            veiculo1.Modelo = "Fusca";
            veiculo1.Marca = "Volkswagem";
            veiculo1.Categoria = "Hatch";
            veiculo1.ValorParcela = 650.50;
            veiculo1.QuantidadeParcela = 55;
            veiculo1.ValorFipe = 35000;
            veiculos.Add(veiculo1);

            Veiculo veiculo2 = new Veiculo();
            veiculo2.Modelo = "Kombi";
            veiculo2.Marca = "Volkswagen";
            veiculo2.Categoria = "Vans";
            veiculo2.ValorParcela = 1000;
            veiculo2.QuantidadeParcela = 60;
            veiculo2.ValorFipe = 85000;
            veiculos.Add(veiculo2);

            Veiculo veiculo3 = new Veiculo();
            veiculo3.Modelo = "Bmw 320i";
            veiculo3.Marca = "BMW";
            veiculo3.Categoria = "Sedan";
            veiculo3.ValorParcela = 2500;
            veiculo3.QuantidadeParcela = 50;
            veiculo3.ValorFipe = 200000;
            veiculos.Add(veiculo3);

        }

        private void MostrarCarros()
        {
            for(int i = 0; i < veiculos.Count; i += 1)
            {
                Veiculo veiculo = veiculos[i];

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Modelo: " + veiculo.Modelo);
                Console.WriteLine("Marca: " + veiculo.Marca);
                Console.WriteLine("Categoria: " + veiculo.Categoria);
                Console.WriteLine("Valor Parcela: " + veiculo.ValorParcela);
                Console.WriteLine("Quantida de Parcelas: " + veiculo.QuantidadeParcela);
                Console.WriteLine("valor Fipe: " + veiculo.ValorFipe);
                Console.WriteLine("-------------------------------------------------");

            }

        }
        private void ValorPago()
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\nVALOR TOTAL PAGO:");
            for (int i = 0; i < veiculos.Count; i += 1)
            {
                Veiculo veiculo = veiculos[i];
                Console.WriteLine("-------------------------------------------------");
                double valorPago = veiculo.ValorParcela * veiculo.QuantidadeParcela;
                Console.WriteLine("O valor Pago no "+ veiculo.Modelo  + " foi de: " + valorPago);
                Console.WriteLine("-------------------------------------------------");
            }
        }
        private void JurosPago()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\nTOTAL DO JUROS PAGO:");
            for (int i = 0; i < veiculos.Count; i += 1)
            {
                Veiculo veiculo = veiculos[i];

                double valorPago = veiculo.ValorParcela * veiculo.QuantidadeParcela;

                double valorJuros = veiculo.ValorFipe - valorPago;
            
                Console.WriteLine("-----------------------------------------------------------------------");
                if (valorJuros > 0)
                {
                    Console.WriteLine("O valor do juros em cima do(@) "+ veiculo.Modelo +" foi de: "+ valorJuros);
                }
                else
                {
                    Console.WriteLine("Nenhum juros em cima do " + veiculo.Modelo);
                }
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
    }
   
}
