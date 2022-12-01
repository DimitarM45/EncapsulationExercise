using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        protected string name;

        protected decimal money;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name
        {
            get => name;

            protected set
            {
                if (value == "" || value == null || value == " ")
                    throw new ArgumentException("Name cannot be empty");

                name = value;
            }
        }

        public decimal Money
        {
            get => money;

            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");

                money = value;
            }
        }

        public List<Product> Products { get; protected set; }

        public void BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");

                return;
            }

            Products.Add(product);

            Console.WriteLine($"{Name} bought {product.Name}");

            Money -= product.Cost;
        }
    }
}
