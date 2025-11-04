@@ -16,12 +16,13 @@

do
{
    Console.WriteLine($"Ok {nome}, selecione uma das funções abaixo");
    Console.Clear();
    Console.WriteLine($"Olá {nome}, selecione uma das funções abaixo");
    Console.WriteLine($"1 - Garrafa");
    Console.WriteLine($"2 - Agência");
    Console.WriteLine($"3 - Produto");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine($"");
    Console.WriteLine($"");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
@@ -40,6 +41,9 @@
        case 2:
            ContaBancaria();
            break;
        case 3:
            Produto();
            break;
        default:
            Console.WriteLine("ERRO, a função escolhida não existe");
            break;
@@ -50,6 +54,7 @@ void Garrafa()
        int menu = 0;
        do
        {
            Console.Clear();
            Garrafa g1 = new Garrafa();
            Console.WriteLine($"Olá {nome}, vamos personalizar sua garrafa.");
            Console.WriteLine($"Qual será a marca da sua garrafa?");
@@ -106,12 +111,13 @@ void Garrafa()
    void ContaBancaria()
    {
        int acao = 0;
            ContaBancaria t1 = new ContaBancaria();
            Console.WriteLine($"Olá {nome} vamos abrir uma conta bancária.");
            Console.WriteLine($"Quem será o titular dessa conta?");
            t1.Titular = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"");
        Console.Clear();
        ContaBancaria t1 = new ContaBancaria();
        Console.WriteLine($"Olá {nome} vamos abrir uma conta bancária.");
        Console.WriteLine($"Quem será o titular dessa conta?");
        t1.Titular = Console.ReadLine();
        Console.WriteLine($"");
        Console.WriteLine($"");
        do
        {

@@ -141,4 +147,31 @@ void ContaBancaria()
        } while (acao != 0);

    }
} while (op != 0);
    void Produto()
    {
        int menu = 0;
        do
        {
            Console.Clear();
            Produto p1 = new Produto();
            Console.WriteLine("Qual o nome do produto?");
            Console.WriteLine($"");
            Console.WriteLine($"");
            p1.Nome = Console.ReadLine();

            Console.WriteLine($"Qual o preço de {p1.Nome}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            p1.Preco = int.Parse(Console.ReadLine());
            double percentual = 0;
            p1.AplicarDesconto(percentual);

            Console.WriteLine($"Deseja voltar ao menu ou continuar no sistema?");
            Console.WriteLine($"1 - Sistema");
            Console.WriteLine($"0 - Menu");
            Console.WriteLine($"");
            Console.WriteLine($"");
            menu = int.Parse(Console.ReadLine());
        } while (menu != 0);
    }
} while (op != 0);
