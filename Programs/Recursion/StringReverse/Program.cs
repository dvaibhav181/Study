using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            reverseStringRecursion("Hello World!");
            
        }

        public static void reverseStringRecursion(string str)
        {
            if(str.Length == 0)
            {
                return;
            }
            else
            {
                reverseStringRecursion(str.Substring(1));
                Console.Write(str[0]);
            }
        }
    }        
}
