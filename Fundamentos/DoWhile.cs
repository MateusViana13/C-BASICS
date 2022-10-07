using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class DoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();
                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("DesejaContinuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
