# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def lowestCommonAncestor(self, root: 'TreeNode', p: 'TreeNode', q: 'TreeNode') -> 'TreeNode':
        parent = {}
        parent[root] = (None, 0)
        self.setParents(root, parent, 0)


    
        while p != None and q != None:
            if p == q:
                return p
            (pParent, pLevel) = parent[p]
            (qParent, qLevel) = parent[q]

            if pLevel > qLevel:
                p = pParent

            elif pLevel < qLevel:
                q = qParent
            
            else:
                q = qParent
                p = pParent
                

    def setParents(self, node, parent, level):

        if not node:
            return
        
        if node.left:
            parent[node.left] = (node, level + 1)
            self.setParents(node.left, parent, level + 1)
        
        if node.right:
            parent[node.right] = (node, level + 1)
            self.setParents(node.right, parent, level + 1)

        return

        
