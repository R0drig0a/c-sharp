
static void ExemploVetorString()
{
    //Declarando um vetor com 3 posições, que permitirá armazenar 3 nomes
    string[] nomes = new string[3]; // posiçao, 0,1,2
    // Atrin=buindo valor para cada uma das posições
    nomes[0] = "Pedro";
    nomes[1] = "João";
    nomes[2] = "Paula";
    // Alterando o valor que está armazenado na terceira posição[2]
    nomes[2] = "Paula da silva";
    //Apresentar os nomes
    Console.WriteLine(nomes[0]);
    Console.WriteLine(nomes[1]);
    Console.WriteLine(nomes[2]);
}

static void ExemploVetorInt()
{
    int[] numeros = new int[4];

    Console.WriteLine("Digite um numero:");
    numeros[0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um numero:");
    numeros[1] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um numero:");
    numeros[2] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um numero:");
    numeros[3] = Convert.ToInt32(Console.ReadLine());

    int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];

    Console.WriteLine("Soma: " + soma);
}

static void ExemploVetorDados()
{
    string[] nomes = new string[3];
    //Obter o tamanho de um vetor nomes.length, no caso seria 3

    int[] quantidadeDehoras = new int[nomes.Length];
    double[] valorHora = new double[nomes.Length];
   

    Console.Write("Digite o nome do colaborador: ");
    nomes[0] = Console.ReadLine().Trim();
    Console.Write("Digite a quantidade de horas: ");
    quantidadeDehoras[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o valor da hora: ");
    valorHora[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n\n");


    Console.Write("Digite o nome do colaborador: ");
    nomes[1] = Console.ReadLine().Trim();
    Console.Write("Digite a quantidade de horas: ");
    quantidadeDehoras[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o valor da hora: ");
    valorHora[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n\n");


    Console.Write("Digite o nome do colaborador: ");
    nomes[2] = Console.ReadLine().Trim();
    Console.Write("Digite a quantidade de horas: ");
    quantidadeDehoras[2] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o valor da hora: ");
    valorHora[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n\n");

    double[] salarioBrutos = new double[nomes.Length];
    salarioBrutos[0] = quantidadeDehoras[0] * valorHora[0];
    salarioBrutos[1] = quantidadeDehoras[1] * valorHora[1];
    salarioBrutos[2] = quantidadeDehoras[2] * valorHora[2];

    Console.WriteLine("Salario Bruto do 1°: " + salarioBrutos[0]);
    Console.WriteLine("Salario Bruto do 2°: " + salarioBrutos[1]);
    Console.WriteLine("Salario Bruto do 3°: " + salarioBrutos[2]);

}

static void ExercicioVetor()
{
    /*
     * Solicitar o nome, nota1, nota2, nota3, de dois alunos
     * Calcular a media dos dois alunos
     * apresentar se esta aprovado ou reprovado cada um dos alunos;
     */

    string[] nomes = new string[2];
    double[] notas1 = new double[nomes.Length];
    double[] notas2 = new double[nomes.Length];
    double[] notas3 = new double[nomes.Length];

    Console.Write("Digite o nome do aluno: ");
    nomes[0] = Console.ReadLine();
    Console.Write("Digte a primeira nota: ");
    notas1[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digte a segunda nota: ");
    notas2[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digte a terceira nota: ");
    notas3[0] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o nome do aluno: ");
    nomes[1] = Console.ReadLine();
    Console.Write("Digte a primeira nota: ");
    notas1[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digte a segunda nota: ");
    notas2[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digte a terceira nota: ");
    notas3[1] = Convert.ToDouble(Console.ReadLine());

    double[] media = new double[nomes.Length];

    media[0] = (notas1[0] + notas2[0] + notas3[0])/ 3;
    media[1] = (notas1[1] + notas2[1] + notas3[1]) /3;

    Console.WriteLine(nomes[0]+ " média foi: " + media[0]);
    if (media[0] >= 7)
    {
        Console.WriteLine(nomes[0] +"está aprovado");
    }
    else
        Console.WriteLine(nomes[0] + " está reprovado!");

    Console.WriteLine(nomes[1] + " média foi: " + media[1]);
    if (media[1] >= 7)
    {
        Console.WriteLine(nomes[1] + " está aprovado");
    }
    else
        Console.WriteLine(nomes[1] + " está reprovado!");
}
ExercicioVetor();