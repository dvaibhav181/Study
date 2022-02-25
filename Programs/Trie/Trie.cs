using System.Collections.Generic;

public class Trie
{
    private class TrieNode
    {
        public Dictionary<char, TrieNode> edges;
        public bool isWordEnd;

        public TrieNode()
        {   
            this.edges = new Dictionary<char, TrieNode>();
            this.isWordEnd = false;
        }
    }

    private TrieNode root;
    public Trie()
    {
        this.root = new TrieNode();
    }

    public void insert(string word)
    {
        TrieNode currNode = this.root;
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

    public bool search(string word)
    {
        TrieNode currNode = this.root;
        foreach(char c in word)
        {
            if(!currNode.edges.ContainsKey(c))
            {
                return false;
            }
            currNode = currNode.edges[c];
        }
        return currNode.isWordEnd;
    }

    public bool canBeBuilt(string word) 
    {
        TrieNode currentNode = root;
        foreach (char c in word.ToCharArray()) 
        {
            if (!currentNode.edges.ContainsKey(c))
            {
                return false;
            }
            currentNode = currentNode.edges[c];
            if (!currentNode.isWordEnd)
            {
                return false;
            }
        }
        return true;
    }

    public string LongestWord(string[] words) {
        if (words == null || words.Length == 0)
            return null;
        
        Trie trie = new Trie();
        foreach (string word in words)
        {
            trie.insert(word);
        }
        
        string answer = null;
        foreach (string word in words)
        {
            if (trie.canBeBuilt(word))
            {
                if (answer == null || answer.Length < word.Length || (answer.Length == word.Length && word.CompareTo(answer) < 0)) 
                {
                    answer = word;
                }   
            }
        }
        return answer;
    }
    public bool startswith(string word)
    {
        TrieNode currNode = this.root;
        foreach(char c in word)
        {
            if(!currNode.edges.ContainsKey(c))
            {
                return false;
            }
            currNode = currNode.edges[c];
        }
        return true;
    }

    public void printTrie()
    {
        TrieNode currNode = this.root;
        while(!currNode.isWordEnd)
        {   
            foreach(KeyValuePair<char, TrieNode> kvp in currNode.edges)
            {
                System.Console.Write($"{ kvp.Key } --> ");
                currNode = kvp.Value;
            }
        }
    }
}
