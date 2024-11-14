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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {

        if(root == null)
            return new List<IList<int>>();;

        var result = new List<IList<int>>();
        var seenCol = new Dictionary<int, List<(int row, int val)>>();
        

        //recurse through the tree and 
        //add val and col to list

        dfs(root, seenCol, 0, 0);

        
        //merge same col values

        var sortedDict = new SortedDictionary<int, List<(int row, int val)>>(seenCol);


        foreach(var kvp in sortedDict){
            
            kvp.Value.Sort((a, b) => a.row == b.row ? a.val.CompareTo(b.val) : a.row.CompareTo(b.row));
            var colList = new List<int>();
            foreach (var item in kvp.Value) {
                colList.Add(item.val);
            }
            result.Add(colList);
    
        }

        return result;

    }

    public void dfs(TreeNode currNode, Dictionary<int, List<(int row, int val)>> seenCol, int colNum , int rowNum){

        if(currNode == null)
            return;

        if(seenCol.ContainsKey(colNum))
            seenCol[colNum].Add((rowNum, currNode.val));
        else
             seenCol.Add(colNum, new List<(int row, int val)> { (rowNum, currNode.val) });
        
        
        dfs(currNode.left, seenCol, colNum-1, rowNum + 1);
        dfs(currNode.right, seenCol, colNum+1, rowNum + 1);
    }


}