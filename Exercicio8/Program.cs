// Faça uma alteração no programa acima do menu para que ele funcione em loop. Pra isso utilize o laço do while do c#.

int opcao;
do
{
    Console.WriteLine("\n1) Opção 1");
    Console.WriteLine("2) Opção 2");
    Console.WriteLine("3) Opção 3");
    Console.WriteLine("0) Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a Opção 1");
            break;
        case 2:
            Console.WriteLine("Você escolheu a Opção 2");
            break;
        case 3:
            Console.WriteLine("Você escolheu a Opção 3");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
} while (opcao != 0);
