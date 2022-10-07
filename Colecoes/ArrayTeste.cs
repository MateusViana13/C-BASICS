using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Colecoes
{
    class ArrayTeste
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "1";
            alunos[1] = "2";
            alunos[2] = "3";
            alunos[3] = "4";
            alunos[4] = "5";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
