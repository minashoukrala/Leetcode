public class Solution {
    public bool Exist(char[][] board, string word) {
      
        for(int row = 0; row < board.Length; row++){
            for(int col = 0; col < board[0].Length; col++){
                if(word[0] == board[row][col] ){
                    var seen = new HashSet<(int x, int y)>();
                    if(dfs(board, row, col, word, 0, seen))
                        return true;
                }
            }
        }
        return false;
    }

    public bool dfs(char[][] board, int row, int col, string word, int wordIndex, HashSet<(int x, int y)> seen){
        if(word.Length == wordIndex){
            return true;
        }

        if(row > board.Length - 1 || row < 0 || col < 0 ||col > board[0].Length - 1 ||
         board[row][col] != word[wordIndex] || seen.Contains((row, col)))
            return false;

        seen.Add((row, col));

        bool found = dfs(board, row + 1, col, word, wordIndex + 1, seen) ||
                 dfs(board, row - 1, col, word, wordIndex + 1, seen) ||
                 dfs(board, row, col + 1, word, wordIndex + 1, seen) ||
                 dfs(board, row, col - 1, word, wordIndex + 1, seen);
                 
        seen.Remove((row, col));

        return found;
        
    }
}