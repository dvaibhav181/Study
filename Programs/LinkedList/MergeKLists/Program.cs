using System;

namespace MergeKLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = new ListNode[]{
                new ListNode[1,4,5],
                new ListNode[1,3,4],
                new ListNode[2,6]
            };
            MergeKLists(lists);
            Console.WriteLine("Hello World!");
        }

        public static ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0)
        {
            return null;
        }
        var tempList = new ListNode[lists.Length];
        //ListNode[] tempList = null;
        int index = 0;
        while (lists.Length > 1)
        {
            for(int i = 0; i < lists.Length; i++)
            {
                ListNode l1 = lists[i];
                ListNode l2 = null;
                if(i + 1 < lists.Length)
                {
                    l2 = lists[i+1];
                }
                
                tempList[index++] = mergeLists(l1,l2);
            }
            lists = tempList;
        }
        return lists[0];
    }
    
    public static ListNode mergeLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        var curr = dummy;
        
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                curr.next = l1;
                l1 = l1.next;
            }
            else
            {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }
        
        if(l1 != null)
        {
            curr.next = l1;
        }
        
        if(l2 != null)
        {
            curr.next = l2;
        }
        
        return dummy.next;
        
    }
    }
}
