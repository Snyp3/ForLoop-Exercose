using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double pointsTotal = 0;
            double pointsJury = 0;
            for (int i = 0; i < n; i++)
            {
                string jury = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                pointsJury = pointsJury + (jury.Length * points) / 2;

                pointsTotal = academyPoints + pointsJury;

                if (pointsTotal > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsTotal:F1}!");
                    break;
                }
            }
            if (1250.5 > pointsTotal )
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsTotal:F1} more!");
            }
        }
    }
}
