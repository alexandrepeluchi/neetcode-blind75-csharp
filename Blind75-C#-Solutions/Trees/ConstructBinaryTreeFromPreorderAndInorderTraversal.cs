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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int preIndex = 0;
        Dictionary<int, int> map = new();

        for (int i = 0; i < inorder.Length; i++)
            map[inorder[i]] = i;   

        TreeNode Build(int[] preorder, int left, int right)
        {
            if (left > right) return null;

            int rootVal = preorder[preIndex++];
            TreeNode root = new TreeNode(rootVal);

            int mid = map[rootVal];

            root.left = Build(preorder, left, mid - 1);
            root.right = Build(preorder, mid + 1, right);

            return root;
        }

        return Build(preorder, 0, inorder.Length - 1);
    }
}
