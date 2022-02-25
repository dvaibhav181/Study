using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            int count = 0;
            //Dictionary<char,int> dict = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            // foreach(char c in s1)
            // {
            //     if(!dict.ContainsKey(c))
            //     {
            //         dict[c] = 1;
            //     }
            //     else
            //     {
            //         dict[c]++;
            //     }
            // }

            sb.Append(s1[0]);
            count++;
            for(int i = 1; i < s1.Length; i++)
            {
                if(s1[i] == s1[i-1])
                {
                    count++;
                }
                else{
                    sb.Append(count);
                    sb.Append(s1[i]);
                    count = 1;
                }
            }
            sb.Append(count);
            // foreach(KeyValuePair<char,int> kvp in dict)
            // {
            //     sb.Append(kvp.Key);
            //     sb.Append(kvp.Value.ToString());
            // }
            Console.WriteLine(sb.Length > s1.Length ? s1 : sb.ToString());
        }
    }
}
