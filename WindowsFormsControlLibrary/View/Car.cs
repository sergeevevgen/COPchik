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

        public Car(string Brand, string Model, string VIN, int Price, decimal Power, string Color, string Body)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.VIN = VIN;
            this.Price = Price;
            this.Power = Power;
            this.Color = Color;
            this.Body = Body;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Price { get; set; }
        public decimal Power { get; set; }
        public string Color { get; set; }
        public string Body { get; set; }
    }
}