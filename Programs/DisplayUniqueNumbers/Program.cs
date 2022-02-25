using System;
using System.Collections.Generic;

namespace DisplayUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>();
            Console.WriteLine("Enter Number: ");
            while(true)
            {
                var input = Console.ReadLine();
                if(input.ToLower() == "quit")
                    break;
                // else if (number.Contains(Convert.ToInt32(input)))
                //     break;
                else
                    number.Add(Convert.ToInt32(input));
            }
            
            var uniques = new List<int>();
            foreach(var item in number)
            {
                if(!uniques.Contains(item))
                    uniques.Add(item);
            }

            foreach(var unique in uniques)
                Console.WriteLine(unique);
        }
    }
}
