# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
from collections import deque

class Solution:
    def deepestLeavesSum(self, root: Optional[TreeNode]) -> int:

        if not root:
            return 0
        return self.bfs(root)
        
    
    def bfs(self, node):

        
        q = deque([node])


        while q:
            sumOfLevel = 0

            for i in range(len(q)):
                
                currNode = q.popleft()
                if currNode.left:
                    q.append(currNode.left)
                if currNode.right:
                    q.append(currNode.right)
                
                sumOfLevel += currNode.val

        return sumOfLevel
            
            


    









            

        