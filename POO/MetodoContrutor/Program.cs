using System.Runtime.Intrinsics.Arm;
using MetodoConstrutor;

Pessoa fontes = new Pessoa("Joao", 17);

// fontes.Nome = "Lorenzo";
// fontes.Idade = 17;
//primeiro metodo construtor da class
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
System.Console.WriteLine(@$"primeira pessoa cadastrada:
                            Nome:{PrimeiraPessoa.Nome}
                            Idade:{PrimeiraPessoa.Idade}");
//segundo metodo construtor da class
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
System.Console.WriteLine(@$"segunda pessoa cadastrada:
                            nome:{SegundaPessoa.Nome}
                            Idade:{PrimeiraPessoa.Idade}");

//terceiro metodo construtor da class
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);
System.Console.WriteLine(@$"terceira pessoa cadastrada:
                            nome:{TerceiraPessoa.Nome}
                            idade: {TerceiraPessoa.Idade}");
                            

// atividade: peca o nome e a idade da terceira pessoa pelo terminal
//atribui os valores digitados ao objeto TerceiraPessoa
Console.WriteLine("\nDigite o nome da terceira pessoa:");
TerceiraPessoa.Nome = Console.ReadLine();

Console.WriteLine("Digite a idade da terceira pessoa:");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Dados da terceira pessoa:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade}");



