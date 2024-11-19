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
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();

        if(root == null) return new List<int>();

        DFS(root, result);
        return result;

        
    }


    public void DFS(TreeNode node, IList<int> result){

        if(node == null) return;

        DFS(node.left, result);
        result.Add(node.val);
        DFS(node.right, result);

        return;
    }

    /*public void Helper(TreeNode node, IList<int> ans){

        if(node==null)
            return;

        Helper(node.left,ans);
        ans.Add(node.val);
        Helper(node.right,ans);
        return;

    }*/
}