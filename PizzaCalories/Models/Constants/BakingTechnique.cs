using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models.Constants
{
    public static class BakingTechnique
    {
        public static readonly Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            { "crispy", 0.9},
            { "chewy", 1.1},
            { "homemade", 1.0},
        };
    }
}
