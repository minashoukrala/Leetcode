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

        if(root==null)  
            return true;

        
        
        return (Math.Abs(maxDepth(root.left)-maxDepth(root.right))<2) && IsBalanced(root.left) && IsBalanced(root.right);
        
    }

    public int maxDepth(TreeNode node){

        if(node==null)
            return -1;
        
        int left=maxDepth(node.left);
        int right=maxDepth(node.right);

        return 1+ Math.Max(left,right);

    }
}