using System.Collections;
using System.Collections.Generic;
using System.Linq;

class BinarySearchTree
{
    public Node<int> root = null;
    public BinarySearchTree()
    {
        this.root = null;
    }

    public int MaxDepth(Node<int> root) {
        
        
        if(root == null)
        {
            return 0;
        }
        
        //Recursive DFS
        //return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
        
        /* Iterative DFS using Stack
        Stack<TreeNode> stack = new Stack<TreeNode>();
        int level = 1;
        stack.Push(root);
        int result = 0;
        
        while(stack.Count > 0)
        {
            root = stack.Pop();
            if(root != null)
            {
                result = Math.Max(result,level);
               
                if(root.left != null)
                {
                    stack.Push(root.left);
                }
                
                if(root.right != null)
                {
                    stack.Push(root.right);
                }
                
                if(root.left != null && root.right != null)
                {                    
                    level = level + 1;
                }
            }
        }
        
        return result;*/
        
        //Iterative BFS using Queue
        Queue<Node<int>> queue = new Queue<Node<int>>();
        int level = 0;
        queue.Enqueue(root);
        
        Node<int> node;
        while (queue.Any())
        {
            for(int i = 0;i < queue.Count; i++)
            {
                node = (Node<int>)queue.Dequeue();
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            level += 1;
        }
        return level;
    }

    public void insert(int value)
    {
        Node<int> newNode = new Node<int>(value);
        
        if(this.root == null)
        {
            this.root = newNode;
        }
        else
        {
            Node<int> currNode = this.root;
            while(true)
            {
                if(value < currNode.value)
                {
                    if(currNode.left == null)
                    {
                        currNode.left = newNode;
                        break;
                    }
                    currNode = currNode.left;
                }
                if(value >= currNode.value)
                {
                    if(currNode.right == null)
                    {
                        currNode.right = newNode;
                        break;
                    }
                    currNode = currNode.right;
                }
            }

        }


    }


    public void remove(int value)
    {
        Node<int> currNode = this.root;
        Node<int> prevNode = currNode;
        while(currNode.value != value)
        {
            if(value < currNode.value)
            {
                prevNode = currNode;
                currNode = currNode.left;
            }
            else if(value >= currNode.value)
            {
                prevNode = currNode;
                currNode = currNode.right;
            }
        }
        
        Node<int> nextNode = currNode;
        if(currNode.right != null)
        {
            nextNode = currNode.right;
            prevNode = nextNode;
        }
        while(nextNode.left != null)
        {
            prevNode = nextNode;
            nextNode = nextNode.left;
        }
        nextNode.right = currNode.right;
        nextNode.left = currNode.left;
        currNode.value = nextNode.value;
        prevNode.left = null;
    }
}