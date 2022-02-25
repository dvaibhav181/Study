using System;
using System.Collections.Generic;

namespace FiveNumberSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var fiveNumbers = new List<int>();

            while(fiveNumbers.Count < 5)
            {
               Console.WriteLine("Enter Number: ");
               var input = Console.ReadLine();

               if(fiveNumbers.Contains(Convert.ToInt32(input)))
                {
                    Console.WriteLine("Already entered {0}",Convert.ToInt32(input));
                    continue;
                }    
                

                fiveNumbers.Add(Convert.ToInt32(input));
            }
            fiveNumbers.Sort();
            Console.WriteLine("\nSorted numbers are: ");
            foreach (var number in fiveNumbers) 
                Console.WriteLine(number);
        }
    }
}
