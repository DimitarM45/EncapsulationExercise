using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models.Constants
{
    public static class FlourType
    {
        public static readonly Dictionary<string, double> flourTypes = new Dictionary<string, double>
        {
            { "white", 1.5},
            { "wholegrain", 1.0},
        };
    }
}
