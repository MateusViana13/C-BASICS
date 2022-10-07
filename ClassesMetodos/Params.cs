using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)//estrutura que agrupa variso parametros
        {
            foreach (var x in pessoas)
            {
                Console.WriteLine("Olá {0}", x);
            }
        }

        public static void Executar()
        {
            Recepcionar("Mateus", "Teste", "Test", "New");
        }
    }
}
