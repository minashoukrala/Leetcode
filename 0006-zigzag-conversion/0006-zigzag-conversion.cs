public class Solution {
    public string Convert(string s, int numRows) {
        
        var strings = new List<StringBuilder>();
        for(int i = 0; i < numRows; i++){
            strings.Add(new StringBuilder());
        }

       int index = 0;
       bool up = false;
       foreach(var c  in s){
        Console.WriteLine(index);
            strings[index].Append(c);
            if(index == 0){
                up = false;
            }
            if(index == numRows - 1){
                up = true;
            }
            if(up)
                index--;
            else
                index++;

            
       }
       StringBuilder ans = new StringBuilder();
       
       foreach(var x in strings){
        ans.Append(x);
       }
       return ans.ToString();
    }

}