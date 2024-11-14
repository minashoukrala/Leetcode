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
    public bool IsValidBST(TreeNode root) {
        if(root.left == null && root.right == null) return true;
        return Validate(root,int.MinValue,int.MaxValue, false,false);
    }

    private bool Validate(TreeNode node, int low, int high, bool lowBoundExists, bool highBoundExists) {
        if (node == null) return true;

        // Check if the node's value violates the low or high boundaries
        if ((lowBoundExists && node.val <= low) || 
            (highBoundExists && node.val >= high)) {
            return false;
        }

        // Recursively validate the left and right subtrees
        return Validate(node.left, low, node.val, lowBoundExists, true) && 
               Validate(node.right, node.val, high, true, highBoundExists);
    }
}