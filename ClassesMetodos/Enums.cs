using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }//Pascal case

    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class Enums
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "Teste";
            filme.GeneroFilme = Genero.Comedia;
        }
    }
}
