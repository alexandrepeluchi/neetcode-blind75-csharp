public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        if (nums == null || nums.Length < 2)
            return Array.Empty<int>();

        for (int i = 0; i < nums.Count(); i++)
        {
            for (int j = i + 1; j < nums.Count(); j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[2] { i, j };
            }
        }

        return Array.Empty<int>();
    }
}
