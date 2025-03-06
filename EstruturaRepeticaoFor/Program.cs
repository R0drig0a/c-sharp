static void ExemploWhile()
{
    Console.WriteLine("Exemplo com while");
    int indice = 0;
    while (indice < 4)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        indice = indice + 1;
    }
}

static void ExemploFor()
{
    Console.WriteLine("Exemplo com for");
    // for (declaração variável; condição para repetir; incrementar)
    for (int indice = 0; indice < 4; indice = indice + 1)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
    }
}

static void ExemploForMaiorSalario()
{
    for (int indice = 0; indice < 2; indice = indice + 1)
    {
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade de horas trabalhadas:");
        int horasTrabalhada = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor da hora:");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = horasTrabalhada * valorHora;
        Console.WriteLine("Seu salario bruto é: " + salarioBruto);
        Console.Write("Aperte qualquer tecla para continuar!");
        Console.ReadKey();
        Console.Clear();
    }
}

static void ExemploForComValidacaoDeNumeros()
{
    for (int indice = 0; indice < 3; indice = indice + 1)
    {
        int numero = 0;
        bool ehValido = false;
        while (ehValido == false)
        {
            try
            {
                Console.Write("Digite algum numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                ehValido = true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Numero invalidado! Favor informar com numeros");
                Console.ResetColor();

            }
        }
        Console.WriteLine(numero);
    }
}


static void ExemploForRelogio()
{
    /*
     * 00:00:00
     * 00:00:01
     * 00:00:59
     * 00:01:00
     * 23:59:59
     */
    for (int hora = 0; hora <= 23; hora = hora + 1)
    {
        for (int minuto = 0; minuto <= 59; minuto = minuto + 1)
        {
            for (int segundo = 0; segundo <= 59; segundo = segundo + 1)
            {
                Console.WriteLine(hora + ":" + minuto + ":" + segundo);
                Thread.Sleep(1000); // Delay de 1 segundo
            }
        }
    }
}

static void ExemploForContagemRegressiva()
{
    for (int indice = 10; indice >= 0; indice = indice - 1)
    {
        Console.WriteLine(indice);
        Thread.Sleep(300);
        Console.Clear();
    }
    DateTime dataHoraAtual = DateTime.Now;
    int anoAtual = dataHoraAtual.Year;
    // string + string => string
    // string + int => string
    // string + int => string
    Console.WriteLine("Feliz ano novo " + (anoAtual + 1));
}
static void ExemploForValidacaoDeNotas()
{
    /*
     * Solicitar nome,nota1, nota2, nota3 e calcular a media de 3 alunos
     * o nome deve conter no minimo 3 caracteres e no maximo 15 caracteres
     * a nota deve ser no minino 0 e maximo 10
     */
    for (int indice = 0; indice < 3; indice = indice + 1)
    {
        string nome = "";
        while (nome.Length < 3 || nome.Length > 15)
        {
            Console.Write("Digite seu nome:");
            nome = Console.ReadLine().Trim();
            if (nome.Length < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome inválido! nome deve conter no minimo 3 caracteres");
                Console.ResetColor();
            }
            else if (nome.Length > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome inválido! nome deve conter no maximo 15 caracteres");
                Console.ResetColor();
            }
        }

        bool nota1Valida = false;
        double nota1 = 0;
        while (nota1Valida == false)
        {
            try
            {
                Console.Write("Digite a primeira nota: ");
                 nota1 = Convert.ToDouble(Console.ReadLine());
                if (nota1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nota inválida! o valor minimo para nota é 0");
                    Console.ResetColor();
                }
                else if (nota1 > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nota inválida! o valor maximo para a nota é 10");
                    Console.ResetColor();
                }
                else
                    nota1Valida = true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("nota inválida!");
                Console.ResetColor();
            }
        }
        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Sua média foi: " + media);
        Console.Write("Aperte alguma tecla para cadastrar novo aluno e suas medias!");
        Console.ReadKey();
        Console.Clear();


    }
}
//ExemploWhile();
ExemploForValidacaoDeNotas();