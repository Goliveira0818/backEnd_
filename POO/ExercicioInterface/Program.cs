//cria uma lista de objetos fatura
using Exercicio02;
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatMaya = new Fatura("Mayara", "Nike ", 4500, 1);
// fatMaya.Imprimir();


int opcao;
do
{
    Console.Clear();

    // Desenha o Menu
    Console.WriteLine($"Menu de Opções: ");
    Console.WriteLine(@$"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Lisar Contratos
0) Sair
Escolha um opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;

        case 2:
            CadastrarRelatorio();
            break;

        case 3:
            CadastrarContrato();
            break;

        case 4:
            Console.WriteLine($"Listar Faturas");
            break;

        case 5:
            Console.WriteLine($"Listar Rleatórios");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção Inválida!");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine(); // Para o console para dar tempo de ver as mensagens do programa

} while (opcao != 0);


// Funções Auuxiliares
void CadastrarFatura()
{
    // Pede ao usuário os dados
    Console.WriteLine($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    Console.WriteLine($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    Console.WriteLine($"Digite o valor da fatura: ");
    float valfat = float.Parse(Console.ReadLine());
    Console.WriteLine($"Quantos dias a fatura está em atraso? ");
    int qtdAtraso = int.Parse(Console.ReadLine());

    // Cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valfat, qtdAtraso);
    // Cadastra a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante: ");
    string contratante = Console.ReadLine();
    Console.WriteLine($"Digite o nome do contratado: ");
    string contratado = Console.ReadLine();
    Console.WriteLine($"Informe as cláusulas do contrato: ");
    string txtClasulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratado, txtClasulas);
    documentos.Add(c);
}

void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do responsável pelo relatório: ");
    string responsavel = Console.ReadLine();
    Console.WriteLine($"Digite as informações do relatório: ");
    string txtrelatorio = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtrelatorio);
    documentos.Add(r);
}

 void ListarFatura()
 {
    foreach (IImprimivel doc in documentos)
     {
         Console.WriteLine("-- Lista de Faturas --");
         Console.WriteLine(doc.Imprimir);
     }
 }