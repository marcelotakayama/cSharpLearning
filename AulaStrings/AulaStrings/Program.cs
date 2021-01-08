﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaStrings {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHI ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);

            Console.WriteLine("Original: -"+ original + "-");
            Console.WriteLine("To Upper: -"+ s1 + "-");
            Console.WriteLine("To Lower: -"+ s2 + "-");
            Console.WriteLine("Trim: -"+ s3 + "-");
            Console.WriteLine("IndexOf('bc'): "+ n1 );
            Console.WriteLine("LastIndexOf('bc'): "+ n2 );
            Console.WriteLine("Substring(3): "+ s4 );
            Console.WriteLine("Substring(3, 5): "+ s5 );
            Console.WriteLine("Replace('a', 'x'): "+ s6 );
            Console.WriteLine("Replace('abc', 'xy'): "+ s7 );
            Console.WriteLine("IsNullOrEmpty: "+ b1 );
        }
    }
}
