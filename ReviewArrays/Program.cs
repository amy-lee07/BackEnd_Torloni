using System.Net.WebSockets;

string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;


do
{
    Console.WriteLine($" 1) cadastrar alunos");
    Console.WriteLine($" 2) listar alunos");
    Console.WriteLine($" 0) sair");
    Console.WriteLine($" digite uma opcao:");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {

         case 0:
            Console.WriteLine($"encerrando ...");
            Console.WriteLine($"presssione <Enter> para encerrar ...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarAlunos();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opcao invalida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
            
    }

} while (opcao != 0);

void CadastrarAlunos()
{
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"nao limite de ocupacao atingido");
        return;
    }
    Console.WriteLine($"digite o nome do aluno");
    string n = Console.ReadLine();

    Console.WriteLine($"digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"aluno cadastrado com sucesso");
    Console.WriteLine($"ha {totalAlunos} alunos(s) cadastrado(s) no sistema");
    Console.WriteLine($"pressione <Enter> para continuar");
    Console.ReadLine();

}

void ListarAlunos()
{
    Console.WriteLine();
Console.WriteLine($"resultado");

for (int i = 0; i <nomes.Length; i++)
{
    Console.WriteLine($"  nome: {nomes[i]}");
    Console.WriteLine($"  idade: {idades[i]}");
    Console.WriteLine();

}

}

