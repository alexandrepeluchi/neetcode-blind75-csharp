/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        DFS(root, 0, result);
        
        return result;
    }

    private void DFS(TreeNode node, int depth, List<List<int>> result)
    {
        if (node == null) return;

        if (result.Count == depth)
            result.Add(new List<int>());

        result[depth].Add(node.val);

        DFS(node.left, depth + 1, result);
        DFS(node.right, depth + 1, result);
    }
}
