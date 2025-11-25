using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string Nome = " ";
        public string TextoRelatorio = " ";
        public Relatorio(string responsável, string txtRelatorio)
        {
            Nome = responsável;
            TextoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Dono do relatorio: {Nome}...");
            Console.WriteLine(TextoRelatorio);
        }
    }
}
