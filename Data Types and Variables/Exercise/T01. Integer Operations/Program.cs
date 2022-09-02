using System;

namespace T08_Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double value1 = 0;
            double value2 = 0;
            string name = null;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = float.Parse(Console.ReadLine());
                double height = float.Parse(Console.ReadLine());

                value1 = Math.PI * (radius * radius) * height;
                if (value1 > value2)
                {
                    value2 = value1;
                    name = model;
                }

            }
            Console.WriteLine(name);
        }
    }
}
