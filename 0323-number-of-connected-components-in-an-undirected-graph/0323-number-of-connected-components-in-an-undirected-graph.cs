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

        for(int i = 0; i < n; i++){
            if(!seen.Contains(i)){ 
                counter++;
                if(graph.ContainsKey(i))
                    dfs(graph, seen, i);
            }
        }
        return counter;
    }


    public void dfs(Dictionary<int, List<int>> graph, HashSet<int> seen, int key){
          
                seen.Add(key);
                foreach(var neighbor in graph[key]){
                    if(!seen.Contains(neighbor))
                        dfs(graph, seen, neighbor);
                }  
            
            return;  
    }
}