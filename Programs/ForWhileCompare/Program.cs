using System;
using System.Diagnostics;

namespace ForWhileCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MinValue;
            int max = 1000000000;
            Stopwatch stopWatch = new Stopwatch();
            string read = Console.ReadLine();
            if (read.Length > 1 && read == "While")
            {
                Console.WriteLine("While Loop: ");
                stopWatch.Start();
                WhileLoop(max);
                stopWatch.Stop();
                DisplayElapsedTime(stopWatch.Elapsed);
            }
            else if (read.Length > 1 && read == "RWhile")
            {
                Console.WriteLine("While Loop: ");
                stopWatch.Start();
                ReverseWhileLoop(max);
                stopWatch.Stop();
                DisplayElapsedTime(stopWatch.Elapsed);
            }
            else
            {
                Console.WriteLine("For Loop: ");
                stopWatch.Start();
                ForLoop(max);
                stopWatch.Stop();
                DisplayElapsedTime(stopWatch.Elapsed);
            }
        }

        private static void WhileLoop(int max)
        {
            int i = 0;
            while (i <= max)
            {
                //Console.WriteLine(i);
                i++;
            };
        }

        private static void ReverseWhileLoop(int max)
        {
            int i = max;
            while (i >= 0)
            {
                //Console.WriteLine(i);
                i--;
            };
        }

        private static void ForLoop(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                //Console.WriteLine(i);
            }
        }

        private static void DisplayElapsedTime(TimeSpan ts)
        {
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime, "RunTime");
        }
    }
}
