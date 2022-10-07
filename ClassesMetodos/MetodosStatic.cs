using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public class Calculadora
    {
        public int Somar(int a, int b)//MÉTODO NÃO PERTENCE MAIS AO OBJETO MAS A CLASSE
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //MEMBRO ESTATICO PERTENCE A CLASSE E NÃO AO OBJETO 
    }

    class MetodosStatic
    {
        public static void Executar()
        {
            var resultado = Calculadora.Multiplicar(2, 2);
            Console.WriteLine(resultado);

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(2, 2));
            //Console.WriteLine(calculadora.Multiplicar(2,2));
        }
    }
}
