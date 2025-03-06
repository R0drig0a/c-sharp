
/*
 *---------------------------------------------- Lista 02 SE  -----------------------------------------------------------
 */
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

static void TempoEmpresa()
{

    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();

    Console.Write("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Quantos anos você trabalha na empresa:");
    int tempo = Convert.ToInt32(Console.ReadLine());
    double bonus = 0;
    if (tempo <= 1)
    {
        bonus = 150;
    }
    else if (tempo <= 3)
    {
        bonus = 3_000;

    }
    else if (tempo <= 7)
    {
        bonus = 5000;

    }
    else if (tempo <= 10)
    {
        bonus = 8000;

    }
    else
    {
        bonus = 15_000;

    }
    Console.Write("Você Recebeu de bônus de R$" + bonus);

}


static void Temperatura()
{
    Console.Write("Qual a temperatura : ");
    double temperatura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Qual o tipo da temperatura que deseja fazer a conversão, c = Celsius para Fahrenheit  ou f = Fahrenheit para Celsius: ");
    string tipoTemperatura = Console.ReadLine();

    if (tipoTemperatura == "c")
    {
        temperatura = (temperatura * 1.8) + 32;
        Console.WriteLine("Sua temperatura foi convertida para Fahrenheit com Sucesso: " + temperatura + "°F");


    }

    else if (tipoTemperatura == "f")
    {
        temperatura = (temperatura - 32) / 1.8;
        Console.WriteLine("Sua temperatura foi convertida para Celsius com Sucesso: " + temperatura + "°C");

    }
    else
    {
        Console.WriteLine("Caracter inválido!");
    }
}





static void IntervaloDeNumeros()
{
    Console.Write("Digite o numero: ");
    double numero = Convert.ToDouble(Console.ReadLine());

    if (numero >= -100 && numero <= 100)
    {
        Console.WriteLine("Seu número esta dentro do intervalo");
    }
    else
    {
        Console.WriteLine("Seu numero nao esta no intervalo");
    }
}



static void MediaAluno()
{

    Console.Write("Qual foi sua frequencia:");
    double frequencia = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a primeira nota: ");
    double nota1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
    double nota2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a terceira nota: ");
    double nota3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a quarta nota: ");
    double nota4 = Convert.ToDouble(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4) / 4;

    if (frequencia >= 75)
    {

        if (media < 5.0)
        {
            Console.WriteLine("Você está reprovado!" + "Sua média foi: " + media);
        }
        else if (media < 7)
        {
            Console.WriteLine("Você está em exame!" + "Sua média foi: " + media);

        }
        else
        {
            Console.WriteLine("Você está aprovado!" + "Sua média foi: " + media);
        }

    }
    else
    {
        Console.WriteLine("Voce está reprovado sua frequencia estava abaixo de 75!");
    }
}



