public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] list = new int[amount + 1];

        for (int i = 1; i <= amount; i++)
            list[i] = amount + 1;

        list[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (coin <= i)
                    list[i] = Math.Min(list[i], list[i - coin] + 1);
            }
        }

        return list[amount] > amount ? -1 : list[amount];
    }
}
