2 ) // Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol 
// (os gols de cada time) e informa se o resultado foi um empate, 
// se a vitória foi do primeiro time ou do segundo time.

int n = 0, contador = 0;
Console.WriteLine("Digite o número de repetições:");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    int gols1, gols2;

    Console.WriteLine("Digite os gols do primeiro time:");
    gols1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os gols do segundo time:");
    gols2 = int.Parse(Console.ReadLine());

    if (gols1 == gols2)
        Console.WriteLine("Empate!");
    else if (gols1 > gols2)
        Console.WriteLine("Vitória do primeiro time!");
    else
        Console.WriteLine("Vitória do segundo time!");

    contador++;
}