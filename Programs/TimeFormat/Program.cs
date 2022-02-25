using System;

namespace TimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in 24-hour format: ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input) || input.Split(":").Length > 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }   

            var timeNumber = input.Split(":");

            if((Convert.ToInt32(timeNumber[0]) >= 0 && Convert.ToInt32(timeNumber[0]) < 24) &&
                (Convert.ToInt32(timeNumber[1]) >= 0 && Convert.ToInt32(timeNumber[1]) < 60))
            {
                Console.WriteLine("Valid Time");
            }
            else
            {
                Console.WriteLine("Invalid Time");   
            }
        }
    }
}
