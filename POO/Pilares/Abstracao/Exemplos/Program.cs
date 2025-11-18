using System.Runtime.InteropServices;
using Exemplos;
// Cachorro toto = new Cachorro();
// Gato gatinho = new Gato();

/*crie um classe abstrata ContaBancaria com os metodos Depositar*/

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(5);
System.Console.WriteLine($"Saldo Conta Poupanca antes do Saque: {cp.Saldo}");
System.Console.WriteLine($"Saldo Conta Corrente antes do Saque: {cc.Saldo}");

cc.Sacar(10);
cp.Sacar(5);
System.Console.WriteLine($"Saldo Conta Poupanca apos o Saque: {cp.Saldo}");
System.Console.WriteLine($"Saldo Conta Corrente apos o Saque: {cc.Saldo}");



