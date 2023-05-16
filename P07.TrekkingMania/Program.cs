using System;

namespace P07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //•	Група от 6 до 12 човека – изкачват Монблан
            //•	Група от 13 до 25 човека – изкачват Килиманджаро
            //•	Група от 26 до 40 човека –  изкачват К2
            //•	Група от 41 или повече човека – изкачват Еверест
            int groupCount = int.Parse(Console.ReadLine());

            
            double peopleTotal = 0;
            int peak1 = 0;  //мусала
            int peak2 = 0;  // монблан
            int peak3 = 0;  // килиманджаро
            int peak4 = 0;  // к2
            int peak5 = 0;  // еверест


            for (int i = 1; i <= groupCount; ++i)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                peopleTotal += peopleCount;

                if (peopleCount <= 5)//•	Група до 5 човека – изкачват Мусала
                {
                    peak1 += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    peak2 += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    peak3 += peopleCount;
                }
                else if (peopleCount <= 40)
                {
                    peak4 += peopleCount;
                }
                else if (peopleCount >= 41)
                {
                    peak5 += peopleCount;
                }

            }
            Console.WriteLine($"{(double)peak1 / peopleTotal * 100:F2}%");
            Console.WriteLine($"{(double)peak2 / peopleTotal * 100:F2}%");
            Console.WriteLine($"{(double)peak3 / peopleTotal * 100:F2}%");
            Console.WriteLine($"{(double)peak4 / peopleTotal * 100:F2}%");
            Console.WriteLine($"{(double)peak5 / peopleTotal * 100:F2}%");

            //•	Първи ред - процентът изкачващи Мусала
            //•	Втори ред – процентът изкачващи Монблан
            //•	Трети ред – процентът изкачващи Килиманджаро
            //•	Четвърти ред – процентът изкачващи К2
            //•	Пети ред – процентът изкачващи Еверест


        }
    }
}
