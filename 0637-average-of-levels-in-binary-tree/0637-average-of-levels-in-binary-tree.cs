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
    public IList<double> AverageOfLevels(TreeNode root) {
        

        Queue<TreeNode> que = new Queue<TreeNode>();
        if(root == null) return new List<double>();

        que.Enqueue(root);
        var result = new List<double>();

        while(que.Count > 0){

            int len = que.Count;
            double sum = 0;
            int count = 0;

            for(int i = 0; i < len; i++){

                TreeNode curr = que.Dequeue();
                sum += curr.val;
                count += 1;
                Console.WriteLine("node: " + curr.val);
                Console.WriteLine("sum inside: " + sum);
                if(curr.left != null)
                    que.Enqueue(curr.left);

                if(curr.right != null)
                    que.Enqueue(curr.right);
            }
            Console.WriteLine("sum" + sum);
            Console.WriteLine(count);
            result.Add((double)sum/count);
        }
        return result;
        
    }
}