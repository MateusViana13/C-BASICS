using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // () => é uma função anonima
            //Action não tem retorno
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };
            algoNoConsole();

            //Func tem retorno
            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            //RETURN IMPLICITO
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
