public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        
        var neighbors = new Dictionary<int,List<int>>();
        var seen = new bool[n];

        if(n == 1) return source == destination;

        foreach(var edge in edges){

            if(!neighbors.ContainsKey(edge[0])) 
                neighbors[edge[0]] = new List<int>();

            neighbors[edge[0]].Add(edge[1]);

            if(!neighbors.ContainsKey(edge[1])) 
                neighbors[edge[1]] = new List<int>();

            neighbors[edge[1]].Add(edge[0]);
            

        }


        return dfs(neighbors, seen, source, destination);

    }

    public bool dfs(Dictionary<int,List<int>> neighbors, bool[] seen, int currNode, int destination){

            if(currNode == destination) return true;


            if(!seen[currNode]){
                seen[currNode] = true;
                foreach(var next in neighbors[currNode]){
                    if(dfs(neighbors, seen, next, destination))
                        return true;
                }
            }
            return false;

        }
}
