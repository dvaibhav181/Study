using System;
using System.Collections.Generic;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "fcrxzwscanmligyxyvym", b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
        //     Dictionary<char, int> lettera = new Dictionary<char, int>();
        //     Dictionary<char, int> letterb = new Dictionary<char, int>();
         int deletions = 0;
        // foreach(char c in a)
        // {
        //     if(!lettera.ContainsKey(c))
        //     {
        //         lettera.Add(c,1);
        //     }
        //     else
        //     {
        //         lettera[c]++;
        //     }
            
        // }
        
        // foreach(char c in b)
        // {
        //     if(!lettera.ContainsKey(c) && !letterb.ContainsKey(c))
        //     {
        //         letterb.Add(c,1);
        //     }
        //     else if(!letterb.ContainsKey(c))
        //     {
        //         letterb.Add(c,1);
        //     }
        //     else
        //     {
        //         letterb[c]++;
        //     }
        // }
        
        // foreach(KeyValuePair<char, int> kvp in letterb)
        // {
        //     if(!lettera.ContainsKey(kvp.Key))
        //     {
        //         deletions += kvp.Value;
        //     }
        //     else
        //     {
        //         deletions += Math.Abs(kvp.Value - lettera.GetValueOrDefault(kvp.Key));
        //     }
        // }

        // foreach(KeyValuePair<char, int> kvp in lettera)
        // {
        //     if(!letterb.ContainsKey(kvp.Key))
        //     {
        //         deletions += kvp.Value;
        //     }
        //     else
        //     {
        //         deletions += Math.Abs(kvp.Value - letterb.GetValueOrDefault(kvp.Key));
        //     }
        // }

        List<int> list = new List<int>(new int[26]);
        int total = 0;
        
        foreach (char item in a) { var val = item - 'a'; list[item - 'a']++; }
        foreach (char item in b) { list[item - 'a']--; }
        foreach (int item in list) { deletions += Math.Abs(item); }

        System.Console.WriteLine(deletions); 
        }
    }
}
