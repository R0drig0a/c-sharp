using Microsoft.Data.SqlClient;
using System.Data;


namespace ExercicioComBancoDeDados
{
    internal class ExercicioTimes
    {
        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 - Adicionar Time
                    2 - Lista de Times
                    3 - Apagar Times
                    4 - Editar Times
                    5 - Listar Times por Serie
                    10 - Sair
                    """);
                Console.WriteLine("Digite o que precisa do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1: Adicionar(); break;
                    case 2: ListaTime(); break;
                    case 3: ApagarTime(); break;
                    case 4: EditarTime(); break;
                    case 5: ListaTimePorSerie(); break;
                }

            } while (menu != 10);
                
                
        }
        private void Adicionar()
        {
            ListaSeries();
            Console.Write("Digite o codigo da serie: ");
            int serieId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do time que deseja adicionar: ");
            string nomeAdicionado = Console.ReadLine();

            Console.Write("Digite qual estado é o time que deseja Adicionar Ex SC: ");
            string estadoTime = Console.ReadLine();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into times(nome,estado,id_serie) values(@NOME_ADICIONADO,@ESTADO_ADICIONADO,@SERIE_ID)";
            comando.Parameters.AddWithValue("@NOME_ADICIONADO", nomeAdicionado);
            comando.Parameters.AddWithValue("@ESTADO_ADICIONADO", estadoTime);
            comando.Parameters.AddWithValue("@SERIE_ID", serieId);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Time adicionado com Sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
        }
        private void ListaTime()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = """
                select
                series.nome as 'Serie',
                times.id as 'Id',
                times.nome as 'Nome',
                times.estado as 'Estado'
                from times
                inner join series on(times.id_serie = series.id);
                """;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            for(int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];
                //Console.WriteLine("Codigo: " + linha["id"].ToString() + "\nNome: " + linha["nome"].ToString() + "\n");

                Console.WriteLine(linha["Id"] + " Time: " + linha["Nome"].ToString()+ " " +linha["Estado"].ToString() + " "+ linha["Serie"]);
             
            }
        }
        private void ListaTimePorSerie()
        {
            ListaSeries();
            Console.Write("Digite o codigo da serie que deseja ver os times: ");
            int serieId = Convert.ToInt32(Console.ReadLine());


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = """
                select
                times.id as 'Id',
                times.nome as 'Nome'
                from times
                where times.id_serie = @SERIE_ID
                ORDER BY times.nome ASC
                """;

            comando.Parameters.AddWithValue("@SERIE_ID", serieId);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            Console.Clear();
            Console.WriteLine("Times da Série:");
            for (int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];

                Console.WriteLine("\t" + linha["Nome"].ToString());
            }
        }
        private void ListaSeries()
        {
            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "select id, nome from series";
                DataTable tabela = new DataTable();
                tabela.Load(comando.ExecuteReader());

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    DataRow linha = tabela.Rows[i];
                    Console.WriteLine($"ID: {linha["id"]} | Série: {linha["nome"]}");
                }
            }
        }


        private void ApagarTime()
        {
            ListaTime();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o nome do time  que deseja apagar: ");
            Console.ResetColor();
            string timeApagado = Console.ReadLine();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from times where nome = @TIME_APAGADO";
            comando.Parameters.AddWithValue("@TIME_APAGADO", timeApagado);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Time apagado com Sucesso!");
           

        }

        private void EditarTime()
        {
            ListaTime();
            Console.Write("Qual time deseja alterar digite o codigo: ");
            int codigoAlterar =Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome do time: ");
            string novoTime = Console.ReadLine();

            ListaSeries();
            Console.Write("Digite o codigo da serie: ");
            int serieId = Convert.ToInt32(Console.ReadLine());

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "update times set nome =@NOVO_TIME, id_serie =@SERIE_ID where id =@CODIGO_ALTERAR";
            comando.Parameters.AddWithValue("@CODIGO_ALTERAR", codigoAlterar);
            comando.Parameters.AddWithValue("@NOVO_TIME", novoTime);
            comando.Parameters.AddWithValue("@SERIE_ID", serieId);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Time alterado com Sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
