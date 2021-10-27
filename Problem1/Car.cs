using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    class Car
    {
        public string Vin {get; set;}
        public string Make { get; set; }
        public string Color { get; set; }
        public int Year {get; set;}
        public string Model {get; set;}
        public double Sale_Price { get; set; }


        public Car()
        {
            Vin = string.Empty;
            Make = string.Empty;
            Color = string.Empty;
            Year = 0;
            Model = string.Empty;
            Sale_Price = 0;
        }

        public override string ToString()
        {
            return $"{Year} {Make} - {Model}";
        }

        public Car(string vin, string make, string color, int year, string model, double sale_price)
        {
            Vin = vin;
            Make = make;
            Color = color;
            Year = year;
            Model = model;
            Sale_Price = sale_price;
        }
    }




}
