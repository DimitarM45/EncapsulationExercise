﻿namespace AnimalFarm
{
    using System;
    using AnimalFarm.Models;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chicken = new Chicken(name, age);

                Console.WriteLine($"Chicken {name} (age {age}) can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
