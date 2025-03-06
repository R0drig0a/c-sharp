namespace ExercicioComListaEClasse
{
    internal class ExecutorMarcas
    {
        List<Marca> marcas = new List<Marca>();

        public void Executar()
        {
            int menu;
            CadastrarMarcas();
            do
            {
                Console.WriteLine("""
                    1 -Listar Marcas
                    2 - Remover Pepsi
                    3 - Editar Nomes
                    4 - Remover o Indice 0
                    5 - Sair
                    
                    """);
                Console.WriteLine("Digite o que você deseja do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {

                    case 1: ListarTodos(); break;
                    case 2: RemoverPepsi(); break;
                    case 3: EditarNomes(); break;
                    case 4: RemoverIndice(); break;
                    case 5: break;
                    default: Console.WriteLine("Opção invalida"); break;
                }

            } while (menu != 5);
        }
        private void CadastrarMarcas()
        {
            Marca marca1 = new Marca();
            marca1.Nome = "Coca - Cola";
            marca1.AnoFundacao = 1958;
            marca1.PaisOrigem = "Estados unidos";
            marcas.Add(marca1);

            Marca marca2 = new Marca();
            marca2.Nome = "Pepsi";
            marca2.AnoFundacao = 1965;
            marca2.PaisOrigem = "Inglaterra";
            marcas.Add(marca2);

            Marca marca3 = new Marca();
            marca3.Nome = "Apple";
            marca3.AnoFundacao = 1980;
            marca3.PaisOrigem = "Estados unidos";
            marcas.Add(marca3);

            Marca marca4 = new Marca();
            marca4.Nome = "Sansung";
            marca4.AnoFundacao = 1958;
            marca4.PaisOrigem = "Estados unidos";
            marcas.Add(marca4);

            Marca marca5 = new Marca();
            marca5.Nome = "Tesla";
            marca5.AnoFundacao = 1958;
            marca5.PaisOrigem = "Estados unidos";
            marcas.Add(marca5);

            Marca marca6 = new Marca();
            marca6.Nome = "Volksvagem";
            marca6.AnoFundacao = 1958;
            marca6.PaisOrigem = "Estados unidos";
            marcas.Add(marca6);

        }

        private void ListarTodos()
        {
            for (int i = 0; i < marcas.Count; i += 1)
            {
                Marca marca = marcas[i];
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Marca: " + marca.Nome);
                Console.WriteLine("Ano Fundação: " + marca.AnoFundacao);
                Console.WriteLine("Pais origem: " + marca.PaisOrigem);
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }
        private void RemoverPepsi()
        {

            marcas.RemoveAt(index: 1);

            Console.WriteLine("Marca apagada com Sucesso!");
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();

        }
        private void EditarNomes()
        {
            Console.WriteLine("Digite o nome que deseja editar: ");
            string nomeEditar = Console.ReadLine();

            for (int i = 0; i < marcas.Count; i += 1)
            {
                Marca marca = marcas[i];
                if (marca.Nome == nomeEditar)
                {
                    Console.WriteLine("Digite o nome correto: ");
                    marca.Nome = Console.ReadLine();

                }

            }
            Console.WriteLine("Marca atualizada com sucesso!");
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }
        private void RemoverIndice()
        {

            marcas.RemoveAt(index: 0);

            Console.WriteLine("Marca apagada com Sucesso!");
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();


        }

    }

}
