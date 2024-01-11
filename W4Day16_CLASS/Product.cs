using System;
using System.Collections.Generic;
using System.Text;

namespace W4Day16_CLASS
{
    internal class Product
    {

        public Product(string Name)
        {
            this.Name = Name;
        }

        public Product(string Name, double Price):this(Name)
        {
            this.Price = Price;
        }

        public string Name;
        public double Price = 10;
        public Product[] products;

        
        public double AveragePrice(Product[] products)
        {
            double total = 0;
            for (int i = 0; i < products.Length; i++)
            {
                total += products[i].Price;
            }
            double averagePrice = total / products.Length;
            return averagePrice;
        }

        public void MostExpensiveProduct(Product[] products)
        {
            double mostExpensive = products[0].Price;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i].Price > mostExpensive)
                {
                    mostExpensive = products[i].Price;
                }
            }
            Console.WriteLine(mostExpensive);
        }

        public void CheapestProduct(Product[] products)
        {
            double mostExpensive = products[0].Price;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i].Price < mostExpensive)
                {
                    mostExpensive = products[i].Price;
                }
            }
            Console.WriteLine(mostExpensive);
        }

    }
}
