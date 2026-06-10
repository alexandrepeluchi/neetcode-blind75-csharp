/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {
        if (intervals.Count == 0)
            return 0;

        int n = intervals.Count;
        int[] starts = new int[n];
        int[] ends = new int[n];

        for (int i = 0; i < n; i++) {
            starts[i] = intervals[i].start;
            ends[i] = intervals[i].end;
        }

        Array.Sort(starts);
        Array.Sort(ends);

        int rooms = 0;
        int end = 0;

        foreach (int start in starts) {
            if (start < ends[end]) {
                rooms++;
            } else {
                end++;
            }
        }

        return rooms;
    }
}
