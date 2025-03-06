using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses
{
    internal class ExecutorPaciente
    {
        Paciente paciente1 = new Paciente();
        public void Executar()
        {

            Console.WriteLine("Digite seu nome: ");
            paciente1.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            paciente1.Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite seu apelido: ");
            paciente1.Apelido = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            paciente1.Altura = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite seu peso: ");
            paciente1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua idade: ");
            paciente1.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            CalcularImc();
            AnoNascimento();
            NomeCompleto();
            ChamarApelido();
        }

        private void CalcularImc()
        {
            double imc = paciente1.Peso / (paciente1.Altura * paciente1.Altura);
            Console.WriteLine("Seu imc é: " + imc);
        }

        private void AnoNascimento()
        {
            int anoAtual = DateTime.Now.Year;
            int anoNascimento = anoAtual - paciente1.Idade;
            Console.WriteLine("O ano do seu nascimento é: " + anoNascimento);
        }
        private void NomeCompleto()
        {
            Console.WriteLine($"Seu nome Completo é: {paciente1.Nome} {paciente1.Sobrenome}");
        }

        private void ChamarApelido()
        {
            if (paciente1.Apelido == "")
            {
                Console.WriteLine($"Não tem apelido então é chamado pelo Primeiro nome: {paciente1.Nome}");
            }
            else
                Console.WriteLine($"Seu apelido é: {paciente1.Apelido}");
        }
    }
}
