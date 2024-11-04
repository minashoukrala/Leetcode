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
    public int MaxAncestorDiff(TreeNode root) {
        
        int max = root.val;
        int min = root.val;
        int leftdiff = 0;
        int rightdiff = 0;

        dfs(root.left, max, min, ref leftdiff);
        dfs(root.right, max, min, ref rightdiff);

        return Math.Max(leftdiff,rightdiff);
    }

    public void dfs(TreeNode curr, int max, int min,ref int diff){

        if(curr == null) return ;

        if(curr.val > max) max = curr.val;
        else if (curr.val < min) min = curr.val;
        
        diff = Math.Max(diff, max-min);

        dfs(curr.left, max, min, ref diff);
        dfs(curr.right, max, min, ref diff);        

        return;
    }
}