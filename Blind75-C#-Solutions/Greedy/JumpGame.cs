public class Solution {
    public bool CanJump(int[] nums) {
        int far = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > far)
                return false;

            far = Math.Max(far, i + nums[i]);
        }

        return true;
    }
}
