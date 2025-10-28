/ See https://aka.ms/new-console-template for more information
int opcao, totalClientes = 0;
string[] nomes = new string[10];
int[] idades = new int[10];
double[] saldo = new double[10];


Console.Clear();

do
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("==================== SISTEMA BANCARIO SIMPLES ==================");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Escolha uma das opções abaixo");
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($" 1 - Cadastrar cliente(s)");
    Console.WriteLine($" 2 - Depositar");
    Console.WriteLine($" 3 - Sacar");
    Console.WriteLine($" 4 - Transferir");
    Console.WriteLine($" 5 - Listar clientes");
    Console.WriteLine($" 6 - Buscar id do cliente");
    Console.WriteLine($" 0 - Sair");
    Console.WriteLine("----------------------------------------------------------------");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Obrigado por usar nosso programa");
            Console.WriteLine();
            Console.Write($"Encerrando");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);
            Console.Write($".");
            Thread.Sleep(1000);

            break;
        case 1:
            Console.Clear();
            CadastrarCliente();
            EsperarEnter();
            break;
        case 2:
            Console.Clear();
            Depositar();
            EsperarEnter();
            break;
        case 3:
            Console.Clear();
            Sacar();
            EsperarEnter();
            break;
        case 4:
            Console.Clear();
            Transferencia();
            EsperarEnter();
            break;
        case 5:
            Console.Clear();
            ListarClientes();
            EsperarEnter();
            break;
        case 6:
            Console.Clear();
            Console.WriteLine($"id do cliente:{BuscarCliente()}");
            Console.WriteLine();
            EsperarEnter();

            break;
        default:
            Console.Clear();
            Console.WriteLine("OPÇÃO INVALIDA - Porfavor tente denovo");
            EsperarEnter();
            break;
    }

} while (opcao != 0);
Console.WriteLine();





//    =================================(Funções)=================================

void CadastrarCliente()
{
    //verificar se tem espaço no array
    if (totalClientes >= 10)
    {
        Console.WriteLine("Limite de ocupação atingido");
        return;
    }
    else
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Digite o nome do Cliente");
        Console.WriteLine("----------------------------------------------------------------");
        nomes[totalClientes] = Console.ReadLine();
        saldo[totalClientes] = 0;
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"Digite a idade do(a) {nomes[totalClientes]}");
        Console.WriteLine("----------------------------------------------------------------");
        idades[totalClientes] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        totalClientes++;

        Console.WriteLine($"Cliente cadastrado com sucesso");
        Console.WriteLine($"Agora há {totalClientes} cadastrados no sistema");
        Console.WriteLine();
        Console.WriteLine();
    }
}





void Depositar()
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente fez o deposito");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - {idades[i]} anos - Deposito Atual: R$:{saldo[i]:F2}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
    Console.WriteLine("----------------------------------------------------------------");

    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Digite de quanto foi o deposito ");
    Console.WriteLine("----------------------------------------------------------------");

    double deposito = double.Parse(Console.ReadLine());

    saldo[n - 1] += deposito;
    Console.WriteLine($"Saldo atual: R${saldo[n - 1]}");
}





void Sacar()
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente fez saque");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - {idades[i]} anos - Deposito Atual: R$:{saldo[i]:F2}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
    Console.WriteLine("----------------------------------------------------------------");

    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Digite de quanto foi o saque");
    Console.WriteLine("----------------------------------------------------------------");

    double saque = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    if (saldo[n - 1] - saque < 0)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"Saldo insuficiente");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else
    {
        saldo[n - 1] -= saque;
        Console.WriteLine($"Saque concluido!");
        Console.WriteLine($"Saldo atual: R${saldo[n - 1]}");
    }
}





void Transferencia()
{
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente fez a transferencia");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - {idades[i]} anos - Deposito Atual: R$:{saldo[i]:F2}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    };
    
    Console.WriteLine("----------------------------------------------------------------");

    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente recebeu a transferencia");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - {idades[i]} anos - Deposito Atual: R$:{saldo[i]:F2}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
    Console.WriteLine("----------------------------------------------------------------");

    int n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Digite de quanto foi a transferencia");
    Console.WriteLine("----------------------------------------------------------------");

    double transferencia = double.Parse(Console.ReadLine());

    if (saldo[n1 - 1] - transferencia < 0)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"Saldo insuficiente");
        Console.WriteLine("----------------------------------------------------------------");
    }
    else
    {
        saldo[n1 - 1] -= transferencia;
        saldo[n2 - 1] += transferencia;
        Console.WriteLine($"Saque concluido!");
        Console.WriteLine($"Saldo atual do(a) {nomes[n1 - 1]}: R${saldo[n1 - 1]:F2}");
        Console.WriteLine($"Saldo atual do(a) {nomes[n2 - 1]}: R${saldo[n2 - 1]:F2}");
    }
}






void ListarClientes()
{
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i} - {nomes[i]}, {idades[i]} anos - Depositado Atual: R$:{saldo[i]:F2}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
}

int BuscarCliente()
{
    ListarClientes();
    System.Console.WriteLine("Digite o numero do cliente");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1;
    }
    ;
    return idCliente;

}

void EsperarEnter()
{
    Console.Write("Para continuar precione a tecla <Enter>");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.Write($".");
    Thread.Sleep(500);
    Console.WriteLine($".");
    Console.ReadLine();
}
;