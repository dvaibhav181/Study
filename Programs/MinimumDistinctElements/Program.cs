using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumDistinctElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[8]{2,4,1,5,3,5,1,3};
            //int[] arr = new int[6]{2,2,1,3,3,3};
            int[] arr = new int[7]{7,5,5,6,7,7,6};
            int k = 6;

            Dictionary<int, int> hash = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(hash.ContainsKey(arr[i]))
                {
                    hash[arr[i]]++;
                }
                else
                {
                    hash.Add(arr[i],1);
                }
            }

            int val = 0;
            foreach (var item in hash.OrderBy(x => x.Value))
            {
                val += item.Value;
                if (val > k)
                {
                    break;
                }
                else
                {
                    hash.Remove(item.Key);
                }
            }

            System.Console.WriteLine(hash.Count());
        }
    }
}
