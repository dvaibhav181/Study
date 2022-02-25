using System;

namespace PanCakeSort
{
    class Program
    {
        public static void flip(int[] arr, int k)
        {
            int l = 0;
            int r = k;
            
            while(l < r)
            {
                int temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
        }
        public static int[] PancakeSort(int[] arr)
        {
            // your code goes here
                       
            
            for(int i = arr.Length - 1; i > 0; i--)
            {
                int maxValue = -1;
                int maxValueindex = 0; 
                //finding max value from array
                for(int max = 0; max <= i; max++)
                {
                    if(arr[max] > maxValue)
                    {
                        maxValue = arr[max];
                        maxValueindex = max;
                    }
                }
                //flipping the max value
                flip(arr, maxValueindex);
                flip(arr, i);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]{1,5,4,3,2};
            var result = new int[5];

            string source = "ABCDEFG";
            string target = "ABDFFGH";

            int[] letters = new int[26];

            for(int i = 0; i < source.Length; i++)
            {
                letters[source[i] - 'A']--;
            }
            
            for(int i = 0; i < target.Length; i++)
            {
                letters[target[i] - 'A']++;
            }

            result = PancakeSort(arr);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
