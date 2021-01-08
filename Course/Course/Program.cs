using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    class Program {
        static void Main(string[] args) {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0)?preco *0.1: preco*0.05;
            //teste
            Console.WriteLine(desconto);
        }
    }
}
    

