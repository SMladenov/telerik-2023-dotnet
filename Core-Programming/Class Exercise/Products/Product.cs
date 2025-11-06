using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Exercise.Products
{
    internal abstract class Product
    {
        public Product(string name, decimal price,double mililiters, List<string> herbs)
        {
            Name = name;

            Price = price;

            Mililiters = mililiters;

            Herbs = herbs;

        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Mililiters { get; set; }

        public List<string> Herbs { get; set; }

        public void GetPromoPrice()
        {
            decimal promoPrice = Price * 0.8m;
            Console.WriteLine(promoPrice);
        }

        public abstract string ToString();

        public virtual void Print()
        {
            Console.WriteLine($"Hello from {Name}");
        }
    }
}
