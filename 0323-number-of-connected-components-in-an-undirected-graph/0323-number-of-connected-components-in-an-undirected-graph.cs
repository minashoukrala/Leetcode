public class Solution {
    public int CountComponents(int n, int[][] edges) {
        
        var seen = new HashSet<int>();
        var graph = new Dictionary<int, List<int>>();
        int counter = 0;

        foreach(var edge in edges){
            if(!graph.ContainsKey(edge[0])) graph[edge[0]]= new List<int>();
            if(!graph.ContainsKey(edge[1])) graph[edge[1]]= new List<int>();

            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        foreach(var kvp in graph){
            if(!seen.Contains(kvp.Key)){ 
                counter++;
                dfs(graph, seen, ref counter, kvp.Key);
            }
        }
        return counter;
    }


    public void dfs(Dictionary<int, List<int>> graph, HashSet<int> seen, ref int counter, int key){
            if(!seen.Contains(key)){ 
                seen.Add(key);
                Console.WriteLine(key);
                foreach(var neighbor in graph[key]){
                    dfs(graph, seen, ref counter, neighbor);
                }  
            }   
            return;  
    }
}