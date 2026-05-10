/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
            return null;

        var clones = new Dictionary<Node, Node>();

        Node DFS(Node current)
        {
            if (clones.ContainsKey(current))
                return clones[current];
            
            var copy = new Node(current.val);
            clones[current] = copy;

            foreach (var neighbor in current.neighbors)
                copy.neighbors.Add(DFS(neighbor));

            return copy;
        }

        return DFS(node);
    }
}
