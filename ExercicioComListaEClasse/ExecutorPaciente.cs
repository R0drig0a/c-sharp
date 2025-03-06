namespace ExercicioComListaEClasse
{
    internal class ExecutorPaciente
    {
        List<Paciente> pacientes = new List<Paciente>();
        public void Executar()
        {

            int menu;
            CadastrarPaciente();
            do
            {
                Console.WriteLine("""
                    1 - Mostrar Pacientes
                    2 - CalcularImc
                    3 - Mostrar ano de nascimento
                    4 - ObterNomeCompleto
                    5 - ChamarApelido
                    6 - Sair
                    
                    """);
                Console.WriteLine("Digite o que você deseja do menu: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {

                    case 1: MostrarPaciente(); break;
                    case 2: MostrarImc(); break;
                    case 3: MostrarAnoDeNascimento(); break;
                    case 4: NomeCompleto(); break;
                    case 5: ChamarApelido(); break;
                    case 6: break;
                    default: Console.WriteLine("Opção invalida"); break;
                }

            } while (menu != 6);
          
          
           
        }

        private void CadastrarPaciente()
        {
            Paciente paciente1 = new Paciente();
            paciente1.Nome = "Marcelo";
            paciente1.Sobrenome = "Silva";
            paciente1.Apelido = "";
            paciente1.Altura = 1.89;
            paciente1.Peso =  85.8;
            paciente1.Idade = 22 ;
            pacientes.Add(paciente1);


            Paciente paciente2 = new Paciente();
            paciente2.Nome = "Bernardo";
            paciente2.Sobrenome = "Andrade";
            paciente2.Apelido = "Be";
            paciente2.Altura = 1.50;
            paciente2.Peso = 75.5;
            paciente2.Idade = 10;
            pacientes.Add(paciente2);


            Paciente paciente3 = new Paciente();
            paciente3.Nome = "Antonio";
            paciente3.Sobrenome = "Albino";
            paciente3.Apelido = "";
            paciente3.Altura = 2.50;
            paciente3.Peso = 120;
            paciente3.Idade = 35;
            pacientes.Add(paciente3);


            Paciente paciente4 = new Paciente();
            paciente4.Nome = "André";
            paciente4.Sobrenome = "Souza";
            paciente4.Apelido = "Dé";
            paciente4.Altura = 1.58;
            paciente4.Peso = 62.8;
            paciente4.Idade = 5;
            pacientes.Add(paciente4);


            Paciente paciente5 = new Paciente();
            paciente5.Nome = "Emily";
            paciente5.Sobrenome = "Dias";
            paciente5.Apelido = "Dias";
            paciente5.Altura = 1.70;
            paciente5.Peso = 70.5;
            paciente5.Idade = 15;
            pacientes.Add(paciente5);
        }


        private void MostrarPaciente()
        {
            for(int i = 0; i < pacientes.Count; i += 1)
            {
                Paciente paciente = pacientes[i];

              
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Nome: " + paciente.Nome);
                Console.WriteLine("Sobrenome: " + paciente.Sobrenome);
                Console.WriteLine("Apelido: " + paciente.Apelido);
                Console.WriteLine("Altura: " + paciente.Altura + " m");
                Console.WriteLine("Peso: " + paciente.Peso + " Kg");
                Console.WriteLine("Idade: " + paciente.Idade + " anos");
                
                Console.WriteLine("-------------------------------------------------");

            }

            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }
        private void MostrarImc()
        {
           
            for (int i = 0; i < pacientes.Count; i += 1)
            {
                Paciente paciente = pacientes[i];

                double imc = paciente.Peso / (paciente.Altura * paciente.Altura);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O imc do(@): " + paciente.Nome + " é de: " +imc);
                Console.WriteLine("-------------------------------------------------");

            }

            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();

        }

        private void MostrarAnoDeNascimento()
        {
            for (int i = 0; i < pacientes.Count; i += 1)
            {
                Paciente paciente = pacientes[i];
                int anoAtual = DateTime.Now.Year;
                int anoNascimento = anoAtual - paciente.Idade;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O ano do nascimento do(@)"+ paciente.Nome + " é: " + anoNascimento);
                Console.WriteLine("-------------------------------------------------");

            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

        private void NomeCompleto()
        {

            for (int i = 0; i < pacientes.Count; i += 1)
            {
                Paciente paciente = pacientes[i];
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Seu nome Completo do Paciente: {paciente.Nome} {paciente.Sobrenome}");
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

        private void ChamarApelido()
        {
            for(int i = 0; i < pacientes.Count; i += 1)
            {
                Paciente paciente = pacientes[i];
                if (paciente.Apelido == "")
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine($"Não tem apelido então é chamado pelo Primeiro nome: {paciente.Nome}");
                    Console.WriteLine("--------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine($"Seu apelido é: {paciente.Apelido}");
                    Console.WriteLine("-------------------------------------------------");
                }
                    
            }
            Console.WriteLine("Aperte alguma tecla para voltar ao menu..");
            Console.ReadKey();
            Console.Clear();
        }

    }
   
}
