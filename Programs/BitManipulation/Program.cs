using System;
using System.Collections;
using System.Collections.Generic;

namespace BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // int SumResult = GetSum(-1,-2);
            // Queue myQueue = new System.Collections.Queue();
            // Queue<Dictionary<int,int>> newQueue = new Queue<Dictionary<int,int>>();
            // IList<IList<int>> result;
            // newQueue.Enqueue(new Dictionary<int, int>(){{3,1}});
            // var sublist = newQueue.Dequeue();          
            int[] inOrder = new int[]{9,3,15,20,7};
            int[] preOrder = new int[]{3,9,20,15,7};

            int mid = Array.IndexOf(inOrder,preOrder[0]);

            int i,j = 0;
            string str = "vaibhav";
            
            
            //int SubstractResult = GetDiff(-3,-2);
            //System.Console.WriteLine(SubstractResult);
        }

        private static int GetDiff(int v1, int v2)
        {
            int borrow = 0;
            while(v2 != 0)
            {
                borrow = ~v1 & v2;
                v1 = v1 ^ v2;
                v2 = borrow << 1;
            }

            return v1;
        }

        private static int GetSum(int v1, int v2)
        {
            int carry = 9;
            char c = 'a';
            Dictionary<int,List<string>> hashTable = new Dictionary<int,List<string>>();
            string s = "vaibhav";
            //List<string> s = new List<string>{"a"};
            //hashTable.Add(1,{"b","a","b"});
            foreach(char i in s)
            {
                System.Console.WriteLine((int)i);
            }
            
            System.Console.WriteLine();
            while(v2 != 0)
            {
                carry = v1 & v2;
                v1 = v1 ^ v2;
                v2 = carry << 1;
            }

            return v1;
        }
    }
}