static void CalcularPeso()
{
    Console.Write("Digite seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);
    if (imc < 17)
    {
        Console.WriteLine("Muito abaixo do peso Seu Imc é: " + imc);
    }
    else if (imc >= 17 && imc < 18.49)
    {
        Console.WriteLine("Abaixo do peso Seu Imc é: " + imc);
    }

    else if (imc >= 18.5 && imc < 24.99)
    {
        Console.WriteLine("Peso normal Seu Imc é: " + imc);
    }

    else if (imc >= 25 && imc < 29.99)
    {
        Console.WriteLine("Acima do peso Seu Imc é: " + imc);
    }
    else if (imc >= 30 && imc < 34.99)
    {
        Console.WriteLine("Obesidade 1 Seu Imc é: " + imc);
    }
    else if (imc >= 35 && imc < 39.99)
    {
        Console.WriteLine("Obesidade 2(severa) Seu Imc é: " + imc);
    }
    else
    {
        Console.WriteLine("Obesidade 3 (mórbida) Seu Imc é:" + imc);
    }
}




static void Letras()
{
    Console.Write("Digite uma letra: ");
    string letras = Console.ReadLine();

    if (letras == "a" || letras == "e" || letras == "i" || letras == "o" || letras == "u")
    {
        Console.WriteLine("Sua letra é uma vogal");

    }
    else if (letras == "b" || letras == "c" || letras == "d" || letras == "f" || letras == "g" || letras == "h" || letras == "j" ||
        letras == "k" || letras == "l" || letras == "m" || letras == "n" || letras == "p" || letras == "q" || letras == "r" || letras
        == "s" || letras == "t" || letras == "v" || letras == "w" || letras == "x" || letras == "y" || letras == "z")
    {
        Console.WriteLine("Sua letra  é uma consoante");
    }
    else
    {
        Console.WriteLine("O que você digitou não é uma letra");
    }
}



static void Mercado()
{
    Console.Write("Quantidade de produtos: ");
    int produto = Convert.ToInt32(Console.ReadLine());

    Console.Write("Valor do produto: ");
    double valorProduto = Convert.ToDouble(Console.ReadLine());

    double valorDaCompra = valorProduto * produto;
    Console.WriteLine("Sua compra foi de: " + valorDaCompra);


    Console.Write("Dinheiro entregue para pagamento: ");
    double pagamento = Convert.ToDouble(Console.ReadLine());

    if (pagamento == valorDaCompra)
    {
        Console.WriteLine("Compra feita com Sucesso!");
    }
    else if (pagamento > valorDaCompra)
    {
        double troco = pagamento - valorDaCompra;
        Console.WriteLine("Seu troco foi de: " + " " + "R$" + troco);
    }
    else
    {
        Console.WriteLine("Seu dinheiro não foi suficiente!");
    }

}

static void ConversaoTempo()
{
    Console.WriteLine("Conversão de medida: c= Celsius, f =Fahrenheit , k = Kelvin");
    Console.Write("Digite a unidade de medida de origem: ");
    string unidadeMedida = Console.ReadLine();

    Console.Write("Digite o valor: ");
    double valorMedida = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a unidade termica de destino: ");
    string unidadeDestino = Console.ReadLine();

    if (unidadeMedida == "c" && unidadeDestino == "k")
    {
        valorMedida = valorMedida + 273.15;
    }
    else if (unidadeMedida == "c" && unidadeDestino == "f")
    {
        valorMedida = (valorMedida * 1.8000) + 32.00;
    }
    else if (unidadeMedida == "k" && unidadeDestino == "c")
    {
        valorMedida = valorMedida - 273.15;
    }
    else if (unidadeMedida == "k" && unidadeDestino == "f")
    {
        valorMedida = (valorMedida - 273.15) * 1.8000 + 32.00;
    }
    else if (unidadeMedida == "f" && unidadeDestino == "c")
    {
        valorMedida = (valorMedida - 32) / 1.800;
    }
    else if (unidadeMedida == "f" && unidadeDestino == "k")
    {
        valorMedida = ((valorMedida - 32) / 1.800) + 273.15;
    }
    else
    {
        Console.WriteLine("Nenhuma unidade de medida escolhida corretamente");
        return;
    }

    Console.WriteLine("Sua unidade de media foi convertida com sucesso!" + " " + valorMedida);

}

static void SomaTriangulo()
{
    Console.Write("Digite o valor do lado A: ");
    double ladoA = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do lado B: ");
    double ladoB = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do lado C: ");
    double ladoC = Convert.ToDouble(Console.ReadLine());



    if (ladoA == ladoB && ladoB > ladoC || ladoA == ladoC && ladoA > ladoB || ladoB == ladoC && ladoB > ladoA)
    {
        double ladoAB = ladoA + ladoB;
        double ladoAC = ladoA + ladoC;
        double ladoBC = ladoB + ladoC;
        Console.WriteLine("Isso é um triângulo");
    }

    else if (ladoA != ladoB && ladoB != ladoC)
    {
        Console.WriteLine("Isso é um triângulo Escaleno!");
    }
    else if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("Isso é um triângulo Equilátero");
    }
}



