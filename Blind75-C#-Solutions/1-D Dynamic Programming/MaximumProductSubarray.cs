public class Solution {
    public int MaxProduct(int[] nums) {
        int result = nums[0];
        int max = nums[0];
        int min = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int number = nums[i];

            if (number < 0)
            {
                int aux = max;
                max = min;
                min = aux;
            }

            max = Math.Max(number, max * number);
            min = Math.Min(number, min * number);

            result = Math.Max(result, max);
        }

        return result;
    }
}
