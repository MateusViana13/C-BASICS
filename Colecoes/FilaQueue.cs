using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Colecoes
{
    class FilaQueue
    {
        public static void Executar()
        {
            //FIFO = FIRST IN FIRST OUT - PRIMEIRO A ENTRAR PRIMEIRO A SAIR
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");//COLOCA NA LISTA
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//PEGA O PRIMEIRO MAS NÃO EXCLUI
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());//TIRA O PRIMEIRO
            Console.WriteLine(fila.Count);

            foreach (var x in fila)
            {
                Console.WriteLine(x);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("AAA");
            salada.Enqueue(true);
            Console.WriteLine(salada.Contains(3));
        }
    }
}
