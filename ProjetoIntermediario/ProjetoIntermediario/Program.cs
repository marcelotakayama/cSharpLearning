using ProjetoIntermediario.Entities;
using ProjetoIntermediario.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntermediario {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(order);
        }
    }
}
