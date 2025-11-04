using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3Sobrecargas
    {
        public string Nome;
        public int Idade;

        //metodo contrutor de pessoa, possuindo parametros
        /*possui parametros - representam os valores de nome e idade
        ou seja, estamos inicializando valores para as props nome e idade*/
        public Pessoa3Sobrecargas()
        {
            Nome = "Desconhecido"; //valores iniciais fixos
            Idade = 0; //valores iniciais fixos
        }
        public Pessoa3Sobrecargas(string n)
        {
            Nome = n; //valores iniciais dinamicos
            Idade = 0; //valores iniciais
        }
        public Pessoa3Sobrecargas(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}