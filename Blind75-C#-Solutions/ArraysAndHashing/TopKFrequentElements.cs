public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return
            nums.GroupBy(x => x)
                .OrderByDescending(c => c.Count())
                .Take(k)
                .Select(s => s.Key)
                .ToArray();
    }
}
