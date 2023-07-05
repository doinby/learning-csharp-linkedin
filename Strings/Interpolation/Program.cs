using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting


            // TODO: Using string interpolation
            // Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and cost ${price:C2}");

            // TODO: With inline expressions
            Console.WriteLine($"This car is a {year} {make} {model}, with {{{miles * 1.6:F2}}} kms and cost ${price:C2}");
        }
    }
}
