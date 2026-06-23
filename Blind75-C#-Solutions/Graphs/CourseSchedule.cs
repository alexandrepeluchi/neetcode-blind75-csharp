public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var pre in prerequisites)
        {
            graph[pre[0]].Add(pre[1]);
        }

        int[] state = new int[numCourses];

        for (int i = 0; i < numCourses; i++)
        {
            if (!DFS(i, graph, state))
                return false;
        }

        return true;
    }

    private bool DFS(int course, List<int>[] graph, int[] state)
    {
        if (state[course] == 1) return false;
        if (state[course] == 2) return true;

        state[course] = 1;

        foreach (int pre in graph[course])
        {
            if (!DFS(pre, graph, state))
                return false;
        }

        state[course] = 2;
        return true;
    }
}
