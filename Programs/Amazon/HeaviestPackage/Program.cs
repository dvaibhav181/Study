using System;
using System.Collections.Generic;

namespace HeaviestPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[]{2,9,10,3,7};
            Console.WriteLine(GetHeaviestPackages(arr));
            
        }

        private static int GetHeaviestPackages(int[] arr)
        {
            var packageList = new List<int>(arr);
            int index = 0;
            var count = 0;
            //&& packageList[index] < packageList[index + 1]
            
            while(packageList.Count > 1)
            {
                if(AllDescending(packageList, packageList.Count) == 1)
                {
                    break;
                }
                int maxIndex = FindIndexOfMaxWeight(packageList);
                if(maxIndex == 0)
                {
                    maxIndex = 1 + FindIndexOfMaxWeight(packageList.GetRange(1,packageList.Count - 1));
                }
                if(maxIndex != 0 && packageList[maxIndex] > packageList[maxIndex - 1])
                {
                    packageList[maxIndex] = packageList[maxIndex - 1] + packageList[maxIndex];
                    packageList.RemoveAt(maxIndex - 1);
                }
            }
            //int finalIndex = FindIndexOfMaxWeight(packageList);
            return packageList[0];
        }

        private static int AllDescending(List<int> packageList, int n)
        {
            // Array has one or no element or the
            // rest are already checked and approved.
            if (n == 1 || n == 0)
                return 1;
 
            // Unsorted pair found (Equal values allowed)
            if (packageList[n - 1] > packageList[n - 2])
                return 0;
 
            // Last pair was sorted
            // Keep on checking
            return AllDescending(packageList, n - 1);
        }

        private static int FindIndexOfMaxWeight(List<int> package)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            for(int i = 0; i < package.Count; i++)
            {
                if(package[i] > max)
                {
                    max = package[i]; 
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
