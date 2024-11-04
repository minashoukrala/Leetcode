using System.Collections;
public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> MyPath=new Stack<string>();
        string[] words = path.Split('/');
        StringBuilder result = new StringBuilder();

        foreach(var s in words){
            
            if(s == "..") {if(MyPath.Count > 0) MyPath.Pop();}
            else if(s == "." || s == "") continue;
            else MyPath.Push(s);
        }


        while(MyPath.Count > 0){

            result.Insert(0, MyPath.Pop());
            result.Insert(0,"/");

        }

        if(result.Length == 0)return "/";

        return result.ToString();
        
    }
}