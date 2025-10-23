Console.WriteLine($"digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}!. Agora vamos dar as boas vindas a voce!!");
Console.WriteLine($"por favor escolha uma opcao abaixo");
Console.WriteLine($"1- saudar com nome");
Console.WriteLine($"2- saudar com sobrenome");
Console.WriteLine($"3- saudar com nome e sobrenome");
Console.WriteLine($"0- apenas saudacao generica");
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        saudacaogenerica();
        break;
    case 1:
        saudarComNome(nome);
        break;
    case 2:
        saudarComNome(sobrenome);
        break;
    case 3:
        string nomeCompleto = devolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"seja bem vindo {nomeCompleto}");
        break;
    default:
        break;
}
void saudacaogenerica()
{
    Console.WriteLine($"Ola, seja bem vindo ao nosso programa, tenha um otimo dia: )");
}
void saudarComNome(string nomeRecebido)
{
    Console.WriteLine($"seja bem vindo, {nomeRecebido}");
}
string devolveNomeCompleto(string nomeRecebido,string sobrenomeRecebido)
{
    return nomeRecebido + " " + sobrenomeRecebido;
}
