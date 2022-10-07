using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Conversao
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; //DOUBLE MAIOR QUE INT, NÃO HÁ PERIGO DE PERDA DE INFORMAÇÃO
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //int notaTruncada = nota; <- não funciona
            int notaTruncada = (int)nota; //CONVERSÃO EXPLICITA ( FEITA MANUALMENTE)
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite um numero:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); //VAI TENTAR TRANSFORMAR PALAVRA NUM VALOR INTEIRO E JOGAR NA VARIAVEL NUMERO
            Console.WriteLine("Resultado: {0}", numero);

            Console.Write("Digite um numero novamente:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
