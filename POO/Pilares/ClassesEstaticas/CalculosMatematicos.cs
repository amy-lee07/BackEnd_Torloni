using System.Net.WebSockets;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        //operacoes matematicas simlples 
        public static float Somar (float a, float b)
        {
        return a + b;
        }
        //criar as outras 3 operacoes 
        /*nao se esqueca que nao exister divisao por 0,
        entao na divisao faca a validacao*/
         public static float Subtrair (float a, float b)
        {
        return a - b;
        }
        
         public static float Multiplicar (float a, float b)
        {
        return a * b;
        }
        
         public static float Dividir (float a, float b)
        {
            if(b == 0)
            {
                System.Console.WriteLine($"Divisao invalida");
                return 0;
            }
        return a / b;
        }
        

    }
}