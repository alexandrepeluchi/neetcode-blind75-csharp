public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] list = new int[nums.Length];
        Array.Fill(list, 1);
        int max = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                    list[i] = Math.Max(list[i], list[j] + 1);

            }
            max = Math.Max(max, list[i]);
        }
        
        return max;
    }
}
