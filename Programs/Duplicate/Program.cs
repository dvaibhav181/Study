using System;
using System.Collections;
using System.Collections.Generic;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{};
            bool isDuplicate = ContainsDuplicate(nums);
            System.Console.WriteLine(isDuplicate.ToString());
            // Console.WriteLine("Enter numbers: ");
            // var input = Console.ReadLine();
            // var charstring = new List<string>();

            // if (String.IsNullOrWhiteSpace(input))
            //     return;
            
            // if (!input.Contains("-") && !String.IsNullOrWhiteSpace(input))
            // {
            //     System.Console.WriteLine("Enter numbers with hyphen in between");
            //     input = Console.ReadLine();
            // }

            // foreach (var item in input.Split('-'))
            // {
            //     if(!charstring.Contains(item))
            //     {
            //         charstring.Add(item);
            //     }  
            //     else{
            //         System.Console.WriteLine("Duplicate is {0}", item);
            //     }   
            // }

            // foreach (var strings in charstring)
            // {
            //     System.Console.WriteLine(strings);
            // }
        }

        public static bool ContainsDuplicate(int[] nums) {
        
        if(nums == null || nums.Length == 0)
        {
            return false;
        }
        
        Hashtable ht = new Hashtable();
        
        for(int i = 0; i <= nums.Length - 1; i++)
        {
            if(ht.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                ht[nums[i]] = 1;
            }
        }
        return false;
    }
    }
}
