public class WordDictionary {

    class Node {
        public Dictionary<char, Node> next = new();
        public bool isWord;
    }

    Node root = new();
    
    public void AddWord(string word) {
        var node = root;

        foreach(var c in word)
        {
            node = node.next.TryGetValue(c, out var n) ? n : (node.next[c] = new Node());
        }

        node.isWord = true;
    }
    
    public bool Search(string word) => DFS(word, 0, root);

    bool DFS(string w, int i, Node node)
    {
        if (i == w.Length)
            return node.isWord;

        if (w[i] == '.')
        {
            foreach (var child in node.next.Values)
            {
                if (DFS(w, i + 1, child))
                    return true;
            }
            return false;
        }

        return node.next.TryGetValue(w[i], out var next) && DFS(w, i + 1, next);
    }
}
