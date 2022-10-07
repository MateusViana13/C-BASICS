using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Atribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 +10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 2; // num1 = num1 * 2
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);
            int a = 1;
            int b = a;

            a++; //acrescentando 1
            Console.WriteLine(a);

            b--; //subtraind 1
            Console.WriteLine(b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.Nome = "João";

            dynamic d = c; //MESMO ESPAÇO DE MEMÓRIA
            d.Nome = "Maria";

            Console.WriteLine(c.Nome); //c.Nome = Maria
        }
    }
}
