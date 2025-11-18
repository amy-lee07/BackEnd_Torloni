//namespace pode ser considerado como a pasta do projeto
namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Endereco enderecoCompleto;

        public Pessoa ( Endereco endereco)
        {
            enderecoCompleto = endereco;
        }

        //endereco

        public void Falar()
        {
            System.Console.WriteLine($"Ola, eu sou o {Nome} e tenho {Idade} anos ");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}