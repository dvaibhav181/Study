using System;

public class Node<T>
{
    public Node<T> left {get; set;}
    public Node<T> right {get; set;}
    public T value;
    public Node(T value)
    {
        this.left = null;
        this.right = null;
        this.value = value;
    }

    
}