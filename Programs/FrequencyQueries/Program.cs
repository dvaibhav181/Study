using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencyQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            
        List<List<int>> queries = new List<List<int>>();

        // queries.Add(new List<int>{3,4});
        // queries.Add(new List<int>{2,1003});
        // queries.Add(new List<int>{1,16});
        // queries.Add(new List<int>{3,1});

        queries.Add(new List<int>{1,3});
        queries.Add(new List<int>{2,3});
        queries.Add(new List<int>{3,2});
        queries.Add(new List<int>{1,4});
        queries.Add(new List<int>{1,5});
        queries.Add(new List<int>{1,5});
        queries.Add(new List<int>{1,4});
        queries.Add(new List<int>{3,2});
        queries.Add(new List<int>{2,4});
        queries.Add(new List<int>{3,2});
        

        List<int> ans = freqQuery(queries);

        Console.WriteLine(String.Join("\n", ans));
        }

        static List<int> freqQuery(List<List<int>> queries) 
        {
            Dictionary<int,int> freqValDictionary = new Dictionary<int, int>();
            Dictionary<int,int> freqCountDictionary = new Dictionary<int, int>();
            List<int> freqQueryArray = new List<int>();
            for(int i = 0; i < queries.Count; i++)
            {
                var operation = queries[i][0];
                switch(operation)
                {
                    case 1:
                        if(freqValDictionary.ContainsKey(queries[i][1]))
                        {
                            freqValDictionary[queries[i][1]]++;
                        }
                        else{
                            freqValDictionary.Add(queries[i][1],1);
                        }
                    break;

                    case 2:
                        if(freqValDictionary.ContainsKey(queries[i][1]))
                        {
                            freqValDictionary.Remove(queries[i][1]);
                        }
                        else{
                            break;
                        }
                    break;

                    case 3:
                        if(freqValDictionary.Values.Contains(queries[i][1]))
                            {
                                freqQueryArray.Add(1);
                            }   
                            else
                            {
                                freqQueryArray.Add(0);
                            }
                        
                        
                    break;
                        
                }

            }
            return freqQueryArray;

            /*var res = new List<int>();
				
				// value - frequency
        var dictVF = new Dictionary<int, int>();
			
			  // frequency - count
        var dictFC = new Dictionary<int, int>();
        dictFC[0] = 0;

        foreach (var q in queries)
        {
            switch (q[0])
            {
                case 1:
                    if (!dictVF.ContainsKey(q[1]))
                    {
                        dictVF[q[1]] = 0;
                        dictFC[0]++;
                    }

                    dictFC[dictVF[q[1]]]--;
                    dictVF[q[1]]++;

                    if (!dictFC.ContainsKey(dictVF[q[1]]))
                    {
                        dictFC[dictVF[q[1]]] = 0;
                    }

                    dictFC[dictVF[q[1]]]++;

                    break;
                case 2:
                    if (dictVF.ContainsKey(q[1]))
                    {
                        if (dictVF[q[1]] > 0)
                        {
                            dictVF[q[1]]--;
                            dictFC[dictVF[q[1]] + 1]--;

                            if (dictVF[q[1]] >= 0)
                            {
                                if (!dictFC.ContainsKey(dictVF[q[1]]))
                                {
                                    dictFC[dictVF[q[1]]] = 0;
                                }

                                dictFC[dictVF[q[1]]]++;
                            }
                        }
                    }
                    break;
                case 3:
                    res.Add((dictFC.ContainsKey(q[1]) && dictFC[q[1]] > 0) ? 1 : 0);
                    break;
            }
        }

        return res;*/
        }
    }
}