static void Retangulo()
{
    Console.Write("Digite o primeiro valor: ");
    int lado1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    int lado2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o terceiro valor: ");
    int lado3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o quarto valor: ");
    int lado4 = Convert.ToInt32(Console.ReadLine());

    if (lado1 == lado3 && lado2 == lado4 && lado1 != lado2)
    {
        Console.WriteLine("Isso é um retângulo!");
    }
    else
    {
        Console.WriteLine("Isso não é um retângulo!");
    }
}



static void Quadrado()
{
    Console.Write("Digite o valor do primeiro lado:");
    double lado1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do segundo lado:");
    double lado2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do terceiro lado:");
    double lado3 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do quarto lado:");
    double lado4 = Convert.ToDouble(Console.ReadLine());

    if (lado1 == lado2 && lado2 == lado3 && lado3 == lado4)
    {
        Console.WriteLine("Isso é um quadrado!");
    }

    else
    {
        Console.WriteLine("Isso não é um quadrado!");
    }
}


static void DiariaHotel()
{
    Console.Write("Digite o dia da semana que deseja se hospedar: ");
    string dia = Console.ReadLine();

    double diaria = 120;

    double taxaServico = 0;

    if (dia == "domingo")
    {
        taxaServico = 12.09;
    }
    else if (dia == "segunda-feira")
    {
        taxaServico = 6.67;
    }

    else if (dia == "sábado")
    {
        taxaServico = 8.29;
    }
    else if (dia == "terça-feira " || dia == "quarta-feira" || dia == "quinta-feira")
    {
        taxaServico = 4.50;
    }
    else if (dia == "sexta-feira")
    {
        taxaServico = 7.30;
    }
    double contaTotal = diaria + taxaServico;
    Console.WriteLine("Sua conta total foi de: " + " " + "R$" + contaTotal);
}




static void Maior()
{
    Console.Write("Digite o valor de a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor de b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine("A letra a é maior! " + a);
    }
    else
    {
        Console.WriteLine("A letra b é maior! " + b);
    }
}




static void ParImpar()
{
    Console.Write("Digite o primeiro numero: ");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    double soma = numero1 + numero2;

    if (soma % 2 == 1)
    {
        Console.WriteLine("O número " + soma + " é impar");
    }
    else
    {
        Console.WriteLine("O número " + soma + " é par");
    }
}



