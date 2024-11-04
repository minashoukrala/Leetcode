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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {

        Queue<TreeNode> queue=new Queue<TreeNode>();
        IList<IList<int>> ans=new List<IList<int>>();
        bool left=false;

        if(root==null)
            return ans;

        queue.Enqueue(root);

        while(queue.Count>0){
            IList<int> currLevel=new List<int>();
            int Length=queue.Count;

            for(int i=0;i<Length;i++){

                TreeNode currNode = queue.Dequeue();
                currLevel.Add(currNode.val);
                if(left){
                    if(currNode.left!=null)
                        queue.Enqueue(currNode.left);
                    if(currNode.right!= null)
                        queue.Enqueue(currNode.right);
                    
                }
                else{
                    if(currNode.right!= null)
                        queue.Enqueue(currNode.right);
                    if(currNode.left!=null)
                        queue.Enqueue(currNode.left);
                    
                }
            }
                left=!left;

            ans.Add(new List<int> (currLevel));
        }

    
    return ans;



    }
}