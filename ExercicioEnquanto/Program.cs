

static void Loja()
{
    int indice = 0;

    while (indice < 13)
    {
        Console.Write("Digite o nome das roupas: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço das roupas:");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nome da roupa que dgitou: " + nome);
        Console.WriteLine("O preço da roupa é: " + preco);

        indice = indice + 1;

    }
}

static void DigiteFim()
{
    string nome = "";
    while (nome != "fim")
    {
        Console.Write("Digite seu nome (digte fim para encerrar): ");
        nome = Console.ReadLine();
    }
    Console.Write("Você digitou fim! ");

}

static void IdadeMaior()
{
    int idade = 128;
    while (idade <= 128)
    {
        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("A idade que você digitou foi superior a 128: ");

}

static void CalcularPeso()
{
    int indice = 0;
    Console.WriteLine("Quantas pessoas foram entrevistadas: ");
    int pessoasEntrevistadas = Convert.ToInt32(Console.ReadLine());

    while (indice < pessoasEntrevistadas)
    {
        Console.Write("Digite seu peso:");
        double peso = Convert.ToDouble(Console.ReadLine());

        if (peso < 0 || peso > 300)
        {
            Console.WriteLine("Seu peso está abaixo de 0 ou muito acima de 300");
        }

        Console.WriteLine("Aperte algo pra continuar...");
        Console.ReadKey();
        Console.Clear();

        indice = indice + 1;

    }

    Console.WriteLine("O total de pessoa que informaram o peso:" + indice);
}

static void CadastrarCarro()
{
    Console.Write("Digite a quantidade de carro que deseja cadastrar:");
    int quantidadeCarro = Convert.ToInt32(Console.ReadLine());
    Console.Clear();


    int somaAno = 0;
    double somaValor = 0;
    int indice = 0;
    int quantidadeCarrosG = 0, quantidadeCarrosA = 0;
    while (indice < quantidadeCarro)
    {
        Console.Write("Digite o modelo do carro:");
        string nomeCarro = Console.ReadLine();

        Console.Write("Digite o valor do carro: ");
        double valorCarro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o ano do carro:");
        int anoCarro = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        somaAno = somaAno + anoCarro;
        somaValor = somaValor + valorCarro;

        if (nomeCarro.ToUpper().StartsWith("G"))
        {
            quantidadeCarrosG = quantidadeCarrosG + 1;
        }
        if (nomeCarro.ToUpper().StartsWith("A"))
        {
            quantidadeCarrosA = quantidadeCarrosA + 1;
        }

        indice = indice + 1;
    }
    double mediaAnoCarro = somaAno / quantidadeCarro;
    double mediaValorCarro = somaValor / quantidadeCarro;

    Console.WriteLine("Media de ano dos carros:" + mediaAnoCarro);
    Console.WriteLine("Media de valores dos carros:" + mediaValorCarro);
    Console.WriteLine("Carros que começam com a letra G: " + quantidadeCarrosG);
    Console.WriteLine("Carros que começam com a letra A: " + quantidadeCarrosA);

}

static void Tabuada()
{
    /**
     * Solicite um número e apresente a tabuada do mesmo até 1000
     */

    int indice = 0;
    Console.Write("Digite o numero que deseja ver a tabuada:");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (indice <= 100)
    {
        // 5 x 0 = 0
        //5 x 1 = 5


        Console.WriteLine(numero + " x " + indice + " = " + indice * numero);


        indice = indice + 1;
    }
}

static void SucessorAntecessor()
{
    /*
     * 
     * Solicite um número e apresente:
    ● Os 50 números antecessores pares;
    ● Os 50 números sucessores ímpares
     */

    int indice = 0;

    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    int antecessor = numero;
    int sucessor = numero;

    while (indice < 10)
    {
        if ((antecessor - 1) % 2 == 0)
        {
            Console.WriteLine("Antcessor par: " + (antecessor - 1));
            indice = indice + 1;
        }



        antecessor = antecessor - 1;
    }

    indice = 0;
    while (indice < 10)
    {
        sucessor = sucessor + 1;

        if (sucessor % 2 == 1 || sucessor % 2 == -1)
        {
            Console.WriteLine("Sucessor impar: " + sucessor);
            indice = indice + 1;
        }

    }
}

static void Calcular()
{

    Console.WriteLine("\n1-somar, \n2-Subtrair, \n3-multiplicação, \n4-divisao,\n5-sair");

    Console.Write("Digite um numero:");
    int opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    while (opcao != 5 || opcao == 0)
    {
        Console.WriteLine("Digite o primeiro numero: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo  numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;
        if (opcao == 1)
        {
            resultado = numero + numero2;
        }
        else if (opcao == 2)
        {
            resultado = numero - numero2;
        }
        else if (opcao == 3)
        {
            resultado = numero * numero2;
        }
        else if (opcao == 4)
        {
            resultado = numero / numero2;
        }
        Console.WriteLine("O resultado foi: " + resultado);

        Console.WriteLine("Deseja fazer outra operação? 0-sim ou 5-não");
        int simNao = Convert.ToInt32(Console.ReadLine());

        if (simNao == 0)
        {
            Console.WriteLine("\n1-somar, \n2-Subtrair, \n3-multiplicação, \n4-divisao,\n5-sair");

            Console.Write("Digite um numero:");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        else if (simNao == 5)
            break;

        Console.Clear();
    }

}

static void ComandaPadaria()
{

    double totalPedidos = 0;
    int produtosConsumidos = 0;
    int opcao = 0;
    int quantidadeBolos = 0;
    int quantidadeDoces = 0;
    int quantidadeSanduiches = 0;
    int quantidadePizzas = 0;


    while (opcao != 16)
    {
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|     Código   |      Tipo        |               Nome                  |        Valor               |");
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("| 1            | Bolos            | Bolo Brigadeiro                              |  R$ 29,50         |");
        Console.WriteLine("| 2            | Bolos            | Bolo Floresta Negra                          |  R$ 2,00          |");
        Console.WriteLine("| 3            | Bolos            | Bolo Leite com Nutella                       |  R$ 29,23         |");
        Console.WriteLine("| 4            | Bolos            | Bolo Mousse de Chocolate                     |  R$ 7,10          |");
        Console.WriteLine("| 5            | Bolos            | Bolo Nega Maluca                             |  R$ 19,33         |");
        Console.WriteLine("| 6            | Doces            | Bomba de Creme                               |  R$ 17,71         |");
        Console.WriteLine("| 7            | Doces            | Bomba de Morango                             |  R$ 4,82          |");
        Console.WriteLine("| 8            | Sanduíches       | Filé-Mignon com fritas e cheddar             |  R$ 21, 16        |");
        Console.WriteLine("| 9            | Sanduíches       | Hambúrguer com queijos, champignon e rúcula  |  R$ 12,70         |");
        Console.WriteLine("| 10           | Sanduíches       | Provolone com salame                         |  R$ 19,70         |");
        Console.WriteLine("| 11           | Sanduíches       | Vegetariano de berinjela                     |  R$ 28,22         |");
        Console.WriteLine("| 12           | Pizzas           | Calabresa                                    |  R$ 8,98          |");
        Console.WriteLine("| 13           | Pizzas           | Napolitana                                   |  R$ 0,42          |");
        Console.WriteLine("| 14           | Pizzas           | Peruana                                      |  R$ 18,36         |");
        Console.WriteLine("| 15           | Pizzas           | Portuguesa                                   |  R$ 27,50         |");
        Console.WriteLine("\n| 16                             SAIR                                                          ");

        Console.Write("\nO que você deseja? favor em formar com os códigos acima: ");
        int pedido = Convert.ToInt32(Console.ReadLine());

        double preco = 0;


        if (pedido == 1)
        {
            preco = preco + 29.50;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (pedido == 2)
        {
            preco = preco + 2.00;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (pedido == 3)
        {
            preco = preco + 29.23;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (pedido == 4)
        {
            preco = preco + 7.10;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (pedido == 5)
        {
            preco = preco + 19.33;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (pedido == 6)
        {
            preco = preco + 17.71;
            quantidadeDoces = quantidadeDoces + 1;
        }
        else if (pedido == 7)
        {
            preco = preco + 4.82;
            quantidadeDoces = quantidadeDoces + 1;
        }
        else if (pedido == 8)
        {
            preco = preco + 21.16;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (pedido == 9)
        {
            preco = preco + 12.70;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (pedido == 10)
        {
            preco = preco + 19.70;
            produtosConsumidos = produtosConsumidos + 1;
        }
        else if (pedido == 11)
        {
            preco = preco + 28.22;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (pedido == 12)
        {
            preco = preco + 8.98;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (pedido == 13)
        {
            preco = preco + 0.42;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (pedido == 14)
        {
            preco = preco + 18.36;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (pedido == 15)
        {
            preco = preco + 27.50;
            quantidadePizzas = quantidadePizzas + 1;
        }

        totalPedidos = totalPedidos + preco;
        produtosConsumidos = produtosConsumidos + 1;

        Console.WriteLine("Você deseja fazer outro pedido? 0-Sim 16-não");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (opcao > 16)
            Console.WriteLine("Código inválido!");
       

    }
    double mediaProdutos = totalPedidos / produtosConsumidos;
    Console.WriteLine("O valor total do pedido foi: " + totalPedidos);
    Console.WriteLine("Quantidade de produtos consumidos: " + produtosConsumidos);

    Console.WriteLine("Quantidade de bolos consumidos: " + quantidadeBolos);
    Console.WriteLine("Quantidade de doces consumidos: " + quantidadeDoces);
    Console.WriteLine("Quantidade de sanduiches consumidos: " + quantidadeSanduiches);
    Console.WriteLine("Quantidade de pizza consumidas: " + quantidadePizzas);
    Console.WriteLine("A média dos produtos: " + mediaProdutos);

}


static void SensoSelecao()
{
    double menorPeso = 99999999999;
    double maiorAltura = 0;
    int maiorNome = 0, menorNome = 9999999;
    int quantidadeSexoFeminino = 0, quantidadeSexoMasculino = 0;
    int menorQuantidadeDeCartaoAmarelosTomado = 99999, menorQuantidadeDeCartaoVermelhoTomado = 9999999; ;
    int maiorQuantidadeDeCartaoVermelhoTomado = 0, maiorQuantidadeDeCartaoAmareloTomado = 0;
    double maiorPeso = 0;
    int indice = 0;
    string nomeMenorQuantidadeDeCartaoAmareloTomado = "";
    string nomemenorPeso = "";
    string nomeMaiorAltura = "";
    string nomeMaior = "";
    string nomeMenor = "";
    string nomeMaiorPeso = "";
    string nomeMaiorquantidadeDeCartaoVermelhosTomado = "";
    string nomeMaiorquantidadeDeCartaoAmarelosTomado = "";
    string nomeMenorQuantidadeDeCartaoVermelhoTomado = "";
    while (indice <= 1)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu sexo:");
        string sexo = Console.ReadLine();

        Console.Write("Digite seu altura:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de gols marcados:");
        int golsMarcados = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantidade de cartões amarelos recebidos: ");
        int cartaoAmarelo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantidade de cartões vermelhos recebidos: ");
        int cartaoVermelho = Convert.ToInt32(Console.ReadLine());
        Console.Clear();



        if (peso < menorPeso)
        {
            menorPeso = peso;
            nomemenorPeso = nome;
        }
        if (peso > maiorPeso)
        {
            maiorPeso = peso;
            nomeMaiorPeso = nome;
        }

        if (altura > maiorAltura)
        {
            maiorAltura = altura;
            nomeMaiorAltura = nome;
        }

        if (nome.Length > maiorNome)
        {
            maiorNome = nome.Length;
            nomeMaior = nome;
        }
        if (nome.Length < menorNome)
        {
            menorNome = nome.Length;
            nomeMenor = nome;
        }

        if (sexo.ToUpper().StartsWith("M"))
        {
            quantidadeSexoMasculino = quantidadeSexoMasculino + 1;
        }
        if (sexo.ToUpper().StartsWith("F"))
        {
            quantidadeSexoFeminino = quantidadeSexoFeminino + 1;
        }

        if (cartaoAmarelo < menorQuantidadeDeCartaoAmarelosTomado)
        {
            menorQuantidadeDeCartaoAmarelosTomado = cartaoAmarelo;
            nomeMenorQuantidadeDeCartaoAmareloTomado = nome;
        }
        if (cartaoAmarelo > maiorQuantidadeDeCartaoAmareloTomado)
        {
            maiorQuantidadeDeCartaoAmareloTomado = cartaoAmarelo;
            nomeMaiorquantidadeDeCartaoAmarelosTomado = nome;
        }


        if (cartaoVermelho > maiorQuantidadeDeCartaoVermelhoTomado)
        {
            maiorQuantidadeDeCartaoVermelhoTomado = cartaoVermelho;
            nomeMaiorquantidadeDeCartaoVermelhosTomado = nome;
        }
        if (cartaoVermelho < menorQuantidadeDeCartaoVermelhoTomado)
        {
            menorQuantidadeDeCartaoVermelhoTomado = cartaoVermelho;
            nomeMenorQuantidadeDeCartaoVermelhoTomado = nome;

        }

        indice = indice + 1;
    }
    /*
     * TODO: Fazr uma variavel para receber o nome onde esta os cartões e arrumar em ordem
     */
    Console.WriteLine("O menor peso do elenco: " + menorPeso);
    Console.WriteLine("A maior altura do elenco:  " + maiorAltura);
    Console.WriteLine("Quantidade de pessoas do sexo masculino  do elenco: " + quantidadeSexoMasculino);
    Console.WriteLine("Quantidade de pessoas do sexo feminino  do elenco:  " + quantidadeSexoFeminino);
    Console.WriteLine("A menor quantidade de cartões amarelo do elenco: " + menorQuantidadeDeCartaoAmarelosTomado);
    Console.WriteLine("O menor nome do elenco " + menorNome);
    Console.WriteLine("O maior peso do elenco: " + maiorPeso);
    Console.WriteLine("A maior quantidade de cartões vermelhos do elenco: " + maiorQuantidadeDeCartaoVermelhoTomado);
    Console.WriteLine("A maior quantidade de cartões amarelos do elenco: " + maiorQuantidadeDeCartaoAmareloTomado);
    Console.WriteLine("A menor quantidade de cartões vermelhos do elenco: " + menorQuantidadeDeCartaoVermelhoTomado);
}

/*
 * --------------------------------------------------------------Exercicio com For--------------------------------------------------------------------------------
 */

static void Exercicio1ComFor()
{
    for (int indice = 0; indice < 13; indice = indice + 1)
    {
        Console.Write("Digite o nome da roupa: ");
        string nomeRoupa = Console.ReadLine();

        Console.Write("Digite o preço da roupa: ");
        double precoRoupa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Aperte alguma tecla pra cadastrar nova roupa!");
        Console.ReadKey();
        Console.Clear();
    }
}

static void Exercicio2ComFor()
{
    for (string nome = ""; nome.ToUpper() != "FIM";)
    {
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

    }
}

static void Exercico3ComFor()
{
    for(int idade = 0; idade <= 128;)
    {
        Console.Write("Digite sua idade:");
         idade = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("A idade que digitou superou a 128!");
}

static void Exercicio4ComFor()
{
    for (double peso = 0; peso >= 0 && peso <= 300;)
    {
        Console.Write("Digite seu peso: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Aperte alguma tecla para digitar seu peso de novo!");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine("Peso invalido!");
}

static void Exercicio6ComFor()
{
    double valorTotal = 0;
    double valorProduto = 0;
    int quantidadeProduto = 0;
    double valorDesconto = 0;
    for (string nome = ""; nome != "sair";)
    {
        Console.Write("Digite o nome do produto:");
        nome = Console.ReadLine();
        if (nome == "sair")
            break;

        Console.Write("Digite o valor do produto:");
         valorProduto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de produtos:");
         quantidadeProduto = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Você quer comprar mais alguma coisa? sim ou sair");
        nome = Console.ReadLine();
        Console.Clear();

        valorTotal = valorTotal+ (valorProduto * quantidadeProduto);
        
    }
   
    valorDesconto = valorTotal * 0.05;
    valorTotal = valorTotal - valorDesconto;
    Console.WriteLine("O valor do desconto foi:" + "R$" + valorDesconto);
    Console.WriteLine("O valor total das sua compra foi:" + "R$" + valorTotal);
}

static void Exercicio7ComFor() 
{
    double desconto = 150;
    double contaTotal = 0;
    for(int quantidadeProdutos = 0; quantidadeProdutos < 5;)
    {
        Console.Write("Digite o nome do produto:");
        string nomeProduto = Console.ReadLine();

        Console.Write("Digite o valor do produto:");
        double valorProduto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de produtos:");
        quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

        contaTotal = contaTotal + (valorProduto * quantidadeProdutos);
    }
    contaTotal = contaTotal - 150;
    Console.WriteLine("Você ultrapassou o limite de prdoutos!");
    Console.WriteLine("Sua conta deu: " + contaTotal );
}

//static void Exercici8ComFor()
//{
//    for (int indice = 0; indice < 100;) 
//    {
//        Console.WriteLine("Digite o numero que deseja ver a tabuada: ");
//        int numero = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine(numero + " x " + indice + " = " + indice * numero);
//        indice = indice + 1;
//    }
//}

static void Exercicio11ComFor()
{
    double operacoes = 0;
    for (int numero = 0; numero < 5;)
    {
        Console.WriteLine("\n1-somar, \n2-Subtrair, \n3-multiplicação, \n4-divisao,\n5-sair");

        Console.Write("Digite aqui qual operação você deseja fazer:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 5)
        {
            Console.WriteLine("Até mais!!");
            break;
        }
          

        Console.Write("Digite o primeiro numero:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero:");
        double numero2 = Convert.ToDouble(Console.ReadLine());


        if (numero == 1)
        {
            operacoes = numero1 + numero2;

        }
        else if(numero == 2)
        {
            operacoes = numero1 - numero2;
        }
        else if (numero == 3)
        {
            operacoes = numero1 * numero2;
        }
        else if (numero == 4)
        {
            operacoes = numero1 / numero2;
        }
        
        Console.Clear();

        Console.WriteLine("O seu resultado foi: " + operacoes);
       
        Console.WriteLine("Você deseja fazer outra operação? 0-Sim ou 5-Sair");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 5)
            Console.WriteLine("Até mais!!");

    }
   
}

static void Exercicio12ComFor()
{
    double preco = 0;
    int quantidadeBolos = 0;
    int quantidadeDoces = 0;
    int quantidadeSanduiches = 0;
    int quantidadePizzas = 0;
    double totalComanda = 0;
    int quantidadeDeProdutosConsumidos = 0;
    for (int codigo = 0; codigo < 16;)
    {
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("|     Código   |      Tipo        |               Nome                  |        Valor               |");
        Console.WriteLine("|----------------------------------------------------------------------------------------------------|");
        Console.WriteLine("| 1            | Bolos            | Bolo Brigadeiro                              |  R$ 29,50         |");
        Console.WriteLine("| 2            | Bolos            | Bolo Floresta Negra                          |  R$ 2,00          |");
        Console.WriteLine("| 3            | Bolos            | Bolo Leite com Nutella                       |  R$ 29,23         |");
        Console.WriteLine("| 4            | Bolos            | Bolo Mousse de Chocolate                     |  R$ 7,10          |");
        Console.WriteLine("| 5            | Bolos            | Bolo Nega Maluca                             |  R$ 19,33         |");
        Console.WriteLine("| 6            | Doces            | Bomba de Creme                               |  R$ 17,71         |");
        Console.WriteLine("| 7            | Doces            | Bomba de Morango                             |  R$ 4,82          |");
        Console.WriteLine("| 8            | Sanduíches       | Filé-Mignon com fritas e cheddar             |  R$ 21, 16        |");
        Console.WriteLine("| 9            | Sanduíches       | Hambúrguer com queijos, champignon e rúcula  |  R$ 12,70         |");
        Console.WriteLine("| 10           | Sanduíches       | Provolone com salame                         |  R$ 19,70         |");
        Console.WriteLine("| 11           | Sanduíches       | Vegetariano de berinjela                     |  R$ 28,22         |");
        Console.WriteLine("| 12           | Pizzas           | Calabresa                                    |  R$ 8,98          |");
        Console.WriteLine("| 13           | Pizzas           | Napolitana                                   |  R$ 0,42          |");
        Console.WriteLine("| 14           | Pizzas           | Peruana                                      |  R$ 18,36         |");
        Console.WriteLine("| 15           | Pizzas           | Portuguesa                                   |  R$ 27,50         |");
        Console.WriteLine("\n| 16                             SAIR                                                          ");

        Console.Write("\nO que você deseja? favor em formar com os códigos acima: ");
         codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo == 1)
        {
            preco = preco + 29.50;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (codigo == 2)
        {
            preco = preco + 2.00;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (codigo == 3)
        {
            preco = preco + 29.23;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (codigo == 4)
        {
            preco = preco + 7.10;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (codigo == 5)
        {
            preco = preco + 19.33;
            quantidadeBolos = quantidadeBolos + 1;
        }
        else if (codigo == 6)
        {
            preco = preco + 17.71;
            quantidadeDoces = quantidadeDoces + 1;
        }
        else if (codigo == 7)
        {
            preco = preco + 4.82;
            quantidadeDoces = quantidadeDoces + 1;
        }
        else if (codigo == 8)
        {
            preco = preco + 21.16;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (codigo == 9)
        {
            preco = preco + 12.70;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (codigo == 10)
        {
            preco = preco + 19.70;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (codigo == 11)
        {
            preco = preco + 28.22;
            quantidadeSanduiches = quantidadeSanduiches + 1;
        }
        else if (codigo == 12)
        {
            preco = preco + 8.98;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (codigo == 13)
        {
            preco = preco + 0.42;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (codigo == 14)
        {
            preco = preco + 18.36;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (codigo == 15)
        {
            preco = preco + 27.50;
            quantidadePizzas = quantidadePizzas + 1;
        }
        else if (codigo >= 16)
        {
            Console.WriteLine("Ate mais!!");
            break;
        }
        totalComanda = totalComanda + preco;
        quantidadeDeProdutosConsumidos = quantidadeDeProdutosConsumidos + 1;
    }
  
}

static void Exercicio13ComFor()
{
    double menorPeso = 999999999;
    double maiorPeso = 0;
    double maiorAltura = 0;
    int maiorNome = 0;
    int menorNome = 999999;
    int quantidadeSexoM = 0;
    int quantidadeSexoF = 0;
    int maiorQuantidadeDeCartaoVermelho = 0;
    int menorQuantidadeDeCartaoVermelho = 99999;
    int maiorQuantidadeDeCartaoAmarelo = 0;
    int menorQuantidadeDeCartaoAmarelo = 999999;

    string nomeMenorPeso = "";
    string nomeMaiorPeso = "";
    string nomeMaiorAltura = "";
    string nomeMaior = "";
    string nomeMenor = "";
    string nomeMaiorQuantidadeDeCartaoVermelho = "";
    string nomeMenorQuantidadeDeCartaoVermelho = "";
    string nomeMaiorQuantidadeDeCartaoAmarelo = "";
    string nomeMenorQuantidadeDeCartaoAmarelo = "";

    for (int indice = 0; indice < 22; indice = indice + 1)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Digite sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de gols marcados: ");
        int golsMarcados = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
        int quantidadeAmarelo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a quantidade de cartões vermelho recebidos: ");
        int quantidadeVermelho = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Aperte alguma tecla para continuar cadastrando...");
        Console.ReadKey();
        Console.Clear();

        if (peso < menorPeso)
        {
            menorPeso =  peso;
            nomeMenorPeso = nome;
        }
        if (peso > maiorPeso)
        {
            maiorPeso =  peso;
            nomeMaiorPeso = nome;
        }

        if (altura > maiorAltura)
        {
            maiorAltura =  altura;
            nomeMaiorAltura = nome;
        }

        if (nome.Length < menorNome)
        {
            menorNome = nome.Length;
            nomeMenor = nome;
        }
        if (nome.Length > maiorNome)
        {
            maiorNome = nome.Length;
            nomeMaior = nome;
        }

        if (sexo.ToUpper().StartsWith("F"))
        {
            quantidadeSexoF = quantidadeSexoF + 1;
        }
        if (sexo.ToUpper().StartsWith("M"))
        {
            quantidadeSexoM = quantidadeSexoM + 1;
        }
        if (quantidadeAmarelo < menorQuantidadeDeCartaoAmarelo)
        {
            menorQuantidadeDeCartaoAmarelo = quantidadeAmarelo;
            nomeMenorQuantidadeDeCartaoAmarelo = nome;
        }
        if (quantidadeAmarelo > maiorQuantidadeDeCartaoAmarelo)
        {
            maiorQuantidadeDeCartaoAmarelo = quantidadeAmarelo;
            nomeMaiorQuantidadeDeCartaoAmarelo = nome;
        }

        if (quantidadeVermelho < menorQuantidadeDeCartaoVermelho)
        {
            menorQuantidadeDeCartaoVermelho = quantidadeVermelho;
            nomeMenorQuantidadeDeCartaoVermelho = nome;
        }
        if (quantidadeVermelho > maiorQuantidadeDeCartaoVermelho)
        {
            maiorQuantidadeDeCartaoVermelho = quantidadeVermelho;
            nomeMaiorQuantidadeDeCartaoVermelho = nome;
        }
    }

    Console.WriteLine("O jogador(@) com menor peso do elenco é: " + nomeMenorPeso + " com: " + menorPeso);
    Console.WriteLine("O jogador(@) com maior altura é: " + nomeMaiorAltura + " com: " + maiorAltura);
    Console.WriteLine("O jogador(@) com maior nome é:" + nomeMaior + " com: " + maiorNome );
    Console.WriteLine("Quantidade de jogadoras: " + quantidadeSexoF);
    Console.WriteLine("Quantidade de jogadores: " + quantidadeSexoM);
    Console.WriteLine("O jogador(@) com menor quantidade de cartão amarelos recebidos é: "+ nomeMenorQuantidadeDeCartaoAmarelo+ " com: " + menorQuantidadeDeCartaoAmarelo);
    Console.WriteLine("O jogador(@) com menor nome é: "+nomeMenor+ " com: " + menorNome);
    Console.WriteLine("O jogador(@) com maior peso é: "+ nomeMaiorPeso + " com: " + maiorPeso);
    Console.WriteLine("O jogador(@) com maior quantidade de cartão vermelho tomado é: "+ nomeMaiorQuantidadeDeCartaoVermelho +" com: " + maiorQuantidadeDeCartaoVermelho);
    Console.WriteLine("O jogador(@) com maior quantidade de amarelo recebido é: "+ nomeMaiorQuantidadeDeCartaoAmarelo+ " com: " + maiorQuantidadeDeCartaoAmarelo);
    Console.WriteLine("O jogador(@) com menor cartão vermelho recebido é: "+ nomeMenorQuantidadeDeCartaoVermelho+ " com: "+ menorQuantidadeDeCartaoVermelho);
}
Exercicio13ComFor();