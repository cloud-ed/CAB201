using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class House
    {
        private int bed;
        private double price;
        public House(int bedrooms, double price)
        {
            this.price = price;
            bed = bedrooms;
        }
    }
}

