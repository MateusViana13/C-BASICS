using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Unarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//INVERTE VALOR
            Console.WriteLine(!booleano);//NEGAÇÃO LÓGICA
            Console.WriteLine(numero1++ == --numero2); //NUMERO2 SERA DECREMENTADO ANTES DE COMPARAR
            Console.WriteLine("{0} {1}", numero1, numero2);
        }
    }
}
