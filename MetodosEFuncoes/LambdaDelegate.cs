using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdaDelegate
    {
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;
        }
    }
}
