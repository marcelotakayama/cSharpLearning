﻿using AulaInterfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaInterfaces.Services {
    class RentalService {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoid(CarRental carRental) {

        }
    }
}
