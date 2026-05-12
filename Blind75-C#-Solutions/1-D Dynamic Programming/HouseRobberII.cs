public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
            return nums[0];

        return Math.Max(
            RobRange(nums, 0, nums.Length - 2),
            RobRange(nums, 1, nums.Length - 1)
        );
    }

    private int RobRange(int[] nums, int start, int end)
    {
        int aux = 0;
        int auxBefore = 0;

        for (int i = start; i <= end; i++)
        {
            int temp = Math.Max(aux, auxBefore + nums[i]);
            auxBefore = aux;
            aux = temp;
        }

        return aux;
    }
}
