using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    class Membro
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa(); //CLASSE E CONSTRUTOR
            pessoa.Nome = "Renato";
            pessoa.Idade = 21;

            Console.WriteLine("{0} tem {1} anos", pessoa.Nome, pessoa.Idade);
            pessoa.ApresentarNoCosole();

            var pessoa2 = new Pessoa(); //INFERENCIA
            pessoa2.Nome = "Mateus";
            pessoa2.Idade = 19;

            var apresentacao = pessoa2.Apresentar();
            Console.WriteLine(apresentacao);
        }
    }
}
