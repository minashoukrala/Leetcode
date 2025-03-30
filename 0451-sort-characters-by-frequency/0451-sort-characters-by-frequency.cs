public class Solution {
    public string FrequencySort(string s) {

        var dict = new Dictionary <char,int>();

        for(int i=0;i<s.Length;i++){
            if(dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict[s[i]]=1;
        }



        var maxHeap = new PriorityQueue<char, int>();

        foreach(var kvp in dict){
            
            maxHeap.Enqueue(kvp.Key,-kvp.Value);
        }

         var ans = new StringBuilder();
        while (maxHeap.Count > 0) {
            char ch = maxHeap.Dequeue();
            int freq = dict[ch];
            ans.Append(ch, freq);
        }

        return ans.ToString();
        
    }
}