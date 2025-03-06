using Microsoft.Data.SqlClient;
using System.Data;

namespace ExemploBancoDados
{
    internal class ExemploPaciente
    {
        public void Executar()
        {
            int opcao;

            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar Paciente");
                Console.WriteLine("2 - Editar Paciente");
                Console.WriteLine("3 - Listar Todos os Pacientes");
                Console.WriteLine("4 - Apagar Paciente");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                // Lê e valida a opção escolhida
                if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                // Executa a operação com base na escolha
                switch (opcao)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 3:
                        ListarTodos();
                        break;
                    case 4:
                        Apagar();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                }
            } while (opcao != 5);
        }

        private void Adicionar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using (SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO pacientes(nome,cpf,idade) VALUES(@NOME,@CPF,@IDADE)";
                    comando.Parameters.AddWithValue("@NOME", nome);
                    comando.Parameters.AddWithValue("@CPF", cpf);
                    comando.Parameters.AddWithValue("@IDADE", idade);
                    comando.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Paciente adicionado com sucesso!");
        }

        private void Editar()
        {
            ListarTodos();
            Console.Write("Digite o código que deseja alterar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o novo nome: ");
            string novoNome = Console.ReadLine();

            Console.Write("Digite o novo CPF: ");
            string novoCPF = Console.ReadLine();

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using (SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "UPDATE pacientes SET nome = @NOME, cpf = @CPF WHERE id = @CODIGO";
                    comando.Parameters.AddWithValue("@NOME", novoNome);
                    comando.Parameters.AddWithValue("@CPF", novoCPF);
                    comando.Parameters.AddWithValue("@CODIGO", codigo);
                    comando.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Paciente atualizado com sucesso!");
        }

        private void ListarTodos()
        {
            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using (SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "SELECT id, nome, cpf, idade FROM pacientes";
                    DataTable tabela = new DataTable();
                    tabela.Load(comando.ExecuteReader());

                    Console.WriteLine("\nPacientes Cadastrados:");
                    foreach (DataRow linha in tabela.Rows)
                    {
                        Console.WriteLine("Codigo: " + linha["id"].ToString() + "\nNome: " + linha["nome"] + " \nCPF: " + linha["cpf"] + "\nIdade: " + linha["idade"] + "\n");
                    }
                }
            }
        }

        private void Apagar()
        {
            ListarTodos();
            Console.Write("Digite o código que deseja excluir: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rodri\Desktop\ExemploBancoDeDados.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexao.Open();
                using (SqlCommand comando = conexao.CreateCommand())
                {
                    comando.CommandText = "DELETE FROM pacientes WHERE id = @CODIGO";
                    comando.Parameters.AddWithValue("@CODIGO", codigo);
                    comando.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Paciente removido com sucesso!");
        }
    }
}
