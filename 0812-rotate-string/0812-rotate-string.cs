public class Solution {
    public bool RotateString(string s, string goal) {
        string concatnate = s + s;

        if(s.Length != goal.Length) return false;

        if(concatnate.Contains(goal)) return true;
        return false;
    }
}