using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string Brand, string Model, string VIN, int price)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.VIN = VIN;
            this.price = price;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string VIN;
        public int price;
    }
}