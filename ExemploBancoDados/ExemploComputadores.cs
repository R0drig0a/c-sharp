using Microsoft.Data.SqlClient;
using System.Data;


namespace ExemploBancoDados
{
    internal class ExemploComputadores
    {
        public void Executar()
        {
            ListarTodos();
            //Adicionar();
            //Apagar();
            //Editar();
        }
        private void  ListarTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select id,processador,memoriaRam,fonte,placaDeVideo, preco from computadores";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            for(int i = 0; i < tabela.Rows.Count; i += 1)
            {
                DataRow linha = tabela.Rows[i];
                Console.WriteLine(linha["id"]);
            }
        }
        private void Adicionar()
        {
           
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "insert into computadores(processador,memoriaRam,fonte,placaDeVideo,preco) values('i5','64','1000','Rtx4060','7800')";// fiquei un 15 minutos para descobrir que cada atributos tinha que botar apostrofo
            comando.ExecuteNonQuery();
            conexao.Close();

        }
        private void Apagar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from computadores where id = 5";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        private void Editar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            conexao.Open();
            SqlCommand comando = conexao.CreateCommand();
            //update produtos set nome = 'Samsung' where id = 2
            comando.CommandText = "update computadores set processador = 'i3',memoriaRam = '128' where id = 2";
            //comando.CommandText = "update computadores set processador = 'i18',preco = '85000' where id = 3"; Não sabia que nesse caso aqui atualizaria o ultimo.
            comando.ExecuteNonQuery();
            conexao.Close();
        }

    }
}
