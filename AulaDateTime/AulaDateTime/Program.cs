using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDateTime {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021, 1, 8);
            DateTime d3 = new DateTime(2021, 1, 8, 17, 36, 12);
            DateTime d4 = new DateTime(2021, 1, 8, 17, 36, 12, 500);

            DateTime d5 = new DateTime.Now;



            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
        }
    }
}