static void PositivoNegativoNeutro()
{
    Console.Write("Digite o valor de A: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor de B: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor de C: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double operacao = (a + c) - b;

    if (operacao > 0)
    {
        Console.WriteLine("O resultado " + operacao + " é Positivo");
    }
    else if (operacao == 0)
    {
        Console.WriteLine("O resultado " + operacao + " é Neutro");
    }
    else
    {
        Console.WriteLine("O resultado " + operacao + " é Negativo");
    }
}

static void ListaSeEx03Cardapio()
{
    /*
         * - Apresentar o seguinte cardápio para o usuário, solicitando o código do produto e
        armazenando o valor do produto de acordo com o código informado.
        Especificação Código Preço
        Cachorro quente 100 R$ 1,20
        Bauru simples 101 R$ 1,30
        Hamburger 103 R$ 1,20
        Pão com bolinho 104 R$ 1,30
        Refrigerante 105 R$ 1,00
        Deve ser apresentado o cardápio para o usuário 4 vezes e o mesmo escolherá quatro vezes
        o código do produto desejado. Após isto deverá apresentar o valor total do pedido.
    */

    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Produto                     | Código                  | Preço                             |");
    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Cachorro quente             | 100                     |R$ 1,20                            |");
    Console.WriteLine("| Bauru simples               | 101                     |R$ 1,30                            |");
    Console.WriteLine("| Hamburger                   | 103                     |R$ 1,20                            |");
    Console.WriteLine("| Pão com bolinho             | 104                     |R$ 1,30                            |");
    Console.WriteLine("| Refrigerante                | 105                     |R$ 1,00                            |");

    Console.Write("Digite o codigo do produto que deseja: ");
    int codigo = Convert.ToInt32(Console.ReadLine());

    double preco = 0;
    if (codigo == 100)
    {
         preco = 1.20;
    }
    else if (codigo == 101 )
    {
         preco = 1.30;
    }
    else if (codigo == 103)
    {
         preco = 1.20;
    }
    else if (codigo == 104)
    {
         preco = 1.30;
    }
    else if (codigo == 105)
    {
         preco = 1.00;
    }
    else
    {
        Console.WriteLine("Nenhum item da lista foi escolhido");
    }

    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Produto                     | Código                  | Preço                             |");
    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Cachorro quente             | 100                     |R$ 1,20                            |");
    Console.WriteLine("| Bauru simples               | 101                     |R$ 1,30                            |");
    Console.WriteLine("| Hamburger                   | 103                     |R$ 1,20                            |");
    Console.WriteLine("| Pão com bolinho             | 104                     |R$ 1,30                            |");
    Console.WriteLine("| Refrigerante                | 105                     |R$ 1,00                            |");


    Console.Write("Digite o codigo do produto que deseja: ");
    int codigo2 = Convert.ToInt32(Console.ReadLine());

    double preco2 = 0;

    if (codigo2 == 100)
    {
         preco2 = 1.20;
    }
    else if (codigo2 == 101)
    {
         preco2 = 1.30;
    }
    else if (codigo2 == 103)
    {
         preco2 = 1.20;
    }
    else if (codigo2 == 104)
    {
         preco2 = 1.30;
    }
    else if (codigo2 == 105)
    {
         preco2 = 1.00;
    }
    else
    {
        Console.WriteLine("Nenhum item da lista foi escolhido");
    }

    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Produto                     | Código                  | Preço                             |");
    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Cachorro quente             | 100                     |R$ 1,20                            |");
    Console.WriteLine("| Bauru simples               | 101                     |R$ 1,30                            |");
    Console.WriteLine("| Hamburger                   | 103                     |R$ 1,20                            |");
    Console.WriteLine("| Pão com bolinho             | 104                     |R$ 1,30                            |");
    Console.WriteLine("| Refrigerante                | 105                     |R$ 1,00                            |");

    Console.Write("Digite o codigo do produto que deseja: ");
    int codigo3 = Convert.ToInt32(Console.ReadLine());

    double preco3 = 0;

    if (codigo3 == 100)
    {
         preco3 = 1.20;
    }
    else if (codigo3 == 101)
    {
         preco3 = 1.30;
    }
    else if (codigo3 == 103)
    {
         preco3 = 1.20;
    }
    else if (codigo3 == 104)
    {
         preco3 = 1.30;
    }
    else if (codigo3 == 105)
    {
         preco3 = 1.00;
    }
    else
    {
        Console.WriteLine("Nenhum item da lista foi escolhido");
    }


    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Produto                     | Código                  | Preço                             |");
    Console.WriteLine("|-------------------------------------------------------------------------------------------|");
    Console.WriteLine("| Cachorro quente             | 100                     |R$ 1,20                            |");
    Console.WriteLine("| Bauru simples               | 101                     |R$ 1,30                            |");
    Console.WriteLine("| Hamburger                   | 103                     |R$ 1,20                            |");
    Console.WriteLine("| Pão com bolinho             | 104                     |R$ 1,30                            |");
    Console.WriteLine("| Refrigerante                | 105                     |R$ 1,00                            |");


    Console.Write("Digite o codigo do produto que deseja: ");
    int codigo4 = Convert.ToInt32(Console.ReadLine());

    double preco4 = 0;

    if (codigo4 == 100)
    {
         preco4 = 1.20;
    }
    else if (codigo4 == 101)
    {
         preco4 = 1.30;
    }
    else if (codigo4 == 103)
    {
         preco4 = 1.20;
    }
    else if (codigo4 == 104)
    {
         preco4 = 1.30;
    }
    else if (codigo4 == 105)
    {
         preco4 = 1.00;
    }
    else
    {
        Console.WriteLine("Nenhum item da lista foi escolhido");
    }

    double contaTotal = preco + preco2 + preco3 + preco4;

    Console.WriteLine("Sua conta foi: " + "R$" + contaTotal);

}
/*
 *---------------------------------------------- Lista 01 Leia  -----------------------------------------------------------
 */

static void SucessorAntecessor()
{
    Console.Write("Digite um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    int antecessor = numero - 1;
    int sucessor = numero + 1;

    Console.WriteLine("Seu numero é: " + numero);
    Console.WriteLine("O Antecessor é: " + antecessor);
    Console.WriteLine("O Sucessor é: " + sucessor);
}

static void Operacoes()
{
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    double soma = numero1 + numero2;
    double subtracao = numero1 - numero2;
    double multiplicacao = numero1 * numero2;
    double divisao = numero1 / numero2;

    Console.WriteLine("O resultado da soma foi: " + soma);
    Console.WriteLine("O resultado da subtração foi: " + subtracao);
    Console.WriteLine("O resultado da multiplicação foi: " + multiplicacao);
    Console.WriteLine("O resultado da divisão foi: " + divisao);

}

static void Tabuada()
{
    Console.Write("Digite o numero da tabuada que deseja ver: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    //2 x 0 = 0;
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 0);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 1);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 2);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 3);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 4);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 5);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 6);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 7);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 8);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 9);
    Console.WriteLine(numero + " x " + 0 + " = " + numero * 10);

}

