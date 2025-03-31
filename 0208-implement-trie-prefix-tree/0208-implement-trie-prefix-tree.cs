
public class Node{
    public Dictionary<char, Node> children;
    public char character;
    public bool endOfWord;

    public Node(char c){
        children = new Dictionary<char, Node>();
        character = c;
        endOfWord = false;
    }
}

public class Trie {

    public Node _trieRoot;

    public Trie() {

        _trieRoot = new Node('.');

    }
    
    public void Insert(string word) {
        var currNode = this._trieRoot;
        foreach(var c in word){
            if(currNode.children.ContainsKey(c)){
            }
            else{
                currNode.children.Add(c,new Node(c));
            }
            currNode = currNode.children[c];
        }
        currNode.endOfWord = true;
        
    }
    
    public bool Search(string word) {
        var currNode = this._trieRoot;
        foreach(var c in word){

            if(currNode.children.ContainsKey(c)){
                currNode = currNode.children[c];
            }

            else 
                return false;
        }
        if(currNode.endOfWord)
            return true;
        return false;
    }
    
    public bool StartsWith(string prefix) {
        var currNode = this._trieRoot;
        foreach(var c in prefix){

            if(currNode.children.ContainsKey(c)){
                currNode = currNode.children[c];
            }

            else 
                return false;
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */