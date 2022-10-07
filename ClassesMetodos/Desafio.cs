using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    class Desafio
    {
        int A = 10;

        public static void Executar()
        {
            //acesse a variavel A dentro do método executar
            var b = new Desafio();
            Console.WriteLine(b.A);
            //ACESSAR A PARTIR DA INSTANCIA
        }
    }
}
