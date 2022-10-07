using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Ternarios
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = false;
            string resultado = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado"; //SE VERDADEIRO = APROVADO, SE NÃO = REPROVADO
            Console.WriteLine(resultado);
        }
    }
}
