public class Solution {
    public string ReverseWords(string s) {
        
     
        string[] words = s.Split( ' ' );

        Array.Reverse(words);

        StringBuilder result = new StringBuilder();
        foreach(var word in words){
            Console.WriteLine(word);
            if(word.Trim() != "")
            { 
                Console.WriteLine("inside");
                result.Append(word); 
                result.Append(" ");
            }
        }
        return result.ToString().Trim();


        }
    }
