// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Rodrigo");
Console.WriteLine("Texto" + " " + "Texto2");
Console.WriteLine("\nSoma:" + (2+2));
Console.WriteLine("Subtração:" + (2 - 2));
Console.WriteLine("Multiplicação:" + (2 * 2));
Console.WriteLine("Divisão:" + (2 / 2));
Console.WriteLine("Porcentagem: " + (3 % 2));
/*
 * string + string => string (concatenação)
 * int + int => int (adição)
 * string + int => string (concatenação)
 */


string nome = "Rodrigo";
string sobrenome = "Albino";
string nomeCompleto = nome + " " + sobrenome;
int idade = 22;
double peso = 69.30;
double altura = 1.70;
double imc = peso / (altura * altura);
bool estudandoProgramacao = true;

Console.WriteLine("\nNome Completo:" + nomeCompleto + "\nidade:" + idade + "\npeso:" + peso + "\nestudando:" + estudandoProgramacao + "\nimc:" + imc);

string aluno1 = "João";
double nota1 = 7;
double nota2 = 7;
double media = (nota1 + nota2) / 2;

Console.WriteLine("\nNome aluno:" + aluno1 + "\nMédia:" + media);




