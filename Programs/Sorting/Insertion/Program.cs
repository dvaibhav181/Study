using System;
using System.Collections.Generic;
using System.Linq;

namespace Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> {4,3,1,2};
            InsertionSort(num);

            //List<int> num1 = new List<int> {5,1,2,3,7,8,6,4};
            //List<int> num1 = new List<int> {1,2,5,3,7,8,6,4};
            //InsertionSortBribe(num1);
            
            //int[] num2 = new int[]{2,3,1,5,4};
            //MinimumBribes(num2);
            
        }

        private static void InsertionSort(List<int> num)
        {
            int counter = 0;
            for (int i=0; i < num.Count; i++){
                if(num[i] < num[0])
                    {
                        var temp = num[i];
                        num.RemoveAt(i);
                        num.Insert(0,temp);
                        counter++;
                    }
                for (int j = i + 1; j < num.Count; j++){
                    if(num[j] < num[i])
                    {
                        var temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                        counter++;
                    }
                }
            }
            System.Console.WriteLine(counter);
        }

        public static void MinimumBribes(int[] q)
        {
            int totalBribes = 0;
    
            int expectedFirst = 1;
            int expectedSecond = 2;
            int expectedThird = 3;
            
            for (int i = 0; i < q.Length; ++i) {
                if (q[i] == expectedFirst) {
                    expectedFirst = expectedSecond;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                } else if (q[i] == expectedSecond) {
                    ++totalBribes;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                } else if (q[i] == expectedThird) {
                    totalBribes += 2;
                    ++expectedThird;
                } else {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
            Console.WriteLine(totalBribes);
        }

        private static void InsertionSortBribe(List<int> num)
        { int[] arr = new int[5];
        //bool flag = true;
        
        Dictionary<int, int> numcount = new Dictionary<int, int>();
        for(int i = 0 ; i < num.Count; i++)
        {
            numcount.Add(num[i],0);
        }
            int counter = 0;
            for (int i=0; i < num.Count; i++){
                if(num[i] < num[0])
                    {
                        numcount[num[i]]++;
                        var temp = num[i];
                        num.RemoveAt(i);
                        num.Insert(0,temp);
                        counter++;
                    }
                for (int j = i + 1; j < num.Count; j++){
                    if(num[j] < num[i])
                    {
                        numcount[num[i]]++;
                        var temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                        counter++;
                    }
                }
            }
            if(numcount.Values.Max() > 2)
            {
                System.Console.WriteLine("Too chaotic");
            }
            else{
                System.Console.WriteLine(numcount.Values.Sum());
            }
        }
    }
}
