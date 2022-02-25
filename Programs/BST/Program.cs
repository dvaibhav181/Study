using System;
using System.Collections.Generic;
using System.Linq;

namespace BST
{
    class Program
    {
    public static void inorder(Node<int> root)
    {
        if(root == null)
        {
            return;
        }

        inorder(root.left);//inorder(this.left);
        Console.WriteLine(root.value);
        inorder(root.right);//inorder(this.right);
    }

    public static void preorder(Node<int> root)
    {
        if(root == null)
        {
            return;
        }

        Console.WriteLine(root.value);
        preorder(root.left);//inorder(this.left);
        preorder(root.right);//inorder(this.right);
    }

    public static void postorder(Node<int> root)
    {
        if(root == null)
        {
            return;
        }

        postorder(root.left);//inorder(this.left);
        postorder(root.right);//inorder(this.right);
        Console.WriteLine(root.value);
    }

    public static bool PathSum(BinaryTreeNode<int> root, int targetSum, int curSum)
    {
        if(root == null)
            return false;
        
        curSum += root.value;
        if(root.left == null && root.right == null && curSum == targetSum)
            return true;

        bool ltree = PathSum(root.left, targetSum, curSum);
        bool rtree = PathSum(root.right, targetSum, curSum);

        return ltree || rtree;
    }

    public static void PathSumII(BinaryTreeNode<int> root, int targetSum, int curSum, List<IList<int>> result, List<int> subResult)
    {
        if(root == null)
            return;
        
        curSum += root.value;
        subResult.Add(root.value);
        if(root.left == null && root.right == null && curSum == targetSum)
            result.Add(subResult);

        PathSumII(root.left, targetSum, curSum, result, new List<int>(subResult));
        PathSumII(root.right, targetSum, curSum, result, new List<int>(subResult));
        
        return;
    }

    public static bool ValidateBST(Node<int> root, int min, int max)
    {
        if (root == null)
            return true;

        if(min < root.value && max > root.value)
        {
            var ltree = ValidateBST(root.left, min, root.value);
            var rtree = ValidateBST(root.right, root.value, max);  

            if(rtree && ltree)
            {
                return true;
            }      
        }   
        return false;
    }

    public static void PrintSide(BinaryTreeNode<int> root, int sideFlag)
    {
        var result = new List<int>();
        // Right/Left side of tree will use BFS(Queue/Level order traversal)

        Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            BinaryTreeNode<int> side = null;
            int size = q.Count();

            for(int i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if(node != null)
                    side = node;
                    if(sideFlag == 0)
                    { //for right side, insert left first then right
                        if(node.left != null)
                        q.Enqueue(node.left);
                    
                        if(node.right != null)
                        q.Enqueue(node.right);
                    }
                    else
                    { //for left side, insert right first then left
                        if(node.right != null)
                            q.Enqueue(node.right);

                        if(node.left != null)
                            q.Enqueue(node.left);
                    }
                    
            }

            if(side != null)
                result.Add(side.value);
        }

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
        static void Main(string[] args)
        {
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(5,null,null);
            root.left = new BinaryTreeNode<int>(4,null,null);
            root.left.left = new BinaryTreeNode<int>(11,null,null);
            root.left.left.left = new BinaryTreeNode<int>(7,null,null);            
            root.left.left.right = new BinaryTreeNode<int>(2,null,null);

            root.right = new BinaryTreeNode<int>(8,null,null);
            root.right.left = new BinaryTreeNode<int>(13,null,null);
            root.right.right = new BinaryTreeNode<int>(4,null,null);            
            root.right.right.right = new BinaryTreeNode<int>(1,null,null);                  
            root.right.right.left = new BinaryTreeNode<int>(5,null,null);
            
            //0 for right side, 1 for left side
            PrintSide(root,1);
            //PrintLeftSide(root);
            //Console.WriteLine(PathSum(root,22,0));
            
            List<IList<int>> result = new List<IList<int>>();
            List<int> subResult = new List<int>();

            PathSumII(root,22,0,result,subResult);
            foreach (var item in result)
            {
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();
            }

            //Trie trie = new Trie();
            //trie.Insert("apple");
            //trie.Search("apple");   // return True
            //trie.Search("app");     // return False
            //trie.StartsWith("app"); // return True
            //trie.Insert("app");
            //trie.Search("app");     // return True

            //var dict = new Dictionary<int,string>();
            //var list = new List<int>();
            //var i = list[2];

            /*BinarySearchTree bst = new BinarySearchTree();
            bst.insert(72);
            bst.insert(20);
            bst.insert(18);
            bst.insert(73);
            bst.insert(62);
            bst.insert(65);
            bst.insert(33);
            bst.insert(38);
            bst.insert(54);
            bst.remove(20);
            
            Console.WriteLine(ValidateBST(bst.root, int.MinValue, int.MaxValue));
            Console.WriteLine(bst.MaxDepth(bst.root));
            Console.WriteLine(bst);*/
            /*var arr = new int[10];
            var l = arr.Length;
            if(arr.Equals(null) || arr.Length < 3)
            {

            }*/
            // List<int> visited = new List<int>();
            // List<string> temp = new List<string>{"aaa","cab","bca"};
            
            // Queue<int> newQueue = new Queue<int>();
            // throw new NullReferenceException();
            // int[] stockPrices = {10, 7, 5, 8, 11, 9};
            
            /*Node<int> root = new Node<int>(1);
            root.left = new Node<int>(2);
            root.right = new Node<int>(3);
            root.left.left = new Node<int>(4);
            root.right.left = new Node<int>(5);
            root.right.right = new Node<int>(6);
            root.right.left.left = new Node<int>(7);
            root.right.left.right = new Node<int>(8);*/
            
            //inorder(root);
            //preorder(root);
            //postorder(root);
        }
    }
}
