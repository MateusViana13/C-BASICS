using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Mateus";
            Console.WriteLine(nome);
            //C# RECONHEÇE O TIPO INFERIDO NO VAR
            //  não funciona pois o tipo está implicito -> var idade;
            // var é necessário inicializar 
        }
    }
}
