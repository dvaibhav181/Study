using System;

namespace ElectronicShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] keyboards = new int[]{40,50,60};
            int[] drives = new int[]{5,8,12};
            int b = 60;
            int moneySpent = getMoneySpent(keyboards, drives, b);

        }

        static int getMoneySpent(int[] keyboards, int[] drives, int b) 
        {
        if(b < 1 || keyboards.Length < 1 || drives.Length < 1)
        {
            return -1;
        }
        int max = -1;
        // for(int i = 0; i<keyboards.Length; i++)
        // {
        //     if (keyboards[i] < b)
        //     {
        //         for (int j = 0; j < drives.Length; j++)
        //         {
        //             if(keyboards[i] + drives[j] > max && keyboards[i] + drives[j] < b)
        //             {
        //                 max = keyboards[i] + drives[j];
        //             }
        //         }
        //     }
        // }
        Array.Reverse(keyboards);
        Array.Sort(drives);
        int count = 0;
        for(int i = 0,j  = 0; i<keyboards.Length; i++)
        {
            //if (keyboards[i] < b)
            //{
                for (; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] > b) 
                    {
                        break;
                    }
                    if(keyboards[i] + drives[j] > max )
                    {
                        max = keyboards[i] + drives[j];
                    }
                    count++;
                }
            //}
        }
        return max;

    }
    }
}
