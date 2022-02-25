using System;
using System.Collections.Generic;

namespace PrimeAndPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a: ");
            //var a = Convert.ToDouble(Console.ReadLine());
            
            //Console.WriteLine("Enter b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            // List<int> result = PalindromicPrimes(a,b);
            // foreach (var item in result)
            // {
            //     Console.Write(item + " ");
            // }
            Console.WriteLine(Convert.ToInt32(AddDigits(63)));

        }

        private static double AddDigits(int a)
        {
            if(a == 0)
                return 1;

            // var M = Math.Pow(2,a);
            // 32 bit int range - -2,147,483,648 to 2,147,483,647
            // 32 bit uint range - 0 to 4,294,967,295
            // 64 bit long range - -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // 64 bit ulong range - 0 to 18,446,744,073,709,551,615

             ulong M = (ulong) (1 << a); // shifts number 1 a times to left in binary
             ulong sum = 0;
             ulong temp = M;

            
            while(temp > 0 || sum > 9)
            {
                if(temp == 0)
                {
                    temp = sum;
                    sum = 0;
                }
                sum += temp % 10;
                temp = temp / 10;
            }
            // var tempSum = sum;
            // while(tempSum.ToString().Length > 1)
            // {
            //     var finalSum = 0;
            //     foreach(var item in tempSum.ToString())
            //     {
            //         finalSum += item - '0';
            //     }
            //     tempSum = finalSum;
            //     //tempSum += sum % 10;
            //     //sum = Math.Floor(sum / 10);
            // }
            return sum;
        }

        private static List<int> PalindromicPrimes(int a, int b)
        {
            List<int> output = new List<int>();

            List<int> primes = ListPrimes(a,b);   

            foreach(var item in primes)
            {
                if(IsPalindrome(item))
                {
                    output.Add(item);
                }
            }
            return output;
        }

        private static bool IsPalindrome(int num)
        {
            int temp = num;
            int reverse = 0;
            int remainder = 0;
            while(num > 0)
            {
                remainder = num%10;
                reverse = reverse * 10 + remainder;
                num/=10;
            }

            return reverse == temp ? true : false;
            // if(reverse == temp)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }

        private static List<int> ListPrimes(int a, int b)
        {
            List<int> primes = new List<int>();
            int flag;
            //check whether a is less than 2
            if(a == 1)
            {
                primes.Add(a);
                a++;
                if(b >= 2)
                {
                    primes.Add(a);
                    a++; 
                }
            }

            if(a == 2)
            {
                primes.Add(a);
            }

            //making sure that a is odd
            if(a%2 == 0)
            {
                a++;
            }

            //traverse only for odd numbers
            for(int i = a; i <= b; i = i + 2)
            {
                //flag to check if number is prime
                flag = 1;

                //traverse till square root of j only
                for(int j = 2 ; j * j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if(flag == 1)
                {
                    primes.Add(i);
                }

            }

            return primes;
        }
    }
}
