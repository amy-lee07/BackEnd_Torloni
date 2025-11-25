// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();
Console. Clear();

// Console.WriteLine($"Digite um numero: ");
// float a = float. Parse(Console.ReadLine());
// System.Console.WriteLine($"Digite outro numero: ");
// float b = float. Parse(Console.ReadLine());

// //uso da classes estatica de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// float s = CalculosMatematicos.Subtrair(a, b);
// System.Console.WriteLine($"Subtracao: {s}");

// float m = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicacao: {m}");

// float d = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisao: {d}");

System.Console.WriteLine($" Valor do PI e : {Math.PI}");
System.Console.WriteLine($" Potencia de 2 e : {Math.Pow(3, 2)}");

/*solicitar ao usuario 2 numeros reais e informar qual
e o maior e qual e o menor dos numeros. Para isso voce deve
utilizar a classe Math, utilitaria do C#*/
Console.WriteLine($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

if (n1== n2)
{
    System.Console.WriteLine($" Os dois numeros sao iguais");
}
else
{
   System.Console.WriteLine($@" O maior numero e: {Math.Max(n1, n2)}
                             o numero menor e: {Math.Min(n1, n2)}");
}
