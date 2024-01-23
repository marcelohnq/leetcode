namespace leetcode.easy;

public class ClimbStairs
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(45, 1836311903)]
    public void Case(int n, int r)
    {
        Assert.Equal(r, Climb(n));
    }

    public int Climb(int n) 
    {
        if (n <= 2)
        {
            return Math.Max(1, n);
        }

        int a1 = 1;
        int a2 = 2;

        for (int i=2; i<n; i++) {
            int t = a1 + a2;
            a1 = a2;
            a2 = t;
        }

        return a2;
    }
}