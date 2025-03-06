// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo de Conversão");

string numeroTexto = "1";
int numero = Convert.ToInt32( "2");
//int numero = Convert.ToInt32( numeroTexto);
Console.WriteLine(numero);

string numeroTexto2 = "2,68";
double numero2 = Convert.ToDouble(numeroTexto2);
Console.WriteLine(numero2);

string empregadoTexto = "TRUE";
bool empregado = Convert.ToBoolean (empregadoTexto);
Console.WriteLine(empregado);


