using System;
using System.Collections;

public class Stack
{
    private ArrayList ArrayList;
    private int Top;

    public Stack()
    {
        ArrayList = new ArrayList();
        Top = -1;
    }
    public void Push(object obj)
    {
        if (obj != null)
        {
            ArrayList.Add(obj);
            Top++;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public object Pop()
    {
        if(ArrayList.Count == 0)
        {
            throw new InvalidOperationException();
        }
        var obj = ArrayList[Top];
        ArrayList.RemoveAt(Top);
        Top--;
        return obj;
    }

    public void Clear()
    {
        ArrayList.Clear();
    }
}