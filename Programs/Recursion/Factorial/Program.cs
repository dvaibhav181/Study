using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            var result1 = findFactorialRecursive(number);
            var result2 = findFactorialIterative(number);
            Console.WriteLine(result1.ToString());
            Console.WriteLine(result2.ToString());
        }

        public static int findFactorialIterative(int number)
        {
            var result = number;;
            if (number == 1)
            {
                return 1;
            }
            else{
                for (int i = number - 1; i > 1; i--)
                {
                    result = result * i;
                }
            }      
            return result;      
        }

        public static int findFactorialRecursive(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else{
                return (number*findFactorialRecursive(number-1));
            }            
        }

        // public static int findFactorialIterative(int number)
        // {
            
        // }
    }
}
