namespace leetcode.medium;

public class AddTwoNumbers
{
    [Theory]
    [InlineData(new int[] {0}, new int[] {0}, new int[] {0})]
    [InlineData(new int[] {0}, new int[] {9}, new int[] {9})]
    [InlineData(new int[] {9}, new int[] {0}, new int[] {9})]
    [InlineData(new int[] {2}, new int[] {2}, new int[] {4})]
    [InlineData(new int[] {9}, new int[] {9}, new int[] {8, 1})]
    [InlineData(new int[] {2, 4, 3}, new int[] {5, 6, 4}, new int[] {7, 0, 8})]
    [InlineData(new int[] {1, 2, 3}, new int[] {3, 2 ,1}, new int[] {4, 4 ,4})]
    [InlineData(new int[] {5, 4, 3, 2, 1}, new int[] {9, 9}, new int[] {4, 4, 4, 2, 1})]
    [InlineData(new int[] {9, 9, 9, 9, 9, 9, 9}, new int[] {9, 9, 9, 9}, new int[] {8, 9, 9, 9, 0, 0, 0, 1})]
    [InlineData(new int[] {9, 9, 9, 9}, new int[] {9, 9, 9, 9, 9, 9, 9}, new int[] {8, 9, 9, 9, 0, 0, 0, 1})]
    public void Case(int[] nums1, int[] nums2, int[] expec)
    {
        ListNode head = SumTwoNumbers(ListNode.CreateLinkedList(nums1), ListNode.CreateLinkedList(nums2));
        Assert.Equal(expec, ListNode.CreateArray(head));
    }

    private ListNode SumTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode output = l1;
        ListNode? prev = null;
        int d = 0;

        while (l1 != null && (l2 != null || d != 0))
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + d;
            d = sum/10;
            l1.val = sum%10;

            prev = l1;
            l1 = l1.next;
            l2 = l2?.next;

            if (l1 == null)
            {
                l1 = l2;
                prev.next = l1;
                l2 = null;
            }
        }

        if (d != 0)
        {
            prev.next = new(d);
        }

        // GC.Collect(); // se usado irá piorar a performance em 2x
        return output;
    }
}