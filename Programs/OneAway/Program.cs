using System;
using System.Collections.Generic;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "pale";
            string s2 = "balle";
            int counter = 0;
            Dictionary<char,int> dict = new Dictionary<char, int>();

            foreach(char c in s1)
            {
                if(!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else{
                    dict[c]++;
                }
            }

            foreach(char c in s2)
            {
                if(dict.ContainsKey(c))
                {
                    dict.Remove(c);
                }
            }
            counter = dict.Count;
            Console.WriteLine(counter > 1 ? "false" : "true");
        }
    }
}
