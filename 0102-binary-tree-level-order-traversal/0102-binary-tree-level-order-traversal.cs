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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        IList<IList<int>> ans=new List<IList<int>>();
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);

        if(root==null)
            return ans;

        while(queue.Count > 0){

            int length=queue.Count;
            
            IList<int> NodesInLevel = new List<int>();
            Console.WriteLine("start");

            for(int i = 0; i < length; i++){

                TreeNode curr = queue.Dequeue();
                Console.WriteLine("curr val: "+curr.val);

                NodesInLevel.Add(curr.val);

                if(curr.left!= null){
                    queue.Enqueue(curr.left);
                    Console.WriteLine("left val: "+curr.left.val);
                }
                
                if(curr.right!=null)
                    queue.Enqueue(curr.right);

            }

         
            ans.Add(NodesInLevel);


        }

        return ans;
    }



}