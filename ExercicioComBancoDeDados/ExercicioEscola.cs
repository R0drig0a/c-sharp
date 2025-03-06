

namespace ExercicioComBancoDeDados
{
    internal class ExercicioEscola
    {
        public void Executar()
        {
            AdicionarAluno();
        }

        private void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno(@): ");
            string nome = Console.ReadLine();
        }
    }
}
