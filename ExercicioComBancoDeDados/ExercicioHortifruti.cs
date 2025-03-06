using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComBancoDeDados
{
    internal class ExercicioHortifruti
    {
       public  ExercicioHortifruti()
        {
            Executar();
        }

        string BANCO_DADOS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDados2.mdf;Integrated Security=True";

        public void Executar()
        {
            AdicionarHortifruti();
            ListarProdutos(false);
            ExcluirProduto();
            AtualizarProduto();
        }

        private void AdicionarHortifruti()
        {
            Console.Write("Digite o nome do que deseja adicionar: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o tipo de (1- Fruta ou 2- Verdura): ");
            string classificacaoHortifruti = Console.ReadLine();

            Console.Write("Digite o preço unitario: ");
            double precoHortifruti = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            double quantidadeHortifruti = Convert.ToDouble(Console.ReadLine());

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = BANCO_DADOS;
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into hortifruti(nome_hortifruti,id_categoria,preco_hortifruti,quantidade_hortifruti) values(@NOME_PRODUTO,@CLASSIFICACAOHORTIFRUTI,@PRECO_HORTIFRUTI,@QUANTIDADE_HORTIFRUTI)";
            comando.Parameters.AddWithValue("@NOME_PRODUTO", nomeProduto);
            comando.Parameters.AddWithValue("@CLASSIFICACAOHORTIFRUTI", classificacaoHortifruti);
            comando.Parameters.AddWithValue("@PRECO_HORTIFRUTI", precoHortifruti);
            comando.Parameters.AddWithValue("@QUANTIDADE_HORTIFRUTI", quantidadeHortifruti);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto adicionado com Sucesso");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
        }

        private void ListarProdutos(bool produtosNumerados)
        {

            SqlConnection conexao = CreateConnection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = """
                select
                	ht.id_categoria,
                	ct.nome_categoria,
                	ht.nome_hortifruti,
                	ht.quantidade_hortifruti,
                    ht.id_hortifruti,
                	ht.preco_hortifruti,
                	ht.preco_hortifruti * ht.quantidade_hortifruti as preco_multiplicado
                from
                	categoria ct
                inner join hortifruti ht on (ct.id_categoria = ht.id_categoria);
                """;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            for (int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];
                string textoIdProduto = produtosNumerados ? linha["id_hortifruti"].ToString() + "- " : "";
                Console.WriteLine(textoIdProduto + "Hortifruti: " + linha["nome_hortifruti"].ToString() + " Preço: " + linha["preco_hortifruti"] + "R$ " + "Quantidade: "+ linha["quantidade_hortifruti"]);
            }
        }

        private SqlConnection CreateConnection()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = BANCO_DADOS;
            conexao.Open();
            return conexao;
        }
        private void ExcluirProduto()
        {
            ListarProdutos(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o codigo do produto que deseja excluir: ");
            Console.ResetColor();
            int idProduto = Convert.ToInt32(Console.ReadLine());
            SqlConnection conexao = CreateConnection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from hortifruti where id_hortifruti = @ID_HORTIFRUTI";
            comando.Parameters.AddWithValue("@ID_HORTIFRUTI", idProduto);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto apagado com Sucesso!");
            ListarProdutos(true);
        }
        private void AtualizarProduto()
        {
            ListarProdutos(true);

            Console.WriteLine("Digite o codigo do produto que deseja alterar: ");
            int idProduto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do que deseja adicionar: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o tipo de (1- Fruta ou 2- Verdura): ");
            string classificacaoHortifruti = Console.ReadLine();

            Console.Write("Digite o preço unitario: ");
            double precoHortifruti = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            double quantidadeHortifruti = Convert.ToDouble(Console.ReadLine());

            SqlConnection conexao = CreateConnection();
          
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = " update hortifruti set nome_hortifruti = @NOME_HORTIFRUTI, id_categoria = @ID_CAREGORIA, preco_hortifruti = @PRECO_HORTIFRUTI,quantidade_hortifruti = @QUANTIDADE_HORTIFRUTI where id_hortifruti = @ID_HORTIFRUTI;";
            comando.Parameters.AddWithValue("@NOME_HORTIFRUTI", nomeProduto);
            comando.Parameters.AddWithValue("@ID_CAREGORIA", classificacaoHortifruti);
            comando.Parameters.AddWithValue("@PRECO_HORTIFRUTI", precoHortifruti);
            comando.Parameters.AddWithValue("@QUANTIDADE_HORTIFRUTI", quantidadeHortifruti);
            comando.Parameters.AddWithValue("@ID_HORTIFRUTI", idProduto);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Produto atualizado com Sucesso!");
            ListarProdutos(true);
        }
    }
}
