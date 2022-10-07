using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            if (cilindrada > 0)
            {
                Cilindrada = cilindrada;
            }

        }

    }

    class GetterSetter
    {
        public static void Executar()
        {
            var moto = new Moto("Kawasaki", "Ninja", 600);
            Console.WriteLine(moto.GetMarca());
            Console.WriteLine(moto.GetModelo());
            Console.WriteLine(moto.GetCilindrada());
        }
    }
}
