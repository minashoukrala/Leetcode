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
    public int DiameterOfBinaryTree(TreeNode root) {

        int diameter = 0;
        dfs(root, ref diameter);
        return diameter;
           
    }

    public int dfs(TreeNode node, ref int diameter){
        if(node == null) return 0;

        int left = dfs(node.left, ref diameter);
        int right = dfs(node.right, ref diameter);

        diameter = Math.Max(diameter, left + right);

        return Math.Max(left, right) + 1;

    }
}