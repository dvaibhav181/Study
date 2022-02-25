using System;
using System.Collections.Generic;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();
            var nameArr = new Char[input.Length];
            
            for(int i=input.Length;i>0;i--)
            {
                nameArr[input.Length - i] = input[i-1];
            }

            var reversedArray = new string(nameArr);
            Console.WriteLine(reversedArray);
        }
    }
}
