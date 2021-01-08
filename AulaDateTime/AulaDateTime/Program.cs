using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AulaDateTime {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021, 1, 8);
            DateTime d3 = new DateTime(2021, 1, 8, 17, 36, 12);
            DateTime d4 = new DateTime(2021, 1, 8, 17, 36, 12, 500);
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;
            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");
            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58",  "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1.Ticks);
            //teste1
            Console.WriteLine(d1);
            //teste2
            Console.WriteLine(d2);
            //teste3
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}
