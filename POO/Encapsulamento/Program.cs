
using Encapsulamento;

        Carro fiat = new Carro();

        
        fiat.DefinirMarca("Toyota");
        fiat.DefinirModelo("Corolla");

        
        fiat.Acelerar(30);
        fiat.Acelerar(20);
        fiat.Frear(15);
        fiat.Frear(50); 

        
        Console.WriteLine("Marca: " + fiat.ObterMarca());
        Console.WriteLine("Modelo: " + fiat.ObterModelo());
        Console.WriteLine("Velocidade Atual: " + fiat.ObterVelocidade() + " km/h");
    
