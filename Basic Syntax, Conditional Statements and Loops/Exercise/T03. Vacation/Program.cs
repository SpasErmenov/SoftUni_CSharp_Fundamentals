using System;

namespace T03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
            }

            

            if (groupType == "Students" && peopleCount >= 30)
            {
                price *= peopleCount;
                price -= (price * 0.15);
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                peopleCount -= 10;
                price *= peopleCount;
            }
            else if (groupType == "Regular" && (peopleCount >= 10 && peopleCount <= 20))
            {
                price *= peopleCount;
                price -= (price * 0.05);
            }
            else
            {
                price *= peopleCount;
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
