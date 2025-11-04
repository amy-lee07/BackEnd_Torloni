using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        //metodo construtor de Pessoa, possuindo parametros
        /*parametros representam valores para as suas respectivas props
        ou seja, estanis inicializando valores para as props 
        nome e idade*/

        public Pessoa()
        {
            Nome = "desconhecido";
            Idade = 0;
        }

         public Pessoa(string n)
        {
            Nome = n;
            Idade = 0;
        }
        
        public Pessoa(string n, int i)
        {
            Nome = n;   //inicializa com o valor de n
            Idade = i; //inicializa com valor de i
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome:{Nome}, Idade: {Idade}");
        }
    }
}