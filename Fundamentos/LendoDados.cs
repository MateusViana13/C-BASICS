using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());// "1" -> 1

            Console.WriteLine("{0} {1}", nome, idade);
        }
    }
}
