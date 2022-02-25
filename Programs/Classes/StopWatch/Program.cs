using System;

namespace StopWatchClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var swObject = new StopWatch();
				int choice;

				do
				{
					System.Console.Write("Enter 1 - Start Watch\n2 - Stop Watch\n3. Read Timer\n0. Quit\n");
					choice = Convert.ToInt32(Console.ReadLine());

					switch(choice)
					{
						case 1:
							swObject.Start();
							break;

						case 2:
							swObject.Stop();
							break;

						case 3:
							Console.WriteLine(swObject.Duration().ToString());
							break;

					}
				} while (choice !=0);


            // swObject.Start();
            // Console.WriteLine("Stopwatch started.....");
            // Random random = new Random();
            // var nextRandom = random.Next(1,100);
            // for (int i = 0; i < nextRandom ; i++)
            // {
            //     System.Console.WriteLine("Waiting {0} times", nextRandom - i);    
            // }
            // swObject.Stop();
            // Console.WriteLine("Stopwatch stopped.....");
            // var timeduration = swObject.Duration().ToString();
            // Console.WriteLine(timeduration);
        }
    }
}
