public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int max = 0;

        while (left < right)
        {
            max = Math.Max(max, Math.Min(heights[left], heights[right]) * (right - left));

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }

        return max;
    }
}
