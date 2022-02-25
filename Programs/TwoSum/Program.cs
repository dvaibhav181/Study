using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[6]{-1,0,1,2,-1,-4};
            //var result = ThreeSum(nums);//TwoSum(nums,target);
            int x = 121;
            var result = ReverseInt(x);
            System.Console.WriteLine(result);
             
        }

        public static bool ReverseInt(int x)
        {
            // StringBuilder news = new StringBuilder();
            // try
            // {
            //     var s = Convert.ToString(x < 0 ? Math.Abs(x) : x).ToCharArray();
            //     System.Console.Write(x < 0 ? "-" : "");
            //     news.Append(x < 0 ? '-' : ' ');
            //     for(int i = s.Length - 1; i >= 0; i--)
            //     {
            //         news.Append(s[i]);
            //     }   
            // }
            // catch(Exception)
            // {
            //     return 0;
            // }
            // return Convert.ToInt32(news.ToString());

            long reversed = 0;int temp = x;
            while (x != 0)
            {
                reversed = reversed*10 + (temp%10);
                temp = temp/10;
            }

            if (reversed >= int.MaxValue || reversed <= int.MinValue)
            {
                return false;
            }
            
            return reversed.Equals(x) ? true : false;
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> retr = new List<IList<int>>();
            IList<int> subretr = new List<int>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {   
                var param = new int[nums.Length - i - 1];
               Array.Copy(nums,i+1,param,0,nums.Length-i-1);
                
                var twosum = TwoSum(param,0);
                if(twosum.Length > 0)
                {
                    subretr.Add(nums[i]);
                    subretr.Add(twosum[0]);
                    subretr.Add(twosum[1]);
                }
            }
            retr.Add(subretr);

            return retr;
        }

        public static int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> hashDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(hashDict.ContainsKey(target - nums[i]))
            {
               return new int[2]{nums[i],hashDict.FirstOrDefault(x => x.Value == nums[i]).Key};
            }
            hashDict[nums[i]] = i;
        }
        return new int[2];
        /*var i = 0;
        var j = 0;
        var twoIndices = new int[2];
        
        if(nums == null || nums.Length < 2 )
        {
            throw new System.ArgumentException("Parameter cannot be null", "original");
        }
        
        while (i < nums.Length)
        {
            if (nums[i] == target)
            {
                j = nums.Length - 1;
                break;
            }
            if (nums[i] < target)
            {
                j = i;  
            }
            i++;
        }
            
        var start = 0;
        if(j == 0)
        {
            j = nums.Length - 1;
        }

        while (start < j)
        {
            if(nums[start] + nums[j] == target)
            {
                twoIndices[0] = start;
                twoIndices[1] = j;
                break;
            }
            if (nums[start] + nums[j] < target)
            {
                start++ ;
                continue;
            }
            else if (nums[start] + nums[j] > target && nums[start] < nums[start + 1])
            {
                j--;
                continue;
            }
            else{
                start++;
            }
        }
        return twoIndices;*/
        }
    }
}
