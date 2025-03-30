public class Solution {
    public int MinSteps(string s, string t) {
        var sDict= new Dictionary <char,int>();

        for(int i=0;i<s.Length;i++){
            if(sDict.ContainsKey(s[i]))
                sDict[s[i]]+=1;
            else
                sDict[s[i]]=1;
        }

        for(int i=0;i<s.Length;i++){
            if(sDict.ContainsKey(t[i]))
                sDict[t[i]]-=1;
            else
                sDict[t[i]]=-1;
        }

        int ans=0;
        foreach(var kvp in sDict){
            if(kvp.Value>0)
                ans+=kvp.Value;
        }
        return ans;

    }
}