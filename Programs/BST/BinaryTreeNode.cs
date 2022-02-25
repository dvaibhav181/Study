public class BinaryTreeNode<T>
{
    public T value;
    public BinaryTreeNode<T> left;
    public BinaryTreeNode<T> right;
    public BinaryTreeNode(T val, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
    {
        this.value = val;
        this.left = null;
        this.right = null;     
    }
}