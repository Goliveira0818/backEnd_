double n1, n2, operacao, continuar;

do
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("-------------------------");
    Console.WriteLine("|                       |");
    Console.WriteLine("|      Calculadora      |");
    Console.WriteLine("|          com          |");
    Console.WriteLine("|         menu          |");
    Console.WriteLine("|                       |");
    Console.WriteLine("-------------------------");
    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Digite o número da operação:");
    Console.WriteLine("1-Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    Console.WriteLine("0-Sair");
    Console.WriteLine("");
    Console.WriteLine("");
    operacao = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("");
    if (operacao == 0)
    {
        sair();
    }
    else
    {
        Console.WriteLine("Digite o primeiro número:");
        Console.WriteLine("");
        Console.WriteLine("");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Digite o segundo número:");
        Console.WriteLine("");
        Console.WriteLine("");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("");

        switch (operacao)
        {
            case 1:
                soma();
                break;
            case 2:
                subtração();
                break;
            case 3:
                multiplicação();
                break;
            case 4:
                divisão();
                break;
            default:
                invalida();
                break;
        }
    Thread.Sleep(1000);
    }
} while (operacao != 0);



void sair()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("-------------------------");
    Console.WriteLine("|    Até mais Usuario   |");
    Console.WriteLine("-------------------------");
    Console.WriteLine("");
    Console.WriteLine("");
}

void soma()
{
    double resultado = n1 + n2;
    Console.WriteLine((n1) + " + " + (n2) + " = " + (resultado));
}

void subtração()
{
    double resultado = n1 - n2;
    Console.WriteLine((n1) + " - " + (n2) + " = " + (resultado));
}

void multiplicação()
{
    double resultado = n1 * n2;
    Console.WriteLine((n1) + " * " + (n2) + " = " + (resultado));
}

void divisão()
{
    if (n2 == 0 || n1 == 0)
    {
        Console.WriteLine("ERRO: IMPOSSÍVEL DIVIDIR POR 0");
    }
    else
    {
        double resultado = n1 / n2;
        Console.WriteLine((n1) + " / " + (n2) + " = " + (resultado));
    }
}

void invalida()
{
    Console.WriteLine("ERRO: Operação inválida");
}