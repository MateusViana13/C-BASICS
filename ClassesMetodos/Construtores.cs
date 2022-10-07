using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)//CONSTRUTOR
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
            public Carro()//CONSTRUTOR PADRÃO
            {

            }
        }
        public static void Executar()
        {
            var carro = new Carro(); //construtor padrão
            carro.Modelo = "Aventador SVJ";
            carro.Fabricante = "Lamborghini";
            carro.Ano = 2021;
            Console.WriteLine("{0} {1} {2}", carro.Fabricante, carro.Modelo, carro.Ano);

            var carro2 = new Carro("488 Pista", "Ferrari", 2021);
            Console.WriteLine("{0} {1} {2}", carro2.Fabricante, carro2.Modelo, carro2.Ano);

            var carro3 = new Carro()
            {
                Fabricante = "Ford",
                Modelo = "Mustang GT500",
                Ano = 2021
            };
        }
    }
}
