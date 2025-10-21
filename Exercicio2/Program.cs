//) Escreva     um     programa que leia     as     medidas     dos     
// lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,   
//  Isósceles    ou    Escaleno.    Sendo    que:     

//Triângulo    Equilátero:    possui    os    3    lados    iguais.     
// Triângulo    Isóscele:    possui    2    lados    iguais.     
//Triângulo    Escaleno:    possui    3    lados    diferentes.


int n = 0, contador = 0;
Console.WriteLine("Digite o número de repetições:");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    double a, b, c;

    Console.WriteLine("Digite o lado A:");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o lado B:");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o lado C:");
    c = double.Parse(Console.ReadLine());

    if (a == b && b == c)cd
        Console.WriteLine("Triângulo Equilátero");
    else if (a == b || a == c || b == c)
        Console.WriteLine("Triângulo Isósceles");
    else
        Console.WriteLine("Triângulo Escaleno");

    contador++;
}