using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;

        private Dough dough;

        private List<Topping> toppings;

        public Pizza(string name)
        {
            toppings = new List<Topping>();
            Name = name;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

                name = value;
            }
        }

        public int Count => toppings.Count;

        public Dough Dough { get; set; }

        public double Calories => CalculateCalories();

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");

            toppings.Add(topping);
        }

        private double CalculateCalories()
        {
            double totalToppingCalories = 0;

            foreach (Topping topping in toppings)
                totalToppingCalories += topping.Calories;

            return totalToppingCalories + Dough.Calories;
        }

        public override string ToString() => $"{Name} - {Calories:f2} Calories.";
    }
}
