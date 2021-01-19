using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterfaces.Entities {
    class CarRental {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicule Vehicule { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicule vehicule) {
            Start = start;
            Finish = finish;
            Vehicule = vehicule;
            Invoice = null;
        }
    }
}
