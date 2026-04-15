public class Solution {
    public int MissingNumber(int[] nums) {
        int len = nums.Length;
        int expected = len * (len + 1) / 2;
        int sum = 0;

        foreach (int num in nums)
            sum += num;

        return expected - sum;
    }
}
