static void Exemplo01()
{
    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine("Seu numero é postivo!");
    }
    else if (numero < 0)
    {
        Console.WriteLine("Seu numero é negativo!");

    }
    else
        Console.WriteLine("Seu numero é neutro!");
}

static void Exemplo02()
{
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine("O numero " + numero1 + " é maior que o numero " + numero2);
    }
    else
    {
        Console.WriteLine("O numero " + numero2 + " é maior que o numero " + numero1);

    }
}

static void Exemplo03()
{
    Console.Write("Digite a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());

    if (nota >= 7)
    {
        Console.WriteLine("Aluno aprovado!");
    }
    else
        Console.WriteLine("Aluno reprovado!");
}

static void Exemplo04()
{
    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Seu numero é par");
    }
    else
        Console.WriteLine("Seu numero é ímpar");
}


static void Exemplo05()
{
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite seu idade:  ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o Segundo nome: ");
    string nome2 = Console.ReadLine();

    Console.Write("Digite a segunda idade: ");
    int idade2 = Convert.ToInt32(Console.ReadLine());

    if (idade > idade2)
    {
        Console.WriteLine(nome + " Com a idade: " + idade + " é mais velho(a) do que " + nome2 + " que tem a idade: " + idade2);
    }
    else if (idade2 > idade)
    {
        Console.WriteLine(nome2 + " Com a idade: " + idade2 + " é mais velho(a) do que " + nome + " que tem a idade: " + idade);
    }
    else
        Console.WriteLine(nome2 + " tem a mesma idade que é : " + idade2 + " do que  " + nome + " que tem a idade: " + idade);

}

static void Exemplo06()
{
    int menu = 0;
    Console.Write("Digite o primeiro numero para fazer a operação:");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo numero para fazer a operação:");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qual operação você deseja fazer? 1- Soma\n 2- Subtração\n 3-Multiplicação\n 4- Diviisão");
    menu = Convert.ToInt32(Console.ReadLine());

    if (menu == 1)
    {
        double soma = 0;
        soma = numero1 + numero2;

        Console.WriteLine("O valor total da soma foi de: " + soma);
    }
    else if (menu == 2)
    {
        double sub = 0;
        sub = numero1 - numero2;
        Console.WriteLine("O valor total da subtração foi de: " + sub);
    }
    else if (menu == 3)
    {
        double multi = 0;
        multi = numero1 * numero2;
        Console.WriteLine("O valor total da multiplicação foi de: " + multi);
    }
    else if (menu == 4)
    {
        double divi = 0;
        divi = numero1 / numero2;
        Console.WriteLine("O valor total da divisão foi de: " + divi);
    }
}

static void Exemplo07()
{
    Console.Write("Digite o ano que você deseja ver se é bissexto: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    if (ano % 4 == 0)
    {
        Console.WriteLine("Seu ano é bissexto!");
    }
    else
        Console.WriteLine("Seu ano não é bissexto!");
}

static void Exemplo08()
{
    Console.Write("Digite o valor da compra: ");
    double valorCompra = Convert.ToDouble(Console.ReadLine());

    if (valorCompra > 100)
    {

        double desconto = valorCompra * 10 / 100;
        double valorCompraComDesconto = valorCompra - desconto;

        Console.WriteLine("O valor total da compra foi de: " + valorCompraComDesconto);
    }
    else
        Console.WriteLine("O valor da compra não atingiu o valor necessario!!");
}

static void Exemplo09()
{
    Console.Write("Digite o primeiro lado de um triângulo: ");
    double lado1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo lado do triângulo: ");
    double lado2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o terceiro lado do triângulo: ");
    double lado3 = Convert.ToDouble(Console.ReadLine());

    if (lado1 == lado2 && lado3 == lado2)
    {
        Console.WriteLine("Seu triângulo é Equilátero! ");
    }
    else if (lado1 == lado2 && lado3 != lado1 || lado1 == lado3 && lado2 != lado1 || lado1 != lado2 && lado2 == lado3)
    {
        Console.WriteLine("Seu triângulo é Isósceles! ");
    }
    else if (lado1 != lado2 && lado3 != lado2)
    {
        Console.WriteLine("Seu triângulo é Escaleno! ");
    }
}


static void Exemplo10()
{
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 % numero2 == 0)
    {
        Console.WriteLine("Os numero são multiplos um do outro! ");
    }
    else
        Console.WriteLine("Os numeros não são multiplos um do outro! ");
}

/////////////////////////////////////////////////////////////////////////////

