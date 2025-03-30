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
    public IList<int> PreorderTraversal(TreeNode root) {
        var stack = new Stack <TreeNode> ();
        var res= new List<int>();

        if(root==null)
            return res;

        stack.Push(root);

        while(stack.Count>0){

            TreeNode curr=stack.Pop();
            res.Add(curr.val);

            if(curr.right != null)
                stack.Push(curr.right);
            if(curr.left !=null)
                stack.Push(curr.left);

        }
        return res;

    }
}