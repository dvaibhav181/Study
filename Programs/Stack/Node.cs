//default scope of class is internal until explicitly declared as public
//Class cannot be declared as private, protected or protected internal
class Node<T>
{
    public int value { get; set; }
    public Node<T> next { get; set; }

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}