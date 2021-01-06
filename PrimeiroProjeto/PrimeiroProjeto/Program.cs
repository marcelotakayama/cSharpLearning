using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i=0; i<n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double sum = 0.0;

            for (int i= 0; i<n; i++) {
                sum += vect[i].Preco;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = "+ avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
