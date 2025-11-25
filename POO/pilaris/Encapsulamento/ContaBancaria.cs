

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;
        
        //Construtores

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if(SaldoInicial > 0)
            {
            Saldo = SaldoInicial;
            }
        }

        public void Depositar(float valor)
        {
            if(valor >= 0)
            {
            Saldo = valor;
            return;
            }

            System.Console.WriteLine($"Valor para deposito invalido");
        }

        //metodo publico que retorna o Saldo 
        public float GetSaldo()
        {
            return Saldo;
        }
          //crie metodo publico Sacar(float valor)

          public void Saque (float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"saque efetuado com sucesso!");
                return;
            }

            System.Console.WriteLine($"Valor para saque invalido");
        }
    }
}