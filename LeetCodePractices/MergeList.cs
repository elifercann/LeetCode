namespace LeetCodePractices;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0,
        ListNode next=null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution7
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode mergedHead = new ListNode(); // Create an empty node as the starting point
        ListNode current = mergedHead; // Set a pointer to the starting node

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Attach remaining nodes
        if (list1 != null)
            current.next = list1;
        else
            current.next = list2;

        return mergedHead.next; // Return the head of the merged linked list
    }

}
