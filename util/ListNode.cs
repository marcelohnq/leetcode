public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public static ListNode CreateLinkedList(int[] l)
    {
        ListNode head = new(l[0]);
        ListNode temp = head;

        for (int i=1; i<l.Length; i++)
        {
            temp.next = new(l[i]);
            temp = temp.next;
        }

        return head;
    }

    public static int[] CreateArray(ListNode head)
    {
        List<int> o = [];
        ListNode? current = head;

        while (current != null)
        {
            o.Add(current.val);
            current = current.next;
        }

        return [.. o];
    }
}