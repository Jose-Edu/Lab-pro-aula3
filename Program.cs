// //tipos de vars
// using System.ComponentModel;

// int x = 10;
// double pi = 3.1415;
// char letra = 'M';
// bool isTrue = true;
// string texto = "Uma linda mensagem";

// //conversão implicita
// double outroValor;
// outroValor = x;

// //conversão explicita
// int valorInteiro = (int) pi;

// //conversão explicita com a classe Convert
// int y = Convert.ToInt32(pi);

// //operadores
// // +, -, /, *, =, ==

// Console.WriteLine("Digite um numero");
// int numero;
// numero = Convert.ToInt32(Console.ReadLine());

// //concatenação
// Console.WriteLine("O usuário digitou: " + numero);

// //interpolação
// Console.WriteLine($"O dobro do que o usuário digitou é : {numero*2}");

Console.WriteLine("Digite um número");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número");
double num2 = Convert.ToInt32(Console.ReadLine());

double soma = num1+num2;
double sub = num1-num2;
double mult = num1*num2;
double div = Convert.ToDouble(num1/num2);

Console.WriteLine("Resultados:");
Console.WriteLine(num1 + " + " + num2 + " = " + soma);
Console.WriteLine($"{num1} - {num2} = {sub}");
Console.WriteLine(string.Format("{0} * {1} = {2}", num1, num2, mult));
Console.WriteLine(string.Format("{0} / {1} = {2}", num1, num2, div));