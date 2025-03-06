using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioComBancoDeDados
{
    internal class ExercicioBebidas
    {
        string  BANCO_DADOS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\source\repos\CSharp\ExemploBancoDados\ExercicioComBancoDeDados2.mdf;Integrated Security=True";

        public void Executar()
        {
            //AdicionarBebida();
            //ListarBebidas(false);
            //ExcluirBebidas();
            AtualizarBebida();
        }
         
        private void AdicionarBebida()
        {
            Console.Write("Digite o nome da bebida: ");
            string nomeBebida = Console.ReadLine();

            Console.Write("Digite o tipo de bebida(1- Whisky ou 2- Vinho): ");
            string classificacaoBebida = Console.ReadLine();

            Console.Write("Digite o teor alcoolico da bebida: ");
            int teorAlcoolico = Convert.ToInt32(Console.ReadLine());

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = BANCO_DADOS;
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into bebidas(nome_bebida,teor_alcoolico,id_classificacao) values(@NOME_BEBIDA,@TEOR_ALCOOLICO,@CLASSIFICACAO_BEBIDA)";
            comando.Parameters.AddWithValue("@NOME_BEBIDA", nomeBebida);
            comando.Parameters.AddWithValue("@TEOR_ALCOOLICO", teorAlcoolico);
            comando.Parameters.AddWithValue("@CLASSIFICACAO_BEBIDA", classificacaoBebida);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Bebida adicionada com Sucesso");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu!");
            Console.ReadKey();
            Console.Clear();
        }

        private void ListarBebidas(bool bebidasNumeradas)
        {

            SqlConnection conexao = CreateConnection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = """
                select 
                     classificacao.id_classificacao as 'Id',
                      classificacao.descricao_classificacao as 'TipoBebida',
                      bebidas.id_bebida as 'IdBebida',
                      bebidas.nome_bebida as 'Nome',
                      bebidas.teor_alcoolico as 'TeorAlcoolico'
                	  from bebidas
                     inner join classificacao on (bebidas.id_classificacao = classificacao.id_classificacao);
                """;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            for(int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];
                string textoIdBebida = bebidasNumeradas ? linha["IdBebida"].ToString() + "- " : "";
                Console.WriteLine(textoIdBebida + "Bebida: " + linha["TipoBebida"].ToString() +" "+ linha["Nome"].ToString() + " " + linha["TeorAlcoolico"] + "%");
            }
        }
        
        private SqlConnection CreateConnection()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = BANCO_DADOS;
            conexao.Open();
            return conexao;
        }
        private void ExcluirBebidas()
        {
            ListarBebidas(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o codigo do produto que deseja excluir: ");
            Console.ResetColor();
            int idBebida = Convert.ToInt32(Console.ReadLine());
            SqlConnection conexao = CreateConnection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from bebidas where id_bebida = @ID_BEBIDA";
            comando.Parameters.AddWithValue("@ID_BEBIDA", idBebida);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Bebida apagada com Sucesso!");
            ListarBebidas(true);
        }
        private void AtualizarBebida()
        {
            ListarBebidas(true);
            Console.WriteLine("Digite o codigo da bebida que deseja alterar: ");
            int idBebida = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome da bebida: ");
            string nomeBebida = Console.ReadLine();

            Console.Write("Digite o tipo de bebida(1- Whisky ou 2- Vinho): ");
            string classificacaoBebida = Console.ReadLine();

            Console.Write("Digite o teor alcoolico da bebida: ");
            int teorAlcoolico = Convert.ToInt32(Console.ReadLine());

            SqlConnection conexao = CreateConnection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = " update bebidas set nome_bebida = @NOME_BEBIDA, teor_alcoolico = @TEOR_ALCOOLICO, id_classificacao = @CLASSIFICACAO_BEBIDA where id_bebida = @ID_BEBIDA;";
            comando.Parameters.AddWithValue("@ID_BEBIDA", idBebida);
            comando.Parameters.AddWithValue("@NOME_BEBIDA", nomeBebida);
            comando.Parameters.AddWithValue("@CLASSIFICACAO_BEBIDA", classificacaoBebida);
            comando.Parameters.AddWithValue("@TEOR_ALCOOLICO", teorAlcoolico);
            comando.ExecuteNonQuery();
            conexao.Close();
            Console.WriteLine("Bebida atualizada com Sucesso!");
            ListarBebidas(true);
        }
    }
}
