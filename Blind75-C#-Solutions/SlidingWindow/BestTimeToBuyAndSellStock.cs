public class Solution {
    public int MaxProfit(int[] prices) {

        int result = 0;

        if (prices.Length == 0)
            return result;

        for (int i = 0; i < prices.Length; i++)
        {
            int buyDay = prices[i];

            for (int j = i + 1; j < prices.Length; j++)
            {
                int sellDay = prices[j];
                result = Math.Max(result, sellDay - buyDay);
            }
        }

        return result;
    }
}