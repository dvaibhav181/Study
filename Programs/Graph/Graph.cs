using System;
using System.Collections.Generic;

public class GraphClass{
    //No of vertices
    private int _V;
    LinkedList<int>[] _adj; //Array of linked list

    public GraphClass(int v)
    { // v is vertices, create graph with v vertices
        _adj = new LinkedList<int>[v];

        for(int i = 0; i < _adj.Length; i++)
        {
            _adj[i] = new LinkedList<int>();
        }

        _V = v;
    }

    public void AddEdge(int u, int w)
    {
        _adj[u].AddLast(w);
    }

    public void BFS(int node)
    {
        //List to maintain the BFS traversal
        var bfsList = new List<int>();

        //boolean array to keep track of visited nodes
        bool[] visited = new bool[_V];

        //For BFS create queue
        LinkedList<int> queue = new LinkedList<int>();
        //add the starting node into the queue and mark it as visited
        queue.AddLast(node);
        visited[node] = true;

        //while all the nodes are visited i.e. queue has any items
        while(queue.Count > 0)
        {
            //Dequeue the node and search for its adjacent nodes
            var root = queue.First.Value;
            bfsList.Add(Convert.ToInt32(root));
            queue.Remove(root);

            //Get all adjacent vertices of the dequeued node
            LinkedList<int> list = _adj[Convert.ToInt32(root)];
            foreach(var item in list)
            {
                if(!visited[item])
                {
                    queue.AddLast(item);
                    visited[item] = true;
                }
            }
        }

        foreach (var item in bfsList)
        {
            Console.WriteLine($"{item}->");
        }
    }

    public void CloneGraph()
    {
        
    }
}