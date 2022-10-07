using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;//VALOR IMUTAVEL EM TEMPO DE EXECUÇÃO - CONSEGEU INICIALIZAR NO CONSTRUTOR

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataDeNascimento()
        {
            return string.Format("{0}/{1}/{2}",
                Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class ReadOny
    {
        public static void Executar()
        {
            var cliente = new Cliente("Mateus", new DateTime(2002, 05, 13));
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetDataDeNascimento());

            //cliente.Nascimento = new DateTime(2002, 05, 14);
        }
    }
}