static void ExemploWhile01()
{
    int indice = 0;

    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (numero >= 0)
    {
        Console.WriteLine("Digite mais um numero novamente: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("Aperte qualque tecla para prosseguir! ");
            Console.ReadKey();
            Console.Clear();
        }
        else
            break;
    }


    Console.WriteLine("Seu numero é negativo!!");
}

static void ExemploWhilhe02()
{
    int indice = 1;
    int resultado = 1;

    Console.Write("Digite um numero para fazer fatorial: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n" + "O Fatorial do numero: " + numero);
    while (indice <= numero)
    {
        Console.WriteLine("\n" + indice + " * " + resultado + " = ");
        resultado = resultado * indice;
        Console.WriteLine(resultado + "\n");
        indice = indice + 1;
        // esta fazendo 1 x 2 x 3 x 4 dado que foi solicitado para fazer o fatorial do numero 4
        // 4 x 3 x 2 x 1
    }
    Console.WriteLine("\n Seu o resultado foi: " + resultado);
}

static void ExemploWhilhe02Alternativa()
{


    Console.Write("Digite um numero para fazer fatorial: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n" + "O Fatorial do numero: " + numero);
    int resultado = numero;

    while (numero > 1)
    {
        numero = numero - 1;
        Console.WriteLine("\n" + numero + " * " + resultado + " = ");
        resultado = resultado * numero;
        Console.WriteLine(resultado + "\n");
        // esta fazendo 1 x 2 x 3 x 4 dado que foi solicitado para fazer o fatorial do numero 4
        // 4 x 3 x 2 x 1
    }
    Console.WriteLine("\n Seu o resultado foi: " + resultado);
}



static void ExemploWhile03()
{

    Console.WriteLine("Digite um numero para ver a contagem regressiva: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (numero > 0)
    {
        numero = numero - 1;

        Console.WriteLine(numero);
    }
}

static void ExemploWhile04()
{
    int indice = 0;
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 == 0 || numero2 == 0)
    {
        Console.WriteLine("O valor que digitou foi Zero por isso da invalidação no sistema! ");
        return;
    }



    while (numero1 != 0 && numero2 != 0)
    {

        int soma = numero1 + numero2;
        Console.WriteLine("O valor da soma foi de: " + soma + "\n ");

        Console.Write("Digite o primeiro numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());


        if (numero1 == 0 || numero2 == 0)
            break;
    }
    Console.WriteLine("O valor que digitou foi Zero por isso da invalidação no sistema! ");
}

static void ExemploWhile05()
{

    string letras = "";
    do
    {
        Console.WriteLine("Digite uma palavra ou frase: ");
        letras = Console.ReadLine().Replace(" ", "");

        if (letras.ToLower() == "fim")
        {
            Console.WriteLine("Você digitou fim, ate mais!!");
            break;
        }
        Console.WriteLine("O que você digitou deu: " + letras.Length + " letras");
    } while (letras.Length > 1);
}

static void ExemploWhile06()
{
    int indice = 2;
    Console.WriteLine("Digite um numero pra ver se é ou não primo: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (indice >= 0)
    {
        if (numero == 2 || numero == 3)
        {
            Console.WriteLine("Esse numero é primo!!");
            //return;
        }
        else if (numero % 2 == 0 || numero % 3 == 0 || numero <= 1)
        {
            Console.WriteLine("Seu numero não é primo!! ");
            //break;
        }
        else
            Console.WriteLine("Seu numero é primo!!");

        Console.WriteLine("Digite um numero pra ver se é ou não primo: ");
        numero = Convert.ToInt32(Console.ReadLine());

    }
}

static void ExemploWhile06Validacao()
{
    int numero = 1;

    while (numero < 100)
    {
        if (EhPrimo(numero) == true)
        {
         
            Console.WriteLine($"Seu numero {numero} é primo!!");

        }
        numero = numero + 1;

    }
}

static bool EhPrimo(int numero)
{
    if (numero == 2 || numero == 3)
    {
        return true;
    }
    else if (numero % 2 == 0 || numero % 3 == 0 || numero <= 1)
    {
        return false;
    }
    for (int i = 5; i * i <= numero; i += 6)
    {
        if (numero % i == 0 || numero % (i + 2) == 0)
            return false;
    }
    return true;
}


static void ExemploWhile07()
{
    int indice = 0;

    Console.WriteLine("Diigte o numero no qual deseja ver a tabuada: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (indice <= 10)
    {
        int tabuada = numero * indice;
        Console.WriteLine(numero + " * " + indice + " = " + tabuada);
        indice = indice + 1;


    }
}
