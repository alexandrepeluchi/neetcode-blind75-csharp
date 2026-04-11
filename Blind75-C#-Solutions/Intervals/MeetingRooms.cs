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
    public bool CanAttendMeetings(List<Interval> intervals) {
        var sorted = intervals.OrderBy(i => i.start).ToList();

        if (sorted.Count <= 1)
            return true;

        return 
            Enumerable.Range(1, sorted.Count -1)
            .All(x => sorted[x].start >= sorted[x -1].end);
    }
}
