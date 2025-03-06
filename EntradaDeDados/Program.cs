static void Exemplo01()
{
    Console.Write("Digite seu Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite seu Sobrenome: ");
    string sobreNome = Console.ReadLine();

    string nomeCompleto = nome + " " + sobreNome;

    Console.Clear();

    Console.Write("Nome completo: " + nomeCompleto);

}

static void Exemplo02()
{
    //int numero = Convert.ToInt32("2");
    Console.Write("Digite o primeiro numero:");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o Segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int adicao = numero1 + numero2;

    Console.Write("O valor da operação é: " + adicao);
}

static void Exercicio1()
{
    Console.Write("Digite a primeira nota: ");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a segunda nota:");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a terceira nota: ");
    double nota3 = Convert.ToDouble(Console.ReadLine());

    double media = (nota1 + nota2 + nota3) / 3;

    Console.WriteLine("Sua média foi:" +  media);
}
Exercicio1();


