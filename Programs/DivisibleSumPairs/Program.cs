using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = 6;

        int k = 3;

        
        //                  [2,0,1,0,2,1]
        //bucket[0] = 2; bucket[1] =2; bucket[2] = 2
        //int result = migratoryBirds(ar);
//         string name = "sandeep";    
// string myName = name;    
// Console.WriteLine("== operator result is {0}", name == myName);    
// Console.WriteLine("Equals method result is {0}", name.Equals(myName));    
        var i = 0;
        var j = 0;
        System.Console.WriteLine(++i);
        
        System.Console.WriteLine(j++);

        }

        // Complete the divisibleSumPairs function below.
    static int migratoryBirds(List<int> arr) {
        Dictionary<int, int> typeCount = new Dictionary<int, int>();
        //int[] typeCount = new int[arr.Count];
        int count = 0;
        for(int i = 0; i < arr.Count; i++)
        {
            if(typeCount.ContainsKey(arr[i]))
            {
                typeCount[arr[i]] += 1;
            }
            else{
                typeCount[arr[i]] = 1;
            }
        }
        
        var maxVal = typeCount.Aggregate((l,r) => l.Value > r.Value ? l : r).Value;
        var findKey = typeCount.Where(x => x.Value == maxVal).Select(x => x.Key).Min();

        return findKey;
    }
    
    }
}
