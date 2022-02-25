using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
    
    class Program
    {
        public static void GroupAnagrams()
        {
            string[] strs = new string[]{"eat","tea","tan","ate","nat","bat"};
            var result = new List<IList<string>>();
            var subResult = new List<string>();
            var dict = new Dictionary<int[],List<string>>();
            //loop over evry string in the array
            foreach(var word in strs)
            {
                var count = new int[26];
                foreach(var c in word)
                {
                    count[c - 'a'] += 1;
                }
                
                List<string> sValue = new List<string>();
                bool exists = dict.TryGetValue(count, out sValue);

                if (exists && !sValue.Contains(word))
                {
                    sValue.Add(word);
                    dict[count] = sValue;
                }
                else if (!exists)
                {
                    sValue = sValue ?? new List<string>();
                    sValue.Add(word);
                    dict.Add(count, sValue);
                }
                // if(dict.ContainsKey(count))
                // {
                //     dict.Add(count, );
                // }
                // else
                // {
                //     dict[count] = word;
                // }
            }
            
            result.Add(subResult);
        }
        public static void StringManipulation(string inputString)
        {
            
            if(String.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine(String.Empty);
            }	
            
            StringBuilder sb = new StringBuilder();
            var strArray = inputString.Split(' ');

            for(int i = 0; i < strArray.Length; i++)
            {
                //checking for odd words, even indexes in the array		
                if(i%2 == 0)
                {
                    //reverse the char for the string at even index
                    var charArray = strArray[i].ToLower().ToCharArray();
                    Array.Reverse(charArray);
                    strArray[i] = new string(charArray);
                    sb.Append($"{new string(charArray)} ");
                }
                else{
                    sb.Append($"{strArray[i].ToLower()} ");
                }
                //odd indexes will be the even indexed in input string, hence append as it
            }
            sb.ToString().Trim();
                var result = String.Empty;
                result += sb[0];
                for(int j = 1; j < sb.ToString().Length - 1; j++)
                {   
                    if(sb[j] == ' ')
                    {
                        if(sb[j-1] == sb[j+1])
                        {
                            j+=2;
                        }
                        else
                        {
                            j+=1;
                        }
                    }
                    result += sb[j];
                }
            // sb = 'ti is a cat tiderc card', 'ti is nnc' ,'nn na ca' 'nn na ac' 'nac'
            Console.WriteLine(result);	
        }

        public static void FindTheDifference(string s, string t) 
        {
            if((String.IsNullOrWhiteSpace(s) && String.IsNullOrWhiteSpace(t)) ||
            (!String.IsNullOrWhiteSpace(s) && String.IsNullOrWhiteSpace(t)))
            {
                Console.WriteLine("");
            }
            
            /*
            var dict = new Dictionary<char,int>();
            
            for(int i = 0; i < t.Length; i++)
            {
                dict[t[i]] = 1 + dict.GetValueOrDefault(t[i],0);
            }
            
            foreach(var item in s)
            {
                if(dict.ContainsKey(item))
                {
                    dict.Remove(s[item]);
                }
            }
            char c = ' ';
            if(dict.Count > 0)
            {
                c = dict.Keys.First();
            }*/
            
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char c = ' ';
            var letters = new int[26];
            foreach(var item in t)
            {
                letters[item - 'a']++;
            }
            foreach(var item in s)
            {
                letters[item - 'a']--;
            }
            
            for(int i = 0; i < letters.Length; i++)
            {
                if(letters[i] == 1)
                {
                    c = alpha[i];
                    break;
                }
            }
            
            Console.WriteLine(c.ToString());
        }
        static void Main(string[] args)
        {
            GroupAnagrams();
            //FindTheDifference("", "y");
            //StringManipulation("It is a cat credit card");
            //Console.WriteLine("Hello World!");
        }
    }
}
