using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {

        
        
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900, 10);

            p.Nome = ("TV 4K");

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
