string cargo = "";
double salario, salario2;

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual o seu cargo?");
cargo = Console.ReadLine();

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual o seu salario?");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------");
Console.WriteLine("Resultado");
if (cargo == "Produção")
{
    salario2 = salario * 1.065;
    Console.WriteLine($"Seu salario agor a é: {salario2}");
}

else if (cargo == "Adiministração")
{
    salario2 = salario * 1.075;
    Console.WriteLine($"Seu salario agor a é: {salario2}");
}

else if (cargo == "Diretoria")
{
    salario2 = salario * 1.12;
    Console.WriteLine($"Seu salario agor a é: {salario2}");
}

else
{
    Console.WriteLine("O seu cargo não foi encontrado, tente com a primeira letra maiuscula");
}