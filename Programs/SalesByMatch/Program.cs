using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = sockMerchant(9, new int[]{10,20,20,10,10,30,50,10,20});
            Console.WriteLine("Hello World!");
        }

        static int sockMerchant(int n, int[] ar) {
        if(n < 1 || n > 100)
        {
            return 0;
        }
        int count = 1;
        int pairs = 0;
        Dictionary<int, int> ht = new Dictionary<int, int>();
        for(int i = 0 ; i < n ; i++)
        {
            if(!ht.ContainsKey(ar[i]))
            {
               ht.Add(ar[i],count);
            }
            else
            {
                var value = ht[ar[i]];
                ht[ar[i]] = value + 1;
            }
        }
        
        foreach(KeyValuePair<int, int> kvp in ht)
        {
            pairs += (kvp.Value / 2);
        }
        
        return pairs;
    }

    }
}
