using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageLili = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int money = 0;

            for (int i = 1; i <= ageLili; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += priceToy;
                }

            }

            if (money >= priceWasher)
            {
                Console.WriteLine($"Yes! {money - priceWasher:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWasher - money:F2}");
            }
        }
    }
}
