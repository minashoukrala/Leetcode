

public class Solution {
    public string MakeGood(string s) {

        StringBuilder result = new StringBuilder();
        Stack<char> stack = new Stack<char>();


        foreach(char c in s){
            if(stack.Count > 0){
                if(Math.Abs(c - stack.Peek()) == 32) {stack.Pop(); continue;}
            }
            stack.Push(c);
        }

        while(stack.Count > 0){
            result.Insert(0,stack.Pop());
        }


        return result.ToString();
    }
}