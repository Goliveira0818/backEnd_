// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

//Console.WriteLine("Bem vindo ao programa ");
//Console.WriteLine();

//System.Console.WriteLine($"Digite um número: ");
//float a = float.Parse(Console.ReadLine());
//System.Console.WriteLine($"Digite outro número:");
//float b = float.Parse(Console.ReadLine());

//uso da classe estatica de forma auxiliar
//float r = CalculosMatematicos.Somar(a, b);
//System.Console.WriteLine($"soma: {r}");

//float r = CalculosMatematicos.Subtrair(a, b);
//System.Console.WriteLine($"SUBTRAÇÃO: {r}");

//float r = CalculosMatematicos.Dividir(a, b);
//System.Console.WriteLine($"DIVISÃO: {r}");

//float r = CalculosMatematicos.Multiplicar(a, b);
//System.Console.WriteLine($"Multiplicação: {r}");

//System.Console.WriteLine($"Valor de PI é: (Math.PI)");
//System.Console.WriteLine($"Potencia de 3 elevadoa 2 é:");

//Solicitar ao usuario 2 numeros reais e informar qual é o maior qual é o maior e qual é o menor dos números
//Para isso voce deve utilizara classe Math, ultilitaria do C#
 

System.Console.WriteLine();("Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine()); 
System.Console.WriteLine();("Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine());



if (n1==n2)
{
   System.Console.WriteLine($"Os dois números são iguais");
}
else
{
System.Console.WriteLine();("Maior: " + Math.Max(n1, n2));
System.Console.WriteLine();("Menor: " + Math.Min(n1, n2));

}
