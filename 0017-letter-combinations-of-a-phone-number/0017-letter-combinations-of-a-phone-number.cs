public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var dict = new Dictionary <char, string> {{'2',"abc"},{'3',"def"},{'4',"ghi"},{'5',"jkl"},{'6',"mno"},{'7',"pqrs"},{'8',"tuv"}, {'9', "wxyz"}};
        var result = new List<string>();
        var digitsToLettersList = new List<string>();

        if(digits.Length == 0)
            return result;

        foreach(var digit in digits){
            digitsToLettersList.Add(dict[digit]);
        }
        
        
        backtrack(digitsToLettersList,0,0, result, digits.Length, new StringBuilder());
        return result;

    }

    public void backtrack(List<string> digitsToLettersList, int currRow, int currCol, List<string> result, int len, StringBuilder currAns){

        if(currRow == digitsToLettersList.Count ){
            result.Add(currAns.ToString());
            return;
        }
        if(currRow > digitsToLettersList.Count - 1 || currCol > digitsToLettersList[currRow].Length - 1)
            return;

        currAns.Append(digitsToLettersList[currRow][currCol]);
        backtrack(digitsToLettersList, currRow+1, 0, result, len, currAns);
        currAns.Remove(currAns.Length - 1,1); 

        backtrack(digitsToLettersList, currRow, currCol+1, result, len, currAns);
        return;


    }
} 