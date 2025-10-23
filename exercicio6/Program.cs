﻿/*Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. Na verdade,
em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, 
ainda teria direito a uma última avaliação de recuperação. 
Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão?
Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado,
porém caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, 
em recuperação ou reprovado.*/

float n1, n2, n3, media, frequencia, continuar;
string nome = "";

Console.WriteLine("-------------------------");
Console.WriteLine("|   Bem vindo Usuario   |");
Console.WriteLine("-------------------------");

do {
Console.WriteLine("Qual o nome do aluno");
nome = Console.ReadLine();

Console.WriteLine("Digite a nota de Matemática:");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota de Português:");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota de História:");
n3 = float.Parse(Console.ReadLine());


Console.WriteLine("Digite a frequência (sem %):");
frequencia = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3) / 4;

if (frequencia < 75)
    Console.WriteLine($"O aluno(a) {nome} foi Reprovado(a)");
 else
if (media >= 7)
    Console.WriteLine("O(A) " + (nome) + " foi Aprovado");
 else if (media < 3)
    Console.WriteLine("O(A) " + (nome) + " foi Reprovado");
else
    Console.WriteLine("O(A )" + (nome) + " esta de Recuperação");

    Console.WriteLine("");
    Console.WriteLine("");

    Console.WriteLine("Deseja continuar no sistema?");
    Console.WriteLine("1-Sim");
    Console.WriteLine("2-Não");
    continuar = int.Parse(Console.ReadLine());

} while (continuar == 1);