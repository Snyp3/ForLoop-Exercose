using System;
using System.ComponentModel;

namespace P08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	W - ако е победител получава 2000 точки
            //	F - ако е финалист получава 1200 точки
            //	SF - ако е полуфиналист получава 720 точки

            int turnaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int currentPoints = 0;
            int winCount = 0;
            for (int i = 0; i < turnaments; i++)
            {
                string winLose = Console.ReadLine();

                if (winLose == "W")
                {
                    currentPoints += +2000;
                    winCount++;
                }
                else if (winLose == "F")
                {
                    currentPoints += +1200;
                }
                else if (winLose == "SF")
                {
                    currentPoints += +720;
                }
            }
            int totalPoints = startingPoints + currentPoints;
            double avaregePoints = currentPoints / turnaments;
            double winRate = ((double)winCount / turnaments) * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {avaregePoints}");
            Console.WriteLine($"{winRate:F2}%");
        }
    }
}
