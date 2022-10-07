using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class While
    {
        public static void Executar()
        {
            Random random = new Random();
            int palpite = 0;
            int numeroSecreto = random.Next(1, 16);
            int tentativasRestantes = 5;
            int tentativasAtuais = 0;
            bool numeroEncontrado = false;


            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentivas", tentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor....Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior....Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
