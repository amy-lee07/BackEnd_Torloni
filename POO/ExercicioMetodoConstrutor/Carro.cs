namespace ExercicioMetodoConstrutor
{
    public class Carro
    {
    public string Marca;
    public string Modelo;
    public int Ano;
    public Carro(string marca, string modelo, int ano);
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
public void ExibirDados()
        {
         Console.WriteLine($"Carro cadastrado:");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        }
       
    }
}


   