using Encapsulamento;

//float dinheiro = 170;

//ContaBancaria contaGustavo = new ContaBancaria();
//ContaBancaria contaJulio = new ContaBancaria(dinheiro);


//contaGustavo.Depositar(dinheiro);



//System.Console.WriteLine($"Saldo da Conta: R${contaGustavo.GetSaldo()} ");
//System.Console.WriteLine($"Saldo da Conta: R${contaJulio.GetSaldo()} ");

//contaGustavo.Saque(90);
//System.Console.WriteLine($"Saldo apos saque do Gustavo: R${contaGustavo.GetSaldo()}");

//Crie um programa em C# para representar um carro usando o conceito de encapsulamento, porem
//utilizar propriedades com get e set. utilize somente privados e metodos publicos para acessar e 
//modificar os dados. Siga as Instrucoes:

class Carro
{
    // Atributos privados
    private string marca;
    private string modelo;
    private int ano;

    // Propriedades públicas (get e set)
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    // Método público para exibir informações do carro
    public void ExibirInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();

        Console.Write("Digite a marca do carro: ");
        carro.Marca = Console.ReadLine();

        Console.Write("Digite o modelo do carro: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Digite o ano do carro: ");
        carro.Ano = int.Parse(Console.ReadLine());

        Console.WriteLine("\n=== Dados do Carro ===");
        carro.ExibirInfo();
    }
}
