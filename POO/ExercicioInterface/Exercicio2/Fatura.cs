using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public string Dono = " ";
        public string Credor = " ";
        public double Valor = 0;
        public double DiasDeAtraso = 0;
        private double Juros = 0.1;

        public Fatura(string Dev, string Cred, double ValFat, int QtdAtraso)
        {
            Dono = Dev;
            Credor = Cred;
            Valor = ValFat;
            DiasDeAtraso = QtdAtraso;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Fatura do {Dono}...");
            Console.WriteLine($"Credor: {Credor}");
            Console.WriteLine($"Devedor: {Dono}");
            Console.WriteLine($"Dias de atraso {DiasDeAtraso} dias");
            Console.WriteLine($"Valor {DiasDeAtraso} dias");
        }
        public void CalcularDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor += DiasDeAtraso * Juros;
            }
        }
    }
}