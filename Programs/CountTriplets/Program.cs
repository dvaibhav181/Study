using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
        //string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = 5;

        long r = 5;

        List<long> arr = new List<long>(){1,5,5,25,125};

        long ans = countTriplets(arr, r);
        
        System.Console.WriteLine(ans);
        }

        public static long countTriplets(List<long> arr, long r)
        {
            const long V = 0L;
            long count = 0;
            var d1 = arr.Distinct().ToDictionary(Key => Key, Value => V); // count occurrence of value in array
            var d2 = new Dictionary<long, long>(d1); // 

            foreach (var i in arr.Reverse<long>())
            {
                long ir = i * r;

                if (d2.TryGetValue(ir, out long d2ir)) count += d2ir;

                if (d1.TryGetValue(ir, out long d1ir)) d2[i] += d1ir;

                d1[i]++;
            }

            return count;
        }
    }
        
    
}
