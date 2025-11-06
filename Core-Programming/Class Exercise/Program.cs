using Class_Exercise.Products;
using System;
using System.Collections.Generic;

namespace Class_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> herbs = new List<string> { "oil", "garlic" };
            List<string> herbs2 = new List<string> { "virgin oil", "garlic", "basil" };


            var cream = new Cream("Dove", 2.25m, Gender.M, 550, herbs);
            var shampoo = new Shampoo("Cien", 3.45m, Gender.X, 500, herbs2);

            var toohPaste = new ToothPaste("Lacalut", 2.45m, 100, herbs);

            var products = new List<Product>();
            products.Add(cream);
            products.Add(shampoo);
            products.Add(toohPaste);

            foreach (var item in products)
            {
                item.Print();
            }

        }
    }
}
