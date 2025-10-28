//Criação de Variáveis
string[] nomes = new string[4];//tamanho é 4 - de 0 a 3
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

//nomes[0] = "Maria";
//idades[0] = 20;

//nomes[1] = "Matheus";
//idades[1] = 16;

//nomes[2] = "Eloysa";
//idades[2] = 17;

//nomes[3] = "Felipe;";
//idades[3] = 17;

//nomes[4] = "José";
//idades[4] = 50;




do
{
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine)



} while (opcao != 0);

// ================= Funções =================



void CadastrarAluno()
{
    //Verificar se tem espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        return;
    }

    //pedir os dados para o usuário (nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    //guarda/cadastrar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistemas!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//parar o sistemas e esperar o usuário dar um <Enter>


}






// função para exibir os alunos
void ListarAlunos()
{
    Console.WriteLine();//pula uma linha
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"    Nome: {nomes[i]}");
    Console.WriteLine($"    Idade: {idades[i]} anos");
    Console.WriteLine();//pula uma linha
}
}