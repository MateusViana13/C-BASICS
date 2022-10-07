using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ClassesMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; //ATRIBUTO DE CLASSE

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

    }

    class AtributosStatic
    {
        public static void Executar()
        {
            var produto = new Produto("Caneta", 2, 0.1);
            var produto2 = new Produto("Caneta", 2, 0.5);
            Produto.Desconto = 0.5; //IGNORA TUDO E DEFINE DESCONTO PARA TODOS OBJETOS COMO 0.5
            Console.WriteLine("Preço com desconto: {0}",
                produto.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto());

        }
    }
}
