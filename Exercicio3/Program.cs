1-int n = 0, contador = 0;
Console.WriteLine("Digite o número de repetições:");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    double salario, gastos;
    Console.WriteLine("Digite o salário recebido:");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o total gasto:");
    gastos = double.Parse(Console.ReadLine());

    if (gastos <= salario)
        Console.WriteLine("Gastos dentro do orçamento");
    else
        Console.WriteLine("Orçamento estourado");

    contador++;
}
