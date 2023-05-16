using System;

namespace P02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;
            int minNum = int.MaxValue; 

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber ;
                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber ;
                }
                if (currentNumber < minNum)
                {
                    minNum = currentNumber ;
                }
            }
            sum -= maxNum;
            if (maxNum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int diff = maxNum - sum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + Math.Abs(diff));
            }
        }
    }
}