static void FinanciamentoCarro()
{
    Console.Write("Digite o nome do seu  carro:");
    string carro = Console.ReadLine();

    Console.Write("Qual o valor do carro: ");
    double valorCarro = Convert.ToDouble(Console.ReadLine());

    Console.Write("Qual o valor de cada parcela:");
    double parcelaCarro = Convert.ToDouble(Console.ReadLine());

    Console.Write("Quantidade de meses que o carro foi financado: : ");
    int mesesFinanciamento = Convert.ToInt32(Console.ReadLine());

    double valorTotalFinanciamento = parcelaCarro * mesesFinanciamento;
    double diferenca = valorTotalFinanciamento - valorCarro;

    Console.WriteLine("O nome do carro é:" + carro);
    Console.WriteLine("O valor do carro é:" + valorCarro);
    Console.WriteLine("A parcela do carro é:" + parcelaCarro);
    Console.WriteLine("Quantidade de parcelas:" + mesesFinanciamento);
    Console.WriteLine("O valor total do financiamento é:" + valorTotalFinanciamento);
    Console.WriteLine("A diferenca do valor total do financiamento foi de:" + diferenca);

}

static void MediaEscolares()
{
    Console.Write("Digite a primeira nota:");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a segunda nota:");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a terceira nota:");
    double nota3 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a qaurta nota:");
    double nota4 = Convert.ToDouble(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4) / 4;

    Console.WriteLine("Sua média foi:" + media);
}

static void Arvore()
{
    Console.WriteLine(" " +  "     * ");

    Console.WriteLine(" " +  "    ***");

    Console.WriteLine(" " + "   *****");

    Console.WriteLine(" " +  "  *******");

    Console.WriteLine(" " +  " *********");

    Console.WriteLine(" " +"***********");
}

