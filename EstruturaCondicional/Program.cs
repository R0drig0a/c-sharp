static void ExemploLogin()
{
    Console.Write("Login:");
    string login = Console.ReadLine();

    Console.Write("Digite sua Senha:");
    string senha = Console.ReadLine();

    if (login == "admin" && senha == "123")
    {
        Console.Write("Login efetuado com Sucesso!");
    }
    else
    {
        Console.Write("Login inválido!");
    }
}
static void ExemploNumeroNegativoPositivoNeutro()
{
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    if(numero1 < 0)
    {
        Console.Write("Seu numero é negativo!");
    }
    else if (numero1 > 0)
    {
        Console.Write("Seu numero é positivo");
    }
    else
    {
        Console.WriteLine("Seu numero é neutro");
    }
}

static void ExemploNumeroPar()
{
    Console.Write("Digite um numero:");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.Write("Seu numero é par!");
    }
    else
    {
        Console.WriteLine("Seu numero é impar!");
    }
}


ExemploNumeroPar();




/* tabela verdade ou ||
 * V ou V = V
 * V ou F = V
 * F ou V = V
 * F ou F = F
 * 
 * tabela verdade e &&
 * V e V = V
 * V e F = F
 * F e V = F
 * F e F = F
 */


/*
 * Operadores relacionais
 * 
 * Igual            ==
 * Menor            < 
 * Menor ou igual   <=
 * Maior            >
 * Maior ou igual   >=
 * Diferente        !=
 * 
 * Operadores lógicos
 * E                &&
 * Ou               ||
 */