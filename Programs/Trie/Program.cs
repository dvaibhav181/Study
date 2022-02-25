using System;

namespace TrieProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie1 = new Trie();
            trie1.insert("apple");
            trie1.insert("apply");
            trie1.insert("application");
            trie1.printTrie();
            var wordToFind = "applica";
            bool isPresent = trie1.search(wordToFind);
            if(isPresent)
            {
                Console.WriteLine($"The word { wordToFind } is present");
            }
            else
            {
                Console.WriteLine($"The word { wordToFind } is not present");
            }

            var wordstartswith = "applicta";
            
            bool startswith = trie1.startswith(wordstartswith);
            if(startswith)
            {
                Console.WriteLine($"The trie starts with { wordstartswith }");
            }
            else
            {
                Console.WriteLine($"The trie does not start with { wordstartswith }");
            }
        }
    }
}
