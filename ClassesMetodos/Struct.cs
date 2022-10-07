using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    interface Ponto
    {
        void MoverDiagonal(int delta);//POR PADRÃO PUBLIC 
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class Struct
    {
        public static void Executar()
        {
            Coordenada coordenada;
            coordenada.X = 2;
            coordenada.Y = 2;
            Console.WriteLine("X = {0} Y = {1}", coordenada.X, coordenada.Y);
        }
    }
}
