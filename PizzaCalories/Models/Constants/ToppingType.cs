using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models.Constants
{
    public static class ToppingType
    {
        public static readonly Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            { "meat", 1.2},
            { "veggies", 0.8},
            { "cheese", 1.1},
            { "sauce", 0.9},
        };
    }
}
