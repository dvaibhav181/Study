using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SubArraysSumEqualsK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3]{1,2,3};
            int k = 3;
        
            int res = SubarraySum(nums, k);
            Console.WriteLine(res);
        }

        private static string DefangString()
        {
            string address = "1.1.1.1";
        int dotCount = 0,index = 0;
            for(int i = 0; i < address.Length; i++)
        {
            if(address[i] == '.')
            {
                dotCount++;
            }
        }
        
        index = address.Length + dotCount * 2;
        char[] sb = new char[index];

        for(int i = address.Length - 1; i >= 0; i--)
        {
            if(address[i] == '.')
            {
                sb[index - 1] = ']';
                sb[index - 2] = '.';
                sb[index - 3] = '[';
                index = index - 3;
            }
            else
            {
                sb[index - 1] = address[i];
                index--;
            }
        }
        string s = sb.ToString();
        }
        
        private static int SubarraySum(int[] nums, int k) 
        {
            // Stack s = new Stack();
            // int count = 0;
            // int stackSum = 0;
            // for (int i = 0; i < nums.Length;i++)
            // {
                
            //     if(nums[i] == k)
            //     {
            //         //s.Push(nums[i]);
            //         count++;
            //     }
                
            //         if(s.Count == 0)
            //         {
            //             s.Push(nums[i]);
            //         }
            //         else
            //         {
            //             if(nums[i] + Convert.ToInt32(s.Peek()) == k)
            //             {
            //                 s.Push(nums[i]);
            //                 count++;
            //             }
            //             else
            //             {
            //                 s.Push(nums[i]);
            //             }
            //         }
                
            // }
            // while(s.Count > 0 )
            // {
            //     stackSum += Convert.ToInt32(s.Pop());
            // }
            // if(stackSum == k)
            // {
            //     count++;
            // }
            // return count;


            int sum = 0, cnt = 0;    
        var dict = new Dictionary<int,int>();
        StringBuilder sb = new StringBuilder();
        foreach(var n in nums){
            if (dict.ContainsKey(sum)) dict[sum]++; 
            else dict.Add(sum, 1);
            
            sum += n;
            var diff = sum - k;
            if (dict.ContainsKey(diff)) cnt += dict[diff];
        }
        return cnt;
        }
    }
}
