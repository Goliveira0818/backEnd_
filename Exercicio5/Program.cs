// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
// e R$ 0,25 se forem compradas pelo menos doze. 
// Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.



int n = 0, contador = 0;
Console.WriteLine("Digite o número de repetições:");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    int qtd;
    Console.WriteLine("Digite o número de maçãs compradas:");
    qtd = int.Parse(Console.ReadLine());

    double preco = qtd < 12 ? 0.30 : 0.25;
    double total = qtd * preco;

    Console.WriteLine($"Valor total: R$ {total:F2}");

    contador++;
}