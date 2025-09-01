# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

from collections import deque
class Solution:
    def zigzagLevelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:

        if not root:
            return []

        ans = []
        self.formTheAnswer(root,ans)
        return ans
    
    def formTheAnswer(self, node, ans):

        q = deque([node])
        left = False


        while q:
            l = []

            for _ in range(len(q)):
                if left:
                    currNode = q.pop()
                    if currNode.right:
                        q.appendleft(currNode.right)
                    if currNode.left:
                        q.appendleft(currNode.left)
                    
                    
                else:
                    currNode = q.popleft()
                    if currNode.left:
                        q.append(currNode.left)
                    if currNode.right:
                        q.append(currNode.right)

                l.append(currNode.val)

            ans.append(l)
            left = not left
        return
        


            









        