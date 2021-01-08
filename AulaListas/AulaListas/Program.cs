using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaListas {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Marcelo"); 
            list.Add("Alex"); 
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
        }
        //static bool Test(string s) {
        //    return s[0] == 'A';
        //}
    }
}
