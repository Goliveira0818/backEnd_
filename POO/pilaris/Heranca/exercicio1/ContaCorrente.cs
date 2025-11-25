using Exemplos;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine($"O valor do saque deve ser maior que R$0,00");
                return; //para a execução do método aqui
            }

            Saldo += valor;
        }

        public override void Sacarar(double valor)
        {
           
        }
    }
}