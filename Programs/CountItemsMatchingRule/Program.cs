using System;
using System.Collections.Generic;

namespace CountItemsMatchingRule
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<string>> items = new List<IList<string>>();
            items.Add(new List<string> {"phone","blue","pixel"});
            items.Add(new List<string> {"computer","silver","lenovo"});
            items.Add(new List<string> {"phone","gold","iphone"});
            string rulekey = "type";
            string ruleValue = "phone";

            int count = 0;

            for(int i = 0; i < items.Count; i++)
            {
                if(items[i][0] == ruleValue)
                {
                    Console.WriteLine($"{ items[i][0] } , { items[i][1] } , { items[i][2] }");
                }
            }
        }
    }
}
