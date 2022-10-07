using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public class CarroOpicional
    {
        double desconto = 0.1;//VISIBILIDADE PRIVADA
        string nome;
        public string Nome
        {
            get
            {
                return "Opicional:" + nome;
            }
            set
            {
                nome = value;
            }
        }
        //PROPRIEDADE AUTO IMPLEMENTADA
        public double Preco { get; set; }

        //somente leitura
        public double precoComDesconto
        {
            get => Preco - desconto * Preco;//lambda
        }

        public CarroOpicional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpicional("Ar", 3500.99);
            Console.WriteLine(op1.precoComDesconto);

            //op1.precoComDesconto = 500; NÃO ROLA POIS É SOMENTE LEITURA
        }
    }
}
