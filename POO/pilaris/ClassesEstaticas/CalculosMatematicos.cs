

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas simples 
        // visibiliadade tipoDeRetorno Nome (parametros){corpo}

        public static float Somar (float a, float b)
        {
        
            return a + b;
        }
         //Cria as outras 3 operacoes
         //Não se esqueca que nao existe divisao por zero,
         //entao  na divisao faca validacao

        public static float Subtrair (float a, float b)
        {
              return a - b;
        }
        

        public static float Dividir (float a, float b)
        {
         if(b == 0)
         {
              System.Console.WriteLine("Divisão não invalida");  

         }

         
        }
        public static float multiplicar (float a, float b)
        {
          return a * b;
        }


        
    }
}