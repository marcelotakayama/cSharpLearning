using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTryCatch {
    class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch(DivideByZeroException e) {
                Console.WriteLine("Divisão por zero não é permitida");
            } catch (FormatException e) {
                Console.WriteLine("Format Error! " + e.Message);
            }
        }
    }
}
