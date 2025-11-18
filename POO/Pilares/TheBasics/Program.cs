using System.ComponentModel.DataAnnotations;
using TheBasics;
Console.Clear();

// List<Pessoa> peoples = new List<Pessoa>();

// /*---Amy---*/
// Endereco enderecoAmy = new Endereco();
// enderecoAmy.Logradouro = "Rua Niteroi";
// //pessoa com endereco
// Pessoa amy = new Pessoa(enderecoAmy);
// amy.Nome = "Amy Lee";
// amy.Idade = 17;

// //*---Livia---*//
// //endereco
// Endereco enderecoLivia = new Endereco();
// enderecoLivia.Logradouro = "Rua la de casa";
// //pessoa com endereco
// Pessoa livia = new Pessoa(enderecoLivia);
// livia.Nome = "Livia Lançoni";
// amy.Idade = 16;


// //guardando os dados na lista
// peoples.Add(amy);//0
// peoples.Add(livia);//1

// foreach (var p in peoples) ;
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spinola Teixeira";
// endEnzo.Numero = 3960;

// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 987;

// Endereco endProfAlexia = new Endereco();
// endProfAlexia.Logradouro = "Rua Niteroi";
// endProfAlexia.Numero = 123;

// Professor proAlexia = new Professor(endProfAlexia);
// proAlexia.Nome = "Alexia Vitoria";

// System.Console.WriteLine($"Aluno {pedroEnzo} estuda na turma {pedroEnzo.Curso} da profa.{proAlexia}");


Carro fusca = new Carro();
fusca.Marca = "Wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar400";

fusca.Ligar();
fusca.AbrirPortaMala();

dominar400.Ligar();