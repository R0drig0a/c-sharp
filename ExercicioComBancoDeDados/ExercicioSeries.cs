using Microsoft.Data.SqlClient;
using System.Data;

namespace ExercicioComBancoDeDados
{
    internal class ExercicioSeries
    {
        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 - Adicionar Série
                    2 - Lista de Séries
                    3 - Apagar Série
                    4 - Editar Série
                    5 - Sair
                    """);
                Console.WriteLine("Digite o que precisa do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1: Adicionar(); break;
                    case 2: ListaSeries(); break;
                    case 3: ApagarSerie(); break;
                    case 4: EditarSerie(); break;
                }
            } while (menu != 5);
        }

        private void Adicionar()
        {
            Console.Write("Digite o nome da série que deseja adicionar: ");
            string nomeAdicionado = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "insert into series(nome) values(@NOME_ADICIONADO)";
                comando.Parameters.AddWithValue("@NOME_ADICIONADO", nomeAdicionado);
                comando.ExecuteNonQuery();
            }
            Console.WriteLine("Série adicionada com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
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

        private void ApagarSerie()
        {
            ListaSeries();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o nome da série que deseja apagar: ");
            Console.ResetColor();
            string serieApagada = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "delete from series where nome = @SERIE_APAGADA";
                comando.Parameters.AddWithValue("@SERIE_APAGADA", serieApagada);
                comando.ExecuteNonQuery();
            }
            Console.WriteLine("Série apagada com sucesso!");
        }

        private void EditarSerie()
        {
            ListaSeries();
            Console.Write("Digite o nome da série que deseja alterar: ");
            string serieAlterar = Console.ReadLine();

            Console.Write("Digite o novo nome da série: ");
            string novoNome = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDado.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "update series set nome = @NOVO_NOME where nome = @SERIE_ALTERAR";
                comando.Parameters.AddWithValue("@SERIE_ALTERAR", serieAlterar);
                comando.Parameters.AddWithValue("@NOVO_NOME", novoNome);
                comando.ExecuteNonQuery();
            }
            Console.WriteLine("Série alterada com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
