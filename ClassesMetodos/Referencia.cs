using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public class Dependente
    {
        public string Nome;//ATRIBUIÇÃO POR REFERENCIA
        public int Idade;  //ATRIBUIÇÃO POR VALOR
    }
    class Referencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copia = numero;
            Console.WriteLine($"{numero} {copia}");
            numero++;
            Console.WriteLine($"{numero} {copia}");

            Dependente dep = new Dependente
            {
                Nome = "Mateus",
                Idade = 19
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
            copiaDep.Nome = "Teste";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
