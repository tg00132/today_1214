﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Deal
    {
        string day;
        Customer customer;
        Car car;
        Seller seller;

        public Deal(string day, Customer customer, Car car, Seller seller)
        {
            this.day = day;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string Day { get => day; set => day = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
