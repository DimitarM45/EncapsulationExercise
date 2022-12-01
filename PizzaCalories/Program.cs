using System;

namespace PizzaCalories
{
    using Models;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaInfo = Console.ReadLine().Split();

            string pizzaName = pizzaInfo[1];

            string[] doughInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string flourType = doughInfo[1];
            string bakingTechnique = doughInfo[2];

            double doughWeight = double.Parse(doughInfo[3]);

            try
            {
                Dough dough = new Dough(flourType, bakingTechnique, doughWeight);

                Pizza pizza = new Pizza(pizzaName);

                pizza.Dough = dough;

                while (true)
                {
                    string[] toppingInfo = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (toppingInfo[0] == "END")
                        break;

                    string toppingName = toppingInfo[1];

                    double toppingWeight = double.Parse(toppingInfo[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
