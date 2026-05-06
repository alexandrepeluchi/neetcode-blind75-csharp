public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();

        void DFS(int i, int sum, List<int> path)
        {
            if (sum == target)
            {
                result.Add(new List<int>(path));
                return;
            }

            if (sum > target || i == nums.Length)
                return;

            path.Add(nums[i]);
            DFS(i, sum + nums[i], path);

            path.RemoveAt(path.Count - 1);
            DFS(i + 1, sum, path);
        }

        DFS(0, 0, new List<int>());
        return result;
    }
}
