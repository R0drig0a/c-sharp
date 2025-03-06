static void ExemploTratamento()
{
    try
    {
        Console.Write("Idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A idade é:" + idade);
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Idade inválida! valor informado não é um numero inteiro valido.");
        Console.ResetColor();
    }
    Console.WriteLine("Até logo");
}

static void ExemploTratamentoDouble()
{
    try
    {
        Console.Write("Salário:");
        double salario = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Salario invalido! valor informado não é um numero real.");
        Console.ResetColor();
    }
}

static void ExemploSolicitarDadosPaciente()
{
    int indice = 0;
    while (indice < 2)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        int idade = 0;
        bool ehIdadeValido = false;
        while (ehIdadeValido == false)
        {
            try
            {
                Console.Write("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                ehIdadeValido = true;
            }
            catch (FormatException error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade inválida! Idade deve ser um número inteiro.");
                Console.ResetColor();
            }
        }

        double peso = 0;
        bool ehPesoValido = false;
        while (ehPesoValido == false)
        {
            try
            {
                Console.Write("Digite a peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                if (peso < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Peso inválido! Peso deve ser positivo");
                    Console.ResetColor();
                }
                else
                {
                    ehPesoValido = true;
                }
            }
            catch (FormatException error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Peso inválido! Valor informado não é um número real");
                Console.ResetColor();
            }
        }

        // string multiline
        Console.WriteLine($"""
            Nome: {nome}
            Idade: {idade}
            Peso: {peso}
            """);

        indice = indice + 1;
    }
}