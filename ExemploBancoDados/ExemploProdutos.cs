using Microsoft.Data.SqlClient;
using System.Data;

namespace ExemploBancoDados
{
    internal class ExemploProdutos
    {

        public void Executar()
        {
            int menu;
            do
            {
                Console.WriteLine("""
                    1 - Consultar Produtos
                    2 - Adicionar Produto
                    3 - Apagar Produto
                    4 - Editar Produto
                    5 - Sair
                    """);
                Console.WriteLine("Digite o que precisa do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1: ConsultarTodos(); break;
                    case 2: Adicionar(); break;
                    case 3: Apagar(); break;
                    case 4: Editar(); break;
                }
            } while (menu != 5);


        }
        private void ConsultarTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select id,nome from produtos";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            Console.WriteLine("Lista de produtos");
            for (int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];
                Console.WriteLine("Codigo: " + linha["id"].ToString() + "\nNome: " + linha["nome"].ToString() + "\n");
            }


        }
        private void Adicionar()
        {
            Console.Write("Digite o nome do produto para cadastro: ");
            string produto = Console.ReadLine();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            //insert into produtos(nome) values('Coca-Cola');
            comando.CommandText = "insert into produtos(nome) values(@PRODUTO)";
            comando.Parameters.AddWithValue("@PRODUTO", produto);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        private void Apagar()
        {
            ConsultarTodos();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o codigo do produto que deseja apagar: ");
            Console.ResetColor();
            int codigoApagar = Convert.ToInt32(Console.ReadLine());

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            //delete from produtos where id = 1
            comando.CommandText = "delete from produtos where id = @CODIGO_APAGAR";
            comando.Parameters.AddWithValue("@CODIGO_APAGAR", codigoApagar);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto apagado com sucesso!");
        }
        private void Editar()
        {
            ConsultarTodos();

            Console.Write("Qual o produto que deseja alterar digite o codigo do produto: ");
            int produtoAlterar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome do produto: ");
            string nomeProduto = Console.ReadLine();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            //update produtos set nome = 'Samsung' where id = 2
            comando.CommandText = "update produtos set nome =@NOME_PRODUTO where id = @CODIGO_ALTERAR";
            comando.Parameters.AddWithValue("@CODIGO_ALTERAR", produtoAlterar);
            comando.Parameters.AddWithValue("@NOME_PRODUTO", nomeProduto);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto Editado com sucesso!");
        }


    }
}
