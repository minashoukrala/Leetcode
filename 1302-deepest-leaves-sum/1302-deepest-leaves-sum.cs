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
    public int DeepestLeavesSum(TreeNode root) {

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        TreeNode curr;
        int sum = 0;

        while(queue.Count != 0){

            int length = queue.Count;
            sum = 0;
            for(int i = 0; i < length; i++){
                curr = queue.Dequeue();
                Console.WriteLine(sum);
                if(curr.right==null && curr.left==null) sum+=curr.val;

                if(curr.left != null) queue.Enqueue(curr.left);
                if(curr.right != null) queue.Enqueue(curr.right);
                
                    
            }


        }
        return sum;

        
        
    }
}