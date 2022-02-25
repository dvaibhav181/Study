using System;

namespace KthGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KthGrammar(3, 2) );
        }

        public static int KthGrammar(int n, int k) 
        {
            if(n == 1 && k == 1)
                return 0;
        
            /*
                    k
            n = 1   0
            n = 2   01
            n = 3   0110
            n = 4   01101001
            
            n is 1-indexed, however the actual value of n is n - 1, so recursive function can be called on n - 1;
            for value of k, when n = 4, the first half of n = 4 is equal to n = 3, hence we take mid variable as
            mid = 2^n-1 / 2; the for n = 4, mid = 2^4-1 / 2 ; mid  = 2^3 / 2; mid = 4
            Hence, when k is less than or equal to mid, call recursive function for n - 1 and k
            when k is greater than mid, the second half of n = 4 is exact opposite of value of k for n = 3, hence
            call recursive function for n - 1 and k - mid and negate the value.
            
            */
        
        
            int mid = (int)((Math.Pow(2,n-1)) / 2);
            if(k <= mid)
                return KthGrammar(n - 1, k);
            else
                return Convert.ToInt32(!Convert.ToBoolean(KthGrammar(n - 1, k - mid)));
        }
    }
}
