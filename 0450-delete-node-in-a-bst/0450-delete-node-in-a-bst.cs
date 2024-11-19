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
    public TreeNode DeleteNode(TreeNode root, int key) {
         if (root == null) return null;

        // Traverse the tree to find the node to delete
        if (key < root.val) {
            root.left = DeleteNode(root.left, key);
        } else if (key > root.val) {
            root.right = DeleteNode(root.right, key);
        } else {
            // Node to delete found
            if (root.left == null) return root.right; // Replace with right child if left is null
            if (root.right == null) return root.left; // Replace with left child if right is null

            // Node has two children: Find the minimum value in the right subtree
            TreeNode minNode = findMin(root.right);
            root.val = minNode.val; // Replace current node's value with the min value
            root.right = DeleteNode(root.right, minNode.val); // Delete the duplicate
        }

        return root;
            
        
    }



     private TreeNode findMin(TreeNode node) {
        while (node.left != null) {
            node = node.left;
        }
        return node;
    }
}