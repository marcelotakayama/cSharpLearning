using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {

        
        
        static void Main(string[] args) {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estorque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("Digite o número de produtos a serem removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            /*
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: "+ Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
