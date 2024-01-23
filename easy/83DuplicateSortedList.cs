namespace leetcode.easy;

public class DuplicateSortedList
{
    [Theory]
    [InlineData(new int[] {1}, new int[] {1})]
    [InlineData(new int[] {1, 1}, new int[] {1})]
    [InlineData(new int[] {1, 1, 1, 1}, new int[] {1})]
    [InlineData(new int[] {1, 1, 2}, new int[] {1, 2})]
    [InlineData(new int[] {1, 1, 2, 2}, new int[] {1, 2})]
    [InlineData(new int[] {1, 1, 2, 2, 3}, new int[] {1, 2, 3})]
    [InlineData(new int[] {-100, 1, 2, 2, 3}, new int[] {-100, 1, 2, 3})]
    public void Case(int[] i, int[] o)
    {
        ListNode head = ListNode.CreateLinkedList(i);
        ListNode? current = head;

        while(current != null)
        {
            RemoveDuplicate(current, current.next, current.val);
            current = current.next;
        }

        Assert.Equal(o, ListNode.CreateArray(head));
    }

    private static void RemoveDuplicate(ListNode prev, ListNode? current, int x) 
    {
        if (current == null)
        {
            return;
        }

        if (current.val == x)
        {
            prev.next = current.next;
            current = prev;
        }

        RemoveDuplicate(current, current.next, x);
    }
}