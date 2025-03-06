using Microsoft.Data.SqlClient;
using System.Data;

namespace ExercicioComBancoDeDados
{
    internal class ExercicioLivraria
    {
        public void Executar()
        {
            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Editar Livro");
                Console.WriteLine("3 - Listar Livros");
                Console.WriteLine("4 - Excluir Livro");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 3:
                        ListarLivros();
                        break;
                    case 4:
                        Excluir();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            } while (opcao != 5);
        }

        private void Adicionar()
        {
            Console.Write("Digite o nome do livro que deseja adicionar: ");
            string nomeLivro = Console.ReadLine();

            Console.Write("Digite o nome do autor do livro: ");
            string nomeAutor = Console.ReadLine();

            Console.Write("Digite o ano de publicação do livro: ");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o genero do livro: ");
            string genero = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using(SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "insert into livros(titulo,autor,anoPublicacao,genero) values (@LIVRO,@AUTOR,@ANO,@GENERO)";
                    comando.Parameters.AddWithValue("@LIVRO", nomeLivro);
                    comando.Parameters.AddWithValue("@AUTOR", nomeAutor);
                    comando.Parameters.AddWithValue("@ANO", anoPublicacao);
                    comando.Parameters.AddWithValue("@GENERO", genero);
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Livro adicionado com Sucesso!");
        }

        private void Editar()
        {
            ListarLivros();
            Console.Write("Digite o codigo do livro que deseja alterar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome do livro: ");
            string novoNome = Console.ReadLine();

            Console.Write("Digite o nome do autor: ");
            string nomeAutor = Console.ReadLine();

            Console.Write("Digite o ano de publicação do livro: ");
            int anoPublicacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o genero do livro: ");
            string genero = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using(SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "update livros set titulo = @LIVRO, autor =@AUTOR, anoPublicacao = @ANO, genero = @GENERO where id = @CODIGO ";
                    comando.Parameters.AddWithValue("@LIVRO",novoNome);
                    comando.Parameters.AddWithValue("@AUTOR", nomeAutor);
                    comando.Parameters.AddWithValue("@ANO", anoPublicacao);
                    comando.Parameters.AddWithValue("@CODIGO", codigo);
                    comando.Parameters.AddWithValue("@GENERO", genero);
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Livro Atualizado com Sucesso!");
        }

        private void ListarLivros()
        {
            using(SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using(SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "select id,titulo,autor,anoPublicacao,genero from livros";
                    DataTable tabela = new DataTable();
                    tabela.Load(comando.ExecuteReader());
                    Console.WriteLine("\nLivros Cadastrados: ");
                    for(int i = 0; i <tabela.Rows.Count; i += 1)
                    {
                        DataRow linha = tabela.Rows[i];
                        Console.WriteLine("Codigo: " + linha["id"].ToString() + "\nNome do Livro: " + linha["titulo"] + " \nAutor: " + linha["autor"] + "\nAno de Publicação: " + linha["anoPublicacao"] + "\nGenero: " + linha["genero"] + "\n");
                    }
                }
            }
        }
        private void Excluir()
        {
            ListarLivros();
            Console.WriteLine("Digite o codigo do livro que deseja excluir: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            using(SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using(SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "delete from livros where id = @CODIGO";
                    comando.Parameters.AddWithValue("@CODIGO", codigo);
                    comando.ExecuteNonQuery();

                }
            }
            Console.WriteLine("Livro Excluido com Sucesso!");
            ListarLivros();
        }
    }
}
