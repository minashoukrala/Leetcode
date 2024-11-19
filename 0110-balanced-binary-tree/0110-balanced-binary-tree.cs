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
    public bool IsBalanced(TreeNode root) {

       return  CheckHeight(root) != -1;
        
    }

     public int CheckHeight(TreeNode node) {
        if (node == null) return 0;

        int leftHeight = CheckHeight(node.left);
        if (leftHeight == -1) return -1; // Left subtree is unbalanced
        
        int rightHeight = CheckHeight(node.right);
        if (rightHeight == -1) return -1; // Right subtree is unbalanced
        
        if (Math.Abs(leftHeight - rightHeight) > 1) return -1; // Current node is unbalanced
        
        return Math.Max(leftHeight, rightHeight) + 1; // Height of the current node
    }
}