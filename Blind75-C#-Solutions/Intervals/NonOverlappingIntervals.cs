public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        int count = 0;
        int end = int.MinValue;

        foreach (var interval in intervals) {
            if (interval[0] >= end) {
                end = interval[1];
            } else {
                count++;
            }
        }

        return count;
    }
}
