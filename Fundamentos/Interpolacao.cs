﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook";
            var marca = "Dell";
            double preco = 5800.00;
            Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"A Marca {marca} é legal");
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
