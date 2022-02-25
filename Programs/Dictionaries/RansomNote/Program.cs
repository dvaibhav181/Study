using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note) {
        if(magazine == null || magazine.Length < 1 || note == null || note.Length < 1)
        {
            Console.WriteLine("Incorrect Input");
            return;
        }
        
        Dictionary<string, int> magazineDictionary = new Dictionary<string, int>();
        Dictionary<string, int> noteDictionary = new Dictionary<string, int>();
        //int noteWordCounter = 1, magWordCounter = 1;
        foreach(string word in note)
        {   
            if(!noteDictionary.ContainsKey(word))
            {
                noteDictionary.Add(word, 1);
            }
            else
            {
                noteDictionary[word]++;
            }   
        }
        
        foreach(string word in magazine)
        {   
            if(!magazineDictionary.ContainsKey(word))
            {
                magazineDictionary.Add(word, 1);
            }
            else
            {
                magazineDictionary[word]++;
            }   
        }
        
        foreach(string wordToCompare in note)
        {
            if(magazineDictionary.ContainsKey(wordToCompare) && magazineDictionary[wordToCompare] >= noteDictionary[wordToCompare])
            {
                continue;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Yes");
    }

    static void checkSubstring(string s1, string s2) {
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Incorrect Input");
                return;
            }

            if (string.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Incorrect Input");
                return;
            }

            
        
        Dictionary<char, int> magazineDictionary = new Dictionary<char, int>();
        Dictionary<char, int> noteDictionary = new Dictionary<char, int>();
        //int noteWordCounter = 1, magWordCounter = 1;
        foreach(char word in s2)
        {   
            if(!noteDictionary.ContainsKey(word))
            {
                noteDictionary.Add(word, 1);
            }
            else
            {
                noteDictionary[word]++;
            }   
        }
        
        foreach(char word in s1)
        {   
            if(!magazineDictionary.ContainsKey(word))
            {
                magazineDictionary.Add(word, 1);
            }
            else
            {
                magazineDictionary[word]++;
            }   
        }
        
        foreach(char wordToCompare in s2)
        {
            if(magazineDictionary.ContainsKey(wordToCompare)) //&& magazineDictionary[wordToCompare] >= noteDictionary[wordToCompare]
            {
                Console.WriteLine("YES");
                return;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("NO");
    }

        static void Main(string[] args)
        {
            List<int> n = new List<int>();
            List<IList<int>> n1 = new List<IList<int>>();
            n1.Add(new List<int>{1,2,3});
            
            Queue queue = new Queue();
            int c = queue.Count;
            queue.Dequeue();
            var dictionary = new Dictionary<int, int>();
        dictionary[5] = 1;
        dictionary[6] = 2;
        int min = dictionary.Keys.Min();
        System.Console.WriteLine(min);
            // string[] magazine = {"apgo","clm","w","lxkvg","mwz","elo","bg","elo","lxkvg","elo","apgo","apgo","w","elo","bg"};

            // string[] note = {"elo","lxkvg","bg","mwz","clm","w"};

            // checkMagazine(magazine, note);

            // string s1 = "heLLO";
            // string s2 = "world";
            // checkSubstring(s1,s2);
            string s = "a";
            string t = "ab";

            var letters = new Dictionary<char,int>();
        
            for(int arrayIndex = 0; arrayIndex < s.Length; arrayIndex++)
            {
                letters[s[arrayIndex]] = 1 + letters.GetValueOrDefault(s[arrayIndex],0);
            }
            letters.Keys.First();
            for(int arrayIndex = 0; arrayIndex < t.Length; arrayIndex++)
            {
                if(letters.ContainsKey(t[arrayIndex]))
                {
                    letters[t[arrayIndex]]--;
                    if(letters[t[arrayIndex]] < 0)
                    {
                        System.Console.WriteLine("false");
                    }
                }
                else
                {
                    letters[t[arrayIndex]] = 1 + letters.GetValueOrDefault(t[arrayIndex],0);
                }
            }
        
        System.Console.WriteLine(letters.Values.Max() == 0 ? "true" : "false"); 

            string s3 = "cdcd";
            Stack stack = new Stack();
            
            char.ToLower(s3[1]);
            Array.Sort(s3.ToCharArray());
            Console.WriteLine(s3);
            
            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();
        
            Array.Sort(sArr);
            Array.Sort(tArr);
        
            if(sArr.SequenceEqual(tArr))
            {
                System.Console.WriteLine("true");;
            }
            else
            {
                System.Console.WriteLine("false");
            }


            //Without inbuilt sorting
        int[] charMapS = new int[26];
        int[] charMapT = new int[26];
        StringBuilder sNew = new StringBuilder();
        StringBuilder tNew = new StringBuilder();
        
        foreach(char c1 in s)
        {
            charMapS[c - 'a']++;
        }
        
        foreach(char c1 in t)
        {
            charMapT[c - 'a']++;
        }
        
        for(int i = 0; i < 26; i++)
        {
            for (int j = 0; j < charMapS[i]; j++)
            {
                sNew.Append((char)(i + 'a'));
            }
        }
        
        for(int i = 0; i < 26; i++)
        {
            for (int j = 0; j < charMapT[i]; j++)
            {
                tNew.Append((char)(i + 'a'));
            }
        }

        System.Console.WriteLine(sNew.ToString());        
        System.Console.WriteLine(tNew.ToString());

        if(sNew.Equals(tNew))
        {
            System.Console.WriteLine("true");
        }
        else
        {
            System.Console.WriteLine("false");
        }
            //findallsubstring(s3);
            //Console.WriteLine("Hello World!");
        }

    public static void findallsubstring(string s)
    {
        // int anagrampairs = 0;
        // for (int i = 1; i <= s.Length; i++)
        // {
        //     Dictionary<int,string> compare = new Dictionary<int,string>();
        //     Dictionary<int,int> anagramstrings = new Dictionary<int,int>();
            
        //     int k = 0;
        //     for (int j = 0; j <= s.Length - i; j++)
        //     {
        //         string subString = s.Substring(j, i);
        //         char[] arr = subString.ToCharArray();
        //         Array.Sort(arr);
        //         string sortedsubString = new string(arr);
        //         if (!compare.ContainsValue(sortedsubString))
        //         {
        //             compare.Add(k, sortedsubString);
        //             k++;
        //             Console.WriteLine(sortedsubString);
        //         }
        //         else{
        //             anagrampairs++;
        //         }
        //     }
            
        // }

        var dictionary = new Dictionary<int, int>();
        dictionary[0] = 1;
        dictionary[1] = 2;
        int min = dictionary.Keys.Min();
        System.Console.WriteLine(min);
            var count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    var substring = new string(s.Substring(i, j));
                    //.OrderBy(c => c).ToArray());
                    char[] arr = substring.ToCharArray();
                    Array.Sort(arr);
                    string sortedsubString = new string(arr);
                    // if (dictionary.ContainsKey(sortedsubString))
                    // {
                    //     dictionary[sortedsubString]++;
                    // }
                    // else
                    // {
                    //     dictionary.Add(sortedsubString, 1);
                    // }
                }
            }
            var maxVal = dictionary.Values.Max();
            Hashtable ht = new Hashtable();
            
            foreach (var v in dictionary.Values.Where(x => x > 1))
            {
                count += v * (v - 1) / 2;
            }
        System.Console.WriteLine(count);
    }
    }
}
