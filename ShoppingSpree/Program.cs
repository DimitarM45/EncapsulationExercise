using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    using Models;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            string[] productsInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                foreach (string person in peopleInfo)
                {
                    string[] personInfo = person
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);

                    people.Add(new Person(name, money));
                }

                foreach (string product in productsInfo)
                {
                    string[] productInfo = product
                        .Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = productInfo[0];
                    decimal cost = decimal.Parse(productInfo[1]);

                    products.Add(new Product(name, cost));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                return;
            }

            string[] tokens = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "END")
            {
                string personName = tokens[0];
                string productName = tokens[1];

                int personIndex = people.FindIndex(p => p.Name == personName);
                int productIndex = products.FindIndex(p => p.Name == productName);

                people[personIndex].BuyProduct(products[productIndex]);

                tokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Person person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");

                    continue;
                }

                string[] currentPersonProducts = person.Products.Select(p => p.Name).ToArray();

                Console.WriteLine($"{person.Name} - {string.Join(", ", currentPersonProducts)}");
            }
        }
    }
}
