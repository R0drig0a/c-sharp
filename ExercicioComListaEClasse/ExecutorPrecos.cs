namespace ExercicioComListaEClasse
{
    internal class ExecutorPrecos
    {
        List<Precos> precos = new List<Precos>();
        public void Executar()
        {
            CadastrarPrecos();
            ApresentarPrecos();
            ApresentarSoma();
            MenorNumero();
            MaiorNumero();
        }

        private void CadastrarPrecos()
        {
            Precos preco1 = new Precos();
            preco1.Preco = 18.95;
            precos.Add(preco1);

            Precos preco2 = new Precos();
            preco2.Preco = 45.85;
            precos.Add(preco2);

            Precos preco3 = new Precos();
            preco3.Preco = 3000;
            precos.Add(preco3);

            Precos preco4 = new Precos();
            preco4.Preco = 150;
            precos.Add(preco4);

            Precos preco5 = new Precos();
            preco5.Preco = 350.56;
            precos.Add(preco5);

            Precos preco6 = new Precos();
            preco6.Preco = 10.00;
            precos.Add(preco6);

            Precos preco7 = new Precos();
            preco7.Preco = 12.50;
            precos.Add(preco7);
        }

        private void ApresentarPrecos()
        {
            for (int i = 0; i < precos.Count; i += 1)
            {
                Precos preco = precos[i];
                Console.WriteLine(preco.Preco);
            }
        }

        private void ApresentarSoma()
        {
            double soma = 0;
            for (int i = 0; i < precos.Count; i += 1)
            {
                Precos preco = precos[i];
                soma += preco.Preco;

            }
            Console.WriteLine("O total dos preços cadastrados foi de: " + soma);
        }

        private void MenorNumero()
        {
            double menorNumero = 9999999;
            for (int i = 0; i < precos.Count; i += 1)
            {
                Precos preco = precos[i];

                if (preco.Preco < menorNumero)
                {
                    menorNumero = preco.Preco;
                }
            }
            Console.WriteLine("O menor numero cadastrados é: " + menorNumero);
        }

        private void MaiorNumero()
        {
            double maiorNumero = 0;
            for(int i = 0; i < precos.Count; i += 1)
            {
                Precos preco = precos[i];
                if(preco.Preco > maiorNumero)
                {
                    maiorNumero = preco.Preco;
                }
            }
            Console.WriteLine("O maior numero cadastrado é: " + maiorNumero);
        }
    }
}
