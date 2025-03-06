static void TamanhoString()
{
    string texto = "rodrigo ademar albino";
    int tamanho = texto.Length;

    Console.WriteLine("Seu texto é:" + texto);
    Console.WriteLine("O tamanho do texto é:" + tamanho);
}


static void SubstituirString()
{
    //string cpf = "099.746.989-32"; // Remover os pontos e o hifen do cpf
    //string cpfLimpo = cpf.Replace(".", "");
    //cpfLimpo = cpfLimpo.Replace("-", "");
    //Console.WriteLine("Seu cpf é:" + cpf);
    //Console.WriteLine("Seu novo cpf é:" + cpfLimpo);
    string valor = "R$ 4.000,99";//Valor que teria ficar seria 4000.99
    string valorNovo = valor.Replace(".", "");
    valorNovo = valorNovo.Replace(",", ".");
    valorNovo = valorNovo.Replace("R$ ", "");
    Console.WriteLine("seu valor é: " + valor);
    Console.WriteLine("seu valor novo é: " + valorNovo);


    Console.Write("Dinheiro entregue para pagamento: ");
    double pagamento = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
    Console.WriteLine(pagamento);
}


static void RemoverEspacoComeco()
{
    string nome = " marcos filho ";
    string nomeLimpo = nome.TrimStart();

    Console.WriteLine("'" + nome + "'");
    Console.WriteLine("'" + nomeLimpo + "'");
}

static void RemoverEspacoFim() {

    string nome = " marcos filho ";
    string nomeLimpo = nome.TrimEnd();

    Console.WriteLine("'" + nome + "'");
    Console.WriteLine("'" + nomeLimpo + "'");
}

static void RemoverEspacoComecoFim() {

    string nome = " marcos filho ";
    string nomeLimpo = nome.Trim();

    Console.WriteLine("'" + nome + "'");
    Console.WriteLine("'" + nomeLimpo + "'");
}

static void Maiusculo() {

    string nome = " Marcos Filho ";
    string texto = nome.ToUpper();

    Console.WriteLine("'" + nome + "'");
    Console.WriteLine("'" + texto + "'");
}

static void Minusculo() {
    string nome = " Marcos Filho ";
    string texto = nome.ToLower();

    Console.WriteLine("'" + nome + "'");
    Console.WriteLine("'" + texto + "'");
}

static void Contem() {
    string data = "12/09/1900";
    bool contemHifen = data.Contains("-");
    if(contemHifen == true)
    {
        Console.WriteLine("Data inválida");
    }
    else
    {
        Console.WriteLine("data valida");
    }
}
static void ComecaComTexto() {
    //A festa é somente para pessoas que o nome começa com Ana
    string nome = " Ana maria joaquina".Trim();
    Console.WriteLine(nome);
    //nome = nome.Trim();
    if (nome.ToLower().StartsWith("ana"))
    {
        Console.WriteLine("liberado a entrada pra festa");
    }
    else
    {
        Console.WriteLine("Não pode participar da festa");
    }
}

static void TerminaComTexto() {
    //A festa é somente para pessoas que termina com Joaquina
    string nome = " Ana maria joaquina".Trim();
    Console.WriteLine(nome);
    //nome = nome.Trim();
    if (nome.ToLower().EndsWith("joaquina"))
    {
        Console.WriteLine("liberado a entrada pra festa");
    }
    else
    {
        Console.WriteLine("Não pode participar da festa");
    }
}

static void ObterParteString() {

    string horaCompleta = "23:49:30";

    int hora = Convert.ToInt32(horaCompleta.Substring(0, 2));
    string minuto = horaCompleta.Substring(3, 2);
    string segundo = horaCompleta.Substring(6, 2);
    Console.WriteLine(hora);
    Console.WriteLine(minuto);
    Console.WriteLine(segundo);

}

static void QuebrarStringEmVetor() { }



TerminaComTexto();
