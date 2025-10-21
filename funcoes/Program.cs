Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu nome");
string sobrenome = Console.ReadLine();


Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a você!!");

Console.WriteLine($"por favor escolha uma opção abaixo:");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - saudar com o sobrenome");
Console.WriteLine($"3 - saudar com o nome e sobrenome");
Console.WriteLine($"0 - Apenas saudação genérica");

int opcao = 0;
switch (opcao)
{
    case 0:
        saudacaoGenerica();

        break;
    case 1:
        SaudarComNome(nome);
        break;

    case 2:
        SaudarComSobrenome(sobrenome);
        break;

    case 3:
        string nomeComplrto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;
    default:
        break;
}


void saudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}

void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Olá, seja bem-vindo {sobrenomeRecebido}");
}

string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}