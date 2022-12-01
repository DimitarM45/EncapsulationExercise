using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;

        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
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

        public decimal Cost
        {
            get => cost;

            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");

                cost = value;
            }
        }
    }
}
