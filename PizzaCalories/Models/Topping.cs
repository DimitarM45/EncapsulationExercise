using System;

namespace PizzaCalories.Models
{
    using Constants;

    public class Topping
    {
        private const double BASE_CALORIES = 2;

        private string type;

        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;

            private set
            {
                if (!ToppingType.toppingTypes.ContainsKey(value.ToLower()))
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");

                type = value;
            }
        }

        public double Weight
        {
            get => weight;

            private set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");

                weight = value;
            }
        }

        public double Calories => CalculateCalories();

        private double CalculateCalories() => BASE_CALORIES * weight * ToppingType.toppingTypes[Type.ToLower()];
    }
}
