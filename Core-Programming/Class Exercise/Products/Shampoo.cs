using System.Collections.Generic;

namespace Class_Exercise.Products
{
    internal class Shampoo : Product
    {
        public Shampoo(string name, decimal price, Gender gender, double mililiters, List<string> herbs)
            : base(name, price, mililiters, herbs)
        {
            Sex = gender;
        }

        public Gender Sex { get; set; }

        public override string ToString()
        {
            return "I am paste";
        }
    }
}
