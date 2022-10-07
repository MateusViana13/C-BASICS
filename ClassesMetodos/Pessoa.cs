using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    class Pessoa
    {
        public string Nome; //VALOR PADRÃO STRING = NULL
        public int Idade;   //VALOR PADRÃO INT = 0

        public string Apresentar()
        {
            return string.Format("Olá, meu nome é {0} e tenho {1} anos.", Nome, Idade);
        }

        public void ApresentarNoCosole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
