using System;
using System.Collections.Generic;

namespace Likes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLikes = new List<string>();
            while(true)
            {
                Console.WriteLine("Enter Name: ");
                var input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input))
                    break;

                numberOfLikes.Add(input);
            }

            int countOfNames = numberOfLikes.Count;

            if (countOfNames == 1)
                    Console.WriteLine("{0} likes your post.", numberOfLikes[0].ToString());
            else if (countOfNames == 2)
                    Console.WriteLine("{0} and {1} like your post.", numberOfLikes[0].ToString(),numberOfLikes[1].ToString());
            else if (countOfNames > 2)
                    Console.WriteLine("{0},{1} and {2} others like your post.", numberOfLikes[0].ToString(),numberOfLikes[1].ToString(),numberOfLikes.Count - 2);
            else
                Console.WriteLine();
                
            foreach(var item in numberOfLikes)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
