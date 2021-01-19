using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterfaces.Entities {
    class Vehicule {
        public string Model { get; set; }

        public Vehicule(string model) {
            Model = model;
        }
    }
}
