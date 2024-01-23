namespace leetcode.hard;

public class MeadinArraysSorted
{
    [Theory]
    [InlineData(new int[] {}, new int[] {}, default(double))]
    [InlineData(new int[] {1}, new int[] {}, 1)]
    [InlineData(new int[] {}, new int[] {2}, 2)]
    [InlineData(new int[] {1, 3}, new int[] {2}, 2)]
    [InlineData(new int[] {1, 3}, new int[] {2, 4}, 2.5)]
    public void Case(int[] m, int[] n, double expec)
    {
        Assert.Equal(expec, FindMedianSortedArrays(m, n));
    }

    private double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0 && nums2.Length == 0)
        {
            return default;
        }

        if (nums1.Length == 1 && nums2.Length == 0)
        {
            return nums1[0];
        }

        if (nums1.Length == 0 && nums2.Length == 1)
        {
            return nums2[0];
        }

        int[] r = [];

        if (nums2.Length == 0)
        {
            r = nums1;
        }
        else if (nums1.Length == 0)
        {
            r = nums2;
        }
        else
        {
            r = [.. nums1, .. nums2];
            Array.Sort(r);
        }

        int center = r.Length / 2;

        if (r.Length % 2 == 0)
        {
            center--;
            return (r[center] + r[center+1])/2.0;
        }
        
        return r[center];
    } 
}