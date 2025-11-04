using ExercicioMetodoConstrutor;
// Carro c1 = new Carro("Toyota", "Corolla", 2022);
// c1.ExibirDados();
// System.Console.WriteLine();

Aluno a1 = new Aluno();
Aluno a2 = new Aluno("Matheus Lima", 10);

System.Console.WriteLine();

System.Console.WriteLine(@$"Aluno 1:
Nome: {a1.Nome}
Nota: {a1.Nota}");

System.Console.WriteLine(@$"Aluno 2:
Nome: {a2.Nome}
Nota: {a2.Nota}");