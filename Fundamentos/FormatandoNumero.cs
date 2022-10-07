using System;
using System.Globalization;

namespace CSharpBasics.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 = UMA CASA DECIMAL
            Console.WriteLine(valor.ToString("C")); // MOEDA - DE ACORDO COM O SISTEMA
            Console.WriteLine(valor.ToString("P"));// PERCENTUAL
            Console.WriteLine(valor.ToString("#.##")); //FORMATO QUE EU DEFINO

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); // DINHEIRO SEM CASA DECIMAL COM CULTURA BR

            CultureInfo culturaInglesa = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C", culturaInglesa));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // NUMERO COM 10 CASAS E COM ZERO A ESQUERDA
        }
    }
}
