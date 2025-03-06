

using System.Text;

static void Exemplo01(){

    int indice = 0;
    while(indice < 3)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite Seu sobrenome: ");
        string sobreNome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobreNome;
        Console.WriteLine("Nome Completo: " + nomeCompleto);

        //Incrementar a variavel indice em 1
        indice = indice + 1;
    }
}

static void Exemplo2()
{
    int soma = 0;
    int indice = 0;
    while(indice < 5)
    {
        Console.Write("Digite o numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        soma = soma + numero;
        indice = indice + 1;
    }
    Console.WriteLine(soma);
}


static void ExemploEnquanto01()
{
    //
    int indice = 0;
    while (indice < 11)
    {
        Console.WriteLine(indice);

        indice = indice + 1;
    }
}

static void ExemploEnquanto02ContagemREgressiva()
{
    int indice = 10;

    while (indice >= 0)
    {
        Console.WriteLine(indice);
        indice = indice - 1;
    }
}

static void ExemploSolicitarDadosAlunos()
{
    // Solicitar nome, nota 1, nota 2, nota 3 e calcular a média de 3 alunos
    int indice = 0;
    while (indice < 3) // 0..2
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine().Trim();

        Console.Write("Digite a nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Média: " + media);

        Console.Write("\n\nAperte alguma tecla para continuar...");
        Console.ReadKey(); // Aguarda apertar alguma tecla do teclado
        Console.Clear(); // Limpa tela

        indice = indice + 1; // Incrementar
    }
}


static void ExemploSolicitarDados3Alunos()
{
    // Solicitar nome, nota 1, nota 2, nota 3 e calcular a média de 3 alunos
    int indice = 0;
    while (indice < 3) // 0..2
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine().Trim();

        Console.Write("Digite a nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Média: " + media);

        Console.Write("\n\nAperte alguma tecla para continuar...");
        Console.ReadKey(); // Aguarda apertar alguma tecla do teclado
        Console.Clear(); // Limpa tela

        indice = indice + 1; // Incrementar
    }
}
static void ExemploSolicitarDadosAlunosEnquantoDesejar()
{
    // Solicitar nome, nota 1, nota 2, nota 3 e calcular a média de n alunos
    string nome = "";

    while (nome != "sair") // 0..2
    {
        Console.Write("Digite o nome (digite sair para encerrar): ");
        nome = Console.ReadLine().Trim();

        if (nome.ToLower() == "sair")
            break; // Encerra a execução do while

        Console.Write("Digite a nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Média: " + media);

        Console.Write("\n\nAperte alguma tecla para continuar...");
        Console.ReadKey();
        Console.Clear(); // Limpa tela
    }
}

static void ExemploSolicitarDadosAlunosEnquantoDesejarContinuar()
{
    // Solicitar nome, nota 1, nota 2, nota 3 e calcular a média de n alunos
    string desejaContinuar = "";
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8; // Definir que a entrada permitirá acentos de pt-br

    while (desejaContinuar != "não" && desejaContinuar != "n")
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine().Trim();

        Console.Write("Digite a nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Média: " + media);

        Console.Write("\n\nDeseja calcular a média de outro aluno? [sim/não] ");
        desejaContinuar = Console.ReadLine().ToLower();
        Console.Clear(); // Limpa tela
    }
}


static void ExemploMaiorAltura()
{
    int indice = 0;
    double maiorAltura = 0;

    while (indice < 3)
    {
        Console.Write("Altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Se a altura que o usuário digitou é maior do que a maior altura
        if (altura > maiorAltura)
        {
            // Armazenamos a altura digitada pois é maior que a maior altura
            maiorAltura = altura;
        }
        indice = indice + 1;
    }
    Console.WriteLine("Maior altura: " + maiorAltura);
}

static void ExemploMenorPeso()
{
    int indice = 0;
    double menorPeso = 9999999999999999999;
    while (indice < 3)
    {
        Console.Write("Peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        if (peso < menorPeso)
        {
            menorPeso = peso;
        }

        // Incrementar
        indice = indice + 1;
    }
    Console.WriteLine("Menor peso: " + menorPeso);
}

static void ExemploSoma()
{
    int indice = 0;
    double soma = 0;
    while (indice < 4)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        soma = soma + valor;

        indice = indice + 1;
    }
    Console.WriteLine("Soma: " + soma);
}
static void DescobrirQuantidade()
{
    int indice = 0;
    int quantidadeSc = 0, quantidadeRs = 0, quantidadePr = 0;
    while (indice < 5)
    {
        Console.Write("Estado: ");
        string estado = Console.ReadLine();

        if (estado.ToUpper() == "SC")
        {
            quantidadeSc = quantidadeSc + 1;
        }
        else if (estado.ToUpper() == "PR")
        {
            quantidadePr = quantidadePr + 1;
        }
        else if (estado.ToUpper() == "RS")
        {
            quantidadeRs = quantidadeRs + 1;
        }


        indice = indice + 1;
    }
    Console.WriteLine(
        "Quantidade PR: " + quantidadePr +
        "\nQuantidade RS: " + quantidadeRs +
        "\nQuantidade SC: " + quantidadeSc);
}
static void DescobrirMedia()
{
    int indice = 0;
    double soma = 0;
    while (indice < 4)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        soma = soma + valor;

        indice = indice + 1;
    }
    double media = soma / indice;

    Console.WriteLine("Média: " + media);
}

static void ExemploEnquantoCOmValidacao()
{
    //nome: min 3 max 100
    // idade : min 0 max 120
    int indice = 0;
    while (indice < 3)
    {
        Console.Write("Nome:");
        string nome = Console.ReadLine().Trim();
        
        while(nome.Length < 3 || nome.Length > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome inválido! Deve conter no minimo 3 caracteres e no maximo 100.");
            Console.ResetColor();

            Console.Write("Nome:");
             nome = Console.ReadLine().Trim();

        }

        Console.Write("Idade:");
        int idade = Convert.ToInt32(Console.ReadLine());
        while(idade < 0 || idade > 120)
        {
            if(idade == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida! Deve conter no minimo 0 anos. ");
                Console.ResetColor();
            }

            else if (idade > 120)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida! Deve conter no maximo 120 anos.");
                Console.ResetColor();
            }

            Console.Write("Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
        }
        indice = indice + 1;
    } 
}
ExemploEnquantoCOmValidacao();