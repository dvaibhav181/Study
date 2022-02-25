using System.Collections.Generic;

public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool endOfWord = false;
}

public class Trie {
    TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        
        foreach(char c in word)
        {
            if(!current.children.ContainsKey(c))
            {
                current.children[c] = new TrieNode();
            }
            current = current.children[c];
        }
        current.endOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        
        foreach(char c in word)
        {
            if(!current.children.ContainsKey(c))
            {
                return false;
            }
            else
            {
                current = current.children[c];
            }
        }
        return current.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        
        foreach(char c in prefix)
        {
            if(!current.children.ContainsKey(c))
            {
                return false;
            }
            else
            {
                current = current.children[c];
            }
        }
        return true;
    }
}