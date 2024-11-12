public class Solution {
    public int ReachableNodes(int n, int[][] edges, int[] restricted) {
        
        var graph = new Dictionary<int, List<int>>();

        var visited = new HashSet <int>();

        foreach(var edge in edges){
            if(!graph.ContainsKey(edge[0])){
                graph.Add(edge[0], new List<int>());
            }
            if(!graph.ContainsKey(edge[1])){
                graph.Add(edge[1], new List<int>());
            }
            graph[edge[0]].Add( edge[1]);
            graph[edge[1]].Add( edge[0]);
        }

        foreach(int neigh in restricted){
            visited.Add(neigh);
        }
        int counter = 0;
        dfs(graph, visited, 0, ref counter);
        return counter;


    }

    public void dfs(Dictionary<int,List<int>> graph, HashSet<int> visited,int node,ref int counter){

        foreach(var neigh in graph[node]){
            if(!visited.Contains(neigh)){
                visited.Add(neigh);
                counter++;
                dfs(graph, visited, neigh,ref counter);
            }
        }
    }
}