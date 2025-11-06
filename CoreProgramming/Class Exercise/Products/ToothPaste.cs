using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Exercise.Products
{
    internal class ToothPaste : Product
    {
        public ToothPaste(string name, decimal price, double mililiters, List<string> herbs)
            : base(name, price, mililiters, herbs) { }

        public override string ToString()
        {
            return "I am paste";
        }
    }
}
