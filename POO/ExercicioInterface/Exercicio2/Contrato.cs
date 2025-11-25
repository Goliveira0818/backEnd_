using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
         public string Contratante = " ";
         public string PrestadorServiso = " ";
        public string TextoClausulas = " ";
        public Contrato(string contratante, string contratado ,string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServiso = contratado;
            TextoClausulas = txtClausulas;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Contratador: {Contratante}");
            Console.WriteLine($"Contratado: {PrestadorServiso}");
            Console.WriteLine($"Clausulas: {TextoClausulas}");
        }
    }
}
