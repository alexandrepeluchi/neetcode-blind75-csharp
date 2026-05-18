public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var result = new List<int[]>();
        bool inserted = false;

        foreach (var interval in intervals)
        {
            if (interval[1] < newInterval[0])
            {
                result.Add(interval);
            }
            else if (interval[0] > newInterval[1])
            {
                if(!inserted)
                {
                    result.Add(newInterval);
                    inserted = true;
                }
                
                result.Add(interval);
            }
            else
            {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }

        if (!inserted)
            result.Add(newInterval);

        return result.ToArray();
    }
}
