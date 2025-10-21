/ See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

int soma = 0;
int numero;

for (int i = 1; i >= 3; i++)
{
Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"digite o {i}° numero");
Console.WriteLine("----------------------------------------------------------------");
    numero = int.Parse(Console.ReadLine());
    soma =+ numero;

};


Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"a soma dos numeros que você digitou é: {soma}");
Console.WriteLine("----------------------------------------------------------------");
