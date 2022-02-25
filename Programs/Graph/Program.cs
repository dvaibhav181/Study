using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
        HashSet<int> hS = new System.Collections.Generic.HashSet<int>();
        hS.Add(5);
        hS.Add(2);

        foreach(var item in hS)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(hS.GetHashCode());

            GraphClass g = new GraphClass(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            
            Console.Write("Following is Breadth First " +
                        "Traversal(starting from " +
                        "vertex 2)\n");
            g.BFS(2);
        }
    }
}
