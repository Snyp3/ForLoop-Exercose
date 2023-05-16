using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int payCheck = int.Parse(Console.ReadLine());

            string tabsName;
            for (int i = 0; i < tabs; i++)
            {
                tabsName = Console.ReadLine();
                if (tabsName == "Facebook")
                {

                    payCheck -= 150;
                }
                else if (tabsName == "Instagram")
                {
                    payCheck -= 100;
                }
                else if (tabsName == "Reddit")
                {
                    payCheck -= 50;
                }
                if (payCheck <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (payCheck > 0)
                {
                    Console.WriteLine($"{payCheck}");                    
                }

        }
    }
}
