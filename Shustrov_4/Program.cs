using System;

namespace Shustrov_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double result =
                26 / Math.Pow(
                    Math.Sqrt((3 / (0.2 - 0.1)) / (2.5 * (0.8 + 1.2))) +
                    (34.06 - 33.81) * 4 / (6.84 / Math.Pow(28.57 - 25.15, 1 / 3.0)), 1 / 7.0)
                + Math.Pow(
                    Math.PI / 3 / (4 / 21.0) + Math.Pow((1 + 5 * Math.Sqrt(5)) / 3.5, 1 / 3.0), 1 / 5.0);
            Console.WriteLine("Result: {0}", result);
        }
    }
}