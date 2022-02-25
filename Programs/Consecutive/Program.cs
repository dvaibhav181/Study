using System;
using System.Collections.Generic;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            var input = Console.ReadLine();
            var intstring = new List<int>();
            
            if (!input.Contains("-"))
            {
                System.Console.WriteLine("Enter numbers with hyphen in between");
                input = Console.ReadLine();
            }

            foreach (var item in input.Split('-'))
            {
                intstring.Add(Convert.ToInt32(item));
            }
            
            intstring.Sort();
            
            var isConsecutive = true;
            for(int i = 1; i<intstring.Count;i++)
            {
                if (intstring[i] != intstring[i-1]+1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }
}
