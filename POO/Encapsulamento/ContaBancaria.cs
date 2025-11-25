using System.Diagnostics.Contracts;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;
        //Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
                return;
            }
        }
        //metodo publico que seta/configura/guarda
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }
            System.Console.WriteLine($" Valor para deposito invalido");
        }
        public float GetSaldo()
        {

            return Saldo;
        }
        //crie o metodo publico Sacar(float valor)
        public void Sacar(float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque efetuado com sucesso");
                return;
            }
            System.Console.WriteLine($"Valor para saque invalido");

        }
    }
}