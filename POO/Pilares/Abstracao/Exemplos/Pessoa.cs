namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
           System.Console.WriteLine($"Ola, sou uma pessoa");
        }
           public override void Mover()
        {
           System.Console.WriteLine($"Estou andando a 2km por hora");
        }

    }
}