using System.Collections.Generic;

public class TrieNode
{
    Dictionary<char, TrieNode> edges;
    bool isWordEnd;

    public TrieNode()
    {
        this.edges = new Dictionary<char, TrieNode>();
        this.isWordEnd = false;
    }

    public void insert(TrieNode root, string word)
    {
        TrieNode currNode = root;
        foreach(char c in word)
        {
            if(!currNode.edges.ContainsKey(c))
            {
                currNode.edges.TryAdd(c, new TrieNode());
            }
            currNode = currNode.edges[c];
        }
        currNode.isWordEnd = true;
    }

    public void printTrie()
    {
        
    }
}