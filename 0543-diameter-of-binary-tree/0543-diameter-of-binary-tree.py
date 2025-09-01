# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:

        self.diameter = 0

        def getMaxDepth(node):
            if not node:
                return 0

            left = getMaxDepth(node.left)
            right = getMaxDepth(node.right)

            # Diameter is the longest path through this node
            self.diameter = max(self.diameter, left + right)

            # Return depth of the subtree
            return max(left, right) + 1

        getMaxDepth(root)
        return self.diameter

        
   



        
        