using System;
using System.Collections;

namespace FirstRecurringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var arr = new Object[] {'H','e','l','l','o',' ','w','o','r','l','d'};//{2,5,1,2,3,5,1,2,4};
            var firstRecurringCharacter = FindFirstRecurringCharacter(arr);
            Console.WriteLine(firstRecurringCharacter.ToString());
        }

        private static object FindFirstRecurringCharacter(object[] arr)
        {
            if(arr.Length == 0)
            {
                throw new InvalidOperationException("Array should be null");
            }
            var hashtable = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if(!hashtable.ContainsKey(arr[i]))
                {
                    hashtable.Add(arr[i],"First");
                }
                else{
                    return arr[i];
                }
            }
            return "undefined";
        }
    }
}
