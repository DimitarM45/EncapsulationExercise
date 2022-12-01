using System;

namespace PizzaCalories.Models
{
    using Models.Constants;

    public class Dough
    {
        private const double BASE_CALORIES = 2;

        private string typeOfFlour;

        private string bakingTech;

        private double weight;

        public Dough(string typeOfFlour, string bakingTech, double weight)
        {
            TypeOfFlour = typeOfFlour;
            BakingTech = bakingTech;
            Weight = weight;
        }

        public string TypeOfFlour
        {
            get => typeOfFlour;

            private set
            {
                if (!FlourType.flourTypes.ContainsKey(value.ToLower()))
                    throw new ArgumentException("Invalid type of dough.");

                typeOfFlour = value;
            }
        }

        public string BakingTech
        {
            get => bakingTech;

            private set
            {
                if (!BakingTechnique.bakingTechniques.ContainsKey(value.ToLower()))
                    throw new ArgumentException("Invalid type of dough.");

                bakingTech = value;
            }
        }

        public double Weight
        {
            get => weight;

            private set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");

                weight = value;
            }
        }

        public double Calories => CalculateCalories();

        private double CalculateCalories() => (BASE_CALORIES * weight) * FlourType.flourTypes[typeOfFlour.ToLower()] * BakingTechnique.bakingTechniques[bakingTech.ToLower()];
    }
}
