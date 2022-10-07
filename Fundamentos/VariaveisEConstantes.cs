using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //AREA DA CIRCUNFERENCIA
            double raio = 4.5;
            const double PI = 3.14; //CONST NÃO DEIXA ELA SER ALTERADA EM OUTRO LUGAR

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A Área é: " + (area + 1));

            //TIPOS
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            /* BYTE = 1 byte
             * SHORT = 2 BYTES
             * INT = 3 BYTES
             * LONG = 4 BYTES
             * DIFERENÇA DE CAPACIDADE DE ARMAZENAMENTO
             * INT == PADRÃO
             */
            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(saldoDeGols);

            int intNum = int.MaxValue;
            Console.WriteLine(intNum);

            long longNum = long.MaxValue;
            Console.WriteLine(longNum);

            uint numeroSemSinal = 207_600_000;
            Console.WriteLine(numeroSemSinal);

            float precoComputador = 12999.99f;//double = 2x Float (double = 8bytes, float = 4bytes)
            Console.WriteLine(precoComputador);

            decimal distanciaEntreEstrela = decimal.MaxValue;//muito grande
            Console.WriteLine(distanciaEntreEstrela);

            char letra = 'b';//UNICA LETRA, ASPAS SIMPLES

            string texto = "EAE"; //cadeia de caracteres

        }
    }
}
