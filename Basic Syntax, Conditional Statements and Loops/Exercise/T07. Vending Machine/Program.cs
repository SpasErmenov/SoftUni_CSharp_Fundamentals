using System;

namespace T07_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string insurtCoins = string.Empty;
            double sumOfCoins = 0;
            string chooseProduct = string.Empty;
            double productPrice = 0;

            const double nutsPrice = 2;
            const double waterPrice = 0.7;
            const double crispsPrice = 1.5;
            const double sodaPrice = 0.8;
            const double cokePrice = 1;

            do
            {
                insurtCoins = (Console.ReadLine());
                if (insurtCoins == "0.1")
                {
                    sumOfCoins += double.Parse(insurtCoins);
                }
                else if (insurtCoins == "0.2")
                {
                    sumOfCoins += double.Parse(insurtCoins); ;
                }
                else if (insurtCoins == "0.5")
                {
                    sumOfCoins += double.Parse(insurtCoins); ;
                }
                else if (insurtCoins == "1")
                {
                    sumOfCoins += double.Parse(insurtCoins); ;
                }
                else if (insurtCoins == "2")
                {
                    sumOfCoins += double.Parse(insurtCoins); ;
                }
                else if (insurtCoins != "0.1" && insurtCoins != "0.2" && insurtCoins != "0.5"
                        && insurtCoins != "1" && insurtCoins != "2" && insurtCoins != "Start")
                {
                    Console.WriteLine($"Cannot accept {insurtCoins}");
                }

            } while (insurtCoins != "Start");

            do
            {
                chooseProduct = Console.ReadLine();
                if (chooseProduct == "Nuts" && sumOfCoins >= nutsPrice)
                {
                    sumOfCoins -= nutsPrice;
                    Console.WriteLine($"Purchased {chooseProduct}");
                }
                else if (chooseProduct == "Water" && sumOfCoins >= waterPrice)
                {
                    sumOfCoins -= waterPrice;
                    Console.WriteLine($"Purchased {chooseProduct}");
                }
                else if (chooseProduct == "Crisps" && sumOfCoins >= crispsPrice)
                {
                    sumOfCoins -= crispsPrice;
                    Console.WriteLine($"Purchased {chooseProduct}");
                }
                else if (chooseProduct == "Soda" && sumOfCoins >= sodaPrice)
                {
                    sumOfCoins -= sodaPrice;
                    Console.WriteLine($"Purchased {chooseProduct}");
                }
                else if (chooseProduct == "Coke" && sumOfCoins >= cokePrice)
                {
                    sumOfCoins -= cokePrice;
                    Console.WriteLine($"Purchased {chooseProduct}");
                }
                else if (chooseProduct != "Nuts" && chooseProduct != "Water" && chooseProduct != "Crisps" && 
                         chooseProduct != "Soda" && chooseProduct != "Coke" && chooseProduct != "End")
                {
                    Console.WriteLine("Invalid product");
                }

                if (true)
                {

                }

            } while (chooseProduct != "End");

        }
    }
}