static void Despesas()
{
    Console.Write("Digite o valor da conta de luz: ");
    double contaEnergia = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor da conta de agua: ");
    double contaAgua = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor da conta da NET: ");
    double contaNet = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor da conta da Vivo: ");
    double contaVivo = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor da conta da Oi: ");
    double contaOi = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do IPTU: ");
    double contaIptu = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do IPVA: ");
    double contaIpva = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor do seguro do carro: ");
    double contaSeguroCarro = Convert.ToDouble(Console.ReadLine());

    double valorTelefone = contaNet + contaVivo + contaOi;
    double valorImpostos = contaIptu + contaIpva;
    double valorRestante = contaEnergia + contaAgua + contaSeguroCarro;
    double valorTotal = contaEnergia + contaAgua + contaNet + contaVivo + contaOi + contaIptu + contaIpva + contaSeguroCarro;

    Console.WriteLine("O valor dos telefenes deu: " + "R$" + valorTelefone);
    Console.WriteLine("O valor dos impostos deu: " + "R$" + valorImpostos);
    Console.WriteLine("O valor restante deu: " + "R$" + valorRestante);
    Console.WriteLine("O valor total deu: " + "R$" + valorTotal);
}

static void NumeroInvertidos()
{
    Console.Write("Digite o primeiro numero: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Os numeros que você digitou foi: " + numero1 + "| |" + numero2);

    Console.WriteLine("Agora com valores invertidos:" + numero2 + "| |" + numero1);
}

static void Nascimento()
{
    Console.Write("Digite o seu ano de nascimento: ");
    int nascimento = Convert.ToInt32(Console.ReadLine());

    double anoAtual = 2024;
    double idade = anoAtual - nascimento;

    Console.WriteLine("Sua idade é ou irá fazer:" + idade);
}

static void ContagemNascimento()
{
    Console.Write("Digite o dia em que nasceu:");
    int dia = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o mes  em que nasceu:");
    string mes = Console.ReadLine();

    Console.Write("Digite o ano em que nasceu:");
    double ano = Convert.ToInt32(Console.ReadLine());

    double anoAtualmente = 2024;
    double diasTotais = 365;
    double idade = anoAtualmente - ano;

    double diasVivo = idade * diasTotais;
    double anosVivo = idade;
    double mesesVivo = idade * 12;
    double horasVivo = diasVivo * 24;
    double minutosVivo = horasVivo * 60;
    double segundosVivo = minutosVivo * 60;


    Console.WriteLine("Dias Vivo:" + diasVivo);
    Console.WriteLine("Quantidade de anos vivos é:" + idade);
    Console.WriteLine("Quantidade de meses vivos é:" + mesesVivo);
    Console.WriteLine("Quantidade de horas vivos é:" + horasVivo);
    Console.WriteLine("Quantidade de minutos vivos é:" + minutosVivo);
    Console.WriteLine("Quantidade de segundos vivos é:" + segundosVivo);



}


static void Exercicio()
{
    string data = "25/12/2024" ;

    int dia = Convert.ToInt32(data.Substring(0, 2));
    int mes = Convert.ToInt32(data.Substring(3, 2));
    int ano = Convert.ToInt32(data.Substring(6, 4));

    Console.WriteLine(dia);
    Console.WriteLine(mes);
    Console.WriteLine(ano);
}

static void Exercico2()
{
   
    string horas = "23:59:10";
    string[] horasPartes = horas.Split(":");
    string hora = horasPartes[0];
    string minutos = horasPartes[1];
    string segundos = horasPartes[2];


    Console.WriteLine(hora);
    Console.WriteLine(minutos);
    Console.WriteLine(segundos);
}

static void Contas()
{
    Console.Write("Digite a média de litros engeridos por dia:");
    double litrosDia = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite quantidade e anos:");
    int anos = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor pago pela agua:");
    double conta = Convert.ToDouble(Console.ReadLine());

    double litrosIngeridoAno = litrosDia * 365 * anos;
    Console.WriteLine(litrosIngeridoAno);

    double valorTotal = litrosIngeridoAno * conta;
    Console.WriteLine(valorTotal);
}
