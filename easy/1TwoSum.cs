namespace leetcode.easy;

public class TwoSum
{
    [Theory]
    [InlineData(new int[] {1, 2}, 50, new int[] {})]
    [InlineData(new int[] {1, 2, 3}, 5, new int[] {1, 2})]
    [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] {0, 1})]
    [InlineData(new int[] {2, 7, 11, 15}, 13, new int[] {0, 2})]
    [InlineData(new int[] {2, 7, 11, 15}, 17, new int[] {0, 3})]
    [InlineData(new int[] {2, 7, 11, 15}, 18, new int[] {1, 2})]
    [InlineData(new int[] {2, 7, 11, 15}, 22, new int[] {1, 3})]
    [InlineData(new int[] {2, 7, 11, 15}, 26, new int[] {2, 3})]
    public void Case(int[] nums, int target, int[] expec)
    {
        Assert.Equal(expec, FindTwoSum(nums, target));
    }

    // Para melhorar a performance, é possível trocar um dos loops por uma estrutura de dados, como um
    // dicionário
    private int[] FindTwoSum(int[] nums, int target)
    {
        for (int i=0; i<nums.Length-1; i++)
        {
            for (int j=i+1; j<nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }
}