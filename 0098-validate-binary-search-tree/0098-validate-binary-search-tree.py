# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:


        return self.dfs(root, 99999999999999999999,-9999999999999999999999)


    def dfs(self, node, maxi, mini):

        if not node:
            return True
        
        if node.val <= mini or node.val >= maxi:
            return False
        
        return self.dfs(node.left, node.val, mini) and self.dfs(node.right, maxi, node.val)


        

            

        

            
        